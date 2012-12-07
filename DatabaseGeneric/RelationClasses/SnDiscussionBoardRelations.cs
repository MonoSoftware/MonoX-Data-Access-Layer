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
	/// <summary>Implements the relations factory for the entity: SnDiscussionBoard. </summary>
	public partial class SnDiscussionBoardRelations
	{
		/// <summary>CTor</summary>
		public SnDiscussionBoardRelations()
		{
		}

		/// <summary>Gets all relations of the SnDiscussionBoardEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnDiscussionBoardInRoleEntityUsingBoardId);
			toReturn.Add(this.SnDiscussionBoardModeratorEntityUsingSnDiscussionBoardId);
			toReturn.Add(this.SnDiscussionTopicEntityUsingSnDiscussionBoardId);
			toReturn.Add(this.SnEventEntityUsingSnDiscussionBoardId);
			toReturn.Add(this.SnRelationshipEntityUsingDiscussionBoardId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.AspnetUsersEntityUsingPinnedByUserId);
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			toReturn.Add(this.SnGroupEntityUsingSnGroupId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and SnDiscussionBoardInRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// SnDiscussionBoard.Id - SnDiscussionBoardInRole.BoardId
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardInRoleEntityUsingBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnDiscussionBoardInRoles" , true);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnDiscussionBoardInRoleFields.BoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardInRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and SnDiscussionBoardModeratorEntity over the 1:n relation they have, using the relation between the fields:
		/// SnDiscussionBoard.Id - SnDiscussionBoardModerator.SnDiscussionBoardId
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardModeratorEntityUsingSnDiscussionBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnDiscussionBoardModerators" , true);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnDiscussionBoardModeratorFields.SnDiscussionBoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardModeratorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and SnDiscussionTopicEntity over the 1:n relation they have, using the relation between the fields:
		/// SnDiscussionBoard.Id - SnDiscussionTopic.SnDiscussionBoardId
		/// </summary>
		public virtual IEntityRelation SnDiscussionTopicEntityUsingSnDiscussionBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnDiscussionTopics" , true);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnDiscussionTopicFields.SnDiscussionBoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionTopicEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// SnDiscussionBoard.Id - SnEvent.SnDiscussionBoardId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingSnDiscussionBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnEvents" , true);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnEventFields.SnDiscussionBoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// SnDiscussionBoard.Id - SnRelationship.DiscussionBoardId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingDiscussionBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnRelationshipFields.DiscussionBoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionBoard.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplication", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnDiscussionBoardFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionBoard.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionBoardFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionBoard.PinnedByUserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingPinnedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PinnedByUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionBoardFields.PinnedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionBoard.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, SnDiscussionBoardFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardEntity and SnGroupEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionBoard.SnGroupId - SnGroup.Id
		/// </summary>
		public virtual IEntityRelation SnGroupEntityUsingSnGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnGroup", false);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnDiscussionBoardFields.SnGroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", true);
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
	internal static class StaticSnDiscussionBoardRelations
	{
		internal static readonly IEntityRelation SnDiscussionBoardInRoleEntityUsingBoardIdStatic = new SnDiscussionBoardRelations().SnDiscussionBoardInRoleEntityUsingBoardId;
		internal static readonly IEntityRelation SnDiscussionBoardModeratorEntityUsingSnDiscussionBoardIdStatic = new SnDiscussionBoardRelations().SnDiscussionBoardModeratorEntityUsingSnDiscussionBoardId;
		internal static readonly IEntityRelation SnDiscussionTopicEntityUsingSnDiscussionBoardIdStatic = new SnDiscussionBoardRelations().SnDiscussionTopicEntityUsingSnDiscussionBoardId;
		internal static readonly IEntityRelation SnEventEntityUsingSnDiscussionBoardIdStatic = new SnDiscussionBoardRelations().SnEventEntityUsingSnDiscussionBoardId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingDiscussionBoardIdStatic = new SnDiscussionBoardRelations().SnRelationshipEntityUsingDiscussionBoardId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new SnDiscussionBoardRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnDiscussionBoardRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingPinnedByUserIdStatic = new SnDiscussionBoardRelations().AspnetUsersEntityUsingPinnedByUserId;
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new SnDiscussionBoardRelations().LanguageEntityUsingLanguageId;
		internal static readonly IEntityRelation SnGroupEntityUsingSnGroupIdStatic = new SnDiscussionBoardRelations().SnGroupEntityUsingSnGroupId;

		/// <summary>CTor</summary>
		static StaticSnDiscussionBoardRelations()
		{
		}
	}
}
