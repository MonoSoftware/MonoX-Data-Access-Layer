///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
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
	/// <summary>Entity class which represents the entity 'SnRelationship'.<br/><br/></summary>
	[Serializable]
	public partial class SnRelationshipEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SnCommentEntity> _snComments;
		private EntityCollection<SnFileEntity> _snFiles;
		private EntityCollection<SnRatingEntity> _snRatings;
		private EntityCollection<SnSubscriberEntity> _snSubscribers;
		private EntityCollection<SnTagEntity> _snTags;
		private AspnetApplicationsEntity _aspnetApplication;
		private AspnetUsersEntity _aspnetUser;
		private BlogEntity _blog;
		private BlogPostEntity _blogPost;
		private CalendarEventEntity _calendarEvent;
		private CampaignEntity _campaign;
		private DocumentEntity _document;
		private ListItemEntity _listItem;
		private NewsCategoryEntity _newsCategory;
		private NewsItemEntity _newsItem;
		private NewsletterEntity _newsletter;
		private PageEntity _page;
		private PollEntity _poll;
		private SnAlbumEntity _snAlbum;
		private SnDiscussionBoardEntity _snDiscussionBoard;
		private SnDiscussionMessageEntity _snDiscussionMessage;
		private SnDiscussionTopicEntity _snDiscussionTopic;
		private SnFileEntity _snFile;
		private SnGroupEntity _snGroup;
		private SnMessageEntity _snMessage;
		private SnNoteEntity _snNote;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AspnetApplication</summary>
			public static readonly string AspnetApplication = "AspnetApplication";
			/// <summary>Member name AspnetUser</summary>
			public static readonly string AspnetUser = "AspnetUser";
			/// <summary>Member name Blog</summary>
			public static readonly string Blog = "Blog";
			/// <summary>Member name BlogPost</summary>
			public static readonly string BlogPost = "BlogPost";
			/// <summary>Member name CalendarEvent</summary>
			public static readonly string CalendarEvent = "CalendarEvent";
			/// <summary>Member name Campaign</summary>
			public static readonly string Campaign = "Campaign";
			/// <summary>Member name Document</summary>
			public static readonly string Document = "Document";
			/// <summary>Member name ListItem</summary>
			public static readonly string ListItem = "ListItem";
			/// <summary>Member name NewsCategory</summary>
			public static readonly string NewsCategory = "NewsCategory";
			/// <summary>Member name NewsItem</summary>
			public static readonly string NewsItem = "NewsItem";
			/// <summary>Member name Newsletter</summary>
			public static readonly string Newsletter = "Newsletter";
			/// <summary>Member name Page</summary>
			public static readonly string Page = "Page";
			/// <summary>Member name Poll</summary>
			public static readonly string Poll = "Poll";
			/// <summary>Member name SnAlbum</summary>
			public static readonly string SnAlbum = "SnAlbum";
			/// <summary>Member name SnDiscussionBoard</summary>
			public static readonly string SnDiscussionBoard = "SnDiscussionBoard";
			/// <summary>Member name SnDiscussionMessage</summary>
			public static readonly string SnDiscussionMessage = "SnDiscussionMessage";
			/// <summary>Member name SnDiscussionTopic</summary>
			public static readonly string SnDiscussionTopic = "SnDiscussionTopic";
			/// <summary>Member name SnFile</summary>
			public static readonly string SnFile = "SnFile";
			/// <summary>Member name SnGroup</summary>
			public static readonly string SnGroup = "SnGroup";
			/// <summary>Member name SnMessage</summary>
			public static readonly string SnMessage = "SnMessage";
			/// <summary>Member name SnNote</summary>
			public static readonly string SnNote = "SnNote";
			/// <summary>Member name SnComments</summary>
			public static readonly string SnComments = "SnComments";
			/// <summary>Member name SnFiles</summary>
			public static readonly string SnFiles = "SnFiles";
			/// <summary>Member name SnRatings</summary>
			public static readonly string SnRatings = "SnRatings";
			/// <summary>Member name SnSubscribers</summary>
			public static readonly string SnSubscribers = "SnSubscribers";
			/// <summary>Member name SnTags</summary>
			public static readonly string SnTags = "SnTags";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SnRelationshipEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SnRelationshipEntity():base("SnRelationshipEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SnRelationshipEntity(IEntityFields2 fields):base("SnRelationshipEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SnRelationshipEntity</param>
		public SnRelationshipEntity(IValidator validator):base("SnRelationshipEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnRelationship which data should be fetched into this SnRelationship object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnRelationshipEntity(System.Guid id):base("SnRelationshipEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnRelationship which data should be fetched into this SnRelationship object</param>
		/// <param name="validator">The custom validator object for this SnRelationshipEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnRelationshipEntity(System.Guid id, IValidator validator):base("SnRelationshipEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SnRelationshipEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_snComments = (EntityCollection<SnCommentEntity>)info.GetValue("_snComments", typeof(EntityCollection<SnCommentEntity>));
				_snFiles = (EntityCollection<SnFileEntity>)info.GetValue("_snFiles", typeof(EntityCollection<SnFileEntity>));
				_snRatings = (EntityCollection<SnRatingEntity>)info.GetValue("_snRatings", typeof(EntityCollection<SnRatingEntity>));
				_snSubscribers = (EntityCollection<SnSubscriberEntity>)info.GetValue("_snSubscribers", typeof(EntityCollection<SnSubscriberEntity>));
				_snTags = (EntityCollection<SnTagEntity>)info.GetValue("_snTags", typeof(EntityCollection<SnTagEntity>));
				_aspnetApplication = (AspnetApplicationsEntity)info.GetValue("_aspnetApplication", typeof(AspnetApplicationsEntity));
				if(_aspnetApplication!=null)
				{
					_aspnetApplication.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_aspnetUser = (AspnetUsersEntity)info.GetValue("_aspnetUser", typeof(AspnetUsersEntity));
				if(_aspnetUser!=null)
				{
					_aspnetUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_blog = (BlogEntity)info.GetValue("_blog", typeof(BlogEntity));
				if(_blog!=null)
				{
					_blog.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_blogPost = (BlogPostEntity)info.GetValue("_blogPost", typeof(BlogPostEntity));
				if(_blogPost!=null)
				{
					_blogPost.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_calendarEvent = (CalendarEventEntity)info.GetValue("_calendarEvent", typeof(CalendarEventEntity));
				if(_calendarEvent!=null)
				{
					_calendarEvent.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_campaign = (CampaignEntity)info.GetValue("_campaign", typeof(CampaignEntity));
				if(_campaign!=null)
				{
					_campaign.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_document = (DocumentEntity)info.GetValue("_document", typeof(DocumentEntity));
				if(_document!=null)
				{
					_document.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_listItem = (ListItemEntity)info.GetValue("_listItem", typeof(ListItemEntity));
				if(_listItem!=null)
				{
					_listItem.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_newsCategory = (NewsCategoryEntity)info.GetValue("_newsCategory", typeof(NewsCategoryEntity));
				if(_newsCategory!=null)
				{
					_newsCategory.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_newsItem = (NewsItemEntity)info.GetValue("_newsItem", typeof(NewsItemEntity));
				if(_newsItem!=null)
				{
					_newsItem.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_newsletter = (NewsletterEntity)info.GetValue("_newsletter", typeof(NewsletterEntity));
				if(_newsletter!=null)
				{
					_newsletter.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_page = (PageEntity)info.GetValue("_page", typeof(PageEntity));
				if(_page!=null)
				{
					_page.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_poll = (PollEntity)info.GetValue("_poll", typeof(PollEntity));
				if(_poll!=null)
				{
					_poll.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snAlbum = (SnAlbumEntity)info.GetValue("_snAlbum", typeof(SnAlbumEntity));
				if(_snAlbum!=null)
				{
					_snAlbum.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snDiscussionBoard = (SnDiscussionBoardEntity)info.GetValue("_snDiscussionBoard", typeof(SnDiscussionBoardEntity));
				if(_snDiscussionBoard!=null)
				{
					_snDiscussionBoard.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snDiscussionMessage = (SnDiscussionMessageEntity)info.GetValue("_snDiscussionMessage", typeof(SnDiscussionMessageEntity));
				if(_snDiscussionMessage!=null)
				{
					_snDiscussionMessage.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snDiscussionTopic = (SnDiscussionTopicEntity)info.GetValue("_snDiscussionTopic", typeof(SnDiscussionTopicEntity));
				if(_snDiscussionTopic!=null)
				{
					_snDiscussionTopic.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snFile = (SnFileEntity)info.GetValue("_snFile", typeof(SnFileEntity));
				if(_snFile!=null)
				{
					_snFile.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snGroup = (SnGroupEntity)info.GetValue("_snGroup", typeof(SnGroupEntity));
				if(_snGroup!=null)
				{
					_snGroup.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snMessage = (SnMessageEntity)info.GetValue("_snMessage", typeof(SnMessageEntity));
				if(_snMessage!=null)
				{
					_snMessage.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snNote = (SnNoteEntity)info.GetValue("_snNote", typeof(SnNoteEntity));
				if(_snNote!=null)
				{
					_snNote.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SnRelationshipFieldIndex)fieldIndex)
			{
				case SnRelationshipFieldIndex.NoteId:
					DesetupSyncSnNote(true, false);
					break;
				case SnRelationshipFieldIndex.FileId:
					DesetupSyncSnFile(true, false);
					break;
				case SnRelationshipFieldIndex.AlbumId:
					DesetupSyncSnAlbum(true, false);
					break;
				case SnRelationshipFieldIndex.BlogPostId:
					DesetupSyncBlogPost(true, false);
					break;
				case SnRelationshipFieldIndex.MessageId:
					DesetupSyncSnMessage(true, false);
					break;
				case SnRelationshipFieldIndex.DiscussionMessageId:
					DesetupSyncSnDiscussionMessage(true, false);
					break;
				case SnRelationshipFieldIndex.DiscussionBoardId:
					DesetupSyncSnDiscussionBoard(true, false);
					break;
				case SnRelationshipFieldIndex.DiscussionTopicId:
					DesetupSyncSnDiscussionTopic(true, false);
					break;
				case SnRelationshipFieldIndex.DocumentId:
					DesetupSyncDocument(true, false);
					break;
				case SnRelationshipFieldIndex.NewsItemId:
					DesetupSyncNewsItem(true, false);
					break;
				case SnRelationshipFieldIndex.ListItemId:
					DesetupSyncListItem(true, false);
					break;
				case SnRelationshipFieldIndex.BlogId:
					DesetupSyncBlog(true, false);
					break;
				case SnRelationshipFieldIndex.ApplicationId:
					DesetupSyncAspnetApplication(true, false);
					break;
				case SnRelationshipFieldIndex.CalendarEventId:
					DesetupSyncCalendarEvent(true, false);
					break;
				case SnRelationshipFieldIndex.CampaignId:
					DesetupSyncCampaign(true, false);
					break;
				case SnRelationshipFieldIndex.PageId:
					DesetupSyncPage(true, false);
					break;
				case SnRelationshipFieldIndex.UserId:
					DesetupSyncAspnetUser(true, false);
					break;
				case SnRelationshipFieldIndex.NewsCategoryId:
					DesetupSyncNewsCategory(true, false);
					break;
				case SnRelationshipFieldIndex.NewsletterId:
					DesetupSyncNewsletter(true, false);
					break;
				case SnRelationshipFieldIndex.PollId:
					DesetupSyncPoll(true, false);
					break;
				case SnRelationshipFieldIndex.GroupId:
					DesetupSyncSnGroup(true, false);
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
		protected override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{
				case "AspnetApplication":
					this.AspnetApplication = (AspnetApplicationsEntity)entity;
					break;
				case "AspnetUser":
					this.AspnetUser = (AspnetUsersEntity)entity;
					break;
				case "Blog":
					this.Blog = (BlogEntity)entity;
					break;
				case "BlogPost":
					this.BlogPost = (BlogPostEntity)entity;
					break;
				case "CalendarEvent":
					this.CalendarEvent = (CalendarEventEntity)entity;
					break;
				case "Campaign":
					this.Campaign = (CampaignEntity)entity;
					break;
				case "Document":
					this.Document = (DocumentEntity)entity;
					break;
				case "ListItem":
					this.ListItem = (ListItemEntity)entity;
					break;
				case "NewsCategory":
					this.NewsCategory = (NewsCategoryEntity)entity;
					break;
				case "NewsItem":
					this.NewsItem = (NewsItemEntity)entity;
					break;
				case "Newsletter":
					this.Newsletter = (NewsletterEntity)entity;
					break;
				case "Page":
					this.Page = (PageEntity)entity;
					break;
				case "Poll":
					this.Poll = (PollEntity)entity;
					break;
				case "SnAlbum":
					this.SnAlbum = (SnAlbumEntity)entity;
					break;
				case "SnDiscussionBoard":
					this.SnDiscussionBoard = (SnDiscussionBoardEntity)entity;
					break;
				case "SnDiscussionMessage":
					this.SnDiscussionMessage = (SnDiscussionMessageEntity)entity;
					break;
				case "SnDiscussionTopic":
					this.SnDiscussionTopic = (SnDiscussionTopicEntity)entity;
					break;
				case "SnFile":
					this.SnFile = (SnFileEntity)entity;
					break;
				case "SnGroup":
					this.SnGroup = (SnGroupEntity)entity;
					break;
				case "SnMessage":
					this.SnMessage = (SnMessageEntity)entity;
					break;
				case "SnNote":
					this.SnNote = (SnNoteEntity)entity;
					break;
				case "SnComments":
					this.SnComments.Add((SnCommentEntity)entity);
					break;
				case "SnFiles":
					this.SnFiles.Add((SnFileEntity)entity);
					break;
				case "SnRatings":
					this.SnRatings.Add((SnRatingEntity)entity);
					break;
				case "SnSubscribers":
					this.SnSubscribers.Add((SnSubscriberEntity)entity);
					break;
				case "SnTags":
					this.SnTags.Add((SnTagEntity)entity);
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
				case "AspnetApplication":
					toReturn.Add(Relations.AspnetApplicationsEntityUsingApplicationId);
					break;
				case "AspnetUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingUserId);
					break;
				case "Blog":
					toReturn.Add(Relations.BlogEntityUsingBlogId);
					break;
				case "BlogPost":
					toReturn.Add(Relations.BlogPostEntityUsingBlogPostId);
					break;
				case "CalendarEvent":
					toReturn.Add(Relations.CalendarEventEntityUsingCalendarEventId);
					break;
				case "Campaign":
					toReturn.Add(Relations.CampaignEntityUsingCampaignId);
					break;
				case "Document":
					toReturn.Add(Relations.DocumentEntityUsingDocumentId);
					break;
				case "ListItem":
					toReturn.Add(Relations.ListItemEntityUsingListItemId);
					break;
				case "NewsCategory":
					toReturn.Add(Relations.NewsCategoryEntityUsingNewsCategoryId);
					break;
				case "NewsItem":
					toReturn.Add(Relations.NewsItemEntityUsingNewsItemId);
					break;
				case "Newsletter":
					toReturn.Add(Relations.NewsletterEntityUsingNewsletterId);
					break;
				case "Page":
					toReturn.Add(Relations.PageEntityUsingPageId);
					break;
				case "Poll":
					toReturn.Add(Relations.PollEntityUsingPollId);
					break;
				case "SnAlbum":
					toReturn.Add(Relations.SnAlbumEntityUsingAlbumId);
					break;
				case "SnDiscussionBoard":
					toReturn.Add(Relations.SnDiscussionBoardEntityUsingDiscussionBoardId);
					break;
				case "SnDiscussionMessage":
					toReturn.Add(Relations.SnDiscussionMessageEntityUsingDiscussionMessageId);
					break;
				case "SnDiscussionTopic":
					toReturn.Add(Relations.SnDiscussionTopicEntityUsingDiscussionTopicId);
					break;
				case "SnFile":
					toReturn.Add(Relations.SnFileEntityUsingFileId);
					break;
				case "SnGroup":
					toReturn.Add(Relations.SnGroupEntityUsingGroupId);
					break;
				case "SnMessage":
					toReturn.Add(Relations.SnMessageEntityUsingMessageId);
					break;
				case "SnNote":
					toReturn.Add(Relations.SnNoteEntityUsingNoteId);
					break;
				case "SnComments":
					toReturn.Add(Relations.SnCommentEntityUsingRelationshipId);
					break;
				case "SnFiles":
					toReturn.Add(Relations.SnFileEntityUsingRelationshipId);
					break;
				case "SnRatings":
					toReturn.Add(Relations.SnRatingEntityUsingRelationshipId);
					break;
				case "SnSubscribers":
					toReturn.Add(Relations.SnSubscriberEntityUsingRelationshipId);
					break;
				case "SnTags":
					toReturn.Add(Relations.SnTagEntityUsingRelationshipId);
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
				case "AspnetApplication":
					return true;
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "AspnetApplication":
					SetupSyncAspnetApplication(relatedEntity);
					break;
				case "AspnetUser":
					SetupSyncAspnetUser(relatedEntity);
					break;
				case "Blog":
					SetupSyncBlog(relatedEntity);
					break;
				case "BlogPost":
					SetupSyncBlogPost(relatedEntity);
					break;
				case "CalendarEvent":
					SetupSyncCalendarEvent(relatedEntity);
					break;
				case "Campaign":
					SetupSyncCampaign(relatedEntity);
					break;
				case "Document":
					SetupSyncDocument(relatedEntity);
					break;
				case "ListItem":
					SetupSyncListItem(relatedEntity);
					break;
				case "NewsCategory":
					SetupSyncNewsCategory(relatedEntity);
					break;
				case "NewsItem":
					SetupSyncNewsItem(relatedEntity);
					break;
				case "Newsletter":
					SetupSyncNewsletter(relatedEntity);
					break;
				case "Page":
					SetupSyncPage(relatedEntity);
					break;
				case "Poll":
					SetupSyncPoll(relatedEntity);
					break;
				case "SnAlbum":
					SetupSyncSnAlbum(relatedEntity);
					break;
				case "SnDiscussionBoard":
					SetupSyncSnDiscussionBoard(relatedEntity);
					break;
				case "SnDiscussionMessage":
					SetupSyncSnDiscussionMessage(relatedEntity);
					break;
				case "SnDiscussionTopic":
					SetupSyncSnDiscussionTopic(relatedEntity);
					break;
				case "SnFile":
					SetupSyncSnFile(relatedEntity);
					break;
				case "SnGroup":
					SetupSyncSnGroup(relatedEntity);
					break;
				case "SnMessage":
					SetupSyncSnMessage(relatedEntity);
					break;
				case "SnNote":
					SetupSyncSnNote(relatedEntity);
					break;
				case "SnComments":
					this.SnComments.Add((SnCommentEntity)relatedEntity);
					break;
				case "SnFiles":
					this.SnFiles.Add((SnFileEntity)relatedEntity);
					break;
				case "SnRatings":
					this.SnRatings.Add((SnRatingEntity)relatedEntity);
					break;
				case "SnSubscribers":
					this.SnSubscribers.Add((SnSubscriberEntity)relatedEntity);
					break;
				case "SnTags":
					this.SnTags.Add((SnTagEntity)relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "AspnetApplication":
					DesetupSyncAspnetApplication(false, true);
					break;
				case "AspnetUser":
					DesetupSyncAspnetUser(false, true);
					break;
				case "Blog":
					DesetupSyncBlog(false, true);
					break;
				case "BlogPost":
					DesetupSyncBlogPost(false, true);
					break;
				case "CalendarEvent":
					DesetupSyncCalendarEvent(false, true);
					break;
				case "Campaign":
					DesetupSyncCampaign(false, true);
					break;
				case "Document":
					DesetupSyncDocument(false, true);
					break;
				case "ListItem":
					DesetupSyncListItem(false, true);
					break;
				case "NewsCategory":
					DesetupSyncNewsCategory(false, true);
					break;
				case "NewsItem":
					DesetupSyncNewsItem(false, true);
					break;
				case "Newsletter":
					DesetupSyncNewsletter(false, true);
					break;
				case "Page":
					DesetupSyncPage(false, true);
					break;
				case "Poll":
					DesetupSyncPoll(false, true);
					break;
				case "SnAlbum":
					DesetupSyncSnAlbum(false, true);
					break;
				case "SnDiscussionBoard":
					DesetupSyncSnDiscussionBoard(false, true);
					break;
				case "SnDiscussionMessage":
					DesetupSyncSnDiscussionMessage(false, true);
					break;
				case "SnDiscussionTopic":
					DesetupSyncSnDiscussionTopic(false, true);
					break;
				case "SnFile":
					DesetupSyncSnFile(false, true);
					break;
				case "SnGroup":
					DesetupSyncSnGroup(false, true);
					break;
				case "SnMessage":
					DesetupSyncSnMessage(false, true);
					break;
				case "SnNote":
					DesetupSyncSnNote(false, true);
					break;
				case "SnComments":
					this.PerformRelatedEntityRemoval(this.SnComments, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFiles":
					this.PerformRelatedEntityRemoval(this.SnFiles, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnRatings":
					this.PerformRelatedEntityRemoval(this.SnRatings, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnSubscribers":
					this.PerformRelatedEntityRemoval(this.SnSubscribers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnTags":
					this.PerformRelatedEntityRemoval(this.SnTags, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_aspnetApplication!=null)
			{
				toReturn.Add(_aspnetApplication);
			}
			if(_aspnetUser!=null)
			{
				toReturn.Add(_aspnetUser);
			}
			if(_blog!=null)
			{
				toReturn.Add(_blog);
			}
			if(_blogPost!=null)
			{
				toReturn.Add(_blogPost);
			}
			if(_calendarEvent!=null)
			{
				toReturn.Add(_calendarEvent);
			}
			if(_campaign!=null)
			{
				toReturn.Add(_campaign);
			}
			if(_document!=null)
			{
				toReturn.Add(_document);
			}
			if(_listItem!=null)
			{
				toReturn.Add(_listItem);
			}
			if(_newsCategory!=null)
			{
				toReturn.Add(_newsCategory);
			}
			if(_newsItem!=null)
			{
				toReturn.Add(_newsItem);
			}
			if(_newsletter!=null)
			{
				toReturn.Add(_newsletter);
			}
			if(_page!=null)
			{
				toReturn.Add(_page);
			}
			if(_poll!=null)
			{
				toReturn.Add(_poll);
			}
			if(_snAlbum!=null)
			{
				toReturn.Add(_snAlbum);
			}
			if(_snDiscussionBoard!=null)
			{
				toReturn.Add(_snDiscussionBoard);
			}
			if(_snDiscussionMessage!=null)
			{
				toReturn.Add(_snDiscussionMessage);
			}
			if(_snDiscussionTopic!=null)
			{
				toReturn.Add(_snDiscussionTopic);
			}
			if(_snFile!=null)
			{
				toReturn.Add(_snFile);
			}
			if(_snGroup!=null)
			{
				toReturn.Add(_snGroup);
			}
			if(_snMessage!=null)
			{
				toReturn.Add(_snMessage);
			}
			if(_snNote!=null)
			{
				toReturn.Add(_snNote);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SnComments);
			toReturn.Add(this.SnFiles);
			toReturn.Add(this.SnRatings);
			toReturn.Add(this.SnSubscribers);
			toReturn.Add(this.SnTags);
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
				info.AddValue("_snComments", ((_snComments!=null) && (_snComments.Count>0) && !this.MarkedForDeletion)?_snComments:null);
				info.AddValue("_snFiles", ((_snFiles!=null) && (_snFiles.Count>0) && !this.MarkedForDeletion)?_snFiles:null);
				info.AddValue("_snRatings", ((_snRatings!=null) && (_snRatings.Count>0) && !this.MarkedForDeletion)?_snRatings:null);
				info.AddValue("_snSubscribers", ((_snSubscribers!=null) && (_snSubscribers.Count>0) && !this.MarkedForDeletion)?_snSubscribers:null);
				info.AddValue("_snTags", ((_snTags!=null) && (_snTags.Count>0) && !this.MarkedForDeletion)?_snTags:null);
				info.AddValue("_aspnetApplication", (!this.MarkedForDeletion?_aspnetApplication:null));
				info.AddValue("_aspnetUser", (!this.MarkedForDeletion?_aspnetUser:null));
				info.AddValue("_blog", (!this.MarkedForDeletion?_blog:null));
				info.AddValue("_blogPost", (!this.MarkedForDeletion?_blogPost:null));
				info.AddValue("_calendarEvent", (!this.MarkedForDeletion?_calendarEvent:null));
				info.AddValue("_campaign", (!this.MarkedForDeletion?_campaign:null));
				info.AddValue("_document", (!this.MarkedForDeletion?_document:null));
				info.AddValue("_listItem", (!this.MarkedForDeletion?_listItem:null));
				info.AddValue("_newsCategory", (!this.MarkedForDeletion?_newsCategory:null));
				info.AddValue("_newsItem", (!this.MarkedForDeletion?_newsItem:null));
				info.AddValue("_newsletter", (!this.MarkedForDeletion?_newsletter:null));
				info.AddValue("_page", (!this.MarkedForDeletion?_page:null));
				info.AddValue("_poll", (!this.MarkedForDeletion?_poll:null));
				info.AddValue("_snAlbum", (!this.MarkedForDeletion?_snAlbum:null));
				info.AddValue("_snDiscussionBoard", (!this.MarkedForDeletion?_snDiscussionBoard:null));
				info.AddValue("_snDiscussionMessage", (!this.MarkedForDeletion?_snDiscussionMessage:null));
				info.AddValue("_snDiscussionTopic", (!this.MarkedForDeletion?_snDiscussionTopic:null));
				info.AddValue("_snFile", (!this.MarkedForDeletion?_snFile:null));
				info.AddValue("_snGroup", (!this.MarkedForDeletion?_snGroup:null));
				info.AddValue("_snMessage", (!this.MarkedForDeletion?_snMessage:null));
				info.AddValue("_snNote", (!this.MarkedForDeletion?_snNote:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SnRelationshipRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnComment' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnComments()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnCommentFields.RelationshipId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnFile' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFiles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFileFields.RelationshipId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRating' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRatings()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRatingFields.RelationshipId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnSubscriber' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnSubscribers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnSubscriberFields.RelationshipId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnTag' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnTags()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnTagFields.RelationshipId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetApplications' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetApplication()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetApplicationsFields.ApplicationId, null, ComparisonOperator.Equal, this.ApplicationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Blog' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBlog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BlogFields.Id, null, ComparisonOperator.Equal, this.BlogId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'BlogPost' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBlogPost()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BlogPostFields.Id, null, ComparisonOperator.Equal, this.BlogPostId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CalendarEvent' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCalendarEvent()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CalendarEventFields.Id, null, ComparisonOperator.Equal, this.CalendarEventId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Campaign' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCampaign()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CampaignFields.Id, null, ComparisonOperator.Equal, this.CampaignId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Document' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDocument()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DocumentFields.Id, null, ComparisonOperator.Equal, this.DocumentId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ListItem' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoListItem()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ListItemFields.Id, null, ComparisonOperator.Equal, this.ListItemId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'NewsCategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsCategory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsCategoryFields.Id, null, ComparisonOperator.Equal, this.NewsCategoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'NewsItem' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsItem()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsItemFields.Id, null, ComparisonOperator.Equal, this.NewsItemId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Newsletter' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsletter()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsletterFields.Id, null, ComparisonOperator.Equal, this.NewsletterId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Page' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPage()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PageFields.Id, null, ComparisonOperator.Equal, this.PageId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Poll' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPoll()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PollFields.Id, null, ComparisonOperator.Equal, this.PollId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnAlbum' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnAlbum()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnAlbumFields.Id, null, ComparisonOperator.Equal, this.AlbumId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnDiscussionBoard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionBoard()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionBoardFields.Id, null, ComparisonOperator.Equal, this.DiscussionBoardId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnDiscussionMessage' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionMessage()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionMessageFields.Id, null, ComparisonOperator.Equal, this.DiscussionMessageId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnDiscussionTopic' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionTopic()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionTopicFields.Id, null, ComparisonOperator.Equal, this.DiscussionTopicId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnFile' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFile()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFileFields.Id, null, ComparisonOperator.Equal, this.FileId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnGroup' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnGroup()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnGroupFields.Id, null, ComparisonOperator.Equal, this.GroupId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnMessage' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnMessage()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnMessageFields.Id, null, ComparisonOperator.Equal, this.MessageId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnNote' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnNote()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnNoteFields.Id, null, ComparisonOperator.Equal, this.NoteId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._snComments);
			collectionsQueue.Enqueue(this._snFiles);
			collectionsQueue.Enqueue(this._snRatings);
			collectionsQueue.Enqueue(this._snSubscribers);
			collectionsQueue.Enqueue(this._snTags);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._snComments = (EntityCollection<SnCommentEntity>) collectionsQueue.Dequeue();
			this._snFiles = (EntityCollection<SnFileEntity>) collectionsQueue.Dequeue();
			this._snRatings = (EntityCollection<SnRatingEntity>) collectionsQueue.Dequeue();
			this._snSubscribers = (EntityCollection<SnSubscriberEntity>) collectionsQueue.Dequeue();
			this._snTags = (EntityCollection<SnTagEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._snComments != null);
			toReturn |=(this._snFiles != null);
			toReturn |=(this._snRatings != null);
			toReturn |=(this._snSubscribers != null);
			toReturn |=(this._snTags != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnCommentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnCommentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnFileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFileEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRatingEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRatingEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnSubscriberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnSubscriberEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnTagEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnTagEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetApplication", _aspnetApplication);
			toReturn.Add("AspnetUser", _aspnetUser);
			toReturn.Add("Blog", _blog);
			toReturn.Add("BlogPost", _blogPost);
			toReturn.Add("CalendarEvent", _calendarEvent);
			toReturn.Add("Campaign", _campaign);
			toReturn.Add("Document", _document);
			toReturn.Add("ListItem", _listItem);
			toReturn.Add("NewsCategory", _newsCategory);
			toReturn.Add("NewsItem", _newsItem);
			toReturn.Add("Newsletter", _newsletter);
			toReturn.Add("Page", _page);
			toReturn.Add("Poll", _poll);
			toReturn.Add("SnAlbum", _snAlbum);
			toReturn.Add("SnDiscussionBoard", _snDiscussionBoard);
			toReturn.Add("SnDiscussionMessage", _snDiscussionMessage);
			toReturn.Add("SnDiscussionTopic", _snDiscussionTopic);
			toReturn.Add("SnFile", _snFile);
			toReturn.Add("SnGroup", _snGroup);
			toReturn.Add("SnMessage", _snMessage);
			toReturn.Add("SnNote", _snNote);
			toReturn.Add("SnComments", _snComments);
			toReturn.Add("SnFiles", _snFiles);
			toReturn.Add("SnRatings", _snRatings);
			toReturn.Add("SnSubscribers", _snSubscribers);
			toReturn.Add("SnTags", _snTags);
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
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NoteId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FileId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AlbumId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BlogPostId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MessageId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DiscussionMessageId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomId1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomId2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomId3", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DiscussionBoardId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DiscussionTopicId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DocumentId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NewsItemId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ListItemId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BlogId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ApplicationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CalendarEventId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CampaignId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PageId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NewsCategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NewsletterId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PollId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GroupId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetApplication</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetApplication(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetApplication, new PropertyChangedEventHandler( OnAspnetApplicationPropertyChanged ), "AspnetApplication", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.ApplicationId } );
			_aspnetApplication = null;
		}

		/// <summary> setups the sync logic for member _aspnetApplication</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetApplication(IEntity2 relatedEntity)
		{
			if(_aspnetApplication!=relatedEntity)
			{
				DesetupSyncAspnetApplication(true, true);
				_aspnetApplication = (AspnetApplicationsEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetApplication, new PropertyChangedEventHandler( OnAspnetApplicationPropertyChanged ), "AspnetApplication", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAspnetApplicationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _aspnetUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "SnRelationshipss", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.UserId } );
			_aspnetUser = null;
		}

		/// <summary> setups the sync logic for member _aspnetUser</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetUser(IEntity2 relatedEntity)
		{
			if(_aspnetUser!=relatedEntity)
			{
				DesetupSyncAspnetUser(true, true);
				_aspnetUser = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAspnetUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _blog</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBlog(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _blog, new PropertyChangedEventHandler( OnBlogPropertyChanged ), "Blog", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.BlogEntityUsingBlogIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.BlogId } );
			_blog = null;
		}

		/// <summary> setups the sync logic for member _blog</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBlog(IEntity2 relatedEntity)
		{
			if(_blog!=relatedEntity)
			{
				DesetupSyncBlog(true, true);
				_blog = (BlogEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _blog, new PropertyChangedEventHandler( OnBlogPropertyChanged ), "Blog", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.BlogEntityUsingBlogIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBlogPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _blogPost</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBlogPost(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _blogPost, new PropertyChangedEventHandler( OnBlogPostPropertyChanged ), "BlogPost", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.BlogPostEntityUsingBlogPostIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.BlogPostId } );
			_blogPost = null;
		}

		/// <summary> setups the sync logic for member _blogPost</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBlogPost(IEntity2 relatedEntity)
		{
			if(_blogPost!=relatedEntity)
			{
				DesetupSyncBlogPost(true, true);
				_blogPost = (BlogPostEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _blogPost, new PropertyChangedEventHandler( OnBlogPostPropertyChanged ), "BlogPost", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.BlogPostEntityUsingBlogPostIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBlogPostPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _calendarEvent</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCalendarEvent(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _calendarEvent, new PropertyChangedEventHandler( OnCalendarEventPropertyChanged ), "CalendarEvent", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.CalendarEventEntityUsingCalendarEventIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.CalendarEventId } );
			_calendarEvent = null;
		}

		/// <summary> setups the sync logic for member _calendarEvent</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCalendarEvent(IEntity2 relatedEntity)
		{
			if(_calendarEvent!=relatedEntity)
			{
				DesetupSyncCalendarEvent(true, true);
				_calendarEvent = (CalendarEventEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _calendarEvent, new PropertyChangedEventHandler( OnCalendarEventPropertyChanged ), "CalendarEvent", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.CalendarEventEntityUsingCalendarEventIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCalendarEventPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _campaign</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCampaign(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _campaign, new PropertyChangedEventHandler( OnCampaignPropertyChanged ), "Campaign", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.CampaignEntityUsingCampaignIdStatic, true, signalRelatedEntity, "SnRelationshipss", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.CampaignId } );
			_campaign = null;
		}

		/// <summary> setups the sync logic for member _campaign</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCampaign(IEntity2 relatedEntity)
		{
			if(_campaign!=relatedEntity)
			{
				DesetupSyncCampaign(true, true);
				_campaign = (CampaignEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _campaign, new PropertyChangedEventHandler( OnCampaignPropertyChanged ), "Campaign", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.CampaignEntityUsingCampaignIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCampaignPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _document</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDocument(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _document, new PropertyChangedEventHandler( OnDocumentPropertyChanged ), "Document", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.DocumentEntityUsingDocumentIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.DocumentId } );
			_document = null;
		}

		/// <summary> setups the sync logic for member _document</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDocument(IEntity2 relatedEntity)
		{
			if(_document!=relatedEntity)
			{
				DesetupSyncDocument(true, true);
				_document = (DocumentEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _document, new PropertyChangedEventHandler( OnDocumentPropertyChanged ), "Document", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.DocumentEntityUsingDocumentIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDocumentPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _listItem</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncListItem(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _listItem, new PropertyChangedEventHandler( OnListItemPropertyChanged ), "ListItem", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.ListItemEntityUsingListItemIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.ListItemId } );
			_listItem = null;
		}

		/// <summary> setups the sync logic for member _listItem</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncListItem(IEntity2 relatedEntity)
		{
			if(_listItem!=relatedEntity)
			{
				DesetupSyncListItem(true, true);
				_listItem = (ListItemEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _listItem, new PropertyChangedEventHandler( OnListItemPropertyChanged ), "ListItem", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.ListItemEntityUsingListItemIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnListItemPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _newsCategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncNewsCategory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _newsCategory, new PropertyChangedEventHandler( OnNewsCategoryPropertyChanged ), "NewsCategory", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.NewsCategoryEntityUsingNewsCategoryIdStatic, true, signalRelatedEntity, "SnRelationshipss", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.NewsCategoryId } );
			_newsCategory = null;
		}

		/// <summary> setups the sync logic for member _newsCategory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncNewsCategory(IEntity2 relatedEntity)
		{
			if(_newsCategory!=relatedEntity)
			{
				DesetupSyncNewsCategory(true, true);
				_newsCategory = (NewsCategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _newsCategory, new PropertyChangedEventHandler( OnNewsCategoryPropertyChanged ), "NewsCategory", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.NewsCategoryEntityUsingNewsCategoryIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnNewsCategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _newsItem</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncNewsItem(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _newsItem, new PropertyChangedEventHandler( OnNewsItemPropertyChanged ), "NewsItem", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.NewsItemEntityUsingNewsItemIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.NewsItemId } );
			_newsItem = null;
		}

		/// <summary> setups the sync logic for member _newsItem</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncNewsItem(IEntity2 relatedEntity)
		{
			if(_newsItem!=relatedEntity)
			{
				DesetupSyncNewsItem(true, true);
				_newsItem = (NewsItemEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _newsItem, new PropertyChangedEventHandler( OnNewsItemPropertyChanged ), "NewsItem", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.NewsItemEntityUsingNewsItemIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnNewsItemPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _newsletter</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncNewsletter(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _newsletter, new PropertyChangedEventHandler( OnNewsletterPropertyChanged ), "Newsletter", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.NewsletterEntityUsingNewsletterIdStatic, true, signalRelatedEntity, "SnRelationshipss", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.NewsletterId } );
			_newsletter = null;
		}

		/// <summary> setups the sync logic for member _newsletter</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncNewsletter(IEntity2 relatedEntity)
		{
			if(_newsletter!=relatedEntity)
			{
				DesetupSyncNewsletter(true, true);
				_newsletter = (NewsletterEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _newsletter, new PropertyChangedEventHandler( OnNewsletterPropertyChanged ), "Newsletter", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.NewsletterEntityUsingNewsletterIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnNewsletterPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _page</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPage(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _page, new PropertyChangedEventHandler( OnPagePropertyChanged ), "Page", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.PageEntityUsingPageIdStatic, true, signalRelatedEntity, "SnRelationshipss", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.PageId } );
			_page = null;
		}

		/// <summary> setups the sync logic for member _page</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPage(IEntity2 relatedEntity)
		{
			if(_page!=relatedEntity)
			{
				DesetupSyncPage(true, true);
				_page = (PageEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _page, new PropertyChangedEventHandler( OnPagePropertyChanged ), "Page", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.PageEntityUsingPageIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPagePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _poll</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPoll(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _poll, new PropertyChangedEventHandler( OnPollPropertyChanged ), "Poll", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.PollEntityUsingPollIdStatic, true, signalRelatedEntity, "SnRelationshipss", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.PollId } );
			_poll = null;
		}

		/// <summary> setups the sync logic for member _poll</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPoll(IEntity2 relatedEntity)
		{
			if(_poll!=relatedEntity)
			{
				DesetupSyncPoll(true, true);
				_poll = (PollEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _poll, new PropertyChangedEventHandler( OnPollPropertyChanged ), "Poll", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.PollEntityUsingPollIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPollPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _snAlbum</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnAlbum(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snAlbum, new PropertyChangedEventHandler( OnSnAlbumPropertyChanged ), "SnAlbum", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnAlbumEntityUsingAlbumIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.AlbumId } );
			_snAlbum = null;
		}

		/// <summary> setups the sync logic for member _snAlbum</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnAlbum(IEntity2 relatedEntity)
		{
			if(_snAlbum!=relatedEntity)
			{
				DesetupSyncSnAlbum(true, true);
				_snAlbum = (SnAlbumEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snAlbum, new PropertyChangedEventHandler( OnSnAlbumPropertyChanged ), "SnAlbum", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnAlbumEntityUsingAlbumIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnAlbumPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _snDiscussionBoard</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnDiscussionBoard(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snDiscussionBoard, new PropertyChangedEventHandler( OnSnDiscussionBoardPropertyChanged ), "SnDiscussionBoard", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnDiscussionBoardEntityUsingDiscussionBoardIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.DiscussionBoardId } );
			_snDiscussionBoard = null;
		}

		/// <summary> setups the sync logic for member _snDiscussionBoard</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnDiscussionBoard(IEntity2 relatedEntity)
		{
			if(_snDiscussionBoard!=relatedEntity)
			{
				DesetupSyncSnDiscussionBoard(true, true);
				_snDiscussionBoard = (SnDiscussionBoardEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snDiscussionBoard, new PropertyChangedEventHandler( OnSnDiscussionBoardPropertyChanged ), "SnDiscussionBoard", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnDiscussionBoardEntityUsingDiscussionBoardIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnDiscussionBoardPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _snDiscussionMessage</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnDiscussionMessage(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snDiscussionMessage, new PropertyChangedEventHandler( OnSnDiscussionMessagePropertyChanged ), "SnDiscussionMessage", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnDiscussionMessageEntityUsingDiscussionMessageIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.DiscussionMessageId } );
			_snDiscussionMessage = null;
		}

		/// <summary> setups the sync logic for member _snDiscussionMessage</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnDiscussionMessage(IEntity2 relatedEntity)
		{
			if(_snDiscussionMessage!=relatedEntity)
			{
				DesetupSyncSnDiscussionMessage(true, true);
				_snDiscussionMessage = (SnDiscussionMessageEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snDiscussionMessage, new PropertyChangedEventHandler( OnSnDiscussionMessagePropertyChanged ), "SnDiscussionMessage", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnDiscussionMessageEntityUsingDiscussionMessageIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnDiscussionMessagePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _snDiscussionTopic</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnDiscussionTopic(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snDiscussionTopic, new PropertyChangedEventHandler( OnSnDiscussionTopicPropertyChanged ), "SnDiscussionTopic", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnDiscussionTopicEntityUsingDiscussionTopicIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.DiscussionTopicId } );
			_snDiscussionTopic = null;
		}

		/// <summary> setups the sync logic for member _snDiscussionTopic</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnDiscussionTopic(IEntity2 relatedEntity)
		{
			if(_snDiscussionTopic!=relatedEntity)
			{
				DesetupSyncSnDiscussionTopic(true, true);
				_snDiscussionTopic = (SnDiscussionTopicEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snDiscussionTopic, new PropertyChangedEventHandler( OnSnDiscussionTopicPropertyChanged ), "SnDiscussionTopic", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnDiscussionTopicEntityUsingDiscussionTopicIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnDiscussionTopicPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _snFile</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnFile(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snFile, new PropertyChangedEventHandler( OnSnFilePropertyChanged ), "SnFile", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnFileEntityUsingFileIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.FileId } );
			_snFile = null;
		}

		/// <summary> setups the sync logic for member _snFile</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnFile(IEntity2 relatedEntity)
		{
			if(_snFile!=relatedEntity)
			{
				DesetupSyncSnFile(true, true);
				_snFile = (SnFileEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snFile, new PropertyChangedEventHandler( OnSnFilePropertyChanged ), "SnFile", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnFileEntityUsingFileIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnFilePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _snGroup</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnGroup(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snGroup, new PropertyChangedEventHandler( OnSnGroupPropertyChanged ), "SnGroup", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnGroupEntityUsingGroupIdStatic, true, signalRelatedEntity, "SnRelationshipss", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.GroupId } );
			_snGroup = null;
		}

		/// <summary> setups the sync logic for member _snGroup</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnGroup(IEntity2 relatedEntity)
		{
			if(_snGroup!=relatedEntity)
			{
				DesetupSyncSnGroup(true, true);
				_snGroup = (SnGroupEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snGroup, new PropertyChangedEventHandler( OnSnGroupPropertyChanged ), "SnGroup", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnGroupEntityUsingGroupIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnGroupPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _snMessage</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnMessage(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snMessage, new PropertyChangedEventHandler( OnSnMessagePropertyChanged ), "SnMessage", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnMessageEntityUsingMessageIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.MessageId } );
			_snMessage = null;
		}

		/// <summary> setups the sync logic for member _snMessage</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnMessage(IEntity2 relatedEntity)
		{
			if(_snMessage!=relatedEntity)
			{
				DesetupSyncSnMessage(true, true);
				_snMessage = (SnMessageEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snMessage, new PropertyChangedEventHandler( OnSnMessagePropertyChanged ), "SnMessage", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnMessageEntityUsingMessageIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnMessagePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _snNote</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnNote(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snNote, new PropertyChangedEventHandler( OnSnNotePropertyChanged ), "SnNote", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnNoteEntityUsingNoteIdStatic, true, signalRelatedEntity, "SnRelationships", resetFKFields, new int[] { (int)SnRelationshipFieldIndex.NoteId } );
			_snNote = null;
		}

		/// <summary> setups the sync logic for member _snNote</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnNote(IEntity2 relatedEntity)
		{
			if(_snNote!=relatedEntity)
			{
				DesetupSyncSnNote(true, true);
				_snNote = (SnNoteEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snNote, new PropertyChangedEventHandler( OnSnNotePropertyChanged ), "SnNote", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnRelationshipRelations.SnNoteEntityUsingNoteIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnNotePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SnRelationshipEntity</param>
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
		public  static SnRelationshipRelations Relations
		{
			get	{ return new SnRelationshipRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnComment' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnComments
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnCommentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnCommentEntityFactory))), (IEntityRelation)GetRelationsForField("SnComments")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnCommentEntity, 0, null, null, null, null, "SnComments", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFile' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFiles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnFileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFileEntityFactory))), (IEntityRelation)GetRelationsForField("SnFiles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, 0, null, null, null, null, "SnFiles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRating' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRatings
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRatingEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRatingEntityFactory))), (IEntityRelation)GetRelationsForField("SnRatings")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRatingEntity, 0, null, null, null, null, "SnRatings", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnSubscriber' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnSubscribers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnSubscriberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnSubscriberEntityFactory))), (IEntityRelation)GetRelationsForField("SnSubscribers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnSubscriberEntity, 0, null, null, null, null, "SnSubscribers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnTag' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnTags
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnTagEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnTagEntityFactory))), (IEntityRelation)GetRelationsForField("SnTags")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnTagEntity, 0, null, null, null, null, "SnTags", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetApplications' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetApplication
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetApplicationsEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetApplication")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, 0, null, null, null, null, "AspnetApplication", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Blog' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBlog
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(BlogEntityFactory))),	(IEntityRelation)GetRelationsForField("Blog")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.BlogEntity, 0, null, null, null, null, "Blog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BlogPost' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBlogPost
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(BlogPostEntityFactory))),	(IEntityRelation)GetRelationsForField("BlogPost")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.BlogPostEntity, 0, null, null, null, null, "BlogPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CalendarEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCalendarEvent
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventEntityFactory))),	(IEntityRelation)GetRelationsForField("CalendarEvent")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity, 0, null, null, null, null, "CalendarEvent", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Campaign' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCampaign
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CampaignEntityFactory))),	(IEntityRelation)GetRelationsForField("Campaign")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CampaignEntity, 0, null, null, null, null, "Campaign", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Document' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDocument
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(DocumentEntityFactory))),	(IEntityRelation)GetRelationsForField("Document")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.DocumentEntity, 0, null, null, null, null, "Document", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ListItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathListItem
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ListItemEntityFactory))),	(IEntityRelation)GetRelationsForField("ListItem")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.ListItemEntity, 0, null, null, null, null, "ListItem", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsCategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsCategory
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryEntityFactory))),	(IEntityRelation)GetRelationsForField("NewsCategory")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, 0, null, null, null, null, "NewsCategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsItem
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(NewsItemEntityFactory))),	(IEntityRelation)GetRelationsForField("NewsItem")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, 0, null, null, null, null, "NewsItem", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Newsletter' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsletter
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(NewsletterEntityFactory))),	(IEntityRelation)GetRelationsForField("Newsletter")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, 0, null, null, null, null, "Newsletter", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Page' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPage
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PageEntityFactory))),	(IEntityRelation)GetRelationsForField("Page")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, 0, null, null, null, null, "Page", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Poll' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPoll
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PollEntityFactory))),	(IEntityRelation)GetRelationsForField("Poll")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PollEntity, 0, null, null, null, null, "Poll", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnAlbum' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnAlbum
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnAlbumEntityFactory))),	(IEntityRelation)GetRelationsForField("SnAlbum")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnAlbumEntity, 0, null, null, null, null, "SnAlbum", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionBoard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionBoard
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardEntityFactory))),	(IEntityRelation)GetRelationsForField("SnDiscussionBoard")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, 0, null, null, null, null, "SnDiscussionBoard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionMessage' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionMessage
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionMessageEntityFactory))),	(IEntityRelation)GetRelationsForField("SnDiscussionMessage")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, 0, null, null, null, null, "SnDiscussionMessage", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionTopic' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionTopic
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionTopicEntityFactory))),	(IEntityRelation)GetRelationsForField("SnDiscussionTopic")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, 0, null, null, null, null, "SnDiscussionTopic", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFile' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFile
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnFileEntityFactory))),	(IEntityRelation)GetRelationsForField("SnFile")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, 0, null, null, null, null, "SnFile", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnGroup' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnGroup
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupEntityFactory))),	(IEntityRelation)GetRelationsForField("SnGroup")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, 0, null, null, null, null, "SnGroup", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnMessage' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnMessage
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnMessageEntityFactory))),	(IEntityRelation)GetRelationsForField("SnMessage")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnMessageEntity, 0, null, null, null, null, "SnMessage", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnNote' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnNote
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))),	(IEntityRelation)GetRelationsForField("SnNote")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnNoteEntity, 0, null, null, null, null, "SnNote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)SnRelationshipFieldIndex.Id, true); }
			set	{ SetValue((int)SnRelationshipFieldIndex.Id, value); }
		}

		/// <summary> The NoteId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."NoteId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> NoteId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.NoteId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.NoteId, value); }
		}

		/// <summary> The FileId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."FileId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> FileId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.FileId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.FileId, value); }
		}

		/// <summary> The AlbumId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."AlbumId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> AlbumId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.AlbumId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.AlbumId, value); }
		}

		/// <summary> The BlogPostId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."BlogPostId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> BlogPostId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.BlogPostId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.BlogPostId, value); }
		}

		/// <summary> The MessageId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."MessageId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> MessageId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.MessageId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.MessageId, value); }
		}

		/// <summary> The DiscussionMessageId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."DiscussionMessageId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> DiscussionMessageId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.DiscussionMessageId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.DiscussionMessageId, value); }
		}

		/// <summary> The CustomId1 property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."CustomId1"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> CustomId1
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.CustomId1, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.CustomId1, value); }
		}

		/// <summary> The CustomId2 property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."CustomId2"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> CustomId2
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.CustomId2, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.CustomId2, value); }
		}

		/// <summary> The CustomId3 property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."CustomId3"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> CustomId3
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.CustomId3, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.CustomId3, value); }
		}

		/// <summary> The DiscussionBoardId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."DiscussionBoardId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> DiscussionBoardId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.DiscussionBoardId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.DiscussionBoardId, value); }
		}

		/// <summary> The DiscussionTopicId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."DiscussionTopicId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> DiscussionTopicId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.DiscussionTopicId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.DiscussionTopicId, value); }
		}

		/// <summary> The DocumentId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."DocumentId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> DocumentId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.DocumentId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.DocumentId, value); }
		}

		/// <summary> The NewsItemId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."NewsItemId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> NewsItemId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.NewsItemId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.NewsItemId, value); }
		}

		/// <summary> The ListItemId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."ListItemId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> ListItemId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.ListItemId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.ListItemId, value); }
		}

		/// <summary> The BlogId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."BlogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> BlogId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.BlogId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.BlogId, value); }
		}

		/// <summary> The ApplicationId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."ApplicationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> ApplicationId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.ApplicationId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.ApplicationId, value); }
		}

		/// <summary> The CalendarEventId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."CalendarEventId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> CalendarEventId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.CalendarEventId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.CalendarEventId, value); }
		}

		/// <summary> The CampaignId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."CampaignId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> CampaignId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.CampaignId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.CampaignId, value); }
		}

		/// <summary> The PageId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."PageId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> PageId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.PageId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.PageId, value); }
		}

		/// <summary> The UserId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> UserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.UserId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.UserId, value); }
		}

		/// <summary> The NewsCategoryId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."NewsCategoryId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> NewsCategoryId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.NewsCategoryId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.NewsCategoryId, value); }
		}

		/// <summary> The NewsletterId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."NewsletterId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> NewsletterId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.NewsletterId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.NewsletterId, value); }
		}

		/// <summary> The PollId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."PollId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> PollId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.PollId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.PollId, value); }
		}

		/// <summary> The GroupId property of the Entity SnRelationship<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnRelationship"."GroupId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> GroupId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnRelationshipFieldIndex.GroupId, false); }
			set	{ SetValue((int)SnRelationshipFieldIndex.GroupId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnCommentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnCommentEntity))]
		public virtual EntityCollection<SnCommentEntity> SnComments
		{
			get { return GetOrCreateEntityCollection<SnCommentEntity, SnCommentEntityFactory>("SnRelationship", true, false, ref _snComments);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnFileEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnFileEntity))]
		public virtual EntityCollection<SnFileEntity> SnFiles
		{
			get { return GetOrCreateEntityCollection<SnFileEntity, SnFileEntityFactory>("SnRelationship", true, false, ref _snFiles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRatingEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRatingEntity))]
		public virtual EntityCollection<SnRatingEntity> SnRatings
		{
			get { return GetOrCreateEntityCollection<SnRatingEntity, SnRatingEntityFactory>("SnRelationship", true, false, ref _snRatings);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnSubscriberEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnSubscriberEntity))]
		public virtual EntityCollection<SnSubscriberEntity> SnSubscribers
		{
			get { return GetOrCreateEntityCollection<SnSubscriberEntity, SnSubscriberEntityFactory>("SnRelationship", true, false, ref _snSubscribers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnTagEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnTagEntity))]
		public virtual EntityCollection<SnTagEntity> SnTags
		{
			get { return GetOrCreateEntityCollection<SnTagEntity, SnTagEntityFactory>("SnRelationship", true, false, ref _snTags);	}
		}

		/// <summary> Gets / sets related entity of type 'AspnetApplicationsEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual AspnetApplicationsEntity AspnetApplication
		{
			get	{ return _aspnetApplication; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAspnetApplication(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "", "AspnetApplication", _aspnetApplication, false); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AspnetUsersEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual AspnetUsersEntity AspnetUser
		{
			get	{ return _aspnetUser; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAspnetUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationshipss", "AspnetUser", _aspnetUser, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'BlogEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual BlogEntity Blog
		{
			get	{ return _blog; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncBlog(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "Blog", _blog, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'BlogPostEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual BlogPostEntity BlogPost
		{
			get	{ return _blogPost; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncBlogPost(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "BlogPost", _blogPost, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'CalendarEventEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual CalendarEventEntity CalendarEvent
		{
			get	{ return _calendarEvent; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCalendarEvent(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "CalendarEvent", _calendarEvent, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'CampaignEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual CampaignEntity Campaign
		{
			get	{ return _campaign; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCampaign(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationshipss", "Campaign", _campaign, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'DocumentEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual DocumentEntity Document
		{
			get	{ return _document; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncDocument(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "Document", _document, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ListItemEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual ListItemEntity ListItem
		{
			get	{ return _listItem; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncListItem(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "ListItem", _listItem, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'NewsCategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual NewsCategoryEntity NewsCategory
		{
			get	{ return _newsCategory; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncNewsCategory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationshipss", "NewsCategory", _newsCategory, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'NewsItemEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual NewsItemEntity NewsItem
		{
			get	{ return _newsItem; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncNewsItem(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "NewsItem", _newsItem, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'NewsletterEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual NewsletterEntity Newsletter
		{
			get	{ return _newsletter; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncNewsletter(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationshipss", "Newsletter", _newsletter, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'PageEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual PageEntity Page
		{
			get	{ return _page; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPage(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationshipss", "Page", _page, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'PollEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual PollEntity Poll
		{
			get	{ return _poll; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPoll(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationshipss", "Poll", _poll, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnAlbumEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnAlbumEntity SnAlbum
		{
			get	{ return _snAlbum; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnAlbum(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "SnAlbum", _snAlbum, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnDiscussionBoardEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnDiscussionBoardEntity SnDiscussionBoard
		{
			get	{ return _snDiscussionBoard; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnDiscussionBoard(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "SnDiscussionBoard", _snDiscussionBoard, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnDiscussionMessageEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnDiscussionMessageEntity SnDiscussionMessage
		{
			get	{ return _snDiscussionMessage; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnDiscussionMessage(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "SnDiscussionMessage", _snDiscussionMessage, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnDiscussionTopicEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnDiscussionTopicEntity SnDiscussionTopic
		{
			get	{ return _snDiscussionTopic; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnDiscussionTopic(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "SnDiscussionTopic", _snDiscussionTopic, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnFileEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnFileEntity SnFile
		{
			get	{ return _snFile; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnFile(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "SnFile", _snFile, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnGroupEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnGroupEntity SnGroup
		{
			get	{ return _snGroup; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnGroup(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationshipss", "SnGroup", _snGroup, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnMessageEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnMessageEntity SnMessage
		{
			get	{ return _snMessage; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnMessage(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "SnMessage", _snMessage, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnNoteEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnNoteEntity SnNote
		{
			get	{ return _snNote; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnNote(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnRelationships", "SnNote", _snNote, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity; }
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
