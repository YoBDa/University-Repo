using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Classes
{
    public class nFile : nItem
    {
        private bool disposedValue;

        public Guid GUID { get; private set; }
        public uint Size { get; private set; }
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
                return string.Join("/", rPath.ToArray());
            }
        }
        public string Shortname { get { return Name; }  }
        public nDirectory Parent { get; set; }
        public string Name { get;  set; }

        public nFile(string Name, uint Size)
        {
            this.Size = Size;
            this.Name = Name;
            this.GUID = new Guid();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~nFile()
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
