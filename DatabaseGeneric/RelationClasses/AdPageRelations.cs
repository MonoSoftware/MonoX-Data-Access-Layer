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
	/// <summary>Implements the relations factory for the entity: AdPage. </summary>
	public partial class AdPageRelations
	{
		/// <summary>CTor</summary>
		public AdPageRelations()
		{
		}

		/// <summary>Gets all relations of the AdPageEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AdEntityUsingAdId);
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			toReturn.Add(this.PageEntityUsingPageId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between AdPageEntity and AdEntity over the m:1 relation they have, using the relation between the fields:
		/// AdPage.AdId - Ad.Id
		/// </summary>
		public virtual IEntityRelation AdEntityUsingAdId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Ad", false);
				relation.AddEntityFieldPair(AdFields.Id, AdPageFields.AdId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdPageEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AdPageEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// AdPage.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, AdPageFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdPageEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AdPageEntity and PageEntity over the m:1 relation they have, using the relation between the fields:
		/// AdPage.PageId - Page.Id
		/// </summary>
		public virtual IEntityRelation PageEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Page", false);
				relation.AddEntityFieldPair(PageFields.Id, AdPageFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdPageEntity", true);
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
	internal static class StaticAdPageRelations
	{
		internal static readonly IEntityRelation AdEntityUsingAdIdStatic = new AdPageRelations().AdEntityUsingAdId;
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new AdPageRelations().LanguageEntityUsingLanguageId;
		internal static readonly IEntityRelation PageEntityUsingPageIdStatic = new AdPageRelations().PageEntityUsingPageId;

		/// <summary>CTor</summary>
		static StaticAdPageRelations()
		{
		}
	}
}
