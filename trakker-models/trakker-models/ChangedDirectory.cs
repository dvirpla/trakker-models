using System;
using System.Collections.Generic;
using System.Text;
using TrakkerModels;

namespace TrakkerModels
{
    public class ChangedDirectory : ChangedFileSystemNode
    {
        public List<FileSystemNode> Children { get; set; }

        public ChangedDirectory(string fullPath, ulong size, List<FileSystemNode> children, ChangedSystemNodeStatus status)
        {
            this.FullPath = fullPath;
            this.Size = size;
            this.Status = status;
            this.Children = children;
        }
        public ChangedDirectory(string fullPath, ulong size, List<FileSystemNode> children, ChangedSystemNodeStatus status, ulong oldSize)
        {
            this.FullPath = fullPath;
            this.Size = size;
            this.Status = status;
            this.OldSize = oldSize;
            this.Children = children;
        }

    }
}
