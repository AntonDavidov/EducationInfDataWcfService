using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace EducationInfDataWcfService.Entities
{
    public partial class Student
    {
        public Student()
        {
            CheckPoints = new HashSet<CheckPoint>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }

        public int? FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public int? StudGroupId { get; set; }
        public virtual StudGroup StudGroup { get; set; }
        public virtual ICollection<CheckPoint> CheckPoints { get; set; }
    }
}