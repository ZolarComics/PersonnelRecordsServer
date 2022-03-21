using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class EducationApi : ApiBaseType
    {
        public string EducationalPlace { get; set; }
        public string Speciality { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
