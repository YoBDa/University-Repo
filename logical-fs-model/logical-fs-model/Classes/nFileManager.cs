using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logical_fs_model.Exceptions;

namespace logical_fs_model.Classes
{
    public class nFileManager
    {
        private static readonly string ForbiddenFilenameCharacters = "/\\:*+?<>\"";
        public nFileManager()
        {
            nItem root = new nDirectory("");
            CurrentDirectory = root;
            Filesystem.Add(root);
        }
        
        public nDirectory CurrentDirectory { get; set; }
        public List<nItem> ListOfFiles(nItem Directory)
        {
            return CurrentDirectory.Child;
        }

        public List<nItem> ListOfFilesHere()
        {
            return ListOfFiles(CurrentDirectory);
        }


        public bool CreateFileHere(bool IsDirectory, string Filename, uint Size=0)
        {
            return CreateFile(IsDirectory, CurrentDirectory, Filename, Size);
        }
        public bool CreateFile(bool IsDirectory, nDirectory Directory, string Filename, uint Size=0)
        {
            try
            {
                if (IsDirectory)
                    Directory.AppendChild(new nDirectory(Filename));
                else
                    Directory.AppendChild(new nFile(Filename, Size));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool MoveFile(nItem file, nDirectory toDirectory)
        {
            nDirectory oldParent = file.Parent;
            try
            {
                oldParent.RemoveChild(file);
                file.Parent = toDirectory;
                toDirectory.AppendChild(file);
                return true;
            }
            catch (FileOrDirectoryNotExistsException ex)
            {
                return false;
            }
            catch (FileOrDirectoryExistException ex)
            {
                file.Parent = oldParent;
                oldParent.AppendChild(file);
                return false;
            }

        }
        public bool DeleteFile(nItem file)
        {

            try
            {
                file.Parent.RemoveChild(file);
                file.Dispose();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool RenameFile(nItem file, string NewName)
        {
            if ()
            file.Name = NewName;
        }
      
        





    }
}
