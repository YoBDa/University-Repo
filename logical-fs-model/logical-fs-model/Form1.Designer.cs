
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
            this.panDrawArea.SuspendLayout();
            this.cmsBrowser.SuspendLayout();
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
            this.paste});
            this.cmsBrowser.Name = "cmsBrowser";
            this.cmsBrowser.Size = new System.Drawing.Size(211, 152);
            // 
            // create
            // 
            this.create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.folderToolStripMenuItem});
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(210, 24);
            this.create.Text = "Create";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // rename
            // 
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(210, 24);
            this.rename.Text = "Rename";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(210, 24);
            this.copy.Text = "Copy";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(210, 24);
            this.cut.Text = "Cut";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(210, 24);
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
            this.cmsBrowser.ResumeLayout(false);
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
    }
}

