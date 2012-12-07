using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class SnEventTypeEntity
    {
        #region Properties
        /// <summary>
        /// Gets a SEO optimized name.
        /// </summary>
        public string SEOName
        {
            get
            {
                return MonoSoftware.Web.UrlSeoOptimizer.GetOptimizedString(this.Name);
            }
        }

        public bool IsPlainEvent
        {
            get { return Name == "plain event"; }
        }

        public bool IsSignedUp
        {
            get { return Name == "signed up"; }
        }

        public bool IsUpdatedProfile
        {
            get { return Name == "updated profile"; }
        }

        public bool IsBecameFriends
        {
            get { return Name == "became friends with"; }
        }

        public bool IsJoinedGroup
        {
            get { return Name == "joined the group"; }
        }

        public bool IsPostedBlogPost
        {
            get { return Name == "posted a blog post"; }
        }

        public bool IsPublishedAlbum
        {
            get { return Name == "published an album"; }
        }

        public bool IsAddedPhotoToAlbum
        {
            get { return Name == "added a photo"; }
        }

        public bool IsUploadedFile
        {
            get { return Name == "uploaded a file"; }
        }

        public bool IsAddedDiscussionBoard
        {
            get { return Name == "added a discussion board"; }
        }

        public bool IsAddedDiscussionTopic
        {
            get { return Name == "added a discussion topic"; }
        }

        public bool IsCreatedGroup
        {
            get { return Name == "created a group"; }
        }

        public bool IsUpdatedStatus
        {
            get { return Name == "updated status"; }
        }

        public bool IsWallNotePost
        {
            get { return Name == "Member posted a wall note"; }
        }

        public static SnEventTypeEntity PlainEvent
        {
            get { return GetLookup().Entities.First(entity => entity.IsPlainEvent); }
        }

        public static SnEventTypeEntity SignedUp
        {
            get { return GetLookup().Entities.First(entity => entity.IsSignedUp); }
        }

        public static SnEventTypeEntity UpdatedProfile
        {
            get { return GetLookup().Entities.First(entity => entity.IsUpdatedProfile); }
        }

        public static SnEventTypeEntity UpdatedStatus
        {
            get { return GetLookup().Entities.First(entity => entity.IsUpdatedStatus); }
        }

        public static SnEventTypeEntity BecameFriends
        {
            get { return GetLookup().Entities.First(entity => entity.IsBecameFriends); }
        }

        public static SnEventTypeEntity JoinedGroup
        {
            get { return GetLookup().Entities.First(entity => entity.IsJoinedGroup); }
        }

        public static SnEventTypeEntity CreatedGroup
        {
            get { return GetLookup().Entities.First(entity => entity.IsCreatedGroup); }
        }

        public static SnEventTypeEntity PostedBlogPost
        {
            get { return GetLookup().Entities.First(entity => entity.IsPostedBlogPost); }
        }

        public static SnEventTypeEntity PublishedAlbum
        {
            get { return GetLookup().Entities.First(entity => entity.IsPublishedAlbum); }
        }

        public static SnEventTypeEntity AddedPhotoToAlbum
        {
            get { return GetLookup().Entities.First(entity => entity.IsAddedPhotoToAlbum); }
        }

        public static SnEventTypeEntity UploadedFile
        {
            get { return GetLookup().Entities.First(entity => entity.IsUploadedFile); }
        }

        public static SnEventTypeEntity AddedDiscussionBoard
        {
            get { return GetLookup().Entities.First(entity => entity.IsAddedDiscussionBoard); }
        }

        public static SnEventTypeEntity AddedDiscussionTopic
        {
            get { return GetLookup().Entities.First(entity => entity.IsAddedDiscussionTopic); }
        }

        public static SnEventTypeEntity WallNotePosted
        {
            get { return GetLookup().Entities.First(entity => entity.IsWallNotePost); }
        } 
        #endregion

        #region Methods
        public static MonoSoftware.Web.Workspace.Lookup<SnEventTypeEntity> GetLookup()
        {
            return MonoSoftware.Web.Workspace.Lookup<SnEventTypeEntity>.GetInstance(SnEventTypeFields.Name);
        } 
        #endregion
    }
}
