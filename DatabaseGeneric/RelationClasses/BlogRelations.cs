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
	/// <summary>Implements the relations factory for the entity: Blog. </summary>
	public partial class BlogRelations
	{
		/// <summary>CTor</summary>
		public BlogRelations()
		{
		}

		/// <summary>Gets all relations of the BlogEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BlogCategoryEntityUsingBlogId);
			toReturn.Add(this.BlogEditorEntityUsingBlogId);
			toReturn.Add(this.BlogPostEntityUsingBlogId);
			toReturn.Add(this.SnRelationshipEntityUsingBlogId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between BlogEntity and BlogCategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Blog.Id - BlogCategory.BlogId
		/// </summary>
		public virtual IEntityRelation BlogCategoryEntityUsingBlogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BlogCategory" , true);
				relation.AddEntityFieldPair(BlogFields.Id, BlogCategoryFields.BlogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogCategoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BlogEntity and BlogEditorEntity over the 1:n relation they have, using the relation between the fields:
		/// Blog.Id - BlogEditor.BlogId
		/// </summary>
		public virtual IEntityRelation BlogEditorEntityUsingBlogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BlogEditors" , true);
				relation.AddEntityFieldPair(BlogFields.Id, BlogEditorFields.BlogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEditorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BlogEntity and BlogPostEntity over the 1:n relation they have, using the relation between the fields:
		/// Blog.Id - BlogPost.BlogId
		/// </summary>
		public virtual IEntityRelation BlogPostEntityUsingBlogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BlogPosts" , true);
				relation.AddEntityFieldPair(BlogFields.Id, BlogPostFields.BlogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BlogEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// Blog.Id - SnRelationship.BlogId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingBlogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(BlogFields.Id, SnRelationshipFields.BlogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between BlogEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// Blog.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplication", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, BlogFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BlogEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// Blog.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, BlogFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BlogEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// Blog.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, BlogFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", true);
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
	internal static class StaticBlogRelations
	{
		internal static readonly IEntityRelation BlogCategoryEntityUsingBlogIdStatic = new BlogRelations().BlogCategoryEntityUsingBlogId;
		internal static readonly IEntityRelation BlogEditorEntityUsingBlogIdStatic = new BlogRelations().BlogEditorEntityUsingBlogId;
		internal static readonly IEntityRelation BlogPostEntityUsingBlogIdStatic = new BlogRelations().BlogPostEntityUsingBlogId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingBlogIdStatic = new BlogRelations().SnRelationshipEntityUsingBlogId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new BlogRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new BlogRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new BlogRelations().LanguageEntityUsingLanguageId;

		/// <summary>CTor</summary>
		static StaticBlogRelations()
		{
		}
	}
}
