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
        public List<Process> Processes { get; private set; }
        private int Id;
        public IScheduler Scheduler { get; set; }
        public ProcessManager(IScheduler scheduler)
        {
            Processes = new List<Process>();
            Scheduler = scheduler;
        }
        public int ProcessCount { get { return Processes.Count; } }
        public void Tick()
        {
            foreach (Process proc in Processes)
            {
                if (proc.State == ProcessState.Zombie || (proc.TimeResource - proc.TimeUsed) < 1) { proc.State = ProcessState.Zombie; continue; }
                if (proc.State == ProcessState.Ready) { proc.CurrentPriority++; continue; }
                if (proc.State == ProcessState.Waiting) { proc.TicksToReady--; continue; }
                if (proc.State == ProcessState.Waiting && proc.TicksToReady < 1) { proc.State = ProcessState.Ready; continue; }
                if (proc.State == ProcessState.Active) //select what will do the process
                {
                    if (proc.TimeResource - proc.TimeUsed < 1) { proc.State = ProcessState.Zombie; continue; }
                    Random rnd = new Random();
                    int selector = rnd.Next(0, 100);
                    if (selector < 20) { proc.State = ProcessState.Waiting; proc.TicksToReady = rnd.Next(1, 5); }
                    else proc.State = ProcessState.Ready;
                }
                
            }
                
            
            Process active = Scheduler.GetNextActive(Processes); 
            if (active == null || active.State == ProcessState.Zombie || active.State == ProcessState.Waiting || active.State == ProcessState.Active) return;
            active.Go();
            active.CurrentPriority = active.SelfPriority;
            active.State = ProcessState.Active;
        }

        public void AddProcess(string Name, int Priority, int TimeResource)
        {
            Processes.Add(new Process(Priority, Id, Name, TimeResource));
            Id++;
        }
    }
}
