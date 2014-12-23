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
	/// <summary>Implements the relations factory for the entity: SnGroupCategory. </summary>
	public partial class SnGroupCategoryRelations
	{
		/// <summary>CTor</summary>
		public SnGroupCategoryRelations()
		{
		}

		/// <summary>Gets all relations of the SnGroupCategoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnGroupEntityUsingGroupCategoryId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnGroupCategoryEntity and SnGroupEntity over the 1:n relation they have, using the relation between the fields:
		/// SnGroupCategory.Id - SnGroup.GroupCategoryId
		/// </summary>
		public virtual IEntityRelation SnGroupEntityUsingGroupCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnGroups" , true);
				relation.AddEntityFieldPair(SnGroupCategoryFields.Id, SnGroupFields.GroupCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnGroupCategoryEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// SnGroupCategory.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplication", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnGroupCategoryFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupCategoryEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnGroupCategoryEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// SnGroupCategory.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, SnGroupCategoryFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupCategoryEntity", true);
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
	internal static class StaticSnGroupCategoryRelations
	{
		internal static readonly IEntityRelation SnGroupEntityUsingGroupCategoryIdStatic = new SnGroupCategoryRelations().SnGroupEntityUsingGroupCategoryId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new SnGroupCategoryRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new SnGroupCategoryRelations().LanguageEntityUsingLanguageId;

		/// <summary>CTor</summary>
		static StaticSnGroupCategoryRelations()
		{
		}
	}
}
