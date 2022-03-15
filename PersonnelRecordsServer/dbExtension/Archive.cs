using ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.db
{
    public partial class Archive
    {
        public static explicit operator ArchiveApi(Archive archive)
        {
            return new ArchiveApi
            {
                Id = archive.Id,
                StaffingId = archive.StaffingId,
                TypeOfImpactId = archive.TypeOfImpactId
            };
        }

        public static explicit operator Archive(ArchiveApi archive)
        {
            return new Archive
            {
                Id = archive.Id,
                StaffingId = archive.StaffingId,
                TypeOfImpactId = archive.TypeOfImpactId
            };
        }
    }
}
