using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.DatabaseGeneric.Resources;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class SnGroupRequestEntity
    {
        #region Properties
        /// <summary>
        /// Gets group member custom display format.
        /// </summary>
        public string DisplayInfo
        {
            get
            {
                string info = String.Empty;
                if (this.AspnetUser != null)
                    info += this.AspnetUser.UserName;
                if (this.DateAccepted.HasValue)
                    info += String.Format(" [{0}: {1}] ", DefaultResource.DateAccepted, this.DateAccepted.GetValueOrDefault());
                return info;
            }
        }
        #endregion
    }
}
