using System;
using System.Collections.Generic;
using System.Text;

namespace trakker_models
{
    internal class DirectoryInfo : FileSystemNode
    {
        public List<FileSystemNode> Children { get; set; }
    }
}
