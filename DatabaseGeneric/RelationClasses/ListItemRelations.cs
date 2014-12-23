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
	/// <summary>Implements the relations factory for the entity: ListItem. </summary>
	public partial class ListItemRelations
	{
		/// <summary>CTor</summary>
		public ListItemRelations()
		{
		}

		/// <summary>Gets all relations of the ListItemEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ListItemLocalizationEntityUsingListItemId);
			toReturn.Add(this.SnRelationshipEntityUsingListItemId);
			toReturn.Add(this.ListEntityUsingListId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ListItemEntity and ListItemLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// ListItem.Id - ListItemLocalization.ListItemId
		/// </summary>
		public virtual IEntityRelation ListItemLocalizationEntityUsingListItemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ListItemLocalizations" , true);
				relation.AddEntityFieldPair(ListItemFields.Id, ListItemLocalizationFields.ListItemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ListItemEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// ListItem.Id - SnRelationship.ListItemId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingListItemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(ListItemFields.Id, SnRelationshipFields.ListItemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ListItemEntity and ListEntity over the m:1 relation they have, using the relation between the fields:
		/// ListItem.ListId - List.Id
		/// </summary>
		public virtual IEntityRelation ListEntityUsingListId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "List", false);
				relation.AddEntityFieldPair(ListFields.Id, ListItemFields.ListId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemEntity", true);
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
	internal static class StaticListItemRelations
	{
		internal static readonly IEntityRelation ListItemLocalizationEntityUsingListItemIdStatic = new ListItemRelations().ListItemLocalizationEntityUsingListItemId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingListItemIdStatic = new ListItemRelations().SnRelationshipEntityUsingListItemId;
		internal static readonly IEntityRelation ListEntityUsingListIdStatic = new ListItemRelations().ListEntityUsingListId;

		/// <summary>CTor</summary>
		static StaticListItemRelations()
		{
		}
	}
}
