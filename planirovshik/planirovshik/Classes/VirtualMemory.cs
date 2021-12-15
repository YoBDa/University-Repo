using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planirovshik.Classes
{
    public class VirtualMemory
    {
        RandomAccessMemory RAM;
        public int Size { get; private set; }
        public List<Process> Cells;
        public VirtualMemory(int Size, RandomAccessMemory RAM)
        {
            this.Size = Size;
            Cells = new List<Process>();
            this.RAM = RAM;

        }
        public int CellsFree
        {
            get => Size - Cells.Count;
        }
        public bool Swap(Process process)
        {
            if (process.RealOrVirtual)
            {
                RAM.Unallocate(process);
                this.Allocate(process);
                process.RealOrVirtual = false;
                return true;
            }
            else
            {
                this.Unallocate(process);
                RAM.Allocate(process);
                process.RealOrVirtual = true;
                return true;
            }
            
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
