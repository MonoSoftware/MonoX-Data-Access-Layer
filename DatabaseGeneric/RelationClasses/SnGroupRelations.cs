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
	/// <summary>Implements the relations factory for the entity: SnGroup. </summary>
	public partial class SnGroupRelations
	{
		/// <summary>CTor</summary>
		public SnGroupRelations()
		{
		}

		/// <summary>Gets all relations of the SnGroupEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnAlbumEntityUsingSnGroupId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingSnGroupId);
			toReturn.Add(this.SnEventEntityUsingSnGroupId);
			toReturn.Add(this.SnGroupMemberEntityUsingGroupId);
			toReturn.Add(this.SnGroupRequestEntityUsingGroupId);
			toReturn.Add(this.SnNoteEntityUsingGroupId);
			toReturn.Add(this.SnRelationshipEntityUsingGroupId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.SnGroupCategoryEntityUsingGroupCategoryId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnGroupEntity and SnAlbumEntity over the 1:n relation they have, using the relation between the fields:
		/// SnGroup.Id - SnAlbum.SnGroupId
		/// </summary>
		public virtual IEntityRelation SnAlbumEntityUsingSnGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnAlbum" , true);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnAlbumFields.SnGroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnGroupEntity and SnDiscussionBoardEntity over the 1:n relation they have, using the relation between the fields:
		/// SnGroup.Id - SnDiscussionBoard.SnGroupId
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingSnGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnDiscussionBoard" , true);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnDiscussionBoardFields.SnGroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnGroupEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// SnGroup.Id - SnEvent.SnGroupId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingSnGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnEvents" , true);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnEventFields.SnGroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnGroupEntity and SnGroupMemberEntity over the 1:n relation they have, using the relation between the fields:
		/// SnGroup.Id - SnGroupMember.GroupId
		/// </summary>
		public virtual IEntityRelation SnGroupMemberEntityUsingGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnGroupMembers" , true);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnGroupMemberFields.GroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupMemberEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnGroupEntity and SnGroupRequestEntity over the 1:n relation they have, using the relation between the fields:
		/// SnGroup.Id - SnGroupRequest.GroupId
		/// </summary>
		public virtual IEntityRelation SnGroupRequestEntityUsingGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnGroupRequests" , true);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnGroupRequestFields.GroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupRequestEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnGroupEntity and SnNoteEntity over the 1:n relation they have, using the relation between the fields:
		/// SnGroup.Id - SnNote.GroupId
		/// </summary>
		public virtual IEntityRelation SnNoteEntityUsingGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnNotes" , true);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnNoteFields.GroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnGroupEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// SnGroup.Id - SnRelationship.GroupId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationshipss" , true);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnRelationshipFields.GroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnGroupEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnGroup.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnGroupFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnGroupEntity and SnGroupCategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// SnGroup.GroupCategoryId - SnGroupCategory.Id
		/// </summary>
		public virtual IEntityRelation SnGroupCategoryEntityUsingGroupCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnGroupCategory", false);
				relation.AddEntityFieldPair(SnGroupCategoryFields.Id, SnGroupFields.GroupCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupCategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", true);
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
	internal static class StaticSnGroupRelations
	{
		internal static readonly IEntityRelation SnAlbumEntityUsingSnGroupIdStatic = new SnGroupRelations().SnAlbumEntityUsingSnGroupId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingSnGroupIdStatic = new SnGroupRelations().SnDiscussionBoardEntityUsingSnGroupId;
		internal static readonly IEntityRelation SnEventEntityUsingSnGroupIdStatic = new SnGroupRelations().SnEventEntityUsingSnGroupId;
		internal static readonly IEntityRelation SnGroupMemberEntityUsingGroupIdStatic = new SnGroupRelations().SnGroupMemberEntityUsingGroupId;
		internal static readonly IEntityRelation SnGroupRequestEntityUsingGroupIdStatic = new SnGroupRelations().SnGroupRequestEntityUsingGroupId;
		internal static readonly IEntityRelation SnNoteEntityUsingGroupIdStatic = new SnGroupRelations().SnNoteEntityUsingGroupId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingGroupIdStatic = new SnGroupRelations().SnRelationshipEntityUsingGroupId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnGroupRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation SnGroupCategoryEntityUsingGroupCategoryIdStatic = new SnGroupRelations().SnGroupCategoryEntityUsingGroupCategoryId;

		/// <summary>CTor</summary>
		static StaticSnGroupRelations()
		{
		}
	}
}
