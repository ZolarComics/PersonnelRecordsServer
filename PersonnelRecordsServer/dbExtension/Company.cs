using ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.db
{
    public partial class Company
    {
        public static explicit operator CompanyApi(Company company)
        {
            return new CompanyApi { Id = company.Id, Adress = company.Adress, Description = company.Description,
                Name = company.Name, Owner = company.Owner, Phone = company.Phone, };
        }

        public static explicit operator Company(CompanyApi company)
        {
            return new Company {
                Id = company.Id,
                Adress = company.Adress,
                Description = company.Description,
                Name = company.Name,
                Owner = company.Owner,
                Phone = company.Phone,
            };
        }
    }
}
