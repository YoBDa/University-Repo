using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Classes
{
    public class Cluster
    {
        public int Size { get => Data.Length; }
        public byte[] Data; 
        public byte State { get; set; }
        // 0 - free
        // 1 - busy not last
        // 2 - busy last
        public int NextCluster { get; set; }

        public Cluster(int Size)
        {
            Data = new byte[Size];
            State = 0;
            NextCluster = 0; // if last then 0xFFFFFFF or  268 435 455
        }
    }
}
