
namespace HashTable
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
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbPhone = new System.Windows.Forms.RadioButton();
            this.rbBirthDate = new System.Windows.Forms.RadioButton();
            this.btLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKeyInput = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbBirthdate = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.trbRowCount = new System.Windows.Forms.TrackBar();
            this.combFunctions = new System.Windows.Forms.ComboBox();
            this.lbRowCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRowCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGraph
            // 
            this.pbGraph.Location = new System.Drawing.Point(141, 12);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(538, 553);
            this.pbGraph.TabIndex = 0;
            this.pbGraph.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "KeyType";
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Checked = true;
            this.rbName.Location = new System.Drawing.Point(13, 34);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(66, 21);
            this.rbName.TabIndex = 2;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbPhone
            // 
            this.rbPhone.AutoSize = true;
            this.rbPhone.Location = new System.Drawing.Point(13, 62);
            this.rbPhone.Name = "rbPhone";
            this.rbPhone.Size = new System.Drawing.Size(70, 21);
            this.rbPhone.TabIndex = 3;
            this.rbPhone.Text = "Phone";
            this.rbPhone.UseVisualStyleBackColor = true;
            // 
            // rbBirthDate
            // 
            this.rbBirthDate.AutoSize = true;
            this.rbBirthDate.Location = new System.Drawing.Point(13, 90);
            this.rbBirthDate.Name = "rbBirthDate";
            this.rbBirthDate.Size = new System.Drawing.Size(86, 21);
            this.rbBirthDate.TabIndex = 4;
            this.rbBirthDate.Text = "Birthdate";
            this.rbBirthDate.UseVisualStyleBackColor = true;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(12, 117);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(122, 43);
            this.btLoad.TabIndex = 5;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key to Find";
            // 
            // tbKeyInput
            // 
            this.tbKeyInput.Location = new System.Drawing.Point(9, 363);
            this.tbKeyInput.Name = "tbKeyInput";
            this.tbKeyInput.Size = new System.Drawing.Size(100, 22);
            this.tbKeyInput.TabIndex = 7;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(10, 437);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 17);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "_name_";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(10, 454);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(64, 17);
            this.lbPhone.TabIndex = 9;
            this.lbPhone.Text = "_phone_";
            // 
            // lbBirthdate
            // 
            this.lbBirthdate.AutoSize = true;
            this.lbBirthdate.Location = new System.Drawing.Point(10, 471);
            this.lbBirthdate.Name = "lbBirthdate";
            this.lbBirthdate.Size = new System.Drawing.Size(80, 17);
            this.lbBirthdate.TabIndex = 10;
            this.lbBirthdate.Text = "_birthdate_";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(9, 548);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(59, 17);
            this.lbCount.TabIndex = 11;
            this.lbCount.Text = "_count_";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(9, 391);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(122, 43);
            this.btFind.TabIndex = 12;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // trbRowCount
            // 
            this.trbRowCount.Location = new System.Drawing.Point(5, 187);
            this.trbRowCount.Maximum = 100;
            this.trbRowCount.Minimum = 10;
            this.trbRowCount.Name = "trbRowCount";
            this.trbRowCount.Size = new System.Drawing.Size(126, 56);
            this.trbRowCount.TabIndex = 13;
            this.trbRowCount.Value = 10;
            this.trbRowCount.Scroll += new System.EventHandler(this.trbRowCount_Scroll);
            // 
            // combFunctions
            // 
            this.combFunctions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combFunctions.FormattingEnabled = true;
            this.combFunctions.Location = new System.Drawing.Point(13, 249);
            this.combFunctions.Name = "combFunctions";
            this.combFunctions.Size = new System.Drawing.Size(118, 24);
            this.combFunctions.TabIndex = 14;
            // 
            // lbRowCount
            // 
            this.lbRowCount.AutoSize = true;
            this.lbRowCount.Location = new System.Drawing.Point(13, 167);
            this.lbRowCount.Name = "lbRowCount";
            this.lbRowCount.Size = new System.Drawing.Size(92, 17);
            this.lbRowCount.TabIndex = 15;
            this.lbRowCount.Text = "Row Count = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Function:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 577);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRowCount);
            this.Controls.Add(this.combFunctions);
            this.Controls.Add(this.trbRowCount);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbBirthdate);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbKeyInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.rbBirthDate);
            this.Controls.Add(this.rbPhone);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "HashTable ";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRowCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbPhone;
        private System.Windows.Forms.RadioButton rbBirthDate;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKeyInput;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbBirthdate;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TrackBar trbRowCount;
        private System.Windows.Forms.ComboBox combFunctions;
        private System.Windows.Forms.Label lbRowCount;
        private System.Windows.Forms.Label label3;
    }
}

