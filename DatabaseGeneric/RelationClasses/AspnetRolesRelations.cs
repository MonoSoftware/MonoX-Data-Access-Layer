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
	/// <summary>Implements the relations factory for the entity: AspnetRoles. </summary>
	public partial class AspnetRolesRelations
	{
		/// <summary>CTor</summary>
		public AspnetRolesRelations()
		{
		}

		/// <summary>Gets all relations of the AspnetRolesEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetUsersInRolesEntityUsingRoleId);
			toReturn.Add(this.BlogPostRoleEntityUsingRoleId);
			toReturn.Add(this.CalendarEditRoleEntityUsingRoleId);
			toReturn.Add(this.CalendarViewRoleEntityUsingRoleId);
			toReturn.Add(this.NavigationRoleEntityUsingRoleId);
			toReturn.Add(this.NewsCategoryInRoleEntityUsingRoleId);
			toReturn.Add(this.NewsletterRoleEntityUsingRoleId);
			toReturn.Add(this.PageEditRoleEntityUsingRoleId);
			toReturn.Add(this.PageRoleEntityUsingRoleId);
			toReturn.Add(this.SnDiscussionBoardInRoleEntityUsingRoleId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and AspnetUsersInRolesEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - AspnetUsersInRoles.RoleId
		/// </summary>
		public virtual IEntityRelation AspnetUsersInRolesEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AspnetUsersInRoles" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, AspnetUsersInRolesFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersInRolesEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and BlogPostRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - BlogPostRole.RoleId
		/// </summary>
		public virtual IEntityRelation BlogPostRoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, BlogPostRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogPostRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and CalendarEditRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - CalendarEditRole.RoleId
		/// </summary>
		public virtual IEntityRelation CalendarEditRoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarEditRoles" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, CalendarEditRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEditRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and CalendarViewRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - CalendarViewRole.RoleId
		/// </summary>
		public virtual IEntityRelation CalendarViewRoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarViewRoles" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, CalendarViewRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarViewRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and NavigationRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - NavigationRole.RoleId
		/// </summary>
		public virtual IEntityRelation NavigationRoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, NavigationRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and NewsCategoryInRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - NewsCategoryInRole.RoleId
		/// </summary>
		public virtual IEntityRelation NewsCategoryInRoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, NewsCategoryInRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryInRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and NewsletterRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - NewsletterRole.RoleId
		/// </summary>
		public virtual IEntityRelation NewsletterRoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, NewsletterRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and PageEditRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - PageEditRole.RoleId
		/// </summary>
		public virtual IEntityRelation PageEditRoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, PageEditRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEditRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and PageRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - PageRole.RoleId
		/// </summary>
		public virtual IEntityRelation PageRoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, PageRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and SnDiscussionBoardInRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetRoles.RoleId - SnDiscussionBoardInRole.RoleId
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardInRoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, SnDiscussionBoardInRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardInRoleEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AspnetRolesEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// AspnetRoles.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplications", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, AspnetRolesFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", true);
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
	internal static class StaticAspnetRolesRelations
	{
		internal static readonly IEntityRelation AspnetUsersInRolesEntityUsingRoleIdStatic = new AspnetRolesRelations().AspnetUsersInRolesEntityUsingRoleId;
		internal static readonly IEntityRelation BlogPostRoleEntityUsingRoleIdStatic = new AspnetRolesRelations().BlogPostRoleEntityUsingRoleId;
		internal static readonly IEntityRelation CalendarEditRoleEntityUsingRoleIdStatic = new AspnetRolesRelations().CalendarEditRoleEntityUsingRoleId;
		internal static readonly IEntityRelation CalendarViewRoleEntityUsingRoleIdStatic = new AspnetRolesRelations().CalendarViewRoleEntityUsingRoleId;
		internal static readonly IEntityRelation NavigationRoleEntityUsingRoleIdStatic = new AspnetRolesRelations().NavigationRoleEntityUsingRoleId;
		internal static readonly IEntityRelation NewsCategoryInRoleEntityUsingRoleIdStatic = new AspnetRolesRelations().NewsCategoryInRoleEntityUsingRoleId;
		internal static readonly IEntityRelation NewsletterRoleEntityUsingRoleIdStatic = new AspnetRolesRelations().NewsletterRoleEntityUsingRoleId;
		internal static readonly IEntityRelation PageEditRoleEntityUsingRoleIdStatic = new AspnetRolesRelations().PageEditRoleEntityUsingRoleId;
		internal static readonly IEntityRelation PageRoleEntityUsingRoleIdStatic = new AspnetRolesRelations().PageRoleEntityUsingRoleId;
		internal static readonly IEntityRelation SnDiscussionBoardInRoleEntityUsingRoleIdStatic = new AspnetRolesRelations().SnDiscussionBoardInRoleEntityUsingRoleId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new AspnetRolesRelations().AspnetApplicationsEntityUsingApplicationId;

		/// <summary>CTor</summary>
		static StaticAspnetRolesRelations()
		{
		}
	}
}
