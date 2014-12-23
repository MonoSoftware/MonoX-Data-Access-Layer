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
	/// <summary>Implements the relations factory for the entity: SnDiscussionMessage. </summary>
	public partial class SnDiscussionMessageRelations
	{
		/// <summary>CTor</summary>
		public SnDiscussionMessageRelations()
		{
		}

		/// <summary>Gets all relations of the SnDiscussionMessageEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnRelationshipEntityUsingDiscussionMessageId);
			toReturn.Add(this.AspnetUsersEntityUsingAdminAttentionReportedByUserId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.AspnetUsersEntityUsingDeleteRequestedByUserId);
			toReturn.Add(this.AspnetUsersEntityUsingPinnedByUserId);
			toReturn.Add(this.SnDiscussionTopicEntityUsingSnDiscussionTopicId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnDiscussionMessageEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// SnDiscussionMessage.Id - SnRelationship.DiscussionMessageId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingDiscussionMessageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(SnDiscussionMessageFields.Id, SnRelationshipFields.DiscussionMessageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnDiscussionMessageEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionMessage.AdminAttentionReportedByUserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingAdminAttentionReportedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AdminAttentionReportedByUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionMessageFields.AdminAttentionReportedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionMessageEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionMessage.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionMessageFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionMessageEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionMessage.DeleteRequestedByUserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingDeleteRequestedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "DeleteRequestedByUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionMessageFields.DeleteRequestedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionMessageEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionMessage.PinnedByUserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingPinnedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PinnedByUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionMessageFields.PinnedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionMessageEntity and SnDiscussionTopicEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionMessage.SnDiscussionTopicId - SnDiscussionTopic.Id
		/// </summary>
		public virtual IEntityRelation SnDiscussionTopicEntityUsingSnDiscussionTopicId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnDiscussionTopic", false);
				relation.AddEntityFieldPair(SnDiscussionTopicFields.Id, SnDiscussionMessageFields.SnDiscussionTopicId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", true);
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
	internal static class StaticSnDiscussionMessageRelations
	{
		internal static readonly IEntityRelation SnRelationshipEntityUsingDiscussionMessageIdStatic = new SnDiscussionMessageRelations().SnRelationshipEntityUsingDiscussionMessageId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingAdminAttentionReportedByUserIdStatic = new SnDiscussionMessageRelations().AspnetUsersEntityUsingAdminAttentionReportedByUserId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnDiscussionMessageRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingDeleteRequestedByUserIdStatic = new SnDiscussionMessageRelations().AspnetUsersEntityUsingDeleteRequestedByUserId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingPinnedByUserIdStatic = new SnDiscussionMessageRelations().AspnetUsersEntityUsingPinnedByUserId;
		internal static readonly IEntityRelation SnDiscussionTopicEntityUsingSnDiscussionTopicIdStatic = new SnDiscussionMessageRelations().SnDiscussionTopicEntityUsingSnDiscussionTopicId;

		/// <summary>CTor</summary>
		static StaticSnDiscussionMessageRelations()
		{
		}
	}
}
