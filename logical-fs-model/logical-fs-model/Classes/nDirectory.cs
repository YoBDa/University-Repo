using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logical_fs_model.Exceptions;

namespace logical_fs_model.Classes
{
    public class nDirectory : nItem
    {
        private bool disposedValue;

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
        public nDirectory Parent { get; set; }
        public string Name { get; set; }

        public nDirectory(string Name)
        {
            this.Name = Name;
            this.Child = new List<nItem>();
            this.GUID = new Guid();
        }
        public void RemoveChild(nItem item)
        {
            if (Child.Contains(item))
                Child.Remove(item);
            else throw new FileOrDirectoryNotExistsException(item.Fullname);
        }

        public void AppendChild(nItem item)
        {
            if (Child.FindIndex(f => f.Shortname == item.Shortname) != -1) throw new FileOrDirectoryExistException(item.Fullname); 
            Child.Add(item);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    foreach (nItem item in Child)
                        item.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~nDirectory()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
