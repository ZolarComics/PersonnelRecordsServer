using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class ArchiveApi : ApiBaseType
    {
        public DateTime? MakedDate { get; set; }
        public string NewStatus { get; set; }
        public string OldStatus { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? StaffingId { get; set; }
        public int? ImpactTypeId { get; set; }
        public int? WorkerId { get; set; }
    }
}
