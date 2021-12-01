using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Classes
{
    public class Filesystem
    {
        public Filesystem(int ClusterSize, int ClustersCount)
        {
            if (ClusterSize < 1024) throw new Exception("Invalid cluster size");
            this.ClusterSize = ClusterSize;
            this.ClustersCount = ClustersCount;
            Fat = new List<Cluster>();
            for (int i = 0; i < ClustersCount; i++)
            {
                Fat[i] = new Cluster(ClusterSize);
            }
            FileRecord fr = new FileRecord("", 0, 0, 1);
            Fat[0].State = 2;
            

        }
        public int ClusterSize { get; private set; }
        
        public int ClustersCount { get; private set; }

        public int TotalSpace { get => ClustersCount * ClusterSize; }
        public int FreeSpace { get => FreeClusters * ClusterSize; }
        private int FreeClusters { get => Fat.FindAll(c=>c.State==0).Count; }
    

        public List<Cluster> Fat { get; }
        private int IndexOfFirstFreeCluster()
        {
            return Fat.IndexOf(Fat.Find(c => c.State == 0));
        }
        public bool AddFileRecord(FileRecord fl, int DirectoryIndex = 0)
        {
            
        }

        public bool CreateFile(nItem file, int inDirectory)
        {
            
            int index = IndexOfFirstFreeCluster();

            if (file is nFile)
            {
                FileRecord record = new FileRecord(file.Name, IndexOfFirstFreeCluster(), file.Size, 0);
                List<byte> data = new List<byte>();
                int clustersNeed = (int)(file.Size / ClusterSize + 1);
                if (FreeClusters < clustersNeed) return false;
                data.AddRange(new byte[file.Size]);
                int looper = 0;
                for (int i = 0; i < clustersNeed; i++)
                {
                    if (looper > ClusterSize)
                    {
                        looper = 0;
                        int prevIndex = index;
                        index = IndexOfFirstFreeCluster();
                        Fat[prevIndex].NextCluster = index;
                    }
                    Fat[index].State = 1;
                    Fat[index].Data[looper] = data[i];
                    looper++;
                    if (i == clustersNeed - 1) Fat[index].State = 2;

                }
                return true;
            }
            else
            {
                FileRecord record = new FileRecord(file.Name,IndexOfFirstFreeCluster(), 0, 1);
                List<byte> data = new List<byte>();
                data.AddRange(record.Serialize());
                int clustersNeed = (int)((data.Count + file.Size) / ClusterSize + 1);
                if (FreeClusters < clustersNeed) return false;

            }
                return true;


            }

        }

        

    }
}
