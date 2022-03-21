using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Experience
    {
        public int Id { get; set; }
        public int? WorkerId { get; set; }
        public string PositionName { get; set; }
        public int? WorkPeriod { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
