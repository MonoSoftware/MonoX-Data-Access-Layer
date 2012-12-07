﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: BlogCategory. </summary>
	public partial class BlogCategoryRelations
	{
		/// <summary>CTor</summary>
		public BlogCategoryRelations()
		{
		}

		/// <summary>Gets all relations of the BlogCategoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BlogPostCategoryEntityUsingBlogCategoryId);
			toReturn.Add(this.BlogEntityUsingBlogId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between BlogCategoryEntity and BlogPostCategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// BlogCategory.Id - BlogPostCategory.BlogCategoryId
		/// </summary>
		public virtual IEntityRelation BlogPostCategoryEntityUsingBlogCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BlogPostCategory" , true);
				relation.AddEntityFieldPair(BlogCategoryFields.Id, BlogPostCategoryFields.BlogCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostCategoryEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between BlogCategoryEntity and BlogEntity over the m:1 relation they have, using the relation between the fields:
		/// BlogCategory.BlogId - Blog.Id
		/// </summary>
		public virtual IEntityRelation BlogEntityUsingBlogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Blog", false);
				relation.AddEntityFieldPair(BlogFields.Id, BlogCategoryFields.BlogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogCategoryEntity", true);
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
	internal static class StaticBlogCategoryRelations
	{
		internal static readonly IEntityRelation BlogPostCategoryEntityUsingBlogCategoryIdStatic = new BlogCategoryRelations().BlogPostCategoryEntityUsingBlogCategoryId;
		internal static readonly IEntityRelation BlogEntityUsingBlogIdStatic = new BlogCategoryRelations().BlogEntityUsingBlogId;

		/// <summary>CTor</summary>
		static StaticBlogCategoryRelations()
		{
		}
	}
}