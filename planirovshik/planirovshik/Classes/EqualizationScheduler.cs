using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using planirovshik.Interfaces;

namespace planirovshik.Classes
{
    class EqualizationScheduler : IScheduler
    {

        public Process GetNextActive(List<Process> Processes)
        {
            if (Processes.Count == 0) return null;
            List<Process> Ready = Processes.FindAll(proc => proc.State == ProcessState.Ready);
            if (Ready.Count == 0) return null;
            if (Ready.Count == 1) return Processes[0];
            return Ready.Find(p => p.TimeUsed == Ready.Min(pr => pr.TimeUsed));
        }
    }
}
