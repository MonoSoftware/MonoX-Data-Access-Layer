///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using MonoSoftware.MonoX.DAL;
using MonoSoftware.MonoX.DAL.FactoryClasses;
using MonoSoftware.MonoX.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace MonoSoftware.MonoX.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: AspnetUsers. </summary>
	public partial class AspnetUsersRelations
	{
		/// <summary>CTor</summary>
		public AspnetUsersRelations()
		{
		}

		/// <summary>Gets all relations of the AspnetUsersEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetPersonalizationPerUserEntityUsingUserId);
			toReturn.Add(this.AspnetUsersInRolesEntityUsingUserId);
			toReturn.Add(this.BlogEntityUsingUserId);
			toReturn.Add(this.BlogEditorEntityUsingUserId);
			toReturn.Add(this.BlogPostEntityUsingUserId);
			toReturn.Add(this.CalendarEntityUsingOwnerId);
			toReturn.Add(this.CalendarEventEntityUsingAuthorId);
			toReturn.Add(this.CalendarModeratorEntityUsingUserId);
			toReturn.Add(this.DocumentEntityUsingUserId);
			toReturn.Add(this.ListEntityUsingUserId);
			toReturn.Add(this.NewsItemEntityUsingUserId);
			toReturn.Add(this.NewsletterEntityUsingUserId);
			toReturn.Add(this.NewsPublishQueueEntityUsingUserId);
			toReturn.Add(this.OaTokenEntityUsingUserId);
			toReturn.Add(this.PageEntityUsingUserId);
			toReturn.Add(this.PollEntityUsingUserId);
			toReturn.Add(this.PrivacyLevelDefinitionEntityUsingUserId);
			toReturn.Add(this.SnAlbumEntityUsingUserId);
			toReturn.Add(this.SnBlockUserEntityUsingUserId);
			toReturn.Add(this.SnBlockUserEntityUsingBlockedUserId);
			toReturn.Add(this.SnCommentEntityUsingUserId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingUserId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingPinnedByUserId);
			toReturn.Add(this.SnDiscussionBoardModeratorEntityUsingUserId);
			toReturn.Add(this.SnDiscussionMessageEntityUsingAdminAttentionReportedByUserId);
			toReturn.Add(this.SnDiscussionMessageEntityUsingUserId);
			toReturn.Add(this.SnDiscussionMessageEntityUsingDeleteRequestedByUserId);
			toReturn.Add(this.SnDiscussionMessageEntityUsingPinnedByUserId);
			toReturn.Add(this.SnDiscussionTopicEntityUsingUserId);
			toReturn.Add(this.SnDiscussionTopicEntityUsingPinnedByUserId);
			toReturn.Add(this.SnEventEntityUsingUserId);
			toReturn.Add(this.SnEventEntityUsingFriendId);
			toReturn.Add(this.SnFileEntityUsingUserId);
			toReturn.Add(this.SnFriendEntityUsingUserId);
			toReturn.Add(this.SnFriendEntityUsingFriendUserId);
			toReturn.Add(this.SnFriendListEntityUsingUserId);
			toReturn.Add(this.SnFriendListMemberEntityUsingUserId);
			toReturn.Add(this.SnFriendRequestEntityUsingFriendUserId);
			toReturn.Add(this.SnFriendRequestEntityUsingUserId);
			toReturn.Add(this.SnGroupEntityUsingUserId);
			toReturn.Add(this.SnGroupMemberEntityUsingUserId);
			toReturn.Add(this.SnGroupRequestEntityUsingUserId);
			toReturn.Add(this.SnInvitationEntityUsingUserId);
			toReturn.Add(this.SnInvitationEntityUsingBecameUserId);
			toReturn.Add(this.SnMessageEntityUsingUserId);
			toReturn.Add(this.SnMessageRecipientEntityUsingUserId);
			toReturn.Add(this.SnNoteEntityUsingUserId);
			toReturn.Add(this.SnNoteEntityUsingPostToUserId);
			toReturn.Add(this.SnRatingEntityUsingUserId);
			toReturn.Add(this.SnRelationshipEntityUsingUserId);
			toReturn.Add(this.SnSubscriberEntityUsingUserId);
			toReturn.Add(this.UserSocialIdentityEntityUsingUserId);
			toReturn.Add(this.AspnetMembershipEntityUsingUserId);
			toReturn.Add(this.AspnetProfileEntityUsingUserId);
			toReturn.Add(this.UserAvatarEntityUsingId);
			toReturn.Add(this.UserProfileEntityUsingId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and AspnetPersonalizationPerUserEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - AspnetPersonalizationPerUser.UserId
		/// </summary>
		public virtual IEntityRelation AspnetPersonalizationPerUserEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AspnetPersonalizationPerUser" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, AspnetPersonalizationPerUserFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPersonalizationPerUserEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and AspnetUsersInRolesEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - AspnetUsersInRoles.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersInRolesEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AspnetUsersInRoles" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, AspnetUsersInRolesFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersInRolesEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and BlogEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - Blog.UserId
		/// </summary>
		public virtual IEntityRelation BlogEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Blogs" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, BlogFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and BlogEditorEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - BlogEditor.UserId
		/// </summary>
		public virtual IEntityRelation BlogEditorEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BlogEditors" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, BlogEditorFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEditorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and BlogPostEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - BlogPost.UserId
		/// </summary>
		public virtual IEntityRelation BlogPostEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BlogPosts" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, BlogPostFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and CalendarEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - Calendar.OwnerId
		/// </summary>
		public virtual IEntityRelation CalendarEntityUsingOwnerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Calendars" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, CalendarFields.OwnerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and CalendarEventEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - CalendarEvent.AuthorId
		/// </summary>
		public virtual IEntityRelation CalendarEventEntityUsingAuthorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarEvents" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, CalendarEventFields.AuthorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and CalendarModeratorEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - CalendarModerator.UserId
		/// </summary>
		public virtual IEntityRelation CalendarModeratorEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarModerators" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, CalendarModeratorFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarModeratorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and DocumentEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - Document.UserId
		/// </summary>
		public virtual IEntityRelation DocumentEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Documents" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, DocumentFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and ListEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - List.UserId
		/// </summary>
		public virtual IEntityRelation ListEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Lists" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, ListFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and NewsItemEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - NewsItem.UserId
		/// </summary>
		public virtual IEntityRelation NewsItemEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsItems" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, NewsItemFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and NewsletterEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - Newsletter.UserId
		/// </summary>
		public virtual IEntityRelation NewsletterEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Newsletters" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, NewsletterFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and NewsPublishQueueEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - NewsPublishQueue.UserId
		/// </summary>
		public virtual IEntityRelation NewsPublishQueueEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsPublishQueue" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, NewsPublishQueueFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsPublishQueueEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and OaTokenEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - OaToken.UserId
		/// </summary>
		public virtual IEntityRelation OaTokenEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "OaTokens" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, OaTokenFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OaTokenEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and PageEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - Page.UserId
		/// </summary>
		public virtual IEntityRelation PageEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Page" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, PageFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and PollEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - Poll.UserId
		/// </summary>
		public virtual IEntityRelation PollEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Polls" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, PollFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and PrivacyLevelDefinitionEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - PrivacyLevelDefinition.UserId
		/// </summary>
		public virtual IEntityRelation PrivacyLevelDefinitionEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PrivacyLevelDefinition" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, PrivacyLevelDefinitionFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelDefinitionEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnAlbumEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnAlbum.UserId
		/// </summary>
		public virtual IEntityRelation SnAlbumEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnAlbums" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnAlbumFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnBlockUserEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnBlockUser.UserId
		/// </summary>
		public virtual IEntityRelation SnBlockUserEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnBlockUsers" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnBlockUserFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnBlockUserEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnBlockUserEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnBlockUser.BlockedUserId
		/// </summary>
		public virtual IEntityRelation SnBlockUserEntityUsingBlockedUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnBlockUsers_" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnBlockUserFields.BlockedUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnBlockUserEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnCommentEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnComment.UserId
		/// </summary>
		public virtual IEntityRelation SnCommentEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnComments" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnCommentFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnCommentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnDiscussionBoardEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnDiscussionBoard.UserId
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionBoardFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnDiscussionBoardEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnDiscussionBoard.PinnedByUserId
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingPinnedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionBoardFields.PinnedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnDiscussionBoardModeratorEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnDiscussionBoardModerator.UserId
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardModeratorEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionBoardModeratorFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardModeratorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnDiscussionMessageEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnDiscussionMessage.AdminAttentionReportedByUserId
		/// </summary>
		public virtual IEntityRelation SnDiscussionMessageEntityUsingAdminAttentionReportedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionMessageFields.AdminAttentionReportedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnDiscussionMessageEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnDiscussionMessage.UserId
		/// </summary>
		public virtual IEntityRelation SnDiscussionMessageEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionMessageFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnDiscussionMessageEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnDiscussionMessage.DeleteRequestedByUserId
		/// </summary>
		public virtual IEntityRelation SnDiscussionMessageEntityUsingDeleteRequestedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionMessageFields.DeleteRequestedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnDiscussionMessageEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnDiscussionMessage.PinnedByUserId
		/// </summary>
		public virtual IEntityRelation SnDiscussionMessageEntityUsingPinnedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnDiscussionMessage" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionMessageFields.PinnedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnDiscussionTopicEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnDiscussionTopic.UserId
		/// </summary>
		public virtual IEntityRelation SnDiscussionTopicEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionTopicFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnDiscussionTopicEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnDiscussionTopic.PinnedByUserId
		/// </summary>
		public virtual IEntityRelation SnDiscussionTopicEntityUsingPinnedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionTopicFields.PinnedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnEvent.UserId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnEvents" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnEventFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnEvent.FriendId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingFriendId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFriendEvents" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnEventFields.FriendId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnFileEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnFile.UserId
		/// </summary>
		public virtual IEntityRelation SnFileEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFiles" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnFileFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnFriendEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnFriend.UserId
		/// </summary>
		public virtual IEntityRelation SnFriendEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFriendsUsers" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnFriendFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFriendEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnFriendEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnFriend.FriendUserId
		/// </summary>
		public virtual IEntityRelation SnFriendEntityUsingFriendUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFriendsFriends" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnFriendFields.FriendUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFriendEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnFriendListEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnFriendList.UserId
		/// </summary>
		public virtual IEntityRelation SnFriendListEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFriendLists" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnFriendListFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFriendListEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnFriendListMemberEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnFriendListMember.UserId
		/// </summary>
		public virtual IEntityRelation SnFriendListMemberEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFriendListMembers" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnFriendListMemberFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFriendListMemberEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnFriendRequestEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnFriendRequest.FriendUserId
		/// </summary>
		public virtual IEntityRelation SnFriendRequestEntityUsingFriendUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFriendRequestsFriends" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnFriendRequestFields.FriendUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFriendRequestEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnFriendRequestEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnFriendRequest.UserId
		/// </summary>
		public virtual IEntityRelation SnFriendRequestEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFriendRequestsUsers" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnFriendRequestFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFriendRequestEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnGroupEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnGroup.UserId
		/// </summary>
		public virtual IEntityRelation SnGroupEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnGroups" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnGroupFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnGroupMemberEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnGroupMember.UserId
		/// </summary>
		public virtual IEntityRelation SnGroupMemberEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnGroupMembers" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnGroupMemberFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupMemberEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnGroupRequestEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnGroupRequest.UserId
		/// </summary>
		public virtual IEntityRelation SnGroupRequestEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnGroupRequests" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnGroupRequestFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupRequestEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnInvitationEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnInvitation.UserId
		/// </summary>
		public virtual IEntityRelation SnInvitationEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnInvitations" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnInvitationFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnInvitationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnInvitationEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnInvitation.BecameUserId
		/// </summary>
		public virtual IEntityRelation SnInvitationEntityUsingBecameUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnInvitationsBecameUsers" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnInvitationFields.BecameUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnInvitationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnMessageEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnMessage.UserId
		/// </summary>
		public virtual IEntityRelation SnMessageEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnMessages" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnMessageFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnMessageRecipientEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnMessageRecipient.UserId
		/// </summary>
		public virtual IEntityRelation SnMessageRecipientEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnMessageRecipients" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnMessageRecipientFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageRecipientEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnNoteEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnNote.UserId
		/// </summary>
		public virtual IEntityRelation SnNoteEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnNotesPostedTo" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnNoteFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnNoteEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnNote.PostToUserId
		/// </summary>
		public virtual IEntityRelation SnNoteEntityUsingPostToUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnNotesAuthoredBy" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnNoteFields.PostToUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnRatingEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnRating.UserId
		/// </summary>
		public virtual IEntityRelation SnRatingEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRating" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnRatingFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRatingEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnRelationship.UserId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationshipss" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnRelationshipFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and SnSubscriberEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - SnSubscriber.UserId
		/// </summary>
		public virtual IEntityRelation SnSubscriberEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnSubscribers" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnSubscriberFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnSubscriberEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and UserSocialIdentityEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - UserSocialIdentity.UserId
		/// </summary>
		public virtual IEntityRelation UserSocialIdentityEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "UserSocialIdentities" , true);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, UserSocialIdentityFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserSocialIdentityEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and AspnetMembershipEntity over the 1:1 relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - AspnetMembership.UserId
		/// </summary>
		public virtual IEntityRelation AspnetMembershipEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "AspnetMembership", true);

				relation.AddEntityFieldPair(AspnetUsersFields.UserId, AspnetMembershipFields.UserId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetMembershipEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and AspnetProfileEntity over the 1:1 relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - AspnetProfile.UserId
		/// </summary>
		public virtual IEntityRelation AspnetProfileEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "AspnetProfile", true);

				relation.AddEntityFieldPair(AspnetUsersFields.UserId, AspnetProfileFields.UserId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetProfileEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and UserAvatarEntity over the 1:1 relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - UserAvatar.Id
		/// </summary>
		public virtual IEntityRelation UserAvatarEntityUsingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "UserAvatar", true);

				relation.AddEntityFieldPair(AspnetUsersFields.UserId, UserAvatarFields.Id);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserAvatarEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and UserProfileEntity over the 1:1 relation they have, using the relation between the fields:
		/// AspnetUsers.UserId - UserProfile.Id
		/// </summary>
		public virtual IEntityRelation UserProfileEntityUsingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "UserProfile", true);

				relation.AddEntityFieldPair(AspnetUsersFields.UserId, UserProfileFields.Id);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserProfileEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetUsersEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// AspnetUsers.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplications", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, AspnetUsersFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticAspnetUsersRelations
	{
		internal static readonly IEntityRelation AspnetPersonalizationPerUserEntityUsingUserIdStatic = new AspnetUsersRelations().AspnetPersonalizationPerUserEntityUsingUserId;
		internal static readonly IEntityRelation AspnetUsersInRolesEntityUsingUserIdStatic = new AspnetUsersRelations().AspnetUsersInRolesEntityUsingUserId;
		internal static readonly IEntityRelation BlogEntityUsingUserIdStatic = new AspnetUsersRelations().BlogEntityUsingUserId;
		internal static readonly IEntityRelation BlogEditorEntityUsingUserIdStatic = new AspnetUsersRelations().BlogEditorEntityUsingUserId;
		internal static readonly IEntityRelation BlogPostEntityUsingUserIdStatic = new AspnetUsersRelations().BlogPostEntityUsingUserId;
		internal static readonly IEntityRelation CalendarEntityUsingOwnerIdStatic = new AspnetUsersRelations().CalendarEntityUsingOwnerId;
		internal static readonly IEntityRelation CalendarEventEntityUsingAuthorIdStatic = new AspnetUsersRelations().CalendarEventEntityUsingAuthorId;
		internal static readonly IEntityRelation CalendarModeratorEntityUsingUserIdStatic = new AspnetUsersRelations().CalendarModeratorEntityUsingUserId;
		internal static readonly IEntityRelation DocumentEntityUsingUserIdStatic = new AspnetUsersRelations().DocumentEntityUsingUserId;
		internal static readonly IEntityRelation ListEntityUsingUserIdStatic = new AspnetUsersRelations().ListEntityUsingUserId;
		internal static readonly IEntityRelation NewsItemEntityUsingUserIdStatic = new AspnetUsersRelations().NewsItemEntityUsingUserId;
		internal static readonly IEntityRelation NewsletterEntityUsingUserIdStatic = new AspnetUsersRelations().NewsletterEntityUsingUserId;
		internal static readonly IEntityRelation NewsPublishQueueEntityUsingUserIdStatic = new AspnetUsersRelations().NewsPublishQueueEntityUsingUserId;
		internal static readonly IEntityRelation OaTokenEntityUsingUserIdStatic = new AspnetUsersRelations().OaTokenEntityUsingUserId;
		internal static readonly IEntityRelation PageEntityUsingUserIdStatic = new AspnetUsersRelations().PageEntityUsingUserId;
		internal static readonly IEntityRelation PollEntityUsingUserIdStatic = new AspnetUsersRelations().PollEntityUsingUserId;
		internal static readonly IEntityRelation PrivacyLevelDefinitionEntityUsingUserIdStatic = new AspnetUsersRelations().PrivacyLevelDefinitionEntityUsingUserId;
		internal static readonly IEntityRelation SnAlbumEntityUsingUserIdStatic = new AspnetUsersRelations().SnAlbumEntityUsingUserId;
		internal static readonly IEntityRelation SnBlockUserEntityUsingUserIdStatic = new AspnetUsersRelations().SnBlockUserEntityUsingUserId;
		internal static readonly IEntityRelation SnBlockUserEntityUsingBlockedUserIdStatic = new AspnetUsersRelations().SnBlockUserEntityUsingBlockedUserId;
		internal static readonly IEntityRelation SnCommentEntityUsingUserIdStatic = new AspnetUsersRelations().SnCommentEntityUsingUserId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingUserIdStatic = new AspnetUsersRelations().SnDiscussionBoardEntityUsingUserId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingPinnedByUserIdStatic = new AspnetUsersRelations().SnDiscussionBoardEntityUsingPinnedByUserId;
		internal static readonly IEntityRelation SnDiscussionBoardModeratorEntityUsingUserIdStatic = new AspnetUsersRelations().SnDiscussionBoardModeratorEntityUsingUserId;
		internal static readonly IEntityRelation SnDiscussionMessageEntityUsingAdminAttentionReportedByUserIdStatic = new AspnetUsersRelations().SnDiscussionMessageEntityUsingAdminAttentionReportedByUserId;
		internal static readonly IEntityRelation SnDiscussionMessageEntityUsingUserIdStatic = new AspnetUsersRelations().SnDiscussionMessageEntityUsingUserId;
		internal static readonly IEntityRelation SnDiscussionMessageEntityUsingDeleteRequestedByUserIdStatic = new AspnetUsersRelations().SnDiscussionMessageEntityUsingDeleteRequestedByUserId;
		internal static readonly IEntityRelation SnDiscussionMessageEntityUsingPinnedByUserIdStatic = new AspnetUsersRelations().SnDiscussionMessageEntityUsingPinnedByUserId;
		internal static readonly IEntityRelation SnDiscussionTopicEntityUsingUserIdStatic = new AspnetUsersRelations().SnDiscussionTopicEntityUsingUserId;
		internal static readonly IEntityRelation SnDiscussionTopicEntityUsingPinnedByUserIdStatic = new AspnetUsersRelations().SnDiscussionTopicEntityUsingPinnedByUserId;
		internal static readonly IEntityRelation SnEventEntityUsingUserIdStatic = new AspnetUsersRelations().SnEventEntityUsingUserId;
		internal static readonly IEntityRelation SnEventEntityUsingFriendIdStatic = new AspnetUsersRelations().SnEventEntityUsingFriendId;
		internal static readonly IEntityRelation SnFileEntityUsingUserIdStatic = new AspnetUsersRelations().SnFileEntityUsingUserId;
		internal static readonly IEntityRelation SnFriendEntityUsingUserIdStatic = new AspnetUsersRelations().SnFriendEntityUsingUserId;
		internal static readonly IEntityRelation SnFriendEntityUsingFriendUserIdStatic = new AspnetUsersRelations().SnFriendEntityUsingFriendUserId;
		internal static readonly IEntityRelation SnFriendListEntityUsingUserIdStatic = new AspnetUsersRelations().SnFriendListEntityUsingUserId;
		internal static readonly IEntityRelation SnFriendListMemberEntityUsingUserIdStatic = new AspnetUsersRelations().SnFriendListMemberEntityUsingUserId;
		internal static readonly IEntityRelation SnFriendRequestEntityUsingFriendUserIdStatic = new AspnetUsersRelations().SnFriendRequestEntityUsingFriendUserId;
		internal static readonly IEntityRelation SnFriendRequestEntityUsingUserIdStatic = new AspnetUsersRelations().SnFriendRequestEntityUsingUserId;
		internal static readonly IEntityRelation SnGroupEntityUsingUserIdStatic = new AspnetUsersRelations().SnGroupEntityUsingUserId;
		internal static readonly IEntityRelation SnGroupMemberEntityUsingUserIdStatic = new AspnetUsersRelations().SnGroupMemberEntityUsingUserId;
		internal static readonly IEntityRelation SnGroupRequestEntityUsingUserIdStatic = new AspnetUsersRelations().SnGroupRequestEntityUsingUserId;
		internal static readonly IEntityRelation SnInvitationEntityUsingUserIdStatic = new AspnetUsersRelations().SnInvitationEntityUsingUserId;
		internal static readonly IEntityRelation SnInvitationEntityUsingBecameUserIdStatic = new AspnetUsersRelations().SnInvitationEntityUsingBecameUserId;
		internal static readonly IEntityRelation SnMessageEntityUsingUserIdStatic = new AspnetUsersRelations().SnMessageEntityUsingUserId;
		internal static readonly IEntityRelation SnMessageRecipientEntityUsingUserIdStatic = new AspnetUsersRelations().SnMessageRecipientEntityUsingUserId;
		internal static readonly IEntityRelation SnNoteEntityUsingUserIdStatic = new AspnetUsersRelations().SnNoteEntityUsingUserId;
		internal static readonly IEntityRelation SnNoteEntityUsingPostToUserIdStatic = new AspnetUsersRelations().SnNoteEntityUsingPostToUserId;
		internal static readonly IEntityRelation SnRatingEntityUsingUserIdStatic = new AspnetUsersRelations().SnRatingEntityUsingUserId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingUserIdStatic = new AspnetUsersRelations().SnRelationshipEntityUsingUserId;
		internal static readonly IEntityRelation SnSubscriberEntityUsingUserIdStatic = new AspnetUsersRelations().SnSubscriberEntityUsingUserId;
		internal static readonly IEntityRelation UserSocialIdentityEntityUsingUserIdStatic = new AspnetUsersRelations().UserSocialIdentityEntityUsingUserId;
		internal static readonly IEntityRelation AspnetMembershipEntityUsingUserIdStatic = new AspnetUsersRelations().AspnetMembershipEntityUsingUserId;
		internal static readonly IEntityRelation AspnetProfileEntityUsingUserIdStatic = new AspnetUsersRelations().AspnetProfileEntityUsingUserId;
		internal static readonly IEntityRelation UserAvatarEntityUsingIdStatic = new AspnetUsersRelations().UserAvatarEntityUsingId;
		internal static readonly IEntityRelation UserProfileEntityUsingIdStatic = new AspnetUsersRelations().UserProfileEntityUsingId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new AspnetUsersRelations().AspnetApplicationsEntityUsingApplicationId;

		/// <summary>CTor</summary>
		static StaticAspnetUsersRelations()
		{
		}
	}
}
