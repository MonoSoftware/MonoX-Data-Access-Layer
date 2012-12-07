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
	/// <summary>Implements the relations factory for the entity: NewsItem. </summary>
	public partial class NewsItemRelations
	{
		/// <summary>CTor</summary>
		public NewsItemRelations()
		{
		}

		/// <summary>Gets all relations of the NewsItemEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.NewsFileEntityUsingNewsItemId);
			toReturn.Add(this.NewsItemLocalizationEntityUsingNewsId);
			toReturn.Add(this.NewsPublishQueueEntityUsingNewsItemId);
			toReturn.Add(this.SnRelationshipEntityUsingNewsItemId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.NewsCategoryEntityUsingNewsCategoryId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between NewsItemEntity and NewsFileEntity over the 1:n relation they have, using the relation between the fields:
		/// NewsItem.Id - NewsFile.NewsItemId
		/// </summary>
		public virtual IEntityRelation NewsFileEntityUsingNewsItemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsFiles" , true);
				relation.AddEntityFieldPair(NewsItemFields.Id, NewsFileFields.NewsItemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsFileEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsItemEntity and NewsItemLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// NewsItem.Id - NewsItemLocalization.NewsId
		/// </summary>
		public virtual IEntityRelation NewsItemLocalizationEntityUsingNewsId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsItemLocalizations" , true);
				relation.AddEntityFieldPair(NewsItemFields.Id, NewsItemLocalizationFields.NewsId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsItemEntity and NewsPublishQueueEntity over the 1:n relation they have, using the relation between the fields:
		/// NewsItem.Id - NewsPublishQueue.NewsItemId
		/// </summary>
		public virtual IEntityRelation NewsPublishQueueEntityUsingNewsItemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "NewsPublishQueues" , true);
				relation.AddEntityFieldPair(NewsItemFields.Id, NewsPublishQueueFields.NewsItemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsPublishQueueEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between NewsItemEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// NewsItem.Id - SnRelationship.NewsItemId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingNewsItemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(NewsItemFields.Id, SnRelationshipFields.NewsItemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between NewsItemEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsItem.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, NewsItemFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NewsItemEntity and NewsCategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsItem.NewsCategoryId - NewsCategory.Id
		/// </summary>
		public virtual IEntityRelation NewsCategoryEntityUsingNewsCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "NewsCategory", false);
				relation.AddEntityFieldPair(NewsCategoryFields.Id, NewsItemFields.NewsCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemEntity", true);
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
	internal static class StaticNewsItemRelations
	{
		internal static readonly IEntityRelation NewsFileEntityUsingNewsItemIdStatic = new NewsItemRelations().NewsFileEntityUsingNewsItemId;
		internal static readonly IEntityRelation NewsItemLocalizationEntityUsingNewsIdStatic = new NewsItemRelations().NewsItemLocalizationEntityUsingNewsId;
		internal static readonly IEntityRelation NewsPublishQueueEntityUsingNewsItemIdStatic = new NewsItemRelations().NewsPublishQueueEntityUsingNewsItemId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingNewsItemIdStatic = new NewsItemRelations().SnRelationshipEntityUsingNewsItemId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new NewsItemRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation NewsCategoryEntityUsingNewsCategoryIdStatic = new NewsItemRelations().NewsCategoryEntityUsingNewsCategoryId;

		/// <summary>CTor</summary>
		static StaticNewsItemRelations()
		{
		}
	}
}
