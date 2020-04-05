using System;
using System.Collections.Generic;
using System.Text;
using TrakkerModels;

namespace TrakkerModels
{
    public class ChangedDirectory : ChangedFileSystemNode
    {
        public List<FileSystemNode> Children { get; set; }

        public ChangedDirectory(string fullPath, ulong size, ChangedSystemNodeStatus status, List<FileSystemNode> children)
        {
            this.FullPath = fullPath;
            this.Size = size;
            this.Status = status;
            this.Children = children;
        }
        public ChangedDirectory(string fullPath, ulong size, ChangedSystemNodeStatus status, List<FileSystemNode> children, FileSystemNode oldFileSystemNode)
        {
            this.FullPath = fullPath;
            this.Size = size;
            this.Status = status;
            this.OldFileSystemNode = oldFileSystemNode;
            this.Children = children;
        }

    }
}
