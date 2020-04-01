using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    [Serializable]
    public class DriveInfo : DirectoryInfo
    {

        public DriveInfo(string name) : base(name)
        {
            this.Children = new List<FileSystemNode>();
        }

        public DriveInfo(string name, DirectoryInfo directory) : base(name,directory.Children)
        {
        }
        public DriveInfo(string name, DirectoryInfo directory,ulong size) : base(name, directory.Children,size)
        {
        }
    }
}
