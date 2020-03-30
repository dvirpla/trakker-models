﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    [Serializable]
    public abstract class FileSystemNode
    {
        /// <summary>
        /// This Size is in bytes.
        /// </summary>
        public ulong Size { get; set; }

        public string FullPath { get; set; }

        protected FileSystemNode(ulong size, string fullPath)
        {
            this.Size = size;
            this.FullPath = fullPath;
        }

        protected FileSystemNode(string fullPath)
        {
            this.FullPath = fullPath;
        }

        protected FileSystemNode()
        {

        }
    }
}
