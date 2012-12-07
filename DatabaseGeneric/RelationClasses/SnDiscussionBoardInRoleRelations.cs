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
	/// <summary>Implements the relations factory for the entity: SnDiscussionBoardInRole. </summary>
	public partial class SnDiscussionBoardInRoleRelations
	{
		/// <summary>CTor</summary>
		public SnDiscussionBoardInRoleRelations()
		{
		}

		/// <summary>Gets all relations of the SnDiscussionBoardInRoleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetRolesEntityUsingRoleId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingBoardId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardInRoleEntity and AspnetRolesEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionBoardInRole.RoleId - AspnetRoles.RoleId
		/// </summary>
		public virtual IEntityRelation AspnetRolesEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetRole", false);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, SnDiscussionBoardInRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardInRoleEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardInRoleEntity and SnDiscussionBoardEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionBoardInRole.BoardId - SnDiscussionBoard.Id
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnDiscussionBoard", false);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnDiscussionBoardInRoleFields.BoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardInRoleEntity", true);
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
	internal static class StaticSnDiscussionBoardInRoleRelations
	{
		internal static readonly IEntityRelation AspnetRolesEntityUsingRoleIdStatic = new SnDiscussionBoardInRoleRelations().AspnetRolesEntityUsingRoleId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingBoardIdStatic = new SnDiscussionBoardInRoleRelations().SnDiscussionBoardEntityUsingBoardId;

		/// <summary>CTor</summary>
		static StaticSnDiscussionBoardInRoleRelations()
		{
		}
	}
}
