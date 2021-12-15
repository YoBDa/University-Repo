using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using planirovshik.Interfaces;
namespace planirovshik.Classes
{
    
    public class ProcessManager
    {
        public Exception NoFreeMemoryException = new Exception("Lack of free memory");
        private VirtualMemory VirtualMemory;
        private RandomAccessMemory RealMemory;

        public double FreeRAM
        {
            get
            {
                return (double)RealMemory.CellsFree / RealMemory.Size;
            }
        }
        public double FreeVRAM
        {
            get
            {
                return (double)VirtualMemory.CellsFree / VirtualMemory.Size;
            }
        }
        public List<Process> Processes { get; private set; }
        private int Id;
        public IScheduler Scheduler { get; set; }
        public ProcessManager(IScheduler scheduler)
        {
            int RealMemorySize = 10;
            Processes = new List<Process>();
            Scheduler = scheduler;
            RealMemory = new RandomAccessMemory(RealMemorySize);
            VirtualMemory = new VirtualMemory(RealMemorySize * 2, RealMemory);
            
        }
        public int ProcessCount { get { return Processes.Count; } }
        public void Tick()
        {
            foreach (Process proc in Processes)
            {

                if (proc.State == ProcessState.Zombie)
                {
                    continue;
                }
                
                if ((proc.TimeResource - proc.TimeUsed) < 1) 
                {
                    proc.State = ProcessState.Zombie;
                    continue; 
                }
                if (proc.State == ProcessState.Ready) { proc.CurrentPriority++; continue; }
                if (proc.State == ProcessState.Waiting && proc.TicksToReady < 1) { proc.State = ProcessState.Ready; continue; }
                if (proc.State == ProcessState.Waiting) { proc.TicksToReady--; continue; }
                
                if (proc.State == ProcessState.Active) //select what will do the process
                {
                    if (proc.TimeResource - proc.TimeUsed < 1) { proc.State = ProcessState.Zombie; continue; }
                    Random rnd = new Random();
                    int selector = rnd.Next(0, 100);
                    if (selector < 20) { proc.State = ProcessState.Waiting; proc.TicksToReady = rnd.Next(1, 5); }
                    else proc.State = ProcessState.Ready;
                }
                
            }
            foreach (Process pr in Processes.FindAll(p => p.State == ProcessState.Zombie))
            {
                VirtualMemory.Unallocate(pr);
                RealMemory.Unallocate(pr);
            }
            Processes.RemoveAll(p => p.State == ProcessState.Zombie); // clearing 

            Process active = Scheduler.GetNextActive(Processes); 
            if (active == null || active.State == ProcessState.Zombie || active.State == ProcessState.Waiting || active.State == ProcessState.Active) return;

            if (FreeRAM < 0.1)
                ReleaseMemory();

            if (!active.RealOrVirtual) VirtualMemory.Swap(active);

            active.Go();
            active.CurrentPriority = active.SelfPriority;
            active.State = ProcessState.Active;
        }

        private void ReleaseMemory()
        {
            foreach (Process pr in Processes.FindAll(p => p.State == ProcessState.Zombie))
            {
                VirtualMemory.Unallocate(pr);
                RealMemory.Unallocate(pr);
            }
            Processes.RemoveAll(p => p.State == ProcessState.Zombie); // clearing 
            if (FreeVRAM == 0) return;


            List<Process> Swapable = (from process in Processes
                                     where process.RealOrVirtual && (process.State == ProcessState.Waiting || process.State == ProcessState.Ready)
                                     select process).ToList();

            foreach (Process process in Swapable)
            {
                if (FreeRAM < 0.3)
                {
                    if (FreeVRAM > 0)
                        VirtualMemory.Swap(process);
                    else return;
                }
                else return;

            }
            
        }
        public void AddProcess(string Name, int Priority, int TimeResource)
        {
            if (FreeRAM == 0)
                if (FreeVRAM > 0) { ReleaseMemory(); }
                else throw NoFreeMemoryException;

            Process p = new Process(Priority, Id, Name, TimeResource);
            Processes.Add(p);
            RealMemory.Allocate(p);
            p.RealOrVirtual = true;

            Id++;
        }
    }
}
