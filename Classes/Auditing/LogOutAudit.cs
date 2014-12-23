using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonoSoftware.MonoX.DAL.Auditing
{
    /// <summary>
    /// Auditing in/out class.
    /// </summary>
    [Serializable]
    public class LogOutAudit
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
        /// Log out date.
        /// </summary>
        public DateTime LogoutDate { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        public LogOutAudit(string userName, Guid userId, string userEmail, DateTime logoutDate)
        {
            UserName = userName;
            UserId = userId;
            UserEmail = userEmail;
            LogoutDate = logoutDate;
        }
        #endregion
    }
}
