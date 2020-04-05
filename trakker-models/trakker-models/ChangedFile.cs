using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    public class ChangedFile : ChangedFileSystemNode
    {
        public ChangedFile(string fullPath, ulong size, ChangedSystemNodeStatus status)
        {
            this.FullPath = fullPath;
            this.Size = size;
            this.Status = status;
        }
        public ChangedFile(string fullPath, ulong size, ChangedSystemNodeStatus status, FileSystemNode oldFileSystemNode)
        {
            this.FullPath = fullPath;
            this.Size = size;
            this.Status = status;
            this.OldFileSystemNode = oldFileSystemNode;
        }
    }
}
