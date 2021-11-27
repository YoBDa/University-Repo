using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using logical_fs_model.Exceptions;

namespace logical_fs_model.Classes
{
    public class nFile
    {
        private static readonly string ForbiddenFilenameCharacters = "/\\:*+?<>\"";
        private static readonly string ForbiddenPathCharacters = "\\:*+?<>\"";


        private string fullName;
        private int size;
        public nFile(bool IsDirectory, string Fullname, int Size = 0)
        {
            this.IsDirectory = IsDirectory;
            if (IsDirectory)
                this.Fullname = Fullname + "/";
            else
                this.Fullname = Fullname;
            GUID = new Guid();
            size = IsDirectory ? 0 : Size;
        }
        public bool IsDirectory { get; private set; }

        public Guid GUID { get; private set; }
        public int Size
        {
            get
            {
                if (IsDirectory) return 0;
                else return size;
            }
        }
        
        public string Fullname {
            get { return fullName; }
            set 
            {
                if (value.IndexOfAny(ForbiddenPathCharacters.ToCharArray()) != -1)
                    throw new InvalidFilenameException(value);
                fullName = value;
            } 
        }
        public string Shortname
        {
            get
            {
                if (IsDirectory)
                {
                    string[] path = Fullname.Split('/');
                    return path[path.Length - 2] + "/";
                }
                else
                    return Fullname.Split('/').Last();
            }
            set
            {
                if (value.IndexOfAny(ForbiddenFilenameCharacters.ToCharArray()) != -1)
                    throw new InvalidFilenameException(value);
                int index = Fullname.LastIndexOf('/');
                Fullname = Fullname.Substring(0, index) + value;
            }
        }


    }
}
