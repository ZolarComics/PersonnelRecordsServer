using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Education
    {
        public Education()
        {
            Workers = new HashSet<Worker>();
        }

        public int Id { get; set; }
        public string EducationalPlace { get; set; }
        public string Speciality { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}
