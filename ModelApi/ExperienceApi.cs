using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class ExperienceApi : ApiBaseType
    {
        public int? WorkerId { get; set; }
        public string PositionName { get; set; }
        public int? WorkPeriod { get; set; }
    }
}
