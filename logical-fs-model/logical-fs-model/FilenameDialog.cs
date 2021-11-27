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
    public partial class FilenameDialog : Form
    {
        private static readonly string ForbiddenFilenameCharacters = "/\\:*+?<>\"";
        public string Result = "";
        public FilenameDialog()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text.IndexOfAny(ForbiddenFilenameCharacters.ToCharArray()) != -1)
            {
                MessageBox.Show("Invalid name");
                return;
            }
            Result = tbName.Text;
            this.Close();
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCreate.PerformClick();
            }
        }
    }
}
