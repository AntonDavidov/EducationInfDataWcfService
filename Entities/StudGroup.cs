using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationInfDataWcfService.Entities
{
    public class StudGroup
    {
        public StudGroup()
        {
            Teachers = new HashSet<Teacher>();
            Subjects = new HashSet<Subject>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}