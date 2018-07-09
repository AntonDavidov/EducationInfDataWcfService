//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Security;

namespace EducationInfDataWcfService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class EducationInfDataServ : EntityFrameworkDataService<EducationInfDataModel>
    {
        SqlRoleProvider sqlRoleProvider;
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("Faculties", EntitySetRights.All);
            config.SetEntitySetAccessRule("Teachers", EntitySetRights.All);
            config.SetEntitySetAccessRule("Subjects", EntitySetRights.All);
            config.SetEntitySetAccessRule("CheckPoints", EntitySetRights.All);
            config.SetEntitySetAccessRule("StudGroups", EntitySetRights.All);
            config.SetEntitySetAccessRule("Students", EntitySetRights.All);
            config.MaxChangesetCount = 100;
            config.MaxObjectCountOnInsert = 50;
            config.SetServiceOperationAccessRule("CreateNewRole", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }

        [WebInvoke]
        public void CreateNewRole()
        {
            sqlRoleProvider = new SqlRoleProvider();
            sqlRoleProvider.CreateRole("Administrators");
        }
    }
}
