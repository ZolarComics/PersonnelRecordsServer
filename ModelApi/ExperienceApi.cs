using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class ExperienceApi : ApiBaseType
    {
        public int? CompanyId { get; set; }
        public int? StaffingId { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? WorkerId { get; set; }
    }
}
