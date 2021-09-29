using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using planirovshik.Interfaces;

namespace planirovshik.Classes
{
    class PriorityScheduler : IScheduler
    {
        public Process GetNextActive(List<Process> Processes)
        {
            if (Processes.Count == 0) return null;
            List<Process> Ready = Processes.FindAll(proc => proc.State == ProcessState.Ready);
            if (Ready.Count == 1) return Ready[0];
            if (Ready.Count == 0) return null;
            return Ready.Find(proc => proc.CurrentPriority == Ready.Max(pr => pr.CurrentPriority));
        }

    }
}
