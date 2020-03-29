using System;
using System.Collections.Generic;
using System.Text;

namespace trakker_models
{
    class ChangedDirectory : ChangedSystemNode
    {
        public List<FileSystemNode> Children { get; set; }
    }
}
