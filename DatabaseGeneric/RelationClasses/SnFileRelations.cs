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
	/// <summary>Implements the relations factory for the entity: SnFile. </summary>
	public partial class SnFileRelations
	{
		/// <summary>CTor</summary>
		public SnFileRelations()
		{
		}

		/// <summary>Gets all relations of the SnFileEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnEventEntityUsingSnFileId);
			toReturn.Add(this.SnRelationshipEntityUsingFileId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.PrivacyLevelEntityUsingPrivacyLevelId);
			toReturn.Add(this.SnAlbumEntityUsingAlbumId);
			toReturn.Add(this.SnRelationshipEntityUsingRelationshipId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnFileEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// SnFile.Id - SnEvent.SnFileId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingSnFileId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnEvents" , true);
				relation.AddEntityFieldPair(SnFileFields.Id, SnEventFields.SnFileId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnFileEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// SnFile.Id - SnRelationship.FileId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingFileId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(SnFileFields.Id, SnRelationshipFields.FileId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnFileEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnFile.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnFileFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnFileEntity and PrivacyLevelEntity over the m:1 relation they have, using the relation between the fields:
		/// SnFile.PrivacyLevelId - PrivacyLevel.Id
		/// </summary>
		public virtual IEntityRelation PrivacyLevelEntityUsingPrivacyLevelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PrivacyLevel", false);
				relation.AddEntityFieldPair(PrivacyLevelFields.Id, SnFileFields.PrivacyLevelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnFileEntity and SnAlbumEntity over the m:1 relation they have, using the relation between the fields:
		/// SnFile.AlbumId - SnAlbum.Id
		/// </summary>
		public virtual IEntityRelation SnAlbumEntityUsingAlbumId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnAlbum", false);
				relation.AddEntityFieldPair(SnAlbumFields.Id, SnFileFields.AlbumId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnFileEntity and SnRelationshipEntity over the m:1 relation they have, using the relation between the fields:
		/// SnFile.RelationshipId - SnRelationship.Id
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingRelationshipId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnRelationship", false);
				relation.AddEntityFieldPair(SnRelationshipFields.Id, SnFileFields.RelationshipId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", true);
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
	internal static class StaticSnFileRelations
	{
		internal static readonly IEntityRelation SnEventEntityUsingSnFileIdStatic = new SnFileRelations().SnEventEntityUsingSnFileId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingFileIdStatic = new SnFileRelations().SnRelationshipEntityUsingFileId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnFileRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation PrivacyLevelEntityUsingPrivacyLevelIdStatic = new SnFileRelations().PrivacyLevelEntityUsingPrivacyLevelId;
		internal static readonly IEntityRelation SnAlbumEntityUsingAlbumIdStatic = new SnFileRelations().SnAlbumEntityUsingAlbumId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingRelationshipIdStatic = new SnFileRelations().SnRelationshipEntityUsingRelationshipId;

		/// <summary>CTor</summary>
		static StaticSnFileRelations()
		{
		}
	}
}
