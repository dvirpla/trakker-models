using System;
using System.Collections.Generic;
using System.Text;

// CR: Change the namespace to CamelCase
namespace trakker_models
{
    // CR: "An internal modifier is used to prevent the use of a public modifier, which allows access to other assemblies wherever necessary."
    // CR: Change the internal modifier to public
    internal class Snapshot
    {
        public DateTime Time { get; set; }
        public DriveInfo Drive { get; set; }

        //CR: Where is the list of Drive info?
        // CRR: (Kfir) We decided that snapshots are per-drive, so each one holds 1 drive only
    }
}
