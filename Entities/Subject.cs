using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationInfDataWcfService.Entities
{
    public partial class Subject
    {
        public Subject()
        {
            Teachers = new HashSet<Teacher>();
            StudGroups = new HashSet<StudGroup>();
            CheckPoints = new HashSet<CheckPoint>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int? FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<StudGroup> StudGroups { get; set; }
        public virtual ICollection<CheckPoint> CheckPoints { get; set; }
    }
}