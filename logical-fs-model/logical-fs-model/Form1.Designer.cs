
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
            this.panDrawArea = new System.Windows.Forms.Panel();
            this.btCreateFolder = new System.Windows.Forms.Button();
            this.btCreateFile = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDrawer = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCurDir = new System.Windows.Forms.Label();
            this.lbParDir = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panDrawArea.SuspendLayout();
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // lvDrawer
            // 
            this.lvDrawer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lvDrawer.FullRowSelect = true;
            this.lvDrawer.HideSelection = false;
            this.lvDrawer.Location = new System.Drawing.Point(6, 6);
            this.lvDrawer.Name = "lvDrawer";
            this.lvDrawer.Size = new System.Drawing.Size(584, 381);
            this.lvDrawer.TabIndex = 0;
            this.lvDrawer.UseCompatibleStateImageBehavior = false;
            this.lvDrawer.View = System.Windows.Forms.View.Details;
            this.lvDrawer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvDrawer_ColumnClick);
            this.lvDrawer.ItemActivate += new System.EventHandler(this.lvDrawer_ItemActivate);
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 162;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

