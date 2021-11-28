﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Classes
{
    public class nFile : nItem
    {

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
        public nItem Parent { get; set; }
        public string Name { get;  set; }

        public nFile(string Name, uint Size)
        {
            this.Size = Size;
            this.Name = Name;
            this.GUID = new Guid();
        }
    }
}
