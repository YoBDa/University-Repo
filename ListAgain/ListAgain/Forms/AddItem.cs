using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAgain.Forms
{
    public partial class AddItemForm : Form
    {
        public delegate void OnValueGet(int Value, int Index);
        public event OnValueGet ValueGet;
        private int Index;
        public AddItemForm(int Index)
        {
            this.Index = Index;
            InitializeComponent();
           
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int Value = 0;
            if (Int32.TryParse(tbInput.Text, out Value))
            {
                if (cbIndex.Checked) Index = -1;
                ValueGet?.Invoke(Value, Index);
                this.Close();
                this.Dispose();
                

            }
            else
                MessageBox.Show("Invalid entered value");

        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btAdd.PerformClick();
        }

        private void cbIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btAdd.PerformClick();
        }
    }
}
