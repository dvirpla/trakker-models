using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    public class FileInfo : FileSystemNode
    {
        public FileInfo(ulong size, string fullPath) : base(size, fullPath)
        {
        }

        public FileInfo(string fullPath) : base(fullPath)
        {
            // CR: TrakkerModels shouldn't contain logic; let this come from outside
            this.Size = (ulong) new System.IO.FileInfo(fullPath).Length;
        }
    }
}
