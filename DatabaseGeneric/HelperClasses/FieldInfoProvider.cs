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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace MonoSoftware.MonoX.DAL.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (96 + 0));
			InitAdEntityInfos();
			InitAdPageEntityInfos();
			InitAspnetApplicationsEntityInfos();
			InitAspnetMembershipEntityInfos();
			InitAspnetPathsEntityInfos();
			InitAspnetPersonalizationAllUsersEntityInfos();
			InitAspnetPersonalizationPerUserEntityInfos();
			InitAspnetProfileEntityInfos();
			InitAspnetRolesEntityInfos();
			InitAspnetSchemaVersionsEntityInfos();
			InitAspnetUsersEntityInfos();
			InitAspnetUsersInRolesEntityInfos();
			InitAspnetWebEventEventsEntityInfos();
			InitAuditInfoEntityInfos();
			InitBlogEntityInfos();
			InitBlogCategoryEntityInfos();
			InitBlogEditorEntityInfos();
			InitBlogPostEntityInfos();
			InitBlogPostCategoryEntityInfos();
			InitBlogPostRoleEntityInfos();
			InitCalendarEntityInfos();
			InitCalendarEditRoleEntityInfos();
			InitCalendarEventEntityInfos();
			InitCalendarEventEntryEntityInfos();
			InitCalendarEventRecurringDefinitionEntityInfos();
			InitCalendarEventRecurringDefinitionTypeEntityInfos();
			InitCalendarModeratorEntityInfos();
			InitCalendarViewRoleEntityInfos();
			InitCampaignEntityInfos();
			InitDocumentEntityInfos();
			InitFriendSuggestionTypedViewEntryEntityInfos();
			InitLanguageEntityInfos();
			InitListEntityInfos();
			InitListItemEntityInfos();
			InitListItemLocalizationEntityInfos();
			InitLocalizationBinaryEntityInfos();
			InitLocalizationSourceEntityInfos();
			InitLocalizationStringEntityInfos();
			InitNavigationEntityInfos();
			InitNavigationLocalizationEntityInfos();
			InitNavigationRoleEntityInfos();
			InitNewsCategoryEntityInfos();
			InitNewsCategoryInRoleEntityInfos();
			InitNewsCategoryLocalizationEntityInfos();
			InitNewsCategoryTemplateEntityInfos();
			InitNewsFileEntityInfos();
			InitNewsItemEntityInfos();
			InitNewsItemLocalizationEntityInfos();
			InitNewsletterEntityInfos();
			InitNewsletterLogEntityInfos();
			InitNewsletterRoleEntityInfos();
			InitNewsMetaIgnoredWordEntityInfos();
			InitNewsPublishQueueEntityInfos();
			InitOaConsumerEntityInfos();
			InitOaTokenEntityInfos();
			InitPageEntityInfos();
			InitPageEditRoleEntityInfos();
			InitPageLocalizationEntityInfos();
			InitPageRoleEntityInfos();
			InitPollEntityInfos();
			InitPollAnswerEntityInfos();
			InitPollAnswerLocalizationEntityInfos();
			InitPollLocalizationEntityInfos();
			InitPrivacyLevelEntityInfos();
			InitPrivacyLevelDefinitionEntityInfos();
			InitSnAlbumEntityInfos();
			InitSnBlockUserEntityInfos();
			InitSnCommentEntityInfos();
			InitSnDiscussionBoardEntityInfos();
			InitSnDiscussionBoardInRoleEntityInfos();
			InitSnDiscussionBoardModeratorEntityInfos();
			InitSnDiscussionMessageEntityInfos();
			InitSnDiscussionTopicEntityInfos();
			InitSnEventEntityInfos();
			InitSnEventTypeEntityInfos();
			InitSnFileEntityInfos();
			InitSnFriendEntityInfos();
			InitSnFriendListEntityInfos();
			InitSnFriendListMemberEntityInfos();
			InitSnFriendRequestEntityInfos();
			InitSnGroupEntityInfos();
			InitSnGroupCategoryEntityInfos();
			InitSnGroupMemberEntityInfos();
			InitSnGroupRequestEntityInfos();
			InitSnMessageEntityInfos();
			InitSnMessageRecipientEntityInfos();
			InitSnNoteEntityInfos();
			InitSnRatingEntityInfos();
			InitSnRelationshipEntityInfos();
			InitSnSubscriberEntityInfos();
			InitSnTagEntityInfos();
			InitTermsAndConditionsEntityInfos();
			InitUserAvatarEntityInfos();
			InitUserProfileEntityInfos();
			InitUserSocialIdentityEntityInfos();
			InitVersionEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AdEntity's FieldInfo objects</summary>
		private void InitAdEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AdFieldIndex), "AdEntity");
			this.AddElementFieldInfo("AdEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)AdFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("AdEntity", "CampaignId", typeof(System.Guid), false, true, false, false,  (int)AdFieldIndex.CampaignId, 0, 0, 0);
			this.AddElementFieldInfo("AdEntity", "ImageUrl", typeof(System.String), false, false, false, true,  (int)AdFieldIndex.ImageUrl, 255, 0, 0);
			this.AddElementFieldInfo("AdEntity", "AdContent", typeof(System.String), false, false, false, true,  (int)AdFieldIndex.AdContent, 2147483647, 0, 0);
			this.AddElementFieldInfo("AdEntity", "NavigateUrl", typeof(System.String), false, false, false, false,  (int)AdFieldIndex.NavigateUrl, 255, 0, 0);
			this.AddElementFieldInfo("AdEntity", "Keyword", typeof(System.String), false, false, false, true,  (int)AdFieldIndex.Keyword, 255, 0, 0);
			this.AddElementFieldInfo("AdEntity", "AlternateText", typeof(System.String), false, false, false, true,  (int)AdFieldIndex.AlternateText, 255, 0, 0);
			this.AddElementFieldInfo("AdEntity", "Caption", typeof(System.String), false, false, false, true,  (int)AdFieldIndex.Caption, 255, 0, 0);
			this.AddElementFieldInfo("AdEntity", "Weight", typeof(System.Int32), false, false, false, false,  (int)AdFieldIndex.Weight, 0, 0, 10);
			this.AddElementFieldInfo("AdEntity", "ValidFrom", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)AdFieldIndex.ValidFrom, 0, 0, 0);
			this.AddElementFieldInfo("AdEntity", "ValidTo", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)AdFieldIndex.ValidTo, 0, 0, 0);
			this.AddElementFieldInfo("AdEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)AdFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("AdEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)AdFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits AdPageEntity's FieldInfo objects</summary>
		private void InitAdPageEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AdPageFieldIndex), "AdPageEntity");
			this.AddElementFieldInfo("AdPageEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)AdPageFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("AdPageEntity", "AdId", typeof(System.Guid), false, true, false, false,  (int)AdPageFieldIndex.AdId, 0, 0, 0);
			this.AddElementFieldInfo("AdPageEntity", "PageId", typeof(System.Guid), false, true, false, false,  (int)AdPageFieldIndex.PageId, 0, 0, 0);
			this.AddElementFieldInfo("AdPageEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)AdPageFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("AdPageEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)AdPageFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("AdPageEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)AdPageFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits AspnetApplicationsEntity's FieldInfo objects</summary>
		private void InitAspnetApplicationsEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetApplicationsFieldIndex), "AspnetApplicationsEntity");
			this.AddElementFieldInfo("AspnetApplicationsEntity", "ApplicationName", typeof(System.String), false, false, false, false,  (int)AspnetApplicationsFieldIndex.ApplicationName, 256, 0, 0);
			this.AddElementFieldInfo("AspnetApplicationsEntity", "LoweredApplicationName", typeof(System.String), false, false, false, false,  (int)AspnetApplicationsFieldIndex.LoweredApplicationName, 256, 0, 0);
			this.AddElementFieldInfo("AspnetApplicationsEntity", "ApplicationId", typeof(System.Guid), true, false, false, false,  (int)AspnetApplicationsFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetApplicationsEntity", "Description", typeof(System.String), false, false, false, true,  (int)AspnetApplicationsFieldIndex.Description, 256, 0, 0);
		}
		/// <summary>Inits AspnetMembershipEntity's FieldInfo objects</summary>
		private void InitAspnetMembershipEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetMembershipFieldIndex), "AspnetMembershipEntity");
			this.AddElementFieldInfo("AspnetMembershipEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)AspnetMembershipFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "UserId", typeof(System.Guid), true, true, false, false,  (int)AspnetMembershipFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "Password", typeof(System.String), false, false, false, false,  (int)AspnetMembershipFieldIndex.Password, 128, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "PasswordFormat", typeof(System.Int32), false, false, false, false,  (int)AspnetMembershipFieldIndex.PasswordFormat, 0, 0, 10);
			this.AddElementFieldInfo("AspnetMembershipEntity", "PasswordSalt", typeof(System.String), false, false, false, false,  (int)AspnetMembershipFieldIndex.PasswordSalt, 128, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "MobilePin", typeof(System.String), false, false, false, true,  (int)AspnetMembershipFieldIndex.MobilePin, 16, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "Email", typeof(System.String), false, false, false, true,  (int)AspnetMembershipFieldIndex.Email, 256, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "LoweredEmail", typeof(System.String), false, false, false, true,  (int)AspnetMembershipFieldIndex.LoweredEmail, 256, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "PasswordQuestion", typeof(System.String), false, false, false, true,  (int)AspnetMembershipFieldIndex.PasswordQuestion, 256, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "PasswordAnswer", typeof(System.String), false, false, false, true,  (int)AspnetMembershipFieldIndex.PasswordAnswer, 128, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "IsApproved", typeof(System.Boolean), false, false, false, false,  (int)AspnetMembershipFieldIndex.IsApproved, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "IsLockedOut", typeof(System.Boolean), false, false, false, false,  (int)AspnetMembershipFieldIndex.IsLockedOut, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "CreateDate", typeof(System.DateTime), false, false, false, false,  (int)AspnetMembershipFieldIndex.CreateDate, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "LastLoginDate", typeof(System.DateTime), false, false, false, false,  (int)AspnetMembershipFieldIndex.LastLoginDate, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "LastPasswordChangedDate", typeof(System.DateTime), false, false, false, false,  (int)AspnetMembershipFieldIndex.LastPasswordChangedDate, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "LastLockoutDate", typeof(System.DateTime), false, false, false, false,  (int)AspnetMembershipFieldIndex.LastLockoutDate, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "FailedPasswordAttemptCount", typeof(System.Int32), false, false, false, false,  (int)AspnetMembershipFieldIndex.FailedPasswordAttemptCount, 0, 0, 10);
			this.AddElementFieldInfo("AspnetMembershipEntity", "FailedPasswordAttemptWindowStart", typeof(System.DateTime), false, false, false, false,  (int)AspnetMembershipFieldIndex.FailedPasswordAttemptWindowStart, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "FailedPasswordAnswerAttemptCount", typeof(System.Int32), false, false, false, false,  (int)AspnetMembershipFieldIndex.FailedPasswordAnswerAttemptCount, 0, 0, 10);
			this.AddElementFieldInfo("AspnetMembershipEntity", "FailedPasswordAnswerAttemptWindowStart", typeof(System.DateTime), false, false, false, false,  (int)AspnetMembershipFieldIndex.FailedPasswordAnswerAttemptWindowStart, 0, 0, 0);
			this.AddElementFieldInfo("AspnetMembershipEntity", "Comment", typeof(System.String), false, false, false, true,  (int)AspnetMembershipFieldIndex.Comment, 1073741823, 0, 0);
		}
		/// <summary>Inits AspnetPathsEntity's FieldInfo objects</summary>
		private void InitAspnetPathsEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetPathsFieldIndex), "AspnetPathsEntity");
			this.AddElementFieldInfo("AspnetPathsEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)AspnetPathsFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetPathsEntity", "PathId", typeof(System.Guid), true, false, false, false,  (int)AspnetPathsFieldIndex.PathId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetPathsEntity", "Path", typeof(System.String), false, false, false, false,  (int)AspnetPathsFieldIndex.Path, 256, 0, 0);
			this.AddElementFieldInfo("AspnetPathsEntity", "LoweredPath", typeof(System.String), false, false, false, false,  (int)AspnetPathsFieldIndex.LoweredPath, 256, 0, 0);
		}
		/// <summary>Inits AspnetPersonalizationAllUsersEntity's FieldInfo objects</summary>
		private void InitAspnetPersonalizationAllUsersEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetPersonalizationAllUsersFieldIndex), "AspnetPersonalizationAllUsersEntity");
			this.AddElementFieldInfo("AspnetPersonalizationAllUsersEntity", "PathId", typeof(System.Guid), true, true, false, false,  (int)AspnetPersonalizationAllUsersFieldIndex.PathId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetPersonalizationAllUsersEntity", "PageSettings", typeof(System.Byte[]), false, false, false, false,  (int)AspnetPersonalizationAllUsersFieldIndex.PageSettings, 2147483647, 0, 0);
			this.AddElementFieldInfo("AspnetPersonalizationAllUsersEntity", "LastUpdatedDate", typeof(System.DateTime), false, false, false, false,  (int)AspnetPersonalizationAllUsersFieldIndex.LastUpdatedDate, 0, 0, 0);
		}
		/// <summary>Inits AspnetPersonalizationPerUserEntity's FieldInfo objects</summary>
		private void InitAspnetPersonalizationPerUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetPersonalizationPerUserFieldIndex), "AspnetPersonalizationPerUserEntity");
			this.AddElementFieldInfo("AspnetPersonalizationPerUserEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)AspnetPersonalizationPerUserFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("AspnetPersonalizationPerUserEntity", "PathId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)AspnetPersonalizationPerUserFieldIndex.PathId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetPersonalizationPerUserEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)AspnetPersonalizationPerUserFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetPersonalizationPerUserEntity", "PageSettings", typeof(System.Byte[]), false, false, false, false,  (int)AspnetPersonalizationPerUserFieldIndex.PageSettings, 2147483647, 0, 0);
			this.AddElementFieldInfo("AspnetPersonalizationPerUserEntity", "LastUpdatedDate", typeof(System.DateTime), false, false, false, false,  (int)AspnetPersonalizationPerUserFieldIndex.LastUpdatedDate, 0, 0, 0);
		}
		/// <summary>Inits AspnetProfileEntity's FieldInfo objects</summary>
		private void InitAspnetProfileEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetProfileFieldIndex), "AspnetProfileEntity");
			this.AddElementFieldInfo("AspnetProfileEntity", "UserId", typeof(System.Guid), true, true, false, false,  (int)AspnetProfileFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetProfileEntity", "PropertyNames", typeof(System.String), false, false, false, false,  (int)AspnetProfileFieldIndex.PropertyNames, 1073741823, 0, 0);
			this.AddElementFieldInfo("AspnetProfileEntity", "PropertyValuesString", typeof(System.String), false, false, false, false,  (int)AspnetProfileFieldIndex.PropertyValuesString, 1073741823, 0, 0);
			this.AddElementFieldInfo("AspnetProfileEntity", "PropertyValuesBinary", typeof(System.Byte[]), false, false, false, false,  (int)AspnetProfileFieldIndex.PropertyValuesBinary, 2147483647, 0, 0);
			this.AddElementFieldInfo("AspnetProfileEntity", "LastUpdatedDate", typeof(System.DateTime), false, false, false, false,  (int)AspnetProfileFieldIndex.LastUpdatedDate, 0, 0, 0);
		}
		/// <summary>Inits AspnetRolesEntity's FieldInfo objects</summary>
		private void InitAspnetRolesEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetRolesFieldIndex), "AspnetRolesEntity");
			this.AddElementFieldInfo("AspnetRolesEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)AspnetRolesFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetRolesEntity", "RoleId", typeof(System.Guid), true, false, false, false,  (int)AspnetRolesFieldIndex.RoleId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetRolesEntity", "RoleName", typeof(System.String), false, false, false, false,  (int)AspnetRolesFieldIndex.RoleName, 256, 0, 0);
			this.AddElementFieldInfo("AspnetRolesEntity", "LoweredRoleName", typeof(System.String), false, false, false, false,  (int)AspnetRolesFieldIndex.LoweredRoleName, 256, 0, 0);
			this.AddElementFieldInfo("AspnetRolesEntity", "Description", typeof(System.String), false, false, false, true,  (int)AspnetRolesFieldIndex.Description, 256, 0, 0);
		}
		/// <summary>Inits AspnetSchemaVersionsEntity's FieldInfo objects</summary>
		private void InitAspnetSchemaVersionsEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetSchemaVersionsFieldIndex), "AspnetSchemaVersionsEntity");
			this.AddElementFieldInfo("AspnetSchemaVersionsEntity", "Feature", typeof(System.String), true, false, false, false,  (int)AspnetSchemaVersionsFieldIndex.Feature, 128, 0, 0);
			this.AddElementFieldInfo("AspnetSchemaVersionsEntity", "CompatibleSchemaVersion", typeof(System.String), true, false, false, false,  (int)AspnetSchemaVersionsFieldIndex.CompatibleSchemaVersion, 128, 0, 0);
			this.AddElementFieldInfo("AspnetSchemaVersionsEntity", "IsCurrentVersion", typeof(System.Boolean), false, false, false, false,  (int)AspnetSchemaVersionsFieldIndex.IsCurrentVersion, 0, 0, 0);
		}
		/// <summary>Inits AspnetUsersEntity's FieldInfo objects</summary>
		private void InitAspnetUsersEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetUsersFieldIndex), "AspnetUsersEntity");
			this.AddElementFieldInfo("AspnetUsersEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)AspnetUsersFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetUsersEntity", "UserId", typeof(System.Guid), true, false, false, false,  (int)AspnetUsersFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetUsersEntity", "UserName", typeof(System.String), false, false, false, false,  (int)AspnetUsersFieldIndex.UserName, 256, 0, 0);
			this.AddElementFieldInfo("AspnetUsersEntity", "LoweredUserName", typeof(System.String), false, false, false, false,  (int)AspnetUsersFieldIndex.LoweredUserName, 256, 0, 0);
			this.AddElementFieldInfo("AspnetUsersEntity", "MobileAlias", typeof(System.String), false, false, false, true,  (int)AspnetUsersFieldIndex.MobileAlias, 16, 0, 0);
			this.AddElementFieldInfo("AspnetUsersEntity", "IsAnonymous", typeof(System.Boolean), false, false, false, false,  (int)AspnetUsersFieldIndex.IsAnonymous, 0, 0, 0);
			this.AddElementFieldInfo("AspnetUsersEntity", "LastActivityDate", typeof(System.DateTime), false, false, false, false,  (int)AspnetUsersFieldIndex.LastActivityDate, 0, 0, 0);
		}
		/// <summary>Inits AspnetUsersInRolesEntity's FieldInfo objects</summary>
		private void InitAspnetUsersInRolesEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetUsersInRolesFieldIndex), "AspnetUsersInRolesEntity");
			this.AddElementFieldInfo("AspnetUsersInRolesEntity", "UserId", typeof(System.Guid), true, true, false, false,  (int)AspnetUsersInRolesFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("AspnetUsersInRolesEntity", "RoleId", typeof(System.Guid), true, true, false, false,  (int)AspnetUsersInRolesFieldIndex.RoleId, 0, 0, 0);
		}
		/// <summary>Inits AspnetWebEventEventsEntity's FieldInfo objects</summary>
		private void InitAspnetWebEventEventsEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AspnetWebEventEventsFieldIndex), "AspnetWebEventEventsEntity");
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "EventId", typeof(System.String), true, false, false, false,  (int)AspnetWebEventEventsFieldIndex.EventId, 32, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "EventTimeUtc", typeof(System.DateTime), false, false, false, false,  (int)AspnetWebEventEventsFieldIndex.EventTimeUtc, 0, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "EventTime", typeof(System.DateTime), false, false, false, false,  (int)AspnetWebEventEventsFieldIndex.EventTime, 0, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "EventType", typeof(System.String), false, false, false, false,  (int)AspnetWebEventEventsFieldIndex.EventType, 256, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "EventSequence", typeof(System.Decimal), false, false, false, false,  (int)AspnetWebEventEventsFieldIndex.EventSequence, 0, 0, 19);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "EventOccurrence", typeof(System.Decimal), false, false, false, false,  (int)AspnetWebEventEventsFieldIndex.EventOccurrence, 0, 0, 19);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "EventCode", typeof(System.Int32), false, false, false, false,  (int)AspnetWebEventEventsFieldIndex.EventCode, 0, 0, 10);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "EventDetailCode", typeof(System.Int32), false, false, false, false,  (int)AspnetWebEventEventsFieldIndex.EventDetailCode, 0, 0, 10);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "Message", typeof(System.String), false, false, false, true,  (int)AspnetWebEventEventsFieldIndex.Message, 1024, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "ApplicationPath", typeof(System.String), false, false, false, true,  (int)AspnetWebEventEventsFieldIndex.ApplicationPath, 256, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "ApplicationVirtualPath", typeof(System.String), false, false, false, true,  (int)AspnetWebEventEventsFieldIndex.ApplicationVirtualPath, 256, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "MachineName", typeof(System.String), false, false, false, false,  (int)AspnetWebEventEventsFieldIndex.MachineName, 256, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "RequestUrl", typeof(System.String), false, false, false, true,  (int)AspnetWebEventEventsFieldIndex.RequestUrl, 1024, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "ExceptionType", typeof(System.String), false, false, false, true,  (int)AspnetWebEventEventsFieldIndex.ExceptionType, 256, 0, 0);
			this.AddElementFieldInfo("AspnetWebEventEventsEntity", "Details", typeof(System.String), false, false, false, true,  (int)AspnetWebEventEventsFieldIndex.Details, 1073741823, 0, 0);
		}
		/// <summary>Inits AuditInfoEntity's FieldInfo objects</summary>
		private void InitAuditInfoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AuditInfoFieldIndex), "AuditInfoEntity");
			this.AddElementFieldInfo("AuditInfoEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)AuditInfoFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)AuditInfoFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "AffectedEntityName", typeof(System.String), false, false, false, true,  (int)AuditInfoFieldIndex.AffectedEntityName, 250, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "ActionDateTime", typeof(System.DateTime), false, false, false, false,  (int)AuditInfoFieldIndex.ActionDateTime, 0, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "ActionType", typeof(System.Int32), false, false, false, false,  (int)AuditInfoFieldIndex.ActionType, 0, 0, 10);
			this.AddElementFieldInfo("AuditInfoEntity", "ActionTypeName", typeof(System.String), false, false, false, true,  (int)AuditInfoFieldIndex.ActionTypeName, 150, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "ActionPerformedByUser", typeof(System.String), false, false, false, true,  (int)AuditInfoFieldIndex.ActionPerformedByUser, 250, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "ActionData", typeof(System.String), false, false, false, true,  (int)AuditInfoFieldIndex.ActionData, 2147483647, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "ActionDataBinary", typeof(System.Byte[]), false, false, false, true,  (int)AuditInfoFieldIndex.ActionDataBinary, 2147483647, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)AuditInfoFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "DateUpdated", typeof(System.DateTime), false, false, false, false,  (int)AuditInfoFieldIndex.DateUpdated, 0, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "ConcurrencyTimeStamp", typeof(System.Byte[]), false, false, true, true,  (int)AuditInfoFieldIndex.ConcurrencyTimeStamp, 2147483647, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "IpAddress", typeof(System.String), false, false, false, true,  (int)AuditInfoFieldIndex.IpAddress, 50, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "UserAgent", typeof(System.String), false, false, false, true,  (int)AuditInfoFieldIndex.UserAgent, 255, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "Referrer", typeof(System.String), false, false, false, true,  (int)AuditInfoFieldIndex.Referrer, 500, 0, 0);
		}
		/// <summary>Inits BlogEntity's FieldInfo objects</summary>
		private void InitBlogEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BlogFieldIndex), "BlogEntity");
			this.AddElementFieldInfo("BlogEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)BlogFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("BlogEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)BlogFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("BlogEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)BlogFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("BlogEntity", "Name", typeof(System.String), false, false, false, false,  (int)BlogFieldIndex.Name, 450, 0, 0);
			this.AddElementFieldInfo("BlogEntity", "Slug", typeof(System.String), false, false, false, false,  (int)BlogFieldIndex.Slug, 450, 0, 0);
			this.AddElementFieldInfo("BlogEntity", "Description", typeof(System.String), false, false, false, true,  (int)BlogFieldIndex.Description, 2147483647, 0, 0);
			this.AddElementFieldInfo("BlogEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)BlogFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("BlogEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)BlogFieldIndex.UserId, 0, 0, 0);
		}
		/// <summary>Inits BlogCategoryEntity's FieldInfo objects</summary>
		private void InitBlogCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BlogCategoryFieldIndex), "BlogCategoryEntity");
			this.AddElementFieldInfo("BlogCategoryEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)BlogCategoryFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("BlogCategoryEntity", "BlogId", typeof(System.Guid), false, true, false, false,  (int)BlogCategoryFieldIndex.BlogId, 0, 0, 0);
			this.AddElementFieldInfo("BlogCategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)BlogCategoryFieldIndex.Name, 255, 0, 0);
			this.AddElementFieldInfo("BlogCategoryEntity", "Slug", typeof(System.String), false, false, false, false,  (int)BlogCategoryFieldIndex.Slug, 255, 0, 0);
		}
		/// <summary>Inits BlogEditorEntity's FieldInfo objects</summary>
		private void InitBlogEditorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BlogEditorFieldIndex), "BlogEditorEntity");
			this.AddElementFieldInfo("BlogEditorEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)BlogEditorFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("BlogEditorEntity", "BlogId", typeof(System.Guid), false, true, false, false,  (int)BlogEditorFieldIndex.BlogId, 0, 0, 0);
			this.AddElementFieldInfo("BlogEditorEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)BlogEditorFieldIndex.UserId, 0, 0, 0);
		}
		/// <summary>Inits BlogPostEntity's FieldInfo objects</summary>
		private void InitBlogPostEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BlogPostFieldIndex), "BlogPostEntity");
			this.AddElementFieldInfo("BlogPostEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)BlogPostFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "IdentityId", typeof(System.Int32), false, false, true, false,  (int)BlogPostFieldIndex.IdentityId, 0, 0, 10);
			this.AddElementFieldInfo("BlogPostEntity", "BlogId", typeof(System.Guid), false, true, false, false,  (int)BlogPostFieldIndex.BlogId, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "Title", typeof(System.String), false, false, false, false,  (int)BlogPostFieldIndex.Title, 450, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "Description", typeof(System.String), false, false, false, true,  (int)BlogPostFieldIndex.Description, 2147483647, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "PostContent", typeof(System.String), false, false, false, false,  (int)BlogPostFieldIndex.PostContent, 2147483647, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "DateCreated", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BlogPostFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BlogPostFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "DatePublished", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BlogPostFieldIndex.DatePublished, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "IsCommentEnabled", typeof(System.Boolean), false, false, false, false,  (int)BlogPostFieldIndex.IsCommentEnabled, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "Raters", typeof(System.Int32), false, false, false, false,  (int)BlogPostFieldIndex.Raters, 0, 0, 10);
			this.AddElementFieldInfo("BlogPostEntity", "Rating", typeof(System.Double), false, false, false, false,  (int)BlogPostFieldIndex.Rating, 0, 0, 38);
			this.AddElementFieldInfo("BlogPostEntity", "Slug", typeof(System.String), false, false, false, false,  (int)BlogPostFieldIndex.Slug, 450, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)BlogPostFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostEntity", "IsPublished", typeof(System.Boolean), false, false, false, false,  (int)BlogPostFieldIndex.IsPublished, 0, 0, 0);
		}
		/// <summary>Inits BlogPostCategoryEntity's FieldInfo objects</summary>
		private void InitBlogPostCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BlogPostCategoryFieldIndex), "BlogPostCategoryEntity");
			this.AddElementFieldInfo("BlogPostCategoryEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)BlogPostCategoryFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostCategoryEntity", "BlogPostId", typeof(System.Guid), false, true, false, false,  (int)BlogPostCategoryFieldIndex.BlogPostId, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostCategoryEntity", "BlogCategoryId", typeof(System.Guid), false, true, false, false,  (int)BlogPostCategoryFieldIndex.BlogCategoryId, 0, 0, 0);
		}
		/// <summary>Inits BlogPostRoleEntity's FieldInfo objects</summary>
		private void InitBlogPostRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BlogPostRoleFieldIndex), "BlogPostRoleEntity");
			this.AddElementFieldInfo("BlogPostRoleEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)BlogPostRoleFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostRoleEntity", "BlogPostId", typeof(System.Guid), false, true, false, false,  (int)BlogPostRoleFieldIndex.BlogPostId, 0, 0, 0);
			this.AddElementFieldInfo("BlogPostRoleEntity", "RoleId", typeof(System.Guid), false, true, false, false,  (int)BlogPostRoleFieldIndex.RoleId, 0, 0, 0);
		}
		/// <summary>Inits CalendarEntity's FieldInfo objects</summary>
		private void InitCalendarEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CalendarFieldIndex), "CalendarEntity");
			this.AddElementFieldInfo("CalendarEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)CalendarFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEntity", "OwnerId", typeof(System.Guid), false, true, false, false,  (int)CalendarFieldIndex.OwnerId, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)CalendarFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CalendarFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEntity", "Name", typeof(System.String), false, false, false, true,  (int)CalendarFieldIndex.Name, 255, 0, 0);
			this.AddElementFieldInfo("CalendarEntity", "Slug", typeof(System.String), false, false, false, true,  (int)CalendarFieldIndex.Slug, 255, 0, 0);
		}
		/// <summary>Inits CalendarEditRoleEntity's FieldInfo objects</summary>
		private void InitCalendarEditRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CalendarEditRoleFieldIndex), "CalendarEditRoleEntity");
			this.AddElementFieldInfo("CalendarEditRoleEntity", "CalendarId", typeof(System.Guid), true, true, false, false,  (int)CalendarEditRoleFieldIndex.CalendarId, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEditRoleEntity", "RoleId", typeof(System.Guid), true, true, false, false,  (int)CalendarEditRoleFieldIndex.RoleId, 0, 0, 0);
		}
		/// <summary>Inits CalendarEventEntity's FieldInfo objects</summary>
		private void InitCalendarEventEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CalendarEventFieldIndex), "CalendarEventEntity");
			this.AddElementFieldInfo("CalendarEventEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)CalendarEventFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "AuthorId", typeof(System.Guid), false, true, false, false,  (int)CalendarEventFieldIndex.AuthorId, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)CalendarEventFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CalendarEventFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "StartTime", typeof(System.DateTime), false, false, false, false,  (int)CalendarEventFieldIndex.StartTime, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "EndTime", typeof(System.DateTime), false, false, false, false,  (int)CalendarEventFieldIndex.EndTime, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "AllDay", typeof(System.Boolean), false, false, false, false,  (int)CalendarEventFieldIndex.AllDay, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "Title", typeof(System.String), false, false, false, true,  (int)CalendarEventFieldIndex.Title, 150, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "Description", typeof(System.String), false, false, false, true,  (int)CalendarEventFieldIndex.Description, 500, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "Place", typeof(System.String), false, false, false, true,  (int)CalendarEventFieldIndex.Place, 250, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "RecurringDefinitionId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)CalendarEventFieldIndex.RecurringDefinitionId, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntity", "OwnerCalendarId", typeof(System.Guid), false, true, false, false,  (int)CalendarEventFieldIndex.OwnerCalendarId, 0, 0, 0);
		}
		/// <summary>Inits CalendarEventEntryEntity's FieldInfo objects</summary>
		private void InitCalendarEventEntryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CalendarEventEntryFieldIndex), "CalendarEventEntryEntity");
			this.AddElementFieldInfo("CalendarEventEntryEntity", "CalendarId", typeof(System.Guid), true, true, false, false,  (int)CalendarEventEntryFieldIndex.CalendarId, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntryEntity", "CalendarEventId", typeof(System.Guid), true, true, false, false,  (int)CalendarEventEntryFieldIndex.CalendarEventId, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventEntryEntity", "IsBusy", typeof(System.Boolean), false, false, false, false,  (int)CalendarEventEntryFieldIndex.IsBusy, 0, 0, 0);
		}
		/// <summary>Inits CalendarEventRecurringDefinitionEntity's FieldInfo objects</summary>
		private void InitCalendarEventRecurringDefinitionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CalendarEventRecurringDefinitionFieldIndex), "CalendarEventRecurringDefinitionEntity");
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "RecurringTypeId", typeof(System.Guid), false, true, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.RecurringTypeId, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "RepeatFactor", typeof(System.Int32), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.RepeatFactor, 0, 0, 10);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "Sunday", typeof(System.Boolean), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.Sunday, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "Monday", typeof(System.Boolean), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.Monday, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "Tuesday", typeof(System.Boolean), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.Tuesday, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "Wednesday", typeof(System.Boolean), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.Wednesday, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "Thursday", typeof(System.Boolean), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.Thursday, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "Friday", typeof(System.Boolean), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.Friday, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "Saturday", typeof(System.Boolean), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.Saturday, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "DayOfMonth", typeof(Nullable<System.Int32>), false, false, false, true,  (int)CalendarEventRecurringDefinitionFieldIndex.DayOfMonth, 0, 0, 10);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "MonthOfYear", typeof(Nullable<System.Int32>), false, false, false, true,  (int)CalendarEventRecurringDefinitionFieldIndex.MonthOfYear, 0, 0, 10);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "StartsOn", typeof(System.DateTime), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.StartsOn, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionEntity", "EndsOn", typeof(System.DateTime), false, false, false, false,  (int)CalendarEventRecurringDefinitionFieldIndex.EndsOn, 0, 0, 0);
		}
		/// <summary>Inits CalendarEventRecurringDefinitionTypeEntity's FieldInfo objects</summary>
		private void InitCalendarEventRecurringDefinitionTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CalendarEventRecurringDefinitionTypeFieldIndex), "CalendarEventRecurringDefinitionTypeEntity");
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionTypeEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)CalendarEventRecurringDefinitionTypeFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)CalendarEventRecurringDefinitionTypeFieldIndex.Name, 250, 0, 0);
			this.AddElementFieldInfo("CalendarEventRecurringDefinitionTypeEntity", "Abrv", typeof(System.String), false, false, false, false,  (int)CalendarEventRecurringDefinitionTypeFieldIndex.Abrv, 250, 0, 0);
		}
		/// <summary>Inits CalendarModeratorEntity's FieldInfo objects</summary>
		private void InitCalendarModeratorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CalendarModeratorFieldIndex), "CalendarModeratorEntity");
			this.AddElementFieldInfo("CalendarModeratorEntity", "CalendarId", typeof(System.Guid), true, true, false, false,  (int)CalendarModeratorFieldIndex.CalendarId, 0, 0, 0);
			this.AddElementFieldInfo("CalendarModeratorEntity", "UserId", typeof(System.Guid), true, true, false, false,  (int)CalendarModeratorFieldIndex.UserId, 0, 0, 0);
		}
		/// <summary>Inits CalendarViewRoleEntity's FieldInfo objects</summary>
		private void InitCalendarViewRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CalendarViewRoleFieldIndex), "CalendarViewRoleEntity");
			this.AddElementFieldInfo("CalendarViewRoleEntity", "CalendarId", typeof(System.Guid), true, true, false, false,  (int)CalendarViewRoleFieldIndex.CalendarId, 0, 0, 0);
			this.AddElementFieldInfo("CalendarViewRoleEntity", "RoleId", typeof(System.Guid), true, true, false, false,  (int)CalendarViewRoleFieldIndex.RoleId, 0, 0, 0);
		}
		/// <summary>Inits CampaignEntity's FieldInfo objects</summary>
		private void InitCampaignEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CampaignFieldIndex), "CampaignEntity");
			this.AddElementFieldInfo("CampaignEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)CampaignFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)CampaignFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "Name", typeof(System.String), false, false, false, false,  (int)CampaignFieldIndex.Name, 250, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "Start", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CampaignFieldIndex.Start, 0, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "End", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CampaignFieldIndex.End, 0, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "Active", typeof(System.Boolean), false, false, false, false,  (int)CampaignFieldIndex.Active, 0, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "DateEntered", typeof(System.DateTime), false, false, false, false,  (int)CampaignFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "DateModified", typeof(System.DateTime), false, false, false, false,  (int)CampaignFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits DocumentEntity's FieldInfo objects</summary>
		private void InitDocumentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DocumentFieldIndex), "DocumentEntity");
			this.AddElementFieldInfo("DocumentEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)DocumentFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "PageId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)DocumentFieldIndex.PageId, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "ControlId", typeof(System.String), false, false, false, true,  (int)DocumentFieldIndex.ControlId, 200, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "ContentId", typeof(System.String), false, false, false, true,  (int)DocumentFieldIndex.ContentId, 200, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "Title", typeof(System.String), false, false, false, true,  (int)DocumentFieldIndex.Title, 2147483647, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "TextContent", typeof(System.String), false, false, false, true,  (int)DocumentFieldIndex.TextContent, 2147483647, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)DocumentFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)DocumentFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "DateModified", typeof(System.DateTime), false, false, false, false,  (int)DocumentFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "RevisionVersion", typeof(System.Boolean), false, false, false, false,  (int)DocumentFieldIndex.RevisionVersion, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "BackupVersion", typeof(System.Boolean), false, false, false, false,  (int)DocumentFieldIndex.BackupVersion, 0, 0, 0);
		}
		/// <summary>Inits FriendSuggestionTypedViewEntryEntity's FieldInfo objects</summary>
		private void InitFriendSuggestionTypedViewEntryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(FriendSuggestionTypedViewEntryFieldIndex), "FriendSuggestionTypedViewEntryEntity");
			this.AddElementFieldInfo("FriendSuggestionTypedViewEntryEntity", "UserId", typeof(System.Guid), false, false, false, false,  (int)FriendSuggestionTypedViewEntryFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("FriendSuggestionTypedViewEntryEntity", "UserName", typeof(System.String), false, false, false, false,  (int)FriendSuggestionTypedViewEntryFieldIndex.UserName, 256, 0, 0);
			this.AddElementFieldInfo("FriendSuggestionTypedViewEntryEntity", "FirstName", typeof(System.String), false, false, false, true,  (int)FriendSuggestionTypedViewEntryFieldIndex.FirstName, 250, 0, 0);
			this.AddElementFieldInfo("FriendSuggestionTypedViewEntryEntity", "LastName", typeof(System.String), false, false, false, true,  (int)FriendSuggestionTypedViewEntryFieldIndex.LastName, 250, 0, 0);
			this.AddElementFieldInfo("FriendSuggestionTypedViewEntryEntity", "ConnectionLevel", typeof(System.Int32), false, false, false, false,  (int)FriendSuggestionTypedViewEntryFieldIndex.ConnectionLevel, 0, 0, 10);
			this.AddElementFieldInfo("FriendSuggestionTypedViewEntryEntity", "RecordCount", typeof(System.Int32), false, false, false, false,  (int)FriendSuggestionTypedViewEntryFieldIndex.RecordCount, 0, 0, 10);
		}
		/// <summary>Inits LanguageEntity's FieldInfo objects</summary>
		private void InitLanguageEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LanguageFieldIndex), "LanguageEntity");
			this.AddElementFieldInfo("LanguageEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)LanguageFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("LanguageEntity", "LanguageName", typeof(System.String), false, false, false, false,  (int)LanguageFieldIndex.LanguageName, 100, 0, 0);
			this.AddElementFieldInfo("LanguageEntity", "CultureName", typeof(System.String), false, false, false, false,  (int)LanguageFieldIndex.CultureName, 10, 0, 0);
			this.AddElementFieldInfo("LanguageEntity", "DefaultLanguage", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)LanguageFieldIndex.DefaultLanguage, 0, 0, 0);
		}
		/// <summary>Inits ListEntity's FieldInfo objects</summary>
		private void InitListEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ListFieldIndex), "ListEntity");
			this.AddElementFieldInfo("ListEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)ListFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("ListEntity", "Title", typeof(System.String), false, false, false, false,  (int)ListFieldIndex.Title, 200, 0, 0);
			this.AddElementFieldInfo("ListEntity", "DateModified", typeof(System.DateTime), false, false, false, false,  (int)ListFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("ListEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)ListFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("ListEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)ListFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("ListEntity", "ListType", typeof(System.Int32), false, false, false, false,  (int)ListFieldIndex.ListType, 0, 0, 10);
		}
		/// <summary>Inits ListItemEntity's FieldInfo objects</summary>
		private void InitListItemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ListItemFieldIndex), "ListItemEntity");
			this.AddElementFieldInfo("ListItemEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)ListItemFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("ListItemEntity", "ListId", typeof(System.Guid), false, true, false, false,  (int)ListItemFieldIndex.ListId, 0, 0, 0);
			this.AddElementFieldInfo("ListItemEntity", "ItemOrder", typeof(System.Int32), false, false, false, false,  (int)ListItemFieldIndex.ItemOrder, 0, 0, 10);
			this.AddElementFieldInfo("ListItemEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)ListItemFieldIndex.DateCreated, 0, 0, 0);
		}
		/// <summary>Inits ListItemLocalizationEntity's FieldInfo objects</summary>
		private void InitListItemLocalizationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ListItemLocalizationFieldIndex), "ListItemLocalizationEntity");
			this.AddElementFieldInfo("ListItemLocalizationEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)ListItemLocalizationFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("ListItemLocalizationEntity", "ListItemId", typeof(System.Guid), false, true, false, false,  (int)ListItemLocalizationFieldIndex.ListItemId, 0, 0, 0);
			this.AddElementFieldInfo("ListItemLocalizationEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)ListItemLocalizationFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("ListItemLocalizationEntity", "ItemTitle", typeof(System.String), false, false, false, false,  (int)ListItemLocalizationFieldIndex.ItemTitle, 2147483647, 0, 0);
			this.AddElementFieldInfo("ListItemLocalizationEntity", "ItemContent", typeof(System.String), false, false, false, true,  (int)ListItemLocalizationFieldIndex.ItemContent, 2147483647, 0, 0);
			this.AddElementFieldInfo("ListItemLocalizationEntity", "ItemUrl", typeof(System.String), false, false, false, true,  (int)ListItemLocalizationFieldIndex.ItemUrl, 500, 0, 0);
		}
		/// <summary>Inits LocalizationBinaryEntity's FieldInfo objects</summary>
		private void InitLocalizationBinaryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LocalizationBinaryFieldIndex), "LocalizationBinaryEntity");
			this.AddElementFieldInfo("LocalizationBinaryEntity", "Id", typeof(System.Guid), true, true, false, false,  (int)LocalizationBinaryFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("LocalizationBinaryEntity", "Data", typeof(System.Byte[]), false, false, false, false,  (int)LocalizationBinaryFieldIndex.Data, 2147483647, 0, 0);
			this.AddElementFieldInfo("LocalizationBinaryEntity", "DateEntered", typeof(System.DateTime), false, false, false, false,  (int)LocalizationBinaryFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("LocalizationBinaryEntity", "DateModified", typeof(System.DateTime), false, false, false, false,  (int)LocalizationBinaryFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits LocalizationSourceEntity's FieldInfo objects</summary>
		private void InitLocalizationSourceEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LocalizationSourceFieldIndex), "LocalizationSourceEntity");
			this.AddElementFieldInfo("LocalizationSourceEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)LocalizationSourceFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("LocalizationSourceEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)LocalizationSourceFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("LocalizationSourceEntity", "Source", typeof(System.String), false, false, false, false,  (int)LocalizationSourceFieldIndex.Source, 256, 0, 0);
			this.AddElementFieldInfo("LocalizationSourceEntity", "ResourceKey", typeof(System.String), false, false, false, false,  (int)LocalizationSourceFieldIndex.ResourceKey, 128, 0, 0);
			this.AddElementFieldInfo("LocalizationSourceEntity", "Type", typeof(System.String), false, false, false, false,  (int)LocalizationSourceFieldIndex.Type, 256, 0, 0);
			this.AddElementFieldInfo("LocalizationSourceEntity", "DateEntered", typeof(System.DateTime), false, false, false, false,  (int)LocalizationSourceFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("LocalizationSourceEntity", "DateModified", typeof(System.DateTime), false, false, false, false,  (int)LocalizationSourceFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits LocalizationStringEntity's FieldInfo objects</summary>
		private void InitLocalizationStringEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LocalizationStringFieldIndex), "LocalizationStringEntity");
			this.AddElementFieldInfo("LocalizationStringEntity", "Id", typeof(System.Guid), true, true, false, false,  (int)LocalizationStringFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("LocalizationStringEntity", "Data", typeof(System.String), false, false, false, false,  (int)LocalizationStringFieldIndex.Data, 2048, 0, 0);
			this.AddElementFieldInfo("LocalizationStringEntity", "DateEntered", typeof(System.DateTime), false, false, false, false,  (int)LocalizationStringFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("LocalizationStringEntity", "DateModified", typeof(System.DateTime), false, false, false, false,  (int)LocalizationStringFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits NavigationEntity's FieldInfo objects</summary>
		private void InitNavigationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NavigationFieldIndex), "NavigationEntity");
			this.AddElementFieldInfo("NavigationEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NavigationFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NavigationEntity", "PageId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)NavigationFieldIndex.PageId, 0, 0, 0);
			this.AddElementFieldInfo("NavigationEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)NavigationFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("NavigationEntity", "ExternalUrl", typeof(System.String), false, false, false, true,  (int)NavigationFieldIndex.ExternalUrl, 500, 0, 0);
			this.AddElementFieldInfo("NavigationEntity", "IsContainerPage", typeof(System.Boolean), false, false, false, false,  (int)NavigationFieldIndex.IsContainerPage, 0, 0, 0);
			this.AddElementFieldInfo("NavigationEntity", "ParentId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)NavigationFieldIndex.ParentId, 0, 0, 0);
			this.AddElementFieldInfo("NavigationEntity", "PageOrder", typeof(System.Int32), false, false, false, false,  (int)NavigationFieldIndex.PageOrder, 0, 0, 10);
		}
		/// <summary>Inits NavigationLocalizationEntity's FieldInfo objects</summary>
		private void InitNavigationLocalizationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NavigationLocalizationFieldIndex), "NavigationLocalizationEntity");
			this.AddElementFieldInfo("NavigationLocalizationEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NavigationLocalizationFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NavigationLocalizationEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)NavigationLocalizationFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("NavigationLocalizationEntity", "NavigationId", typeof(System.Guid), false, true, false, false,  (int)NavigationLocalizationFieldIndex.NavigationId, 0, 0, 0);
			this.AddElementFieldInfo("NavigationLocalizationEntity", "Title", typeof(System.String), false, false, false, false,  (int)NavigationLocalizationFieldIndex.Title, 255, 0, 0);
			this.AddElementFieldInfo("NavigationLocalizationEntity", "ToolTip", typeof(System.String), false, false, false, true,  (int)NavigationLocalizationFieldIndex.ToolTip, 500, 0, 0);
		}
		/// <summary>Inits NavigationRoleEntity's FieldInfo objects</summary>
		private void InitNavigationRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NavigationRoleFieldIndex), "NavigationRoleEntity");
			this.AddElementFieldInfo("NavigationRoleEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NavigationRoleFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NavigationRoleEntity", "NavigationId", typeof(System.Guid), false, true, false, false,  (int)NavigationRoleFieldIndex.NavigationId, 0, 0, 0);
			this.AddElementFieldInfo("NavigationRoleEntity", "RoleId", typeof(System.Guid), false, true, false, false,  (int)NavigationRoleFieldIndex.RoleId, 0, 0, 0);
		}
		/// <summary>Inits NewsCategoryEntity's FieldInfo objects</summary>
		private void InitNewsCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsCategoryFieldIndex), "NewsCategoryEntity");
			this.AddElementFieldInfo("NewsCategoryEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsCategoryFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)NewsCategoryFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryEntity", "NewsCategoryId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)NewsCategoryFieldIndex.NewsCategoryId, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryEntity", "Image", typeof(System.Byte[]), false, false, false, true,  (int)NewsCategoryFieldIndex.Image, 2147483647, 0, 0);
			this.AddElementFieldInfo("NewsCategoryEntity", "Order", typeof(System.Int32), false, false, false, false,  (int)NewsCategoryFieldIndex.Order, 0, 0, 10);
			this.AddElementFieldInfo("NewsCategoryEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsCategoryFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsCategoryFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits NewsCategoryInRoleEntity's FieldInfo objects</summary>
		private void InitNewsCategoryInRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsCategoryInRoleFieldIndex), "NewsCategoryInRoleEntity");
			this.AddElementFieldInfo("NewsCategoryInRoleEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsCategoryInRoleFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryInRoleEntity", "NewsCategoryId", typeof(System.Guid), false, true, false, false,  (int)NewsCategoryInRoleFieldIndex.NewsCategoryId, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryInRoleEntity", "RoleId", typeof(System.Guid), false, true, false, false,  (int)NewsCategoryInRoleFieldIndex.RoleId, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryInRoleEntity", "ViewPermissions", typeof(System.Boolean), false, false, false, false,  (int)NewsCategoryInRoleFieldIndex.ViewPermissions, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryInRoleEntity", "EditPermissions", typeof(System.Boolean), false, false, false, false,  (int)NewsCategoryInRoleFieldIndex.EditPermissions, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryInRoleEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsCategoryInRoleFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryInRoleEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsCategoryInRoleFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits NewsCategoryLocalizationEntity's FieldInfo objects</summary>
		private void InitNewsCategoryLocalizationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsCategoryLocalizationFieldIndex), "NewsCategoryLocalizationEntity");
			this.AddElementFieldInfo("NewsCategoryLocalizationEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsCategoryLocalizationFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryLocalizationEntity", "NewsCategoryId", typeof(System.Guid), false, true, false, false,  (int)NewsCategoryLocalizationFieldIndex.NewsCategoryId, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryLocalizationEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)NewsCategoryLocalizationFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryLocalizationEntity", "Title", typeof(System.String), false, false, false, false,  (int)NewsCategoryLocalizationFieldIndex.Title, 150, 0, 0);
			this.AddElementFieldInfo("NewsCategoryLocalizationEntity", "Name", typeof(System.String), false, false, false, false,  (int)NewsCategoryLocalizationFieldIndex.Name, 150, 0, 0);
			this.AddElementFieldInfo("NewsCategoryLocalizationEntity", "Description", typeof(System.String), false, false, false, true,  (int)NewsCategoryLocalizationFieldIndex.Description, 2147483647, 0, 0);
			this.AddElementFieldInfo("NewsCategoryLocalizationEntity", "Published", typeof(System.Boolean), false, false, false, false,  (int)NewsCategoryLocalizationFieldIndex.Published, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryLocalizationEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsCategoryLocalizationFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryLocalizationEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsCategoryLocalizationFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits NewsCategoryTemplateEntity's FieldInfo objects</summary>
		private void InitNewsCategoryTemplateEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsCategoryTemplateFieldIndex), "NewsCategoryTemplateEntity");
			this.AddElementFieldInfo("NewsCategoryTemplateEntity", "Id", typeof(System.Guid), true, true, false, false,  (int)NewsCategoryTemplateFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryTemplateEntity", "TemplateName", typeof(System.String), false, false, false, false,  (int)NewsCategoryTemplateFieldIndex.TemplateName, 100, 0, 0);
			this.AddElementFieldInfo("NewsCategoryTemplateEntity", "TemplateNameFullContent", typeof(System.String), false, false, false, false,  (int)NewsCategoryTemplateFieldIndex.TemplateNameFullContent, 100, 0, 0);
			this.AddElementFieldInfo("NewsCategoryTemplateEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsCategoryTemplateFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("NewsCategoryTemplateEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsCategoryTemplateFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits NewsFileEntity's FieldInfo objects</summary>
		private void InitNewsFileEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsFileFieldIndex), "NewsFileEntity");
			this.AddElementFieldInfo("NewsFileEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsFileFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsFileEntity", "NewsItemId", typeof(System.Guid), false, true, false, false,  (int)NewsFileFieldIndex.NewsItemId, 0, 0, 0);
			this.AddElementFieldInfo("NewsFileEntity", "ContentType", typeof(System.String), false, false, false, false,  (int)NewsFileFieldIndex.ContentType, 50, 0, 0);
			this.AddElementFieldInfo("NewsFileEntity", "Name", typeof(System.String), false, false, false, true,  (int)NewsFileFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("NewsFileEntity", "Content", typeof(System.Byte[]), false, false, false, false,  (int)NewsFileFieldIndex.Content, 2147483647, 0, 0);
		}
		/// <summary>Inits NewsItemEntity's FieldInfo objects</summary>
		private void InitNewsItemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsItemFieldIndex), "NewsItemEntity");
			this.AddElementFieldInfo("NewsItemEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsItemFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "NewsCategoryId", typeof(System.Guid), false, true, false, false,  (int)NewsItemFieldIndex.NewsCategoryId, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)NewsItemFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "ShowOnHomePage", typeof(System.Boolean), false, false, false, false,  (int)NewsItemFieldIndex.ShowOnHomePage, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "Revision", typeof(System.Int32), false, false, false, false,  (int)NewsItemFieldIndex.Revision, 0, 0, 10);
			this.AddElementFieldInfo("NewsItemEntity", "ShowTitle", typeof(System.Boolean), false, false, false, false,  (int)NewsItemFieldIndex.ShowTitle, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "ShowShortContent", typeof(System.Boolean), false, false, false, false,  (int)NewsItemFieldIndex.ShowShortContent, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "ShowCategoryTitle", typeof(System.Boolean), false, false, false, false,  (int)NewsItemFieldIndex.ShowCategoryTitle, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "ShowCategoryTitleAsLink", typeof(System.Boolean), false, false, false, false,  (int)NewsItemFieldIndex.ShowCategoryTitleAsLink, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "ShowFullCategoryPath", typeof(System.Boolean), false, false, false, false,  (int)NewsItemFieldIndex.ShowFullCategoryPath, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "ShowUserName", typeof(System.Boolean), false, false, false, false,  (int)NewsItemFieldIndex.ShowUserName, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "ShowDateEntered", typeof(System.Boolean), false, false, false, false,  (int)NewsItemFieldIndex.ShowDateEntered, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "ShowDateModified", typeof(System.Boolean), false, false, false, false,  (int)NewsItemFieldIndex.ShowDateModified, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "ViewCount", typeof(Nullable<System.Int32>), false, false, false, true,  (int)NewsItemFieldIndex.ViewCount, 0, 0, 10);
			this.AddElementFieldInfo("NewsItemEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsItemFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsItemFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemEntity", "VisibleDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsItemFieldIndex.VisibleDate, 0, 0, 0);
		}
		/// <summary>Inits NewsItemLocalizationEntity's FieldInfo objects</summary>
		private void InitNewsItemLocalizationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsItemLocalizationFieldIndex), "NewsItemLocalizationEntity");
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsItemLocalizationFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "NewsId", typeof(System.Guid), false, true, false, false,  (int)NewsItemLocalizationFieldIndex.NewsId, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)NewsItemLocalizationFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "Title", typeof(System.String), false, false, false, true,  (int)NewsItemLocalizationFieldIndex.Title, 300, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "ShortContent", typeof(System.String), false, false, false, true,  (int)NewsItemLocalizationFieldIndex.ShortContent, 2147483647, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "Content", typeof(System.String), false, false, false, true,  (int)NewsItemLocalizationFieldIndex.Content, 2147483647, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "Published", typeof(System.Boolean), false, false, false, false,  (int)NewsItemLocalizationFieldIndex.Published, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "PublishStart", typeof(System.DateTime), false, false, false, false,  (int)NewsItemLocalizationFieldIndex.PublishStart, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "PublishEnd", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsItemLocalizationFieldIndex.PublishEnd, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "MetaDescription", typeof(System.String), false, false, false, true,  (int)NewsItemLocalizationFieldIndex.MetaDescription, 255, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "MetaKeywords", typeof(System.String), false, false, false, true,  (int)NewsItemLocalizationFieldIndex.MetaKeywords, 255, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsItemLocalizationFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsItemLocalizationFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("NewsItemLocalizationEntity", "VisibleDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsItemLocalizationFieldIndex.VisibleDate, 0, 0, 0);
		}
		/// <summary>Inits NewsletterEntity's FieldInfo objects</summary>
		private void InitNewsletterEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsletterFieldIndex), "NewsletterEntity");
			this.AddElementFieldInfo("NewsletterEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsletterFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "Title", typeof(System.String), false, false, false, false,  (int)NewsletterFieldIndex.Title, 200, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "TextContent", typeof(System.String), false, false, false, true,  (int)NewsletterFieldIndex.TextContent, 2147483647, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "HtmlContent", typeof(System.String), false, false, false, true,  (int)NewsletterFieldIndex.HtmlContent, 2147483647, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "DateModified", typeof(System.DateTime), false, false, false, false,  (int)NewsletterFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "SentOn", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsletterFieldIndex.SentOn, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)NewsletterFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)NewsletterFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "Status", typeof(System.String), false, false, false, true,  (int)NewsletterFieldIndex.Status, 200, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "MailFrom", typeof(System.String), false, false, false, true,  (int)NewsletterFieldIndex.MailFrom, 200, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "TestAddress", typeof(System.String), false, false, false, true,  (int)NewsletterFieldIndex.TestAddress, 200, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "Result", typeof(System.String), false, false, false, true,  (int)NewsletterFieldIndex.Result, 200, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "TextOnly", typeof(System.Boolean), false, false, false, false,  (int)NewsletterFieldIndex.TextOnly, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)NewsletterFieldIndex.LanguageId, 0, 0, 0);
		}
		/// <summary>Inits NewsletterLogEntity's FieldInfo objects</summary>
		private void InitNewsletterLogEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsletterLogFieldIndex), "NewsletterLogEntity");
			this.AddElementFieldInfo("NewsletterLogEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsletterLogFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterLogEntity", "NewsletterId", typeof(System.Guid), false, true, false, false,  (int)NewsletterLogFieldIndex.NewsletterId, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterLogEntity", "Email", typeof(System.String), false, false, false, false,  (int)NewsletterLogFieldIndex.Email, 200, 0, 0);
			this.AddElementFieldInfo("NewsletterLogEntity", "SentOn", typeof(System.DateTime), false, false, false, false,  (int)NewsletterLogFieldIndex.SentOn, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterLogEntity", "Success", typeof(System.Boolean), false, false, false, false,  (int)NewsletterLogFieldIndex.Success, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterLogEntity", "Message", typeof(System.String), false, false, false, true,  (int)NewsletterLogFieldIndex.Message, 500, 0, 0);
		}
		/// <summary>Inits NewsletterRoleEntity's FieldInfo objects</summary>
		private void InitNewsletterRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsletterRoleFieldIndex), "NewsletterRoleEntity");
			this.AddElementFieldInfo("NewsletterRoleEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsletterRoleFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterRoleEntity", "NewsletterId", typeof(System.Guid), false, true, false, false,  (int)NewsletterRoleFieldIndex.NewsletterId, 0, 0, 0);
			this.AddElementFieldInfo("NewsletterRoleEntity", "RoleId", typeof(System.Guid), false, true, false, false,  (int)NewsletterRoleFieldIndex.RoleId, 0, 0, 0);
		}
		/// <summary>Inits NewsMetaIgnoredWordEntity's FieldInfo objects</summary>
		private void InitNewsMetaIgnoredWordEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsMetaIgnoredWordFieldIndex), "NewsMetaIgnoredWordEntity");
			this.AddElementFieldInfo("NewsMetaIgnoredWordEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsMetaIgnoredWordFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsMetaIgnoredWordEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)NewsMetaIgnoredWordFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("NewsMetaIgnoredWordEntity", "Word", typeof(System.String), false, false, false, false,  (int)NewsMetaIgnoredWordFieldIndex.Word, 255, 0, 0);
			this.AddElementFieldInfo("NewsMetaIgnoredWordEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsMetaIgnoredWordFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("NewsMetaIgnoredWordEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NewsMetaIgnoredWordFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits NewsPublishQueueEntity's FieldInfo objects</summary>
		private void InitNewsPublishQueueEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(NewsPublishQueueFieldIndex), "NewsPublishQueueEntity");
			this.AddElementFieldInfo("NewsPublishQueueEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)NewsPublishQueueFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("NewsPublishQueueEntity", "NewsItemId", typeof(System.Guid), false, true, false, false,  (int)NewsPublishQueueFieldIndex.NewsItemId, 0, 0, 0);
			this.AddElementFieldInfo("NewsPublishQueueEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)NewsPublishQueueFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("NewsPublishQueueEntity", "DateEntered", typeof(System.DateTime), false, false, false, false,  (int)NewsPublishQueueFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("NewsPublishQueueEntity", "DateModified", typeof(System.DateTime), false, false, false, false,  (int)NewsPublishQueueFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits OaConsumerEntity's FieldInfo objects</summary>
		private void InitOaConsumerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OaConsumerFieldIndex), "OaConsumerEntity");
			this.AddElementFieldInfo("OaConsumerEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)OaConsumerFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("OaConsumerEntity", "Name", typeof(System.String), false, false, false, false,  (int)OaConsumerFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("OaConsumerEntity", "Secret", typeof(System.String), false, false, false, false,  (int)OaConsumerFieldIndex.Secret, 50, 0, 0);
			this.AddElementFieldInfo("OaConsumerEntity", "CallbackUrl", typeof(System.String), false, false, false, true,  (int)OaConsumerFieldIndex.CallbackUrl, 2147483647, 0, 0);
			this.AddElementFieldInfo("OaConsumerEntity", "CertificateRaw", typeof(System.Byte[]), false, false, false, true,  (int)OaConsumerFieldIndex.CertificateRaw, 2147483647, 0, 0);
			this.AddElementFieldInfo("OaConsumerEntity", "VerificationCodeFormatValue", typeof(System.Int32), false, false, false, false,  (int)OaConsumerFieldIndex.VerificationCodeFormatValue, 0, 0, 10);
			this.AddElementFieldInfo("OaConsumerEntity", "VerificationCodeLength", typeof(System.Int32), false, false, false, false,  (int)OaConsumerFieldIndex.VerificationCodeLength, 0, 0, 10);
			this.AddElementFieldInfo("OaConsumerEntity", "Version", typeof(System.String), false, false, false, true,  (int)OaConsumerFieldIndex.Version, 50, 0, 0);
		}
		/// <summary>Inits OaTokenEntity's FieldInfo objects</summary>
		private void InitOaTokenEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OaTokenFieldIndex), "OaTokenEntity");
			this.AddElementFieldInfo("OaTokenEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)OaTokenFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "Token", typeof(System.String), false, false, false, false,  (int)OaTokenFieldIndex.Token, 2147483647, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "TokenSecret", typeof(System.String), false, false, false, false,  (int)OaTokenFieldIndex.TokenSecret, 50, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "CreatedOnUtc", typeof(System.DateTime), false, false, false, false,  (int)OaTokenFieldIndex.CreatedOnUtc, 0, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "CallbackUrl", typeof(System.String), false, false, false, true,  (int)OaTokenFieldIndex.CallbackUrl, 2147483647, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "Scope", typeof(System.String), false, false, false, true,  (int)OaTokenFieldIndex.Scope, 2147483647, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "ConsumerId", typeof(System.Guid), false, true, false, false,  (int)OaTokenFieldIndex.ConsumerId, 0, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)OaTokenFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "VerificationCode", typeof(System.String), false, false, false, true,  (int)OaTokenFieldIndex.VerificationCode, 50, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "ExpirationDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OaTokenFieldIndex.ExpirationDate, 0, 0, 0);
			this.AddElementFieldInfo("OaTokenEntity", "IsAccess", typeof(System.Boolean), false, false, false, false,  (int)OaTokenFieldIndex.IsAccess, 0, 0, 0);
		}
		/// <summary>Inits PageEntity's FieldInfo objects</summary>
		private void InitPageEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PageFieldIndex), "PageEntity");
			this.AddElementFieldInfo("PageEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PageFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PageEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)PageFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("PageEntity", "Url", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.Url, 450, 0, 0);
			this.AddElementFieldInfo("PageEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)PageFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("PageEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)PageFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("PageEntity", "TemplateName", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.TemplateName, 100, 0, 0);
			this.AddElementFieldInfo("PageEntity", "CacheDuration", typeof(System.Int32), false, false, false, false,  (int)PageFieldIndex.CacheDuration, 0, 0, 10);
			this.AddElementFieldInfo("PageEntity", "VaryByCustom", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.VaryByCustom, 100, 0, 0);
			this.AddElementFieldInfo("PageEntity", "VaryByParam", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.VaryByParam, 100, 0, 0);
			this.AddElementFieldInfo("PageEntity", "VaryByContentEncoding", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.VaryByContentEncoding, 100, 0, 0);
			this.AddElementFieldInfo("PageEntity", "VaryByHeader", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.VaryByHeader, 100, 0, 0);
			this.AddElementFieldInfo("PageEntity", "VaryByControl", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.VaryByControl, 100, 0, 0);
			this.AddElementFieldInfo("PageEntity", "CacheDependencyKeys", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.CacheDependencyKeys, 100, 0, 0);
			this.AddElementFieldInfo("PageEntity", "CacheLocation", typeof(System.Int32), false, false, false, false,  (int)PageFieldIndex.CacheLocation, 0, 0, 10);
			this.AddElementFieldInfo("PageEntity", "SlidingExpiration", typeof(System.Int32), false, false, false, false,  (int)PageFieldIndex.SlidingExpiration, 0, 0, 10);
			this.AddElementFieldInfo("PageEntity", "Theme", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.Theme, 50, 0, 0);
			this.AddElementFieldInfo("PageEntity", "MasterPage", typeof(System.String), false, false, false, true,  (int)PageFieldIndex.MasterPage, 50, 0, 0);
		}
		/// <summary>Inits PageEditRoleEntity's FieldInfo objects</summary>
		private void InitPageEditRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PageEditRoleFieldIndex), "PageEditRoleEntity");
			this.AddElementFieldInfo("PageEditRoleEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PageEditRoleFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PageEditRoleEntity", "PageId", typeof(System.Guid), false, true, false, false,  (int)PageEditRoleFieldIndex.PageId, 0, 0, 0);
			this.AddElementFieldInfo("PageEditRoleEntity", "RoleId", typeof(System.Guid), false, true, false, false,  (int)PageEditRoleFieldIndex.RoleId, 0, 0, 0);
		}
		/// <summary>Inits PageLocalizationEntity's FieldInfo objects</summary>
		private void InitPageLocalizationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PageLocalizationFieldIndex), "PageLocalizationEntity");
			this.AddElementFieldInfo("PageLocalizationEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PageLocalizationFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PageLocalizationEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)PageLocalizationFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("PageLocalizationEntity", "PageId", typeof(System.Guid), false, true, false, false,  (int)PageLocalizationFieldIndex.PageId, 0, 0, 0);
			this.AddElementFieldInfo("PageLocalizationEntity", "Title", typeof(System.String), false, false, false, false,  (int)PageLocalizationFieldIndex.Title, 255, 0, 0);
			this.AddElementFieldInfo("PageLocalizationEntity", "Description", typeof(System.String), false, false, false, true,  (int)PageLocalizationFieldIndex.Description, 2147483647, 0, 0);
			this.AddElementFieldInfo("PageLocalizationEntity", "Keywords", typeof(System.String), false, false, false, true,  (int)PageLocalizationFieldIndex.Keywords, 1000, 0, 0);
		}
		/// <summary>Inits PageRoleEntity's FieldInfo objects</summary>
		private void InitPageRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PageRoleFieldIndex), "PageRoleEntity");
			this.AddElementFieldInfo("PageRoleEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PageRoleFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PageRoleEntity", "PageId", typeof(System.Guid), false, true, false, false,  (int)PageRoleFieldIndex.PageId, 0, 0, 0);
			this.AddElementFieldInfo("PageRoleEntity", "RoleId", typeof(System.Guid), false, true, false, false,  (int)PageRoleFieldIndex.RoleId, 0, 0, 0);
		}
		/// <summary>Inits PollEntity's FieldInfo objects</summary>
		private void InitPollEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PollFieldIndex), "PollEntity");
			this.AddElementFieldInfo("PollEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PollFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PollEntity", "Title", typeof(System.String), false, false, false, false,  (int)PollFieldIndex.Title, 200, 0, 0);
			this.AddElementFieldInfo("PollEntity", "DateModified", typeof(System.DateTime), false, false, false, false,  (int)PollFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("PollEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)PollFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("PollEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)PollFieldIndex.ApplicationId, 0, 0, 0);
		}
		/// <summary>Inits PollAnswerEntity's FieldInfo objects</summary>
		private void InitPollAnswerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PollAnswerFieldIndex), "PollAnswerEntity");
			this.AddElementFieldInfo("PollAnswerEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PollAnswerFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PollAnswerEntity", "PollId", typeof(System.Guid), false, true, false, false,  (int)PollAnswerFieldIndex.PollId, 0, 0, 0);
			this.AddElementFieldInfo("PollAnswerEntity", "Votes", typeof(System.Int32), false, false, false, false,  (int)PollAnswerFieldIndex.Votes, 0, 0, 10);
			this.AddElementFieldInfo("PollAnswerEntity", "Color", typeof(System.String), false, false, false, false,  (int)PollAnswerFieldIndex.Color, 200, 0, 0);
			this.AddElementFieldInfo("PollAnswerEntity", "AnswerOrder", typeof(System.Int32), false, false, false, false,  (int)PollAnswerFieldIndex.AnswerOrder, 0, 0, 10);
		}
		/// <summary>Inits PollAnswerLocalizationEntity's FieldInfo objects</summary>
		private void InitPollAnswerLocalizationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PollAnswerLocalizationFieldIndex), "PollAnswerLocalizationEntity");
			this.AddElementFieldInfo("PollAnswerLocalizationEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PollAnswerLocalizationFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PollAnswerLocalizationEntity", "PollAnswerId", typeof(System.Guid), false, true, false, false,  (int)PollAnswerLocalizationFieldIndex.PollAnswerId, 0, 0, 0);
			this.AddElementFieldInfo("PollAnswerLocalizationEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)PollAnswerLocalizationFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("PollAnswerLocalizationEntity", "Answer", typeof(System.String), false, false, false, false,  (int)PollAnswerLocalizationFieldIndex.Answer, 2147483647, 0, 0);
		}
		/// <summary>Inits PollLocalizationEntity's FieldInfo objects</summary>
		private void InitPollLocalizationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PollLocalizationFieldIndex), "PollLocalizationEntity");
			this.AddElementFieldInfo("PollLocalizationEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PollLocalizationFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PollLocalizationEntity", "PollId", typeof(System.Guid), false, true, false, false,  (int)PollLocalizationFieldIndex.PollId, 0, 0, 0);
			this.AddElementFieldInfo("PollLocalizationEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)PollLocalizationFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("PollLocalizationEntity", "Question", typeof(System.String), false, false, false, false,  (int)PollLocalizationFieldIndex.Question, 2147483647, 0, 0);
			this.AddElementFieldInfo("PollLocalizationEntity", "VoteButtonText", typeof(System.String), false, false, false, true,  (int)PollLocalizationFieldIndex.VoteButtonText, 100, 0, 0);
			this.AddElementFieldInfo("PollLocalizationEntity", "TotalVotesTextTemplate", typeof(System.String), false, false, false, true,  (int)PollLocalizationFieldIndex.TotalVotesTextTemplate, 200, 0, 0);
		}
		/// <summary>Inits PrivacyLevelEntity's FieldInfo objects</summary>
		private void InitPrivacyLevelEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PrivacyLevelFieldIndex), "PrivacyLevelEntity");
			this.AddElementFieldInfo("PrivacyLevelEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PrivacyLevelFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelEntity", "PrivacyLevel", typeof(System.String), false, false, false, false,  (int)PrivacyLevelFieldIndex.PrivacyLevel, 100, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelEntity", "Sort", typeof(System.Int32), false, false, false, false,  (int)PrivacyLevelFieldIndex.Sort, 0, 0, 10);
			this.AddElementFieldInfo("PrivacyLevelEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PrivacyLevelFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PrivacyLevelFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelEntity", "Abrv", typeof(System.String), false, false, false, false,  (int)PrivacyLevelFieldIndex.Abrv, 50, 0, 0);
		}
		/// <summary>Inits PrivacyLevelDefinitionEntity's FieldInfo objects</summary>
		private void InitPrivacyLevelDefinitionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PrivacyLevelDefinitionFieldIndex), "PrivacyLevelDefinitionEntity");
			this.AddElementFieldInfo("PrivacyLevelDefinitionEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)PrivacyLevelDefinitionFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelDefinitionEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)PrivacyLevelDefinitionFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelDefinitionEntity", "ObjectName", typeof(System.String), false, false, false, false,  (int)PrivacyLevelDefinitionFieldIndex.ObjectName, 150, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelDefinitionEntity", "FieldName", typeof(System.String), false, false, false, false,  (int)PrivacyLevelDefinitionFieldIndex.FieldName, 150, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelDefinitionEntity", "PrivacyLevelId", typeof(System.Guid), false, true, false, false,  (int)PrivacyLevelDefinitionFieldIndex.PrivacyLevelId, 0, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelDefinitionEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PrivacyLevelDefinitionFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("PrivacyLevelDefinitionEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PrivacyLevelDefinitionFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits SnAlbumEntity's FieldInfo objects</summary>
		private void InitSnAlbumEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnAlbumFieldIndex), "SnAlbumEntity");
			this.AddElementFieldInfo("SnAlbumEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnAlbumFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnAlbumEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnAlbumFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnAlbumEntity", "SnGroupId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnAlbumFieldIndex.SnGroupId, 0, 0, 0);
			this.AddElementFieldInfo("SnAlbumEntity", "Name", typeof(System.String), false, false, false, false,  (int)SnAlbumFieldIndex.Name, 1000, 0, 0);
			this.AddElementFieldInfo("SnAlbumEntity", "Description", typeof(System.String), false, false, false, true,  (int)SnAlbumFieldIndex.Description, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnAlbumEntity", "PrivacyLevelId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnAlbumFieldIndex.PrivacyLevelId, 0, 0, 0);
			this.AddElementFieldInfo("SnAlbumEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnAlbumFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnAlbumEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)SnAlbumFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("SnAlbumEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)SnAlbumFieldIndex.LanguageId, 0, 0, 0);
		}
		/// <summary>Inits SnBlockUserEntity's FieldInfo objects</summary>
		private void InitSnBlockUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnBlockUserFieldIndex), "SnBlockUserEntity");
			this.AddElementFieldInfo("SnBlockUserEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnBlockUserFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnBlockUserEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnBlockUserFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnBlockUserEntity", "BlockedUserId", typeof(System.Guid), false, true, false, false,  (int)SnBlockUserFieldIndex.BlockedUserId, 0, 0, 0);
			this.AddElementFieldInfo("SnBlockUserEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnBlockUserFieldIndex.DateCreated, 0, 0, 0);
		}
		/// <summary>Inits SnCommentEntity's FieldInfo objects</summary>
		private void InitSnCommentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnCommentFieldIndex), "SnCommentEntity");
			this.AddElementFieldInfo("SnCommentEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnCommentFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnCommentFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "RelationshipId", typeof(System.Guid), false, true, false, false,  (int)SnCommentFieldIndex.RelationshipId, 0, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "Comment", typeof(System.String), false, false, false, true,  (int)SnCommentFieldIndex.Comment, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnCommentFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "Author", typeof(System.String), false, false, false, true,  (int)SnCommentFieldIndex.Author, 255, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "Email", typeof(System.String), false, false, false, true,  (int)SnCommentFieldIndex.Email, 255, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "Website", typeof(System.String), false, false, false, true,  (int)SnCommentFieldIndex.Website, 500, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "Ip", typeof(System.String), false, false, false, true,  (int)SnCommentFieldIndex.Ip, 50, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "Referrer", typeof(System.String), false, false, false, true,  (int)SnCommentFieldIndex.Referrer, 500, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "UserAgent", typeof(System.String), false, false, false, true,  (int)SnCommentFieldIndex.UserAgent, 255, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "IsApproved", typeof(System.Boolean), false, false, false, false,  (int)SnCommentFieldIndex.IsApproved, 0, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "IsSpam", typeof(System.Boolean), false, false, false, false,  (int)SnCommentFieldIndex.IsSpam, 0, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "Spaminess", typeof(System.Decimal), false, false, false, false,  (int)SnCommentFieldIndex.Spaminess, 0, 0, 18);
			this.AddElementFieldInfo("SnCommentEntity", "Signature", typeof(System.String), false, false, false, true,  (int)SnCommentFieldIndex.Signature, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnCommentEntity", "Rating", typeof(System.Double), false, false, false, false,  (int)SnCommentFieldIndex.Rating, 0, 0, 38);
		}
		/// <summary>Inits SnDiscussionBoardEntity's FieldInfo objects</summary>
		private void InitSnDiscussionBoardEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnDiscussionBoardFieldIndex), "SnDiscussionBoardEntity");
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnDiscussionBoardFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)SnDiscussionBoardFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)SnDiscussionBoardFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "SnGroupId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnDiscussionBoardFieldIndex.SnGroupId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "Name", typeof(System.String), false, false, false, false,  (int)SnDiscussionBoardFieldIndex.Name, 500, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnDiscussionBoardFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnDiscussionBoardFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "Description", typeof(System.String), false, false, false, true,  (int)SnDiscussionBoardFieldIndex.Description, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "DailyReportSentOn", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnDiscussionBoardFieldIndex.DailyReportSentOn, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "IsClosed", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionBoardFieldIndex.IsClosed, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "IsPinned", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionBoardFieldIndex.IsPinned, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "PinnedOn", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnDiscussionBoardFieldIndex.PinnedOn, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardEntity", "PinnedByUserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnDiscussionBoardFieldIndex.PinnedByUserId, 0, 0, 0);
		}
		/// <summary>Inits SnDiscussionBoardInRoleEntity's FieldInfo objects</summary>
		private void InitSnDiscussionBoardInRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnDiscussionBoardInRoleFieldIndex), "SnDiscussionBoardInRoleEntity");
			this.AddElementFieldInfo("SnDiscussionBoardInRoleEntity", "BoardId", typeof(System.Guid), true, true, false, false,  (int)SnDiscussionBoardInRoleFieldIndex.BoardId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardInRoleEntity", "RoleId", typeof(System.Guid), true, true, false, false,  (int)SnDiscussionBoardInRoleFieldIndex.RoleId, 0, 0, 0);
		}
		/// <summary>Inits SnDiscussionBoardModeratorEntity's FieldInfo objects</summary>
		private void InitSnDiscussionBoardModeratorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnDiscussionBoardModeratorFieldIndex), "SnDiscussionBoardModeratorEntity");
			this.AddElementFieldInfo("SnDiscussionBoardModeratorEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnDiscussionBoardModeratorFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardModeratorEntity", "SnDiscussionBoardId", typeof(System.Guid), false, true, false, false,  (int)SnDiscussionBoardModeratorFieldIndex.SnDiscussionBoardId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionBoardModeratorEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnDiscussionBoardModeratorFieldIndex.UserId, 0, 0, 0);
		}
		/// <summary>Inits SnDiscussionMessageEntity's FieldInfo objects</summary>
		private void InitSnDiscussionMessageEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnDiscussionMessageFieldIndex), "SnDiscussionMessageEntity");
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnDiscussionMessageFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "SnDiscussionTopicId", typeof(System.Guid), false, true, false, false,  (int)SnDiscussionMessageFieldIndex.SnDiscussionTopicId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnDiscussionMessageFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "Message", typeof(System.String), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.Message, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnDiscussionMessageFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "LastModifiedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.LastModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "Ip", typeof(System.String), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.Ip, 50, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "Referrer", typeof(System.String), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.Referrer, 500, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "UserAgent", typeof(System.String), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.UserAgent, 255, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "IsApproved", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionMessageFieldIndex.IsApproved, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "IsSpam", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionMessageFieldIndex.IsSpam, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "Spaminess", typeof(System.Decimal), false, false, false, false,  (int)SnDiscussionMessageFieldIndex.Spaminess, 0, 0, 18);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "Signature", typeof(System.String), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.Signature, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "IsAnswer", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.IsAnswer, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "AdminAttentionRequired", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.AdminAttentionRequired, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "AdminAttentionReportedByUserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnDiscussionMessageFieldIndex.AdminAttentionReportedByUserId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "AdminAttentionReportedOn", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.AdminAttentionReportedOn, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "AdminAttentionApproved", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.AdminAttentionApproved, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "AdminAttentionReason", typeof(System.String), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.AdminAttentionReason, 300, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "IsDeleteRequested", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionMessageFieldIndex.IsDeleteRequested, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "DeleteRequestedOn", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.DeleteRequestedOn, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "DeleteRequestedByUserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnDiscussionMessageFieldIndex.DeleteRequestedByUserId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "IsDeleteApproved", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.IsDeleteApproved, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "DeleteDisapprovedReason", typeof(System.String), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.DeleteDisapprovedReason, 300, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "IsPinned", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionMessageFieldIndex.IsPinned, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "PinnedOn", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnDiscussionMessageFieldIndex.PinnedOn, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionMessageEntity", "PinnedByUserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnDiscussionMessageFieldIndex.PinnedByUserId, 0, 0, 0);
		}
		/// <summary>Inits SnDiscussionTopicEntity's FieldInfo objects</summary>
		private void InitSnDiscussionTopicEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnDiscussionTopicFieldIndex), "SnDiscussionTopicEntity");
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnDiscussionTopicFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "SnDiscussionBoardId", typeof(System.Guid), false, true, false, false,  (int)SnDiscussionTopicFieldIndex.SnDiscussionBoardId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "Title", typeof(System.String), false, false, false, false,  (int)SnDiscussionTopicFieldIndex.Title, 500, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnDiscussionTopicFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnDiscussionTopicFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "Ip", typeof(System.String), false, false, false, true,  (int)SnDiscussionTopicFieldIndex.Ip, 50, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "Referrer", typeof(System.String), false, false, false, true,  (int)SnDiscussionTopicFieldIndex.Referrer, 500, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "UserAgent", typeof(System.String), false, false, false, true,  (int)SnDiscussionTopicFieldIndex.UserAgent, 255, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "IsApproved", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionTopicFieldIndex.IsApproved, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "IsSpam", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionTopicFieldIndex.IsSpam, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "Spaminess", typeof(System.Decimal), false, false, false, false,  (int)SnDiscussionTopicFieldIndex.Spaminess, 0, 0, 18);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "Signature", typeof(System.String), false, false, false, true,  (int)SnDiscussionTopicFieldIndex.Signature, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "TimesViewed", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SnDiscussionTopicFieldIndex.TimesViewed, 0, 0, 10);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "IsClosed", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionTopicFieldIndex.IsClosed, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "IsPinned", typeof(System.Boolean), false, false, false, false,  (int)SnDiscussionTopicFieldIndex.IsPinned, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "PinnedOn", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnDiscussionTopicFieldIndex.PinnedOn, 0, 0, 0);
			this.AddElementFieldInfo("SnDiscussionTopicEntity", "PinnedByUserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnDiscussionTopicFieldIndex.PinnedByUserId, 0, 0, 0);
		}
		/// <summary>Inits SnEventEntity's FieldInfo objects</summary>
		private void InitSnEventEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnEventFieldIndex), "SnEventEntity");
			this.AddElementFieldInfo("SnEventEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnEventFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnEventFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "EventTypeId", typeof(System.Guid), false, true, false, false,  (int)SnEventFieldIndex.EventTypeId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnEventFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "FriendId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnEventFieldIndex.FriendId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "BlogPostId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnEventFieldIndex.BlogPostId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "SnGroupId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnEventFieldIndex.SnGroupId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "SnAlbumId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnEventFieldIndex.SnAlbumId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "SnFileId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnEventFieldIndex.SnFileId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "SnDiscussionBoardId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnEventFieldIndex.SnDiscussionBoardId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "SnDiscussionTopicId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnEventFieldIndex.SnDiscussionTopicId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "OaConsumerId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnEventFieldIndex.OaConsumerId, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "CustomId1", typeof(Nullable<System.Guid>), false, false, false, true,  (int)SnEventFieldIndex.CustomId1, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "CustomId2", typeof(Nullable<System.Guid>), false, false, false, true,  (int)SnEventFieldIndex.CustomId2, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "CustomId3", typeof(Nullable<System.Guid>), false, false, false, true,  (int)SnEventFieldIndex.CustomId3, 0, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "EventContent", typeof(System.String), false, false, false, true,  (int)SnEventFieldIndex.EventContent, 500, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "PlainEventTitle", typeof(System.String), false, false, false, true,  (int)SnEventFieldIndex.PlainEventTitle, 150, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "PlainEventUrl", typeof(System.String), false, false, false, true,  (int)SnEventFieldIndex.PlainEventUrl, 500, 0, 0);
			this.AddElementFieldInfo("SnEventEntity", "SnNoteId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnEventFieldIndex.SnNoteId, 0, 0, 0);
		}
		/// <summary>Inits SnEventTypeEntity's FieldInfo objects</summary>
		private void InitSnEventTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnEventTypeFieldIndex), "SnEventTypeEntity");
			this.AddElementFieldInfo("SnEventTypeEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnEventTypeFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnEventTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)SnEventTypeFieldIndex.Name, 100, 0, 0);
		}
		/// <summary>Inits SnFileEntity's FieldInfo objects</summary>
		private void InitSnFileEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnFileFieldIndex), "SnFileEntity");
			this.AddElementFieldInfo("SnFileEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnFileFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnFileFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "RelationshipId", typeof(System.Guid), false, true, false, false,  (int)SnFileFieldIndex.RelationshipId, 0, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "Name", typeof(System.String), false, false, false, true,  (int)SnFileFieldIndex.Name, 500, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "Url", typeof(System.String), false, false, false, false,  (int)SnFileFieldIndex.Url, 2000, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "Description", typeof(System.String), false, false, false, true,  (int)SnFileFieldIndex.Description, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "PrivacyLevelId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnFileFieldIndex.PrivacyLevelId, 0, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "ThumbnailUrl", typeof(System.String), false, false, false, true,  (int)SnFileFieldIndex.ThumbnailUrl, 2000, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnFileFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "AlbumId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnFileFieldIndex.AlbumId, 0, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "IsAlbumCover", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)SnFileFieldIndex.IsAlbumCover, 0, 0, 0);
			this.AddElementFieldInfo("SnFileEntity", "SortOrder", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SnFileFieldIndex.SortOrder, 0, 0, 10);
			this.AddElementFieldInfo("SnFileEntity", "Rating", typeof(System.Double), false, false, false, false,  (int)SnFileFieldIndex.Rating, 0, 0, 38);
		}
		/// <summary>Inits SnFriendEntity's FieldInfo objects</summary>
		private void InitSnFriendEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnFriendFieldIndex), "SnFriendEntity");
			this.AddElementFieldInfo("SnFriendEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnFriendFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnFriendFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendEntity", "FriendUserId", typeof(System.Guid), false, true, false, false,  (int)SnFriendFieldIndex.FriendUserId, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnFriendFieldIndex.DateCreated, 0, 0, 0);
		}
		/// <summary>Inits SnFriendListEntity's FieldInfo objects</summary>
		private void InitSnFriendListEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnFriendListFieldIndex), "SnFriendListEntity");
			this.AddElementFieldInfo("SnFriendListEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnFriendListFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendListEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnFriendListFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendListEntity", "Name", typeof(System.String), false, false, false, false,  (int)SnFriendListFieldIndex.Name, 200, 0, 0);
			this.AddElementFieldInfo("SnFriendListEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnFriendListFieldIndex.DateCreated, 0, 0, 0);
		}
		/// <summary>Inits SnFriendListMemberEntity's FieldInfo objects</summary>
		private void InitSnFriendListMemberEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnFriendListMemberFieldIndex), "SnFriendListMemberEntity");
			this.AddElementFieldInfo("SnFriendListMemberEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnFriendListMemberFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendListMemberEntity", "FriendListId", typeof(System.Guid), false, true, false, false,  (int)SnFriendListMemberFieldIndex.FriendListId, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendListMemberEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnFriendListMemberFieldIndex.UserId, 0, 0, 0);
		}
		/// <summary>Inits SnFriendRequestEntity's FieldInfo objects</summary>
		private void InitSnFriendRequestEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnFriendRequestFieldIndex), "SnFriendRequestEntity");
			this.AddElementFieldInfo("SnFriendRequestEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnFriendRequestFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendRequestEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnFriendRequestFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendRequestEntity", "FriendUserId", typeof(System.Guid), false, true, false, false,  (int)SnFriendRequestFieldIndex.FriendUserId, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendRequestEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnFriendRequestFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnFriendRequestEntity", "DateAccepted", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnFriendRequestFieldIndex.DateAccepted, 0, 0, 0);
		}
		/// <summary>Inits SnGroupEntity's FieldInfo objects</summary>
		private void InitSnGroupEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnGroupFieldIndex), "SnGroupEntity");
			this.AddElementFieldInfo("SnGroupEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnGroupFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupEntity", "Name", typeof(System.String), false, false, false, false,  (int)SnGroupFieldIndex.Name, 500, 0, 0);
			this.AddElementFieldInfo("SnGroupEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnGroupFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupEntity", "MemberCount", typeof(System.Int32), false, false, false, false,  (int)SnGroupFieldIndex.MemberCount, 0, 0, 10);
			this.AddElementFieldInfo("SnGroupEntity", "Description", typeof(System.String), false, false, false, true,  (int)SnGroupFieldIndex.Description, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnGroupEntity", "IsPublic", typeof(System.Boolean), false, false, false, false,  (int)SnGroupFieldIndex.IsPublic, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnGroupFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupEntity", "ImageUrl", typeof(System.String), false, false, false, true,  (int)SnGroupFieldIndex.ImageUrl, 500, 0, 0);
			this.AddElementFieldInfo("SnGroupEntity", "GroupCategoryId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnGroupFieldIndex.GroupCategoryId, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupEntity", "Slug", typeof(System.String), false, false, false, true,  (int)SnGroupFieldIndex.Slug, 500, 0, 0);
		}
		/// <summary>Inits SnGroupCategoryEntity's FieldInfo objects</summary>
		private void InitSnGroupCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnGroupCategoryFieldIndex), "SnGroupCategoryEntity");
			this.AddElementFieldInfo("SnGroupCategoryEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnGroupCategoryFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupCategoryEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)SnGroupCategoryFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupCategoryEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)SnGroupCategoryFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupCategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)SnGroupCategoryFieldIndex.Name, 200, 0, 0);
			this.AddElementFieldInfo("SnGroupCategoryEntity", "Slug", typeof(System.String), false, false, false, true,  (int)SnGroupCategoryFieldIndex.Slug, 255, 0, 0);
		}
		/// <summary>Inits SnGroupMemberEntity's FieldInfo objects</summary>
		private void InitSnGroupMemberEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnGroupMemberFieldIndex), "SnGroupMemberEntity");
			this.AddElementFieldInfo("SnGroupMemberEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnGroupMemberFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupMemberEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnGroupMemberFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupMemberEntity", "GroupId", typeof(System.Guid), false, true, false, false,  (int)SnGroupMemberFieldIndex.GroupId, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupMemberEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnGroupMemberFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupMemberEntity", "IsAdmin", typeof(System.Boolean), false, false, false, false,  (int)SnGroupMemberFieldIndex.IsAdmin, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupMemberEntity", "IsApproved", typeof(System.Boolean), false, false, false, false,  (int)SnGroupMemberFieldIndex.IsApproved, 0, 0, 0);
		}
		/// <summary>Inits SnGroupRequestEntity's FieldInfo objects</summary>
		private void InitSnGroupRequestEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnGroupRequestFieldIndex), "SnGroupRequestEntity");
			this.AddElementFieldInfo("SnGroupRequestEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnGroupRequestFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupRequestEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnGroupRequestFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupRequestEntity", "GroupId", typeof(System.Guid), false, true, false, false,  (int)SnGroupRequestFieldIndex.GroupId, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupRequestEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnGroupRequestFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupRequestEntity", "DateAccepted", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnGroupRequestFieldIndex.DateAccepted, 0, 0, 0);
			this.AddElementFieldInfo("SnGroupRequestEntity", "RequestType", typeof(System.Int32), false, false, false, false,  (int)SnGroupRequestFieldIndex.RequestType, 0, 0, 10);
		}
		/// <summary>Inits SnMessageEntity's FieldInfo objects</summary>
		private void InitSnMessageEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnMessageFieldIndex), "SnMessageEntity");
			this.AddElementFieldInfo("SnMessageEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnMessageFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnMessageEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnMessageFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnMessageEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnMessageFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnMessageEntity", "Subject", typeof(System.String), false, false, false, true,  (int)SnMessageFieldIndex.Subject, 255, 0, 0);
			this.AddElementFieldInfo("SnMessageEntity", "Body", typeof(System.String), false, false, false, true,  (int)SnMessageFieldIndex.Body, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnMessageEntity", "InReplyToMessageId", typeof(System.Guid), false, true, false, false,  (int)SnMessageFieldIndex.InReplyToMessageId, 0, 0, 0);
			this.AddElementFieldInfo("SnMessageEntity", "ToList", typeof(System.String), false, false, false, true,  (int)SnMessageFieldIndex.ToList, 2147483647, 0, 0);
		}
		/// <summary>Inits SnMessageRecipientEntity's FieldInfo objects</summary>
		private void InitSnMessageRecipientEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnMessageRecipientFieldIndex), "SnMessageRecipientEntity");
			this.AddElementFieldInfo("SnMessageRecipientEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnMessageRecipientFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnMessageRecipientEntity", "MessageId", typeof(System.Guid), false, true, false, false,  (int)SnMessageRecipientFieldIndex.MessageId, 0, 0, 0);
			this.AddElementFieldInfo("SnMessageRecipientEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnMessageRecipientFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnMessageRecipientEntity", "MessageStatus", typeof(System.Int32), false, false, false, false,  (int)SnMessageRecipientFieldIndex.MessageStatus, 0, 0, 10);
			this.AddElementFieldInfo("SnMessageRecipientEntity", "DateRead", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnMessageRecipientFieldIndex.DateRead, 0, 0, 0);
		}
		/// <summary>Inits SnNoteEntity's FieldInfo objects</summary>
		private void InitSnNoteEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnNoteFieldIndex), "SnNoteEntity");
			this.AddElementFieldInfo("SnNoteEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnNoteFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnNoteEntity", "ApplicationId", typeof(System.Guid), false, true, false, false,  (int)SnNoteFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("SnNoteEntity", "LanguageId", typeof(System.Guid), false, true, false, false,  (int)SnNoteFieldIndex.LanguageId, 0, 0, 0);
			this.AddElementFieldInfo("SnNoteEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)SnNoteFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnNoteEntity", "GroupId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnNoteFieldIndex.GroupId, 0, 0, 0);
			this.AddElementFieldInfo("SnNoteEntity", "NoteContent", typeof(System.String), false, false, false, true,  (int)SnNoteFieldIndex.NoteContent, 2147483647, 0, 0);
			this.AddElementFieldInfo("SnNoteEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)SnNoteFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("SnNoteEntity", "Title", typeof(System.String), false, false, false, true,  (int)SnNoteFieldIndex.Title, 500, 0, 0);
			this.AddElementFieldInfo("SnNoteEntity", "Rating", typeof(System.Double), false, false, false, false,  (int)SnNoteFieldIndex.Rating, 0, 0, 38);
			this.AddElementFieldInfo("SnNoteEntity", "PostToUserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnNoteFieldIndex.PostToUserId, 0, 0, 0);
			this.AddElementFieldInfo("SnNoteEntity", "PrivacyLevelId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnNoteFieldIndex.PrivacyLevelId, 0, 0, 0);
		}
		/// <summary>Inits SnRatingEntity's FieldInfo objects</summary>
		private void InitSnRatingEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnRatingFieldIndex), "SnRatingEntity");
			this.AddElementFieldInfo("SnRatingEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnRatingFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnRatingEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRatingFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnRatingEntity", "RelationshipId", typeof(System.Guid), false, true, false, false,  (int)SnRatingFieldIndex.RelationshipId, 0, 0, 0);
			this.AddElementFieldInfo("SnRatingEntity", "DateEntered", typeof(System.DateTime), false, false, false, false,  (int)SnRatingFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("SnRatingEntity", "Rating", typeof(System.Int32), false, false, false, false,  (int)SnRatingFieldIndex.Rating, 0, 0, 10);
		}
		/// <summary>Inits SnRelationshipEntity's FieldInfo objects</summary>
		private void InitSnRelationshipEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnRelationshipFieldIndex), "SnRelationshipEntity");
			this.AddElementFieldInfo("SnRelationshipEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnRelationshipFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "NoteId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.NoteId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "FileId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.FileId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "AlbumId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.AlbumId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "BlogPostId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.BlogPostId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "MessageId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.MessageId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "DiscussionMessageId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.DiscussionMessageId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "CustomId1", typeof(Nullable<System.Guid>), false, false, false, true,  (int)SnRelationshipFieldIndex.CustomId1, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "CustomId2", typeof(Nullable<System.Guid>), false, false, false, true,  (int)SnRelationshipFieldIndex.CustomId2, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "CustomId3", typeof(Nullable<System.Guid>), false, false, false, true,  (int)SnRelationshipFieldIndex.CustomId3, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "DiscussionBoardId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.DiscussionBoardId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "DiscussionTopicId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.DiscussionTopicId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "DocumentId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.DocumentId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "NewsItemId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.NewsItemId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "ListItemId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.ListItemId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "BlogId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.BlogId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "ApplicationId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.ApplicationId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "CalendarEventId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.CalendarEventId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "CampaignId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.CampaignId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "PageId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.PageId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "NewsCategoryId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.NewsCategoryId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "NewsletterId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.NewsletterId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "PollId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.PollId, 0, 0, 0);
			this.AddElementFieldInfo("SnRelationshipEntity", "GroupId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnRelationshipFieldIndex.GroupId, 0, 0, 0);
		}
		/// <summary>Inits SnSubscriberEntity's FieldInfo objects</summary>
		private void InitSnSubscriberEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnSubscriberFieldIndex), "SnSubscriberEntity");
			this.AddElementFieldInfo("SnSubscriberEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnSubscriberFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnSubscriberEntity", "RelationshipId", typeof(System.Guid), false, true, false, false,  (int)SnSubscriberFieldIndex.RelationshipId, 0, 0, 0);
			this.AddElementFieldInfo("SnSubscriberEntity", "UserId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)SnSubscriberFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("SnSubscriberEntity", "Email", typeof(System.String), false, false, false, true,  (int)SnSubscriberFieldIndex.Email, 250, 0, 0);
			this.AddElementFieldInfo("SnSubscriberEntity", "SubscriptionDate", typeof(System.DateTime), false, false, false, false,  (int)SnSubscriberFieldIndex.SubscriptionDate, 0, 0, 0);
			this.AddElementFieldInfo("SnSubscriberEntity", "Active", typeof(System.Boolean), false, false, false, false,  (int)SnSubscriberFieldIndex.Active, 0, 0, 0);
			this.AddElementFieldInfo("SnSubscriberEntity", "SubscriptionOrder", typeof(System.Int32), false, false, true, false,  (int)SnSubscriberFieldIndex.SubscriptionOrder, 0, 0, 10);
			this.AddElementFieldInfo("SnSubscriberEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SnSubscriberFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits SnTagEntity's FieldInfo objects</summary>
		private void InitSnTagEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SnTagFieldIndex), "SnTagEntity");
			this.AddElementFieldInfo("SnTagEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)SnTagFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("SnTagEntity", "RelationshipId", typeof(System.Guid), false, true, false, false,  (int)SnTagFieldIndex.RelationshipId, 0, 0, 0);
			this.AddElementFieldInfo("SnTagEntity", "Tag", typeof(System.String), false, false, false, false,  (int)SnTagFieldIndex.Tag, 200, 0, 0);
			this.AddElementFieldInfo("SnTagEntity", "Slug", typeof(System.String), false, false, false, false,  (int)SnTagFieldIndex.Slug, 200, 0, 0);
			this.AddElementFieldInfo("SnTagEntity", "SortOrder", typeof(System.Int32), false, false, false, false,  (int)SnTagFieldIndex.SortOrder, 0, 0, 10);
		}
		/// <summary>Inits TermsAndConditionsEntity's FieldInfo objects</summary>
		private void InitTermsAndConditionsEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TermsAndConditionsFieldIndex), "TermsAndConditionsEntity");
			this.AddElementFieldInfo("TermsAndConditionsEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)TermsAndConditionsFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("TermsAndConditionsEntity", "Terms", typeof(System.String), false, false, false, false,  (int)TermsAndConditionsFieldIndex.Terms, 2147483647, 0, 0);
			this.AddElementFieldInfo("TermsAndConditionsEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TermsAndConditionsFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("TermsAndConditionsEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TermsAndConditionsFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits UserAvatarEntity's FieldInfo objects</summary>
		private void InitUserAvatarEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserAvatarFieldIndex), "UserAvatarEntity");
			this.AddElementFieldInfo("UserAvatarEntity", "Id", typeof(System.Guid), true, true, false, false,  (int)UserAvatarFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("UserAvatarEntity", "Avatar", typeof(System.Byte[]), false, false, false, false,  (int)UserAvatarFieldIndex.Avatar, 2147483647, 0, 0);
			this.AddElementFieldInfo("UserAvatarEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserAvatarFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("UserAvatarEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserAvatarFieldIndex.DateModified, 0, 0, 0);
		}
		/// <summary>Inits UserProfileEntity's FieldInfo objects</summary>
		private void InitUserProfileEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserProfileFieldIndex), "UserProfileEntity");
			this.AddElementFieldInfo("UserProfileEntity", "Id", typeof(System.Guid), true, true, false, false,  (int)UserProfileFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "FirstName", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.FirstName, 250, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "LastName", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.LastName, 250, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "BirthDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserProfileFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "Address", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.Address, 250, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "City", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.City, 250, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "ZipCode", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.ZipCode, 250, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "Country", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.Country, 250, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "AboutMySelf", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.AboutMySelf, 500, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "WebSites", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.WebSites, 500, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "EmailVerified", typeof(System.Boolean), false, false, false, false,  (int)UserProfileFieldIndex.EmailVerified, 0, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "MyStatus", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.MyStatus, 500, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "MyStatusPrivacyLevelId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)UserProfileFieldIndex.MyStatusPrivacyLevelId, 0, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "TermsAndConditionsId", typeof(Nullable<System.Guid>), false, true, false, true,  (int)UserProfileFieldIndex.TermsAndConditionsId, 0, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "TermsAndConditionsAgreedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserProfileFieldIndex.TermsAndConditionsAgreedDate, 0, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "DateEntered", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserProfileFieldIndex.DateEntered, 0, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "DateModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserProfileFieldIndex.DateModified, 0, 0, 0);
			this.AddElementFieldInfo("UserProfileEntity", "ReputationScore", typeof(Nullable<System.Int32>), false, false, false, true,  (int)UserProfileFieldIndex.ReputationScore, 0, 0, 10);
			this.AddElementFieldInfo("UserProfileEntity", "TimeZoneId", typeof(System.String), false, false, false, true,  (int)UserProfileFieldIndex.TimeZoneId, 250, 0, 0);
		}
		/// <summary>Inits UserSocialIdentityEntity's FieldInfo objects</summary>
		private void InitUserSocialIdentityEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserSocialIdentityFieldIndex), "UserSocialIdentityEntity");
			this.AddElementFieldInfo("UserSocialIdentityEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)UserSocialIdentityFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("UserSocialIdentityEntity", "UserId", typeof(System.Guid), false, true, false, false,  (int)UserSocialIdentityFieldIndex.UserId, 0, 0, 0);
			this.AddElementFieldInfo("UserSocialIdentityEntity", "ProviderName", typeof(System.String), false, false, false, false,  (int)UserSocialIdentityFieldIndex.ProviderName, 50, 0, 0);
			this.AddElementFieldInfo("UserSocialIdentityEntity", "ProviderUserId", typeof(System.String), false, false, false, false,  (int)UserSocialIdentityFieldIndex.ProviderUserId, 50, 0, 0);
		}
		/// <summary>Inits VersionEntity's FieldInfo objects</summary>
		private void InitVersionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(VersionFieldIndex), "VersionEntity");
			this.AddElementFieldInfo("VersionEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)VersionFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("VersionEntity", "Version", typeof(System.String), false, false, false, false,  (int)VersionFieldIndex.Version, 50, 0, 0);
			this.AddElementFieldInfo("VersionEntity", "Comment", typeof(System.String), false, false, false, true,  (int)VersionFieldIndex.Comment, 500, 0, 0);
			this.AddElementFieldInfo("VersionEntity", "UpgradeLog", typeof(System.String), false, false, false, true,  (int)VersionFieldIndex.UpgradeLog, 2147483647, 0, 0);
			this.AddElementFieldInfo("VersionEntity", "DateEntered", typeof(System.DateTime), false, false, false, false,  (int)VersionFieldIndex.DateEntered, 0, 0, 0);
		}
		
	}
}




