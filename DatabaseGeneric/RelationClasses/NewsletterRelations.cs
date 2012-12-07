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
	/// <summary>Implements the relations factory for the entity: Newsletter. </summary>
	public partial class NewsletterRelations
	{
		/// <summary>CTor</summary>
		public NewsletterRelations()
		{
		}

		/// <summary>Gets all relations of the NewsletterEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.NewsletterLogEntityUsingNewsletterId);
			toReturn.Add(this.NewsletterRoleEntityUsingNewsletterId);
			toReturn.Add(this.SnRelationshipEntityUsingNewsletterId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between NewsletterEntity and NewsletterLogEntity over the 1:n relation they have, using the relation between the fields:
		/// Newsletter.Id - NewsletterLog.NewsletterId
		/// </summary>
		public virtual IEntityRelation NewsletterLogEntityUsingNewsletterId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsletterLogs" , true);
				relation.AddEntityFieldPair(NewsletterFields.Id, NewsletterLogFields.NewsletterId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsletterEntity and NewsletterRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// Newsletter.Id - NewsletterRole.NewsletterId
		/// </summary>
		public virtual IEntityRelation NewsletterRoleEntityUsingNewsletterId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsletterRoles" , true);
				relation.AddEntityFieldPair(NewsletterFields.Id, NewsletterRoleFields.NewsletterId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsletterEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// Newsletter.Id - SnRelationship.NewsletterId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingNewsletterId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationshipss" , true);
				relation.AddEntityFieldPair(NewsletterFields.Id, SnRelationshipFields.NewsletterId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between NewsletterEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// Newsletter.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplication", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, NewsletterFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NewsletterEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// Newsletter.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, NewsletterFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NewsletterEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// Newsletter.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, NewsletterFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", true);
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
	internal static class StaticNewsletterRelations
	{
		internal static readonly IEntityRelation NewsletterLogEntityUsingNewsletterIdStatic = new NewsletterRelations().NewsletterLogEntityUsingNewsletterId;
		internal static readonly IEntityRelation NewsletterRoleEntityUsingNewsletterIdStatic = new NewsletterRelations().NewsletterRoleEntityUsingNewsletterId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingNewsletterIdStatic = new NewsletterRelations().SnRelationshipEntityUsingNewsletterId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new NewsletterRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new NewsletterRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new NewsletterRelations().LanguageEntityUsingLanguageId;

		/// <summary>CTor</summary>
		static StaticNewsletterRelations()
		{
		}
	}
}
