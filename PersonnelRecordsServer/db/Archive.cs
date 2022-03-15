using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Archive
    {
        public int Id { get; set; }
        public int? StaffingId { get; set; }
        public int? TypeOfImpactId { get; set; }

        public virtual Staffing Staffing { get; set; }
        public virtual ImpactType TypeOfImpact { get; set; }
    }
}
