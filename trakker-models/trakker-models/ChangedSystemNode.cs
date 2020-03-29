using System;
using System.Collections.Generic;
using System.Text;

namespace trakker_models
{
    // CR: Change the internal modifier to public
    // CR: (Kfir) Move this to a separate file
    internal enum ChangedSystemNodeStatus
    {
        New,
        Deleted,
        Modified
    }

    // CR: (Kfir) Don't ignore ReSharper (this should be public)
    // CR: (Kfir) The name should be ChangedFileSystemNode
    class ChangedSystemNode : FileSystemNode
    {
        public ulong NewSize { get; set; }
        public ChangedSystemNodeStatus Status { get; set; }
    }
}
