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
	/// <summary>Implements the relations factory for the entity: Language. </summary>
	public partial class LanguageRelations
	{
		/// <summary>CTor</summary>
		public LanguageRelations()
		{
		}

		/// <summary>Gets all relations of the LanguageEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AdPageEntityUsingLanguageId);
			toReturn.Add(this.BlogEntityUsingLanguageId);
			toReturn.Add(this.DocumentEntityUsingLanguageId);
			toReturn.Add(this.ListItemLocalizationEntityUsingLanguageId);
			toReturn.Add(this.LocalizationSourceEntityUsingLanguageId);
			toReturn.Add(this.NavigationLocalizationEntityUsingLanguageId);
			toReturn.Add(this.NewsCategoryLocalizationEntityUsingLanguageId);
			toReturn.Add(this.NewsItemLocalizationEntityUsingLanguageId);
			toReturn.Add(this.NewsletterEntityUsingLanguageId);
			toReturn.Add(this.NewsMetaIgnoredWordEntityUsingLanguageId);
			toReturn.Add(this.PageLocalizationEntityUsingLanguageId);
			toReturn.Add(this.PollAnswerLocalizationEntityUsingLanguageId);
			toReturn.Add(this.PollLocalizationEntityUsingLanguageId);
			toReturn.Add(this.SnAlbumEntityUsingLanguageId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingLanguageId);
			toReturn.Add(this.SnGroupCategoryEntityUsingLanguageId);
			toReturn.Add(this.SnNoteEntityUsingLanguageId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and AdPageEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - AdPage.LanguageId
		/// </summary>
		public virtual IEntityRelation AdPageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, AdPageFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdPageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and BlogEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - Blog.LanguageId
		/// </summary>
		public virtual IEntityRelation BlogEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, BlogFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BlogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and DocumentEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - Document.LanguageId
		/// </summary>
		public virtual IEntityRelation DocumentEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, DocumentFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and ListItemLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - ListItemLocalization.LanguageId
		/// </summary>
		public virtual IEntityRelation ListItemLocalizationEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, ListItemLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and LocalizationSourceEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - LocalizationSource.LanguageId
		/// </summary>
		public virtual IEntityRelation LocalizationSourceEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, LocalizationSourceFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocalizationSourceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and NavigationLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - NavigationLocalization.LanguageId
		/// </summary>
		public virtual IEntityRelation NavigationLocalizationEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, NavigationLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NavigationLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and NewsCategoryLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - NewsCategoryLocalization.LanguageId
		/// </summary>
		public virtual IEntityRelation NewsCategoryLocalizationEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, NewsCategoryLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsCategoryLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and NewsItemLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - NewsItemLocalization.LanguageId
		/// </summary>
		public virtual IEntityRelation NewsItemLocalizationEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, NewsItemLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsItemLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and NewsletterEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - Newsletter.LanguageId
		/// </summary>
		public virtual IEntityRelation NewsletterEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, NewsletterFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and NewsMetaIgnoredWordEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - NewsMetaIgnoredWord.LanguageId
		/// </summary>
		public virtual IEntityRelation NewsMetaIgnoredWordEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, NewsMetaIgnoredWordFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsMetaIgnoredWordEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and PageLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - PageLocalization.LanguageId
		/// </summary>
		public virtual IEntityRelation PageLocalizationEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, PageLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PageLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and PollAnswerLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - PollAnswerLocalization.LanguageId
		/// </summary>
		public virtual IEntityRelation PollAnswerLocalizationEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, PollAnswerLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollAnswerLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and PollLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - PollLocalization.LanguageId
		/// </summary>
		public virtual IEntityRelation PollLocalizationEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, PollLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and SnAlbumEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - SnAlbum.LanguageId
		/// </summary>
		public virtual IEntityRelation SnAlbumEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, SnAlbumFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnAlbumEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and SnDiscussionBoardEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - SnDiscussionBoard.LanguageId
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, SnDiscussionBoardFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and SnGroupCategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - SnGroupCategory.LanguageId
		/// </summary>
		public virtual IEntityRelation SnGroupCategoryEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, SnGroupCategoryFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnGroupCategoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LanguageEntity and SnNoteEntity over the 1:n relation they have, using the relation between the fields:
		/// Language.Id - SnNote.LanguageId
		/// </summary>
		public virtual IEntityRelation SnNoteEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "" , true);
				relation.AddEntityFieldPair(LanguageFields.Id, SnNoteFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnNoteEntity", false);
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
	internal static class StaticLanguageRelations
	{
		internal static readonly IEntityRelation AdPageEntityUsingLanguageIdStatic = new LanguageRelations().AdPageEntityUsingLanguageId;
		internal static readonly IEntityRelation BlogEntityUsingLanguageIdStatic = new LanguageRelations().BlogEntityUsingLanguageId;
		internal static readonly IEntityRelation DocumentEntityUsingLanguageIdStatic = new LanguageRelations().DocumentEntityUsingLanguageId;
		internal static readonly IEntityRelation ListItemLocalizationEntityUsingLanguageIdStatic = new LanguageRelations().ListItemLocalizationEntityUsingLanguageId;
		internal static readonly IEntityRelation LocalizationSourceEntityUsingLanguageIdStatic = new LanguageRelations().LocalizationSourceEntityUsingLanguageId;
		internal static readonly IEntityRelation NavigationLocalizationEntityUsingLanguageIdStatic = new LanguageRelations().NavigationLocalizationEntityUsingLanguageId;
		internal static readonly IEntityRelation NewsCategoryLocalizationEntityUsingLanguageIdStatic = new LanguageRelations().NewsCategoryLocalizationEntityUsingLanguageId;
		internal static readonly IEntityRelation NewsItemLocalizationEntityUsingLanguageIdStatic = new LanguageRelations().NewsItemLocalizationEntityUsingLanguageId;
		internal static readonly IEntityRelation NewsletterEntityUsingLanguageIdStatic = new LanguageRelations().NewsletterEntityUsingLanguageId;
		internal static readonly IEntityRelation NewsMetaIgnoredWordEntityUsingLanguageIdStatic = new LanguageRelations().NewsMetaIgnoredWordEntityUsingLanguageId;
		internal static readonly IEntityRelation PageLocalizationEntityUsingLanguageIdStatic = new LanguageRelations().PageLocalizationEntityUsingLanguageId;
		internal static readonly IEntityRelation PollAnswerLocalizationEntityUsingLanguageIdStatic = new LanguageRelations().PollAnswerLocalizationEntityUsingLanguageId;
		internal static readonly IEntityRelation PollLocalizationEntityUsingLanguageIdStatic = new LanguageRelations().PollLocalizationEntityUsingLanguageId;
		internal static readonly IEntityRelation SnAlbumEntityUsingLanguageIdStatic = new LanguageRelations().SnAlbumEntityUsingLanguageId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingLanguageIdStatic = new LanguageRelations().SnDiscussionBoardEntityUsingLanguageId;
		internal static readonly IEntityRelation SnGroupCategoryEntityUsingLanguageIdStatic = new LanguageRelations().SnGroupCategoryEntityUsingLanguageId;
		internal static readonly IEntityRelation SnNoteEntityUsingLanguageIdStatic = new LanguageRelations().SnNoteEntityUsingLanguageId;

		/// <summary>CTor</summary>
		static StaticLanguageRelations()
		{
		}
	}
}
