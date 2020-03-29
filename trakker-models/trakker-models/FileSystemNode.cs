using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    public abstract class FileSystemNode
    {
        /// <summary>
        /// This Size is in bytes.
        /// </summary>
        public ulong Size { get; set; }

        public string FullPath { get; set; }
    }
}
