using ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.db
{
    public partial class Education
    {
        public static explicit operator EducationApi(Education education)
        {
            if (education == null)
                return null;
            return new EducationApi
            {
                Id = education.Id,
                EducationalPlace = education.EducationalPlace,
                Speciality = education.Speciality,
                ReceiptDate = education.ReceiptDate,
                ExpirationDate = education.ExpirationDate
            };
        }
        public static explicit operator Education(EducationApi education)
        {
            if (education == null)
                return null;
            return new Education
            {
                Id = education.Id,
                EducationalPlace = education.EducationalPlace,
                Speciality = education.Speciality,
                ReceiptDate = education.ReceiptDate,
                ExpirationDate = education.ExpirationDate

            };
        }
    }
}
