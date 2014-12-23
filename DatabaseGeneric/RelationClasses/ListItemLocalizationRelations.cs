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
	/// <summary>Implements the relations factory for the entity: ListItemLocalization. </summary>
	public partial class ListItemLocalizationRelations
	{
		/// <summary>CTor</summary>
		public ListItemLocalizationRelations()
		{
		}

		/// <summary>Gets all relations of the ListItemLocalizationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			toReturn.Add(this.ListItemEntityUsingListItemId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ListItemLocalizationEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// ListItemLocalization.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, ListItemLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemLocalizationEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ListItemLocalizationEntity and ListItemEntity over the m:1 relation they have, using the relation between the fields:
		/// ListItemLocalization.ListItemId - ListItem.Id
		/// </summary>
		public virtual IEntityRelation ListItemEntityUsingListItemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ListItem", false);
				relation.AddEntityFieldPair(ListItemFields.Id, ListItemLocalizationFields.ListItemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemLocalizationEntity", true);
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
	internal static class StaticListItemLocalizationRelations
	{
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new ListItemLocalizationRelations().LanguageEntityUsingLanguageId;
		internal static readonly IEntityRelation ListItemEntityUsingListItemIdStatic = new ListItemLocalizationRelations().ListItemEntityUsingListItemId;

		/// <summary>CTor</summary>
		static StaticListItemLocalizationRelations()
		{
		}
	}
}
