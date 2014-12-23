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
	/// <summary>Implements the relations factory for the entity: SnDiscussionTopic. </summary>
	public partial class SnDiscussionTopicRelations
	{
		/// <summary>CTor</summary>
		public SnDiscussionTopicRelations()
		{
		}

		/// <summary>Gets all relations of the SnDiscussionTopicEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnDiscussionMessageEntityUsingSnDiscussionTopicId);
			toReturn.Add(this.SnEventEntityUsingSnDiscussionTopicId);
			toReturn.Add(this.SnRelationshipEntityUsingDiscussionTopicId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.AspnetUsersEntityUsingPinnedByUserId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingSnDiscussionBoardId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnDiscussionTopicEntity and SnDiscussionMessageEntity over the 1:n relation they have, using the relation between the fields:
		/// SnDiscussionTopic.Id - SnDiscussionMessage.SnDiscussionTopicId
		/// </summary>
		public virtual IEntityRelation SnDiscussionMessageEntityUsingSnDiscussionTopicId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnDiscussionMessages" , true);
				relation.AddEntityFieldPair(SnDiscussionTopicFields.Id, SnDiscussionMessageFields.SnDiscussionTopicId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionMessageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnDiscussionTopicEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// SnDiscussionTopic.Id - SnEvent.SnDiscussionTopicId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingSnDiscussionTopicId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnEvents" , true);
				relation.AddEntityFieldPair(SnDiscussionTopicFields.Id, SnEventFields.SnDiscussionTopicId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnDiscussionTopicEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// SnDiscussionTopic.Id - SnRelationship.DiscussionTopicId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingDiscussionTopicId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(SnDiscussionTopicFields.Id, SnRelationshipFields.DiscussionTopicId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnDiscussionTopicEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionTopic.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionTopicFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionTopicEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionTopic.PinnedByUserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingPinnedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PinnedByUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionTopicFields.PinnedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionTopicEntity and SnDiscussionBoardEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionTopic.SnDiscussionBoardId - SnDiscussionBoard.Id
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingSnDiscussionBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnDiscussionBoard", false);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnDiscussionTopicFields.SnDiscussionBoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", true);
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
	internal static class StaticSnDiscussionTopicRelations
	{
		internal static readonly IEntityRelation SnDiscussionMessageEntityUsingSnDiscussionTopicIdStatic = new SnDiscussionTopicRelations().SnDiscussionMessageEntityUsingSnDiscussionTopicId;
		internal static readonly IEntityRelation SnEventEntityUsingSnDiscussionTopicIdStatic = new SnDiscussionTopicRelations().SnEventEntityUsingSnDiscussionTopicId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingDiscussionTopicIdStatic = new SnDiscussionTopicRelations().SnRelationshipEntityUsingDiscussionTopicId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnDiscussionTopicRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingPinnedByUserIdStatic = new SnDiscussionTopicRelations().AspnetUsersEntityUsingPinnedByUserId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingSnDiscussionBoardIdStatic = new SnDiscussionTopicRelations().SnDiscussionBoardEntityUsingSnDiscussionBoardId;

		/// <summary>CTor</summary>
		static StaticSnDiscussionTopicRelations()
		{
		}
	}
}
