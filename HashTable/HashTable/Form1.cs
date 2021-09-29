using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            functions.Add(HashFunc1);
            functions.Add(HashFunc2);
            combFunctions.Items.AddRange(functions.ToArray());
            combFunctions.SelectedIndex = 0;
            trbRowCount.Maximum = pbGraph.Height;

        }
        MyHashTable table;

        List<Func<string, int>> functions = new List<Func<string, int>>();
        private void btLoad_Click(object sender, EventArgs e)
        {
            pbGraph.CreateGraphics().Clear(Color.FromKnownColor(KnownColor.Control));
            int RowCount = trbRowCount.Value;
            KeysType kt;
            
            if (rbName.Checked) 
                kt = KeysType.name;
            else if (rbPhone.Checked) kt = KeysType.phone;
            else kt = KeysType.birthdate;
            table = new MyHashTable(RowCount, kt, functions[combFunctions.SelectedIndex].Invoke);
            table.Load();
            table.Draw(pbGraph.CreateGraphics(), pbGraph.Width, pbGraph.Height);
            lbCount.Text = table.Length.ToString();
        }
        /// <summary>
        ///     Represents string.GetHashCode() method
        /// </summary>
        /// <param name="key"> input string</param>
        /// <returns>int</returns>
        int HashFunc1(string key)
        {
            return Math.Abs(key.GetHashCode());
        }

        int HashFunc2(string Key)
        {
            int sum = 0;
            foreach (char c in Key)
            {
                sum += c;
            }
            return sum;
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string Key = tbKeyInput.Text;
            int count = 0;
            User user = table?.Find(Key, out count);
            if (user != null)
            {
                lbName.Text = user.Name;
                lbPhone.Text = user.Phone;
                lbBirthdate.Text = user.BirthDate;
                lbCount.Text = count.ToString();
            }
        }

        private void trbRowCount_Scroll(object sender, EventArgs e)
        {
            lbRowCount.Text = $"Row Count = {trbRowCount.Value}";
        }
    }
}
