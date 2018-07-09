using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace EducationInfDataWcfService
{
    public class UsingOfSqlRoleProvider: SqlRoleProvider
    {
        public UsingOfSqlRoleProvider(): base()
        {
        }

        public void CreateNewRole()
        {
            CreateRole("Administrators");
        }
    }
}