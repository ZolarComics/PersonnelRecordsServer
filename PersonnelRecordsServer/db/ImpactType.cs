using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class ImpactType
    {
        public ImpactType()
        {
            Archives = new HashSet<Archive>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Archive> Archives { get; set; }
    }
}
