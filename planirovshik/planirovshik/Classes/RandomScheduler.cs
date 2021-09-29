using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using planirovshik.Interfaces;

namespace planirovshik.Classes
{
    class RandomScheduler : IScheduler
    {
        public Process GetNextActive(List<Process> Processes)
        {
            if (Processes.Count == 0) return null;
            List<Process> Ready = Processes.FindAll(proc => proc.State == ProcessState.Ready);
            if (Ready.Count == 0) return null;
            if (Ready.Count == 1) return Ready[0];
            Random rnd = new Random();
            return Ready[rnd.Next(0, Ready.Count)];
            
        }
    }
}
