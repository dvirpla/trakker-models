using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    public class DirectoryInfo : FileSystemNode
    {
        public List<FileSystemNode> Children { get; set; }
    }
}
