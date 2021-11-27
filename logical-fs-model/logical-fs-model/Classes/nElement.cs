using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace logical_fs_model.Classes
{
    public class nElement: PictureBox
    {
        public bool IsDirectory { get; private set; }
        public nElement(bool IsDirectory)
            :base()
        {
            this.Size = new Size(128, 128);
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.IsDirectory = IsDirectory;
            

            if (IsDirectory) this.BackgroundImage = Image.FromFile("./Icons/folder.png");
            else this.BackgroundImage = Image.FromFile("./Icons/file.png");
        }
    }
}
