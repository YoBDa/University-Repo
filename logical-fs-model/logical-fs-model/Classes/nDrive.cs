using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Classes
{
    public class nDrive
    {

        private byte[] Data;
        public int Size { get => Data.Length; }
        public nDrive()
        {
            Data = new byte[1024*1024]; //default 1MB size
        }
        public byte this[int index]
        {
            get
            {
                return Data[index];
            }
            set
            {
                Data[index] = value;
            }
        }
        public nDrive(int Size)
        {
            Data = new byte[Size];
        }
    }
}
