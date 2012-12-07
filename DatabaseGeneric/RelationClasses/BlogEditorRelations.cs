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
	/// <summary>Implements the relations factory for the entity: BlogEditor. </summary>
	public partial class BlogEditorRelations
	{
		/// <summary>CTor</summary>
		public BlogEditorRelations()
		{
		}

		/// <summary>Gets all relations of the BlogEditorEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.BlogEntityUsingBlogId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BlogEditorEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// BlogEditor.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, BlogEditorFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEditorEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BlogEditorEntity and BlogEntity over the m:1 relation they have, using the relation between the fields:
		/// BlogEditor.BlogId - Blog.Id
		/// </summary>
		public virtual IEntityRelation BlogEntityUsingBlogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Blog", false);
				relation.AddEntityFieldPair(BlogFields.Id, BlogEditorFields.BlogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEditorEntity", true);
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
	internal static class StaticBlogEditorRelations
	{
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new BlogEditorRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation BlogEntityUsingBlogIdStatic = new BlogEditorRelations().BlogEntityUsingBlogId;

		/// <summary>CTor</summary>
		static StaticBlogEditorRelations()
		{
		}
	}
}
