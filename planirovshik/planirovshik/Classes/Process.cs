using System;
using System.Collections.Generic;
using System.Text;

namespace planirovshik.Classes
{
    public enum ProcessState { Ready, Active, Waiting, Zombie }
    public class Process
    {
        public int SelfPriority { get; set; }
        
        public int TimeResource { get; set; }
        public int CurrentPriority { get; set; }
        public ProcessState State { get; set; }
        public int Id { get; internal set; }
        public string Name { get; set; }
        public int TimeUsed { get; set; }
        public int TicksToReady { get; set; }
        
        public void Go()
        {
            TimeUsed++;
        }


        public Process(int Priority, int Id, string Name, int TimeResource)
        {
            this.SelfPriority = Priority;
            this.Id = Id;
            this.Name = Name;
            this.TimeResource = TimeResource;
        }


    }
}
