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
	/// <summary>Implements the relations factory for the entity: NewsCategoryLocalization. </summary>
	public partial class NewsCategoryLocalizationRelations
	{
		/// <summary>CTor</summary>
		public NewsCategoryLocalizationRelations()
		{
		}

		/// <summary>Gets all relations of the NewsCategoryLocalizationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			toReturn.Add(this.NewsCategoryEntityUsingNewsCategoryId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between NewsCategoryLocalizationEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsCategoryLocalization.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, NewsCategoryLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryLocalizationEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NewsCategoryLocalizationEntity and NewsCategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsCategoryLocalization.NewsCategoryId - NewsCategory.Id
		/// </summary>
		public virtual IEntityRelation NewsCategoryEntityUsingNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "NewsCategory", false);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, NewsCategoryLocalizationFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryLocalizationEntity", true);
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
	internal static class StaticNewsCategoryLocalizationRelations
	{
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new NewsCategoryLocalizationRelations().LanguageEntityUsingLanguageId;
		internal static readonly IEntityRelation NewsCategoryEntityUsingNewsCategoryIdStatic = new NewsCategoryLocalizationRelations().NewsCategoryEntityUsingNewsCategoryId;

		/// <summary>CTor</summary>
		static StaticNewsCategoryLocalizationRelations()
		{
		}
	}
}
