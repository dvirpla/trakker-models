using System;
using System.Collections.Generic;
using System.Text;

// CR: Change the namespace to CamelCase
namespace trakker_models
{
    public class Snapshot
    {
        public Guid Uuid { get; set; }
        public DateTime Time { get; set; }
        public DriveInfo Drive { get; set; }

        //CR: Where is the list of Drive info?
        // CRR: (Kfir) We decided that snapshots are per-drive, so each one holds 1 drive only
    }
}
