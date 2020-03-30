using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    public class DriveInfo
    {
        public string Name { get; set; }
        public List<FileSystemNode> Children { get; set; }

        public DriveInfo(string name)
        {
            this.Name = name;
            this.Children = new List<FileSystemNode>();
        }

        public DriveInfo(string name, DirectoryInfo directory)
        {
            this.Name = name;
            this.Children = directory.Children;
        }
    }
}
