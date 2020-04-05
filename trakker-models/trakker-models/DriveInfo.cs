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

        // CR: (Kfir) It's weird to have a parameter that is a parent class. Demand the children instead.
        //     Also demand size here (we don't need 3 different overloads)
        public DriveInfo(string name, DirectoryInfo directory) : base(name,directory.Children)
        {
        }
        public DriveInfo(string name, DirectoryInfo directory,ulong size) : base(name, directory.Children,size)
        {
        }
    }
}
