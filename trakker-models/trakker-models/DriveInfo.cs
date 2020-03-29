using System;
using System.Collections.Generic;
using System.Text;

namespace trakker_models
{
    // CR: Change the internal modifier to public
    internal class DriveInfo
    {
        public string Name { get; set; }
        public List<FileSystemNode> Children { get; set; }

    }
}
