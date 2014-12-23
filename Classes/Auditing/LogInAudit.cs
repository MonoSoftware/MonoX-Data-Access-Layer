using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonoSoftware.MonoX.DAL.Auditing
{
    [Serializable]
    public class LogInAudit
    {
        #region Properties
        
        /// <summary>
        /// User Id.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// User nane.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// User e-mail.
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// User e-mail.
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Log in date.
        /// </summary>
        public DateTime LoginDate { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        public LogInAudit(string userName, Guid userId, string userEmail, string provider, DateTime loginDate)
        {
            UserName = userName;
            UserId = userId;
            UserEmail = userEmail;
            Provider = provider;
            LoginDate = loginDate;
        }
        #endregion
    }
}
