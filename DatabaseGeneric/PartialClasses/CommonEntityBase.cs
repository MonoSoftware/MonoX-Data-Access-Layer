using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using MonoSoftware.MonoX.Common.DependencyInjection;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class CommonEntityBase
    {
        #region Methods
        protected override void OnInitialized()
        {
            base.OnInitialized();
            var auditor = new Auditing.AnalyticsAuditor();
            this.AuditorToUse = auditor;
        }
        #endregion
    }
}
