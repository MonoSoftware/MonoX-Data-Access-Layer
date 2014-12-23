///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: MonoX.TemplateBindings.General
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using MonoSoftware.MonoX.DAL;
using MonoSoftware.MonoX.DAL.HelperClasses;
using MonoSoftware.MonoX.DAL.FactoryClasses;
using MonoSoftware.MonoX.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'AspnetUsers'.<br/><br/></summary>
	[Serializable]
	public partial class AspnetUsersEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<AspnetPersonalizationPerUserEntity> _aspnetPersonalizationPerUser;
		private EntityCollection<AspnetUsersInRolesEntity> _aspnetUsersInRoles;
		private EntityCollection<AuditInfoEntity> _auditInfos;
		private EntityCollection<BlogEntity> _blogs;
		private EntityCollection<BlogEditorEntity> _blogEditors;
		private EntityCollection<BlogPostEntity> _blogPosts;
		private EntityCollection<CalendarEntity> _calendars;
		private EntityCollection<CalendarEventEntity> _calendarEvents;
		private EntityCollection<CalendarModeratorEntity> _calendarModerators;
		private EntityCollection<DocumentEntity> _documents;
		private EntityCollection<ListEntity> _lists;
		private EntityCollection<NewsItemEntity> _newsItems;
		private EntityCollection<NewsletterEntity> _newsletters;
		private EntityCollection<NewsPublishQueueEntity> _newsPublishQueue;
		private EntityCollection<OaTokenEntity> _oaTokens;
		private EntityCollection<PageEntity> _page;
		private EntityCollection<PollEntity> _polls;
		private EntityCollection<PrivacyLevelDefinitionEntity> _privacyLevelDefinition;
		private EntityCollection<SnAlbumEntity> _snAlbums;
		private EntityCollection<SnBlockUserEntity> _snBlockUsers;
		private EntityCollection<SnBlockUserEntity> _snBlockUsers_;
		private EntityCollection<SnCommentEntity> _snComments;
		private EntityCollection<SnDiscussionMessageEntity> _snDiscussionMessage;
		private EntityCollection<SnEventEntity> _snEvents;
		private EntityCollection<SnEventEntity> _snFriendEvents;
		private EntityCollection<SnFileEntity> _snFiles;
		private EntityCollection<SnFriendEntity> _snFriendsUsers;
		private EntityCollection<SnFriendEntity> _snFriendsFriends;
		private EntityCollection<SnFriendListEntity> _snFriendLists;
		private EntityCollection<SnFriendListMemberEntity> _snFriendListMembers;
		private EntityCollection<SnFriendRequestEntity> _snFriendRequestsFriends;
		private EntityCollection<SnFriendRequestEntity> _snFriendRequestsUsers;
		private EntityCollection<SnGroupEntity> _snGroups;
		private EntityCollection<SnGroupMemberEntity> _snGroupMembers;
		private EntityCollection<SnGroupRequestEntity> _snGroupRequests;
		private EntityCollection<SnMessageEntity> _snMessages;
		private EntityCollection<SnMessageRecipientEntity> _snMessageRecipients;
		private EntityCollection<SnNoteEntity> _snNotesPostedTo;
		private EntityCollection<SnNoteEntity> _snNotesAuthoredBy;
		private EntityCollection<SnRatingEntity> _snRating;
		private EntityCollection<SnRelationshipEntity> _snRelationshipss;
		private EntityCollection<SnSubscriberEntity> _snSubscribers;
		private EntityCollection<UserSocialIdentityEntity> _userSocialIdentities;
		private AspnetApplicationsEntity _aspnetApplications;
		private AspnetMembershipEntity _aspnetMembership;
		private AspnetProfileEntity _aspnetProfile;
		private UserAvatarEntity _userAvatar;
		private UserProfileEntity _userProfile;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AspnetApplications</summary>
			public static readonly string AspnetApplications = "AspnetApplications";
			/// <summary>Member name AspnetPersonalizationPerUser</summary>
			public static readonly string AspnetPersonalizationPerUser = "AspnetPersonalizationPerUser";
			/// <summary>Member name AspnetUsersInRoles</summary>
			public static readonly string AspnetUsersInRoles = "AspnetUsersInRoles";
			/// <summary>Member name AuditInfos</summary>
			public static readonly string AuditInfos = "AuditInfos";
			/// <summary>Member name Blogs</summary>
			public static readonly string Blogs = "Blogs";
			/// <summary>Member name BlogEditors</summary>
			public static readonly string BlogEditors = "BlogEditors";
			/// <summary>Member name BlogPosts</summary>
			public static readonly string BlogPosts = "BlogPosts";
			/// <summary>Member name Calendars</summary>
			public static readonly string Calendars = "Calendars";
			/// <summary>Member name CalendarEvents</summary>
			public static readonly string CalendarEvents = "CalendarEvents";
			/// <summary>Member name CalendarModerators</summary>
			public static readonly string CalendarModerators = "CalendarModerators";
			/// <summary>Member name Documents</summary>
			public static readonly string Documents = "Documents";
			/// <summary>Member name Lists</summary>
			public static readonly string Lists = "Lists";
			/// <summary>Member name NewsItems</summary>
			public static readonly string NewsItems = "NewsItems";
			/// <summary>Member name Newsletters</summary>
			public static readonly string Newsletters = "Newsletters";
			/// <summary>Member name NewsPublishQueue</summary>
			public static readonly string NewsPublishQueue = "NewsPublishQueue";
			/// <summary>Member name OaTokens</summary>
			public static readonly string OaTokens = "OaTokens";
			/// <summary>Member name Page</summary>
			public static readonly string Page = "Page";
			/// <summary>Member name Polls</summary>
			public static readonly string Polls = "Polls";
			/// <summary>Member name PrivacyLevelDefinition</summary>
			public static readonly string PrivacyLevelDefinition = "PrivacyLevelDefinition";
			/// <summary>Member name SnAlbums</summary>
			public static readonly string SnAlbums = "SnAlbums";
			/// <summary>Member name SnBlockUsers</summary>
			public static readonly string SnBlockUsers = "SnBlockUsers";
			/// <summary>Member name SnBlockUsers_</summary>
			public static readonly string SnBlockUsers_ = "SnBlockUsers_";
			/// <summary>Member name SnComments</summary>
			public static readonly string SnComments = "SnComments";
			/// <summary>Member name SnDiscussionMessage</summary>
			public static readonly string SnDiscussionMessage = "SnDiscussionMessage";
			/// <summary>Member name SnEvents</summary>
			public static readonly string SnEvents = "SnEvents";
			/// <summary>Member name SnFriendEvents</summary>
			public static readonly string SnFriendEvents = "SnFriendEvents";
			/// <summary>Member name SnFiles</summary>
			public static readonly string SnFiles = "SnFiles";
			/// <summary>Member name SnFriendsUsers</summary>
			public static readonly string SnFriendsUsers = "SnFriendsUsers";
			/// <summary>Member name SnFriendsFriends</summary>
			public static readonly string SnFriendsFriends = "SnFriendsFriends";
			/// <summary>Member name SnFriendLists</summary>
			public static readonly string SnFriendLists = "SnFriendLists";
			/// <summary>Member name SnFriendListMembers</summary>
			public static readonly string SnFriendListMembers = "SnFriendListMembers";
			/// <summary>Member name SnFriendRequestsFriends</summary>
			public static readonly string SnFriendRequestsFriends = "SnFriendRequestsFriends";
			/// <summary>Member name SnFriendRequestsUsers</summary>
			public static readonly string SnFriendRequestsUsers = "SnFriendRequestsUsers";
			/// <summary>Member name SnGroups</summary>
			public static readonly string SnGroups = "SnGroups";
			/// <summary>Member name SnGroupMembers</summary>
			public static readonly string SnGroupMembers = "SnGroupMembers";
			/// <summary>Member name SnGroupRequests</summary>
			public static readonly string SnGroupRequests = "SnGroupRequests";
			/// <summary>Member name SnMessages</summary>
			public static readonly string SnMessages = "SnMessages";
			/// <summary>Member name SnMessageRecipients</summary>
			public static readonly string SnMessageRecipients = "SnMessageRecipients";
			/// <summary>Member name SnNotesPostedTo</summary>
			public static readonly string SnNotesPostedTo = "SnNotesPostedTo";
			/// <summary>Member name SnNotesAuthoredBy</summary>
			public static readonly string SnNotesAuthoredBy = "SnNotesAuthoredBy";
			/// <summary>Member name SnRating</summary>
			public static readonly string SnRating = "SnRating";
			/// <summary>Member name SnRelationshipss</summary>
			public static readonly string SnRelationshipss = "SnRelationshipss";
			/// <summary>Member name SnSubscribers</summary>
			public static readonly string SnSubscribers = "SnSubscribers";
			/// <summary>Member name UserSocialIdentities</summary>
			public static readonly string UserSocialIdentities = "UserSocialIdentities";
			/// <summary>Member name AspnetMembership</summary>
			public static readonly string AspnetMembership = "AspnetMembership";
			/// <summary>Member name AspnetProfile</summary>
			public static readonly string AspnetProfile = "AspnetProfile";
			/// <summary>Member name UserAvatar</summary>
			public static readonly string UserAvatar = "UserAvatar";
			/// <summary>Member name UserProfile</summary>
			public static readonly string UserProfile = "UserProfile";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AspnetUsersEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public AspnetUsersEntity():base("AspnetUsersEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AspnetUsersEntity(IEntityFields2 fields):base("AspnetUsersEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AspnetUsersEntity</param>
		public AspnetUsersEntity(IValidator validator):base("AspnetUsersEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="userId">PK value for AspnetUsers which data should be fetched into this AspnetUsers object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AspnetUsersEntity(System.Guid userId):base("AspnetUsersEntity")
		{
			InitClassEmpty(null, null);
			this.UserId = userId;
		}

		/// <summary> CTor</summary>
		/// <param name="userId">PK value for AspnetUsers which data should be fetched into this AspnetUsers object</param>
		/// <param name="validator">The custom validator object for this AspnetUsersEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AspnetUsersEntity(System.Guid userId, IValidator validator):base("AspnetUsersEntity")
		{
			InitClassEmpty(validator, null);
			this.UserId = userId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AspnetUsersEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_aspnetPersonalizationPerUser = (EntityCollection<AspnetPersonalizationPerUserEntity>)info.GetValue("_aspnetPersonalizationPerUser", typeof(EntityCollection<AspnetPersonalizationPerUserEntity>));
				_aspnetUsersInRoles = (EntityCollection<AspnetUsersInRolesEntity>)info.GetValue("_aspnetUsersInRoles", typeof(EntityCollection<AspnetUsersInRolesEntity>));
				_auditInfos = (EntityCollection<AuditInfoEntity>)info.GetValue("_auditInfos", typeof(EntityCollection<AuditInfoEntity>));
				_blogs = (EntityCollection<BlogEntity>)info.GetValue("_blogs", typeof(EntityCollection<BlogEntity>));
				_blogEditors = (EntityCollection<BlogEditorEntity>)info.GetValue("_blogEditors", typeof(EntityCollection<BlogEditorEntity>));
				_blogPosts = (EntityCollection<BlogPostEntity>)info.GetValue("_blogPosts", typeof(EntityCollection<BlogPostEntity>));
				_calendars = (EntityCollection<CalendarEntity>)info.GetValue("_calendars", typeof(EntityCollection<CalendarEntity>));
				_calendarEvents = (EntityCollection<CalendarEventEntity>)info.GetValue("_calendarEvents", typeof(EntityCollection<CalendarEventEntity>));
				_calendarModerators = (EntityCollection<CalendarModeratorEntity>)info.GetValue("_calendarModerators", typeof(EntityCollection<CalendarModeratorEntity>));
				_documents = (EntityCollection<DocumentEntity>)info.GetValue("_documents", typeof(EntityCollection<DocumentEntity>));
				_lists = (EntityCollection<ListEntity>)info.GetValue("_lists", typeof(EntityCollection<ListEntity>));
				_newsItems = (EntityCollection<NewsItemEntity>)info.GetValue("_newsItems", typeof(EntityCollection<NewsItemEntity>));
				_newsletters = (EntityCollection<NewsletterEntity>)info.GetValue("_newsletters", typeof(EntityCollection<NewsletterEntity>));
				_newsPublishQueue = (EntityCollection<NewsPublishQueueEntity>)info.GetValue("_newsPublishQueue", typeof(EntityCollection<NewsPublishQueueEntity>));
				_oaTokens = (EntityCollection<OaTokenEntity>)info.GetValue("_oaTokens", typeof(EntityCollection<OaTokenEntity>));
				_page = (EntityCollection<PageEntity>)info.GetValue("_page", typeof(EntityCollection<PageEntity>));
				_polls = (EntityCollection<PollEntity>)info.GetValue("_polls", typeof(EntityCollection<PollEntity>));
				_privacyLevelDefinition = (EntityCollection<PrivacyLevelDefinitionEntity>)info.GetValue("_privacyLevelDefinition", typeof(EntityCollection<PrivacyLevelDefinitionEntity>));
				_snAlbums = (EntityCollection<SnAlbumEntity>)info.GetValue("_snAlbums", typeof(EntityCollection<SnAlbumEntity>));
				_snBlockUsers = (EntityCollection<SnBlockUserEntity>)info.GetValue("_snBlockUsers", typeof(EntityCollection<SnBlockUserEntity>));
				_snBlockUsers_ = (EntityCollection<SnBlockUserEntity>)info.GetValue("_snBlockUsers_", typeof(EntityCollection<SnBlockUserEntity>));
				_snComments = (EntityCollection<SnCommentEntity>)info.GetValue("_snComments", typeof(EntityCollection<SnCommentEntity>));
				_snDiscussionMessage = (EntityCollection<SnDiscussionMessageEntity>)info.GetValue("_snDiscussionMessage", typeof(EntityCollection<SnDiscussionMessageEntity>));
				_snEvents = (EntityCollection<SnEventEntity>)info.GetValue("_snEvents", typeof(EntityCollection<SnEventEntity>));
				_snFriendEvents = (EntityCollection<SnEventEntity>)info.GetValue("_snFriendEvents", typeof(EntityCollection<SnEventEntity>));
				_snFiles = (EntityCollection<SnFileEntity>)info.GetValue("_snFiles", typeof(EntityCollection<SnFileEntity>));
				_snFriendsUsers = (EntityCollection<SnFriendEntity>)info.GetValue("_snFriendsUsers", typeof(EntityCollection<SnFriendEntity>));
				_snFriendsFriends = (EntityCollection<SnFriendEntity>)info.GetValue("_snFriendsFriends", typeof(EntityCollection<SnFriendEntity>));
				_snFriendLists = (EntityCollection<SnFriendListEntity>)info.GetValue("_snFriendLists", typeof(EntityCollection<SnFriendListEntity>));
				_snFriendListMembers = (EntityCollection<SnFriendListMemberEntity>)info.GetValue("_snFriendListMembers", typeof(EntityCollection<SnFriendListMemberEntity>));
				_snFriendRequestsFriends = (EntityCollection<SnFriendRequestEntity>)info.GetValue("_snFriendRequestsFriends", typeof(EntityCollection<SnFriendRequestEntity>));
				_snFriendRequestsUsers = (EntityCollection<SnFriendRequestEntity>)info.GetValue("_snFriendRequestsUsers", typeof(EntityCollection<SnFriendRequestEntity>));
				_snGroups = (EntityCollection<SnGroupEntity>)info.GetValue("_snGroups", typeof(EntityCollection<SnGroupEntity>));
				_snGroupMembers = (EntityCollection<SnGroupMemberEntity>)info.GetValue("_snGroupMembers", typeof(EntityCollection<SnGroupMemberEntity>));
				_snGroupRequests = (EntityCollection<SnGroupRequestEntity>)info.GetValue("_snGroupRequests", typeof(EntityCollection<SnGroupRequestEntity>));
				_snMessages = (EntityCollection<SnMessageEntity>)info.GetValue("_snMessages", typeof(EntityCollection<SnMessageEntity>));
				_snMessageRecipients = (EntityCollection<SnMessageRecipientEntity>)info.GetValue("_snMessageRecipients", typeof(EntityCollection<SnMessageRecipientEntity>));
				_snNotesPostedTo = (EntityCollection<SnNoteEntity>)info.GetValue("_snNotesPostedTo", typeof(EntityCollection<SnNoteEntity>));
				_snNotesAuthoredBy = (EntityCollection<SnNoteEntity>)info.GetValue("_snNotesAuthoredBy", typeof(EntityCollection<SnNoteEntity>));
				_snRating = (EntityCollection<SnRatingEntity>)info.GetValue("_snRating", typeof(EntityCollection<SnRatingEntity>));
				_snRelationshipss = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationshipss", typeof(EntityCollection<SnRelationshipEntity>));
				_snSubscribers = (EntityCollection<SnSubscriberEntity>)info.GetValue("_snSubscribers", typeof(EntityCollection<SnSubscriberEntity>));
				_userSocialIdentities = (EntityCollection<UserSocialIdentityEntity>)info.GetValue("_userSocialIdentities", typeof(EntityCollection<UserSocialIdentityEntity>));
				_aspnetApplications = (AspnetApplicationsEntity)info.GetValue("_aspnetApplications", typeof(AspnetApplicationsEntity));
				if(_aspnetApplications!=null)
				{
					_aspnetApplications.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_aspnetMembership = (AspnetMembershipEntity)info.GetValue("_aspnetMembership", typeof(AspnetMembershipEntity));
				if(_aspnetMembership!=null)
				{
					_aspnetMembership.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_aspnetProfile = (AspnetProfileEntity)info.GetValue("_aspnetProfile", typeof(AspnetProfileEntity));
				if(_aspnetProfile!=null)
				{
					_aspnetProfile.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_userAvatar = (UserAvatarEntity)info.GetValue("_userAvatar", typeof(UserAvatarEntity));
				if(_userAvatar!=null)
				{
					_userAvatar.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_userProfile = (UserProfileEntity)info.GetValue("_userProfile", typeof(UserProfileEntity));
				if(_userProfile!=null)
				{
					_userProfile.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AspnetUsersFieldIndex)fieldIndex)
			{
				case AspnetUsersFieldIndex.ApplicationId:
					DesetupSyncAspnetApplications(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "AspnetApplications":
					this.AspnetApplications = (AspnetApplicationsEntity)entity;
					break;
				case "AspnetPersonalizationPerUser":
					this.AspnetPersonalizationPerUser.Add((AspnetPersonalizationPerUserEntity)entity);
					break;
				case "AspnetUsersInRoles":
					this.AspnetUsersInRoles.Add((AspnetUsersInRolesEntity)entity);
					break;
				case "AuditInfos":
					this.AuditInfos.Add((AuditInfoEntity)entity);
					break;
				case "Blogs":
					this.Blogs.Add((BlogEntity)entity);
					break;
				case "BlogEditors":
					this.BlogEditors.Add((BlogEditorEntity)entity);
					break;
				case "BlogPosts":
					this.BlogPosts.Add((BlogPostEntity)entity);
					break;
				case "Calendars":
					this.Calendars.Add((CalendarEntity)entity);
					break;
				case "CalendarEvents":
					this.CalendarEvents.Add((CalendarEventEntity)entity);
					break;
				case "CalendarModerators":
					this.CalendarModerators.Add((CalendarModeratorEntity)entity);
					break;
				case "Documents":
					this.Documents.Add((DocumentEntity)entity);
					break;
				case "Lists":
					this.Lists.Add((ListEntity)entity);
					break;
				case "NewsItems":
					this.NewsItems.Add((NewsItemEntity)entity);
					break;
				case "Newsletters":
					this.Newsletters.Add((NewsletterEntity)entity);
					break;
				case "NewsPublishQueue":
					this.NewsPublishQueue.Add((NewsPublishQueueEntity)entity);
					break;
				case "OaTokens":
					this.OaTokens.Add((OaTokenEntity)entity);
					break;
				case "Page":
					this.Page.Add((PageEntity)entity);
					break;
				case "Polls":
					this.Polls.Add((PollEntity)entity);
					break;
				case "PrivacyLevelDefinition":
					this.PrivacyLevelDefinition.Add((PrivacyLevelDefinitionEntity)entity);
					break;
				case "SnAlbums":
					this.SnAlbums.Add((SnAlbumEntity)entity);
					break;
				case "SnBlockUsers":
					this.SnBlockUsers.Add((SnBlockUserEntity)entity);
					break;
				case "SnBlockUsers_":
					this.SnBlockUsers_.Add((SnBlockUserEntity)entity);
					break;
				case "SnComments":
					this.SnComments.Add((SnCommentEntity)entity);
					break;
				case "SnDiscussionMessage":
					this.SnDiscussionMessage.Add((SnDiscussionMessageEntity)entity);
					break;
				case "SnEvents":
					this.SnEvents.Add((SnEventEntity)entity);
					break;
				case "SnFriendEvents":
					this.SnFriendEvents.Add((SnEventEntity)entity);
					break;
				case "SnFiles":
					this.SnFiles.Add((SnFileEntity)entity);
					break;
				case "SnFriendsUsers":
					this.SnFriendsUsers.Add((SnFriendEntity)entity);
					break;
				case "SnFriendsFriends":
					this.SnFriendsFriends.Add((SnFriendEntity)entity);
					break;
				case "SnFriendLists":
					this.SnFriendLists.Add((SnFriendListEntity)entity);
					break;
				case "SnFriendListMembers":
					this.SnFriendListMembers.Add((SnFriendListMemberEntity)entity);
					break;
				case "SnFriendRequestsFriends":
					this.SnFriendRequestsFriends.Add((SnFriendRequestEntity)entity);
					break;
				case "SnFriendRequestsUsers":
					this.SnFriendRequestsUsers.Add((SnFriendRequestEntity)entity);
					break;
				case "SnGroups":
					this.SnGroups.Add((SnGroupEntity)entity);
					break;
				case "SnGroupMembers":
					this.SnGroupMembers.Add((SnGroupMemberEntity)entity);
					break;
				case "SnGroupRequests":
					this.SnGroupRequests.Add((SnGroupRequestEntity)entity);
					break;
				case "SnMessages":
					this.SnMessages.Add((SnMessageEntity)entity);
					break;
				case "SnMessageRecipients":
					this.SnMessageRecipients.Add((SnMessageRecipientEntity)entity);
					break;
				case "SnNotesPostedTo":
					this.SnNotesPostedTo.Add((SnNoteEntity)entity);
					break;
				case "SnNotesAuthoredBy":
					this.SnNotesAuthoredBy.Add((SnNoteEntity)entity);
					break;
				case "SnRating":
					this.SnRating.Add((SnRatingEntity)entity);
					break;
				case "SnRelationshipss":
					this.SnRelationshipss.Add((SnRelationshipEntity)entity);
					break;
				case "SnSubscribers":
					this.SnSubscribers.Add((SnSubscriberEntity)entity);
					break;
				case "UserSocialIdentities":
					this.UserSocialIdentities.Add((UserSocialIdentityEntity)entity);
					break;
				case "AspnetMembership":
					this.AspnetMembership = (AspnetMembershipEntity)entity;
					break;
				case "AspnetProfile":
					this.AspnetProfile = (AspnetProfileEntity)entity;
					break;
				case "UserAvatar":
					this.UserAvatar = (UserAvatarEntity)entity;
					break;
				case "UserProfile":
					this.UserProfile = (UserProfileEntity)entity;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "AspnetApplications":
					toReturn.Add(Relations.AspnetApplicationsEntityUsingApplicationId);
					break;
				case "AspnetPersonalizationPerUser":
					toReturn.Add(Relations.AspnetPersonalizationPerUserEntityUsingUserId);
					break;
				case "AspnetUsersInRoles":
					toReturn.Add(Relations.AspnetUsersInRolesEntityUsingUserId);
					break;
				case "AuditInfos":
					toReturn.Add(Relations.AuditInfoEntityUsingUserId);
					break;
				case "Blogs":
					toReturn.Add(Relations.BlogEntityUsingUserId);
					break;
				case "BlogEditors":
					toReturn.Add(Relations.BlogEditorEntityUsingUserId);
					break;
				case "BlogPosts":
					toReturn.Add(Relations.BlogPostEntityUsingUserId);
					break;
				case "Calendars":
					toReturn.Add(Relations.CalendarEntityUsingOwnerId);
					break;
				case "CalendarEvents":
					toReturn.Add(Relations.CalendarEventEntityUsingAuthorId);
					break;
				case "CalendarModerators":
					toReturn.Add(Relations.CalendarModeratorEntityUsingUserId);
					break;
				case "Documents":
					toReturn.Add(Relations.DocumentEntityUsingUserId);
					break;
				case "Lists":
					toReturn.Add(Relations.ListEntityUsingUserId);
					break;
				case "NewsItems":
					toReturn.Add(Relations.NewsItemEntityUsingUserId);
					break;
				case "Newsletters":
					toReturn.Add(Relations.NewsletterEntityUsingUserId);
					break;
				case "NewsPublishQueue":
					toReturn.Add(Relations.NewsPublishQueueEntityUsingUserId);
					break;
				case "OaTokens":
					toReturn.Add(Relations.OaTokenEntityUsingUserId);
					break;
				case "Page":
					toReturn.Add(Relations.PageEntityUsingUserId);
					break;
				case "Polls":
					toReturn.Add(Relations.PollEntityUsingUserId);
					break;
				case "PrivacyLevelDefinition":
					toReturn.Add(Relations.PrivacyLevelDefinitionEntityUsingUserId);
					break;
				case "SnAlbums":
					toReturn.Add(Relations.SnAlbumEntityUsingUserId);
					break;
				case "SnBlockUsers":
					toReturn.Add(Relations.SnBlockUserEntityUsingUserId);
					break;
				case "SnBlockUsers_":
					toReturn.Add(Relations.SnBlockUserEntityUsingBlockedUserId);
					break;
				case "SnComments":
					toReturn.Add(Relations.SnCommentEntityUsingUserId);
					break;
				case "SnDiscussionMessage":
					toReturn.Add(Relations.SnDiscussionMessageEntityUsingPinnedByUserId);
					break;
				case "SnEvents":
					toReturn.Add(Relations.SnEventEntityUsingUserId);
					break;
				case "SnFriendEvents":
					toReturn.Add(Relations.SnEventEntityUsingFriendId);
					break;
				case "SnFiles":
					toReturn.Add(Relations.SnFileEntityUsingUserId);
					break;
				case "SnFriendsUsers":
					toReturn.Add(Relations.SnFriendEntityUsingUserId);
					break;
				case "SnFriendsFriends":
					toReturn.Add(Relations.SnFriendEntityUsingFriendUserId);
					break;
				case "SnFriendLists":
					toReturn.Add(Relations.SnFriendListEntityUsingUserId);
					break;
				case "SnFriendListMembers":
					toReturn.Add(Relations.SnFriendListMemberEntityUsingUserId);
					break;
				case "SnFriendRequestsFriends":
					toReturn.Add(Relations.SnFriendRequestEntityUsingFriendUserId);
					break;
				case "SnFriendRequestsUsers":
					toReturn.Add(Relations.SnFriendRequestEntityUsingUserId);
					break;
				case "SnGroups":
					toReturn.Add(Relations.SnGroupEntityUsingUserId);
					break;
				case "SnGroupMembers":
					toReturn.Add(Relations.SnGroupMemberEntityUsingUserId);
					break;
				case "SnGroupRequests":
					toReturn.Add(Relations.SnGroupRequestEntityUsingUserId);
					break;
				case "SnMessages":
					toReturn.Add(Relations.SnMessageEntityUsingUserId);
					break;
				case "SnMessageRecipients":
					toReturn.Add(Relations.SnMessageRecipientEntityUsingUserId);
					break;
				case "SnNotesPostedTo":
					toReturn.Add(Relations.SnNoteEntityUsingUserId);
					break;
				case "SnNotesAuthoredBy":
					toReturn.Add(Relations.SnNoteEntityUsingPostToUserId);
					break;
				case "SnRating":
					toReturn.Add(Relations.SnRatingEntityUsingUserId);
					break;
				case "SnRelationshipss":
					toReturn.Add(Relations.SnRelationshipEntityUsingUserId);
					break;
				case "SnSubscribers":
					toReturn.Add(Relations.SnSubscriberEntityUsingUserId);
					break;
				case "UserSocialIdentities":
					toReturn.Add(Relations.UserSocialIdentityEntityUsingUserId);
					break;
				case "AspnetMembership":
					toReturn.Add(Relations.AspnetMembershipEntityUsingUserId);
					break;
				case "AspnetProfile":
					toReturn.Add(Relations.AspnetProfileEntityUsingUserId);
					break;
				case "UserAvatar":
					toReturn.Add(Relations.UserAvatarEntityUsingId);
					break;
				case "UserProfile":
					toReturn.Add(Relations.UserProfileEntityUsingId);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0+1;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				case "AspnetApplications":
					return true;
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "AspnetApplications":
					SetupSyncAspnetApplications(relatedEntity);
					break;
				case "AspnetPersonalizationPerUser":
					this.AspnetPersonalizationPerUser.Add((AspnetPersonalizationPerUserEntity)relatedEntity);
					break;
				case "AspnetUsersInRoles":
					this.AspnetUsersInRoles.Add((AspnetUsersInRolesEntity)relatedEntity);
					break;
				case "AuditInfos":
					this.AuditInfos.Add((AuditInfoEntity)relatedEntity);
					break;
				case "Blogs":
					this.Blogs.Add((BlogEntity)relatedEntity);
					break;
				case "BlogEditors":
					this.BlogEditors.Add((BlogEditorEntity)relatedEntity);
					break;
				case "BlogPosts":
					this.BlogPosts.Add((BlogPostEntity)relatedEntity);
					break;
				case "Calendars":
					this.Calendars.Add((CalendarEntity)relatedEntity);
					break;
				case "CalendarEvents":
					this.CalendarEvents.Add((CalendarEventEntity)relatedEntity);
					break;
				case "CalendarModerators":
					this.CalendarModerators.Add((CalendarModeratorEntity)relatedEntity);
					break;
				case "Documents":
					this.Documents.Add((DocumentEntity)relatedEntity);
					break;
				case "Lists":
					this.Lists.Add((ListEntity)relatedEntity);
					break;
				case "NewsItems":
					this.NewsItems.Add((NewsItemEntity)relatedEntity);
					break;
				case "Newsletters":
					this.Newsletters.Add((NewsletterEntity)relatedEntity);
					break;
				case "NewsPublishQueue":
					this.NewsPublishQueue.Add((NewsPublishQueueEntity)relatedEntity);
					break;
				case "OaTokens":
					this.OaTokens.Add((OaTokenEntity)relatedEntity);
					break;
				case "Page":
					this.Page.Add((PageEntity)relatedEntity);
					break;
				case "Polls":
					this.Polls.Add((PollEntity)relatedEntity);
					break;
				case "PrivacyLevelDefinition":
					this.PrivacyLevelDefinition.Add((PrivacyLevelDefinitionEntity)relatedEntity);
					break;
				case "SnAlbums":
					this.SnAlbums.Add((SnAlbumEntity)relatedEntity);
					break;
				case "SnBlockUsers":
					this.SnBlockUsers.Add((SnBlockUserEntity)relatedEntity);
					break;
				case "SnBlockUsers_":
					this.SnBlockUsers_.Add((SnBlockUserEntity)relatedEntity);
					break;
				case "SnComments":
					this.SnComments.Add((SnCommentEntity)relatedEntity);
					break;
				case "SnDiscussionMessage":
					this.SnDiscussionMessage.Add((SnDiscussionMessageEntity)relatedEntity);
					break;
				case "SnEvents":
					this.SnEvents.Add((SnEventEntity)relatedEntity);
					break;
				case "SnFriendEvents":
					this.SnFriendEvents.Add((SnEventEntity)relatedEntity);
					break;
				case "SnFiles":
					this.SnFiles.Add((SnFileEntity)relatedEntity);
					break;
				case "SnFriendsUsers":
					this.SnFriendsUsers.Add((SnFriendEntity)relatedEntity);
					break;
				case "SnFriendsFriends":
					this.SnFriendsFriends.Add((SnFriendEntity)relatedEntity);
					break;
				case "SnFriendLists":
					this.SnFriendLists.Add((SnFriendListEntity)relatedEntity);
					break;
				case "SnFriendListMembers":
					this.SnFriendListMembers.Add((SnFriendListMemberEntity)relatedEntity);
					break;
				case "SnFriendRequestsFriends":
					this.SnFriendRequestsFriends.Add((SnFriendRequestEntity)relatedEntity);
					break;
				case "SnFriendRequestsUsers":
					this.SnFriendRequestsUsers.Add((SnFriendRequestEntity)relatedEntity);
					break;
				case "SnGroups":
					this.SnGroups.Add((SnGroupEntity)relatedEntity);
					break;
				case "SnGroupMembers":
					this.SnGroupMembers.Add((SnGroupMemberEntity)relatedEntity);
					break;
				case "SnGroupRequests":
					this.SnGroupRequests.Add((SnGroupRequestEntity)relatedEntity);
					break;
				case "SnMessages":
					this.SnMessages.Add((SnMessageEntity)relatedEntity);
					break;
				case "SnMessageRecipients":
					this.SnMessageRecipients.Add((SnMessageRecipientEntity)relatedEntity);
					break;
				case "SnNotesPostedTo":
					this.SnNotesPostedTo.Add((SnNoteEntity)relatedEntity);
					break;
				case "SnNotesAuthoredBy":
					this.SnNotesAuthoredBy.Add((SnNoteEntity)relatedEntity);
					break;
				case "SnRating":
					this.SnRating.Add((SnRatingEntity)relatedEntity);
					break;
				case "SnRelationshipss":
					this.SnRelationshipss.Add((SnRelationshipEntity)relatedEntity);
					break;
				case "SnSubscribers":
					this.SnSubscribers.Add((SnSubscriberEntity)relatedEntity);
					break;
				case "UserSocialIdentities":
					this.UserSocialIdentities.Add((UserSocialIdentityEntity)relatedEntity);
					break;
				case "AspnetMembership":
					SetupSyncAspnetMembership(relatedEntity);
					break;
				case "AspnetProfile":
					SetupSyncAspnetProfile(relatedEntity);
					break;
				case "UserAvatar":
					SetupSyncUserAvatar(relatedEntity);
					break;
				case "UserProfile":
					SetupSyncUserProfile(relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "AspnetApplications":
					DesetupSyncAspnetApplications(false, true);
					break;
				case "AspnetPersonalizationPerUser":
					this.PerformRelatedEntityRemoval(this.AspnetPersonalizationPerUser, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AspnetUsersInRoles":
					this.PerformRelatedEntityRemoval(this.AspnetUsersInRoles, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AuditInfos":
					this.PerformRelatedEntityRemoval(this.AuditInfos, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Blogs":
					this.PerformRelatedEntityRemoval(this.Blogs, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BlogEditors":
					this.PerformRelatedEntityRemoval(this.BlogEditors, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BlogPosts":
					this.PerformRelatedEntityRemoval(this.BlogPosts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Calendars":
					this.PerformRelatedEntityRemoval(this.Calendars, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CalendarEvents":
					this.PerformRelatedEntityRemoval(this.CalendarEvents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CalendarModerators":
					this.PerformRelatedEntityRemoval(this.CalendarModerators, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Documents":
					this.PerformRelatedEntityRemoval(this.Documents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Lists":
					this.PerformRelatedEntityRemoval(this.Lists, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NewsItems":
					this.PerformRelatedEntityRemoval(this.NewsItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Newsletters":
					this.PerformRelatedEntityRemoval(this.Newsletters, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NewsPublishQueue":
					this.PerformRelatedEntityRemoval(this.NewsPublishQueue, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "OaTokens":
					this.PerformRelatedEntityRemoval(this.OaTokens, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Page":
					this.PerformRelatedEntityRemoval(this.Page, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Polls":
					this.PerformRelatedEntityRemoval(this.Polls, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PrivacyLevelDefinition":
					this.PerformRelatedEntityRemoval(this.PrivacyLevelDefinition, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnAlbums":
					this.PerformRelatedEntityRemoval(this.SnAlbums, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnBlockUsers":
					this.PerformRelatedEntityRemoval(this.SnBlockUsers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnBlockUsers_":
					this.PerformRelatedEntityRemoval(this.SnBlockUsers_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnComments":
					this.PerformRelatedEntityRemoval(this.SnComments, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnDiscussionMessage":
					this.PerformRelatedEntityRemoval(this.SnDiscussionMessage, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnEvents":
					this.PerformRelatedEntityRemoval(this.SnEvents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFriendEvents":
					this.PerformRelatedEntityRemoval(this.SnFriendEvents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFiles":
					this.PerformRelatedEntityRemoval(this.SnFiles, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFriendsUsers":
					this.PerformRelatedEntityRemoval(this.SnFriendsUsers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFriendsFriends":
					this.PerformRelatedEntityRemoval(this.SnFriendsFriends, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFriendLists":
					this.PerformRelatedEntityRemoval(this.SnFriendLists, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFriendListMembers":
					this.PerformRelatedEntityRemoval(this.SnFriendListMembers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFriendRequestsFriends":
					this.PerformRelatedEntityRemoval(this.SnFriendRequestsFriends, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFriendRequestsUsers":
					this.PerformRelatedEntityRemoval(this.SnFriendRequestsUsers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnGroups":
					this.PerformRelatedEntityRemoval(this.SnGroups, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnGroupMembers":
					this.PerformRelatedEntityRemoval(this.SnGroupMembers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnGroupRequests":
					this.PerformRelatedEntityRemoval(this.SnGroupRequests, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnMessages":
					this.PerformRelatedEntityRemoval(this.SnMessages, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnMessageRecipients":
					this.PerformRelatedEntityRemoval(this.SnMessageRecipients, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnNotesPostedTo":
					this.PerformRelatedEntityRemoval(this.SnNotesPostedTo, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnNotesAuthoredBy":
					this.PerformRelatedEntityRemoval(this.SnNotesAuthoredBy, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnRating":
					this.PerformRelatedEntityRemoval(this.SnRating, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnRelationshipss":
					this.PerformRelatedEntityRemoval(this.SnRelationshipss, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnSubscribers":
					this.PerformRelatedEntityRemoval(this.SnSubscribers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "UserSocialIdentities":
					this.PerformRelatedEntityRemoval(this.UserSocialIdentities, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AspnetMembership":
					DesetupSyncAspnetMembership(false, true);
					break;
				case "AspnetProfile":
					DesetupSyncAspnetProfile(false, true);
					break;
				case "UserAvatar":
					DesetupSyncUserAvatar(false, true);
					break;
				case "UserProfile":
					DesetupSyncUserProfile(false, true);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_aspnetMembership!=null)
			{
				toReturn.Add(_aspnetMembership);
			}

			if(_aspnetProfile!=null)
			{
				toReturn.Add(_aspnetProfile);
			}

			if(_userAvatar!=null)
			{
				toReturn.Add(_userAvatar);
			}

			if(_userProfile!=null)
			{
				toReturn.Add(_userProfile);
			}

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_aspnetApplications!=null)
			{
				toReturn.Add(_aspnetApplications);
			}








			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.AspnetPersonalizationPerUser);
			toReturn.Add(this.AspnetUsersInRoles);
			toReturn.Add(this.AuditInfos);
			toReturn.Add(this.Blogs);
			toReturn.Add(this.BlogEditors);
			toReturn.Add(this.BlogPosts);
			toReturn.Add(this.Calendars);
			toReturn.Add(this.CalendarEvents);
			toReturn.Add(this.CalendarModerators);
			toReturn.Add(this.Documents);
			toReturn.Add(this.Lists);
			toReturn.Add(this.NewsItems);
			toReturn.Add(this.Newsletters);
			toReturn.Add(this.NewsPublishQueue);
			toReturn.Add(this.OaTokens);
			toReturn.Add(this.Page);
			toReturn.Add(this.Polls);
			toReturn.Add(this.PrivacyLevelDefinition);
			toReturn.Add(this.SnAlbums);
			toReturn.Add(this.SnBlockUsers);
			toReturn.Add(this.SnBlockUsers_);
			toReturn.Add(this.SnComments);
			toReturn.Add(this.SnDiscussionMessage);
			toReturn.Add(this.SnEvents);
			toReturn.Add(this.SnFriendEvents);
			toReturn.Add(this.SnFiles);
			toReturn.Add(this.SnFriendsUsers);
			toReturn.Add(this.SnFriendsFriends);
			toReturn.Add(this.SnFriendLists);
			toReturn.Add(this.SnFriendListMembers);
			toReturn.Add(this.SnFriendRequestsFriends);
			toReturn.Add(this.SnFriendRequestsUsers);
			toReturn.Add(this.SnGroups);
			toReturn.Add(this.SnGroupMembers);
			toReturn.Add(this.SnGroupRequests);
			toReturn.Add(this.SnMessages);
			toReturn.Add(this.SnMessageRecipients);
			toReturn.Add(this.SnNotesPostedTo);
			toReturn.Add(this.SnNotesAuthoredBy);
			toReturn.Add(this.SnRating);
			toReturn.Add(this.SnRelationshipss);
			toReturn.Add(this.SnSubscribers);
			toReturn.Add(this.UserSocialIdentities);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_aspnetPersonalizationPerUser", ((_aspnetPersonalizationPerUser!=null) && (_aspnetPersonalizationPerUser.Count>0) && !this.MarkedForDeletion)?_aspnetPersonalizationPerUser:null);
				info.AddValue("_aspnetUsersInRoles", ((_aspnetUsersInRoles!=null) && (_aspnetUsersInRoles.Count>0) && !this.MarkedForDeletion)?_aspnetUsersInRoles:null);
				info.AddValue("_auditInfos", ((_auditInfos!=null) && (_auditInfos.Count>0) && !this.MarkedForDeletion)?_auditInfos:null);
				info.AddValue("_blogs", ((_blogs!=null) && (_blogs.Count>0) && !this.MarkedForDeletion)?_blogs:null);
				info.AddValue("_blogEditors", ((_blogEditors!=null) && (_blogEditors.Count>0) && !this.MarkedForDeletion)?_blogEditors:null);
				info.AddValue("_blogPosts", ((_blogPosts!=null) && (_blogPosts.Count>0) && !this.MarkedForDeletion)?_blogPosts:null);
				info.AddValue("_calendars", ((_calendars!=null) && (_calendars.Count>0) && !this.MarkedForDeletion)?_calendars:null);
				info.AddValue("_calendarEvents", ((_calendarEvents!=null) && (_calendarEvents.Count>0) && !this.MarkedForDeletion)?_calendarEvents:null);
				info.AddValue("_calendarModerators", ((_calendarModerators!=null) && (_calendarModerators.Count>0) && !this.MarkedForDeletion)?_calendarModerators:null);
				info.AddValue("_documents", ((_documents!=null) && (_documents.Count>0) && !this.MarkedForDeletion)?_documents:null);
				info.AddValue("_lists", ((_lists!=null) && (_lists.Count>0) && !this.MarkedForDeletion)?_lists:null);
				info.AddValue("_newsItems", ((_newsItems!=null) && (_newsItems.Count>0) && !this.MarkedForDeletion)?_newsItems:null);
				info.AddValue("_newsletters", ((_newsletters!=null) && (_newsletters.Count>0) && !this.MarkedForDeletion)?_newsletters:null);
				info.AddValue("_newsPublishQueue", ((_newsPublishQueue!=null) && (_newsPublishQueue.Count>0) && !this.MarkedForDeletion)?_newsPublishQueue:null);
				info.AddValue("_oaTokens", ((_oaTokens!=null) && (_oaTokens.Count>0) && !this.MarkedForDeletion)?_oaTokens:null);
				info.AddValue("_page", ((_page!=null) && (_page.Count>0) && !this.MarkedForDeletion)?_page:null);
				info.AddValue("_polls", ((_polls!=null) && (_polls.Count>0) && !this.MarkedForDeletion)?_polls:null);
				info.AddValue("_privacyLevelDefinition", ((_privacyLevelDefinition!=null) && (_privacyLevelDefinition.Count>0) && !this.MarkedForDeletion)?_privacyLevelDefinition:null);
				info.AddValue("_snAlbums", ((_snAlbums!=null) && (_snAlbums.Count>0) && !this.MarkedForDeletion)?_snAlbums:null);
				info.AddValue("_snBlockUsers", ((_snBlockUsers!=null) && (_snBlockUsers.Count>0) && !this.MarkedForDeletion)?_snBlockUsers:null);
				info.AddValue("_snBlockUsers_", ((_snBlockUsers_!=null) && (_snBlockUsers_.Count>0) && !this.MarkedForDeletion)?_snBlockUsers_:null);
				info.AddValue("_snComments", ((_snComments!=null) && (_snComments.Count>0) && !this.MarkedForDeletion)?_snComments:null);
				info.AddValue("_snDiscussionMessage", ((_snDiscussionMessage!=null) && (_snDiscussionMessage.Count>0) && !this.MarkedForDeletion)?_snDiscussionMessage:null);
				info.AddValue("_snEvents", ((_snEvents!=null) && (_snEvents.Count>0) && !this.MarkedForDeletion)?_snEvents:null);
				info.AddValue("_snFriendEvents", ((_snFriendEvents!=null) && (_snFriendEvents.Count>0) && !this.MarkedForDeletion)?_snFriendEvents:null);
				info.AddValue("_snFiles", ((_snFiles!=null) && (_snFiles.Count>0) && !this.MarkedForDeletion)?_snFiles:null);
				info.AddValue("_snFriendsUsers", ((_snFriendsUsers!=null) && (_snFriendsUsers.Count>0) && !this.MarkedForDeletion)?_snFriendsUsers:null);
				info.AddValue("_snFriendsFriends", ((_snFriendsFriends!=null) && (_snFriendsFriends.Count>0) && !this.MarkedForDeletion)?_snFriendsFriends:null);
				info.AddValue("_snFriendLists", ((_snFriendLists!=null) && (_snFriendLists.Count>0) && !this.MarkedForDeletion)?_snFriendLists:null);
				info.AddValue("_snFriendListMembers", ((_snFriendListMembers!=null) && (_snFriendListMembers.Count>0) && !this.MarkedForDeletion)?_snFriendListMembers:null);
				info.AddValue("_snFriendRequestsFriends", ((_snFriendRequestsFriends!=null) && (_snFriendRequestsFriends.Count>0) && !this.MarkedForDeletion)?_snFriendRequestsFriends:null);
				info.AddValue("_snFriendRequestsUsers", ((_snFriendRequestsUsers!=null) && (_snFriendRequestsUsers.Count>0) && !this.MarkedForDeletion)?_snFriendRequestsUsers:null);
				info.AddValue("_snGroups", ((_snGroups!=null) && (_snGroups.Count>0) && !this.MarkedForDeletion)?_snGroups:null);
				info.AddValue("_snGroupMembers", ((_snGroupMembers!=null) && (_snGroupMembers.Count>0) && !this.MarkedForDeletion)?_snGroupMembers:null);
				info.AddValue("_snGroupRequests", ((_snGroupRequests!=null) && (_snGroupRequests.Count>0) && !this.MarkedForDeletion)?_snGroupRequests:null);
				info.AddValue("_snMessages", ((_snMessages!=null) && (_snMessages.Count>0) && !this.MarkedForDeletion)?_snMessages:null);
				info.AddValue("_snMessageRecipients", ((_snMessageRecipients!=null) && (_snMessageRecipients.Count>0) && !this.MarkedForDeletion)?_snMessageRecipients:null);
				info.AddValue("_snNotesPostedTo", ((_snNotesPostedTo!=null) && (_snNotesPostedTo.Count>0) && !this.MarkedForDeletion)?_snNotesPostedTo:null);
				info.AddValue("_snNotesAuthoredBy", ((_snNotesAuthoredBy!=null) && (_snNotesAuthoredBy.Count>0) && !this.MarkedForDeletion)?_snNotesAuthoredBy:null);
				info.AddValue("_snRating", ((_snRating!=null) && (_snRating.Count>0) && !this.MarkedForDeletion)?_snRating:null);
				info.AddValue("_snRelationshipss", ((_snRelationshipss!=null) && (_snRelationshipss.Count>0) && !this.MarkedForDeletion)?_snRelationshipss:null);
				info.AddValue("_snSubscribers", ((_snSubscribers!=null) && (_snSubscribers.Count>0) && !this.MarkedForDeletion)?_snSubscribers:null);
				info.AddValue("_userSocialIdentities", ((_userSocialIdentities!=null) && (_userSocialIdentities.Count>0) && !this.MarkedForDeletion)?_userSocialIdentities:null);
				info.AddValue("_aspnetApplications", (!this.MarkedForDeletion?_aspnetApplications:null));
				info.AddValue("_aspnetMembership", (!this.MarkedForDeletion?_aspnetMembership:null));
				info.AddValue("_aspnetProfile", (!this.MarkedForDeletion?_aspnetProfile:null));
				info.AddValue("_userAvatar", (!this.MarkedForDeletion?_userAvatar:null));
				info.AddValue("_userProfile", (!this.MarkedForDeletion?_userProfile:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AspnetUsersRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'AspnetPersonalizationPerUser' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetPersonalizationPerUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetPersonalizationPerUserFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'AspnetUsersInRoles' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetUsersInRoles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersInRolesFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'AuditInfo' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAuditInfos()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AuditInfoFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Blog' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBlogs()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BlogFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BlogEditor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBlogEditors()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BlogEditorFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BlogPost' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBlogPosts()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BlogPostFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Calendar' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCalendars()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CalendarFields.OwnerId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CalendarEvent' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCalendarEvents()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CalendarEventFields.AuthorId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CalendarModerator' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCalendarModerators()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CalendarModeratorFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Document' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDocuments()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DocumentFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'List' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoLists()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ListFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsItem' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsItems()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsItemFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Newsletter' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsletters()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsletterFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsPublishQueue' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsPublishQueue()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsPublishQueueFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'OaToken' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOaTokens()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(OaTokenFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Page' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPage()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PageFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Poll' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPolls()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PollFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PrivacyLevelDefinition' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPrivacyLevelDefinition()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PrivacyLevelDefinitionFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnAlbum' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnAlbums()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnAlbumFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnBlockUser' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnBlockUsers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnBlockUserFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnBlockUser' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnBlockUsers_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnBlockUserFields.BlockedUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnComment' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnComments()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnCommentFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnDiscussionMessage' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionMessage()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionMessageFields.PinnedByUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnEvent' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnEvents()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnEventFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnEvent' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFriendEvents()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnEventFields.FriendId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnFile' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFiles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFileFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnFriend' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFriendsUsers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFriendFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnFriend' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFriendsFriends()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFriendFields.FriendUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnFriendList' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFriendLists()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFriendListFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnFriendListMember' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFriendListMembers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFriendListMemberFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnFriendRequest' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFriendRequestsFriends()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFriendRequestFields.FriendUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnFriendRequest' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFriendRequestsUsers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFriendRequestFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnGroup' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnGroups()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnGroupFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnGroupMember' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnGroupMembers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnGroupMemberFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnGroupRequest' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnGroupRequests()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnGroupRequestFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnMessage' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnMessages()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnMessageFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnMessageRecipient' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnMessageRecipients()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnMessageRecipientFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnNote' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnNotesPostedTo()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnNoteFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnNote' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnNotesAuthoredBy()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnNoteFields.PostToUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRating' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRating()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRatingFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationshipss()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnSubscriber' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnSubscribers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnSubscriberFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UserSocialIdentity' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserSocialIdentities()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserSocialIdentityFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetApplications' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetApplications()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetApplicationsFields.ApplicationId, null, ComparisonOperator.Equal, this.ApplicationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetMembership' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetMembership()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetMembershipFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetProfile' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetProfile()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetProfileFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UserAvatar' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserAvatar()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserAvatarFields.Id, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UserProfile' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserProfile()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserProfileFields.Id, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._aspnetPersonalizationPerUser);
			collectionsQueue.Enqueue(this._aspnetUsersInRoles);
			collectionsQueue.Enqueue(this._auditInfos);
			collectionsQueue.Enqueue(this._blogs);
			collectionsQueue.Enqueue(this._blogEditors);
			collectionsQueue.Enqueue(this._blogPosts);
			collectionsQueue.Enqueue(this._calendars);
			collectionsQueue.Enqueue(this._calendarEvents);
			collectionsQueue.Enqueue(this._calendarModerators);
			collectionsQueue.Enqueue(this._documents);
			collectionsQueue.Enqueue(this._lists);
			collectionsQueue.Enqueue(this._newsItems);
			collectionsQueue.Enqueue(this._newsletters);
			collectionsQueue.Enqueue(this._newsPublishQueue);
			collectionsQueue.Enqueue(this._oaTokens);
			collectionsQueue.Enqueue(this._page);
			collectionsQueue.Enqueue(this._polls);
			collectionsQueue.Enqueue(this._privacyLevelDefinition);
			collectionsQueue.Enqueue(this._snAlbums);
			collectionsQueue.Enqueue(this._snBlockUsers);
			collectionsQueue.Enqueue(this._snBlockUsers_);
			collectionsQueue.Enqueue(this._snComments);
			collectionsQueue.Enqueue(this._snDiscussionMessage);
			collectionsQueue.Enqueue(this._snEvents);
			collectionsQueue.Enqueue(this._snFriendEvents);
			collectionsQueue.Enqueue(this._snFiles);
			collectionsQueue.Enqueue(this._snFriendsUsers);
			collectionsQueue.Enqueue(this._snFriendsFriends);
			collectionsQueue.Enqueue(this._snFriendLists);
			collectionsQueue.Enqueue(this._snFriendListMembers);
			collectionsQueue.Enqueue(this._snFriendRequestsFriends);
			collectionsQueue.Enqueue(this._snFriendRequestsUsers);
			collectionsQueue.Enqueue(this._snGroups);
			collectionsQueue.Enqueue(this._snGroupMembers);
			collectionsQueue.Enqueue(this._snGroupRequests);
			collectionsQueue.Enqueue(this._snMessages);
			collectionsQueue.Enqueue(this._snMessageRecipients);
			collectionsQueue.Enqueue(this._snNotesPostedTo);
			collectionsQueue.Enqueue(this._snNotesAuthoredBy);
			collectionsQueue.Enqueue(this._snRating);
			collectionsQueue.Enqueue(this._snRelationshipss);
			collectionsQueue.Enqueue(this._snSubscribers);
			collectionsQueue.Enqueue(this._userSocialIdentities);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._aspnetPersonalizationPerUser = (EntityCollection<AspnetPersonalizationPerUserEntity>) collectionsQueue.Dequeue();
			this._aspnetUsersInRoles = (EntityCollection<AspnetUsersInRolesEntity>) collectionsQueue.Dequeue();
			this._auditInfos = (EntityCollection<AuditInfoEntity>) collectionsQueue.Dequeue();
			this._blogs = (EntityCollection<BlogEntity>) collectionsQueue.Dequeue();
			this._blogEditors = (EntityCollection<BlogEditorEntity>) collectionsQueue.Dequeue();
			this._blogPosts = (EntityCollection<BlogPostEntity>) collectionsQueue.Dequeue();
			this._calendars = (EntityCollection<CalendarEntity>) collectionsQueue.Dequeue();
			this._calendarEvents = (EntityCollection<CalendarEventEntity>) collectionsQueue.Dequeue();
			this._calendarModerators = (EntityCollection<CalendarModeratorEntity>) collectionsQueue.Dequeue();
			this._documents = (EntityCollection<DocumentEntity>) collectionsQueue.Dequeue();
			this._lists = (EntityCollection<ListEntity>) collectionsQueue.Dequeue();
			this._newsItems = (EntityCollection<NewsItemEntity>) collectionsQueue.Dequeue();
			this._newsletters = (EntityCollection<NewsletterEntity>) collectionsQueue.Dequeue();
			this._newsPublishQueue = (EntityCollection<NewsPublishQueueEntity>) collectionsQueue.Dequeue();
			this._oaTokens = (EntityCollection<OaTokenEntity>) collectionsQueue.Dequeue();
			this._page = (EntityCollection<PageEntity>) collectionsQueue.Dequeue();
			this._polls = (EntityCollection<PollEntity>) collectionsQueue.Dequeue();
			this._privacyLevelDefinition = (EntityCollection<PrivacyLevelDefinitionEntity>) collectionsQueue.Dequeue();
			this._snAlbums = (EntityCollection<SnAlbumEntity>) collectionsQueue.Dequeue();
			this._snBlockUsers = (EntityCollection<SnBlockUserEntity>) collectionsQueue.Dequeue();
			this._snBlockUsers_ = (EntityCollection<SnBlockUserEntity>) collectionsQueue.Dequeue();
			this._snComments = (EntityCollection<SnCommentEntity>) collectionsQueue.Dequeue();
			this._snDiscussionMessage = (EntityCollection<SnDiscussionMessageEntity>) collectionsQueue.Dequeue();
			this._snEvents = (EntityCollection<SnEventEntity>) collectionsQueue.Dequeue();
			this._snFriendEvents = (EntityCollection<SnEventEntity>) collectionsQueue.Dequeue();
			this._snFiles = (EntityCollection<SnFileEntity>) collectionsQueue.Dequeue();
			this._snFriendsUsers = (EntityCollection<SnFriendEntity>) collectionsQueue.Dequeue();
			this._snFriendsFriends = (EntityCollection<SnFriendEntity>) collectionsQueue.Dequeue();
			this._snFriendLists = (EntityCollection<SnFriendListEntity>) collectionsQueue.Dequeue();
			this._snFriendListMembers = (EntityCollection<SnFriendListMemberEntity>) collectionsQueue.Dequeue();
			this._snFriendRequestsFriends = (EntityCollection<SnFriendRequestEntity>) collectionsQueue.Dequeue();
			this._snFriendRequestsUsers = (EntityCollection<SnFriendRequestEntity>) collectionsQueue.Dequeue();
			this._snGroups = (EntityCollection<SnGroupEntity>) collectionsQueue.Dequeue();
			this._snGroupMembers = (EntityCollection<SnGroupMemberEntity>) collectionsQueue.Dequeue();
			this._snGroupRequests = (EntityCollection<SnGroupRequestEntity>) collectionsQueue.Dequeue();
			this._snMessages = (EntityCollection<SnMessageEntity>) collectionsQueue.Dequeue();
			this._snMessageRecipients = (EntityCollection<SnMessageRecipientEntity>) collectionsQueue.Dequeue();
			this._snNotesPostedTo = (EntityCollection<SnNoteEntity>) collectionsQueue.Dequeue();
			this._snNotesAuthoredBy = (EntityCollection<SnNoteEntity>) collectionsQueue.Dequeue();
			this._snRating = (EntityCollection<SnRatingEntity>) collectionsQueue.Dequeue();
			this._snRelationshipss = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();
			this._snSubscribers = (EntityCollection<SnSubscriberEntity>) collectionsQueue.Dequeue();
			this._userSocialIdentities = (EntityCollection<UserSocialIdentityEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._aspnetPersonalizationPerUser != null);
			toReturn |=(this._aspnetUsersInRoles != null);
			toReturn |=(this._auditInfos != null);
			toReturn |=(this._blogs != null);
			toReturn |=(this._blogEditors != null);
			toReturn |=(this._blogPosts != null);
			toReturn |=(this._calendars != null);
			toReturn |=(this._calendarEvents != null);
			toReturn |=(this._calendarModerators != null);
			toReturn |=(this._documents != null);
			toReturn |=(this._lists != null);
			toReturn |=(this._newsItems != null);
			toReturn |=(this._newsletters != null);
			toReturn |=(this._newsPublishQueue != null);
			toReturn |=(this._oaTokens != null);
			toReturn |=(this._page != null);
			toReturn |=(this._polls != null);
			toReturn |=(this._privacyLevelDefinition != null);
			toReturn |=(this._snAlbums != null);
			toReturn |=(this._snBlockUsers != null);
			toReturn |=(this._snBlockUsers_ != null);
			toReturn |=(this._snComments != null);
			toReturn |=(this._snDiscussionMessage != null);
			toReturn |=(this._snEvents != null);
			toReturn |=(this._snFriendEvents != null);
			toReturn |=(this._snFiles != null);
			toReturn |=(this._snFriendsUsers != null);
			toReturn |=(this._snFriendsFriends != null);
			toReturn |=(this._snFriendLists != null);
			toReturn |=(this._snFriendListMembers != null);
			toReturn |=(this._snFriendRequestsFriends != null);
			toReturn |=(this._snFriendRequestsUsers != null);
			toReturn |=(this._snGroups != null);
			toReturn |=(this._snGroupMembers != null);
			toReturn |=(this._snGroupRequests != null);
			toReturn |=(this._snMessages != null);
			toReturn |=(this._snMessageRecipients != null);
			toReturn |=(this._snNotesPostedTo != null);
			toReturn |=(this._snNotesAuthoredBy != null);
			toReturn |=(this._snRating != null);
			toReturn |=(this._snRelationshipss != null);
			toReturn |=(this._snSubscribers != null);
			toReturn |=(this._userSocialIdentities != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AspnetPersonalizationPerUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AspnetPersonalizationPerUserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AspnetUsersInRolesEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersInRolesEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AuditInfoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AuditInfoEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BlogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BlogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BlogEditorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BlogEditorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BlogPostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BlogPostEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CalendarEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CalendarEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CalendarModeratorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarModeratorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DocumentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ListEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ListEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsItemEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsItemEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsletterEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsletterEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsPublishQueueEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsPublishQueueEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<OaTokenEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OaTokenEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PageEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PollEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PollEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PrivacyLevelDefinitionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PrivacyLevelDefinitionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnAlbumEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnAlbumEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnBlockUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnBlockUserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnBlockUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnBlockUserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnCommentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnCommentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnDiscussionMessageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionMessageEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnFileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFileEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnFriendEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnFriendEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnFriendListEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendListEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnFriendListMemberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendListMemberEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnFriendRequestEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendRequestEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnFriendRequestEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendRequestEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnGroupEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnGroupMemberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupMemberEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnGroupRequestEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupRequestEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnMessageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnMessageEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnMessageRecipientEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnMessageRecipientEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnNoteEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnNoteEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRatingEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRatingEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnSubscriberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnSubscriberEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserSocialIdentityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserSocialIdentityEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetApplications", _aspnetApplications);
			toReturn.Add("AspnetPersonalizationPerUser", _aspnetPersonalizationPerUser);
			toReturn.Add("AspnetUsersInRoles", _aspnetUsersInRoles);
			toReturn.Add("AuditInfos", _auditInfos);
			toReturn.Add("Blogs", _blogs);
			toReturn.Add("BlogEditors", _blogEditors);
			toReturn.Add("BlogPosts", _blogPosts);
			toReturn.Add("Calendars", _calendars);
			toReturn.Add("CalendarEvents", _calendarEvents);
			toReturn.Add("CalendarModerators", _calendarModerators);
			toReturn.Add("Documents", _documents);
			toReturn.Add("Lists", _lists);
			toReturn.Add("NewsItems", _newsItems);
			toReturn.Add("Newsletters", _newsletters);
			toReturn.Add("NewsPublishQueue", _newsPublishQueue);
			toReturn.Add("OaTokens", _oaTokens);
			toReturn.Add("Page", _page);
			toReturn.Add("Polls", _polls);
			toReturn.Add("PrivacyLevelDefinition", _privacyLevelDefinition);
			toReturn.Add("SnAlbums", _snAlbums);
			toReturn.Add("SnBlockUsers", _snBlockUsers);
			toReturn.Add("SnBlockUsers_", _snBlockUsers_);
			toReturn.Add("SnComments", _snComments);
			toReturn.Add("SnDiscussionMessage", _snDiscussionMessage);
			toReturn.Add("SnEvents", _snEvents);
			toReturn.Add("SnFriendEvents", _snFriendEvents);
			toReturn.Add("SnFiles", _snFiles);
			toReturn.Add("SnFriendsUsers", _snFriendsUsers);
			toReturn.Add("SnFriendsFriends", _snFriendsFriends);
			toReturn.Add("SnFriendLists", _snFriendLists);
			toReturn.Add("SnFriendListMembers", _snFriendListMembers);
			toReturn.Add("SnFriendRequestsFriends", _snFriendRequestsFriends);
			toReturn.Add("SnFriendRequestsUsers", _snFriendRequestsUsers);
			toReturn.Add("SnGroups", _snGroups);
			toReturn.Add("SnGroupMembers", _snGroupMembers);
			toReturn.Add("SnGroupRequests", _snGroupRequests);
			toReturn.Add("SnMessages", _snMessages);
			toReturn.Add("SnMessageRecipients", _snMessageRecipients);
			toReturn.Add("SnNotesPostedTo", _snNotesPostedTo);
			toReturn.Add("SnNotesAuthoredBy", _snNotesAuthoredBy);
			toReturn.Add("SnRating", _snRating);
			toReturn.Add("SnRelationshipss", _snRelationshipss);
			toReturn.Add("SnSubscribers", _snSubscribers);
			toReturn.Add("UserSocialIdentities", _userSocialIdentities);
			toReturn.Add("AspnetMembership", _aspnetMembership);
			toReturn.Add("AspnetProfile", _aspnetProfile);
			toReturn.Add("UserAvatar", _userAvatar);
			toReturn.Add("UserProfile", _userProfile);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ApplicationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LoweredUserName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MobileAlias", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsAnonymous", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastActivityDate", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetApplications</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetApplications(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)AspnetUsersFieldIndex.ApplicationId } );
			_aspnetApplications = null;
		}

		/// <summary> setups the sync logic for member _aspnetApplications</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetApplications(IEntityCore relatedEntity)
		{
			if(_aspnetApplications!=relatedEntity)
			{
				DesetupSyncAspnetApplications(true, true);
				_aspnetApplications = (AspnetApplicationsEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAspnetApplicationsPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _aspnetMembership</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetMembership(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetMembership, new PropertyChangedEventHandler( OnAspnetMembershipPropertyChanged ), "AspnetMembership", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.AspnetMembershipEntityUsingUserIdStatic, false, signalRelatedEntity, "AspnetUsers", false, new int[] { (int)AspnetUsersFieldIndex.UserId } );
			_aspnetMembership = null;
		}
		
		/// <summary> setups the sync logic for member _aspnetMembership</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetMembership(IEntityCore relatedEntity)
		{
			if(_aspnetMembership!=relatedEntity)
			{
				DesetupSyncAspnetMembership(true, true);
				_aspnetMembership = (AspnetMembershipEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetMembership, new PropertyChangedEventHandler( OnAspnetMembershipPropertyChanged ), "AspnetMembership", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.AspnetMembershipEntityUsingUserIdStatic, false, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAspnetMembershipPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _aspnetProfile</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetProfile(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetProfile, new PropertyChangedEventHandler( OnAspnetProfilePropertyChanged ), "AspnetProfile", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.AspnetProfileEntityUsingUserIdStatic, false, signalRelatedEntity, "AspnetUsers", false, new int[] { (int)AspnetUsersFieldIndex.UserId } );
			_aspnetProfile = null;
		}
		
		/// <summary> setups the sync logic for member _aspnetProfile</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetProfile(IEntityCore relatedEntity)
		{
			if(_aspnetProfile!=relatedEntity)
			{
				DesetupSyncAspnetProfile(true, true);
				_aspnetProfile = (AspnetProfileEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetProfile, new PropertyChangedEventHandler( OnAspnetProfilePropertyChanged ), "AspnetProfile", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.AspnetProfileEntityUsingUserIdStatic, false, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAspnetProfilePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _userAvatar</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUserAvatar(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _userAvatar, new PropertyChangedEventHandler( OnUserAvatarPropertyChanged ), "UserAvatar", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.UserAvatarEntityUsingIdStatic, false, signalRelatedEntity, "AspnetUsers", false, new int[] { (int)AspnetUsersFieldIndex.UserId } );
			_userAvatar = null;
		}
		
		/// <summary> setups the sync logic for member _userAvatar</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUserAvatar(IEntityCore relatedEntity)
		{
			if(_userAvatar!=relatedEntity)
			{
				DesetupSyncUserAvatar(true, true);
				_userAvatar = (UserAvatarEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _userAvatar, new PropertyChangedEventHandler( OnUserAvatarPropertyChanged ), "UserAvatar", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.UserAvatarEntityUsingIdStatic, false, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserAvatarPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _userProfile</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUserProfile(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _userProfile, new PropertyChangedEventHandler( OnUserProfilePropertyChanged ), "UserProfile", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.UserProfileEntityUsingIdStatic, false, signalRelatedEntity, "AspnetUser", false, new int[] { (int)AspnetUsersFieldIndex.UserId } );
			_userProfile = null;
		}
		
		/// <summary> setups the sync logic for member _userProfile</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUserProfile(IEntityCore relatedEntity)
		{
			if(_userProfile!=relatedEntity)
			{
				DesetupSyncUserProfile(true, true);
				_userProfile = (UserProfileEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _userProfile, new PropertyChangedEventHandler( OnUserProfilePropertyChanged ), "UserProfile", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetUsersRelations.UserProfileEntityUsingIdStatic, false, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserProfilePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AspnetUsersEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AspnetUsersRelations Relations
		{
			get	{ return new AspnetUsersRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetPersonalizationPerUser' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetPersonalizationPerUser
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<AspnetPersonalizationPerUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AspnetPersonalizationPerUserEntityFactory))), (IEntityRelation)GetRelationsForField("AspnetPersonalizationPerUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetPersonalizationPerUserEntity, 0, null, null, null, null, "AspnetPersonalizationPerUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsersInRoles' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUsersInRoles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<AspnetUsersInRolesEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersInRolesEntityFactory))), (IEntityRelation)GetRelationsForField("AspnetUsersInRoles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersInRolesEntity, 0, null, null, null, null, "AspnetUsersInRoles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AuditInfo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAuditInfos
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<AuditInfoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AuditInfoEntityFactory))), (IEntityRelation)GetRelationsForField("AuditInfos")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AuditInfoEntity, 0, null, null, null, null, "AuditInfos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Blog' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBlogs
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BlogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BlogEntityFactory))), (IEntityRelation)GetRelationsForField("Blogs")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.BlogEntity, 0, null, null, null, null, "Blogs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BlogEditor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBlogEditors
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BlogEditorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BlogEditorEntityFactory))), (IEntityRelation)GetRelationsForField("BlogEditors")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.BlogEditorEntity, 0, null, null, null, null, "BlogEditors", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BlogPost' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBlogPosts
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BlogPostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BlogPostEntityFactory))), (IEntityRelation)GetRelationsForField("BlogPosts")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.BlogPostEntity, 0, null, null, null, null, "BlogPosts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Calendar' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCalendars
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CalendarEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEntityFactory))), (IEntityRelation)GetRelationsForField("Calendars")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEntity, 0, null, null, null, null, "Calendars", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CalendarEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCalendarEvents
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CalendarEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventEntityFactory))), (IEntityRelation)GetRelationsForField("CalendarEvents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity, 0, null, null, null, null, "CalendarEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CalendarModerator' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCalendarModerators
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CalendarModeratorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarModeratorEntityFactory))), (IEntityRelation)GetRelationsForField("CalendarModerators")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CalendarModeratorEntity, 0, null, null, null, null, "CalendarModerators", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Document' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDocuments
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<DocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DocumentEntityFactory))), (IEntityRelation)GetRelationsForField("Documents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.DocumentEntity, 0, null, null, null, null, "Documents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'List' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathLists
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ListEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ListEntityFactory))), (IEntityRelation)GetRelationsForField("Lists")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.ListEntity, 0, null, null, null, null, "Lists", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsItems
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsItemEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsItemEntityFactory))), (IEntityRelation)GetRelationsForField("NewsItems")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, 0, null, null, null, null, "NewsItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Newsletter' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsletters
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsletterEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsletterEntityFactory))), (IEntityRelation)GetRelationsForField("Newsletters")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, 0, null, null, null, null, "Newsletters", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsPublishQueue' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsPublishQueue
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsPublishQueueEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsPublishQueueEntityFactory))), (IEntityRelation)GetRelationsForField("NewsPublishQueue")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsPublishQueueEntity, 0, null, null, null, null, "NewsPublishQueue", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'OaToken' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOaTokens
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<OaTokenEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OaTokenEntityFactory))), (IEntityRelation)GetRelationsForField("OaTokens")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.OaTokenEntity, 0, null, null, null, null, "OaTokens", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Page' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPage
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PageEntityFactory))), (IEntityRelation)GetRelationsForField("Page")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, 0, null, null, null, null, "Page", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Poll' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPolls
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PollEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PollEntityFactory))), (IEntityRelation)GetRelationsForField("Polls")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PollEntity, 0, null, null, null, null, "Polls", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PrivacyLevelDefinition' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPrivacyLevelDefinition
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PrivacyLevelDefinitionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PrivacyLevelDefinitionEntityFactory))), (IEntityRelation)GetRelationsForField("PrivacyLevelDefinition")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelDefinitionEntity, 0, null, null, null, null, "PrivacyLevelDefinition", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnAlbum' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnAlbums
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnAlbumEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnAlbumEntityFactory))), (IEntityRelation)GetRelationsForField("SnAlbums")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnAlbumEntity, 0, null, null, null, null, "SnAlbums", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnBlockUser' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnBlockUsers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnBlockUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnBlockUserEntityFactory))), (IEntityRelation)GetRelationsForField("SnBlockUsers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnBlockUserEntity, 0, null, null, null, null, "SnBlockUsers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnBlockUser' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnBlockUsers_
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnBlockUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnBlockUserEntityFactory))), (IEntityRelation)GetRelationsForField("SnBlockUsers_")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnBlockUserEntity, 0, null, null, null, null, "SnBlockUsers_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnComment' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnComments
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnCommentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnCommentEntityFactory))), (IEntityRelation)GetRelationsForField("SnComments")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnCommentEntity, 0, null, null, null, null, "SnComments", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionMessage' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionMessage
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnDiscussionMessageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionMessageEntityFactory))), (IEntityRelation)GetRelationsForField("SnDiscussionMessage")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, 0, null, null, null, null, "SnDiscussionMessage", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnEvents
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))), (IEntityRelation)GetRelationsForField("SnEvents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, 0, null, null, null, null, "SnEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFriendEvents
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))), (IEntityRelation)GetRelationsForField("SnFriendEvents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, 0, null, null, null, null, "SnFriendEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFile' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFiles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnFileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFileEntityFactory))), (IEntityRelation)GetRelationsForField("SnFiles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, 0, null, null, null, null, "SnFiles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFriend' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFriendsUsers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnFriendEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendEntityFactory))), (IEntityRelation)GetRelationsForField("SnFriendsUsers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFriendEntity, 0, null, null, null, null, "SnFriendsUsers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFriend' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFriendsFriends
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnFriendEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendEntityFactory))), (IEntityRelation)GetRelationsForField("SnFriendsFriends")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFriendEntity, 0, null, null, null, null, "SnFriendsFriends", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFriendList' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFriendLists
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnFriendListEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendListEntityFactory))), (IEntityRelation)GetRelationsForField("SnFriendLists")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFriendListEntity, 0, null, null, null, null, "SnFriendLists", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFriendListMember' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFriendListMembers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnFriendListMemberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendListMemberEntityFactory))), (IEntityRelation)GetRelationsForField("SnFriendListMembers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFriendListMemberEntity, 0, null, null, null, null, "SnFriendListMembers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFriendRequest' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFriendRequestsFriends
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnFriendRequestEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendRequestEntityFactory))), (IEntityRelation)GetRelationsForField("SnFriendRequestsFriends")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFriendRequestEntity, 0, null, null, null, null, "SnFriendRequestsFriends", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFriendRequest' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFriendRequestsUsers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnFriendRequestEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFriendRequestEntityFactory))), (IEntityRelation)GetRelationsForField("SnFriendRequestsUsers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFriendRequestEntity, 0, null, null, null, null, "SnFriendRequestsUsers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnGroup' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnGroups
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnGroupEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupEntityFactory))), (IEntityRelation)GetRelationsForField("SnGroups")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, 0, null, null, null, null, "SnGroups", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnGroupMember' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnGroupMembers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnGroupMemberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupMemberEntityFactory))), (IEntityRelation)GetRelationsForField("SnGroupMembers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupMemberEntity, 0, null, null, null, null, "SnGroupMembers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnGroupRequest' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnGroupRequests
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnGroupRequestEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupRequestEntityFactory))), (IEntityRelation)GetRelationsForField("SnGroupRequests")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupRequestEntity, 0, null, null, null, null, "SnGroupRequests", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnMessage' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnMessages
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnMessageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnMessageEntityFactory))), (IEntityRelation)GetRelationsForField("SnMessages")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnMessageEntity, 0, null, null, null, null, "SnMessages", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnMessageRecipient' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnMessageRecipients
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnMessageRecipientEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnMessageRecipientEntityFactory))), (IEntityRelation)GetRelationsForField("SnMessageRecipients")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnMessageRecipientEntity, 0, null, null, null, null, "SnMessageRecipients", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnNote' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnNotesPostedTo
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnNoteEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))), (IEntityRelation)GetRelationsForField("SnNotesPostedTo")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnNoteEntity, 0, null, null, null, null, "SnNotesPostedTo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnNote' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnNotesAuthoredBy
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnNoteEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))), (IEntityRelation)GetRelationsForField("SnNotesAuthoredBy")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnNoteEntity, 0, null, null, null, null, "SnNotesAuthoredBy", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRating' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRating
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRatingEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRatingEntityFactory))), (IEntityRelation)GetRelationsForField("SnRating")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRatingEntity, 0, null, null, null, null, "SnRating", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationshipss
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationshipss")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationshipss", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnSubscriber' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnSubscribers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnSubscriberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnSubscriberEntityFactory))), (IEntityRelation)GetRelationsForField("SnSubscribers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnSubscriberEntity, 0, null, null, null, null, "SnSubscribers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserSocialIdentity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserSocialIdentities
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<UserSocialIdentityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserSocialIdentityEntityFactory))), (IEntityRelation)GetRelationsForField("UserSocialIdentities")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.UserSocialIdentityEntity, 0, null, null, null, null, "UserSocialIdentities", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetApplications' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetApplications
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetApplicationsEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetApplications")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, 0, null, null, null, null, "AspnetApplications", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetMembership' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetMembership
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetMembershipEntityFactory))), (IEntityRelation)GetRelationsForField("AspnetMembership")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetMembershipEntity, 0, null, null, null, null, "AspnetMembership", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetProfile' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetProfile
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetProfileEntityFactory))), (IEntityRelation)GetRelationsForField("AspnetProfile")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetProfileEntity, 0, null, null, null, null, "AspnetProfile", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserAvatar' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserAvatar
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UserAvatarEntityFactory))), (IEntityRelation)GetRelationsForField("UserAvatar")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.UserAvatarEntity, 0, null, null, null, null, "UserAvatar", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserProfile' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserProfile
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UserProfileEntityFactory))), (IEntityRelation)GetRelationsForField("UserProfile")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, (int)MonoSoftware.MonoX.DAL.EntityType.UserProfileEntity, 0, null, null, null, null, "UserProfile", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The ApplicationId property of the Entity AspnetUsers<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Users"."ApplicationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid ApplicationId
		{
			get { return (System.Guid)GetValue((int)AspnetUsersFieldIndex.ApplicationId, true); }
			set	{ SetValue((int)AspnetUsersFieldIndex.ApplicationId, value); }
		}

		/// <summary> The UserId property of the Entity AspnetUsers<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Users"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>		
		public virtual System.Guid UserId
		{
			get { return (System.Guid)GetValue((int)AspnetUsersFieldIndex.UserId, true); }
			set	{ SetValue((int)AspnetUsersFieldIndex.UserId, value); }
		}

		/// <summary> The UserName property of the Entity AspnetUsers<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Users"."UserName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.String UserName
		{
			get { return (System.String)GetValue((int)AspnetUsersFieldIndex.UserName, true); }
			set	{ SetValue((int)AspnetUsersFieldIndex.UserName, value); }
		}

		/// <summary> The LoweredUserName property of the Entity AspnetUsers<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Users"."LoweredUserName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.String LoweredUserName
		{
			get { return (System.String)GetValue((int)AspnetUsersFieldIndex.LoweredUserName, true); }
			set	{ SetValue((int)AspnetUsersFieldIndex.LoweredUserName, value); }
		}

		/// <summary> The MobileAlias property of the Entity AspnetUsers<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Users"."MobileAlias"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 16<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String MobileAlias
		{
			get { return (System.String)GetValue((int)AspnetUsersFieldIndex.MobileAlias, true); }
			set	{ SetValue((int)AspnetUsersFieldIndex.MobileAlias, value); }
		}

		/// <summary> The IsAnonymous property of the Entity AspnetUsers<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Users"."IsAnonymous"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Boolean IsAnonymous
		{
			get { return (System.Boolean)GetValue((int)AspnetUsersFieldIndex.IsAnonymous, true); }
			set	{ SetValue((int)AspnetUsersFieldIndex.IsAnonymous, value); }
		}

		/// <summary> The LastActivityDate property of the Entity AspnetUsers<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Users"."LastActivityDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.DateTime LastActivityDate
		{
			get { return (System.DateTime)GetValue((int)AspnetUsersFieldIndex.LastActivityDate, true); }
			set	{ SetValue((int)AspnetUsersFieldIndex.LastActivityDate, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AspnetPersonalizationPerUserEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AspnetPersonalizationPerUserEntity))]		
		public virtual EntityCollection<AspnetPersonalizationPerUserEntity> AspnetPersonalizationPerUser
		{
			get { return GetOrCreateEntityCollection<AspnetPersonalizationPerUserEntity, AspnetPersonalizationPerUserEntityFactory>("AspnetUsers", true, false, ref _aspnetPersonalizationPerUser);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AspnetUsersInRolesEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AspnetUsersInRolesEntity))]		
		public virtual EntityCollection<AspnetUsersInRolesEntity> AspnetUsersInRoles
		{
			get { return GetOrCreateEntityCollection<AspnetUsersInRolesEntity, AspnetUsersInRolesEntityFactory>("AspnetUsers", true, false, ref _aspnetUsersInRoles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AuditInfoEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AuditInfoEntity))]		
		public virtual EntityCollection<AuditInfoEntity> AuditInfos
		{
			get { return GetOrCreateEntityCollection<AuditInfoEntity, AuditInfoEntityFactory>("AspnetUser", true, false, ref _auditInfos);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BlogEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BlogEntity))]		
		public virtual EntityCollection<BlogEntity> Blogs
		{
			get { return GetOrCreateEntityCollection<BlogEntity, BlogEntityFactory>("AspnetUser", true, false, ref _blogs);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BlogEditorEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BlogEditorEntity))]		
		public virtual EntityCollection<BlogEditorEntity> BlogEditors
		{
			get { return GetOrCreateEntityCollection<BlogEditorEntity, BlogEditorEntityFactory>("AspnetUser", true, false, ref _blogEditors);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BlogPostEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BlogPostEntity))]		
		public virtual EntityCollection<BlogPostEntity> BlogPosts
		{
			get { return GetOrCreateEntityCollection<BlogPostEntity, BlogPostEntityFactory>("AspnetUser", true, false, ref _blogPosts);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CalendarEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CalendarEntity))]		
		public virtual EntityCollection<CalendarEntity> Calendars
		{
			get { return GetOrCreateEntityCollection<CalendarEntity, CalendarEntityFactory>("AspnetUsers", true, false, ref _calendars);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CalendarEventEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CalendarEventEntity))]		
		public virtual EntityCollection<CalendarEventEntity> CalendarEvents
		{
			get { return GetOrCreateEntityCollection<CalendarEventEntity, CalendarEventEntityFactory>("AspnetUsers", true, false, ref _calendarEvents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CalendarModeratorEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CalendarModeratorEntity))]		
		public virtual EntityCollection<CalendarModeratorEntity> CalendarModerators
		{
			get { return GetOrCreateEntityCollection<CalendarModeratorEntity, CalendarModeratorEntityFactory>("AspnetUsers", true, false, ref _calendarModerators);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DocumentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(DocumentEntity))]		
		public virtual EntityCollection<DocumentEntity> Documents
		{
			get { return GetOrCreateEntityCollection<DocumentEntity, DocumentEntityFactory>("AspnetUsers", true, false, ref _documents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ListEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ListEntity))]		
		public virtual EntityCollection<ListEntity> Lists
		{
			get { return GetOrCreateEntityCollection<ListEntity, ListEntityFactory>("AspnetUser", true, false, ref _lists);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsItemEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsItemEntity))]		
		public virtual EntityCollection<NewsItemEntity> NewsItems
		{
			get { return GetOrCreateEntityCollection<NewsItemEntity, NewsItemEntityFactory>("AspnetUser", true, false, ref _newsItems);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsletterEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsletterEntity))]		
		public virtual EntityCollection<NewsletterEntity> Newsletters
		{
			get { return GetOrCreateEntityCollection<NewsletterEntity, NewsletterEntityFactory>("AspnetUser", true, false, ref _newsletters);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsPublishQueueEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsPublishQueueEntity))]		
		public virtual EntityCollection<NewsPublishQueueEntity> NewsPublishQueue
		{
			get { return GetOrCreateEntityCollection<NewsPublishQueueEntity, NewsPublishQueueEntityFactory>("AspnetUser", true, false, ref _newsPublishQueue);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'OaTokenEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OaTokenEntity))]		
		public virtual EntityCollection<OaTokenEntity> OaTokens
		{
			get { return GetOrCreateEntityCollection<OaTokenEntity, OaTokenEntityFactory>("AspnetUsers", true, false, ref _oaTokens);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PageEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PageEntity))]		
		public virtual EntityCollection<PageEntity> Page
		{
			get { return GetOrCreateEntityCollection<PageEntity, PageEntityFactory>("AspnetUsers", true, false, ref _page);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PollEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PollEntity))]		
		public virtual EntityCollection<PollEntity> Polls
		{
			get { return GetOrCreateEntityCollection<PollEntity, PollEntityFactory>("AspnetUser", true, false, ref _polls);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PrivacyLevelDefinitionEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PrivacyLevelDefinitionEntity))]		
		public virtual EntityCollection<PrivacyLevelDefinitionEntity> PrivacyLevelDefinition
		{
			get { return GetOrCreateEntityCollection<PrivacyLevelDefinitionEntity, PrivacyLevelDefinitionEntityFactory>("AspnetUsers", true, false, ref _privacyLevelDefinition);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnAlbumEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnAlbumEntity))]		
		public virtual EntityCollection<SnAlbumEntity> SnAlbums
		{
			get { return GetOrCreateEntityCollection<SnAlbumEntity, SnAlbumEntityFactory>("AspnetUser", true, false, ref _snAlbums);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnBlockUserEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnBlockUserEntity))]		
		public virtual EntityCollection<SnBlockUserEntity> SnBlockUsers
		{
			get { return GetOrCreateEntityCollection<SnBlockUserEntity, SnBlockUserEntityFactory>("AspnetUser", true, false, ref _snBlockUsers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnBlockUserEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnBlockUserEntity))]		
		public virtual EntityCollection<SnBlockUserEntity> SnBlockUsers_
		{
			get { return GetOrCreateEntityCollection<SnBlockUserEntity, SnBlockUserEntityFactory>("BlockedAspnetUser", true, false, ref _snBlockUsers_);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnCommentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnCommentEntity))]		
		public virtual EntityCollection<SnCommentEntity> SnComments
		{
			get { return GetOrCreateEntityCollection<SnCommentEntity, SnCommentEntityFactory>("AspnetUser", true, false, ref _snComments);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnDiscussionMessageEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnDiscussionMessageEntity))]		
		public virtual EntityCollection<SnDiscussionMessageEntity> SnDiscussionMessage
		{
			get { return GetOrCreateEntityCollection<SnDiscussionMessageEntity, SnDiscussionMessageEntityFactory>("PinnedByUser", true, false, ref _snDiscussionMessage);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnEventEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnEventEntity))]		
		public virtual EntityCollection<SnEventEntity> SnEvents
		{
			get { return GetOrCreateEntityCollection<SnEventEntity, SnEventEntityFactory>("AspnetUsers", true, false, ref _snEvents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnEventEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnEventEntity))]		
		public virtual EntityCollection<SnEventEntity> SnFriendEvents
		{
			get { return GetOrCreateEntityCollection<SnEventEntity, SnEventEntityFactory>("FriendAspnetUsers", true, false, ref _snFriendEvents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnFileEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnFileEntity))]		
		public virtual EntityCollection<SnFileEntity> SnFiles
		{
			get { return GetOrCreateEntityCollection<SnFileEntity, SnFileEntityFactory>("AspnetUser", true, false, ref _snFiles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnFriendEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnFriendEntity))]		
		public virtual EntityCollection<SnFriendEntity> SnFriendsUsers
		{
			get { return GetOrCreateEntityCollection<SnFriendEntity, SnFriendEntityFactory>("AspnetUser", true, false, ref _snFriendsUsers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnFriendEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnFriendEntity))]		
		public virtual EntityCollection<SnFriendEntity> SnFriendsFriends
		{
			get { return GetOrCreateEntityCollection<SnFriendEntity, SnFriendEntityFactory>("AspnetUserFriend", true, false, ref _snFriendsFriends);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnFriendListEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnFriendListEntity))]		
		public virtual EntityCollection<SnFriendListEntity> SnFriendLists
		{
			get { return GetOrCreateEntityCollection<SnFriendListEntity, SnFriendListEntityFactory>("AspnetUser", true, false, ref _snFriendLists);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnFriendListMemberEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnFriendListMemberEntity))]		
		public virtual EntityCollection<SnFriendListMemberEntity> SnFriendListMembers
		{
			get { return GetOrCreateEntityCollection<SnFriendListMemberEntity, SnFriendListMemberEntityFactory>("AspnetUser", true, false, ref _snFriendListMembers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnFriendRequestEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnFriendRequestEntity))]		
		public virtual EntityCollection<SnFriendRequestEntity> SnFriendRequestsFriends
		{
			get { return GetOrCreateEntityCollection<SnFriendRequestEntity, SnFriendRequestEntityFactory>("AspnetUser", true, false, ref _snFriendRequestsFriends);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnFriendRequestEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnFriendRequestEntity))]		
		public virtual EntityCollection<SnFriendRequestEntity> SnFriendRequestsUsers
		{
			get { return GetOrCreateEntityCollection<SnFriendRequestEntity, SnFriendRequestEntityFactory>("AspnetUserFriend", true, false, ref _snFriendRequestsUsers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnGroupEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnGroupEntity))]		
		public virtual EntityCollection<SnGroupEntity> SnGroups
		{
			get { return GetOrCreateEntityCollection<SnGroupEntity, SnGroupEntityFactory>("AspnetUser", true, false, ref _snGroups);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnGroupMemberEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnGroupMemberEntity))]		
		public virtual EntityCollection<SnGroupMemberEntity> SnGroupMembers
		{
			get { return GetOrCreateEntityCollection<SnGroupMemberEntity, SnGroupMemberEntityFactory>("AspnetUser", true, false, ref _snGroupMembers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnGroupRequestEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnGroupRequestEntity))]		
		public virtual EntityCollection<SnGroupRequestEntity> SnGroupRequests
		{
			get { return GetOrCreateEntityCollection<SnGroupRequestEntity, SnGroupRequestEntityFactory>("AspnetUser", true, false, ref _snGroupRequests);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnMessageEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnMessageEntity))]		
		public virtual EntityCollection<SnMessageEntity> SnMessages
		{
			get { return GetOrCreateEntityCollection<SnMessageEntity, SnMessageEntityFactory>("AspnetUser", true, false, ref _snMessages);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnMessageRecipientEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnMessageRecipientEntity))]		
		public virtual EntityCollection<SnMessageRecipientEntity> SnMessageRecipients
		{
			get { return GetOrCreateEntityCollection<SnMessageRecipientEntity, SnMessageRecipientEntityFactory>("AspnetUser", true, false, ref _snMessageRecipients);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnNoteEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnNoteEntity))]		
		public virtual EntityCollection<SnNoteEntity> SnNotesPostedTo
		{
			get { return GetOrCreateEntityCollection<SnNoteEntity, SnNoteEntityFactory>("AspnetUserAuthor", true, false, ref _snNotesPostedTo);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnNoteEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnNoteEntity))]		
		public virtual EntityCollection<SnNoteEntity> SnNotesAuthoredBy
		{
			get { return GetOrCreateEntityCollection<SnNoteEntity, SnNoteEntityFactory>("AspnetUserPostedTo", true, false, ref _snNotesAuthoredBy);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRatingEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRatingEntity))]		
		public virtual EntityCollection<SnRatingEntity> SnRating
		{
			get { return GetOrCreateEntityCollection<SnRatingEntity, SnRatingEntityFactory>("AspnetUsers", true, false, ref _snRating);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]		
		public virtual EntityCollection<SnRelationshipEntity> SnRelationshipss
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("AspnetUser", true, false, ref _snRelationshipss);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnSubscriberEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnSubscriberEntity))]		
		public virtual EntityCollection<SnSubscriberEntity> SnSubscribers
		{
			get { return GetOrCreateEntityCollection<SnSubscriberEntity, SnSubscriberEntityFactory>("AspnetUsers", true, false, ref _snSubscribers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserSocialIdentityEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UserSocialIdentityEntity))]		
		public virtual EntityCollection<UserSocialIdentityEntity> UserSocialIdentities
		{
			get { return GetOrCreateEntityCollection<UserSocialIdentityEntity, UserSocialIdentityEntityFactory>("AspnetUser", true, false, ref _userSocialIdentities);	}
		}

		/// <summary> Gets / sets related entity of type 'AspnetApplicationsEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual AspnetApplicationsEntity AspnetApplications
		{
			get	{ return _aspnetApplications; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAspnetApplications(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "", "AspnetApplications", _aspnetApplications, false); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AspnetMembershipEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(true)]		
		public virtual AspnetMembershipEntity AspnetMembership
		{
			get { return _aspnetMembership; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAspnetMembership(value);
					CallSetRelatedEntityDuringDeserialization(value, "AspnetUsers");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_aspnetMembership !=null);
						DesetupSyncAspnetMembership(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("AspnetMembership");
						}
					}
					else
					{
						if(_aspnetMembership!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "AspnetUsers");
							SetupSyncAspnetMembership(value);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AspnetProfileEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(true)]		
		public virtual AspnetProfileEntity AspnetProfile
		{
			get { return _aspnetProfile; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAspnetProfile(value);
					CallSetRelatedEntityDuringDeserialization(value, "AspnetUsers");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_aspnetProfile !=null);
						DesetupSyncAspnetProfile(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("AspnetProfile");
						}
					}
					else
					{
						if(_aspnetProfile!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "AspnetUsers");
							SetupSyncAspnetProfile(value);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UserAvatarEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(true)]		
		public virtual UserAvatarEntity UserAvatar
		{
			get { return _userAvatar; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUserAvatar(value);
					CallSetRelatedEntityDuringDeserialization(value, "AspnetUsers");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_userAvatar !=null);
						DesetupSyncUserAvatar(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("UserAvatar");
						}
					}
					else
					{
						if(_userAvatar!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "AspnetUsers");
							SetupSyncUserAvatar(value);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UserProfileEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(true)]		
		public virtual UserProfileEntity UserProfile
		{
			get { return _userProfile; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUserProfile(value);
					CallSetRelatedEntityDuringDeserialization(value, "AspnetUser");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_userProfile !=null);
						DesetupSyncUserProfile(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("UserProfile");
						}
					}
					else
					{
						if(_userProfile!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "AspnetUser");
							SetupSyncUserProfile(value);
						}
					}
				}
			}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the MonoSoftware.MonoX.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode

        

		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
