using System;
using MonoSoftware.LLBLGen;
using MonoSoftware.MonoX.DAL.EntityClasses;
using MonoSoftware.Web;
using MonoSoftware.Core;
using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Xml;
using System.Web;
using MonoSoftware.MonoX.DAL.HelperClasses;

namespace MonoSoftware.MonoX.DAL.Auditing
{
    [Serializable]
    public class AnalyticsAuditor : Auditor
    {
        public AnalyticsAuditor()
            :base()
        {
            includedEntityTypes = new List<Type>()
            {
                typeof(UserProfileEntity)
            };
        }
    }

}
