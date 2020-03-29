using System;
using System.Collections.Generic;
using System.Text;

namespace trakker_models
{
    // CR: Change the internal modifier to public
    internal abstract class FileSystemNode
    {
        // CR: (Kfir) Add a "///" documentation and explain that the size is expressed in bytes
        public ulong Size { get; set; }

        // CR: (Kfir) Rename to "FullPath" to emphasize that the path is not relative to the parent
        public string Path { get; set; }
    }
}
