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
	/// <summary>Implements the relations factory for the entity: SnNote. </summary>
	public partial class SnNoteRelations
	{
		/// <summary>CTor</summary>
		public SnNoteRelations()
		{
		}

		/// <summary>Gets all relations of the SnNoteEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnEventEntityUsingSnNoteId);
			toReturn.Add(this.SnRelationshipEntityUsingNoteId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.AspnetUsersEntityUsingPostToUserId);
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			toReturn.Add(this.PrivacyLevelEntityUsingPrivacyLevelId);
			toReturn.Add(this.SnGroupEntityUsingGroupId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnNoteEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// SnNote.Id - SnEvent.SnNoteId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingSnNoteId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnEvents" , true);
				relation.AddEntityFieldPair(SnNoteFields.Id, SnEventFields.SnNoteId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnNoteEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// SnNote.Id - SnRelationship.NoteId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingNoteId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(SnNoteFields.Id, SnRelationshipFields.NoteId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnNoteEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// SnNote.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplication", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnNoteFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnNoteEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnNote.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUserAuthor", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnNoteFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnNoteEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnNote.PostToUserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingPostToUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUserPostedTo", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnNoteFields.PostToUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnNoteEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// SnNote.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, SnNoteFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnNoteEntity and PrivacyLevelEntity over the m:1 relation they have, using the relation between the fields:
		/// SnNote.PrivacyLevelId - PrivacyLevel.Id
		/// </summary>
		public virtual IEntityRelation PrivacyLevelEntityUsingPrivacyLevelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PrivacyLevel", false);
				relation.AddEntityFieldPair(PrivacyLevelFields.Id, SnNoteFields.PrivacyLevelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnNoteEntity and SnGroupEntity over the m:1 relation they have, using the relation between the fields:
		/// SnNote.GroupId - SnGroup.Id
		/// </summary>
		public virtual IEntityRelation SnGroupEntityUsingGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnGroup", false);
				relation.AddEntityFieldPair(SnGroupFields.Id, SnNoteFields.GroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", true);
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
	internal static class StaticSnNoteRelations
	{
		internal static readonly IEntityRelation SnEventEntityUsingSnNoteIdStatic = new SnNoteRelations().SnEventEntityUsingSnNoteId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingNoteIdStatic = new SnNoteRelations().SnRelationshipEntityUsingNoteId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new SnNoteRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnNoteRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingPostToUserIdStatic = new SnNoteRelations().AspnetUsersEntityUsingPostToUserId;
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new SnNoteRelations().LanguageEntityUsingLanguageId;
		internal static readonly IEntityRelation PrivacyLevelEntityUsingPrivacyLevelIdStatic = new SnNoteRelations().PrivacyLevelEntityUsingPrivacyLevelId;
		internal static readonly IEntityRelation SnGroupEntityUsingGroupIdStatic = new SnNoteRelations().SnGroupEntityUsingGroupId;

		/// <summary>CTor</summary>
		static StaticSnNoteRelations()
		{
		}
	}
}
