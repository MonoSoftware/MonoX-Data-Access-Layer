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
	/// <summary>Implements the relations factory for the entity: PrivacyLevel. </summary>
	public partial class PrivacyLevelRelations
	{
		/// <summary>CTor</summary>
		public PrivacyLevelRelations()
		{
		}

		/// <summary>Gets all relations of the PrivacyLevelEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PrivacyLevelDefinitionEntityUsingPrivacyLevelId);
			toReturn.Add(this.SnAlbumEntityUsingPrivacyLevelId);
			toReturn.Add(this.SnFileEntityUsingPrivacyLevelId);
			toReturn.Add(this.SnNoteEntityUsingPrivacyLevelId);
			toReturn.Add(this.UserProfileEntityUsingMyStatusPrivacyLevelId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PrivacyLevelEntity and PrivacyLevelDefinitionEntity over the 1:n relation they have, using the relation between the fields:
		/// PrivacyLevel.Id - PrivacyLevelDefinition.PrivacyLevelId
		/// </summary>
		public virtual IEntityRelation PrivacyLevelDefinitionEntityUsingPrivacyLevelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PrivacyLevelDefinitions" , true);
				relation.AddEntityFieldPair(PrivacyLevelFields.Id, PrivacyLevelDefinitionFields.PrivacyLevelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelDefinitionEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PrivacyLevelEntity and SnAlbumEntity over the 1:n relation they have, using the relation between the fields:
		/// PrivacyLevel.Id - SnAlbum.PrivacyLevelId
		/// </summary>
		public virtual IEntityRelation SnAlbumEntityUsingPrivacyLevelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnAlbums" , true);
				relation.AddEntityFieldPair(PrivacyLevelFields.Id, SnAlbumFields.PrivacyLevelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PrivacyLevelEntity and SnFileEntity over the 1:n relation they have, using the relation between the fields:
		/// PrivacyLevel.Id - SnFile.PrivacyLevelId
		/// </summary>
		public virtual IEntityRelation SnFileEntityUsingPrivacyLevelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFiles" , true);
				relation.AddEntityFieldPair(PrivacyLevelFields.Id, SnFileFields.PrivacyLevelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFileEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PrivacyLevelEntity and SnNoteEntity over the 1:n relation they have, using the relation between the fields:
		/// PrivacyLevel.Id - SnNote.PrivacyLevelId
		/// </summary>
		public virtual IEntityRelation SnNoteEntityUsingPrivacyLevelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnNotes" , true);
				relation.AddEntityFieldPair(PrivacyLevelFields.Id, SnNoteFields.PrivacyLevelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PrivacyLevelEntity and UserProfileEntity over the 1:n relation they have, using the relation between the fields:
		/// PrivacyLevel.Id - UserProfile.MyStatusPrivacyLevelId
		/// </summary>
		public virtual IEntityRelation UserProfileEntityUsingMyStatusPrivacyLevelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "UserProfile" , true);
				relation.AddEntityFieldPair(PrivacyLevelFields.Id, UserProfileFields.MyStatusPrivacyLevelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserProfileEntity", false);
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
	internal static class StaticPrivacyLevelRelations
	{
		internal static readonly IEntityRelation PrivacyLevelDefinitionEntityUsingPrivacyLevelIdStatic = new PrivacyLevelRelations().PrivacyLevelDefinitionEntityUsingPrivacyLevelId;
		internal static readonly IEntityRelation SnAlbumEntityUsingPrivacyLevelIdStatic = new PrivacyLevelRelations().SnAlbumEntityUsingPrivacyLevelId;
		internal static readonly IEntityRelation SnFileEntityUsingPrivacyLevelIdStatic = new PrivacyLevelRelations().SnFileEntityUsingPrivacyLevelId;
		internal static readonly IEntityRelation SnNoteEntityUsingPrivacyLevelIdStatic = new PrivacyLevelRelations().SnNoteEntityUsingPrivacyLevelId;
		internal static readonly IEntityRelation UserProfileEntityUsingMyStatusPrivacyLevelIdStatic = new PrivacyLevelRelations().UserProfileEntityUsingMyStatusPrivacyLevelId;

		/// <summary>CTor</summary>
		static StaticPrivacyLevelRelations()
		{
		}
	}
}
