using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;
using MonoSoftware.Core;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class FriendSuggestionTypedViewEntryEntity
    {
        #region Properties
        /// <summary>
        /// Gets the user display name.
        /// </summary>
        public string UserDisplayName
        {
            get
            {
                UserProfileEntity userProfile = new UserProfileEntity(this.UserId);
                using (IDataAccessAdapter adapter = MonoSoftware.Web.Workspace.WebContext.GetContext(typeof(UserProfileEntity).Assembly).GetAdapter())
                {
                    if (adapter.FetchEntity(userProfile))
                    {
                        return userProfile.UserDisplayName;
                    }
                }
                return this.UserName;
            }
        }
        #endregion
        
    }
}
