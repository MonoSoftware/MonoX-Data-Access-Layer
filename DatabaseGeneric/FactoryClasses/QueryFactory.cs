///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using MonoSoftware.MonoX.DAL.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace MonoSoftware.MonoX.DAL.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}

		/// <summary>Creates a new DynamicQuery which wraps the specified TableValuedFunction call</summary>
		/// <param name="toWrap">The table valued function call to wrap.</param>
		/// <returns>toWrap wrapped in a DynamicQuery.</returns>
		public DynamicQuery Create(TableValuedFunctionCall toWrap)
		{
			return this.Create().From(new TvfCallWrapper(toWrap)).Select(toWrap.GetFieldsAsArray().Select(f => this.Field(toWrap.Alias, f.Alias)).ToArray());
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField2(fieldName, targetAlias, typeof(TValue));
		}
		
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		

		/// <summary>Creates and returns a new EntityQuery for the Ad entity</summary>
		public EntityQuery<AdEntity> Ad
		{
			get { return Create<AdEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AdPage entity</summary>
		public EntityQuery<AdPageEntity> AdPage
		{
			get { return Create<AdPageEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetApplications entity</summary>
		public EntityQuery<AspnetApplicationsEntity> AspnetApplications
		{
			get { return Create<AspnetApplicationsEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetMembership entity</summary>
		public EntityQuery<AspnetMembershipEntity> AspnetMembership
		{
			get { return Create<AspnetMembershipEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetPaths entity</summary>
		public EntityQuery<AspnetPathsEntity> AspnetPaths
		{
			get { return Create<AspnetPathsEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetPersonalizationAllUsers entity</summary>
		public EntityQuery<AspnetPersonalizationAllUsersEntity> AspnetPersonalizationAllUsers
		{
			get { return Create<AspnetPersonalizationAllUsersEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetPersonalizationPerUser entity</summary>
		public EntityQuery<AspnetPersonalizationPerUserEntity> AspnetPersonalizationPerUser
		{
			get { return Create<AspnetPersonalizationPerUserEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetProfile entity</summary>
		public EntityQuery<AspnetProfileEntity> AspnetProfile
		{
			get { return Create<AspnetProfileEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetRoles entity</summary>
		public EntityQuery<AspnetRolesEntity> AspnetRoles
		{
			get { return Create<AspnetRolesEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetSchemaVersions entity</summary>
		public EntityQuery<AspnetSchemaVersionsEntity> AspnetSchemaVersions
		{
			get { return Create<AspnetSchemaVersionsEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetUsers entity</summary>
		public EntityQuery<AspnetUsersEntity> AspnetUsers
		{
			get { return Create<AspnetUsersEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetUsersInRoles entity</summary>
		public EntityQuery<AspnetUsersInRolesEntity> AspnetUsersInRoles
		{
			get { return Create<AspnetUsersInRolesEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AspnetWebEventEvents entity</summary>
		public EntityQuery<AspnetWebEventEventsEntity> AspnetWebEventEvents
		{
			get { return Create<AspnetWebEventEventsEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AuditInfo entity</summary>
		public EntityQuery<AuditInfoEntity> AuditInfo
		{
			get { return Create<AuditInfoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Blog entity</summary>
		public EntityQuery<BlogEntity> Blog
		{
			get { return Create<BlogEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BlogCategory entity</summary>
		public EntityQuery<BlogCategoryEntity> BlogCategory
		{
			get { return Create<BlogCategoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BlogEditor entity</summary>
		public EntityQuery<BlogEditorEntity> BlogEditor
		{
			get { return Create<BlogEditorEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BlogPost entity</summary>
		public EntityQuery<BlogPostEntity> BlogPost
		{
			get { return Create<BlogPostEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BlogPostCategory entity</summary>
		public EntityQuery<BlogPostCategoryEntity> BlogPostCategory
		{
			get { return Create<BlogPostCategoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BlogPostRole entity</summary>
		public EntityQuery<BlogPostRoleEntity> BlogPostRole
		{
			get { return Create<BlogPostRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Calendar entity</summary>
		public EntityQuery<CalendarEntity> Calendar
		{
			get { return Create<CalendarEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CalendarEditRole entity</summary>
		public EntityQuery<CalendarEditRoleEntity> CalendarEditRole
		{
			get { return Create<CalendarEditRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CalendarEvent entity</summary>
		public EntityQuery<CalendarEventEntity> CalendarEvent
		{
			get { return Create<CalendarEventEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CalendarEventEntry entity</summary>
		public EntityQuery<CalendarEventEntryEntity> CalendarEventEntry
		{
			get { return Create<CalendarEventEntryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CalendarEventRecurringDefinition entity</summary>
		public EntityQuery<CalendarEventRecurringDefinitionEntity> CalendarEventRecurringDefinition
		{
			get { return Create<CalendarEventRecurringDefinitionEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CalendarEventRecurringDefinitionType entity</summary>
		public EntityQuery<CalendarEventRecurringDefinitionTypeEntity> CalendarEventRecurringDefinitionType
		{
			get { return Create<CalendarEventRecurringDefinitionTypeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CalendarModerator entity</summary>
		public EntityQuery<CalendarModeratorEntity> CalendarModerator
		{
			get { return Create<CalendarModeratorEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CalendarViewRole entity</summary>
		public EntityQuery<CalendarViewRoleEntity> CalendarViewRole
		{
			get { return Create<CalendarViewRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Campaign entity</summary>
		public EntityQuery<CampaignEntity> Campaign
		{
			get { return Create<CampaignEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Document entity</summary>
		public EntityQuery<DocumentEntity> Document
		{
			get { return Create<DocumentEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the FriendSuggestionTypedViewEntry entity</summary>
		public EntityQuery<FriendSuggestionTypedViewEntryEntity> FriendSuggestionTypedViewEntry
		{
			get { return Create<FriendSuggestionTypedViewEntryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Language entity</summary>
		public EntityQuery<LanguageEntity> Language
		{
			get { return Create<LanguageEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the List entity</summary>
		public EntityQuery<ListEntity> List
		{
			get { return Create<ListEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ListItem entity</summary>
		public EntityQuery<ListItemEntity> ListItem
		{
			get { return Create<ListItemEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ListItemLocalization entity</summary>
		public EntityQuery<ListItemLocalizationEntity> ListItemLocalization
		{
			get { return Create<ListItemLocalizationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LocalizationBinary entity</summary>
		public EntityQuery<LocalizationBinaryEntity> LocalizationBinary
		{
			get { return Create<LocalizationBinaryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LocalizationSource entity</summary>
		public EntityQuery<LocalizationSourceEntity> LocalizationSource
		{
			get { return Create<LocalizationSourceEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LocalizationString entity</summary>
		public EntityQuery<LocalizationStringEntity> LocalizationString
		{
			get { return Create<LocalizationStringEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Navigation entity</summary>
		public EntityQuery<NavigationEntity> Navigation
		{
			get { return Create<NavigationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NavigationLocalization entity</summary>
		public EntityQuery<NavigationLocalizationEntity> NavigationLocalization
		{
			get { return Create<NavigationLocalizationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NavigationRole entity</summary>
		public EntityQuery<NavigationRoleEntity> NavigationRole
		{
			get { return Create<NavigationRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsCategory entity</summary>
		public EntityQuery<NewsCategoryEntity> NewsCategory
		{
			get { return Create<NewsCategoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsCategoryInRole entity</summary>
		public EntityQuery<NewsCategoryInRoleEntity> NewsCategoryInRole
		{
			get { return Create<NewsCategoryInRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsCategoryLocalization entity</summary>
		public EntityQuery<NewsCategoryLocalizationEntity> NewsCategoryLocalization
		{
			get { return Create<NewsCategoryLocalizationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsCategoryTemplate entity</summary>
		public EntityQuery<NewsCategoryTemplateEntity> NewsCategoryTemplate
		{
			get { return Create<NewsCategoryTemplateEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsFile entity</summary>
		public EntityQuery<NewsFileEntity> NewsFile
		{
			get { return Create<NewsFileEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsItem entity</summary>
		public EntityQuery<NewsItemEntity> NewsItem
		{
			get { return Create<NewsItemEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsItemLocalization entity</summary>
		public EntityQuery<NewsItemLocalizationEntity> NewsItemLocalization
		{
			get { return Create<NewsItemLocalizationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Newsletter entity</summary>
		public EntityQuery<NewsletterEntity> Newsletter
		{
			get { return Create<NewsletterEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsletterLog entity</summary>
		public EntityQuery<NewsletterLogEntity> NewsletterLog
		{
			get { return Create<NewsletterLogEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsletterRole entity</summary>
		public EntityQuery<NewsletterRoleEntity> NewsletterRole
		{
			get { return Create<NewsletterRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsMetaIgnoredWord entity</summary>
		public EntityQuery<NewsMetaIgnoredWordEntity> NewsMetaIgnoredWord
		{
			get { return Create<NewsMetaIgnoredWordEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the NewsPublishQueue entity</summary>
		public EntityQuery<NewsPublishQueueEntity> NewsPublishQueue
		{
			get { return Create<NewsPublishQueueEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the OaConsumer entity</summary>
		public EntityQuery<OaConsumerEntity> OaConsumer
		{
			get { return Create<OaConsumerEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the OaToken entity</summary>
		public EntityQuery<OaTokenEntity> OaToken
		{
			get { return Create<OaTokenEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Page entity</summary>
		public EntityQuery<PageEntity> Page
		{
			get { return Create<PageEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PageEditRole entity</summary>
		public EntityQuery<PageEditRoleEntity> PageEditRole
		{
			get { return Create<PageEditRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PageLocalization entity</summary>
		public EntityQuery<PageLocalizationEntity> PageLocalization
		{
			get { return Create<PageLocalizationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PageRole entity</summary>
		public EntityQuery<PageRoleEntity> PageRole
		{
			get { return Create<PageRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Poll entity</summary>
		public EntityQuery<PollEntity> Poll
		{
			get { return Create<PollEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PollAnswer entity</summary>
		public EntityQuery<PollAnswerEntity> PollAnswer
		{
			get { return Create<PollAnswerEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PollAnswerLocalization entity</summary>
		public EntityQuery<PollAnswerLocalizationEntity> PollAnswerLocalization
		{
			get { return Create<PollAnswerLocalizationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PollLocalization entity</summary>
		public EntityQuery<PollLocalizationEntity> PollLocalization
		{
			get { return Create<PollLocalizationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PrivacyLevel entity</summary>
		public EntityQuery<PrivacyLevelEntity> PrivacyLevel
		{
			get { return Create<PrivacyLevelEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PrivacyLevelDefinition entity</summary>
		public EntityQuery<PrivacyLevelDefinitionEntity> PrivacyLevelDefinition
		{
			get { return Create<PrivacyLevelDefinitionEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnAlbum entity</summary>
		public EntityQuery<SnAlbumEntity> SnAlbum
		{
			get { return Create<SnAlbumEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnBlockUser entity</summary>
		public EntityQuery<SnBlockUserEntity> SnBlockUser
		{
			get { return Create<SnBlockUserEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnComment entity</summary>
		public EntityQuery<SnCommentEntity> SnComment
		{
			get { return Create<SnCommentEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnDiscussionBoard entity</summary>
		public EntityQuery<SnDiscussionBoardEntity> SnDiscussionBoard
		{
			get { return Create<SnDiscussionBoardEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnDiscussionBoardInRole entity</summary>
		public EntityQuery<SnDiscussionBoardInRoleEntity> SnDiscussionBoardInRole
		{
			get { return Create<SnDiscussionBoardInRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnDiscussionBoardModerator entity</summary>
		public EntityQuery<SnDiscussionBoardModeratorEntity> SnDiscussionBoardModerator
		{
			get { return Create<SnDiscussionBoardModeratorEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnDiscussionMessage entity</summary>
		public EntityQuery<SnDiscussionMessageEntity> SnDiscussionMessage
		{
			get { return Create<SnDiscussionMessageEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnDiscussionTopic entity</summary>
		public EntityQuery<SnDiscussionTopicEntity> SnDiscussionTopic
		{
			get { return Create<SnDiscussionTopicEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnEvent entity</summary>
		public EntityQuery<SnEventEntity> SnEvent
		{
			get { return Create<SnEventEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnEventType entity</summary>
		public EntityQuery<SnEventTypeEntity> SnEventType
		{
			get { return Create<SnEventTypeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnFile entity</summary>
		public EntityQuery<SnFileEntity> SnFile
		{
			get { return Create<SnFileEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnFriend entity</summary>
		public EntityQuery<SnFriendEntity> SnFriend
		{
			get { return Create<SnFriendEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnFriendList entity</summary>
		public EntityQuery<SnFriendListEntity> SnFriendList
		{
			get { return Create<SnFriendListEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnFriendListMember entity</summary>
		public EntityQuery<SnFriendListMemberEntity> SnFriendListMember
		{
			get { return Create<SnFriendListMemberEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnFriendRequest entity</summary>
		public EntityQuery<SnFriendRequestEntity> SnFriendRequest
		{
			get { return Create<SnFriendRequestEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnGroup entity</summary>
		public EntityQuery<SnGroupEntity> SnGroup
		{
			get { return Create<SnGroupEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnGroupCategory entity</summary>
		public EntityQuery<SnGroupCategoryEntity> SnGroupCategory
		{
			get { return Create<SnGroupCategoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnGroupMember entity</summary>
		public EntityQuery<SnGroupMemberEntity> SnGroupMember
		{
			get { return Create<SnGroupMemberEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnGroupRequest entity</summary>
		public EntityQuery<SnGroupRequestEntity> SnGroupRequest
		{
			get { return Create<SnGroupRequestEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnMessage entity</summary>
		public EntityQuery<SnMessageEntity> SnMessage
		{
			get { return Create<SnMessageEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnMessageRecipient entity</summary>
		public EntityQuery<SnMessageRecipientEntity> SnMessageRecipient
		{
			get { return Create<SnMessageRecipientEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnNote entity</summary>
		public EntityQuery<SnNoteEntity> SnNote
		{
			get { return Create<SnNoteEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnRating entity</summary>
		public EntityQuery<SnRatingEntity> SnRating
		{
			get { return Create<SnRatingEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnRelationship entity</summary>
		public EntityQuery<SnRelationshipEntity> SnRelationship
		{
			get { return Create<SnRelationshipEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnSubscriber entity</summary>
		public EntityQuery<SnSubscriberEntity> SnSubscriber
		{
			get { return Create<SnSubscriberEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SnTag entity</summary>
		public EntityQuery<SnTagEntity> SnTag
		{
			get { return Create<SnTagEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the TermsAndConditions entity</summary>
		public EntityQuery<TermsAndConditionsEntity> TermsAndConditions
		{
			get { return Create<TermsAndConditionsEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the UserAvatar entity</summary>
		public EntityQuery<UserAvatarEntity> UserAvatar
		{
			get { return Create<UserAvatarEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the UserProfile entity</summary>
		public EntityQuery<UserProfileEntity> UserProfile
		{
			get { return Create<UserProfileEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the UserSocialIdentity entity</summary>
		public EntityQuery<UserSocialIdentityEntity> UserSocialIdentity
		{
			get { return Create<UserSocialIdentityEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Version entity</summary>
		public EntityQuery<VersionEntity> Version
		{
			get { return Create<VersionEntity>(); }
		}

 

	}
}