using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    public class DirectoryInfo : FileSystemNode
    {
        public List<FileSystemNode> Children { get; set; }

        public DirectoryInfo(ulong size, string fullPath) : base(size, fullPath)
        {
            this.Children = new List<FileSystemNode>();
        }

        public DirectoryInfo(string fullPath) : base(fullPath)
        {
            this.FullPath = fullPath;
            this.Children = new List<FileSystemNode>();
        }
    }
}
