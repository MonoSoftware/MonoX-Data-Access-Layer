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
	/// <summary>Implements the relations factory for the entity: Page. </summary>
	public partial class PageRelations
	{
		/// <summary>CTor</summary>
		public PageRelations()
		{
		}

		/// <summary>Gets all relations of the PageEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AdPageEntityUsingPageId);
			toReturn.Add(this.DocumentEntityUsingPageId);
			toReturn.Add(this.NavigationEntityUsingPageId);
			toReturn.Add(this.PageEditRoleEntityUsingPageId);
			toReturn.Add(this.PageLocalizationEntityUsingPageId);
			toReturn.Add(this.PageRoleEntityUsingPageId);
			toReturn.Add(this.SnRelationshipEntityUsingPageId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PageEntity and AdPageEntity over the 1:n relation they have, using the relation between the fields:
		/// Page.Id - AdPage.PageId
		/// </summary>
		public virtual IEntityRelation AdPageEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AdPage" , true);
				relation.AddEntityFieldPair(PageFields.Id, AdPageFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdPageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PageEntity and DocumentEntity over the 1:n relation they have, using the relation between the fields:
		/// Page.Id - Document.PageId
		/// </summary>
		public virtual IEntityRelation DocumentEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Documents" , true);
				relation.AddEntityFieldPair(PageFields.Id, DocumentFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PageEntity and NavigationEntity over the 1:n relation they have, using the relation between the fields:
		/// Page.Id - Navigation.PageId
		/// </summary>
		public virtual IEntityRelation NavigationEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NavigationItems" , true);
				relation.AddEntityFieldPair(PageFields.Id, NavigationFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PageEntity and PageEditRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// Page.Id - PageEditRole.PageId
		/// </summary>
		public virtual IEntityRelation PageEditRoleEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PageEditRoles" , true);
				relation.AddEntityFieldPair(PageFields.Id, PageEditRoleFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEditRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PageEntity and PageLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Page.Id - PageLocalization.PageId
		/// </summary>
		public virtual IEntityRelation PageLocalizationEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PageLocalizations" , true);
				relation.AddEntityFieldPair(PageFields.Id, PageLocalizationFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PageEntity and PageRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// Page.Id - PageRole.PageId
		/// </summary>
		public virtual IEntityRelation PageRoleEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PageRoles" , true);
				relation.AddEntityFieldPair(PageFields.Id, PageRoleFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PageEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// Page.Id - SnRelationship.PageId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingPageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationshipss" , true);
				relation.AddEntityFieldPair(PageFields.Id, SnRelationshipFields.PageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PageEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// Page.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplications", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, PageFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PageEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// Page.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, PageFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", true);
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
	internal static class StaticPageRelations
	{
		internal static readonly IEntityRelation AdPageEntityUsingPageIdStatic = new PageRelations().AdPageEntityUsingPageId;
		internal static readonly IEntityRelation DocumentEntityUsingPageIdStatic = new PageRelations().DocumentEntityUsingPageId;
		internal static readonly IEntityRelation NavigationEntityUsingPageIdStatic = new PageRelations().NavigationEntityUsingPageId;
		internal static readonly IEntityRelation PageEditRoleEntityUsingPageIdStatic = new PageRelations().PageEditRoleEntityUsingPageId;
		internal static readonly IEntityRelation PageLocalizationEntityUsingPageIdStatic = new PageRelations().PageLocalizationEntityUsingPageId;
		internal static readonly IEntityRelation PageRoleEntityUsingPageIdStatic = new PageRelations().PageRoleEntityUsingPageId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingPageIdStatic = new PageRelations().SnRelationshipEntityUsingPageId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new PageRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new PageRelations().AspnetUsersEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticPageRelations()
		{
		}
	}
}
