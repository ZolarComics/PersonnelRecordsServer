using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Passport
    {
        public Passport()
        {
            Workers = new HashSet<Worker>();
        }

        public int Id { get; set; }
        public int? Series { get; set; }
        public int? Number { get; set; }
        public DateTime? ВateOfIssue { get; set; }
        public string IssuedBy { get; set; }
        public string DivisionСode { get; set; }
        public string Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Registration { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}
