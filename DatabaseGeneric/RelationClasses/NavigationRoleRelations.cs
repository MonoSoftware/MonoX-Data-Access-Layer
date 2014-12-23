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
	/// <summary>Implements the relations factory for the entity: NavigationRole. </summary>
	public partial class NavigationRoleRelations
	{
		/// <summary>CTor</summary>
		public NavigationRoleRelations()
		{
		}

		/// <summary>Gets all relations of the NavigationRoleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetRolesEntityUsingRoleId);
			toReturn.Add(this.NavigationEntityUsingNavigationId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between NavigationRoleEntity and AspnetRolesEntity over the m:1 relation they have, using the relation between the fields:
		/// NavigationRole.RoleId - AspnetRoles.RoleId
		/// </summary>
		public virtual IEntityRelation AspnetRolesEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetRoles", false);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, NavigationRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationRoleEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NavigationRoleEntity and NavigationEntity over the m:1 relation they have, using the relation between the fields:
		/// NavigationRole.NavigationId - Navigation.Id
		/// </summary>
		public virtual IEntityRelation NavigationEntityUsingNavigationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Navigation", false);
				relation.AddEntityFieldPair(NavigationFields.Id, NavigationRoleFields.NavigationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationRoleEntity", true);
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
	internal static class StaticNavigationRoleRelations
	{
		internal static readonly IEntityRelation AspnetRolesEntityUsingRoleIdStatic = new NavigationRoleRelations().AspnetRolesEntityUsingRoleId;
		internal static readonly IEntityRelation NavigationEntityUsingNavigationIdStatic = new NavigationRoleRelations().NavigationEntityUsingNavigationId;

		/// <summary>CTor</summary>
		static StaticNavigationRoleRelations()
		{
		}
	}
}
