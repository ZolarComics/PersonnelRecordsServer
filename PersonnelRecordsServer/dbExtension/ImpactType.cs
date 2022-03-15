using ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.db
{
    public partial class ImpactType
    {
        public static explicit operator ImpactTypeApi(ImpactType impactType)
        {
            return new ImpactTypeApi
            {
                Id = impactType.Id,
                Type = impactType.Type
            };
        }

        public static explicit operator ImpactType(ImpactTypeApi impactType)
        {
            return new ImpactType
            {
                Id = impactType.Id,
                Type = impactType.Type
            };
        }
    }
}
