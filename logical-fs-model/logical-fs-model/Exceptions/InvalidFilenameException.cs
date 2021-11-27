using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_fs_model.Exceptions
{
    public class InvalidFilenameException : Exception
    {
        public InvalidFilenameException(string Filename)
            :base($"Invalid filename : {Filename}")
        {
            
        }
    }
}
