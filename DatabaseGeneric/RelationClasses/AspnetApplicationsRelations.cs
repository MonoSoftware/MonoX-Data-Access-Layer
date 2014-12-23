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
	/// <summary>Implements the relations factory for the entity: AspnetApplications. </summary>
	public partial class AspnetApplicationsRelations
	{
		/// <summary>CTor</summary>
		public AspnetApplicationsRelations()
		{
		}

		/// <summary>Gets all relations of the AspnetApplicationsEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetMembershipEntityUsingApplicationId);
			toReturn.Add(this.AspnetPathsEntityUsingApplicationId);
			toReturn.Add(this.AspnetRolesEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingApplicationId);
			toReturn.Add(this.BlogEntityUsingApplicationId);
			toReturn.Add(this.CampaignEntityUsingApplicationId);
			toReturn.Add(this.ListEntityUsingApplicationId);
			toReturn.Add(this.NavigationEntityUsingApplicationId);
			toReturn.Add(this.NewsCategoryEntityUsingApplicationId);
			toReturn.Add(this.NewsletterEntityUsingApplicationId);
			toReturn.Add(this.PageEntityUsingApplicationId);
			toReturn.Add(this.PollEntityUsingApplicationId);
			toReturn.Add(this.SnAlbumEntityUsingApplicationId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingApplicationId);
			toReturn.Add(this.SnGroupCategoryEntityUsingApplicationId);
			toReturn.Add(this.SnNoteEntityUsingApplicationId);
			toReturn.Add(this.SnRelationshipEntityUsingApplicationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and AspnetMembershipEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - AspnetMembership.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetMembershipEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, AspnetMembershipFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetMembershipEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and AspnetPathsEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - AspnetPaths.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetPathsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, AspnetPathsFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPathsEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and AspnetRolesEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - AspnetRoles.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetRolesEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, AspnetRolesFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and AspnetUsersEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - AspnetUsers.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, AspnetUsersFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and BlogEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - Blog.ApplicationId
		/// </summary>
		public virtual IEntityRelation BlogEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, BlogFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and CampaignEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - Campaign.ApplicationId
		/// </summary>
		public virtual IEntityRelation CampaignEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, CampaignFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and ListEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - List.ApplicationId
		/// </summary>
		public virtual IEntityRelation ListEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, ListFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and NavigationEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - Navigation.ApplicationId
		/// </summary>
		public virtual IEntityRelation NavigationEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, NavigationFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and NewsCategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - NewsCategory.ApplicationId
		/// </summary>
		public virtual IEntityRelation NewsCategoryEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, NewsCategoryFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and NewsletterEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - Newsletter.ApplicationId
		/// </summary>
		public virtual IEntityRelation NewsletterEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, NewsletterFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and PageEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - Page.ApplicationId
		/// </summary>
		public virtual IEntityRelation PageEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, PageFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and PollEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - Poll.ApplicationId
		/// </summary>
		public virtual IEntityRelation PollEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, PollFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and SnAlbumEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - SnAlbum.ApplicationId
		/// </summary>
		public virtual IEntityRelation SnAlbumEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnAlbumFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and SnDiscussionBoardEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - SnDiscussionBoard.ApplicationId
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnDiscussionBoardFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and SnGroupCategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - SnGroupCategory.ApplicationId
		/// </summary>
		public virtual IEntityRelation SnGroupCategoryEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnGroupCategoryFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupCategoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and SnNoteEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - SnNote.ApplicationId
		/// </summary>
		public virtual IEntityRelation SnNoteEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnNoteFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetApplicationsEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetApplications.ApplicationId - SnRelationship.ApplicationId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, SnRelationshipFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
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
	internal static class StaticAspnetApplicationsRelations
	{
		internal static readonly IEntityRelation AspnetMembershipEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().AspnetMembershipEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetPathsEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().AspnetPathsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetRolesEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().AspnetRolesEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().AspnetUsersEntityUsingApplicationId;
		internal static readonly IEntityRelation BlogEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().BlogEntityUsingApplicationId;
		internal static readonly IEntityRelation CampaignEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().CampaignEntityUsingApplicationId;
		internal static readonly IEntityRelation ListEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().ListEntityUsingApplicationId;
		internal static readonly IEntityRelation NavigationEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().NavigationEntityUsingApplicationId;
		internal static readonly IEntityRelation NewsCategoryEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().NewsCategoryEntityUsingApplicationId;
		internal static readonly IEntityRelation NewsletterEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().NewsletterEntityUsingApplicationId;
		internal static readonly IEntityRelation PageEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().PageEntityUsingApplicationId;
		internal static readonly IEntityRelation PollEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().PollEntityUsingApplicationId;
		internal static readonly IEntityRelation SnAlbumEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().SnAlbumEntityUsingApplicationId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().SnDiscussionBoardEntityUsingApplicationId;
		internal static readonly IEntityRelation SnGroupCategoryEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().SnGroupCategoryEntityUsingApplicationId;
		internal static readonly IEntityRelation SnNoteEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().SnNoteEntityUsingApplicationId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingApplicationIdStatic = new AspnetApplicationsRelations().SnRelationshipEntityUsingApplicationId;

		/// <summary>CTor</summary>
		static StaticAspnetApplicationsRelations()
		{
		}
	}
}
