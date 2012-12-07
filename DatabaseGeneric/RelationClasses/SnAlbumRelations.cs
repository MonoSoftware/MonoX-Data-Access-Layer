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
	/// <summary>Implements the relations factory for the entity: SnAlbum. </summary>
	public partial class SnAlbumRelations
	{
		/// <summary>CTor</summary>
		public SnAlbumRelations()
		{
		}

		/// <summary>Gets all relations of the SnAlbumEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnEventEntityUsingSnAlbumId);
			toReturn.Add(this.SnFileEntityUsingAlbumId);
			toReturn.Add(this.SnRelationshipEntityUsingAlbumId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			toReturn.Add(this.PrivacyLevelEntityUsingPrivacyLevelId);
			toReturn.Add(this.SnGroupEntityUsingSnGroupId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnAlbumEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// SnAlbum.Id - SnEvent.SnAlbumId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingSnAlbumId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnEvents" , true);
				relation.AddEntityFieldPair(SnAlbumFields.Id, SnEventFields.SnAlbumId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnAlbumEntity and SnFileEntity over the 1:n relation they have, using the relation between the fields:
		/// SnAlbum.Id - SnFile.AlbumId
		/// </summary>
		public virtual IEntityRelation SnFileEntityUsingAlbumId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFiles" , true);
				relation.AddEntityFieldPair(SnAlbumFields.Id, SnFileFields.AlbumId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnAlbumEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// SnAlbum.Id - SnRelationship.AlbumId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingAlbumId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(SnAlbumFields.Id, SnRelationshipFields.AlbumId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnAlbumEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// SnAlbum.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplications", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnAlbumFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnAlbumEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnAlbum.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnAlbumFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnAlbumEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// SnAlbum.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, SnAlbumFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnAlbumEntity and PrivacyLevelEntity over the m:1 relation they have, using the relation between the fields:
		/// SnAlbum.PrivacyLevelId - PrivacyLevel.Id
		/// </summary>
		public virtual IEntityRelation PrivacyLevelEntityUsingPrivacyLevelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PrivacyLevel", false);
				relation.AddEntityFieldPair(PrivacyLevelFields.Id, SnAlbumFields.PrivacyLevelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnAlbumEntity and SnGroupEntity over the m:1 relation they have, using the relation between the fields:
		/// SnAlbum.SnGroupId - SnGroup.Id
		/// </summary>
		public virtual IEntityRelation SnGroupEntityUsingSnGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnGroup", false);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnAlbumFields.SnGroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", true);
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
	internal static class StaticSnAlbumRelations
	{
		internal static readonly IEntityRelation SnEventEntityUsingSnAlbumIdStatic = new SnAlbumRelations().SnEventEntityUsingSnAlbumId;
		internal static readonly IEntityRelation SnFileEntityUsingAlbumIdStatic = new SnAlbumRelations().SnFileEntityUsingAlbumId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingAlbumIdStatic = new SnAlbumRelations().SnRelationshipEntityUsingAlbumId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new SnAlbumRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnAlbumRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new SnAlbumRelations().LanguageEntityUsingLanguageId;
		internal static readonly IEntityRelation PrivacyLevelEntityUsingPrivacyLevelIdStatic = new SnAlbumRelations().PrivacyLevelEntityUsingPrivacyLevelId;
		internal static readonly IEntityRelation SnGroupEntityUsingSnGroupIdStatic = new SnAlbumRelations().SnGroupEntityUsingSnGroupId;

		/// <summary>CTor</summary>
		static StaticSnAlbumRelations()
		{
		}
	}
}
