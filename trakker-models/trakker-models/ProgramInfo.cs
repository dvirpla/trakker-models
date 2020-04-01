﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrakkerModels
{
    public class ProgramInfo : FileSystemNode
    {
        // CR: Add a constructor for this property also.
        public string ProgramDirectoryPath { get; set; }

        public string Icon { get; set; }

        public ProgramInfo(string name) : base(name)
        {
        }

        public ProgramInfo(string name, string icon) : base(name)
        {
            this.Icon = icon;
        }


    }
}
