
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
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
            this.pbRam = new System.Windows.Forms.ProgressBar();
            this.pbVram = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.tpAddProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).BeginInit();
            this.tpRemoveProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpExecute);
            this.tabControl1.Controls.Add(this.tpAddProcess);
            this.tabControl1.Controls.Add(this.tpRemoveProcess);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 346);
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
            this.tpExecute.Location = new System.Drawing.Point(4, 22);
            this.tpExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpExecute.Name = "tpExecute";
            this.tpExecute.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpExecute.Size = new System.Drawing.Size(574, 320);
            this.tpExecute.TabIndex = 0;
            this.tpExecute.Text = "Execute";
            this.tpExecute.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Speed";
            // 
            // tbSpeed
            // 
            this.tbSpeed.LargeChange = 10;
            this.tbSpeed.Location = new System.Drawing.Point(472, 144);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSpeed.Maximum = 30;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(99, 56);
            this.tbSpeed.SmallChange = 5;
            this.tbSpeed.TabIndex = 10;
            this.tbSpeed.TickFrequency = 5;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Scheduler";
            // 
            // cbSchedulers
            // 
            this.cbSchedulers.FormattingEnabled = true;
            this.cbSchedulers.Location = new System.Drawing.Point(472, 84);
            this.cbSchedulers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSchedulers.Name = "cbSchedulers";
            this.cbSchedulers.Size = new System.Drawing.Size(98, 21);
            this.cbSchedulers.TabIndex = 8;
            this.cbSchedulers.SelectedIndexChanged += new System.EventHandler(this.cbSchedulers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ticks:";
            // 
            // btInit
            // 
            this.btInit.Location = new System.Drawing.Point(518, 252);
            this.btInit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInit.Name = "btInit";
            this.btInit.Size = new System.Drawing.Size(56, 19);
            this.btInit.TabIndex = 6;
            this.btInit.Text = "Init";
            this.btInit.UseVisualStyleBackColor = true;
            this.btInit.Click += new System.EventHandler(this.btInit_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(518, 275);
            this.btReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(56, 19);
            this.btReset.TabIndex = 5;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // labTicks
            // 
            this.labTicks.AutoSize = true;
            this.labTicks.Location = new System.Drawing.Point(472, 22);
            this.labTicks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTicks.Name = "labTicks";
            this.labTicks.Size = new System.Drawing.Size(14, 15);
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
            this.lvProcesses.Location = new System.Drawing.Point(7, 5);
            this.lvProcesses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvProcesses.MultiSelect = false;
            this.lvProcesses.Name = "lvProcesses";
            this.lvProcesses.ShowGroups = false;
            this.lvProcesses.Size = new System.Drawing.Size(462, 314);
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
            this.lbHeader.Location = new System.Drawing.Point(4, 5);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 15);
            this.lbHeader.TabIndex = 2;
            // 
            // btStartStop
            // 
            this.btStartStop.Location = new System.Drawing.Point(518, 299);
            this.btStartStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStartStop.Name = "btStartStop";
            this.btStartStop.Size = new System.Drawing.Size(56, 19);
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
            this.tpAddProcess.Location = new System.Drawing.Point(4, 22);
            this.tpAddProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAddProcess.Name = "tpAddProcess";
            this.tpAddProcess.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAddProcess.Size = new System.Drawing.Size(574, 320);
            this.tpAddProcess.TabIndex = 1;
            this.tpAddProcess.Text = "Add Processs";
            this.tpAddProcess.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Priority (bigger - better)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // nudPriority
            // 
            this.nudPriority.Location = new System.Drawing.Point(14, 63);
            this.nudPriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.nudPriority.Size = new System.Drawing.Size(90, 20);
            this.nudPriority.TabIndex = 2;
            this.nudPriority.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(14, 27);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(76, 20);
            this.tbName.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(515, 299);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 19);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tpRemoveProcess
            // 
            this.tpRemoveProcess.Controls.Add(this.btRemove);
            this.tpRemoveProcess.Controls.Add(this.lbProcesses);
            this.tpRemoveProcess.Location = new System.Drawing.Point(4, 22);
            this.tpRemoveProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpRemoveProcess.Name = "tpRemoveProcess";
            this.tpRemoveProcess.Size = new System.Drawing.Size(574, 320);
            this.tpRemoveProcess.TabIndex = 2;
            this.tpRemoveProcess.Text = "Remove Process";
            this.tpRemoveProcess.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(518, 301);
            this.btRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(56, 19);
            this.btRemove.TabIndex = 1;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // lbProcesses
            // 
            this.lbProcesses.FormattingEnabled = true;
            this.lbProcesses.Location = new System.Drawing.Point(2, 2);
            this.lbProcesses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbProcesses.Name = "lbProcesses";
            this.lbProcesses.Size = new System.Drawing.Size(256, 316);
            this.lbProcesses.TabIndex = 0;
            // 
            // pbRam
            // 
            this.pbRam.Location = new System.Drawing.Point(680, 30);
            this.pbRam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRam.Name = "pbRam";
            this.pbRam.Size = new System.Drawing.Size(77, 19);
            this.pbRam.TabIndex = 1;
            // 
            // pbVram
            // 
            this.pbVram.Location = new System.Drawing.Point(680, 63);
            this.pbVram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbVram.Name = "pbVram";
            this.pbVram.Size = new System.Drawing.Size(154, 19);
            this.pbVram.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(602, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "RAM Usage:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "VRAM Usage:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 366);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbVram);
            this.Controls.Add(this.pbRam);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Planner";
            this.tabControl1.ResumeLayout(false);
            this.tpExecute.ResumeLayout(false);
            this.tpExecute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.tpAddProcess.ResumeLayout(false);
            this.tpAddProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).EndInit();
            this.tpRemoveProcess.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ProgressBar pbRam;
        private System.Windows.Forms.ProgressBar pbVram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

