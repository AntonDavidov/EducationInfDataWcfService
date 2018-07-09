using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationInfDataWcfService.Entities
{
    public partial class CheckPoint
    {
        public CheckPoint()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; } = 0;
        public int? SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}