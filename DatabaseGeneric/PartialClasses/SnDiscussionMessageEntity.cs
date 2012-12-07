using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.Web.AntiSpam;
using MonoSoftware.MonoX.DAL.HelperClasses;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class SnDiscussionMessageEntity : IAntiSpamContent
    {
        #region Properties
        private EntityCollection<SnFileEntity> _files = null;
        /// <summary>
        /// Gets the attached files.
        /// </summary>
        public EntityCollection<SnFileEntity> Files
        {
            get
            {
                if (_files == null)
                {
                    _files = new EntityCollection<SnFileEntity>();
                    this.SnRelationships.Where(p => p.SnFiles.Count > 0).ToList().ForEach(p => p.SnFiles.ToList().ForEach(s => _files.Add(s)));
                }
                return _files;
            }
        }
        #endregion

        #region IAntiSpamContent Members

        public string Content
        {
            get
            {
                return this.Message;
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
