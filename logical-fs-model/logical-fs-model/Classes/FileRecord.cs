using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Classes
{
    public class FileRecord
    {
        string Name { get; set; }
        byte TypeOfFile { get; set; }
        int FirstClusterAddr { get; set; }
        int FileSize { get; set; }
        public FileRecord(string Name, int FirstCluster, int Size, byte TypeOfFile = 0)
        {
            this.Name = Name;
            this.TypeOfFile = TypeOfFile;
            this.FirstClusterAddr = FirstCluster;
            this.FileSize = Size;
        }

        public byte[] Serialize()
        {
            List<byte> data = new List<byte>();
            for (int i = 0; i < 23; i++)
            {
                if (i < Name.Length)
                    data.Add((byte)Name[i]);
                else
                    data.Add((byte)(' '));
            }
        
           
            data.Add(TypeOfFile);
            data.AddRange(BitConverter.GetBytes(FirstClusterAddr));
            data.AddRange(BitConverter.GetBytes(FileSize));
            return data.ToArray();
        }
        public static FileRecord Deserialize(byte[] data)
        {
            if (data.Length != 32) return null;
            byte[] name = new byte[23];
            byte[] fdc = new byte[4];
            byte[] size = new byte[4];
            
            for (int i = 0; i < 23; i++)
            {
                name[i] = data[i];
            }
            byte type = data[23];
            for (int i = 0; i < 4; i++)
            {
                fdc[i] = data[24 + i];
            }
            for (int i = 0; i < 4; i++)
            {
                size[i] = data[28 + i];
            }
            string Name = BitConverter.ToString(name);
            int FirstDC = BitConverter.ToInt32(fdc,0);
            int Size = BitConverter.ToInt32(size,0);

            return new FileRecord(Name, FirstDC, Size, type);
        }


    }
}
