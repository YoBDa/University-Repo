
namespace planirovshik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpExecute = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSchedulers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btInit = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.labTicks = new System.Windows.Forms.Label();
            this.lvProcesses = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelfPriorityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentPriorityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicksToReadyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeLeftHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbHeader = new System.Windows.Forms.Label();
            this.btStartStop = new System.Windows.Forms.Button();
            this.tpAddProcess = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPriority = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.tpRemoveProcess = new System.Windows.Forms.TabPage();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbProcesses = new System.Windows.Forms.ListBox();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpExecute.SuspendLayout();
            this.tpAddProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).BeginInit();
            this.tpRemoveProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpExecute);
            this.tabControl1.Controls.Add(this.tpAddProcess);
            this.tabControl1.Controls.Add(this.tpRemoveProcess);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tpExecute
            // 
            this.tpExecute.Controls.Add(this.label5);
            this.tpExecute.Controls.Add(this.tbSpeed);
            this.tpExecute.Controls.Add(this.label4);
            this.tpExecute.Controls.Add(this.cbSchedulers);
            this.tpExecute.Controls.Add(this.label3);
            this.tpExecute.Controls.Add(this.btInit);
            this.tpExecute.Controls.Add(this.btReset);
            this.tpExecute.Controls.Add(this.labTicks);
            this.tpExecute.Controls.Add(this.lvProcesses);
            this.tpExecute.Controls.Add(this.lbHeader);
            this.tpExecute.Controls.Add(this.btStartStop);
            this.tpExecute.Location = new System.Drawing.Point(4, 25);
            this.tpExecute.Name = "tpExecute";
            this.tpExecute.Padding = new System.Windows.Forms.Padding(3);
            this.tpExecute.Size = new System.Drawing.Size(768, 397);
            this.tpExecute.TabIndex = 0;
            this.tpExecute.Text = "Execute";
            this.tpExecute.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Scheduler";
            // 
            // cbSchedulers
            // 
            this.cbSchedulers.FormattingEnabled = true;
            this.cbSchedulers.Location = new System.Drawing.Point(630, 104);
            this.cbSchedulers.Name = "cbSchedulers";
            this.cbSchedulers.Size = new System.Drawing.Size(129, 24);
            this.cbSchedulers.TabIndex = 8;
            this.cbSchedulers.SelectedIndexChanged += new System.EventHandler(this.cbSchedulers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ticks:";
            // 
            // btInit
            // 
            this.btInit.Location = new System.Drawing.Point(690, 310);
            this.btInit.Name = "btInit";
            this.btInit.Size = new System.Drawing.Size(75, 23);
            this.btInit.TabIndex = 6;
            this.btInit.Text = "Init";
            this.btInit.UseVisualStyleBackColor = true;
            this.btInit.Click += new System.EventHandler(this.btInit_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(690, 339);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 5;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // labTicks
            // 
            this.labTicks.AutoSize = true;
            this.labTicks.Location = new System.Drawing.Point(630, 27);
            this.labTicks.Name = "labTicks";
            this.labTicks.Size = new System.Drawing.Size(16, 17);
            this.labTicks.TabIndex = 4;
            this.labTicks.Text = "0";
            // 
            // lvProcesses
            // 
            this.lvProcesses.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.IDHeader,
            this.SelfPriorityHeader,
            this.CurrentPriorityHeader,
            this.WorkCountHeader,
            this.StateHeader,
            this.TicksToReadyHeader,
            this.TimeLeftHeader});
            this.lvProcesses.FullRowSelect = true;
            this.lvProcesses.HideSelection = false;
            this.lvProcesses.LabelWrap = false;
            this.lvProcesses.Location = new System.Drawing.Point(9, 6);
            this.lvProcesses.MultiSelect = false;
            this.lvProcesses.Name = "lvProcesses";
            this.lvProcesses.ShowGroups = false;
            this.lvProcesses.Size = new System.Drawing.Size(615, 385);
            this.lvProcesses.TabIndex = 3;
            this.lvProcesses.UseCompatibleStateImageBehavior = false;
            this.lvProcesses.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 64;
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "ID";
            this.IDHeader.Width = 49;
            // 
            // SelfPriorityHeader
            // 
            this.SelfPriorityHeader.Text = "Self Priority";
            this.SelfPriorityHeader.Width = 78;
            // 
            // CurrentPriorityHeader
            // 
            this.CurrentPriorityHeader.Text = "Current Priority";
            this.CurrentPriorityHeader.Width = 106;
            // 
            // WorkCountHeader
            // 
            this.WorkCountHeader.Text = "Work Count";
            this.WorkCountHeader.Width = 93;
            // 
            // StateHeader
            // 
            this.StateHeader.Text = "State";
            this.StateHeader.Width = 67;
            // 
            // TicksToReadyHeader
            // 
            this.TicksToReadyHeader.Text = "Ticks to Ready";
            // 
            // TimeLeftHeader
            // 
            this.TimeLeftHeader.Text = "Time Left";
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Location = new System.Drawing.Point(6, 6);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 17);
            this.lbHeader.TabIndex = 2;
            // 
            // btStartStop
            // 
            this.btStartStop.Location = new System.Drawing.Point(690, 368);
            this.btStartStop.Name = "btStartStop";
            this.btStartStop.Size = new System.Drawing.Size(75, 23);
            this.btStartStop.TabIndex = 0;
            this.btStartStop.Text = "Start";
            this.btStartStop.UseVisualStyleBackColor = true;
            this.btStartStop.Click += new System.EventHandler(this.btStartStop_Click);
            // 
            // tpAddProcess
            // 
            this.tpAddProcess.Controls.Add(this.label2);
            this.tpAddProcess.Controls.Add(this.label1);
            this.tpAddProcess.Controls.Add(this.nudPriority);
            this.tpAddProcess.Controls.Add(this.tbName);
            this.tpAddProcess.Controls.Add(this.btAdd);
            this.tpAddProcess.Location = new System.Drawing.Point(4, 25);
            this.tpAddProcess.Name = "tpAddProcess";
            this.tpAddProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddProcess.Size = new System.Drawing.Size(768, 397);
            this.tpAddProcess.TabIndex = 1;
            this.tpAddProcess.Text = "Add Processs";
            this.tpAddProcess.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Priority (bigger - better)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // nudPriority
            // 
            this.nudPriority.Location = new System.Drawing.Point(19, 78);
            this.nudPriority.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPriority.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPriority.Name = "nudPriority";
            this.nudPriority.Size = new System.Drawing.Size(120, 22);
            this.nudPriority.TabIndex = 2;
            this.nudPriority.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(19, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(687, 368);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tpRemoveProcess
            // 
            this.tpRemoveProcess.Controls.Add(this.btRemove);
            this.tpRemoveProcess.Controls.Add(this.lbProcesses);
            this.tpRemoveProcess.Location = new System.Drawing.Point(4, 25);
            this.tpRemoveProcess.Name = "tpRemoveProcess";
            this.tpRemoveProcess.Size = new System.Drawing.Size(768, 397);
            this.tpRemoveProcess.TabIndex = 2;
            this.tpRemoveProcess.Text = "Remove Process";
            this.tpRemoveProcess.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(690, 371);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 1;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // lbProcesses
            // 
            this.lbProcesses.FormattingEnabled = true;
            this.lbProcesses.ItemHeight = 16;
            this.lbProcesses.Location = new System.Drawing.Point(3, 3);
            this.lbProcesses.Name = "lbProcesses";
            this.lbProcesses.Size = new System.Drawing.Size(340, 388);
            this.lbProcesses.TabIndex = 0;
            // 
            // tbSpeed
            // 
            this.tbSpeed.LargeChange = 10;
            this.tbSpeed.Location = new System.Drawing.Point(630, 177);
            this.tbSpeed.Maximum = 30;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(132, 56);
            this.tbSpeed.SmallChange = 5;
            this.tbSpeed.TabIndex = 10;
            this.tbSpeed.TickFrequency = 5;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Planner";
            this.tabControl1.ResumeLayout(false);
            this.tpExecute.ResumeLayout(false);
            this.tpExecute.PerformLayout();
            this.tpAddProcess.ResumeLayout(false);
            this.tpAddProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).EndInit();
            this.tpRemoveProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpExecute;
        private System.Windows.Forms.TabPage tpAddProcess;
        private System.Windows.Forms.Button btStartStop;
        private System.Windows.Forms.TabPage tpRemoveProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPriority;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.ListView lvProcesses;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader IDHeader;
        private System.Windows.Forms.ColumnHeader SelfPriorityHeader;
        private System.Windows.Forms.ColumnHeader CurrentPriorityHeader;
        private System.Windows.Forms.ColumnHeader WorkCountHeader;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox lbProcesses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btInit;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label labTicks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSchedulers;
        private System.Windows.Forms.ColumnHeader StateHeader;
        private System.Windows.Forms.ColumnHeader TicksToReadyHeader;
        private System.Windows.Forms.ColumnHeader TimeLeftHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbSpeed;
    }
}

