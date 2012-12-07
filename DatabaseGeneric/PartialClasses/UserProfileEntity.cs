using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;
using MonoSoftware.Web.AntiSpam;
using SD.LLBLGen.Pro.ORMSupportClasses;
using MonoSoftware.Web;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class UserProfileEntity 
    {
        #region Fields
        const string currentContextKey = "__MonoSoftware.MonoX.DAL.EntityClasses.UserProfileEntity.Current";
        #endregion

        #region Properties
        /// <summary>
        /// Gets the user display name.
        /// </summary>
        public string UserDisplayName
        {
            get
            {
                if (!String.IsNullOrEmpty(this.FirstName) || !String.IsNullOrEmpty(this.LastName))
                    return String.Format("{0} {1}", this.FirstName, this.LastName);
                return UserName;
            }
        }

        /// <summary>
        /// Gets the user short display name.
        /// </summary>
        public string UserShortDisplayName
        {
            get
            {
                string result = this.FirstName;
                if (String.IsNullOrEmpty(result))
                    result = this.LastName;
                if (String.IsNullOrEmpty(result))
                    result = UserName;
                return result;
            }
        }

        /// <summary>
        /// Gets the user name.
        /// </summary>
        public string UserName
        {
            get
            {
                if (this.AspnetUser != null)
                    return this.AspnetUser.UserName;
                return String.Empty;
            }
        }

        /// <summary>
        /// Gets the current user's cached profile.
        /// </summary>
        public static UserProfileEntity Current
        {
            get
            {
                return (System.Web.HttpContext.Current.Items[currentContextKey] ??
                    (System.Web.HttpContext.Current.Items[currentContextKey] = GetCurrentProfile())) as UserProfileEntity;
            }
        }        
        #endregion       

        #region Methods
        private static UserProfileEntity GetCurrentProfile()
        {
            System.Web.Security.MembershipUser membershipUser = System.Web.HttpContext.Current.User.GetMembershipUser();
            if (membershipUser != null)
            {
                UserProfileEntity userProfile = new UserProfileEntity(membershipUser.GetProviderUserKey());
                using (IDataAccessAdapter adapter = MonoSoftware.Web.Workspace.WebContext.GetContext(typeof(UserProfileEntity).Assembly).GetAdapter())
                {
                    if (adapter.FetchEntity(userProfile))
                    {
                        return userProfile;
                    }
                }
            }
            return null;
        }
        #endregion
    }
}
