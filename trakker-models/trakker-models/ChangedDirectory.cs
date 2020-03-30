using System;
using System.Collections.Generic;
using System.Text;
using TrakkerModels;

namespace TrakkerModels
{
    public class ChangedDirectory : ChangedFileSystemNode
    {
        public List<FileSystemNode> Children { get; set; }

    }
}
