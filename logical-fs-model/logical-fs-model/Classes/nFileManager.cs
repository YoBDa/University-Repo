﻿using System;
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
            nDirectory root = new nDirectory("");
            CurrentDirectory = root;
        }
        
        public nDirectory CurrentDirectory { get; set; }
        public List<nItem> ListOfFiles(nDirectory Directory)
        {
            return Directory.Child;
        }

        public List<nItem> ListOfFilesHere()
        {
            return ListOfFiles(CurrentDirectory);
        }

        private bool CheckFilename(string Filename)
        {
            if (Filename.IndexOfAny(ForbiddenFilenameCharacters.ToCharArray()) != -1)
                return false;
            else return true;
        }

        public bool CreateFileHere(bool IsDirectory, string Filename, uint Size=0)
        {
            return CreateFile(IsDirectory, CurrentDirectory, Filename, Size);
        }
        public bool CreateFile(bool IsDirectory, nDirectory Directory, string Filename, uint Size=0)
        {
            try
            {
                if (!CheckFilename(Filename)) return false;
                if (IsDirectory)
                    Directory.AppendChild(new nDirectory(Filename) { Parent = Directory});
                else
                    Directory.AppendChild(new nFile(Filename, Size) { Parent = Directory });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CopyFile(nItem file, nDirectory toDirectory, string withName="")
        {
            withName = (string.IsNullOrWhiteSpace(withName)) ? file.Name : withName;
            if (!CheckFilename(withName)) return false;
            nItem newFile = (nItem)file.Clone();
            try
            {
                newFile.Name = withName;
                toDirectory.AppendChild(newFile);
                newFile.Parent = toDirectory;
                return true;
            }
            catch (FileOrDirectoryExistException ex)
            {
                newFile.Dispose();
                return false;
            }

        }

        public bool MoveFile(nItem file, nDirectory toDirectory, string withName = "")
        {
            withName = (string.IsNullOrWhiteSpace(withName)) ? file.Name : withName;
            string oldName = file.Name;
            nDirectory oldParent = file.Parent;
            if (!CheckFilename(withName)) return false;
            try
            {
                oldParent.RemoveChild(file);
                file.Name = withName;
                toDirectory.AppendChild(file);
                file.Parent = toDirectory;
                
                return true;
            }
            catch (FileOrDirectoryExistException ex)
            {
                file.Name = oldName;
                file.Parent = oldParent;
                return false;
            }
            catch (FileOrDirectoryNotExistException ex)
            {
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

        public bool RenameFile(nItem file, string newName)
        {
            return MoveFile(file, file.Parent, newName);
        }
      
        





    }
}
