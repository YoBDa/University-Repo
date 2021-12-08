
namespace logical_fs_model
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
            this.components = new System.ComponentModel.Container();
            this.panDrawArea = new System.Windows.Forms.Panel();
            this.lvDrawer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsBrowser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rename = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btCreateFolder = new System.Windows.Forms.Button();
            this.btCreateFile = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCurDir = new System.Windows.Forms.Label();
            this.lbParDir = new System.Windows.Forms.Label();
            this.btSaveFs = new System.Windows.Forms.Button();
            this.copyAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbFat = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDimensions = new System.Windows.Forms.Label();
            this.btFormat = new System.Windows.Forms.Button();
            this.nudClusterSize = new System.Windows.Forms.NumericUpDown();
            this.nudClustersCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbrSpace = new System.Windows.Forms.ProgressBar();
            this.lbSpace = new System.Windows.Forms.Label();
            this.panDrawArea.SuspendLayout();
            this.cmsBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClusterSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClustersCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panDrawArea
            // 
            this.panDrawArea.Controls.Add(this.lvDrawer);
            this.panDrawArea.Controls.Add(this.button1);
            this.panDrawArea.Location = new System.Drawing.Point(195, 48);
            this.panDrawArea.Name = "panDrawArea";
            this.panDrawArea.Size = new System.Drawing.Size(593, 390);
            this.panDrawArea.TabIndex = 0;
            // 
            // lvDrawer
            // 
            this.lvDrawer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lvDrawer.ContextMenuStrip = this.cmsBrowser;
            this.lvDrawer.FullRowSelect = true;
            this.lvDrawer.HideSelection = false;
            this.lvDrawer.LabelEdit = true;
            this.lvDrawer.Location = new System.Drawing.Point(6, 6);
            this.lvDrawer.Name = "lvDrawer";
            this.lvDrawer.Size = new System.Drawing.Size(584, 381);
            this.lvDrawer.TabIndex = 0;
            this.lvDrawer.UseCompatibleStateImageBehavior = false;
            this.lvDrawer.View = System.Windows.Forms.View.Details;
            this.lvDrawer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvDrawer_ColumnClick);
            this.lvDrawer.ItemActivate += new System.EventHandler(this.lvDrawer_ItemActivate);
            this.lvDrawer.SelectedIndexChanged += new System.EventHandler(this.lvDrawer_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 162;
            // 
            // cmsBrowser
            // 
            this.cmsBrowser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create,
            this.rename,
            this.copy,
            this.cut,
            this.paste,
            this.copyAddressToolStripMenuItem});
            this.cmsBrowser.Name = "cmsBrowser";
            this.cmsBrowser.Size = new System.Drawing.Size(168, 148);
            // 
            // create
            // 
            this.create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.folderToolStripMenuItem});
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(167, 24);
            this.create.Text = "Create";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // rename
            // 
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(167, 24);
            this.rename.Text = "Rename";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(167, 24);
            this.copy.Text = "Copy";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(167, 24);
            this.cut.Text = "Cut";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(167, 24);
            this.paste.Text = "Paste";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btCreateFolder
            // 
            this.btCreateFolder.Location = new System.Drawing.Point(669, 12);
            this.btCreateFolder.Name = "btCreateFolder";
            this.btCreateFolder.Size = new System.Drawing.Size(119, 30);
            this.btCreateFolder.TabIndex = 1;
            this.btCreateFolder.Text = "New Folder";
            this.btCreateFolder.UseVisualStyleBackColor = true;
            this.btCreateFolder.Click += new System.EventHandler(this.btCreateFolder_Click);
            // 
            // btCreateFile
            // 
            this.btCreateFile.Location = new System.Drawing.Point(544, 12);
            this.btCreateFile.Name = "btCreateFile";
            this.btCreateFile.Size = new System.Drawing.Size(119, 30);
            this.btCreateFile.TabIndex = 2;
            this.btCreateFile.Text = "New File";
            this.btCreateFile.UseVisualStyleBackColor = true;
            this.btCreateFile.Click += new System.EventHandler(this.btCreateFile_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(419, 12);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(119, 30);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parent Directory";
            // 
            // lbCurDir
            // 
            this.lbCurDir.AutoSize = true;
            this.lbCurDir.Location = new System.Drawing.Point(16, 40);
            this.lbCurDir.Name = "lbCurDir";
            this.lbCurDir.Size = new System.Drawing.Size(12, 17);
            this.lbCurDir.TabIndex = 6;
            this.lbCurDir.Text = "/";
            // 
            // lbParDir
            // 
            this.lbParDir.AutoSize = true;
            this.lbParDir.Location = new System.Drawing.Point(16, 101);
            this.lbParDir.Name = "lbParDir";
            this.lbParDir.Size = new System.Drawing.Size(12, 17);
            this.lbParDir.TabIndex = 7;
            this.lbParDir.Text = "/";
            // 
            // btSaveFs
            // 
            this.btSaveFs.Location = new System.Drawing.Point(2, 383);
            this.btSaveFs.Name = "btSaveFs";
            this.btSaveFs.Size = new System.Drawing.Size(187, 52);
            this.btSaveFs.TabIndex = 8;
            this.btSaveFs.Text = "Save FS";
            this.btSaveFs.UseVisualStyleBackColor = true;
            this.btSaveFs.Click += new System.EventHandler(this.btSaveFs_Click);
            // 
            // copyAddressToolStripMenuItem
            // 
            this.copyAddressToolStripMenuItem.Name = "copyAddressToolStripMenuItem";
            this.copyAddressToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.copyAddressToolStripMenuItem.Text = "Copy address";
            this.copyAddressToolStripMenuItem.Click += new System.EventHandler(this.copyAddressToolStripMenuItem_Click);
            // 
            // pbFat
            // 
            this.pbFat.Location = new System.Drawing.Point(791, 54);
            this.pbFat.Name = "pbFat";
            this.pbFat.Size = new System.Drawing.Size(360, 300);
            this.pbFat.TabIndex = 9;
            this.pbFat.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "FAT";
            // 
            // lbDimensions
            // 
            this.lbDimensions.AutoSize = true;
            this.lbDimensions.Location = new System.Drawing.Point(834, 34);
            this.lbDimensions.Name = "lbDimensions";
            this.lbDimensions.Size = new System.Drawing.Size(159, 17);
            this.lbDimensions.TabIndex = 11;
            this.lbDimensions.Text = "0 clusters x 0 KB = 0 KB";
            // 
            // btFormat
            // 
            this.btFormat.Location = new System.Drawing.Point(2, 325);
            this.btFormat.Name = "btFormat";
            this.btFormat.Size = new System.Drawing.Size(187, 52);
            this.btFormat.TabIndex = 12;
            this.btFormat.Text = "Format";
            this.btFormat.UseVisualStyleBackColor = true;
            this.btFormat.Click += new System.EventHandler(this.btFormat_Click);
            // 
            // nudClusterSize
            // 
            this.nudClusterSize.Location = new System.Drawing.Point(2, 297);
            this.nudClusterSize.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudClusterSize.Name = "nudClusterSize";
            this.nudClusterSize.Size = new System.Drawing.Size(90, 22);
            this.nudClusterSize.TabIndex = 13;
            this.nudClusterSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudClustersCount
            // 
            this.nudClustersCount.Location = new System.Drawing.Point(98, 297);
            this.nudClustersCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudClustersCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudClustersCount.Name = "nudClustersCount";
            this.nudClustersCount.Size = new System.Drawing.Size(90, 22);
            this.nudClustersCount.TabIndex = 14;
            this.nudClustersCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Size (2^n KB)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Clusters properties:";
            // 
            // pbrSpace
            // 
            this.pbrSpace.Location = new System.Drawing.Point(797, 360);
            this.pbrSpace.Name = "pbrSpace";
            this.pbrSpace.Size = new System.Drawing.Size(354, 52);
            this.pbrSpace.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrSpace.TabIndex = 18;
            // 
            // lbSpace
            // 
            this.lbSpace.AutoSize = true;
            this.lbSpace.Location = new System.Drawing.Point(794, 415);
            this.lbSpace.Name = "lbSpace";
            this.lbSpace.Size = new System.Drawing.Size(109, 17);
            this.lbSpace.TabIndex = 19;
            this.lbSpace.Text = "Space 0/0 [free]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.lbSpace);
            this.Controls.Add(this.pbrSpace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudClustersCount);
            this.Controls.Add(this.nudClusterSize);
            this.Controls.Add(this.btFormat);
            this.Controls.Add(this.lbDimensions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbFat);
            this.Controls.Add(this.btSaveFs);
            this.Controls.Add(this.lbParDir);
            this.Controls.Add(this.lbCurDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btCreateFile);
            this.Controls.Add(this.btCreateFolder);
            this.Controls.Add(this.panDrawArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panDrawArea.ResumeLayout(false);
            this.cmsBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClusterSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClustersCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panDrawArea;
        private System.Windows.Forms.Button btCreateFolder;
        private System.Windows.Forms.Button btCreateFile;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListView lvDrawer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCurDir;
        private System.Windows.Forms.Label lbParDir;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip cmsBrowser;
        private System.Windows.Forms.ToolStripMenuItem create;
        private System.Windows.Forms.ToolStripMenuItem rename;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.Button btSaveFs;
        private System.Windows.Forms.ToolStripMenuItem copyAddressToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbFat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDimensions;
        private System.Windows.Forms.Button btFormat;
        private System.Windows.Forms.NumericUpDown nudClusterSize;
        private System.Windows.Forms.NumericUpDown nudClustersCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbrSpace;
        private System.Windows.Forms.Label lbSpace;
    }
}

