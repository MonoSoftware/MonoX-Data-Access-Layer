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
	/// <summary>Implements the relations factory for the entity: Document. </summary>
	public partial class DocumentRelations
	{
		/// <summary>CTor</summary>
		public DocumentRelations()
		{
		}

		/// <summary>Gets all relations of the DocumentEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnRelationshipEntityUsingDocumentId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			toReturn.Add(this.PageEntityUsingPageId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DocumentEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// Document.Id - SnRelationship.DocumentId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingDocumentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(DocumentFields.Id, SnRelationshipFields.DocumentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between DocumentEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// Document.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, DocumentFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DocumentEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// Document.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, DocumentFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DocumentEntity and PageEntity over the m:1 relation they have, using the relation between the fields:
		/// Document.PageId - Page.Id
		/// </summary>
		public virtual IEntityRelation PageEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Page", false);
				relation.AddEntityFieldPair(PageFields.Id, DocumentFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", true);
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
	internal static class StaticDocumentRelations
	{
		internal static readonly IEntityRelation SnRelationshipEntityUsingDocumentIdStatic = new DocumentRelations().SnRelationshipEntityUsingDocumentId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new DocumentRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new DocumentRelations().LanguageEntityUsingLanguageId;
		internal static readonly IEntityRelation PageEntityUsingPageIdStatic = new DocumentRelations().PageEntityUsingPageId;

		/// <summary>CTor</summary>
		static StaticDocumentRelations()
		{
		}
	}
}
