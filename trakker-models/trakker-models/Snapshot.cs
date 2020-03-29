using System;
using System.Collections.Generic;
using System.Text;

namespace trakker_models
{
    public class Snapshot
    {
        public Guid Uuid { get; set; }
        public DateTime Time { get; set; }
        public DriveInfo Drive { get; set; }
    }
}
