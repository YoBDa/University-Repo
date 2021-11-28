using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Exceptions
{
    public class FileOrDirectoryNotExistException : Exception
    {
        public FileOrDirectoryNotExistException(string Filename)
            : base($"File or directory exist : {Filename}")
        {

        }
    }
}
