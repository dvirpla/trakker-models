using System;
using System.Collections.Generic;
using System.Text;

namespace trakker_models
{
    // CR: Change the internal modifier to public
    internal enum ChangedSystemNodeStatus
    {
        New,
        Deleted,
        Modified
    }
    class ChangedSystemNode : FileSystemNode
    {
        public ulong NewSize { get; set; }
        public ChangedSystemNodeStatus Status { get; set; }
    }
}
