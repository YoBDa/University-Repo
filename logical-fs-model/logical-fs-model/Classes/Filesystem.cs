using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Classes
{


    public struct Fat
    {
        private int[] Clusters;
        public int Length { get => Clusters.Length; }
        public int this[int index]
        {
            get => Clusters[index];
            set => Clusters[index] = value;
        }

        public void MarkAsBusy(int index, int next)
        {
            Clusters[index] = next;
        }
        public void MarkAsLast(int index)
        {
            Clusters[index] = 0xFFFF;
        }
        public void MarkAsFree(int index)
        {
            Clusters[index] = 0x0;
        }
        public Fat(int FatSize) //in clusters
        {
            Clusters = new int[FatSize];
        }
        public int GetFirstFree()
        {
            for (int index = 0; index < Clusters.Length; index++)
            {
                if (Clusters[index] == 0x0) return index;
            }
            throw new Exception("Lack of free memory.");
        }
        public int GetFreeCount()
        {
            int counter = 0;

            for (int index = 0; index < Clusters.Length; index++)
            {
                if (Clusters[index] == 0x0) counter++;
            }
            return counter;
        }

        public bool IsLast(int index)
        {
            return Clusters[index] == 0xFFFF;
        }
        public void RemoveChain(int index)
        {
            while (!IsLast(index))
            {
                int tmp = Clusters[index];
                MarkAsFree(index);
                index = tmp;
            }
            MarkAsFree(index);
        }
        
    }

    //agree that:
    //drive[0-3] = contains size of fat table (typ 1024*128 bytes)
    //drive[fatSize+4] = first data address
    //any directory contains 32-byte length records describing files contains there
    //if record begins with 0xE5 - file deleted, 0x00 previous file was last, else - common file
    //file record + 0x1A - is first data cluster
    public class Filesystem
    {
        public Fat fat;
        public nDrive drive;
        private int fatSize;
        private int fatOffset = 16;
        private int sectorSize = 1; //byte
        public int FirstDataClusterAddress;
        private int fatPointerSize = 4;//byte
        public Filesystem(int ClustersCount, int ClusterSize = 32 * 1024)
        {
            this.ClusterSize = ClusterSize;
            this.ClustersCount = ClustersCount;


            fatSize = fatPointerSize * ClustersCount;
            FirstDataClusterAddress = fatSize + fatOffset;
            int DriveSize = fatOffset + fatSize + (ClusterSize * ClustersCount);
            drive = new nDrive(DriveSize);
            //writing fat to drive
            byte[] FatSizeArray = BitConverter.GetBytes(fatSize);
            for (int i = 0; i < 3; i++)
            {
                drive[i] = FatSizeArray[i];
            }
            fat = new Fat(fatSize / 4);

            for (int i = 0; i < ClusterSize; i += 32)
            {

                int addr = FirstDataClusterAddress + i;
                drive[addr] = 0xE5;
            }
            fat.MarkAsLast(0);

            WriteFat();




            //FileRecord fr = new FileRecord("", FirstDataClusterAddress, 0, 1);


        }
        public void FillDirectoryCluster(int index)
        {
            for (int i = 0; i < ClusterSize; i += 32)
            {

                int addr = FirstDataClusterAddress + (ClusterSize * index) + i;
                drive[addr] = 0xE5;
            }
        }

        private void WriteFat()
        {
            int counter = 0;
            for (int i = 0; i < fat.Length; i++)
            {
                if (counter >= fatSize) break;
                byte[] cluster = BitConverter.GetBytes(fat[i]);
                for (int j = 0; j < 4; j++)
                {
                    drive[counter + fatOffset] = cluster[j];
                    counter++;
                }

            }
        }

        private void ReadFat()
        {
            int counter = 0;
            for (int i = 0; i < fat.Length; i++)
            {
                if (counter >= fatSize) break;
                byte[] cluster = new byte[4];
                for (int j = 0; j < 4; j++)
                {
                    cluster[j] = drive[counter + fatOffset];
                    counter++;
                }

            }
        }
        public int ClusterSize { get; }

        public int ClustersCount { get; }

        public int TotalSpace { get => ClustersCount * ClusterSize; }
        public int FreeSpace { get => FreeClusters * ClusterSize; }
        private int FreeClusters { get => fat.GetFreeCount(); }

        public int AddFileRecord(FileRecord fl, int DirectoryIndex = 0)
        {

            try
            {
                //search for last directory cluster
                while (!fat.IsLast(DirectoryIndex))
                {
                    DirectoryIndex = fat[DirectoryIndex];
                }

                //search for last filerecord in directory data
                int offset = 0;

                while (drive[FirstDataClusterAddress + ClusterSize * (DirectoryIndex) + offset] != 0xE5)
                {
                    if (offset < ClusterSize)
                        offset += 32;
                    else
                    {

                        int index = fat.GetFirstFree();


                        fat.MarkAsBusy(DirectoryIndex, index);
                        fat.MarkAsLast(index);
                        FillDirectoryCluster(index);
                        DirectoryIndex = index;
                    }
                }
                byte[] recBytes = fl.Serialize();
                for (int i = 0; i < 32; i++)
                {
                    drive[FirstDataClusterAddress + ClusterSize * (DirectoryIndex) + (offset - offset/ClusterSize) + i] = recBytes[i];
                }
                WriteFat();

                return offset / 32;
            }
            catch
            {
                //ReadFat();
                return -1;
            }
        }
        public int EditFileRecord(int DirectoryIndex)
        {
            throw new Exception();
            
        }

        public bool CreateFile(nItem file, int inDirectory)
        {
            try
            {
                int index = fat.GetFirstFree();
                int fdc = index;

                if (file is nFile)
                {
                    string test = $"Filesystem integrity check. This file has name {file.Name}";
                    byte[] bytes = Encoding.ASCII.GetBytes(test);
                    List<byte> data = new List<byte>();
                    data.AddRange(bytes);
                    data.AddRange((new byte[ClusterSize * 4]));
                    data.AddRange(bytes);

                    file.Size = data.Count;
                    FileRecord record = new FileRecord(file.Name, fdc, file.Size, 0);

                    int clustersNeed = (int)Math.Ceiling((float)file.Size / ClusterSize);
                    if (FreeClusters < clustersNeed) return false;


                    int counter = 0;
                    for (int i = 0; i < clustersNeed; i++)
                    {
                        for (int j = 0; j < ClusterSize; j++)
                        {
                            if (counter >= data.Count) break;
                            int addr = FirstDataClusterAddress + ClusterSize * index + j;
                            drive[addr] = data[counter];
                            counter++;
                        }


                        int prevIndex = index;
                        index = fat.GetFirstFree();
                        fat.MarkAsBusy(prevIndex, index);
                        fat.MarkAsLast(index);
                    }
                    int offset = AddFileRecord(record, inDirectory);
                    if (offset == -1)
                    {
                        //ReadFat();
                        return false;
                    }
                    file.FilerecordOffset = offset;
                }
                else
                {
                    FileRecord record = new FileRecord(file.Name, fdc, file.Size, 1);
                    int clustersNeed = 1;
                    if (FreeClusters < clustersNeed) return false;
                    FillDirectoryCluster(index);
                    fat.MarkAsLast(index);
                    int offset = AddFileRecord(record, inDirectory);
                    if (offset == -1)
                    {
                        //ReadFat();
                        return false;
                    }
                    file.FilerecordOffset = offset;
                }
                file.FirstDataCluster = fdc;
                WriteFat();
                return true;
            }
            catch (Exception)
            {
                //ReadFat();
                return false;
            }




        }

        public bool RemoveFile(nItem file)
        {

            fat.RemoveChain(file.FirstDataCluster);
            int FilerecordAddr = FirstDataClusterAddress + file.Parent.FirstDataCluster * ClusterSize + file.FilerecordOffset;
            drive[FilerecordAddr] = 0xE5;
            return true;

        }

        public bool MoveFile(nItem file, int WhereIndex)
        {
            file.
        }

    }


}
