using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class StaffingApi : ApiBaseType
    {
        public string Position { get; set; }
        public decimal? Salary { get; set; }
        public int? WorkerId { get; set; }
        public string Note { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public int? CompanyId { get; set; }
    }
}
