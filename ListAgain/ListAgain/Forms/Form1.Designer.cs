
namespace ListAgain.Forms
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
            this.lbData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRmFirst = new System.Windows.Forms.Button();
            this.btRmSelected = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panGraphContainer = new System.Windows.Forms.Panel();
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.btInit = new System.Windows.Forms.Button();
            this.panGraphContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 16;
            this.lbData.Location = new System.Drawing.Point(12, 29);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(180, 228);
            this.lbData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 278);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 50);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRmFirst
            // 
            this.btRmFirst.Location = new System.Drawing.Point(190, 278);
            this.btRmFirst.Name = "btRmFirst";
            this.btRmFirst.Size = new System.Drawing.Size(75, 50);
            this.btRmFirst.TabIndex = 3;
            this.btRmFirst.Text = "Remove First";
            this.btRmFirst.UseVisualStyleBackColor = true;
            this.btRmFirst.Click += new System.EventHandler(this.btRmFirst_Click);
            // 
            // btRmSelected
            // 
            this.btRmSelected.Location = new System.Drawing.Point(101, 278);
            this.btRmSelected.Name = "btRmSelected";
            this.btRmSelected.Size = new System.Drawing.Size(75, 50);
            this.btRmSelected.TabIndex = 4;
            this.btRmSelected.Text = "Remove Selected";
            this.btRmSelected.UseVisualStyleBackColor = true;
            this.btRmSelected.Click += new System.EventHandler(this.btRmSelected_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(457, 278);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 50);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(368, 278);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(75, 50);
            this.btSort.TabIndex = 6;
            this.btSort.Text = "Sort List";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Graph";
            // 
            // panGraphContainer
            // 
            this.panGraphContainer.AutoScroll = true;
            this.panGraphContainer.Controls.Add(this.pbGraph);
            this.panGraphContainer.Location = new System.Drawing.Point(210, 29);
            this.panGraphContainer.Name = "panGraphContainer";
            this.panGraphContainer.Size = new System.Drawing.Size(325, 228);
            this.panGraphContainer.TabIndex = 9;
            // 
            // pbGraph
            // 
            this.pbGraph.Location = new System.Drawing.Point(3, 3);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(291, 222);
            this.pbGraph.TabIndex = 0;
            this.pbGraph.TabStop = false;
            // 
            // btInit
            // 
            this.btInit.Location = new System.Drawing.Point(279, 278);
            this.btInit.Name = "btInit";
            this.btInit.Size = new System.Drawing.Size(75, 50);
            this.btInit.TabIndex = 10;
            this.btInit.Text = "Init";
            this.btInit.UseVisualStyleBackColor = true;
            this.btInit.Click += new System.EventHandler(this.btInit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 358);
            this.Controls.Add(this.btInit);
            this.Controls.Add(this.panGraphContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRmSelected);
            this.Controls.Add(this.btRmFirst);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Listest";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panGraphContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRmFirst;
        private System.Windows.Forms.Button btRmSelected;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panGraphContainer;
        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.Button btInit;
    }
}

