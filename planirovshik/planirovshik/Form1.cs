using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using planirovshik.Classes;
using planirovshik.Interfaces;
using static System.Timers.Timer;

namespace planirovshik
{
    public partial class Form1 : Form
    {
        int ExecSpeed = 1; //tick per sercond
        long TicksCount = 0;
        bool State = false; // false - stopped, true - started
        System.Timers.Timer T;
        ProcessManager ProcessManager;
        Random rnd = new Random((int)DateTime.Now.Ticks);

       
        public Form1()
        {
            InitializeComponent();
            cbSchedulers.Items.Add("Priority");
            cbSchedulers.Items.Add("Random");
            cbSchedulers.Items.Add("Equalization");
            cbSchedulers.SelectedIndex = 0;

            T = new System.Timers.Timer(1000 / ExecSpeed);
            T.Elapsed += T_Tick;
            ProcessManager = new ProcessManager(new PriorityScheduler());

            this.DoubleBuffered = false;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        private void T_Tick(object sender, EventArgs e)
        {
            ProcessManager.Tick();
            TicksCount++;
            Draw();
        }
        private void Draw()
        {
            List<ListViewItem> ProcList = new List<ListViewItem>();
            foreach (Process pr in ProcessManager.Processes)
            {
                string[] Subitems =
                {
                    pr.Name,
                    pr.Id.ToString(),
                    pr.SelfPriority.ToString(),
                    pr.CurrentPriority.ToString(),
                    pr.TimeUsed.ToString(),
                    pr.State.ToString(),
                    pr.TicksToReady.ToString(),
                    (pr.TimeResource - pr.TimeUsed).ToString()
                };

                ListViewItem LVI = new ListViewItem(Subitems);
                
                LVI.Selected = pr.State == ProcessState.Active;
                ProcList.Add(LVI);
            }
            if (labTicks.InvokeRequired) labTicks.Invoke(new MethodInvoker(delegate { labTicks.Text = TicksCount.ToString(); }));
            if (lvProcesses.InvokeRequired)
            {
                lvProcesses.Invoke(new MethodInvoker(delegate { lvProcesses.Items.Clear(); }));
                lvProcesses.Invoke(new MethodInvoker(delegate { lvProcesses.Items.AddRange(ProcList.ToArray()); }));
            }
            else
            {
                lvProcesses.Items.Clear();
                lvProcesses.Items.AddRange(ProcList.ToArray());
            }
            

        }
        private void AddProcess(string Name, int Priority)
        {
            
            ProcessManager.AddProcess(Name, Priority, rnd.Next(1, 50));
        }

        private void btStartStop_Click(object sender, EventArgs e)
        {
            if (State)
            {
                T.Stop();
                btStartStop.Text = "Start";
                State = false;
            }
            else if (!State && ProcessManager.ProcessCount != 0)
            {
                T.Start();
                btStartStop.Text = "Stop";
                State = true;
            }   
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddProcess(tbName.Text, (int)nudPriority.Value);
        }

       
        private void btInit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                AddProcess($"pr_{i}", rnd.Next(1, 11));
            }
            Draw();
            
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            T.Stop();
            btStartStop.Text = "Start";
            State = false;
            ProcessManager.Processes.Clear();
            Draw();
        }

        private void cbSchedulers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProcessManager == null) return;
            switch (cbSchedulers.Text)
            {
                case "Equalization":
                    ProcessManager.Scheduler = new EqualizationScheduler();
                    break;
                case "Random":
                    ProcessManager.Scheduler = new RandomScheduler();
                    break;
                default:
                    ProcessManager.Scheduler = new PriorityScheduler();
                    break;
            }
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            ExecSpeed = tbSpeed.Value;
            T.Interval = ExecSpeed;
        }
    }
}
