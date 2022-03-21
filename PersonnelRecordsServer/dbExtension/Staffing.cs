using ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.db
{
    public partial class Staffing
    {
        public static explicit operator StaffingApi(Staffing staffing)
        {
            return new StaffingApi
            {
                Id = staffing.Id,
                Position = staffing.Position,
                Salary = staffing.Salary,
                WorkerId = staffing.WorkerId,
                Note = staffing.Note,
                CompanyId = staffing.CompanyId
            };
        }

        public static explicit operator Staffing(StaffingApi staffing)
        {
            return new Staffing
            {
                Id = staffing.Id,
                Position = staffing.Position,
                Salary = staffing.Salary,
                WorkerId = staffing.WorkerId,
                Note = staffing.Note,
                CompanyId = staffing.CompanyId
            };
        }
    }
}
