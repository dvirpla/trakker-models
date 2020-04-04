using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    [Serializable]
    public class DirectoryInfo : FileSystemNode
    {
        public List<FileSystemNode> Children { get; set; }
        public bool CanAccess;

        public DirectoryInfo(ulong size, string fullPath, bool canAccess=true) : base(size, fullPath)
        {
            CanAccess = canAccess;
            this.Children = new List<FileSystemNode>();
        }

        public DirectoryInfo(string fullPath, bool canAccess=true) : base(fullPath)
        {
            CanAccess = canAccess;
            this.FullPath = fullPath;
            this.Children = new List<FileSystemNode>();
        }

        public DirectoryInfo(string fullPath, List<FileSystemNode> children, bool canAccess=true) : base(fullPath)
        {
            this.Children = children;
            CanAccess = canAccess;
        }

        public DirectoryInfo(string fullPath, List<FileSystemNode> children,ulong size, bool canAccess=true) : base(size,fullPath)
        {
            this.Children = children;
            CanAccess = canAccess;
        }
    }
}
