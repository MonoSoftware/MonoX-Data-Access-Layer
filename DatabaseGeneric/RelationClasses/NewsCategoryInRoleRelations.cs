﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: NewsCategoryInRole. </summary>
	public partial class NewsCategoryInRoleRelations
	{
		/// <summary>CTor</summary>
		public NewsCategoryInRoleRelations()
		{
		}

		/// <summary>Gets all relations of the NewsCategoryInRoleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetRolesEntityUsingRoleId);
			toReturn.Add(this.NewsCategoryEntityUsingNewsCategoryId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between NewsCategoryInRoleEntity and AspnetRolesEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsCategoryInRole.RoleId - AspnetRoles.RoleId
		/// </summary>
		public virtual IEntityRelation AspnetRolesEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetRole", false);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, NewsCategoryInRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryInRoleEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NewsCategoryInRoleEntity and NewsCategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsCategoryInRole.NewsCategoryId - NewsCategory.Id
		/// </summary>
		public virtual IEntityRelation NewsCategoryEntityUsingNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "NewsCategory", false);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, NewsCategoryInRoleFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryInRoleEntity", true);
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
	internal static class StaticNewsCategoryInRoleRelations
	{
		internal static readonly IEntityRelation AspnetRolesEntityUsingRoleIdStatic = new NewsCategoryInRoleRelations().AspnetRolesEntityUsingRoleId;
		internal static readonly IEntityRelation NewsCategoryEntityUsingNewsCategoryIdStatic = new NewsCategoryInRoleRelations().NewsCategoryEntityUsingNewsCategoryId;

		/// <summary>CTor</summary>
		static StaticNewsCategoryInRoleRelations()
		{
		}
	}
}
