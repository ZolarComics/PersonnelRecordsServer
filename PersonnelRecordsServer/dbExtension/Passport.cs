using ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.db
{
    public partial class Passport
    {
        public static explicit operator PassportApi(Passport passport)
        {
            return new PassportApi
            {
                Id = passport.Id,
                DateOfBirth = passport.DateOfBirth,
                Series = passport.Series,
                DivisionСode = passport.DivisionСode,
                IssuedBy = passport.IssuedBy,
                Number = passport.Number,
                Sex = passport.Sex,
                Registration = passport.Registration,
                ВateOfIssue = passport.ВateOfIssue,
            };
        }

        public static explicit operator Passport(PassportApi passport)
        {
            return new Passport
            {
                Id = passport.Id,
                DateOfBirth = passport.DateOfBirth,
                Series = passport.Series,
                DivisionСode = passport.DivisionСode,
                IssuedBy = passport.IssuedBy,
                Number = passport.Number,
                Sex = passport.Sex,
                Registration = passport.Registration,
                ВateOfIssue = passport.ВateOfIssue,
            };
        }
    }
}
