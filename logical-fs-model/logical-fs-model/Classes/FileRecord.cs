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


    }
}
