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
	/// <summary>Implements the relations factory for the entity: Navigation. </summary>
	public partial class NavigationRelations
	{
		/// <summary>CTor</summary>
		public NavigationRelations()
		{
		}

		/// <summary>Gets all relations of the NavigationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.NavigationEntityUsingParentId);
			toReturn.Add(this.NavigationLocalizationEntityUsingNavigationId);
			toReturn.Add(this.NavigationRoleEntityUsingNavigationId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.NavigationEntityUsingIdParentId);
			toReturn.Add(this.PageEntityUsingPageId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between NavigationEntity and NavigationEntity over the 1:n relation they have, using the relation between the fields:
		/// Navigation.Id - Navigation.ParentId
		/// </summary>
		public virtual IEntityRelation NavigationEntityUsingParentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ChildNavigationItems" , true);
				relation.AddEntityFieldPair(NavigationFields.Id, NavigationFields.ParentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NavigationEntity and NavigationLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Navigation.Id - NavigationLocalization.NavigationId
		/// </summary>
		public virtual IEntityRelation NavigationLocalizationEntityUsingNavigationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NavigationLocalizations" , true);
				relation.AddEntityFieldPair(NavigationFields.Id, NavigationLocalizationFields.NavigationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NavigationEntity and NavigationRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// Navigation.Id - NavigationRole.NavigationId
		/// </summary>
		public virtual IEntityRelation NavigationRoleEntityUsingNavigationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NavigationRoles" , true);
				relation.AddEntityFieldPair(NavigationFields.Id, NavigationRoleFields.NavigationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationRoleEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between NavigationEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// Navigation.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplication", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, NavigationFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NavigationEntity and NavigationEntity over the m:1 relation they have, using the relation between the fields:
		/// Navigation.ParentId - Navigation.Id
		/// </summary>
		public virtual IEntityRelation NavigationEntityUsingIdParentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ParentNavigationItem", false);
				relation.AddEntityFieldPair(NavigationFields.Id, NavigationFields.ParentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NavigationEntity and PageEntity over the m:1 relation they have, using the relation between the fields:
		/// Navigation.PageId - Page.Id
		/// </summary>
		public virtual IEntityRelation PageEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Page", false);
				relation.AddEntityFieldPair(PageFields.Id, NavigationFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", true);
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
	internal static class StaticNavigationRelations
	{
		internal static readonly IEntityRelation NavigationEntityUsingParentIdStatic = new NavigationRelations().NavigationEntityUsingParentId;
		internal static readonly IEntityRelation NavigationLocalizationEntityUsingNavigationIdStatic = new NavigationRelations().NavigationLocalizationEntityUsingNavigationId;
		internal static readonly IEntityRelation NavigationRoleEntityUsingNavigationIdStatic = new NavigationRelations().NavigationRoleEntityUsingNavigationId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new NavigationRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation NavigationEntityUsingIdParentIdStatic = new NavigationRelations().NavigationEntityUsingIdParentId;
		internal static readonly IEntityRelation PageEntityUsingPageIdStatic = new NavigationRelations().PageEntityUsingPageId;

		/// <summary>CTor</summary>
		static StaticNavigationRelations()
		{
		}
	}
}
