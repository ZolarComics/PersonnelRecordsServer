using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Worker
    {
        public Worker()
        {
            Archives = new HashSet<Archive>();
            Experiences = new HashSet<Experience>();
            Staffings = new HashSet<Staffing>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? EducationId { get; set; }
        public int? PassportId { get; set; }

        public virtual Education Education { get; set; }
        public virtual Passport Passport { get; set; }
        public virtual ICollection<Archive> Archives { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Staffing> Staffings { get; set; }
    }
}
