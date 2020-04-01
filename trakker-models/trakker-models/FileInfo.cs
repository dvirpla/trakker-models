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

        public FileInfo(string fullPath) : base(fullPath)
        {
            // CR: Try to think of a way to remove this logic from here. TrakkerModels shouldn't contain logic.
            this.Size = (ulong) new System.IO.FileInfo(fullPath).Length;
        }
    }
}
