
namespace TRICARPET
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
            this.NextCarpet = new System.Windows.Forms.Button();
            this.NextTriangle = new System.Windows.Forms.Button();
            this.FractalBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FractalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NextCarpet
            // 
            this.NextCarpet.Location = new System.Drawing.Point(13, 13);
            this.NextCarpet.Name = "NextCarpet";
            this.NextCarpet.Size = new System.Drawing.Size(88, 42);
            this.NextCarpet.TabIndex = 0;
            this.NextCarpet.Text = "NEXT CARPET";
            this.NextCarpet.UseVisualStyleBackColor = true;
            this.NextCarpet.Click += new System.EventHandler(this.NextCarpet_Click);
            // 
            // NextTriangle
            // 
            this.NextTriangle.Location = new System.Drawing.Point(13, 61);
            this.NextTriangle.Name = "NextTriangle";
            this.NextTriangle.Size = new System.Drawing.Size(88, 43);
            this.NextTriangle.TabIndex = 1;
            this.NextTriangle.Text = "NEXT TRIANGLE";
            this.NextTriangle.UseVisualStyleBackColor = true;
            this.NextTriangle.Click += new System.EventHandler(this.NextTriangle_Click);
            // 
            // FractalBox
            // 
            this.FractalBox.Location = new System.Drawing.Point(107, 13);
            this.FractalBox.Name = "FractalBox";
            this.FractalBox.Size = new System.Drawing.Size(776, 702);
            this.FractalBox.TabIndex = 2;
            this.FractalBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 727);
            this.Controls.Add(this.FractalBox);
            this.Controls.Add(this.NextTriangle);
            this.Controls.Add(this.NextCarpet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TRiCARPET";
            ((System.ComponentModel.ISupportInitialize)(this.FractalBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextCarpet;
        private System.Windows.Forms.Button NextTriangle;
        private System.Windows.Forms.PictureBox FractalBox;
    }
}

