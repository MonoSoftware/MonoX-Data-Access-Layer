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
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace MonoSoftware.MonoX.DAL.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((96 + 0));
			InitAdEntityMappings();
			InitAdPageEntityMappings();
			InitAspnetApplicationsEntityMappings();
			InitAspnetMembershipEntityMappings();
			InitAspnetPathsEntityMappings();
			InitAspnetPersonalizationAllUsersEntityMappings();
			InitAspnetPersonalizationPerUserEntityMappings();
			InitAspnetProfileEntityMappings();
			InitAspnetRolesEntityMappings();
			InitAspnetSchemaVersionsEntityMappings();
			InitAspnetUsersEntityMappings();
			InitAspnetUsersInRolesEntityMappings();
			InitAspnetWebEventEventsEntityMappings();
			InitBlogEntityMappings();
			InitBlogCategoryEntityMappings();
			InitBlogEditorEntityMappings();
			InitBlogPostEntityMappings();
			InitBlogPostCategoryEntityMappings();
			InitBlogPostRoleEntityMappings();
			InitCalendarEntityMappings();
			InitCalendarEditRoleEntityMappings();
			InitCalendarEventEntityMappings();
			InitCalendarEventEntryEntityMappings();
			InitCalendarEventRecurringDefinitionEntityMappings();
			InitCalendarEventRecurringDefinitionTypeEntityMappings();
			InitCalendarModeratorEntityMappings();
			InitCalendarViewRoleEntityMappings();
			InitCampaignEntityMappings();
			InitDocumentEntityMappings();
			InitFriendSuggestionTypedViewEntryEntityMappings();
			InitLanguageEntityMappings();
			InitListEntityMappings();
			InitListItemEntityMappings();
			InitListItemLocalizationEntityMappings();
			InitLocalizationBinaryEntityMappings();
			InitLocalizationSourceEntityMappings();
			InitLocalizationStringEntityMappings();
			InitNavigationEntityMappings();
			InitNavigationLocalizationEntityMappings();
			InitNavigationRoleEntityMappings();
			InitNewsCategoryEntityMappings();
			InitNewsCategoryInRoleEntityMappings();
			InitNewsCategoryLocalizationEntityMappings();
			InitNewsCategoryTemplateEntityMappings();
			InitNewsFileEntityMappings();
			InitNewsItemEntityMappings();
			InitNewsItemLocalizationEntityMappings();
			InitNewsletterEntityMappings();
			InitNewsletterLogEntityMappings();
			InitNewsletterRoleEntityMappings();
			InitNewsMetaIgnoredWordEntityMappings();
			InitNewsPublishQueueEntityMappings();
			InitOaConsumerEntityMappings();
			InitOaTokenEntityMappings();
			InitPageEntityMappings();
			InitPageEditRoleEntityMappings();
			InitPageLocalizationEntityMappings();
			InitPageRoleEntityMappings();
			InitPollEntityMappings();
			InitPollAnswerEntityMappings();
			InitPollAnswerLocalizationEntityMappings();
			InitPollLocalizationEntityMappings();
			InitPrivacyLevelEntityMappings();
			InitPrivacyLevelDefinitionEntityMappings();
			InitSnAlbumEntityMappings();
			InitSnBlockUserEntityMappings();
			InitSnCommentEntityMappings();
			InitSnDiscussionBoardEntityMappings();
			InitSnDiscussionBoardInRoleEntityMappings();
			InitSnDiscussionBoardModeratorEntityMappings();
			InitSnDiscussionMessageEntityMappings();
			InitSnDiscussionTopicEntityMappings();
			InitSnEventEntityMappings();
			InitSnEventTypeEntityMappings();
			InitSnFileEntityMappings();
			InitSnFriendEntityMappings();
			InitSnFriendListEntityMappings();
			InitSnFriendListMemberEntityMappings();
			InitSnFriendRequestEntityMappings();
			InitSnGroupEntityMappings();
			InitSnGroupCategoryEntityMappings();
			InitSnGroupMemberEntityMappings();
			InitSnGroupRequestEntityMappings();
			InitSnInvitationEntityMappings();
			InitSnMessageEntityMappings();
			InitSnMessageRecipientEntityMappings();
			InitSnNoteEntityMappings();
			InitSnRatingEntityMappings();
			InitSnRelationshipEntityMappings();
			InitSnSubscriberEntityMappings();
			InitSnTagEntityMappings();
			InitTermsAndConditionsEntityMappings();
			InitUserAvatarEntityMappings();
			InitUserProfileEntityMappings();
			InitUserSocialIdentityEntityMappings();
			InitVersionEntityMappings();

		}


		/// <summary>Inits AdEntity's mappings</summary>
		private void InitAdEntityMappings()
		{
			this.AddElementMapping( "AdEntity", "MonoX2", @"dbo", "Ad", 13 );
			this.AddElementFieldMapping( "AdEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AdEntity", "CampaignId", "CampaignId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "AdEntity", "ImageUrl", "ImageUrl", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AdEntity", "AdContent", "AdContent", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "AdEntity", "NavigateUrl", "NavigateUrl", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "AdEntity", "Keyword", "Keyword", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "AdEntity", "AlternateText", "AlternateText", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "AdEntity", "Caption", "Caption", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "AdEntity", "Weight", "Weight", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			this.AddElementFieldMapping( "AdEntity", "ValidFrom", "ValidFrom", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			this.AddElementFieldMapping( "AdEntity", "ValidTo", "ValidTo", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			this.AddElementFieldMapping( "AdEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			this.AddElementFieldMapping( "AdEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
		}
		/// <summary>Inits AdPageEntity's mappings</summary>
		private void InitAdPageEntityMappings()
		{
			this.AddElementMapping( "AdPageEntity", "MonoX2", @"dbo", "AdPage", 6 );
			this.AddElementFieldMapping( "AdPageEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AdPageEntity", "AdId", "AdId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "AdPageEntity", "PageId", "PageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "AdPageEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			this.AddElementFieldMapping( "AdPageEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "AdPageEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits AspnetApplicationsEntity's mappings</summary>
		private void InitAspnetApplicationsEntityMappings()
		{
			this.AddElementMapping( "AspnetApplicationsEntity", "MonoX2", @"dbo", "aspnet_Applications", 4 );
			this.AddElementFieldMapping( "AspnetApplicationsEntity", "ApplicationName", "ApplicationName", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "AspnetApplicationsEntity", "LoweredApplicationName", "LoweredApplicationName", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "AspnetApplicationsEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "AspnetApplicationsEntity", "Description", "Description", true, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 3 );
		}
		/// <summary>Inits AspnetMembershipEntity's mappings</summary>
		private void InitAspnetMembershipEntityMappings()
		{
			this.AddElementMapping( "AspnetMembershipEntity", "MonoX2", @"dbo", "aspnet_Membership", 21 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "Password", "Password", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "PasswordFormat", "PasswordFormat", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "PasswordSalt", "PasswordSalt", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "MobilePin", "MobilePIN", true, "NVarChar", 16, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "Email", "Email", true, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "LoweredEmail", "LoweredEmail", true, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "PasswordQuestion", "PasswordQuestion", true, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "PasswordAnswer", "PasswordAnswer", true, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "IsApproved", "IsApproved", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "IsLockedOut", "IsLockedOut", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 11 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "CreateDate", "CreateDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "LastLoginDate", "LastLoginDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "LastPasswordChangedDate", "LastPasswordChangedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "LastLockoutDate", "LastLockoutDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "FailedPasswordAttemptCount", "FailedPasswordAttemptCount", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 16 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "FailedPasswordAttemptWindowStart", "FailedPasswordAttemptWindowStart", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 17 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "FailedPasswordAnswerAttemptCount", "FailedPasswordAnswerAttemptCount", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 18 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "FailedPasswordAnswerAttemptWindowStart", "FailedPasswordAnswerAttemptWindowStart", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 19 );
			this.AddElementFieldMapping( "AspnetMembershipEntity", "Comment", "Comment", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 20 );
		}
		/// <summary>Inits AspnetPathsEntity's mappings</summary>
		private void InitAspnetPathsEntityMappings()
		{
			this.AddElementMapping( "AspnetPathsEntity", "MonoX2", @"dbo", "aspnet_Paths", 4 );
			this.AddElementFieldMapping( "AspnetPathsEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AspnetPathsEntity", "PathId", "PathId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "AspnetPathsEntity", "Path", "Path", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AspnetPathsEntity", "LoweredPath", "LoweredPath", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 3 );
		}
		/// <summary>Inits AspnetPersonalizationAllUsersEntity's mappings</summary>
		private void InitAspnetPersonalizationAllUsersEntityMappings()
		{
			this.AddElementMapping( "AspnetPersonalizationAllUsersEntity", "MonoX2", @"dbo", "aspnet_PersonalizationAllUsers", 3 );
			this.AddElementFieldMapping( "AspnetPersonalizationAllUsersEntity", "PathId", "PathId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AspnetPersonalizationAllUsersEntity", "PageSettings", "PageSettings", false, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 1 );
			this.AddElementFieldMapping( "AspnetPersonalizationAllUsersEntity", "LastUpdatedDate", "LastUpdatedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits AspnetPersonalizationPerUserEntity's mappings</summary>
		private void InitAspnetPersonalizationPerUserEntityMappings()
		{
			this.AddElementMapping( "AspnetPersonalizationPerUserEntity", "MonoX2", @"dbo", "aspnet_PersonalizationPerUser", 5 );
			this.AddElementFieldMapping( "AspnetPersonalizationPerUserEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AspnetPersonalizationPerUserEntity", "PathId", "PathId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "AspnetPersonalizationPerUserEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "AspnetPersonalizationPerUserEntity", "PageSettings", "PageSettings", false, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3 );
			this.AddElementFieldMapping( "AspnetPersonalizationPerUserEntity", "LastUpdatedDate", "LastUpdatedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits AspnetProfileEntity's mappings</summary>
		private void InitAspnetProfileEntityMappings()
		{
			this.AddElementMapping( "AspnetProfileEntity", "MonoX2", @"dbo", "aspnet_Profile", 5 );
			this.AddElementFieldMapping( "AspnetProfileEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AspnetProfileEntity", "PropertyNames", "PropertyNames", false, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "AspnetProfileEntity", "PropertyValuesString", "PropertyValuesString", false, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AspnetProfileEntity", "PropertyValuesBinary", "PropertyValuesBinary", false, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3 );
			this.AddElementFieldMapping( "AspnetProfileEntity", "LastUpdatedDate", "LastUpdatedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits AspnetRolesEntity's mappings</summary>
		private void InitAspnetRolesEntityMappings()
		{
			this.AddElementMapping( "AspnetRolesEntity", "MonoX2", @"dbo", "aspnet_Roles", 5 );
			this.AddElementFieldMapping( "AspnetRolesEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AspnetRolesEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "AspnetRolesEntity", "RoleName", "RoleName", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AspnetRolesEntity", "LoweredRoleName", "LoweredRoleName", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "AspnetRolesEntity", "Description", "Description", true, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 4 );
		}
		/// <summary>Inits AspnetSchemaVersionsEntity's mappings</summary>
		private void InitAspnetSchemaVersionsEntityMappings()
		{
			this.AddElementMapping( "AspnetSchemaVersionsEntity", "MonoX2", @"dbo", "aspnet_SchemaVersions", 3 );
			this.AddElementFieldMapping( "AspnetSchemaVersionsEntity", "Feature", "Feature", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "AspnetSchemaVersionsEntity", "CompatibleSchemaVersion", "CompatibleSchemaVersion", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "AspnetSchemaVersionsEntity", "IsCurrentVersion", "IsCurrentVersion", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
		}
		/// <summary>Inits AspnetUsersEntity's mappings</summary>
		private void InitAspnetUsersEntityMappings()
		{
			this.AddElementMapping( "AspnetUsersEntity", "MonoX2", @"dbo", "aspnet_Users", 7 );
			this.AddElementFieldMapping( "AspnetUsersEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AspnetUsersEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "AspnetUsersEntity", "UserName", "UserName", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AspnetUsersEntity", "LoweredUserName", "LoweredUserName", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "AspnetUsersEntity", "MobileAlias", "MobileAlias", true, "NVarChar", 16, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "AspnetUsersEntity", "IsAnonymous", "IsAnonymous", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			this.AddElementFieldMapping( "AspnetUsersEntity", "LastActivityDate", "LastActivityDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits AspnetUsersInRolesEntity's mappings</summary>
		private void InitAspnetUsersInRolesEntityMappings()
		{
			this.AddElementMapping( "AspnetUsersInRolesEntity", "MonoX2", @"dbo", "aspnet_UsersInRoles", 2 );
			this.AddElementFieldMapping( "AspnetUsersInRolesEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "AspnetUsersInRolesEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
		}
		/// <summary>Inits AspnetWebEventEventsEntity's mappings</summary>
		private void InitAspnetWebEventEventsEntityMappings()
		{
			this.AddElementMapping( "AspnetWebEventEventsEntity", "MonoX2", @"dbo", "aspnet_WebEvent_Events", 15 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "EventId", "EventId", false, "Char", 32, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "EventTimeUtc", "EventTimeUtc", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "EventTime", "EventTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "EventType", "EventType", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "EventSequence", "EventSequence", false, "Decimal", 0, 0, 19, false, "", null, typeof(System.Decimal), 4 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "EventOccurrence", "EventOccurrence", false, "Decimal", 0, 0, 19, false, "", null, typeof(System.Decimal), 5 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "EventCode", "EventCode", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "EventDetailCode", "EventDetailCode", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "Message", "Message", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "ApplicationPath", "ApplicationPath", true, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "ApplicationVirtualPath", "ApplicationVirtualPath", true, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "MachineName", "MachineName", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "RequestUrl", "RequestUrl", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "ExceptionType", "ExceptionType", true, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "AspnetWebEventEventsEntity", "Details", "Details", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 14 );
		}
		/// <summary>Inits BlogEntity's mappings</summary>
		private void InitBlogEntityMappings()
		{
			this.AddElementMapping( "BlogEntity", "MonoX2", @"dbo", "Blog", 8 );
			this.AddElementFieldMapping( "BlogEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "BlogEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "BlogEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "BlogEntity", "Name", "Name", false, "NVarChar", 450, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "BlogEntity", "Slug", "Slug", false, "NVarChar", 450, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "BlogEntity", "Description", "Description", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "BlogEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "BlogEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7 );
		}
		/// <summary>Inits BlogCategoryEntity's mappings</summary>
		private void InitBlogCategoryEntityMappings()
		{
			this.AddElementMapping( "BlogCategoryEntity", "MonoX2", @"dbo", "BlogCategory", 4 );
			this.AddElementFieldMapping( "BlogCategoryEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "BlogCategoryEntity", "BlogId", "BlogId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "BlogCategoryEntity", "Name", "Name", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "BlogCategoryEntity", "Slug", "Slug", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 3 );
		}
		/// <summary>Inits BlogEditorEntity's mappings</summary>
		private void InitBlogEditorEntityMappings()
		{
			this.AddElementMapping( "BlogEditorEntity", "MonoX2", @"dbo", "BlogEditor", 3 );
			this.AddElementFieldMapping( "BlogEditorEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "BlogEditorEntity", "BlogId", "BlogId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "BlogEditorEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
		}
		/// <summary>Inits BlogPostEntity's mappings</summary>
		private void InitBlogPostEntityMappings()
		{
			this.AddElementMapping( "BlogPostEntity", "MonoX2", @"dbo", "BlogPost", 15 );
			this.AddElementFieldMapping( "BlogPostEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "BlogPostEntity", "IdentityId", "IdentityId", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "BlogPostEntity", "BlogId", "BlogId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "BlogPostEntity", "Title", "Title", false, "NVarChar", 450, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "BlogPostEntity", "Description", "Description", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "BlogPostEntity", "PostContent", "PostContent", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "BlogPostEntity", "DateCreated", "DateCreated", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "BlogPostEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "BlogPostEntity", "DatePublished", "DatePublished", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			this.AddElementFieldMapping( "BlogPostEntity", "IsCommentEnabled", "IsCommentEnabled", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			this.AddElementFieldMapping( "BlogPostEntity", "Raters", "Raters", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			this.AddElementFieldMapping( "BlogPostEntity", "Rating", "Rating", false, "Float", 0, 0, 38, false, "", null, typeof(System.Double), 11 );
			this.AddElementFieldMapping( "BlogPostEntity", "Slug", "Slug", false, "NVarChar", 450, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "BlogPostEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 13 );
			this.AddElementFieldMapping( "BlogPostEntity", "IsPublished", "IsPublished", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 14 );
		}
		/// <summary>Inits BlogPostCategoryEntity's mappings</summary>
		private void InitBlogPostCategoryEntityMappings()
		{
			this.AddElementMapping( "BlogPostCategoryEntity", "MonoX2", @"dbo", "BlogPostCategory", 3 );
			this.AddElementFieldMapping( "BlogPostCategoryEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "BlogPostCategoryEntity", "BlogPostId", "BlogPostId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "BlogPostCategoryEntity", "BlogCategoryId", "BlogCategoryId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
		}
		/// <summary>Inits BlogPostRoleEntity's mappings</summary>
		private void InitBlogPostRoleEntityMappings()
		{
			this.AddElementMapping( "BlogPostRoleEntity", "MonoX2", @"dbo", "BlogPostRole", 3 );
			this.AddElementFieldMapping( "BlogPostRoleEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "BlogPostRoleEntity", "BlogPostId", "BlogPostId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "BlogPostRoleEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
		}
		/// <summary>Inits CalendarEntity's mappings</summary>
		private void InitCalendarEntityMappings()
		{
			this.AddElementMapping( "CalendarEntity", "MonoX2", @"dbo", "Calendar", 6 );
			this.AddElementFieldMapping( "CalendarEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "CalendarEntity", "OwnerId", "OwnerId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "CalendarEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "CalendarEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "CalendarEntity", "Name", "Name", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "CalendarEntity", "Slug", "Slug", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits CalendarEditRoleEntity's mappings</summary>
		private void InitCalendarEditRoleEntityMappings()
		{
			this.AddElementMapping( "CalendarEditRoleEntity", "MonoX2", @"dbo", "CalendarEditRole", 2 );
			this.AddElementFieldMapping( "CalendarEditRoleEntity", "CalendarId", "CalendarId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "CalendarEditRoleEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
		}
		/// <summary>Inits CalendarEventEntity's mappings</summary>
		private void InitCalendarEventEntityMappings()
		{
			this.AddElementMapping( "CalendarEventEntity", "MonoX2", @"dbo", "CalendarEvent", 12 );
			this.AddElementFieldMapping( "CalendarEventEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "CalendarEventEntity", "AuthorId", "AuthorId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "CalendarEventEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "CalendarEventEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "CalendarEventEntity", "StartTime", "StartTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "CalendarEventEntity", "EndTime", "EndTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "CalendarEventEntity", "AllDay", "AllDay", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			this.AddElementFieldMapping( "CalendarEventEntity", "Title", "Title", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "CalendarEventEntity", "Description", "Description", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "CalendarEventEntity", "Place", "Place", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "CalendarEventEntity", "RecurringDefinitionId", "RecurringDefinitionId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 10 );
			this.AddElementFieldMapping( "CalendarEventEntity", "OwnerCalendarId", "OwnerCalendarId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 11 );
		}
		/// <summary>Inits CalendarEventEntryEntity's mappings</summary>
		private void InitCalendarEventEntryEntityMappings()
		{
			this.AddElementMapping( "CalendarEventEntryEntity", "MonoX2", @"dbo", "CalendarEventEntry", 3 );
			this.AddElementFieldMapping( "CalendarEventEntryEntity", "CalendarId", "CalendarId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "CalendarEventEntryEntity", "CalendarEventId", "CalendarEventId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "CalendarEventEntryEntity", "IsBusy", "IsBusy", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
		}
		/// <summary>Inits CalendarEventRecurringDefinitionEntity's mappings</summary>
		private void InitCalendarEventRecurringDefinitionEntityMappings()
		{
			this.AddElementMapping( "CalendarEventRecurringDefinitionEntity", "MonoX2", @"dbo", "CalendarEventRecurringDefinition", 14 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "RecurringTypeId", "RecurringTypeId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "RepeatFactor", "RepeatFactor", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "Sunday", "Sunday", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "Monday", "Monday", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "Tuesday", "Tuesday", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "Wednesday", "Wednesday", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "Thursday", "Thursday", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "Friday", "Friday", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "Saturday", "Saturday", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "DayOfMonth", "DayOfMonth", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "MonthOfYear", "MonthOfYear", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 11 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "StartsOn", "StartsOn", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionEntity", "EndsOn", "EndsOn", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
		}
		/// <summary>Inits CalendarEventRecurringDefinitionTypeEntity's mappings</summary>
		private void InitCalendarEventRecurringDefinitionTypeEntityMappings()
		{
			this.AddElementMapping( "CalendarEventRecurringDefinitionTypeEntity", "MonoX2", @"dbo", "CalendarEventRecurringDefinitionType", 3 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionTypeEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionTypeEntity", "Name", "Name", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CalendarEventRecurringDefinitionTypeEntity", "Abrv", "Abrv", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits CalendarModeratorEntity's mappings</summary>
		private void InitCalendarModeratorEntityMappings()
		{
			this.AddElementMapping( "CalendarModeratorEntity", "MonoX2", @"dbo", "CalendarModerator", 2 );
			this.AddElementFieldMapping( "CalendarModeratorEntity", "CalendarId", "CalendarId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "CalendarModeratorEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
		}
		/// <summary>Inits CalendarViewRoleEntity's mappings</summary>
		private void InitCalendarViewRoleEntityMappings()
		{
			this.AddElementMapping( "CalendarViewRoleEntity", "MonoX2", @"dbo", "CalendarViewRole", 2 );
			this.AddElementFieldMapping( "CalendarViewRoleEntity", "CalendarId", "CalendarId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "CalendarViewRoleEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
		}
		/// <summary>Inits CampaignEntity's mappings</summary>
		private void InitCampaignEntityMappings()
		{
			this.AddElementMapping( "CampaignEntity", "MonoX2", @"dbo", "Campaign", 8 );
			this.AddElementFieldMapping( "CampaignEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "CampaignEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "CampaignEntity", "Name", "Name", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CampaignEntity", "Start", "Start", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "CampaignEntity", "End", "End", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "CampaignEntity", "Active", "Active", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			this.AddElementFieldMapping( "CampaignEntity", "DateEntered", "DateEntered", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "CampaignEntity", "DateModified", "DateModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits DocumentEntity's mappings</summary>
		private void InitDocumentEntityMappings()
		{
			this.AddElementMapping( "DocumentEntity", "MonoX2", @"dbo", "Document", 11 );
			this.AddElementFieldMapping( "DocumentEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "DocumentEntity", "PageId", "PageId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "DocumentEntity", "ControlId", "ControlId", true, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "DocumentEntity", "ContentId", "ContentId", true, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "DocumentEntity", "Title", "Title", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "DocumentEntity", "TextContent", "TextContent", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "DocumentEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			this.AddElementFieldMapping( "DocumentEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7 );
			this.AddElementFieldMapping( "DocumentEntity", "DateModified", "DateModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			this.AddElementFieldMapping( "DocumentEntity", "RevisionVersion", "RevisionVersion", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			this.AddElementFieldMapping( "DocumentEntity", "BackupVersion", "BackupVersion", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
		}
		/// <summary>Inits FriendSuggestionTypedViewEntryEntity's mappings</summary>
		private void InitFriendSuggestionTypedViewEntryEntityMappings()
		{
			this.AddElementMapping( "FriendSuggestionTypedViewEntryEntity", "MonoX2", @"dbo", "FriendSuggestionTypedViewEntry", 6 );
			this.AddElementFieldMapping( "FriendSuggestionTypedViewEntryEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "FriendSuggestionTypedViewEntryEntity", "UserName", "UserName", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "FriendSuggestionTypedViewEntryEntity", "FirstName", "FirstName", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "FriendSuggestionTypedViewEntryEntity", "LastName", "LastName", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "FriendSuggestionTypedViewEntryEntity", "ConnectionLevel", "ConnectionLevel", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "FriendSuggestionTypedViewEntryEntity", "RecordCount", "RecordCount", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
		}
		/// <summary>Inits LanguageEntity's mappings</summary>
		private void InitLanguageEntityMappings()
		{
			this.AddElementMapping( "LanguageEntity", "MonoX2", @"dbo", "Language", 4 );
			this.AddElementFieldMapping( "LanguageEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "LanguageEntity", "LanguageName", "LanguageName", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "LanguageEntity", "CultureName", "CultureName", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "LanguageEntity", "DefaultLanguage", "DefaultLanguage", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
		}
		/// <summary>Inits ListEntity's mappings</summary>
		private void InitListEntityMappings()
		{
			this.AddElementMapping( "ListEntity", "MonoX2", @"dbo", "List", 6 );
			this.AddElementFieldMapping( "ListEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "ListEntity", "Title", "Title", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ListEntity", "DateModified", "DateModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "ListEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			this.AddElementFieldMapping( "ListEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			this.AddElementFieldMapping( "ListEntity", "ListType", "ListType", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
		}
		/// <summary>Inits ListItemEntity's mappings</summary>
		private void InitListItemEntityMappings()
		{
			this.AddElementMapping( "ListItemEntity", "MonoX2", @"dbo", "ListItem", 4 );
			this.AddElementFieldMapping( "ListItemEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "ListItemEntity", "ListId", "ListId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "ListItemEntity", "ItemOrder", "ItemOrder", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "ListItemEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ListItemLocalizationEntity's mappings</summary>
		private void InitListItemLocalizationEntityMappings()
		{
			this.AddElementMapping( "ListItemLocalizationEntity", "MonoX2", @"dbo", "ListItemLocalization", 6 );
			this.AddElementFieldMapping( "ListItemLocalizationEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "ListItemLocalizationEntity", "ListItemId", "ListItemId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "ListItemLocalizationEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "ListItemLocalizationEntity", "ItemTitle", "ItemTitle", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ListItemLocalizationEntity", "ItemContent", "ItemContent", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "ListItemLocalizationEntity", "ItemUrl", "ItemUrl", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits LocalizationBinaryEntity's mappings</summary>
		private void InitLocalizationBinaryEntityMappings()
		{
			this.AddElementMapping( "LocalizationBinaryEntity", "MonoX2", @"dbo", "LocalizationBinary", 4 );
			this.AddElementFieldMapping( "LocalizationBinaryEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "LocalizationBinaryEntity", "Data", "Data", false, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 1 );
			this.AddElementFieldMapping( "LocalizationBinaryEntity", "DateEntered", "DateEntered", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "LocalizationBinaryEntity", "DateModified", "DateModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits LocalizationSourceEntity's mappings</summary>
		private void InitLocalizationSourceEntityMappings()
		{
			this.AddElementMapping( "LocalizationSourceEntity", "MonoX2", @"dbo", "LocalizationSource", 7 );
			this.AddElementFieldMapping( "LocalizationSourceEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "LocalizationSourceEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "LocalizationSourceEntity", "Source", "Source", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "LocalizationSourceEntity", "ResourceKey", "ResourceKey", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "LocalizationSourceEntity", "Type", "Type", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "LocalizationSourceEntity", "DateEntered", "DateEntered", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "LocalizationSourceEntity", "DateModified", "DateModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits LocalizationStringEntity's mappings</summary>
		private void InitLocalizationStringEntityMappings()
		{
			this.AddElementMapping( "LocalizationStringEntity", "MonoX2", @"dbo", "LocalizationString", 4 );
			this.AddElementFieldMapping( "LocalizationStringEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "LocalizationStringEntity", "Data", "Data", false, "NVarChar", 2048, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "LocalizationStringEntity", "DateEntered", "DateEntered", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "LocalizationStringEntity", "DateModified", "DateModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits NavigationEntity's mappings</summary>
		private void InitNavigationEntityMappings()
		{
			this.AddElementMapping( "NavigationEntity", "MonoX2", @"dbo", "Navigation", 7 );
			this.AddElementFieldMapping( "NavigationEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NavigationEntity", "PageId", "PageId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NavigationEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "NavigationEntity", "ExternalUrl", "ExternalUrl", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "NavigationEntity", "IsContainerPage", "IsContainerPage", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			this.AddElementFieldMapping( "NavigationEntity", "ParentId", "ParentId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5 );
			this.AddElementFieldMapping( "NavigationEntity", "PageOrder", "PageOrder", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
		}
		/// <summary>Inits NavigationLocalizationEntity's mappings</summary>
		private void InitNavigationLocalizationEntityMappings()
		{
			this.AddElementMapping( "NavigationLocalizationEntity", "MonoX2", @"dbo", "NavigationLocalization", 5 );
			this.AddElementFieldMapping( "NavigationLocalizationEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NavigationLocalizationEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NavigationLocalizationEntity", "NavigationId", "NavigationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "NavigationLocalizationEntity", "Title", "Title", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "NavigationLocalizationEntity", "ToolTip", "ToolTip", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 4 );
		}
		/// <summary>Inits NavigationRoleEntity's mappings</summary>
		private void InitNavigationRoleEntityMappings()
		{
			this.AddElementMapping( "NavigationRoleEntity", "MonoX2", @"dbo", "NavigationRole", 3 );
			this.AddElementFieldMapping( "NavigationRoleEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NavigationRoleEntity", "NavigationId", "NavigationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NavigationRoleEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
		}
		/// <summary>Inits NewsCategoryEntity's mappings</summary>
		private void InitNewsCategoryEntityMappings()
		{
			this.AddElementMapping( "NewsCategoryEntity", "MonoX2", @"dbo", "NewsCategory", 7 );
			this.AddElementFieldMapping( "NewsCategoryEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsCategoryEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsCategoryEntity", "NewsCategoryId", "NewsCategoryId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "NewsCategoryEntity", "Image", "Image", true, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3 );
			this.AddElementFieldMapping( "NewsCategoryEntity", "Order", "Order", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "NewsCategoryEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "NewsCategoryEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits NewsCategoryInRoleEntity's mappings</summary>
		private void InitNewsCategoryInRoleEntityMappings()
		{
			this.AddElementMapping( "NewsCategoryInRoleEntity", "MonoX2", @"dbo", "NewsCategoryInRole", 7 );
			this.AddElementFieldMapping( "NewsCategoryInRoleEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsCategoryInRoleEntity", "NewsCategoryId", "NewsCategoryId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsCategoryInRoleEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "NewsCategoryInRoleEntity", "ViewPermissions", "ViewPermissions", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			this.AddElementFieldMapping( "NewsCategoryInRoleEntity", "EditPermissions", "EditPermissions", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			this.AddElementFieldMapping( "NewsCategoryInRoleEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "NewsCategoryInRoleEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits NewsCategoryLocalizationEntity's mappings</summary>
		private void InitNewsCategoryLocalizationEntityMappings()
		{
			this.AddElementMapping( "NewsCategoryLocalizationEntity", "MonoX2", @"dbo", "NewsCategoryLocalization", 9 );
			this.AddElementFieldMapping( "NewsCategoryLocalizationEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsCategoryLocalizationEntity", "NewsCategoryId", "NewsCategoryId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsCategoryLocalizationEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "NewsCategoryLocalizationEntity", "Title", "Title", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "NewsCategoryLocalizationEntity", "Name", "Name", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "NewsCategoryLocalizationEntity", "Description", "Description", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "NewsCategoryLocalizationEntity", "Published", "Published", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			this.AddElementFieldMapping( "NewsCategoryLocalizationEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "NewsCategoryLocalizationEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
		}
		/// <summary>Inits NewsCategoryTemplateEntity's mappings</summary>
		private void InitNewsCategoryTemplateEntityMappings()
		{
			this.AddElementMapping( "NewsCategoryTemplateEntity", "MonoX2", @"dbo", "NewsCategoryTemplate", 5 );
			this.AddElementFieldMapping( "NewsCategoryTemplateEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsCategoryTemplateEntity", "TemplateName", "TemplateName", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "NewsCategoryTemplateEntity", "TemplateNameFullContent", "TemplateNameFullContent", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "NewsCategoryTemplateEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "NewsCategoryTemplateEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits NewsFileEntity's mappings</summary>
		private void InitNewsFileEntityMappings()
		{
			this.AddElementMapping( "NewsFileEntity", "MonoX2", @"dbo", "NewsFile", 5 );
			this.AddElementFieldMapping( "NewsFileEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsFileEntity", "NewsItemId", "NewsItemId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsFileEntity", "ContentType", "ContentType", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "NewsFileEntity", "Name", "Name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "NewsFileEntity", "Content", "Content", false, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 4 );
		}
		/// <summary>Inits NewsItemEntity's mappings</summary>
		private void InitNewsItemEntityMappings()
		{
			this.AddElementMapping( "NewsItemEntity", "MonoX2", @"dbo", "NewsItem", 17 );
			this.AddElementFieldMapping( "NewsItemEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsItemEntity", "NewsCategoryId", "NewsCategoryId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsItemEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "NewsItemEntity", "ShowOnHomePage", "ShowOnHomePage", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			this.AddElementFieldMapping( "NewsItemEntity", "Revision", "Revision", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "NewsItemEntity", "ShowTitle", "ShowTitle", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			this.AddElementFieldMapping( "NewsItemEntity", "ShowShortContent", "ShowShortContent", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			this.AddElementFieldMapping( "NewsItemEntity", "ShowCategoryTitle", "ShowCategoryTitle", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7 );
			this.AddElementFieldMapping( "NewsItemEntity", "ShowCategoryTitleAsLink", "ShowCategoryTitleAsLink", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			this.AddElementFieldMapping( "NewsItemEntity", "ShowFullCategoryPath", "ShowFullCategoryPath", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			this.AddElementFieldMapping( "NewsItemEntity", "ShowUserName", "ShowUserName", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			this.AddElementFieldMapping( "NewsItemEntity", "ShowDateEntered", "ShowDateEntered", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 11 );
			this.AddElementFieldMapping( "NewsItemEntity", "ShowDateModified", "ShowDateModified", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 12 );
			this.AddElementFieldMapping( "NewsItemEntity", "ViewCount", "ViewCount", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
			this.AddElementFieldMapping( "NewsItemEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			this.AddElementFieldMapping( "NewsItemEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			this.AddElementFieldMapping( "NewsItemEntity", "VisibleDate", "VisibleDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
		}
		/// <summary>Inits NewsItemLocalizationEntity's mappings</summary>
		private void InitNewsItemLocalizationEntityMappings()
		{
			this.AddElementMapping( "NewsItemLocalizationEntity", "MonoX2", @"dbo", "NewsItemLocalization", 14 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "NewsId", "NewsId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "Title", "Title", true, "NVarChar", 300, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "ShortContent", "ShortContent", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "Content", "Content", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "Published", "Published", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "PublishStart", "PublishStart", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "PublishEnd", "PublishEnd", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "MetaDescription", "MetaDescription", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "MetaKeywords", "MetaKeywords", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			this.AddElementFieldMapping( "NewsItemLocalizationEntity", "VisibleDate", "VisibleDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
		}
		/// <summary>Inits NewsletterEntity's mappings</summary>
		private void InitNewsletterEntityMappings()
		{
			this.AddElementMapping( "NewsletterEntity", "MonoX2", @"dbo", "Newsletter", 14 );
			this.AddElementFieldMapping( "NewsletterEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsletterEntity", "Title", "Title", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "NewsletterEntity", "TextContent", "TextContent", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "NewsletterEntity", "HtmlContent", "HtmlContent", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "NewsletterEntity", "DateModified", "DateModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "NewsletterEntity", "SentOn", "SentOn", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "NewsletterEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			this.AddElementFieldMapping( "NewsletterEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7 );
			this.AddElementFieldMapping( "NewsletterEntity", "Status", "Status", true, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "NewsletterEntity", "MailFrom", "MailFrom", true, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "NewsletterEntity", "TestAddress", "TestAddress", true, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "NewsletterEntity", "Result", "Result", true, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "NewsletterEntity", "TextOnly", "TextOnly", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 12 );
			this.AddElementFieldMapping( "NewsletterEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 13 );
		}
		/// <summary>Inits NewsletterLogEntity's mappings</summary>
		private void InitNewsletterLogEntityMappings()
		{
			this.AddElementMapping( "NewsletterLogEntity", "MonoX2", @"dbo", "NewsletterLog", 6 );
			this.AddElementFieldMapping( "NewsletterLogEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsletterLogEntity", "NewsletterId", "NewsletterId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsletterLogEntity", "Email", "Email", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "NewsletterLogEntity", "SentOn", "SentOn", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "NewsletterLogEntity", "Success", "Success", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			this.AddElementFieldMapping( "NewsletterLogEntity", "Message", "Message", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits NewsletterRoleEntity's mappings</summary>
		private void InitNewsletterRoleEntityMappings()
		{
			this.AddElementMapping( "NewsletterRoleEntity", "MonoX2", @"dbo", "NewsletterRole", 3 );
			this.AddElementFieldMapping( "NewsletterRoleEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsletterRoleEntity", "NewsletterId", "NewsletterId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsletterRoleEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
		}
		/// <summary>Inits NewsMetaIgnoredWordEntity's mappings</summary>
		private void InitNewsMetaIgnoredWordEntityMappings()
		{
			this.AddElementMapping( "NewsMetaIgnoredWordEntity", "MonoX2", @"dbo", "NewsMetaIgnoredWord", 5 );
			this.AddElementFieldMapping( "NewsMetaIgnoredWordEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsMetaIgnoredWordEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsMetaIgnoredWordEntity", "Word", "Word", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "NewsMetaIgnoredWordEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "NewsMetaIgnoredWordEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits NewsPublishQueueEntity's mappings</summary>
		private void InitNewsPublishQueueEntityMappings()
		{
			this.AddElementMapping( "NewsPublishQueueEntity", "MonoX2", @"dbo", "NewsPublishQueue", 5 );
			this.AddElementFieldMapping( "NewsPublishQueueEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "NewsPublishQueueEntity", "NewsItemId", "NewsItemId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "NewsPublishQueueEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "NewsPublishQueueEntity", "DateEntered", "DateEntered", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "NewsPublishQueueEntity", "DateModified", "DateModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits OaConsumerEntity's mappings</summary>
		private void InitOaConsumerEntityMappings()
		{
			this.AddElementMapping( "OaConsumerEntity", "MonoX2", @"dbo", "oaConsumer", 8 );
			this.AddElementFieldMapping( "OaConsumerEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "OaConsumerEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "OaConsumerEntity", "Secret", "Secret", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "OaConsumerEntity", "CallbackUrl", "CallbackUrl", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "OaConsumerEntity", "CertificateRaw", "CertificateRaw", true, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 4 );
			this.AddElementFieldMapping( "OaConsumerEntity", "VerificationCodeFormatValue", "VerificationCodeFormatValue", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			this.AddElementFieldMapping( "OaConsumerEntity", "VerificationCodeLength", "VerificationCodeLength", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "OaConsumerEntity", "Version", "Version", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7 );
		}
		/// <summary>Inits OaTokenEntity's mappings</summary>
		private void InitOaTokenEntityMappings()
		{
			this.AddElementMapping( "OaTokenEntity", "MonoX2", @"dbo", "oaToken", 11 );
			this.AddElementFieldMapping( "OaTokenEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "OaTokenEntity", "Token", "Token", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "OaTokenEntity", "TokenSecret", "TokenSecret", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "OaTokenEntity", "CreatedOnUtc", "CreatedOnUtc", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "OaTokenEntity", "CallbackUrl", "CallbackUrl", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "OaTokenEntity", "Scope", "Scope", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "OaTokenEntity", "ConsumerId", "ConsumerId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			this.AddElementFieldMapping( "OaTokenEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7 );
			this.AddElementFieldMapping( "OaTokenEntity", "VerificationCode", "VerificationCode", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "OaTokenEntity", "ExpirationDate", "ExpirationDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			this.AddElementFieldMapping( "OaTokenEntity", "IsAccess", "IsAccess", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
		}
		/// <summary>Inits PageEntity's mappings</summary>
		private void InitPageEntityMappings()
		{
			this.AddElementMapping( "PageEntity", "MonoX2", @"dbo", "Page", 17 );
			this.AddElementFieldMapping( "PageEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PageEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "PageEntity", "Url", "Url", true, "NVarChar", 450, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "PageEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			this.AddElementFieldMapping( "PageEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "PageEntity", "TemplateName", "TemplateName", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "PageEntity", "CacheDuration", "CacheDuration", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "PageEntity", "VaryByCustom", "VaryByCustom", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "PageEntity", "VaryByParam", "VaryByParam", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "PageEntity", "VaryByContentEncoding", "VaryByContentEncoding", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "PageEntity", "VaryByHeader", "VaryByHeader", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "PageEntity", "VaryByControl", "VaryByControl", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "PageEntity", "CacheDependencyKeys", "CacheDependencyKeys", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "PageEntity", "CacheLocation", "CacheLocation", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
			this.AddElementFieldMapping( "PageEntity", "SlidingExpiration", "SlidingExpiration", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 14 );
			this.AddElementFieldMapping( "PageEntity", "Theme", "Theme", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "PageEntity", "MasterPage", "MasterPage", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 16 );
		}
		/// <summary>Inits PageEditRoleEntity's mappings</summary>
		private void InitPageEditRoleEntityMappings()
		{
			this.AddElementMapping( "PageEditRoleEntity", "MonoX2", @"dbo", "PageEditRole", 3 );
			this.AddElementFieldMapping( "PageEditRoleEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PageEditRoleEntity", "PageId", "PageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "PageEditRoleEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
		}
		/// <summary>Inits PageLocalizationEntity's mappings</summary>
		private void InitPageLocalizationEntityMappings()
		{
			this.AddElementMapping( "PageLocalizationEntity", "MonoX2", @"dbo", "PageLocalization", 6 );
			this.AddElementFieldMapping( "PageLocalizationEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PageLocalizationEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "PageLocalizationEntity", "PageId", "PageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "PageLocalizationEntity", "Title", "Title", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "PageLocalizationEntity", "Description", "Description", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "PageLocalizationEntity", "Keywords", "Keywords", true, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits PageRoleEntity's mappings</summary>
		private void InitPageRoleEntityMappings()
		{
			this.AddElementMapping( "PageRoleEntity", "MonoX2", @"dbo", "PageRole", 3 );
			this.AddElementFieldMapping( "PageRoleEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PageRoleEntity", "PageId", "PageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "PageRoleEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
		}
		/// <summary>Inits PollEntity's mappings</summary>
		private void InitPollEntityMappings()
		{
			this.AddElementMapping( "PollEntity", "MonoX2", @"dbo", "Poll", 5 );
			this.AddElementFieldMapping( "PollEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PollEntity", "Title", "Title", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "PollEntity", "DateModified", "DateModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "PollEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			this.AddElementFieldMapping( "PollEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
		}
		/// <summary>Inits PollAnswerEntity's mappings</summary>
		private void InitPollAnswerEntityMappings()
		{
			this.AddElementMapping( "PollAnswerEntity", "MonoX2", @"dbo", "PollAnswer", 5 );
			this.AddElementFieldMapping( "PollAnswerEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PollAnswerEntity", "PollId", "PollId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "PollAnswerEntity", "Votes", "Votes", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "PollAnswerEntity", "Color", "Color", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "PollAnswerEntity", "AnswerOrder", "AnswerOrder", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
		}
		/// <summary>Inits PollAnswerLocalizationEntity's mappings</summary>
		private void InitPollAnswerLocalizationEntityMappings()
		{
			this.AddElementMapping( "PollAnswerLocalizationEntity", "MonoX2", @"dbo", "PollAnswerLocalization", 4 );
			this.AddElementFieldMapping( "PollAnswerLocalizationEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PollAnswerLocalizationEntity", "PollAnswerId", "PollAnswerId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "PollAnswerLocalizationEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "PollAnswerLocalizationEntity", "Answer", "Answer", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
		}
		/// <summary>Inits PollLocalizationEntity's mappings</summary>
		private void InitPollLocalizationEntityMappings()
		{
			this.AddElementMapping( "PollLocalizationEntity", "MonoX2", @"dbo", "PollLocalization", 6 );
			this.AddElementFieldMapping( "PollLocalizationEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PollLocalizationEntity", "PollId", "PollId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "PollLocalizationEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "PollLocalizationEntity", "Question", "Question", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "PollLocalizationEntity", "VoteButtonText", "VoteButtonText", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "PollLocalizationEntity", "TotalVotesTextTemplate", "TotalVotesTextTemplate", true, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits PrivacyLevelEntity's mappings</summary>
		private void InitPrivacyLevelEntityMappings()
		{
			this.AddElementMapping( "PrivacyLevelEntity", "MonoX2", @"dbo", "PrivacyLevel", 6 );
			this.AddElementFieldMapping( "PrivacyLevelEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PrivacyLevelEntity", "PrivacyLevel", "PrivacyLevel", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "PrivacyLevelEntity", "Sort", "Sort", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "PrivacyLevelEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "PrivacyLevelEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "PrivacyLevelEntity", "Abrv", "Abrv", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits PrivacyLevelDefinitionEntity's mappings</summary>
		private void InitPrivacyLevelDefinitionEntityMappings()
		{
			this.AddElementMapping( "PrivacyLevelDefinitionEntity", "MonoX2", @"dbo", "PrivacyLevelDefinition", 7 );
			this.AddElementFieldMapping( "PrivacyLevelDefinitionEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "PrivacyLevelDefinitionEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "PrivacyLevelDefinitionEntity", "ObjectName", "ObjectName", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "PrivacyLevelDefinitionEntity", "FieldName", "FieldName", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "PrivacyLevelDefinitionEntity", "PrivacyLevelId", "PrivacyLevelId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			this.AddElementFieldMapping( "PrivacyLevelDefinitionEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "PrivacyLevelDefinitionEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits SnAlbumEntity's mappings</summary>
		private void InitSnAlbumEntityMappings()
		{
			this.AddElementMapping( "SnAlbumEntity", "MonoX2", @"dbo", "SnAlbum", 9 );
			this.AddElementFieldMapping( "SnAlbumEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnAlbumEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnAlbumEntity", "SnGroupId", "SnGroupId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnAlbumEntity", "Name", "Name", false, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SnAlbumEntity", "Description", "Description", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "SnAlbumEntity", "PrivacyLevelId", "PrivacyLevelId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5 );
			this.AddElementFieldMapping( "SnAlbumEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "SnAlbumEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7 );
			this.AddElementFieldMapping( "SnAlbumEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 8 );
		}
		/// <summary>Inits SnBlockUserEntity's mappings</summary>
		private void InitSnBlockUserEntityMappings()
		{
			this.AddElementMapping( "SnBlockUserEntity", "MonoX2", @"dbo", "SnBlockUsers", 4 );
			this.AddElementFieldMapping( "SnBlockUserEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnBlockUserEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnBlockUserEntity", "BlockedUserId", "BlockedUserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnBlockUserEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits SnCommentEntity's mappings</summary>
		private void InitSnCommentEntityMappings()
		{
			this.AddElementMapping( "SnCommentEntity", "MonoX2", @"dbo", "SnComment", 16 );
			this.AddElementFieldMapping( "SnCommentEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnCommentEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnCommentEntity", "RelationshipId", "RelationshipId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnCommentEntity", "Comment", "Comment", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SnCommentEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "SnCommentEntity", "Author", "Author", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "SnCommentEntity", "Email", "Email", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "SnCommentEntity", "Website", "Website", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SnCommentEntity", "Ip", "Ip", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "SnCommentEntity", "Referrer", "Referrer", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "SnCommentEntity", "UserAgent", "UserAgent", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "SnCommentEntity", "IsApproved", "IsApproved", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 11 );
			this.AddElementFieldMapping( "SnCommentEntity", "IsSpam", "IsSpam", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 12 );
			this.AddElementFieldMapping( "SnCommentEntity", "Spaminess", "Spaminess", false, "Decimal", 0, 0, 18, false, "", null, typeof(System.Decimal), 13 );
			this.AddElementFieldMapping( "SnCommentEntity", "Signature", "Signature", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "SnCommentEntity", "Rating", "Rating", false, "Float", 0, 0, 38, false, "", null, typeof(System.Double), 15 );
		}
		/// <summary>Inits SnDiscussionBoardEntity's mappings</summary>
		private void InitSnDiscussionBoardEntityMappings()
		{
			this.AddElementMapping( "SnDiscussionBoardEntity", "MonoX2", @"dbo", "SnDiscussionBoard", 13 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "SnGroupId", "SnGroupId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "Name", "Name", false, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "Description", "Description", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "DailyReportSentOn", "DailyReportSentOn", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "IsClosed", "IsClosed", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "IsPinned", "IsPinned", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "PinnedOn", "PinnedOn", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			this.AddElementFieldMapping( "SnDiscussionBoardEntity", "PinnedByUserId", "PinnedByUserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 12 );
		}
		/// <summary>Inits SnDiscussionBoardInRoleEntity's mappings</summary>
		private void InitSnDiscussionBoardInRoleEntityMappings()
		{
			this.AddElementMapping( "SnDiscussionBoardInRoleEntity", "MonoX2", @"dbo", "SnDiscussionBoardInRole", 2 );
			this.AddElementFieldMapping( "SnDiscussionBoardInRoleEntity", "BoardId", "BoardId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnDiscussionBoardInRoleEntity", "RoleId", "RoleId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
		}
		/// <summary>Inits SnDiscussionBoardModeratorEntity's mappings</summary>
		private void InitSnDiscussionBoardModeratorEntityMappings()
		{
			this.AddElementMapping( "SnDiscussionBoardModeratorEntity", "MonoX2", @"dbo", "SnDiscussionBoardModerator", 3 );
			this.AddElementFieldMapping( "SnDiscussionBoardModeratorEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnDiscussionBoardModeratorEntity", "SnDiscussionBoardId", "SnDiscussionBoardId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnDiscussionBoardModeratorEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
		}
		/// <summary>Inits SnDiscussionMessageEntity's mappings</summary>
		private void InitSnDiscussionMessageEntityMappings()
		{
			this.AddElementMapping( "SnDiscussionMessageEntity", "MonoX2", @"dbo", "SnDiscussionMessage", 27 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "SnDiscussionTopicId", "SnDiscussionTopicId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "Message", "Message", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "LastModifiedDate", "LastModifiedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "Ip", "Ip", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "Referrer", "Referrer", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "UserAgent", "UserAgent", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "IsApproved", "IsApproved", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "IsSpam", "IsSpam", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "Spaminess", "Spaminess", false, "Decimal", 0, 0, 18, false, "", null, typeof(System.Decimal), 11 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "Signature", "Signature", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "IsAnswer", "IsAnswer", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 13 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "AdminAttentionRequired", "AdminAttentionRequired", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 14 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "AdminAttentionReportedByUserId", "AdminAttentionReportedByUserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 15 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "AdminAttentionReportedOn", "AdminAttentionReportedOn", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "AdminAttentionApproved", "AdminAttentionApproved", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 17 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "AdminAttentionReason", "AdminAttentionReason", true, "NVarChar", 300, 0, 0, false, "", null, typeof(System.String), 18 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "IsDeleteRequested", "IsDeleteRequested", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 19 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "DeleteRequestedOn", "DeleteRequestedOn", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 20 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "DeleteRequestedByUserId", "DeleteRequestedByUserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 21 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "IsDeleteApproved", "IsDeleteApproved", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 22 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "DeleteDisapprovedReason", "DeleteDisapprovedReason", true, "NVarChar", 300, 0, 0, false, "", null, typeof(System.String), 23 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "IsPinned", "IsPinned", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 24 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "PinnedOn", "PinnedOn", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 25 );
			this.AddElementFieldMapping( "SnDiscussionMessageEntity", "PinnedByUserId", "PinnedByUserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 26 );
		}
		/// <summary>Inits SnDiscussionTopicEntity's mappings</summary>
		private void InitSnDiscussionTopicEntityMappings()
		{
			this.AddElementMapping( "SnDiscussionTopicEntity", "MonoX2", @"dbo", "SnDiscussionTopic", 17 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "SnDiscussionBoardId", "SnDiscussionBoardId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "Title", "Title", false, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "Ip", "Ip", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "Referrer", "Referrer", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "UserAgent", "UserAgent", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "IsApproved", "IsApproved", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "IsSpam", "IsSpam", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "Spaminess", "Spaminess", false, "Decimal", 0, 0, 18, false, "", null, typeof(System.Decimal), 10 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "Signature", "Signature", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "TimesViewed", "TimesViewed", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "IsClosed", "IsClosed", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 13 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "IsPinned", "IsPinned", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 14 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "PinnedOn", "PinnedOn", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			this.AddElementFieldMapping( "SnDiscussionTopicEntity", "PinnedByUserId", "PinnedByUserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 16 );
		}
		/// <summary>Inits SnEventEntity's mappings</summary>
		private void InitSnEventEntityMappings()
		{
			this.AddElementMapping( "SnEventEntity", "MonoX2", @"dbo", "SnEvent", 19 );
			this.AddElementFieldMapping( "SnEventEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnEventEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnEventEntity", "EventTypeId", "EventTypeId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnEventEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "SnEventEntity", "FriendId", "FriendId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			this.AddElementFieldMapping( "SnEventEntity", "BlogPostId", "BlogPostId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5 );
			this.AddElementFieldMapping( "SnEventEntity", "SnGroupId", "SnGroupId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			this.AddElementFieldMapping( "SnEventEntity", "SnAlbumId", "SnAlbumId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7 );
			this.AddElementFieldMapping( "SnEventEntity", "SnFileId", "SnFileId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 8 );
			this.AddElementFieldMapping( "SnEventEntity", "SnDiscussionBoardId", "SnDiscussionBoardId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 9 );
			this.AddElementFieldMapping( "SnEventEntity", "SnDiscussionTopicId", "SnDiscussionTopicId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 10 );
			this.AddElementFieldMapping( "SnEventEntity", "OaConsumerId", "OaConsumerId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 11 );
			this.AddElementFieldMapping( "SnEventEntity", "CustomId1", "CustomId1", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 12 );
			this.AddElementFieldMapping( "SnEventEntity", "CustomId2", "CustomId2", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 13 );
			this.AddElementFieldMapping( "SnEventEntity", "CustomId3", "CustomId3", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 14 );
			this.AddElementFieldMapping( "SnEventEntity", "EventContent", "EventContent", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "SnEventEntity", "PlainEventTitle", "PlainEventTitle", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "SnEventEntity", "PlainEventUrl", "PlainEventUrl", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "SnEventEntity", "SnNoteId", "SnNoteId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 18 );
		}
		/// <summary>Inits SnEventTypeEntity's mappings</summary>
		private void InitSnEventTypeEntityMappings()
		{
			this.AddElementMapping( "SnEventTypeEntity", "MonoX2", @"dbo", "SnEventType", 2 );
			this.AddElementFieldMapping( "SnEventTypeEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnEventTypeEntity", "Name", "Name", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits SnFileEntity's mappings</summary>
		private void InitSnFileEntityMappings()
		{
			this.AddElementMapping( "SnFileEntity", "MonoX2", @"dbo", "SnFile", 13 );
			this.AddElementFieldMapping( "SnFileEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnFileEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnFileEntity", "RelationshipId", "RelationshipId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnFileEntity", "Name", "Name", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SnFileEntity", "Url", "Url", false, "NVarChar", 2000, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "SnFileEntity", "Description", "Description", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "SnFileEntity", "PrivacyLevelId", "PrivacyLevelId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			this.AddElementFieldMapping( "SnFileEntity", "ThumbnailUrl", "ThumbnailUrl", true, "NVarChar", 2000, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SnFileEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			this.AddElementFieldMapping( "SnFileEntity", "AlbumId", "AlbumId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 9 );
			this.AddElementFieldMapping( "SnFileEntity", "IsAlbumCover", "IsAlbumCover", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			this.AddElementFieldMapping( "SnFileEntity", "SortOrder", "SortOrder", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 11 );
			this.AddElementFieldMapping( "SnFileEntity", "Rating", "Rating", false, "Float", 0, 0, 38, false, "", null, typeof(System.Double), 12 );
		}
		/// <summary>Inits SnFriendEntity's mappings</summary>
		private void InitSnFriendEntityMappings()
		{
			this.AddElementMapping( "SnFriendEntity", "MonoX2", @"dbo", "SnFriend", 4 );
			this.AddElementFieldMapping( "SnFriendEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnFriendEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnFriendEntity", "FriendUserId", "FriendUserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnFriendEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits SnFriendListEntity's mappings</summary>
		private void InitSnFriendListEntityMappings()
		{
			this.AddElementMapping( "SnFriendListEntity", "MonoX2", @"dbo", "SnFriendList", 4 );
			this.AddElementFieldMapping( "SnFriendListEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnFriendListEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnFriendListEntity", "Name", "Name", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SnFriendListEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits SnFriendListMemberEntity's mappings</summary>
		private void InitSnFriendListMemberEntityMappings()
		{
			this.AddElementMapping( "SnFriendListMemberEntity", "MonoX2", @"dbo", "SnFriendListMember", 3 );
			this.AddElementFieldMapping( "SnFriendListMemberEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnFriendListMemberEntity", "FriendListId", "FriendListId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnFriendListMemberEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
		}
		/// <summary>Inits SnFriendRequestEntity's mappings</summary>
		private void InitSnFriendRequestEntityMappings()
		{
			this.AddElementMapping( "SnFriendRequestEntity", "MonoX2", @"dbo", "SnFriendRequest", 5 );
			this.AddElementFieldMapping( "SnFriendRequestEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnFriendRequestEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnFriendRequestEntity", "FriendUserId", "FriendUserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnFriendRequestEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "SnFriendRequestEntity", "DateAccepted", "DateAccepted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits SnGroupEntity's mappings</summary>
		private void InitSnGroupEntityMappings()
		{
			this.AddElementMapping( "SnGroupEntity", "MonoX2", @"dbo", "SnGroup", 10 );
			this.AddElementFieldMapping( "SnGroupEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnGroupEntity", "Name", "Name", false, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "SnGroupEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "SnGroupEntity", "MemberCount", "MemberCount", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "SnGroupEntity", "Description", "Description", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "SnGroupEntity", "IsPublic", "IsPublic", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			this.AddElementFieldMapping( "SnGroupEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			this.AddElementFieldMapping( "SnGroupEntity", "ImageUrl", "ImageUrl", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SnGroupEntity", "GroupCategoryId", "GroupCategoryId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 8 );
			this.AddElementFieldMapping( "SnGroupEntity", "Slug", "Slug", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 9 );
		}
		/// <summary>Inits SnGroupCategoryEntity's mappings</summary>
		private void InitSnGroupCategoryEntityMappings()
		{
			this.AddElementMapping( "SnGroupCategoryEntity", "MonoX2", @"dbo", "SnGroupCategory", 5 );
			this.AddElementFieldMapping( "SnGroupCategoryEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnGroupCategoryEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnGroupCategoryEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnGroupCategoryEntity", "Name", "Name", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SnGroupCategoryEntity", "Slug", "Slug", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 4 );
		}
		/// <summary>Inits SnGroupMemberEntity's mappings</summary>
		private void InitSnGroupMemberEntityMappings()
		{
			this.AddElementMapping( "SnGroupMemberEntity", "MonoX2", @"dbo", "SnGroupMember", 6 );
			this.AddElementFieldMapping( "SnGroupMemberEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnGroupMemberEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnGroupMemberEntity", "GroupId", "GroupId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnGroupMemberEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "SnGroupMemberEntity", "IsAdmin", "IsAdmin", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			this.AddElementFieldMapping( "SnGroupMemberEntity", "IsApproved", "IsApproved", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
		}
		/// <summary>Inits SnGroupRequestEntity's mappings</summary>
		private void InitSnGroupRequestEntityMappings()
		{
			this.AddElementMapping( "SnGroupRequestEntity", "MonoX2", @"dbo", "SnGroupRequest", 6 );
			this.AddElementFieldMapping( "SnGroupRequestEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnGroupRequestEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnGroupRequestEntity", "GroupId", "GroupId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnGroupRequestEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "SnGroupRequestEntity", "DateAccepted", "DateAccepted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "SnGroupRequestEntity", "RequestType", "RequestType", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
		}
		/// <summary>Inits SnInvitationEntity's mappings</summary>
		private void InitSnInvitationEntityMappings()
		{
			this.AddElementMapping( "SnInvitationEntity", "MonoX2", @"dbo", "SnInvitation", 5 );
			this.AddElementFieldMapping( "SnInvitationEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnInvitationEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnInvitationEntity", "Email", "Email", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SnInvitationEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "SnInvitationEntity", "BecameUserId", "BecameUserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
		}
		/// <summary>Inits SnMessageEntity's mappings</summary>
		private void InitSnMessageEntityMappings()
		{
			this.AddElementMapping( "SnMessageEntity", "MonoX2", @"dbo", "SnMessage", 7 );
			this.AddElementFieldMapping( "SnMessageEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnMessageEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnMessageEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "SnMessageEntity", "Subject", "Subject", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SnMessageEntity", "Body", "Body", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "SnMessageEntity", "InReplyToMessageId", "InReplyToMessageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5 );
			this.AddElementFieldMapping( "SnMessageEntity", "ToList", "ToList", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits SnMessageRecipientEntity's mappings</summary>
		private void InitSnMessageRecipientEntityMappings()
		{
			this.AddElementMapping( "SnMessageRecipientEntity", "MonoX2", @"dbo", "SnMessageRecipient", 5 );
			this.AddElementFieldMapping( "SnMessageRecipientEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnMessageRecipientEntity", "MessageId", "MessageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnMessageRecipientEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnMessageRecipientEntity", "MessageStatus", "MessageStatus", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "SnMessageRecipientEntity", "DateRead", "DateRead", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits SnNoteEntity's mappings</summary>
		private void InitSnNoteEntityMappings()
		{
			this.AddElementMapping( "SnNoteEntity", "MonoX2", @"dbo", "SnNote", 11 );
			this.AddElementFieldMapping( "SnNoteEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnNoteEntity", "ApplicationId", "ApplicationId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnNoteEntity", "LanguageId", "LanguageId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnNoteEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			this.AddElementFieldMapping( "SnNoteEntity", "GroupId", "GroupId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			this.AddElementFieldMapping( "SnNoteEntity", "NoteContent", "NoteContent", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "SnNoteEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "SnNoteEntity", "Title", "Title", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SnNoteEntity", "Rating", "Rating", false, "Float", 0, 0, 38, false, "", null, typeof(System.Double), 8 );
			this.AddElementFieldMapping( "SnNoteEntity", "PostToUserId", "PostToUserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 9 );
			this.AddElementFieldMapping( "SnNoteEntity", "PrivacyLevelId", "PrivacyLevelId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 10 );
		}
		/// <summary>Inits SnRatingEntity's mappings</summary>
		private void InitSnRatingEntityMappings()
		{
			this.AddElementMapping( "SnRatingEntity", "MonoX2", @"dbo", "SnRating", 5 );
			this.AddElementFieldMapping( "SnRatingEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnRatingEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnRatingEntity", "RelationshipId", "RelationshipId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnRatingEntity", "DateEntered", "DateEntered", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "SnRatingEntity", "Rating", "Rating", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
		}
		/// <summary>Inits SnRelationshipEntity's mappings</summary>
		private void InitSnRelationshipEntityMappings()
		{
			this.AddElementMapping( "SnRelationshipEntity", "MonoX2", @"dbo", "SnRelationship", 25 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "NoteId", "NoteId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "FileId", "FileId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "AlbumId", "AlbumId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "BlogPostId", "BlogPostId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "MessageId", "MessageId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "DiscussionMessageId", "DiscussionMessageId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "CustomId1", "CustomId1", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "CustomId2", "CustomId2", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 8 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "CustomId3", "CustomId3", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 9 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "DiscussionBoardId", "DiscussionBoardId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 10 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "DiscussionTopicId", "DiscussionTopicId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 11 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "DocumentId", "DocumentId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 12 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "NewsItemId", "NewsItemId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 13 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "ListItemId", "ListItemId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 14 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "BlogId", "BlogId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 15 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "ApplicationId", "ApplicationId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 16 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "CalendarEventId", "CalendarEventId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 17 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "CampaignId", "CampaignId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 18 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "PageId", "PageId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 19 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 20 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "NewsCategoryId", "NewsCategoryId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 21 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "NewsletterId", "NewsletterId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 22 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "PollId", "PollId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 23 );
			this.AddElementFieldMapping( "SnRelationshipEntity", "GroupId", "GroupId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 24 );
		}
		/// <summary>Inits SnSubscriberEntity's mappings</summary>
		private void InitSnSubscriberEntityMappings()
		{
			this.AddElementMapping( "SnSubscriberEntity", "MonoX2", @"dbo", "SnSubscriber", 8 );
			this.AddElementFieldMapping( "SnSubscriberEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnSubscriberEntity", "RelationshipId", "RelationshipId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnSubscriberEntity", "UserId", "UserId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SnSubscriberEntity", "Email", "Email", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SnSubscriberEntity", "SubscriptionDate", "SubscriptionDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "SnSubscriberEntity", "Active", "Active", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			this.AddElementFieldMapping( "SnSubscriberEntity", "SubscriptionOrder", "SubscriptionOrder", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "SnSubscriberEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits SnTagEntity's mappings</summary>
		private void InitSnTagEntityMappings()
		{
			this.AddElementMapping( "SnTagEntity", "MonoX2", @"dbo", "SnTag", 5 );
			this.AddElementFieldMapping( "SnTagEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "SnTagEntity", "RelationshipId", "RelationshipId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "SnTagEntity", "Tag", "Tag", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SnTagEntity", "Slug", "Slug", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SnTagEntity", "SortOrder", "SortOrder", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
		}
		/// <summary>Inits TermsAndConditionsEntity's mappings</summary>
		private void InitTermsAndConditionsEntityMappings()
		{
			this.AddElementMapping( "TermsAndConditionsEntity", "MonoX2", @"dbo", "TermsAndConditions", 4 );
			this.AddElementFieldMapping( "TermsAndConditionsEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "TermsAndConditionsEntity", "Terms", "Terms", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TermsAndConditionsEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "TermsAndConditionsEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits UserAvatarEntity's mappings</summary>
		private void InitUserAvatarEntityMappings()
		{
			this.AddElementMapping( "UserAvatarEntity", "MonoX2", @"dbo", "UserAvatar", 4 );
			this.AddElementFieldMapping( "UserAvatarEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "UserAvatarEntity", "Avatar", "Avatar", false, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 1 );
			this.AddElementFieldMapping( "UserAvatarEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "UserAvatarEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits UserProfileEntity's mappings</summary>
		private void InitUserProfileEntityMappings()
		{
			this.AddElementMapping( "UserProfileEntity", "MonoX2", @"dbo", "UserProfile", 19 );
			this.AddElementFieldMapping( "UserProfileEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "UserProfileEntity", "FirstName", "FirstName", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "UserProfileEntity", "LastName", "LastName", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "UserProfileEntity", "BirthDate", "BirthDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "UserProfileEntity", "Address", "Address", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "UserProfileEntity", "City", "City", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "UserProfileEntity", "ZipCode", "ZipCode", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "UserProfileEntity", "Country", "Country", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "UserProfileEntity", "AboutMySelf", "AboutMySelf", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "UserProfileEntity", "WebSites", "WebSites", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "UserProfileEntity", "EmailVerified", "EMailVerified", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			this.AddElementFieldMapping( "UserProfileEntity", "MyStatus", "MyStatus", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "UserProfileEntity", "MyStatusPrivacyLevelId", "MyStatusPrivacyLevelId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 12 );
			this.AddElementFieldMapping( "UserProfileEntity", "TermsAndConditionsId", "TermsAndConditionsId", true, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 13 );
			this.AddElementFieldMapping( "UserProfileEntity", "TermsAndConditionsAgreedDate", "TermsAndConditionsAgreedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			this.AddElementFieldMapping( "UserProfileEntity", "DateEntered", "DateEntered", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			this.AddElementFieldMapping( "UserProfileEntity", "DateModified", "DateModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
			this.AddElementFieldMapping( "UserProfileEntity", "ReputationScore", "ReputationScore", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 17 );
			this.AddElementFieldMapping( "UserProfileEntity", "TimeZoneId", "TimeZoneId", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 18 );
		}
		/// <summary>Inits UserSocialIdentityEntity's mappings</summary>
		private void InitUserSocialIdentityEntityMappings()
		{
			this.AddElementMapping( "UserSocialIdentityEntity", "MonoX2", @"dbo", "UserSocialIdentity", 4 );
			this.AddElementFieldMapping( "UserSocialIdentityEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "UserSocialIdentityEntity", "UserId", "UserId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "UserSocialIdentityEntity", "ProviderName", "ProviderName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "UserSocialIdentityEntity", "ProviderUserId", "ProviderUserId", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3 );
		}
		/// <summary>Inits VersionEntity's mappings</summary>
		private void InitVersionEntityMappings()
		{
			this.AddElementMapping( "VersionEntity", "MonoX2", @"dbo", "Version", 5 );
			this.AddElementFieldMapping( "VersionEntity", "Id", "Id", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "VersionEntity", "Version", "Version", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "VersionEntity", "Comment", "Comment", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "VersionEntity", "UpgradeLog", "UpgradeLog", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "VersionEntity", "DateEntered", "DateEntered", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}

	}
}