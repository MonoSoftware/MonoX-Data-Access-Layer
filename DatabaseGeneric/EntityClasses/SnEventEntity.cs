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
	/// <summary>Entity class which represents the entity 'SnEvent'.<br/><br/></summary>
	[Serializable]
	public partial class SnEventEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AspnetUsersEntity _aspnetUsers;
		private AspnetUsersEntity _friendAspnetUsers;
		private BlogPostEntity _blogPost;
		private OaConsumerEntity _oaConsumer;
		private SnAlbumEntity _snAlbum;
		private SnDiscussionBoardEntity _snDiscussionBoard;
		private SnDiscussionTopicEntity _snDiscussionTopic;
		private SnEventTypeEntity _snEventType;
		private SnFileEntity _snFile;
		private SnGroupEntity _snGroup;
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
			/// <summary>Member name AspnetUsers</summary>
			public static readonly string AspnetUsers = "AspnetUsers";
			/// <summary>Member name FriendAspnetUsers</summary>
			public static readonly string FriendAspnetUsers = "FriendAspnetUsers";
			/// <summary>Member name BlogPost</summary>
			public static readonly string BlogPost = "BlogPost";
			/// <summary>Member name OaConsumer</summary>
			public static readonly string OaConsumer = "OaConsumer";
			/// <summary>Member name SnAlbum</summary>
			public static readonly string SnAlbum = "SnAlbum";
			/// <summary>Member name SnDiscussionBoard</summary>
			public static readonly string SnDiscussionBoard = "SnDiscussionBoard";
			/// <summary>Member name SnDiscussionTopic</summary>
			public static readonly string SnDiscussionTopic = "SnDiscussionTopic";
			/// <summary>Member name SnEventType</summary>
			public static readonly string SnEventType = "SnEventType";
			/// <summary>Member name SnFile</summary>
			public static readonly string SnFile = "SnFile";
			/// <summary>Member name SnGroup</summary>
			public static readonly string SnGroup = "SnGroup";
			/// <summary>Member name SnNote</summary>
			public static readonly string SnNote = "SnNote";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SnEventEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SnEventEntity():base("SnEventEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SnEventEntity(IEntityFields2 fields):base("SnEventEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SnEventEntity</param>
		public SnEventEntity(IValidator validator):base("SnEventEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnEvent which data should be fetched into this SnEvent object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnEventEntity(System.Guid id):base("SnEventEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnEvent which data should be fetched into this SnEvent object</param>
		/// <param name="validator">The custom validator object for this SnEventEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnEventEntity(System.Guid id, IValidator validator):base("SnEventEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SnEventEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_aspnetUsers = (AspnetUsersEntity)info.GetValue("_aspnetUsers", typeof(AspnetUsersEntity));
				if(_aspnetUsers!=null)
				{
					_aspnetUsers.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_friendAspnetUsers = (AspnetUsersEntity)info.GetValue("_friendAspnetUsers", typeof(AspnetUsersEntity));
				if(_friendAspnetUsers!=null)
				{
					_friendAspnetUsers.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_blogPost = (BlogPostEntity)info.GetValue("_blogPost", typeof(BlogPostEntity));
				if(_blogPost!=null)
				{
					_blogPost.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_oaConsumer = (OaConsumerEntity)info.GetValue("_oaConsumer", typeof(OaConsumerEntity));
				if(_oaConsumer!=null)
				{
					_oaConsumer.AfterSave+=new EventHandler(OnEntityAfterSave);
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
				_snDiscussionTopic = (SnDiscussionTopicEntity)info.GetValue("_snDiscussionTopic", typeof(SnDiscussionTopicEntity));
				if(_snDiscussionTopic!=null)
				{
					_snDiscussionTopic.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snEventType = (SnEventTypeEntity)info.GetValue("_snEventType", typeof(SnEventTypeEntity));
				if(_snEventType!=null)
				{
					_snEventType.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SnEventFieldIndex)fieldIndex)
			{
				case SnEventFieldIndex.UserId:
					DesetupSyncAspnetUsers(true, false);
					break;
				case SnEventFieldIndex.EventTypeId:
					DesetupSyncSnEventType(true, false);
					break;
				case SnEventFieldIndex.FriendId:
					DesetupSyncFriendAspnetUsers(true, false);
					break;
				case SnEventFieldIndex.BlogPostId:
					DesetupSyncBlogPost(true, false);
					break;
				case SnEventFieldIndex.SnGroupId:
					DesetupSyncSnGroup(true, false);
					break;
				case SnEventFieldIndex.SnAlbumId:
					DesetupSyncSnAlbum(true, false);
					break;
				case SnEventFieldIndex.SnFileId:
					DesetupSyncSnFile(true, false);
					break;
				case SnEventFieldIndex.SnDiscussionBoardId:
					DesetupSyncSnDiscussionBoard(true, false);
					break;
				case SnEventFieldIndex.SnDiscussionTopicId:
					DesetupSyncSnDiscussionTopic(true, false);
					break;
				case SnEventFieldIndex.OaConsumerId:
					DesetupSyncOaConsumer(true, false);
					break;
				case SnEventFieldIndex.SnNoteId:
					DesetupSyncSnNote(true, false);
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
				case "AspnetUsers":
					this.AspnetUsers = (AspnetUsersEntity)entity;
					break;
				case "FriendAspnetUsers":
					this.FriendAspnetUsers = (AspnetUsersEntity)entity;
					break;
				case "BlogPost":
					this.BlogPost = (BlogPostEntity)entity;
					break;
				case "OaConsumer":
					this.OaConsumer = (OaConsumerEntity)entity;
					break;
				case "SnAlbum":
					this.SnAlbum = (SnAlbumEntity)entity;
					break;
				case "SnDiscussionBoard":
					this.SnDiscussionBoard = (SnDiscussionBoardEntity)entity;
					break;
				case "SnDiscussionTopic":
					this.SnDiscussionTopic = (SnDiscussionTopicEntity)entity;
					break;
				case "SnEventType":
					this.SnEventType = (SnEventTypeEntity)entity;
					break;
				case "SnFile":
					this.SnFile = (SnFileEntity)entity;
					break;
				case "SnGroup":
					this.SnGroup = (SnGroupEntity)entity;
					break;
				case "SnNote":
					this.SnNote = (SnNoteEntity)entity;
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
				case "AspnetUsers":
					toReturn.Add(Relations.AspnetUsersEntityUsingUserId);
					break;
				case "FriendAspnetUsers":
					toReturn.Add(Relations.AspnetUsersEntityUsingFriendId);
					break;
				case "BlogPost":
					toReturn.Add(Relations.BlogPostEntityUsingBlogPostId);
					break;
				case "OaConsumer":
					toReturn.Add(Relations.OaConsumerEntityUsingOaConsumerId);
					break;
				case "SnAlbum":
					toReturn.Add(Relations.SnAlbumEntityUsingSnAlbumId);
					break;
				case "SnDiscussionBoard":
					toReturn.Add(Relations.SnDiscussionBoardEntityUsingSnDiscussionBoardId);
					break;
				case "SnDiscussionTopic":
					toReturn.Add(Relations.SnDiscussionTopicEntityUsingSnDiscussionTopicId);
					break;
				case "SnEventType":
					toReturn.Add(Relations.SnEventTypeEntityUsingEventTypeId);
					break;
				case "SnFile":
					toReturn.Add(Relations.SnFileEntityUsingSnFileId);
					break;
				case "SnGroup":
					toReturn.Add(Relations.SnGroupEntityUsingSnGroupId);
					break;
				case "SnNote":
					toReturn.Add(Relations.SnNoteEntityUsingSnNoteId);
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
				case "SnEventType":
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
				case "AspnetUsers":
					SetupSyncAspnetUsers(relatedEntity);
					break;
				case "FriendAspnetUsers":
					SetupSyncFriendAspnetUsers(relatedEntity);
					break;
				case "BlogPost":
					SetupSyncBlogPost(relatedEntity);
					break;
				case "OaConsumer":
					SetupSyncOaConsumer(relatedEntity);
					break;
				case "SnAlbum":
					SetupSyncSnAlbum(relatedEntity);
					break;
				case "SnDiscussionBoard":
					SetupSyncSnDiscussionBoard(relatedEntity);
					break;
				case "SnDiscussionTopic":
					SetupSyncSnDiscussionTopic(relatedEntity);
					break;
				case "SnEventType":
					SetupSyncSnEventType(relatedEntity);
					break;
				case "SnFile":
					SetupSyncSnFile(relatedEntity);
					break;
				case "SnGroup":
					SetupSyncSnGroup(relatedEntity);
					break;
				case "SnNote":
					SetupSyncSnNote(relatedEntity);
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
				case "AspnetUsers":
					DesetupSyncAspnetUsers(false, true);
					break;
				case "FriendAspnetUsers":
					DesetupSyncFriendAspnetUsers(false, true);
					break;
				case "BlogPost":
					DesetupSyncBlogPost(false, true);
					break;
				case "OaConsumer":
					DesetupSyncOaConsumer(false, true);
					break;
				case "SnAlbum":
					DesetupSyncSnAlbum(false, true);
					break;
				case "SnDiscussionBoard":
					DesetupSyncSnDiscussionBoard(false, true);
					break;
				case "SnDiscussionTopic":
					DesetupSyncSnDiscussionTopic(false, true);
					break;
				case "SnEventType":
					DesetupSyncSnEventType(false, true);
					break;
				case "SnFile":
					DesetupSyncSnFile(false, true);
					break;
				case "SnGroup":
					DesetupSyncSnGroup(false, true);
					break;
				case "SnNote":
					DesetupSyncSnNote(false, true);
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
			if(_aspnetUsers!=null)
			{
				toReturn.Add(_aspnetUsers);
			}
			if(_friendAspnetUsers!=null)
			{
				toReturn.Add(_friendAspnetUsers);
			}
			if(_blogPost!=null)
			{
				toReturn.Add(_blogPost);
			}
			if(_oaConsumer!=null)
			{
				toReturn.Add(_oaConsumer);
			}
			if(_snAlbum!=null)
			{
				toReturn.Add(_snAlbum);
			}
			if(_snDiscussionBoard!=null)
			{
				toReturn.Add(_snDiscussionBoard);
			}
			if(_snDiscussionTopic!=null)
			{
				toReturn.Add(_snDiscussionTopic);
			}
			if(_snEventType!=null)
			{
				toReturn.Add(_snEventType);
			}
			if(_snFile!=null)
			{
				toReturn.Add(_snFile);
			}
			if(_snGroup!=null)
			{
				toReturn.Add(_snGroup);
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
				info.AddValue("_aspnetUsers", (!this.MarkedForDeletion?_aspnetUsers:null));
				info.AddValue("_friendAspnetUsers", (!this.MarkedForDeletion?_friendAspnetUsers:null));
				info.AddValue("_blogPost", (!this.MarkedForDeletion?_blogPost:null));
				info.AddValue("_oaConsumer", (!this.MarkedForDeletion?_oaConsumer:null));
				info.AddValue("_snAlbum", (!this.MarkedForDeletion?_snAlbum:null));
				info.AddValue("_snDiscussionBoard", (!this.MarkedForDeletion?_snDiscussionBoard:null));
				info.AddValue("_snDiscussionTopic", (!this.MarkedForDeletion?_snDiscussionTopic:null));
				info.AddValue("_snEventType", (!this.MarkedForDeletion?_snEventType:null));
				info.AddValue("_snFile", (!this.MarkedForDeletion?_snFile:null));
				info.AddValue("_snGroup", (!this.MarkedForDeletion?_snGroup:null));
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
			return new SnEventRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetUsers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoFriendAspnetUsers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.FriendId));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'OaConsumer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOaConsumer()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(OaConsumerFields.Id, null, ComparisonOperator.Equal, this.OaConsumerId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnAlbum' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnAlbum()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnAlbumFields.Id, null, ComparisonOperator.Equal, this.SnAlbumId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnDiscussionBoard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionBoard()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionBoardFields.Id, null, ComparisonOperator.Equal, this.SnDiscussionBoardId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnDiscussionTopic' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionTopic()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionTopicFields.Id, null, ComparisonOperator.Equal, this.SnDiscussionTopicId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnEventType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnEventType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnEventTypeFields.Id, null, ComparisonOperator.Equal, this.EventTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnFile' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFile()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFileFields.Id, null, ComparisonOperator.Equal, this.SnFileId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnGroup' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnGroup()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnGroupFields.Id, null, ComparisonOperator.Equal, this.SnGroupId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnNote' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnNote()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnNoteFields.Id, null, ComparisonOperator.Equal, this.SnNoteId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetUsers", _aspnetUsers);
			toReturn.Add("FriendAspnetUsers", _friendAspnetUsers);
			toReturn.Add("BlogPost", _blogPost);
			toReturn.Add("OaConsumer", _oaConsumer);
			toReturn.Add("SnAlbum", _snAlbum);
			toReturn.Add("SnDiscussionBoard", _snDiscussionBoard);
			toReturn.Add("SnDiscussionTopic", _snDiscussionTopic);
			toReturn.Add("SnEventType", _snEventType);
			toReturn.Add("SnFile", _snFile);
			toReturn.Add("SnGroup", _snGroup);
			toReturn.Add("SnNote", _snNote);
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
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EventTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FriendId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BlogPostId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SnGroupId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SnAlbumId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SnFileId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SnDiscussionBoardId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SnDiscussionTopicId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OaConsumerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomId1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomId2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomId3", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EventContent", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PlainEventTitle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PlainEventUrl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SnNoteId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetUsers</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetUsers(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetUsers, new PropertyChangedEventHandler( OnAspnetUsersPropertyChanged ), "AspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "SnEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.UserId } );
			_aspnetUsers = null;
		}

		/// <summary> setups the sync logic for member _aspnetUsers</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetUsers(IEntityCore relatedEntity)
		{
			if(_aspnetUsers!=relatedEntity)
			{
				DesetupSyncAspnetUsers(true, true);
				_aspnetUsers = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetUsers, new PropertyChangedEventHandler( OnAspnetUsersPropertyChanged ), "AspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAspnetUsersPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _friendAspnetUsers</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncFriendAspnetUsers(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _friendAspnetUsers, new PropertyChangedEventHandler( OnFriendAspnetUsersPropertyChanged ), "FriendAspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.AspnetUsersEntityUsingFriendIdStatic, true, signalRelatedEntity, "SnFriendEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.FriendId } );
			_friendAspnetUsers = null;
		}

		/// <summary> setups the sync logic for member _friendAspnetUsers</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncFriendAspnetUsers(IEntityCore relatedEntity)
		{
			if(_friendAspnetUsers!=relatedEntity)
			{
				DesetupSyncFriendAspnetUsers(true, true);
				_friendAspnetUsers = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _friendAspnetUsers, new PropertyChangedEventHandler( OnFriendAspnetUsersPropertyChanged ), "FriendAspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.AspnetUsersEntityUsingFriendIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnFriendAspnetUsersPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _blogPost, new PropertyChangedEventHandler( OnBlogPostPropertyChanged ), "BlogPost", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.BlogPostEntityUsingBlogPostIdStatic, true, signalRelatedEntity, "SnEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.BlogPostId } );
			_blogPost = null;
		}

		/// <summary> setups the sync logic for member _blogPost</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBlogPost(IEntityCore relatedEntity)
		{
			if(_blogPost!=relatedEntity)
			{
				DesetupSyncBlogPost(true, true);
				_blogPost = (BlogPostEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _blogPost, new PropertyChangedEventHandler( OnBlogPostPropertyChanged ), "BlogPost", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.BlogPostEntityUsingBlogPostIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _oaConsumer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncOaConsumer(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _oaConsumer, new PropertyChangedEventHandler( OnOaConsumerPropertyChanged ), "OaConsumer", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.OaConsumerEntityUsingOaConsumerIdStatic, true, signalRelatedEntity, "SnEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.OaConsumerId } );
			_oaConsumer = null;
		}

		/// <summary> setups the sync logic for member _oaConsumer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncOaConsumer(IEntityCore relatedEntity)
		{
			if(_oaConsumer!=relatedEntity)
			{
				DesetupSyncOaConsumer(true, true);
				_oaConsumer = (OaConsumerEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _oaConsumer, new PropertyChangedEventHandler( OnOaConsumerPropertyChanged ), "OaConsumer", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.OaConsumerEntityUsingOaConsumerIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnOaConsumerPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _snAlbum, new PropertyChangedEventHandler( OnSnAlbumPropertyChanged ), "SnAlbum", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnAlbumEntityUsingSnAlbumIdStatic, true, signalRelatedEntity, "SnEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.SnAlbumId } );
			_snAlbum = null;
		}

		/// <summary> setups the sync logic for member _snAlbum</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnAlbum(IEntityCore relatedEntity)
		{
			if(_snAlbum!=relatedEntity)
			{
				DesetupSyncSnAlbum(true, true);
				_snAlbum = (SnAlbumEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snAlbum, new PropertyChangedEventHandler( OnSnAlbumPropertyChanged ), "SnAlbum", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnAlbumEntityUsingSnAlbumIdStatic, true, new string[] {  } );
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
			this.PerformDesetupSyncRelatedEntity( _snDiscussionBoard, new PropertyChangedEventHandler( OnSnDiscussionBoardPropertyChanged ), "SnDiscussionBoard", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnDiscussionBoardEntityUsingSnDiscussionBoardIdStatic, true, signalRelatedEntity, "SnEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.SnDiscussionBoardId } );
			_snDiscussionBoard = null;
		}

		/// <summary> setups the sync logic for member _snDiscussionBoard</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnDiscussionBoard(IEntityCore relatedEntity)
		{
			if(_snDiscussionBoard!=relatedEntity)
			{
				DesetupSyncSnDiscussionBoard(true, true);
				_snDiscussionBoard = (SnDiscussionBoardEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snDiscussionBoard, new PropertyChangedEventHandler( OnSnDiscussionBoardPropertyChanged ), "SnDiscussionBoard", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnDiscussionBoardEntityUsingSnDiscussionBoardIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _snDiscussionTopic</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnDiscussionTopic(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snDiscussionTopic, new PropertyChangedEventHandler( OnSnDiscussionTopicPropertyChanged ), "SnDiscussionTopic", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnDiscussionTopicEntityUsingSnDiscussionTopicIdStatic, true, signalRelatedEntity, "SnEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.SnDiscussionTopicId } );
			_snDiscussionTopic = null;
		}

		/// <summary> setups the sync logic for member _snDiscussionTopic</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnDiscussionTopic(IEntityCore relatedEntity)
		{
			if(_snDiscussionTopic!=relatedEntity)
			{
				DesetupSyncSnDiscussionTopic(true, true);
				_snDiscussionTopic = (SnDiscussionTopicEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snDiscussionTopic, new PropertyChangedEventHandler( OnSnDiscussionTopicPropertyChanged ), "SnDiscussionTopic", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnDiscussionTopicEntityUsingSnDiscussionTopicIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _snEventType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnEventType(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snEventType, new PropertyChangedEventHandler( OnSnEventTypePropertyChanged ), "SnEventType", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnEventTypeEntityUsingEventTypeIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnEventFieldIndex.EventTypeId } );
			_snEventType = null;
		}

		/// <summary> setups the sync logic for member _snEventType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnEventType(IEntityCore relatedEntity)
		{
			if(_snEventType!=relatedEntity)
			{
				DesetupSyncSnEventType(true, true);
				_snEventType = (SnEventTypeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snEventType, new PropertyChangedEventHandler( OnSnEventTypePropertyChanged ), "SnEventType", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnEventTypeEntityUsingEventTypeIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnEventTypePropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _snFile, new PropertyChangedEventHandler( OnSnFilePropertyChanged ), "SnFile", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnFileEntityUsingSnFileIdStatic, true, signalRelatedEntity, "SnEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.SnFileId } );
			_snFile = null;
		}

		/// <summary> setups the sync logic for member _snFile</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnFile(IEntityCore relatedEntity)
		{
			if(_snFile!=relatedEntity)
			{
				DesetupSyncSnFile(true, true);
				_snFile = (SnFileEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snFile, new PropertyChangedEventHandler( OnSnFilePropertyChanged ), "SnFile", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnFileEntityUsingSnFileIdStatic, true, new string[] {  } );
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
			this.PerformDesetupSyncRelatedEntity( _snGroup, new PropertyChangedEventHandler( OnSnGroupPropertyChanged ), "SnGroup", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnGroupEntityUsingSnGroupIdStatic, true, signalRelatedEntity, "SnEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.SnGroupId } );
			_snGroup = null;
		}

		/// <summary> setups the sync logic for member _snGroup</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnGroup(IEntityCore relatedEntity)
		{
			if(_snGroup!=relatedEntity)
			{
				DesetupSyncSnGroup(true, true);
				_snGroup = (SnGroupEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snGroup, new PropertyChangedEventHandler( OnSnGroupPropertyChanged ), "SnGroup", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnGroupEntityUsingSnGroupIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _snNote</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnNote(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snNote, new PropertyChangedEventHandler( OnSnNotePropertyChanged ), "SnNote", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnNoteEntityUsingSnNoteIdStatic, true, signalRelatedEntity, "SnEvents", resetFKFields, new int[] { (int)SnEventFieldIndex.SnNoteId } );
			_snNote = null;
		}

		/// <summary> setups the sync logic for member _snNote</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnNote(IEntityCore relatedEntity)
		{
			if(_snNote!=relatedEntity)
			{
				DesetupSyncSnNote(true, true);
				_snNote = (SnNoteEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snNote, new PropertyChangedEventHandler( OnSnNotePropertyChanged ), "SnNote", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnEventRelations.SnNoteEntityUsingSnNoteIdStatic, true, new string[] {  } );
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
		/// <param name="validator">The validator object for this SnEventEntity</param>
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
		public  static SnEventRelations Relations
		{
			get	{ return new SnEventRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUsers
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUsers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUsers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathFriendAspnetUsers
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("FriendAspnetUsers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "FriendAspnetUsers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BlogPost' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBlogPost
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(BlogPostEntityFactory))),	(IEntityRelation)GetRelationsForField("BlogPost")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.BlogPostEntity, 0, null, null, null, null, "BlogPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'OaConsumer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOaConsumer
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(OaConsumerEntityFactory))),	(IEntityRelation)GetRelationsForField("OaConsumer")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.OaConsumerEntity, 0, null, null, null, null, "OaConsumer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnAlbum' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnAlbum
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnAlbumEntityFactory))),	(IEntityRelation)GetRelationsForField("SnAlbum")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnAlbumEntity, 0, null, null, null, null, "SnAlbum", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionBoard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionBoard
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardEntityFactory))),	(IEntityRelation)GetRelationsForField("SnDiscussionBoard")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, 0, null, null, null, null, "SnDiscussionBoard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionTopic' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionTopic
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionTopicEntityFactory))),	(IEntityRelation)GetRelationsForField("SnDiscussionTopic")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, 0, null, null, null, null, "SnDiscussionTopic", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnEventType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnEventType
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnEventTypeEntityFactory))),	(IEntityRelation)GetRelationsForField("SnEventType")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnEventTypeEntity, 0, null, null, null, null, "SnEventType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFile' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFile
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnFileEntityFactory))),	(IEntityRelation)GetRelationsForField("SnFile")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, 0, null, null, null, null, "SnFile", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnGroup' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnGroup
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupEntityFactory))),	(IEntityRelation)GetRelationsForField("SnGroup")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, 0, null, null, null, null, "SnGroup", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnNote' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnNote
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))),	(IEntityRelation)GetRelationsForField("SnNote")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnNoteEntity, 0, null, null, null, null, "SnNote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>		
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)SnEventFieldIndex.Id, true); }
			set	{ SetValue((int)SnEventFieldIndex.Id, value); }
		}

		/// <summary> The UserId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid UserId
		{
			get { return (System.Guid)GetValue((int)SnEventFieldIndex.UserId, true); }
			set	{ SetValue((int)SnEventFieldIndex.UserId, value); }
		}

		/// <summary> The EventTypeId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."EventTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid EventTypeId
		{
			get { return (System.Guid)GetValue((int)SnEventFieldIndex.EventTypeId, true); }
			set	{ SetValue((int)SnEventFieldIndex.EventTypeId, value); }
		}

		/// <summary> The DateCreated property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)SnEventFieldIndex.DateCreated, true); }
			set	{ SetValue((int)SnEventFieldIndex.DateCreated, value); }
		}

		/// <summary> The FriendId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."FriendId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> FriendId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.FriendId, false); }
			set	{ SetValue((int)SnEventFieldIndex.FriendId, value); }
		}

		/// <summary> The BlogPostId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."BlogPostId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> BlogPostId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.BlogPostId, false); }
			set	{ SetValue((int)SnEventFieldIndex.BlogPostId, value); }
		}

		/// <summary> The SnGroupId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."SnGroupId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> SnGroupId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.SnGroupId, false); }
			set	{ SetValue((int)SnEventFieldIndex.SnGroupId, value); }
		}

		/// <summary> The SnAlbumId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."SnAlbumId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> SnAlbumId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.SnAlbumId, false); }
			set	{ SetValue((int)SnEventFieldIndex.SnAlbumId, value); }
		}

		/// <summary> The SnFileId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."SnFileId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> SnFileId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.SnFileId, false); }
			set	{ SetValue((int)SnEventFieldIndex.SnFileId, value); }
		}

		/// <summary> The SnDiscussionBoardId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."SnDiscussionBoardId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> SnDiscussionBoardId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.SnDiscussionBoardId, false); }
			set	{ SetValue((int)SnEventFieldIndex.SnDiscussionBoardId, value); }
		}

		/// <summary> The SnDiscussionTopicId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."SnDiscussionTopicId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> SnDiscussionTopicId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.SnDiscussionTopicId, false); }
			set	{ SetValue((int)SnEventFieldIndex.SnDiscussionTopicId, value); }
		}

		/// <summary> The OaConsumerId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."OaConsumerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> OaConsumerId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.OaConsumerId, false); }
			set	{ SetValue((int)SnEventFieldIndex.OaConsumerId, value); }
		}

		/// <summary> The CustomId1 property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."CustomId1"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> CustomId1
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.CustomId1, false); }
			set	{ SetValue((int)SnEventFieldIndex.CustomId1, value); }
		}

		/// <summary> The CustomId2 property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."CustomId2"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> CustomId2
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.CustomId2, false); }
			set	{ SetValue((int)SnEventFieldIndex.CustomId2, value); }
		}

		/// <summary> The CustomId3 property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."CustomId3"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> CustomId3
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.CustomId3, false); }
			set	{ SetValue((int)SnEventFieldIndex.CustomId3, value); }
		}

		/// <summary> The EventContent property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."EventContent"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String EventContent
		{
			get { return (System.String)GetValue((int)SnEventFieldIndex.EventContent, true); }
			set	{ SetValue((int)SnEventFieldIndex.EventContent, value); }
		}

		/// <summary> The PlainEventTitle property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."PlainEventTitle"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String PlainEventTitle
		{
			get { return (System.String)GetValue((int)SnEventFieldIndex.PlainEventTitle, true); }
			set	{ SetValue((int)SnEventFieldIndex.PlainEventTitle, value); }
		}

		/// <summary> The PlainEventUrl property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."PlainEventUrl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String PlainEventUrl
		{
			get { return (System.String)GetValue((int)SnEventFieldIndex.PlainEventUrl, true); }
			set	{ SetValue((int)SnEventFieldIndex.PlainEventUrl, value); }
		}

		/// <summary> The SnNoteId property of the Entity SnEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnEvent"."SnNoteId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> SnNoteId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnEventFieldIndex.SnNoteId, false); }
			set	{ SetValue((int)SnEventFieldIndex.SnNoteId, value); }
		}

		/// <summary> Gets / sets related entity of type 'AspnetUsersEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual AspnetUsersEntity AspnetUsers
		{
			get	{ return _aspnetUsers; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAspnetUsers(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnEvents", "AspnetUsers", _aspnetUsers, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AspnetUsersEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual AspnetUsersEntity FriendAspnetUsers
		{
			get	{ return _friendAspnetUsers; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncFriendAspnetUsers(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnFriendEvents", "FriendAspnetUsers", _friendAspnetUsers, true); 
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
					SetSingleRelatedEntityNavigator(value, "SnEvents", "BlogPost", _blogPost, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'OaConsumerEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual OaConsumerEntity OaConsumer
		{
			get	{ return _oaConsumer; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncOaConsumer(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnEvents", "OaConsumer", _oaConsumer, true); 
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
					SetSingleRelatedEntityNavigator(value, "SnEvents", "SnAlbum", _snAlbum, true); 
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
					SetSingleRelatedEntityNavigator(value, "SnEvents", "SnDiscussionBoard", _snDiscussionBoard, true); 
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
					SetSingleRelatedEntityNavigator(value, "SnEvents", "SnDiscussionTopic", _snDiscussionTopic, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnEventTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual SnEventTypeEntity SnEventType
		{
			get	{ return _snEventType; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnEventType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "", "SnEventType", _snEventType, false); 
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
					SetSingleRelatedEntityNavigator(value, "SnEvents", "SnFile", _snFile, true); 
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
					SetSingleRelatedEntityNavigator(value, "SnEvents", "SnGroup", _snGroup, true); 
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
					SetSingleRelatedEntityNavigator(value, "SnEvents", "SnNote", _snNote, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity; }
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
