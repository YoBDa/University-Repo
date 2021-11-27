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
    public partial class Form1 : Form
    {
        private nFileManager FileManager;
        private List<nFile> CurrentFiles;
        public Form1()
        {
            FileManager = new nFileManager();
            CurrentFiles = new List<nFile>();
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
        private void Draw()
        {
            lvDrawer.Items.Clear();
            CurrentFiles.Clear();
            ListViewItem LVI;
            if (FileManager.CurrentDirectory.Fullname != "/")
            {
                CurrentFiles.Add(FileManager.Parent);
                string[] Subitems =
                {
                    "..",
                    0.ToString()
                };
                LVI = new ListViewItem(Subitems, "back");
                lvDrawer.Items.Add(LVI);
            }

            foreach (nFile file in FileManager.ListOfFilesHere())
            {
                CurrentFiles.Add(file);
                string[] Subitems =
                {
                    file.Shortname,
                    file.Size.ToString()
                };
                if (file.IsDirectory)
                    LVI = new ListViewItem(Subitems, "folder");
                else
                    LVI = new ListViewItem(Subitems, "file");

                lvDrawer.Items.Add(LVI);

            }
            foreach (nFile file in CurrentFiles)
            {
                string[] Subitems =
                {
                    file.Shortname,
                    file.Size.ToString()
                };
                if (file.IsDirectory)
                    LVI = new ListViewItem(Subitems, "folder");
                else
                    LVI = new ListViewItem(Subitems, "file");

                lvDrawer.Items.Add(LVI);
            }

            lbCurDir.Text = FileManager.CurrentDirectory.Fullname;
            lbParDir.Text = FileManager.Parent.Fullname;
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
            if (!FileManager.CreateFileHere(false, Filename, rnd.Next(0,1000000))) MessageBox.Show("Failed to create file.");
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
                nFile file = CurrentFiles[index];
                FileManager.DeleteFile(file);
            }
            Draw();
        }

        private void lvDrawer_ItemActivate(object sender, EventArgs e)
        {
            int index = lvDrawer.SelectedIndices[0];
            nFile activated = CurrentFiles[index];
            if (activated.IsDirectory)
                FileManager.CurrentDirectory = activated;
            Draw();


        }

        private void lvDrawer_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                lvDrawer.Sort()
            }
            //((ListView)sender).Column
        }
    }
}
