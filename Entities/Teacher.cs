using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationInfDataWcfService.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
            StudGroups = new HashSet<StudGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }

        public int? FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<StudGroup> StudGroups { get; set; }
    }
}