using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Experience
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? StaffingId { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? WorkerId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Staffing Staffing { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
