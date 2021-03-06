using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logical_fs_model.Classes;
using logical_fs_model.Exceptions;

namespace logical_fs_model
{
    public enum SortRules { Name, Size };
    public partial class Form1 : Form
    {
        private SortRules SortRule = SortRules.Name;
        private nFileManager FileManager;
        private List<nItem> CurrentFiles;
        public Form1()
        {
            FileManager = new nFileManager();
            CurrentFiles = new List<nItem>();
            InitializeComponent();
            ImageList il = new ImageList();
            
            
            il.Images.Add(Properties.Resources.file);
            il.Images.Add(Properties.Resources.folder);
            il.Images.Add(Properties.Resources.back);
            il.Images.SetKeyName(0, "file");
            il.Images.SetKeyName(1, "folder");
            il.Images.SetKeyName(2, "back");

            lvDrawer.SmallImageList = il;
            Draw();

        }
        private List<nItem> OrderedList(List<nItem> original)
        {
            List<nItem> Files = new List<nItem>();
            List<nItem> Directories = new List<nItem>();
            Files.AddRange(original.FindAll(i => i is nFile));
            Directories.AddRange(original.FindAll(i => i is nDirectory));
            List<nItem> Intermediate = new List<nItem>();
            switch (SortRule)
            {
                case SortRules.Size:
                    Intermediate.AddRange(Directories.OrderBy(f => f.Name).ToList());
                    Intermediate.AddRange(Files.OrderBy(f => f.Size).ToList());
                    return Intermediate;
                default:
                    Intermediate.AddRange(Directories.OrderBy(f => f.Name).ToList());
                    Intermediate.AddRange(Files.OrderBy(f => f.Name).ToList());
                    return Intermediate;

            }
        }
        private void Draw()
        {
            lvDrawer.Items.Clear();
            CurrentFiles.Clear();
            ListViewItem LVI;
            if (FileManager.CurrentDirectory.Fullname != "/")
            {
                CurrentFiles.Add(FileManager.CurrentDirectory.Parent);
                string[] Subitems =
                {
                    "..",
                    0.ToString()
                };
                LVI = new ListViewItem(Subitems, "back");
                lvDrawer.Items.Add(LVI);
            }

            foreach (nItem file in OrderedList(FileManager.ListOfFilesHere()))
            {
                CurrentFiles.Add(file);
                string[] Subitems =
                {
                    file.Shortname,
                    file.Size.ToString()
                };
                if (file is nDirectory)
                    LVI = new ListViewItem(Subitems, "folder");
                else
                    LVI = new ListViewItem(Subitems, "file");

                lvDrawer.Items.Add(LVI);

            }
            

            lbCurDir.Text = FileManager.CurrentDirectory.Fullname;
            string parent = FileManager.CurrentDirectory.Parent?.Fullname;
            lbParDir.Text = (string.IsNullOrWhiteSpace(parent)) ? "" : parent;
        }

        private void btCreateFolder_Click(object sender, EventArgs e)
        {
            FilenameDialog dialog = new FilenameDialog();
            dialog.Show();
            dialog.FormClosing += Dir_Dialog_FormClosing;
        }

        private void File_Dialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            string Filename = ((FilenameDialog)sender).Result;
            if (string.IsNullOrWhiteSpace(Filename)) return;
            if (!FileManager.CreateFileHere(false, Filename, (uint)rnd.Next(0,1000000))) MessageBox.Show("Failed to create file.");
            ((FilenameDialog)sender).FormClosing -= File_Dialog_FormClosing;
            ((FilenameDialog)sender).Dispose();
            Draw();
        }

        private void btCreateFile_Click(object sender, EventArgs e)
        {
            FilenameDialog dialog = new FilenameDialog();
            dialog.Show();
            dialog.FormClosing += File_Dialog_FormClosing;
            
        }
        private void Dir_Dialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            string Filename = ((FilenameDialog)sender).Result;
            if (string.IsNullOrWhiteSpace(Filename)) return;
            if (!FileManager.CreateFileHere(true, Filename))MessageBox.Show("Failed to create directory.");
            ((FilenameDialog)sender).FormClosing -= Dir_Dialog_FormClosing;
            ((FilenameDialog)sender).Dispose();
            Draw();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            foreach (int index in lvDrawer.SelectedIndices)
            {
                nItem file = CurrentFiles[index];
                FileManager.DeleteFile(file);
            }
            Draw();
        }

        private void lvDrawer_ItemActivate(object sender, EventArgs e)
        {
            int index = lvDrawer.SelectedIndices[0];
            nItem activated = CurrentFiles[index];
            if (activated is nDirectory)
                FileManager.CurrentDirectory = (nDirectory)activated;
            Draw();


        }

        private void lvDrawer_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    SortRule = SortRules.Name;
                    Draw();
                    break;
                case 1:
                    SortRule = SortRules.Size;
                    Draw();
                    break;
            }
        }
    }
}
