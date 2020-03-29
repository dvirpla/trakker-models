using System;
using System.Collections.Generic;
using System.Text;
using TrakkerModels;

namespace TrakkerModels
{
    public class ChangedDirectory : ChangedSystemNode
    {
        public List<FileSystemNode> Children { get; set; }
    }
}
