using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    public class ChangedFileSystemNode : FileSystemNode
    {
        public ulong OldSize { get; set; }
        public ChangedSystemNodeStatus Status { get; set; }

        
    }
}
