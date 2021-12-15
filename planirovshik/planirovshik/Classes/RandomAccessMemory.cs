using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planirovshik.Classes
{
    public class RandomAccessMemory
    {
        public int Size { get; private set; }
        public List<Process> Cells;
        public RandomAccessMemory(int Size)
        {
            Cells = new List<Process>();
            this.Size = Size;
        }
        public int CellsFree
        {
            get => Size - Cells.Count; 
        }
        public bool Unallocate(Process proc)
        {
            return Cells.Remove(proc);
        }
        public void Allocate(Process process)
        {
            if (Cells.Count >= Size) return;
            Cells.Add(process);
        }

        public int[] GetAddressArray()
        {
            int[] Addresses = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Addresses[i] = i;
            }
            return Addresses;
        }

    }
}
