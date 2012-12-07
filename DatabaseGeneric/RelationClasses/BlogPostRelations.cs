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
	/// <summary>Implements the relations factory for the entity: BlogPost. </summary>
	public partial class BlogPostRelations
	{
		/// <summary>CTor</summary>
		public BlogPostRelations()
		{
		}

		/// <summary>Gets all relations of the BlogPostEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BlogPostCategoryEntityUsingBlogPostId);
			toReturn.Add(this.BlogPostRoleEntityUsingBlogPostId);
			toReturn.Add(this.SnEventEntityUsingBlogPostId);
			toReturn.Add(this.SnRelationshipEntityUsingBlogPostId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.BlogEntityUsingBlogId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between BlogPostEntity and BlogPostCategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// BlogPost.Id - BlogPostCategory.BlogPostId
		/// </summary>
		public virtual IEntityRelation BlogPostCategoryEntityUsingBlogPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BlogPostCategories" , true);
				relation.AddEntityFieldPair(BlogPostFields.Id, BlogPostCategoryFields.BlogPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostCategoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BlogPostEntity and BlogPostRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// BlogPost.Id - BlogPostRole.BlogPostId
		/// </summary>
		public virtual IEntityRelation BlogPostRoleEntityUsingBlogPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BlogPostRoles" , true);
				relation.AddEntityFieldPair(BlogPostFields.Id, BlogPostRoleFields.BlogPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BlogPostEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// BlogPost.Id - SnEvent.BlogPostId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingBlogPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnEvents" , true);
				relation.AddEntityFieldPair(BlogPostFields.Id, SnEventFields.BlogPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BlogPostEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// BlogPost.Id - SnRelationship.BlogPostId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingBlogPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(BlogPostFields.Id, SnRelationshipFields.BlogPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between BlogPostEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// BlogPost.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, BlogPostFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BlogPostEntity and BlogEntity over the m:1 relation they have, using the relation between the fields:
		/// BlogPost.BlogId - Blog.Id
		/// </summary>
		public virtual IEntityRelation BlogEntityUsingBlogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Blog", false);
				relation.AddEntityFieldPair(BlogFields.Id, BlogPostFields.BlogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", true);
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
	internal static class StaticBlogPostRelations
	{
		internal static readonly IEntityRelation BlogPostCategoryEntityUsingBlogPostIdStatic = new BlogPostRelations().BlogPostCategoryEntityUsingBlogPostId;
		internal static readonly IEntityRelation BlogPostRoleEntityUsingBlogPostIdStatic = new BlogPostRelations().BlogPostRoleEntityUsingBlogPostId;
		internal static readonly IEntityRelation SnEventEntityUsingBlogPostIdStatic = new BlogPostRelations().SnEventEntityUsingBlogPostId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingBlogPostIdStatic = new BlogPostRelations().SnRelationshipEntityUsingBlogPostId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new BlogPostRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation BlogEntityUsingBlogIdStatic = new BlogPostRelations().BlogEntityUsingBlogId;

		/// <summary>CTor</summary>
		static StaticBlogPostRelations()
		{
		}
	}
}
