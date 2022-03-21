using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Archive
    {
        public int Id { get; set; }
        public DateTime? MakedDate { get; set; }
        public string NewStatus { get; set; }
        public string OldStatus { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? StaffingId { get; set; }
        public int? ImpactTypeId { get; set; }
        public int? WorkerId { get; set; }

        public virtual ImpactType ImpactType { get; set; }
        public virtual Staffing Staffing { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
