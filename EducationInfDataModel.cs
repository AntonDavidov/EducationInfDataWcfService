using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Data.Entity;
using EducationInfDataWcfService.Entities;

namespace EducationInfDataWcfService
{
    public partial class EducationInfDataModel: DbContext
    {
        SqlRoleProvider sqlRoleProvider;

        public EducationInfDataModel(): 
            base("EducationInfDataModel")
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<CheckPoint> CheckPoints { get; set; }
        public virtual DbSet<StudGroup> StudGroups { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        [WebInvoke]
        public void CreateNewRole()
        {
            sqlRoleProvider = new SqlRoleProvider();
            sqlRoleProvider.CreateRole("Administrators");
        }
    }
}