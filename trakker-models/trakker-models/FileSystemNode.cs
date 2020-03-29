using System;
using System.Collections.Generic;
using System.Text;

namespace trakker_models
{
    // CR: Change the internal modifier to public
    internal abstract class FileSystemNode
    {
        public ulong Size { get; set; }
        public string Path { get; set; }
    }
}
