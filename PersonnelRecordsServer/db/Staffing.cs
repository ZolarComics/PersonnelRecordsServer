using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Staffing
    {
        public Staffing()
        {
            Archives = new HashSet<Archive>();
        }

        public int Id { get; set; }
        public string Position { get; set; }
        public decimal? Salary { get; set; }
        public int? WorkerId { get; set; }
        public string Note { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual ICollection<Archive> Archives { get; set; }
    }
}
