///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET35
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using MonoSoftware.MonoX.DAL;
using MonoSoftware.MonoX.DAL.EntityClasses;
using MonoSoftware.MonoX.DAL.FactoryClasses;
using MonoSoftware.MonoX.DAL.HelperClasses;
using MonoSoftware.MonoX.DAL.RelationClasses;

namespace MonoSoftware.MonoX.DAL.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((MonoSoftware.MonoX.DAL.EntityType)typeOfEntity)
			{
				case MonoSoftware.MonoX.DAL.EntityType.AdEntity:
					toReturn = this.Ad;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AdPageEntity:
					toReturn = this.AdPage;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity:
					toReturn = this.AspnetApplications;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetMembershipEntity:
					toReturn = this.AspnetMembership;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetPathsEntity:
					toReturn = this.AspnetPaths;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetPersonalizationAllUsersEntity:
					toReturn = this.AspnetPersonalizationAllUsers;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetPersonalizationPerUserEntity:
					toReturn = this.AspnetPersonalizationPerUser;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetProfileEntity:
					toReturn = this.AspnetProfile;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetRolesEntity:
					toReturn = this.AspnetRoles;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetSchemaVersionsEntity:
					toReturn = this.AspnetSchemaVersions;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity:
					toReturn = this.AspnetUsers;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetUsersInRolesEntity:
					toReturn = this.AspnetUsersInRoles;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetWebEventEventsEntity:
					toReturn = this.AspnetWebEventEvents;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogEntity:
					toReturn = this.Blog;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogCategoryEntity:
					toReturn = this.BlogCategory;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogEditorEntity:
					toReturn = this.BlogEditor;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogPostEntity:
					toReturn = this.BlogPost;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogPostCategoryEntity:
					toReturn = this.BlogPostCategory;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogPostRoleEntity:
					toReturn = this.BlogPostRole;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEntity:
					toReturn = this.Calendar;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEditRoleEntity:
					toReturn = this.CalendarEditRole;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity:
					toReturn = this.CalendarEvent;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntryEntity:
					toReturn = this.CalendarEventEntry;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionEntity:
					toReturn = this.CalendarEventRecurringDefinition;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionTypeEntity:
					toReturn = this.CalendarEventRecurringDefinitionType;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarModeratorEntity:
					toReturn = this.CalendarModerator;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarViewRoleEntity:
					toReturn = this.CalendarViewRole;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CampaignEntity:
					toReturn = this.Campaign;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.DocumentEntity:
					toReturn = this.Document;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.FriendSuggestionTypedViewEntryEntity:
					toReturn = this.FriendSuggestionTypedViewEntry;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.LanguageEntity:
					toReturn = this.Language;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.ListEntity:
					toReturn = this.List;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.ListItemEntity:
					toReturn = this.ListItem;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.ListItemLocalizationEntity:
					toReturn = this.ListItemLocalization;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.LocalizationBinaryEntity:
					toReturn = this.LocalizationBinary;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.LocalizationSourceEntity:
					toReturn = this.LocalizationSource;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.LocalizationStringEntity:
					toReturn = this.LocalizationString;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NavigationEntity:
					toReturn = this.Navigation;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NavigationLocalizationEntity:
					toReturn = this.NavigationLocalization;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NavigationRoleEntity:
					toReturn = this.NavigationRole;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity:
					toReturn = this.NewsCategory;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsCategoryInRoleEntity:
					toReturn = this.NewsCategoryInRole;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsCategoryLocalizationEntity:
					toReturn = this.NewsCategoryLocalization;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsCategoryTemplateEntity:
					toReturn = this.NewsCategoryTemplate;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsFileEntity:
					toReturn = this.NewsFile;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity:
					toReturn = this.NewsItem;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsItemLocalizationEntity:
					toReturn = this.NewsItemLocalization;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity:
					toReturn = this.Newsletter;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsletterLogEntity:
					toReturn = this.NewsletterLog;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsletterRoleEntity:
					toReturn = this.NewsletterRole;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsMetaIgnoredWordEntity:
					toReturn = this.NewsMetaIgnoredWord;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsPublishQueueEntity:
					toReturn = this.NewsPublishQueue;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.OaConsumerEntity:
					toReturn = this.OaConsumer;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.OaTokenEntity:
					toReturn = this.OaToken;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PageEntity:
					toReturn = this.Page;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PageEditRoleEntity:
					toReturn = this.PageEditRole;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PageLocalizationEntity:
					toReturn = this.PageLocalization;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PageRoleEntity:
					toReturn = this.PageRole;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PollEntity:
					toReturn = this.Poll;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PollAnswerEntity:
					toReturn = this.PollAnswer;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PollAnswerLocalizationEntity:
					toReturn = this.PollAnswerLocalization;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PollLocalizationEntity:
					toReturn = this.PollLocalization;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity:
					toReturn = this.PrivacyLevel;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelDefinitionEntity:
					toReturn = this.PrivacyLevelDefinition;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnAlbumEntity:
					toReturn = this.SnAlbum;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnBlockUserEntity:
					toReturn = this.SnBlockUser;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnCommentEntity:
					toReturn = this.SnComment;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity:
					toReturn = this.SnDiscussionBoard;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardInRoleEntity:
					toReturn = this.SnDiscussionBoardInRole;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardModeratorEntity:
					toReturn = this.SnDiscussionBoardModerator;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity:
					toReturn = this.SnDiscussionMessage;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity:
					toReturn = this.SnDiscussionTopic;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnEventEntity:
					toReturn = this.SnEvent;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnEventTypeEntity:
					toReturn = this.SnEventType;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFileEntity:
					toReturn = this.SnFile;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFriendEntity:
					toReturn = this.SnFriend;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFriendListEntity:
					toReturn = this.SnFriendList;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFriendListMemberEntity:
					toReturn = this.SnFriendListMember;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFriendRequestEntity:
					toReturn = this.SnFriendRequest;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity:
					toReturn = this.SnGroup;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnGroupCategoryEntity:
					toReturn = this.SnGroupCategory;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnGroupMemberEntity:
					toReturn = this.SnGroupMember;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnGroupRequestEntity:
					toReturn = this.SnGroupRequest;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnMessageEntity:
					toReturn = this.SnMessage;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnMessageRecipientEntity:
					toReturn = this.SnMessageRecipient;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnNoteEntity:
					toReturn = this.SnNote;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnRatingEntity:
					toReturn = this.SnRating;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity:
					toReturn = this.SnRelationship;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnSubscriberEntity:
					toReturn = this.SnSubscriber;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnTagEntity:
					toReturn = this.SnTag;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.TermsAndConditionsEntity:
					toReturn = this.TermsAndConditions;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.UserAvatarEntity:
					toReturn = this.UserAvatar;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.UserProfileEntity:
					toReturn = this.UserProfile;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.UserSocialIdentityEntity:
					toReturn = this.UserSocialIdentity;
					break;
				case MonoSoftware.MonoX.DAL.EntityType.VersionEntity:
					toReturn = this.Version;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AdEntity instances in the database.</summary>
		public DataSource2<AdEntity> Ad
		{
			get { return new DataSource2<AdEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AdPageEntity instances in the database.</summary>
		public DataSource2<AdPageEntity> AdPage
		{
			get { return new DataSource2<AdPageEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetApplicationsEntity instances in the database.</summary>
		public DataSource2<AspnetApplicationsEntity> AspnetApplications
		{
			get { return new DataSource2<AspnetApplicationsEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetMembershipEntity instances in the database.</summary>
		public DataSource2<AspnetMembershipEntity> AspnetMembership
		{
			get { return new DataSource2<AspnetMembershipEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetPathsEntity instances in the database.</summary>
		public DataSource2<AspnetPathsEntity> AspnetPaths
		{
			get { return new DataSource2<AspnetPathsEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetPersonalizationAllUsersEntity instances in the database.</summary>
		public DataSource2<AspnetPersonalizationAllUsersEntity> AspnetPersonalizationAllUsers
		{
			get { return new DataSource2<AspnetPersonalizationAllUsersEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetPersonalizationPerUserEntity instances in the database.</summary>
		public DataSource2<AspnetPersonalizationPerUserEntity> AspnetPersonalizationPerUser
		{
			get { return new DataSource2<AspnetPersonalizationPerUserEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetProfileEntity instances in the database.</summary>
		public DataSource2<AspnetProfileEntity> AspnetProfile
		{
			get { return new DataSource2<AspnetProfileEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetRolesEntity instances in the database.</summary>
		public DataSource2<AspnetRolesEntity> AspnetRoles
		{
			get { return new DataSource2<AspnetRolesEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetSchemaVersionsEntity instances in the database.</summary>
		public DataSource2<AspnetSchemaVersionsEntity> AspnetSchemaVersions
		{
			get { return new DataSource2<AspnetSchemaVersionsEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetUsersEntity instances in the database.</summary>
		public DataSource2<AspnetUsersEntity> AspnetUsers
		{
			get { return new DataSource2<AspnetUsersEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetUsersInRolesEntity instances in the database.</summary>
		public DataSource2<AspnetUsersInRolesEntity> AspnetUsersInRoles
		{
			get { return new DataSource2<AspnetUsersInRolesEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AspnetWebEventEventsEntity instances in the database.</summary>
		public DataSource2<AspnetWebEventEventsEntity> AspnetWebEventEvents
		{
			get { return new DataSource2<AspnetWebEventEventsEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BlogEntity instances in the database.</summary>
		public DataSource2<BlogEntity> Blog
		{
			get { return new DataSource2<BlogEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BlogCategoryEntity instances in the database.</summary>
		public DataSource2<BlogCategoryEntity> BlogCategory
		{
			get { return new DataSource2<BlogCategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BlogEditorEntity instances in the database.</summary>
		public DataSource2<BlogEditorEntity> BlogEditor
		{
			get { return new DataSource2<BlogEditorEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BlogPostEntity instances in the database.</summary>
		public DataSource2<BlogPostEntity> BlogPost
		{
			get { return new DataSource2<BlogPostEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BlogPostCategoryEntity instances in the database.</summary>
		public DataSource2<BlogPostCategoryEntity> BlogPostCategory
		{
			get { return new DataSource2<BlogPostCategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BlogPostRoleEntity instances in the database.</summary>
		public DataSource2<BlogPostRoleEntity> BlogPostRole
		{
			get { return new DataSource2<BlogPostRoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CalendarEntity instances in the database.</summary>
		public DataSource2<CalendarEntity> Calendar
		{
			get { return new DataSource2<CalendarEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CalendarEditRoleEntity instances in the database.</summary>
		public DataSource2<CalendarEditRoleEntity> CalendarEditRole
		{
			get { return new DataSource2<CalendarEditRoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CalendarEventEntity instances in the database.</summary>
		public DataSource2<CalendarEventEntity> CalendarEvent
		{
			get { return new DataSource2<CalendarEventEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CalendarEventEntryEntity instances in the database.</summary>
		public DataSource2<CalendarEventEntryEntity> CalendarEventEntry
		{
			get { return new DataSource2<CalendarEventEntryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CalendarEventRecurringDefinitionEntity instances in the database.</summary>
		public DataSource2<CalendarEventRecurringDefinitionEntity> CalendarEventRecurringDefinition
		{
			get { return new DataSource2<CalendarEventRecurringDefinitionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CalendarEventRecurringDefinitionTypeEntity instances in the database.</summary>
		public DataSource2<CalendarEventRecurringDefinitionTypeEntity> CalendarEventRecurringDefinitionType
		{
			get { return new DataSource2<CalendarEventRecurringDefinitionTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CalendarModeratorEntity instances in the database.</summary>
		public DataSource2<CalendarModeratorEntity> CalendarModerator
		{
			get { return new DataSource2<CalendarModeratorEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CalendarViewRoleEntity instances in the database.</summary>
		public DataSource2<CalendarViewRoleEntity> CalendarViewRole
		{
			get { return new DataSource2<CalendarViewRoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CampaignEntity instances in the database.</summary>
		public DataSource2<CampaignEntity> Campaign
		{
			get { return new DataSource2<CampaignEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DocumentEntity instances in the database.</summary>
		public DataSource2<DocumentEntity> Document
		{
			get { return new DataSource2<DocumentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting FriendSuggestionTypedViewEntryEntity instances in the database.</summary>
		public DataSource2<FriendSuggestionTypedViewEntryEntity> FriendSuggestionTypedViewEntry
		{
			get { return new DataSource2<FriendSuggestionTypedViewEntryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting LanguageEntity instances in the database.</summary>
		public DataSource2<LanguageEntity> Language
		{
			get { return new DataSource2<LanguageEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ListEntity instances in the database.</summary>
		public DataSource2<ListEntity> List
		{
			get { return new DataSource2<ListEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ListItemEntity instances in the database.</summary>
		public DataSource2<ListItemEntity> ListItem
		{
			get { return new DataSource2<ListItemEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ListItemLocalizationEntity instances in the database.</summary>
		public DataSource2<ListItemLocalizationEntity> ListItemLocalization
		{
			get { return new DataSource2<ListItemLocalizationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting LocalizationBinaryEntity instances in the database.</summary>
		public DataSource2<LocalizationBinaryEntity> LocalizationBinary
		{
			get { return new DataSource2<LocalizationBinaryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting LocalizationSourceEntity instances in the database.</summary>
		public DataSource2<LocalizationSourceEntity> LocalizationSource
		{
			get { return new DataSource2<LocalizationSourceEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting LocalizationStringEntity instances in the database.</summary>
		public DataSource2<LocalizationStringEntity> LocalizationString
		{
			get { return new DataSource2<LocalizationStringEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NavigationEntity instances in the database.</summary>
		public DataSource2<NavigationEntity> Navigation
		{
			get { return new DataSource2<NavigationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NavigationLocalizationEntity instances in the database.</summary>
		public DataSource2<NavigationLocalizationEntity> NavigationLocalization
		{
			get { return new DataSource2<NavigationLocalizationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NavigationRoleEntity instances in the database.</summary>
		public DataSource2<NavigationRoleEntity> NavigationRole
		{
			get { return new DataSource2<NavigationRoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsCategoryEntity instances in the database.</summary>
		public DataSource2<NewsCategoryEntity> NewsCategory
		{
			get { return new DataSource2<NewsCategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsCategoryInRoleEntity instances in the database.</summary>
		public DataSource2<NewsCategoryInRoleEntity> NewsCategoryInRole
		{
			get { return new DataSource2<NewsCategoryInRoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsCategoryLocalizationEntity instances in the database.</summary>
		public DataSource2<NewsCategoryLocalizationEntity> NewsCategoryLocalization
		{
			get { return new DataSource2<NewsCategoryLocalizationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsCategoryTemplateEntity instances in the database.</summary>
		public DataSource2<NewsCategoryTemplateEntity> NewsCategoryTemplate
		{
			get { return new DataSource2<NewsCategoryTemplateEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsFileEntity instances in the database.</summary>
		public DataSource2<NewsFileEntity> NewsFile
		{
			get { return new DataSource2<NewsFileEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsItemEntity instances in the database.</summary>
		public DataSource2<NewsItemEntity> NewsItem
		{
			get { return new DataSource2<NewsItemEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsItemLocalizationEntity instances in the database.</summary>
		public DataSource2<NewsItemLocalizationEntity> NewsItemLocalization
		{
			get { return new DataSource2<NewsItemLocalizationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsletterEntity instances in the database.</summary>
		public DataSource2<NewsletterEntity> Newsletter
		{
			get { return new DataSource2<NewsletterEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsletterLogEntity instances in the database.</summary>
		public DataSource2<NewsletterLogEntity> NewsletterLog
		{
			get { return new DataSource2<NewsletterLogEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsletterRoleEntity instances in the database.</summary>
		public DataSource2<NewsletterRoleEntity> NewsletterRole
		{
			get { return new DataSource2<NewsletterRoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsMetaIgnoredWordEntity instances in the database.</summary>
		public DataSource2<NewsMetaIgnoredWordEntity> NewsMetaIgnoredWord
		{
			get { return new DataSource2<NewsMetaIgnoredWordEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NewsPublishQueueEntity instances in the database.</summary>
		public DataSource2<NewsPublishQueueEntity> NewsPublishQueue
		{
			get { return new DataSource2<NewsPublishQueueEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OaConsumerEntity instances in the database.</summary>
		public DataSource2<OaConsumerEntity> OaConsumer
		{
			get { return new DataSource2<OaConsumerEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OaTokenEntity instances in the database.</summary>
		public DataSource2<OaTokenEntity> OaToken
		{
			get { return new DataSource2<OaTokenEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PageEntity instances in the database.</summary>
		public DataSource2<PageEntity> Page
		{
			get { return new DataSource2<PageEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PageEditRoleEntity instances in the database.</summary>
		public DataSource2<PageEditRoleEntity> PageEditRole
		{
			get { return new DataSource2<PageEditRoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PageLocalizationEntity instances in the database.</summary>
		public DataSource2<PageLocalizationEntity> PageLocalization
		{
			get { return new DataSource2<PageLocalizationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PageRoleEntity instances in the database.</summary>
		public DataSource2<PageRoleEntity> PageRole
		{
			get { return new DataSource2<PageRoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PollEntity instances in the database.</summary>
		public DataSource2<PollEntity> Poll
		{
			get { return new DataSource2<PollEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PollAnswerEntity instances in the database.</summary>
		public DataSource2<PollAnswerEntity> PollAnswer
		{
			get { return new DataSource2<PollAnswerEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PollAnswerLocalizationEntity instances in the database.</summary>
		public DataSource2<PollAnswerLocalizationEntity> PollAnswerLocalization
		{
			get { return new DataSource2<PollAnswerLocalizationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PollLocalizationEntity instances in the database.</summary>
		public DataSource2<PollLocalizationEntity> PollLocalization
		{
			get { return new DataSource2<PollLocalizationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PrivacyLevelEntity instances in the database.</summary>
		public DataSource2<PrivacyLevelEntity> PrivacyLevel
		{
			get { return new DataSource2<PrivacyLevelEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PrivacyLevelDefinitionEntity instances in the database.</summary>
		public DataSource2<PrivacyLevelDefinitionEntity> PrivacyLevelDefinition
		{
			get { return new DataSource2<PrivacyLevelDefinitionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnAlbumEntity instances in the database.</summary>
		public DataSource2<SnAlbumEntity> SnAlbum
		{
			get { return new DataSource2<SnAlbumEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnBlockUserEntity instances in the database.</summary>
		public DataSource2<SnBlockUserEntity> SnBlockUser
		{
			get { return new DataSource2<SnBlockUserEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnCommentEntity instances in the database.</summary>
		public DataSource2<SnCommentEntity> SnComment
		{
			get { return new DataSource2<SnCommentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnDiscussionBoardEntity instances in the database.</summary>
		public DataSource2<SnDiscussionBoardEntity> SnDiscussionBoard
		{
			get { return new DataSource2<SnDiscussionBoardEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnDiscussionBoardInRoleEntity instances in the database.</summary>
		public DataSource2<SnDiscussionBoardInRoleEntity> SnDiscussionBoardInRole
		{
			get { return new DataSource2<SnDiscussionBoardInRoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnDiscussionBoardModeratorEntity instances in the database.</summary>
		public DataSource2<SnDiscussionBoardModeratorEntity> SnDiscussionBoardModerator
		{
			get { return new DataSource2<SnDiscussionBoardModeratorEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnDiscussionMessageEntity instances in the database.</summary>
		public DataSource2<SnDiscussionMessageEntity> SnDiscussionMessage
		{
			get { return new DataSource2<SnDiscussionMessageEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnDiscussionTopicEntity instances in the database.</summary>
		public DataSource2<SnDiscussionTopicEntity> SnDiscussionTopic
		{
			get { return new DataSource2<SnDiscussionTopicEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnEventEntity instances in the database.</summary>
		public DataSource2<SnEventEntity> SnEvent
		{
			get { return new DataSource2<SnEventEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnEventTypeEntity instances in the database.</summary>
		public DataSource2<SnEventTypeEntity> SnEventType
		{
			get { return new DataSource2<SnEventTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnFileEntity instances in the database.</summary>
		public DataSource2<SnFileEntity> SnFile
		{
			get { return new DataSource2<SnFileEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnFriendEntity instances in the database.</summary>
		public DataSource2<SnFriendEntity> SnFriend
		{
			get { return new DataSource2<SnFriendEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnFriendListEntity instances in the database.</summary>
		public DataSource2<SnFriendListEntity> SnFriendList
		{
			get { return new DataSource2<SnFriendListEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnFriendListMemberEntity instances in the database.</summary>
		public DataSource2<SnFriendListMemberEntity> SnFriendListMember
		{
			get { return new DataSource2<SnFriendListMemberEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnFriendRequestEntity instances in the database.</summary>
		public DataSource2<SnFriendRequestEntity> SnFriendRequest
		{
			get { return new DataSource2<SnFriendRequestEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnGroupEntity instances in the database.</summary>
		public DataSource2<SnGroupEntity> SnGroup
		{
			get { return new DataSource2<SnGroupEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnGroupCategoryEntity instances in the database.</summary>
		public DataSource2<SnGroupCategoryEntity> SnGroupCategory
		{
			get { return new DataSource2<SnGroupCategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnGroupMemberEntity instances in the database.</summary>
		public DataSource2<SnGroupMemberEntity> SnGroupMember
		{
			get { return new DataSource2<SnGroupMemberEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnGroupRequestEntity instances in the database.</summary>
		public DataSource2<SnGroupRequestEntity> SnGroupRequest
		{
			get { return new DataSource2<SnGroupRequestEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnMessageEntity instances in the database.</summary>
		public DataSource2<SnMessageEntity> SnMessage
		{
			get { return new DataSource2<SnMessageEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnMessageRecipientEntity instances in the database.</summary>
		public DataSource2<SnMessageRecipientEntity> SnMessageRecipient
		{
			get { return new DataSource2<SnMessageRecipientEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnNoteEntity instances in the database.</summary>
		public DataSource2<SnNoteEntity> SnNote
		{
			get { return new DataSource2<SnNoteEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnRatingEntity instances in the database.</summary>
		public DataSource2<SnRatingEntity> SnRating
		{
			get { return new DataSource2<SnRatingEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnRelationshipEntity instances in the database.</summary>
		public DataSource2<SnRelationshipEntity> SnRelationship
		{
			get { return new DataSource2<SnRelationshipEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnSubscriberEntity instances in the database.</summary>
		public DataSource2<SnSubscriberEntity> SnSubscriber
		{
			get { return new DataSource2<SnSubscriberEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SnTagEntity instances in the database.</summary>
		public DataSource2<SnTagEntity> SnTag
		{
			get { return new DataSource2<SnTagEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TermsAndConditionsEntity instances in the database.</summary>
		public DataSource2<TermsAndConditionsEntity> TermsAndConditions
		{
			get { return new DataSource2<TermsAndConditionsEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UserAvatarEntity instances in the database.</summary>
		public DataSource2<UserAvatarEntity> UserAvatar
		{
			get { return new DataSource2<UserAvatarEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UserProfileEntity instances in the database.</summary>
		public DataSource2<UserProfileEntity> UserProfile
		{
			get { return new DataSource2<UserProfileEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UserSocialIdentityEntity instances in the database.</summary>
		public DataSource2<UserSocialIdentityEntity> UserSocialIdentity
		{
			get { return new DataSource2<UserSocialIdentityEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting VersionEntity instances in the database.</summary>
		public DataSource2<VersionEntity> Version
		{
			get { return new DataSource2<VersionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		
		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}