using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class CompanyApi : ApiBaseType
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

    }
}
