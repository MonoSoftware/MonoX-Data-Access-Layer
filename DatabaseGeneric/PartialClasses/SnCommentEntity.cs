using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;
using MonoSoftware.Web.AntiSpam;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class SnCommentEntity : IAntiSpamContent
    {


        #region IAntiSpamContent Members

        public string Content
        {
            get
            {
                return this.Comment;
            }
            set
            {
                this.Comment = value;
            }
        }

        public string ContentAuthor
        {
            get
            {
                if (!String.IsNullOrEmpty(this.Author))
                    return this.Author;
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
                if (!String.IsNullOrEmpty(this.Email))
                    return this.Email;

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
                return this.Website;
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

        DateTime IAntiSpamContent.DateCreated
        {
            get
            {
                return this.DateCreated;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
