using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using logical_fs_model.Exceptions;

namespace logical_fs_model.Classes
{
    public interface nItem : IDisposable, ICloneable
    {
        Guid GUID { get; }
        int Size { get; set; }
        int FirstDataCluster { get; set; }
        int FilerecordOffset { get; set; }
        string Fullname { get; }
        string Shortname{ get; }
        string Name { get; set; }
        nDirectory Parent { get; set; }


    }
}
