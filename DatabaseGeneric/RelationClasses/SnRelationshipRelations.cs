///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
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
	/// <summary>Implements the relations factory for the entity: SnRelationship. </summary>
	public partial class SnRelationshipRelations
	{
		/// <summary>CTor</summary>
		public SnRelationshipRelations()
		{
		}

		/// <summary>Gets all relations of the SnRelationshipEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnCommentEntityUsingRelationshipId);
			toReturn.Add(this.SnFileEntityUsingRelationshipId);
			toReturn.Add(this.SnRatingEntityUsingRelationshipId);
			toReturn.Add(this.SnSubscriberEntityUsingRelationshipId);
			toReturn.Add(this.SnTagEntityUsingRelationshipId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.BlogEntityUsingBlogId);
			toReturn.Add(this.BlogPostEntityUsingBlogPostId);
			toReturn.Add(this.CalendarEventEntityUsingCalendarEventId);
			toReturn.Add(this.CampaignEntityUsingCampaignId);
			toReturn.Add(this.DocumentEntityUsingDocumentId);
			toReturn.Add(this.ListItemEntityUsingListItemId);
			toReturn.Add(this.NewsCategoryEntityUsingNewsCategoryId);
			toReturn.Add(this.NewsItemEntityUsingNewsItemId);
			toReturn.Add(this.NewsletterEntityUsingNewsletterId);
			toReturn.Add(this.PageEntityUsingPageId);
			toReturn.Add(this.PollEntityUsingPollId);
			toReturn.Add(this.SnAlbumEntityUsingAlbumId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingDiscussionBoardId);
			toReturn.Add(this.SnDiscussionMessageEntityUsingDiscussionMessageId);
			toReturn.Add(this.SnDiscussionTopicEntityUsingDiscussionTopicId);
			toReturn.Add(this.SnFileEntityUsingFileId);
			toReturn.Add(this.SnGroupEntityUsingGroupId);
			toReturn.Add(this.SnMessageEntityUsingMessageId);
			toReturn.Add(this.SnNoteEntityUsingNoteId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnCommentEntity over the 1:n relation they have, using the relation between the fields:
		/// SnRelationship.Id - SnComment.RelationshipId
		/// </summary>
		public virtual IEntityRelation SnCommentEntityUsingRelationshipId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnComments" , true);
				relation.AddEntityFieldPair(SnRelationshipFields.Id, SnCommentFields.RelationshipId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnCommentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnFileEntity over the 1:n relation they have, using the relation between the fields:
		/// SnRelationship.Id - SnFile.RelationshipId
		/// </summary>
		public virtual IEntityRelation SnFileEntityUsingRelationshipId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFiles" , true);
				relation.AddEntityFieldPair(SnRelationshipFields.Id, SnFileFields.RelationshipId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnRatingEntity over the 1:n relation they have, using the relation between the fields:
		/// SnRelationship.Id - SnRating.RelationshipId
		/// </summary>
		public virtual IEntityRelation SnRatingEntityUsingRelationshipId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRatings" , true);
				relation.AddEntityFieldPair(SnRelationshipFields.Id, SnRatingFields.RelationshipId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRatingEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnSubscriberEntity over the 1:n relation they have, using the relation between the fields:
		/// SnRelationship.Id - SnSubscriber.RelationshipId
		/// </summary>
		public virtual IEntityRelation SnSubscriberEntityUsingRelationshipId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnSubscribers" , true);
				relation.AddEntityFieldPair(SnRelationshipFields.Id, SnSubscriberFields.RelationshipId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnSubscriberEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnTagEntity over the 1:n relation they have, using the relation between the fields:
		/// SnRelationship.Id - SnTag.RelationshipId
		/// </summary>
		public virtual IEntityRelation SnTagEntityUsingRelationshipId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnTags" , true);
				relation.AddEntityFieldPair(SnRelationshipFields.Id, SnTagFields.RelationshipId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnTagEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplication", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnRelationshipFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnRelationshipFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and BlogEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.BlogId - Blog.Id
		/// </summary>
		public virtual IEntityRelation BlogEntityUsingBlogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Blog", false);
				relation.AddEntityFieldPair(BlogFields.Id, SnRelationshipFields.BlogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and BlogPostEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.BlogPostId - BlogPost.Id
		/// </summary>
		public virtual IEntityRelation BlogPostEntityUsingBlogPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BlogPost", false);
				relation.AddEntityFieldPair(BlogPostFields.Id, SnRelationshipFields.BlogPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and CalendarEventEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.CalendarEventId - CalendarEvent.Id
		/// </summary>
		public virtual IEntityRelation CalendarEventEntityUsingCalendarEventId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CalendarEvent", false);
				relation.AddEntityFieldPair(CalendarEventFields.Id, SnRelationshipFields.CalendarEventId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and CampaignEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.CampaignId - Campaign.Id
		/// </summary>
		public virtual IEntityRelation CampaignEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Campaign", false);
				relation.AddEntityFieldPair(CampaignFields.Id, SnRelationshipFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and DocumentEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.DocumentId - Document.Id
		/// </summary>
		public virtual IEntityRelation DocumentEntityUsingDocumentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Document", false);
				relation.AddEntityFieldPair(DocumentFields.Id, SnRelationshipFields.DocumentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and ListItemEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.ListItemId - ListItem.Id
		/// </summary>
		public virtual IEntityRelation ListItemEntityUsingListItemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ListItem", false);
				relation.AddEntityFieldPair(ListItemFields.Id, SnRelationshipFields.ListItemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and NewsCategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.NewsCategoryId - NewsCategory.Id
		/// </summary>
		public virtual IEntityRelation NewsCategoryEntityUsingNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "NewsCategory", false);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, SnRelationshipFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and NewsItemEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.NewsItemId - NewsItem.Id
		/// </summary>
		public virtual IEntityRelation NewsItemEntityUsingNewsItemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "NewsItem", false);
				relation.AddEntityFieldPair(NewsItemFields.Id, SnRelationshipFields.NewsItemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and NewsletterEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.NewsletterId - Newsletter.Id
		/// </summary>
		public virtual IEntityRelation NewsletterEntityUsingNewsletterId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Newsletter", false);
				relation.AddEntityFieldPair(NewsletterFields.Id, SnRelationshipFields.NewsletterId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and PageEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.PageId - Page.Id
		/// </summary>
		public virtual IEntityRelation PageEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Page", false);
				relation.AddEntityFieldPair(PageFields.Id, SnRelationshipFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and PollEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.PollId - Poll.Id
		/// </summary>
		public virtual IEntityRelation PollEntityUsingPollId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Poll", false);
				relation.AddEntityFieldPair(PollFields.Id, SnRelationshipFields.PollId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnAlbumEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.AlbumId - SnAlbum.Id
		/// </summary>
		public virtual IEntityRelation SnAlbumEntityUsingAlbumId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnAlbum", false);
				relation.AddEntityFieldPair(SnAlbumFields.Id, SnRelationshipFields.AlbumId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnDiscussionBoardEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.DiscussionBoardId - SnDiscussionBoard.Id
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingDiscussionBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnDiscussionBoard", false);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnRelationshipFields.DiscussionBoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnDiscussionMessageEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.DiscussionMessageId - SnDiscussionMessage.Id
		/// </summary>
		public virtual IEntityRelation SnDiscussionMessageEntityUsingDiscussionMessageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnDiscussionMessage", false);
				relation.AddEntityFieldPair(SnDiscussionMessageFields.Id, SnRelationshipFields.DiscussionMessageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnDiscussionTopicEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.DiscussionTopicId - SnDiscussionTopic.Id
		/// </summary>
		public virtual IEntityRelation SnDiscussionTopicEntityUsingDiscussionTopicId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnDiscussionTopic", false);
				relation.AddEntityFieldPair(SnDiscussionTopicFields.Id, SnRelationshipFields.DiscussionTopicId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnFileEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.FileId - SnFile.Id
		/// </summary>
		public virtual IEntityRelation SnFileEntityUsingFileId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnFile", false);
				relation.AddEntityFieldPair(SnFileFields.Id, SnRelationshipFields.FileId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnGroupEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.GroupId - SnGroup.Id
		/// </summary>
		public virtual IEntityRelation SnGroupEntityUsingGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnGroup", false);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnRelationshipFields.GroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnMessageEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.MessageId - SnMessage.Id
		/// </summary>
		public virtual IEntityRelation SnMessageEntityUsingMessageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnMessage", false);
				relation.AddEntityFieldPair(SnMessageFields.Id, SnRelationshipFields.MessageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnRelationshipEntity and SnNoteEntity over the m:1 relation they have, using the relation between the fields:
		/// SnRelationship.NoteId - SnNote.Id
		/// </summary>
		public virtual IEntityRelation SnNoteEntityUsingNoteId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnNote", false);
				relation.AddEntityFieldPair(SnNoteFields.Id, SnRelationshipFields.NoteId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", true);
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
	internal static class StaticSnRelationshipRelations
	{
		internal static readonly IEntityRelation SnCommentEntityUsingRelationshipIdStatic = new SnRelationshipRelations().SnCommentEntityUsingRelationshipId;
		internal static readonly IEntityRelation SnFileEntityUsingRelationshipIdStatic = new SnRelationshipRelations().SnFileEntityUsingRelationshipId;
		internal static readonly IEntityRelation SnRatingEntityUsingRelationshipIdStatic = new SnRelationshipRelations().SnRatingEntityUsingRelationshipId;
		internal static readonly IEntityRelation SnSubscriberEntityUsingRelationshipIdStatic = new SnRelationshipRelations().SnSubscriberEntityUsingRelationshipId;
		internal static readonly IEntityRelation SnTagEntityUsingRelationshipIdStatic = new SnRelationshipRelations().SnTagEntityUsingRelationshipId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new SnRelationshipRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnRelationshipRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation BlogEntityUsingBlogIdStatic = new SnRelationshipRelations().BlogEntityUsingBlogId;
		internal static readonly IEntityRelation BlogPostEntityUsingBlogPostIdStatic = new SnRelationshipRelations().BlogPostEntityUsingBlogPostId;
		internal static readonly IEntityRelation CalendarEventEntityUsingCalendarEventIdStatic = new SnRelationshipRelations().CalendarEventEntityUsingCalendarEventId;
		internal static readonly IEntityRelation CampaignEntityUsingCampaignIdStatic = new SnRelationshipRelations().CampaignEntityUsingCampaignId;
		internal static readonly IEntityRelation DocumentEntityUsingDocumentIdStatic = new SnRelationshipRelations().DocumentEntityUsingDocumentId;
		internal static readonly IEntityRelation ListItemEntityUsingListItemIdStatic = new SnRelationshipRelations().ListItemEntityUsingListItemId;
		internal static readonly IEntityRelation NewsCategoryEntityUsingNewsCategoryIdStatic = new SnRelationshipRelations().NewsCategoryEntityUsingNewsCategoryId;
		internal static readonly IEntityRelation NewsItemEntityUsingNewsItemIdStatic = new SnRelationshipRelations().NewsItemEntityUsingNewsItemId;
		internal static readonly IEntityRelation NewsletterEntityUsingNewsletterIdStatic = new SnRelationshipRelations().NewsletterEntityUsingNewsletterId;
		internal static readonly IEntityRelation PageEntityUsingPageIdStatic = new SnRelationshipRelations().PageEntityUsingPageId;
		internal static readonly IEntityRelation PollEntityUsingPollIdStatic = new SnRelationshipRelations().PollEntityUsingPollId;
		internal static readonly IEntityRelation SnAlbumEntityUsingAlbumIdStatic = new SnRelationshipRelations().SnAlbumEntityUsingAlbumId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingDiscussionBoardIdStatic = new SnRelationshipRelations().SnDiscussionBoardEntityUsingDiscussionBoardId;
		internal static readonly IEntityRelation SnDiscussionMessageEntityUsingDiscussionMessageIdStatic = new SnRelationshipRelations().SnDiscussionMessageEntityUsingDiscussionMessageId;
		internal static readonly IEntityRelation SnDiscussionTopicEntityUsingDiscussionTopicIdStatic = new SnRelationshipRelations().SnDiscussionTopicEntityUsingDiscussionTopicId;
		internal static readonly IEntityRelation SnFileEntityUsingFileIdStatic = new SnRelationshipRelations().SnFileEntityUsingFileId;
		internal static readonly IEntityRelation SnGroupEntityUsingGroupIdStatic = new SnRelationshipRelations().SnGroupEntityUsingGroupId;
		internal static readonly IEntityRelation SnMessageEntityUsingMessageIdStatic = new SnRelationshipRelations().SnMessageEntityUsingMessageId;
		internal static readonly IEntityRelation SnNoteEntityUsingNoteIdStatic = new SnRelationshipRelations().SnNoteEntityUsingNoteId;

		/// <summary>CTor</summary>
		static StaticSnRelationshipRelations()
		{
		}
	}
}
