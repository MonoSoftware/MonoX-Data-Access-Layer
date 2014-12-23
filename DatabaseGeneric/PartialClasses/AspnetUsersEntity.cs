using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;
using MonoSoftware.Web.AntiSpam;
using MonoSoftware.MonoX.Common.DependencyInjection;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class AspnetUsersEntity 
    {

        #region Properties
        private string _userDisplayName = String.Empty;
        /// <summary>
        /// Gets or sets the user display name.
        /// </summary>        
        public string UserDisplayName
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_userDisplayName))
                {
                    if ((this.UserProfile != null) && (!String.IsNullOrEmpty(UserProfile.FirstName) || !String.IsNullOrEmpty(UserProfile.LastName)))
                        _userDisplayName = String.Format("{0} {1}", UserProfile.FirstName, UserProfile.LastName).Trim(' ');
                    else
                        _userDisplayName = this.UserName;
                }
                return _userDisplayName;
            }
            set
            {
                _userDisplayName = value;
            }
        }

        public string UserNameUrlEncoded
        {
            get
            {
                return MonoSoftware.Web.UrlEncoder.UrlEncode(this.UserName);
            }
        }

        public string Email
        {
            get
            {
                if (this.AspnetMembership != null)
                    return this.AspnetMembership.Email;

                return String.Empty;
            }
        }

        public string IsApproved
        {
            get
            {
                if (this.AspnetMembership != null)
                    return this.AspnetMembership.IsApproved.ToString();

                return String.Empty;
            }
        }

        public string IsLockedOut
        {
            get
            {
                if (this.AspnetMembership != null)
                    return this.AspnetMembership.IsLockedOut.ToString();

                return String.Empty;
            }
        }

        public int FailedPasswordAttemptCount
        {
            get
            {
                if (this.AspnetMembership != null)
                    return this.AspnetMembership.FailedPasswordAttemptCount;

                return 0;
            }
        }

        public int FailedPasswordAnswerAttemptCount
        {
            get
            {
                if (this.AspnetMembership != null)
                    return this.AspnetMembership.FailedPasswordAnswerAttemptCount;

                return 0;
            }
        }
        #endregion       
    }
}
