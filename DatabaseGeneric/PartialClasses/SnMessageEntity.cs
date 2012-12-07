using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;
using MonoSoftware.Core;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class SnMessageEntity 
    {
        #region Properties
        public DateTime DateCreatedShort
        {
            get
            {
                if (DateCreated != null)
                    return DateTime.Parse(DateCreated.ToShortDateString());
                else
                    return DateTime.UtcNow;
            }
        }

        public string ToListShort
        {
            get
            {
                if (this.ToList.Length > 50)
                    return this.ToList.ToTrimmedWordString(50);
                else
                    return this.ToList;
            }
        }
        #endregion


        #region Methods
        public bool IsRead(Guid userId)
        {
            if (this.SnMessageRecipients != null)
            {
                SnMessageRecipientEntity recipient = this.SnMessageRecipients.FirstOrDefault(p => p.UserId.Equals(userId));
                return (recipient != null && recipient.DateRead.HasValue);
            }
            return false;
        } 
        #endregion 
        
    }
}
