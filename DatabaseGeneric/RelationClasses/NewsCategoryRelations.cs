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
	/// <summary>Implements the relations factory for the entity: NewsCategory. </summary>
	public partial class NewsCategoryRelations
	{
		/// <summary>CTor</summary>
		public NewsCategoryRelations()
		{
		}

		/// <summary>Gets all relations of the NewsCategoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.NewsCategoryEntityUsingNewsCategoryId);
			toReturn.Add(this.NewsCategoryInRoleEntityUsingNewsCategoryId);
			toReturn.Add(this.NewsCategoryLocalizationEntityUsingNewsCategoryId);
			toReturn.Add(this.NewsItemEntityUsingNewsCategoryId);
			toReturn.Add(this.SnRelationshipEntityUsingNewsCategoryId);
			toReturn.Add(this.NewsCategoryTemplateEntityUsingId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.NewsCategoryEntityUsingIdNewsCategoryId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between NewsCategoryEntity and NewsCategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// NewsCategory.Id - NewsCategory.NewsCategoryId
		/// </summary>
		public virtual IEntityRelation NewsCategoryEntityUsingNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsCategoryChildrens" , true);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, NewsCategoryFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsCategoryEntity and NewsCategoryInRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// NewsCategory.Id - NewsCategoryInRole.NewsCategoryId
		/// </summary>
		public virtual IEntityRelation NewsCategoryInRoleEntityUsingNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsCategoryInRoles" , true);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, NewsCategoryInRoleFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryInRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsCategoryEntity and NewsCategoryLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// NewsCategory.Id - NewsCategoryLocalization.NewsCategoryId
		/// </summary>
		public virtual IEntityRelation NewsCategoryLocalizationEntityUsingNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsCategoryLocalizations" , true);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, NewsCategoryLocalizationFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsCategoryEntity and NewsItemEntity over the 1:n relation they have, using the relation between the fields:
		/// NewsCategory.Id - NewsItem.NewsCategoryId
		/// </summary>
		public virtual IEntityRelation NewsItemEntityUsingNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsItems" , true);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, NewsItemFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsCategoryEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// NewsCategory.Id - SnRelationship.NewsCategoryId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationshipss" , true);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, SnRelationshipFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsCategoryEntity and NewsCategoryTemplateEntity over the 1:1 relation they have, using the relation between the fields:
		/// NewsCategory.Id - NewsCategoryTemplate.Id
		/// </summary>
		public virtual IEntityRelation NewsCategoryTemplateEntityUsingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "NewsCategoryTemplate", true);

				relation.AddEntityFieldPair(NewsCategoryFields.Id, NewsCategoryTemplateFields.Id);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryTemplateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsCategoryEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsCategory.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplications", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, NewsCategoryFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NewsCategoryEntity and NewsCategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsCategory.NewsCategoryId - NewsCategory.Id
		/// </summary>
		public virtual IEntityRelation NewsCategoryEntityUsingIdNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "NewsCategoryParent", false);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, NewsCategoryFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", true);
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
	internal static class StaticNewsCategoryRelations
	{
		internal static readonly IEntityRelation NewsCategoryEntityUsingNewsCategoryIdStatic = new NewsCategoryRelations().NewsCategoryEntityUsingNewsCategoryId;
		internal static readonly IEntityRelation NewsCategoryInRoleEntityUsingNewsCategoryIdStatic = new NewsCategoryRelations().NewsCategoryInRoleEntityUsingNewsCategoryId;
		internal static readonly IEntityRelation NewsCategoryLocalizationEntityUsingNewsCategoryIdStatic = new NewsCategoryRelations().NewsCategoryLocalizationEntityUsingNewsCategoryId;
		internal static readonly IEntityRelation NewsItemEntityUsingNewsCategoryIdStatic = new NewsCategoryRelations().NewsItemEntityUsingNewsCategoryId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingNewsCategoryIdStatic = new NewsCategoryRelations().SnRelationshipEntityUsingNewsCategoryId;
		internal static readonly IEntityRelation NewsCategoryTemplateEntityUsingIdStatic = new NewsCategoryRelations().NewsCategoryTemplateEntityUsingId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new NewsCategoryRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation NewsCategoryEntityUsingIdNewsCategoryIdStatic = new NewsCategoryRelations().NewsCategoryEntityUsingIdNewsCategoryId;

		/// <summary>CTor</summary>
		static StaticNewsCategoryRelations()
		{
		}
	}
}
