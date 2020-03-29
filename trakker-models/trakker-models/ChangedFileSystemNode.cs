using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    public class ChangedFileSystemNode : FileSystemNode
    {
        public FileSystemNode OldFileSystemNode { get; set; }
        public Resources.ChangedSystemNodeStatus Status { get; set; }
    }
}
