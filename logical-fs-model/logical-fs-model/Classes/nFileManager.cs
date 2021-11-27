using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Classes
{
    public class nFileManager
    {
        public nFileManager()
        {
            nFile root = new nFile(true, "");
            CurrentDirectory = root;
            Filesystem.Add(root);
        }
        
        public List<nFile> Filesystem = new List<nFile>();
        public nFile Parent
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
        public nFile ParentOf(nFile file)
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
        public nFile CurrentDirectory { get; set; }
        public List<nFile> ListOfFiles(nFile Directory)
        {
            List<nFile> Result = Filesystem.FindAll(file => file.Fullname == (Directory.Fullname + file.Shortname));
            Result.Remove(Directory);
            return Result;
        }

        public List<nFile> ListOfFilesHere()
        {
            return ListOfFiles(CurrentDirectory);
        }


        public bool CreateFileHere(bool IsDirectory, string Filename, int Size=0)
        {
            return CreateFile(IsDirectory, CurrentDirectory, Filename, Size);
        }
        public bool CreateFile(bool IsDirectory, nFile Directory, string Filename, int Size=0)
        {
            try
            {
                string fullname = Directory.Fullname + Filename;
                nFile file = new nFile(IsDirectory, fullname);
                if (Filesystem.Find(f => f.IsDirectory == file.IsDirectory && f.Fullname == file.Fullname) != null) return false;
                Filesystem.Add(new nFile(IsDirectory, fullname, Size));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool MoveFile(nFile file, nFile toDirectory)
        {
            file.Fullname = toDirectory.Fullname+ file.Shortname;
            return true;

        }
        public bool DeleteFile(nFile file)
        {

            return Filesystem.Remove(file);

        }
        
        public List<nFile> GetChildren(nFile file)
        {
            return Filesystem.FindAll(f => f.Fullname.StartsWith(file.Fullname));
        }

        public bool RenameFile(nFile file, string NewName)
        {
            List<nFile> child = GetChildren(file);
            string OldName = file.Shortname;

            foreach (var f in child)
            {
                f.Fullname = ParentOf(file)
            }
        }
      
        





    }
}
