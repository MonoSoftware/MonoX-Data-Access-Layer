using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;
using MonoSoftware.Web.AntiSpam;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class BlogPostEntity : IAntiSpamContent
    {
        #region Properties
        
        #endregion

        #region IAntiSpamContent Members

        public string Content
        {
            get
            {
                return this.PostContent;
            }
            set
            {
                this.PostContent = value;
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
                return this.Title;
            }
            set
            {
                this.Title = value;
            }
        }

        public string ContentType
        {
            get
            {
                return "blog";
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
                return this.DateCreated.GetValueOrDefault();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Ip
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsApproved
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSpam
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Referrer
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Signature
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal Spaminess
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string UserAgent
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
