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
	/// <summary>Implements the relations factory for the entity: SnEvent. </summary>
	public partial class SnEventRelations
	{
		/// <summary>CTor</summary>
		public SnEventRelations()
		{
		}

		/// <summary>Gets all relations of the SnEventEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.AspnetUsersEntityUsingFriendId);
			toReturn.Add(this.BlogPostEntityUsingBlogPostId);
			toReturn.Add(this.OaConsumerEntityUsingOaConsumerId);
			toReturn.Add(this.SnAlbumEntityUsingSnAlbumId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingSnDiscussionBoardId);
			toReturn.Add(this.SnDiscussionTopicEntityUsingSnDiscussionTopicId);
			toReturn.Add(this.SnEventTypeEntityUsingEventTypeId);
			toReturn.Add(this.SnFileEntityUsingSnFileId);
			toReturn.Add(this.SnGroupEntityUsingSnGroupId);
			toReturn.Add(this.SnNoteEntityUsingSnNoteId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnEventFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.FriendId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingFriendId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "FriendAspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnEventFields.FriendId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and BlogPostEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.BlogPostId - BlogPost.Id
		/// </summary>
		public virtual IEntityRelation BlogPostEntityUsingBlogPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BlogPost", false);
				relation.AddEntityFieldPair(BlogPostFields.Id, SnEventFields.BlogPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and OaConsumerEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.OaConsumerId - OaConsumer.Id
		/// </summary>
		public virtual IEntityRelation OaConsumerEntityUsingOaConsumerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "OaConsumer", false);
				relation.AddEntityFieldPair(OaConsumerFields.Id, SnEventFields.OaConsumerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OaConsumerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and SnAlbumEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.SnAlbumId - SnAlbum.Id
		/// </summary>
		public virtual IEntityRelation SnAlbumEntityUsingSnAlbumId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnAlbum", false);
				relation.AddEntityFieldPair(SnAlbumFields.Id, SnEventFields.SnAlbumId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and SnDiscussionBoardEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.SnDiscussionBoardId - SnDiscussionBoard.Id
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingSnDiscussionBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnDiscussionBoard", false);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnEventFields.SnDiscussionBoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and SnDiscussionTopicEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.SnDiscussionTopicId - SnDiscussionTopic.Id
		/// </summary>
		public virtual IEntityRelation SnDiscussionTopicEntityUsingSnDiscussionTopicId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnDiscussionTopic", false);
				relation.AddEntityFieldPair(SnDiscussionTopicFields.Id, SnEventFields.SnDiscussionTopicId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and SnEventTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.EventTypeId - SnEventType.Id
		/// </summary>
		public virtual IEntityRelation SnEventTypeEntityUsingEventTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnEventType", false);
				relation.AddEntityFieldPair(SnEventTypeFields.Id, SnEventFields.EventTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and SnFileEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.SnFileId - SnFile.Id
		/// </summary>
		public virtual IEntityRelation SnFileEntityUsingSnFileId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnFile", false);
				relation.AddEntityFieldPair(SnFileFields.Id, SnEventFields.SnFileId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and SnGroupEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.SnGroupId - SnGroup.Id
		/// </summary>
		public virtual IEntityRelation SnGroupEntityUsingSnGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnGroup", false);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnEventFields.SnGroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnEventEntity and SnNoteEntity over the m:1 relation they have, using the relation between the fields:
		/// SnEvent.SnNoteId - SnNote.Id
		/// </summary>
		public virtual IEntityRelation SnNoteEntityUsingSnNoteId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnNote", false);
				relation.AddEntityFieldPair(SnNoteFields.Id, SnEventFields.SnNoteId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", true);
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
	internal static class StaticSnEventRelations
	{
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnEventRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingFriendIdStatic = new SnEventRelations().AspnetUsersEntityUsingFriendId;
		internal static readonly IEntityRelation BlogPostEntityUsingBlogPostIdStatic = new SnEventRelations().BlogPostEntityUsingBlogPostId;
		internal static readonly IEntityRelation OaConsumerEntityUsingOaConsumerIdStatic = new SnEventRelations().OaConsumerEntityUsingOaConsumerId;
		internal static readonly IEntityRelation SnAlbumEntityUsingSnAlbumIdStatic = new SnEventRelations().SnAlbumEntityUsingSnAlbumId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingSnDiscussionBoardIdStatic = new SnEventRelations().SnDiscussionBoardEntityUsingSnDiscussionBoardId;
		internal static readonly IEntityRelation SnDiscussionTopicEntityUsingSnDiscussionTopicIdStatic = new SnEventRelations().SnDiscussionTopicEntityUsingSnDiscussionTopicId;
		internal static readonly IEntityRelation SnEventTypeEntityUsingEventTypeIdStatic = new SnEventRelations().SnEventTypeEntityUsingEventTypeId;
		internal static readonly IEntityRelation SnFileEntityUsingSnFileIdStatic = new SnEventRelations().SnFileEntityUsingSnFileId;
		internal static readonly IEntityRelation SnGroupEntityUsingSnGroupIdStatic = new SnEventRelations().SnGroupEntityUsingSnGroupId;
		internal static readonly IEntityRelation SnNoteEntityUsingSnNoteIdStatic = new SnEventRelations().SnNoteEntityUsingSnNoteId;

		/// <summary>CTor</summary>
		static StaticSnEventRelations()
		{
		}
	}
}
