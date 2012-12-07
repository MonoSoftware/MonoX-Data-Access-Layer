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
	/// <summary>Implements the relations factory for the entity: BlogPostRole. </summary>
	public partial class BlogPostRoleRelations
	{
		/// <summary>CTor</summary>
		public BlogPostRoleRelations()
		{
		}

		/// <summary>Gets all relations of the BlogPostRoleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetRolesEntityUsingRoleId);
			toReturn.Add(this.BlogPostEntityUsingBlogPostId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BlogPostRoleEntity and AspnetRolesEntity over the m:1 relation they have, using the relation between the fields:
		/// BlogPostRole.RoleId - AspnetRoles.RoleId
		/// </summary>
		public virtual IEntityRelation AspnetRolesEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetRole", false);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, BlogPostRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostRoleEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BlogPostRoleEntity and BlogPostEntity over the m:1 relation they have, using the relation between the fields:
		/// BlogPostRole.BlogPostId - BlogPost.Id
		/// </summary>
		public virtual IEntityRelation BlogPostEntityUsingBlogPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BlogPost", false);
				relation.AddEntityFieldPair(BlogPostFields.Id, BlogPostRoleFields.BlogPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostRoleEntity", true);
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
	internal static class StaticBlogPostRoleRelations
	{
		internal static readonly IEntityRelation AspnetRolesEntityUsingRoleIdStatic = new BlogPostRoleRelations().AspnetRolesEntityUsingRoleId;
		internal static readonly IEntityRelation BlogPostEntityUsingBlogPostIdStatic = new BlogPostRoleRelations().BlogPostEntityUsingBlogPostId;

		/// <summary>CTor</summary>
		static StaticBlogPostRoleRelations()
		{
		}
	}
}
