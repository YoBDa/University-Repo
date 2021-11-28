using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Classes
{
    public class nFileManager
    {
        private static readonly string ForbiddenFilenameCharacters = "/\\:*+?<>\"";
        public nFileManager()
        {
            nItem root = new nFile(true, "");
            CurrentDirectory = root;
            Filesystem.Add(root);
        }
        
        public List<nItem> Filesystem = new List<nItem>();
        public nItem Parent
        {
            get
            {

                string[] path = CurrentDirectory.Fullname.Split('/');

                if (CurrentDirectory.Fullname != "/") 
                {
                    string prevpath = "";
                    for (int i = 0; i < path.Length - 2; i++) 
                        prevpath += path[i]+"/";
                    return Filesystem.Find(f => f.Fullname == prevpath);
                }
                else return CurrentDirectory;
            }
        }
        public nItem ParentOf(nItem file)
        {
            

            string[] path = file.Fullname.Split('/');

            if (file.Fullname != "/")
            {
                string prevpath = "";
                for (int i = 0; i < path.Length - 2; i++)
                    prevpath += path[i] + "/";
                return Filesystem.Find(f => f.Fullname == prevpath);
            }
            else return file;
            
        }
        public nItem CurrentDirectory { get; set; }
        public List<nItem> ListOfFiles(nItem Directory)
        {
            List<nItem> Result = Filesystem.FindAll(file => file.Fullname == (Directory.Fullname + file.Shortname));
            Result.Remove(Directory);
            return Result;
        }

        public List<nItem> ListOfFilesHere()
        {
            return ListOfFiles(CurrentDirectory);
        }


        public bool CreateFileHere(bool IsDirectory, string Filename, int Size=0)
        {
            return CreateFile(IsDirectory, CurrentDirectory, Filename, Size);
        }
        public bool CreateFile(bool IsDirectory, nItem Directory, string Filename, int Size=0)
        {
            try
            {
                string fullname = Directory.Fullname + Filename;
                nItem file = new nFile(IsDirectory, fullname);
                if (Filesystem.Find(f => f.IsDirectory == file.IsDirectory && f.Fullname == file.Fullname) != null) return false;
                Filesystem.Add((nItem)new nFile(IsDirectory, fullname, Size));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool MoveFile(nItem file, nItem toDirectory)
        {
            file.Fullname = toDirectory.Fullname+ file.Shortname;
            return true;

        }
        public bool DeleteFile(nItem file)
        {

            return Filesystem.Remove(file);

        }
        
        public List<nItem> GetChildren(nItem file)
        {
            return Filesystem.FindAll(f => f.Fullname.StartsWith(file.Fullname));
        }

        public bool RenameFile(nItem file, string NewName)
        {
            List<nItem> child = GetChildren(file);
            string OldName = file.Shortname;

            foreach (var f in child)
            {
                f.Fullname = ParentOf(file)
            }
        }
      
        





    }
}
