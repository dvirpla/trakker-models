using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    [Serializable]
    public class FileInfo : FileSystemNode
    {
        public FileInfo(ulong size, string fullPath) : base(size, fullPath)
        {
        }

        
    }
}
