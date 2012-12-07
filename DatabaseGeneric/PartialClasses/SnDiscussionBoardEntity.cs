using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class SnDiscussionBoardEntity
    {
        /// <summary>
        /// Board moderator names string (comma-separated).
        /// </summary>
        public string ModeratorNames
        {
            get
            {
                string toReturn = string.Empty;
                if (this.SnDiscussionBoardModerators != null)
                {
                    foreach (SnDiscussionBoardModeratorEntity moderator in this.SnDiscussionBoardModerators)
                    {
                        if (moderator.AspnetUsers != null)
                        {
                            if (string.IsNullOrEmpty(toReturn))
                                toReturn = moderator.AspnetUsers.UserName;
                            else
                                toReturn = string.Format("{0},{1}", toReturn, moderator.AspnetUsers.UserName);
                        }
                    }
                }
                return toReturn;
            }
        }

        /// <summary>
        /// Gets or sets the last topic posted to the board.
        /// <para>
        /// Note: This property is null by default it is automatically set by the appropriate method in discussion repository.
        /// </para>
        /// </summary>
        public SnDiscussionTopicEntity LastTopic { get; set; }

        /// <summary>
        /// Gets the author of the last topic if any.
        /// </summary>
        public AspnetUsersEntity LastTopicAuthor
        {
            get
            {
                if ((LastTopic != null) && (LastTopic.AspnetUser != null))
                    return LastTopic.AspnetUser;
                return null;
            }
        }

        /// <summary>
        /// Gets or sets the last post posted to the board.
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
    }
}
