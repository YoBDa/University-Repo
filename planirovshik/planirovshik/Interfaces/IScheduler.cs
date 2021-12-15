using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using planirovshik.Classes;

namespace planirovshik.Interfaces
{
    public interface IScheduler
    {
        Process GetNextActive(List<Process> Processes);
    }
}
