using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.Web.AntiSpam;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class SnDiscussionTopicEntity : IAntiSpamContent
    {

        #region Properties
        /// <summary>
        /// Gets or sets the last message posted to the topic.
        /// <para>
        /// Note: This property is null by default it is automatically set by the appropriate method in discussion repository.
        /// </para>
        /// </summary>
        public SnDiscussionMessageEntity LastPost { get; set; }

        /// <summary>
        /// Gets the author of the last post if any.
        /// </summary>
        public AspnetUsersEntity LastPostAuthor
        {
            get
            {
                if ((LastPost != null) && (LastPost.AspnetUser != null))
                    return LastPost.AspnetUser;
                return null;
            }
        } 
        #endregion

        #region IAntiSpamContent Members

        public string Content
        {
            get
            {
                return this.Title;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ContentAuthor
        {
            get
            {
                if (this.AspnetUser != null)
                {
                    if (this.AspnetUser.UserProfile != null)
                        return String.Format("{0} {1}", AspnetUser.UserProfile.FirstName, AspnetUser.UserProfile.LastName);
                    return this.AspnetUser.UserName;
                }
                return String.Empty;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ContentAuthorEmail
        {
            get
            {
                if (this.AspnetUser != null)
                    return this.AspnetUser.Email;
                return String.Empty;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ContentAuthorUrl
        {
            get
            {
                return String.Empty;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ContentName
        {
            get
            {
                return String.Empty;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ContentType
        {
            get
            {
                return "comment";
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
