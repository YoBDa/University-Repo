using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logical_fs_model.Exceptions;

namespace logical_fs_model.Classes
{
    class nDirectory : nItem
    {

        public Guid GUID { get; private set; }
        public uint Size { get; } = 4;
        public string Fullname
        {
            get
            {
                List<string> rPath = new List<string>();
                nItem current = this;
                rPath.Add(current.Name);
                while (current.Parent != null)
                {
                    current = current.Parent;
                    rPath.Add(current.Name);
                }
                rPath.Reverse();
                return string.Join("/", rPath.ToArray()) + "/";
            }
            
        }
        public string Shortname { get => Name + "/"; }
        public List<nItem> Child { get; private set; }
        public nItem Parent { get; set; }
        public string Name { get; set; }

        public nDirectory(string Name)
        {
            this.Name = Name;
            this.Child = new List<nItem>();
            this.GUID = new Guid();
        }
        
        public void AppendChild(nItem item)
        {
            if (Child.FindIndex(f => f.Shortname == item.Shortname) != -1) throw new FileOrDirectoryExistException(item.Shortname); 
            Child.Add(item);
        }
    }
}
