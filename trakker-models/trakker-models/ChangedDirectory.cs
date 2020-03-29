using System;
using System.Collections.Generic;
using System.Text;

namespace trakker_models
{
    public class ChangedDirectory : ChangedSystemNode
    {
        public List<FileSystemNode> Children { get; set; }
    }
}
