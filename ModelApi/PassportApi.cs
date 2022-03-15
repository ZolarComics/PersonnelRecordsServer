using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class PassportApi : ApiBaseType
    {
        public int? Series { get; set; }
        public int? Number { get; set; }
        public DateTime? ВateOfIssue { get; set; }
        public string IssuedBy { get; set; }
        public string DivisionСode { get; set; }
        public string Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Registration { get; set; }
    }
}
