using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace logical_fs_model
{
    public partial class stringchecker : Form
    {
        private bool cbState = false;

        private static string ForbiddenFilenameCharacters = "/\\:*+?<>\"";
        private static string ForbiddenPathCharacters = "\\:*+?<>\"";
        public stringchecker()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool ismatch = false;
            if (cbState)
                ismatch = textBox1.Text.IndexOfAny(ForbiddenFilenameCharacters.ToCharArray()) != -1;
            else
                ismatch = textBox1.Text.IndexOfAny(ForbiddenPathCharacters.ToCharArray()) != -1;

            if (ismatch)
                pictureBox1.CreateGraphics().FillRectangle(Brushes.Red, 0, 0, pictureBox1.Width, pictureBox1.Height);
            else
                pictureBox1.CreateGraphics().FillRectangle(Brushes.Green, 0, 0, pictureBox1.Width, pictureBox1.Height);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbState = checkBox1.Checked;
            textBox1_TextChanged(sender, e);
        }

    }
}
