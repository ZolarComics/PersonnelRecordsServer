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
                MakedDate = archive.MakedDate,
                NewStatus = archive.NewStatus,
                OldStatus = archive.OldStatus,
                DateStart = archive.DateStart,
                DateEnd = archive.DateEnd,
                StaffingId = archive.StaffingId,
                ImpactTypeId = archive.ImpactTypeId,
                WorkerId = archive.WorkerId
            };
        }

        public static explicit operator Archive(ArchiveApi archive)
        {
            return new Archive
            {
                Id = archive.Id,
                MakedDate = archive.MakedDate,
                NewStatus = archive.NewStatus,
                OldStatus = archive.OldStatus,
                DateStart = archive.DateStart,
                DateEnd = archive.DateEnd,
                StaffingId = archive.StaffingId,
                ImpactTypeId = archive.ImpactTypeId,
                WorkerId = archive.WorkerId
            };
        }
    }
}
