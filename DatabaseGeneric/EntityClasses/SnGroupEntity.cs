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
	/// <summary>Entity class which represents the entity 'SnGroup'.<br/><br/></summary>
	[Serializable]
	public partial class SnGroupEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SnAlbumEntity> _snAlbum;
		private EntityCollection<SnDiscussionBoardEntity> _snDiscussionBoard;
		private EntityCollection<SnEventEntity> _snEvents;
		private EntityCollection<SnGroupMemberEntity> _snGroupMembers;
		private EntityCollection<SnGroupRequestEntity> _snGroupRequests;
		private EntityCollection<SnNoteEntity> _snNotes;
		private EntityCollection<SnRelationshipEntity> _snRelationshipss;
		private AspnetUsersEntity _aspnetUser;
		private SnGroupCategoryEntity _snGroupCategory;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AspnetUser</summary>
			public static readonly string AspnetUser = "AspnetUser";
			/// <summary>Member name SnGroupCategory</summary>
			public static readonly string SnGroupCategory = "SnGroupCategory";
			/// <summary>Member name SnAlbum</summary>
			public static readonly string SnAlbum = "SnAlbum";
			/// <summary>Member name SnDiscussionBoard</summary>
			public static readonly string SnDiscussionBoard = "SnDiscussionBoard";
			/// <summary>Member name SnEvents</summary>
			public static readonly string SnEvents = "SnEvents";
			/// <summary>Member name SnGroupMembers</summary>
			public static readonly string SnGroupMembers = "SnGroupMembers";
			/// <summary>Member name SnGroupRequests</summary>
			public static readonly string SnGroupRequests = "SnGroupRequests";
			/// <summary>Member name SnNotes</summary>
			public static readonly string SnNotes = "SnNotes";
			/// <summary>Member name SnRelationshipss</summary>
			public static readonly string SnRelationshipss = "SnRelationshipss";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SnGroupEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SnGroupEntity():base("SnGroupEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SnGroupEntity(IEntityFields2 fields):base("SnGroupEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SnGroupEntity</param>
		public SnGroupEntity(IValidator validator):base("SnGroupEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnGroup which data should be fetched into this SnGroup object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnGroupEntity(System.Guid id):base("SnGroupEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnGroup which data should be fetched into this SnGroup object</param>
		/// <param name="validator">The custom validator object for this SnGroupEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnGroupEntity(System.Guid id, IValidator validator):base("SnGroupEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SnGroupEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_snAlbum = (EntityCollection<SnAlbumEntity>)info.GetValue("_snAlbum", typeof(EntityCollection<SnAlbumEntity>));
				_snDiscussionBoard = (EntityCollection<SnDiscussionBoardEntity>)info.GetValue("_snDiscussionBoard", typeof(EntityCollection<SnDiscussionBoardEntity>));
				_snEvents = (EntityCollection<SnEventEntity>)info.GetValue("_snEvents", typeof(EntityCollection<SnEventEntity>));
				_snGroupMembers = (EntityCollection<SnGroupMemberEntity>)info.GetValue("_snGroupMembers", typeof(EntityCollection<SnGroupMemberEntity>));
				_snGroupRequests = (EntityCollection<SnGroupRequestEntity>)info.GetValue("_snGroupRequests", typeof(EntityCollection<SnGroupRequestEntity>));
				_snNotes = (EntityCollection<SnNoteEntity>)info.GetValue("_snNotes", typeof(EntityCollection<SnNoteEntity>));
				_snRelationshipss = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationshipss", typeof(EntityCollection<SnRelationshipEntity>));
				_aspnetUser = (AspnetUsersEntity)info.GetValue("_aspnetUser", typeof(AspnetUsersEntity));
				if(_aspnetUser!=null)
				{
					_aspnetUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snGroupCategory = (SnGroupCategoryEntity)info.GetValue("_snGroupCategory", typeof(SnGroupCategoryEntity));
				if(_snGroupCategory!=null)
				{
					_snGroupCategory.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SnGroupFieldIndex)fieldIndex)
			{
				case SnGroupFieldIndex.UserId:
					DesetupSyncAspnetUser(true, false);
					break;
				case SnGroupFieldIndex.GroupCategoryId:
					DesetupSyncSnGroupCategory(true, false);
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
				case "AspnetUser":
					this.AspnetUser = (AspnetUsersEntity)entity;
					break;
				case "SnGroupCategory":
					this.SnGroupCategory = (SnGroupCategoryEntity)entity;
					break;
				case "SnAlbum":
					this.SnAlbum.Add((SnAlbumEntity)entity);
					break;
				case "SnDiscussionBoard":
					this.SnDiscussionBoard.Add((SnDiscussionBoardEntity)entity);
					break;
				case "SnEvents":
					this.SnEvents.Add((SnEventEntity)entity);
					break;
				case "SnGroupMembers":
					this.SnGroupMembers.Add((SnGroupMemberEntity)entity);
					break;
				case "SnGroupRequests":
					this.SnGroupRequests.Add((SnGroupRequestEntity)entity);
					break;
				case "SnNotes":
					this.SnNotes.Add((SnNoteEntity)entity);
					break;
				case "SnRelationshipss":
					this.SnRelationshipss.Add((SnRelationshipEntity)entity);
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
				case "AspnetUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingUserId);
					break;
				case "SnGroupCategory":
					toReturn.Add(Relations.SnGroupCategoryEntityUsingGroupCategoryId);
					break;
				case "SnAlbum":
					toReturn.Add(Relations.SnAlbumEntityUsingSnGroupId);
					break;
				case "SnDiscussionBoard":
					toReturn.Add(Relations.SnDiscussionBoardEntityUsingSnGroupId);
					break;
				case "SnEvents":
					toReturn.Add(Relations.SnEventEntityUsingSnGroupId);
					break;
				case "SnGroupMembers":
					toReturn.Add(Relations.SnGroupMemberEntityUsingGroupId);
					break;
				case "SnGroupRequests":
					toReturn.Add(Relations.SnGroupRequestEntityUsingGroupId);
					break;
				case "SnNotes":
					toReturn.Add(Relations.SnNoteEntityUsingGroupId);
					break;
				case "SnRelationshipss":
					toReturn.Add(Relations.SnRelationshipEntityUsingGroupId);
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
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
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
				case "AspnetUser":
					SetupSyncAspnetUser(relatedEntity);
					break;
				case "SnGroupCategory":
					SetupSyncSnGroupCategory(relatedEntity);
					break;
				case "SnAlbum":
					this.SnAlbum.Add((SnAlbumEntity)relatedEntity);
					break;
				case "SnDiscussionBoard":
					this.SnDiscussionBoard.Add((SnDiscussionBoardEntity)relatedEntity);
					break;
				case "SnEvents":
					this.SnEvents.Add((SnEventEntity)relatedEntity);
					break;
				case "SnGroupMembers":
					this.SnGroupMembers.Add((SnGroupMemberEntity)relatedEntity);
					break;
				case "SnGroupRequests":
					this.SnGroupRequests.Add((SnGroupRequestEntity)relatedEntity);
					break;
				case "SnNotes":
					this.SnNotes.Add((SnNoteEntity)relatedEntity);
					break;
				case "SnRelationshipss":
					this.SnRelationshipss.Add((SnRelationshipEntity)relatedEntity);
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
				case "AspnetUser":
					DesetupSyncAspnetUser(false, true);
					break;
				case "SnGroupCategory":
					DesetupSyncSnGroupCategory(false, true);
					break;
				case "SnAlbum":
					this.PerformRelatedEntityRemoval(this.SnAlbum, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnDiscussionBoard":
					this.PerformRelatedEntityRemoval(this.SnDiscussionBoard, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnEvents":
					this.PerformRelatedEntityRemoval(this.SnEvents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnGroupMembers":
					this.PerformRelatedEntityRemoval(this.SnGroupMembers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnGroupRequests":
					this.PerformRelatedEntityRemoval(this.SnGroupRequests, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnNotes":
					this.PerformRelatedEntityRemoval(this.SnNotes, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnRelationshipss":
					this.PerformRelatedEntityRemoval(this.SnRelationshipss, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_aspnetUser!=null)
			{
				toReturn.Add(_aspnetUser);
			}
			if(_snGroupCategory!=null)
			{
				toReturn.Add(_snGroupCategory);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SnAlbum);
			toReturn.Add(this.SnDiscussionBoard);
			toReturn.Add(this.SnEvents);
			toReturn.Add(this.SnGroupMembers);
			toReturn.Add(this.SnGroupRequests);
			toReturn.Add(this.SnNotes);
			toReturn.Add(this.SnRelationshipss);
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
				info.AddValue("_snAlbum", ((_snAlbum!=null) && (_snAlbum.Count>0) && !this.MarkedForDeletion)?_snAlbum:null);
				info.AddValue("_snDiscussionBoard", ((_snDiscussionBoard!=null) && (_snDiscussionBoard.Count>0) && !this.MarkedForDeletion)?_snDiscussionBoard:null);
				info.AddValue("_snEvents", ((_snEvents!=null) && (_snEvents.Count>0) && !this.MarkedForDeletion)?_snEvents:null);
				info.AddValue("_snGroupMembers", ((_snGroupMembers!=null) && (_snGroupMembers.Count>0) && !this.MarkedForDeletion)?_snGroupMembers:null);
				info.AddValue("_snGroupRequests", ((_snGroupRequests!=null) && (_snGroupRequests.Count>0) && !this.MarkedForDeletion)?_snGroupRequests:null);
				info.AddValue("_snNotes", ((_snNotes!=null) && (_snNotes.Count>0) && !this.MarkedForDeletion)?_snNotes:null);
				info.AddValue("_snRelationshipss", ((_snRelationshipss!=null) && (_snRelationshipss.Count>0) && !this.MarkedForDeletion)?_snRelationshipss:null);
				info.AddValue("_aspnetUser", (!this.MarkedForDeletion?_aspnetUser:null));
				info.AddValue("_snGroupCategory", (!this.MarkedForDeletion?_snGroupCategory:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SnGroupRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnAlbum' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnAlbum()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnAlbumFields.SnGroupId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnDiscussionBoard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionBoard()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionBoardFields.SnGroupId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnEvent' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnEvents()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnEventFields.SnGroupId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnGroupMember' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnGroupMembers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnGroupMemberFields.GroupId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnGroupRequest' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnGroupRequests()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnGroupRequestFields.GroupId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnNote' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnNotes()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnNoteFields.GroupId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationshipss()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.GroupId, null, ComparisonOperator.Equal, this.Id));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnGroupCategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnGroupCategory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnGroupCategoryFields.Id, null, ComparisonOperator.Equal, this.GroupCategoryId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SnGroupEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._snAlbum);
			collectionsQueue.Enqueue(this._snDiscussionBoard);
			collectionsQueue.Enqueue(this._snEvents);
			collectionsQueue.Enqueue(this._snGroupMembers);
			collectionsQueue.Enqueue(this._snGroupRequests);
			collectionsQueue.Enqueue(this._snNotes);
			collectionsQueue.Enqueue(this._snRelationshipss);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._snAlbum = (EntityCollection<SnAlbumEntity>) collectionsQueue.Dequeue();
			this._snDiscussionBoard = (EntityCollection<SnDiscussionBoardEntity>) collectionsQueue.Dequeue();
			this._snEvents = (EntityCollection<SnEventEntity>) collectionsQueue.Dequeue();
			this._snGroupMembers = (EntityCollection<SnGroupMemberEntity>) collectionsQueue.Dequeue();
			this._snGroupRequests = (EntityCollection<SnGroupRequestEntity>) collectionsQueue.Dequeue();
			this._snNotes = (EntityCollection<SnNoteEntity>) collectionsQueue.Dequeue();
			this._snRelationshipss = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._snAlbum != null);
			toReturn |=(this._snDiscussionBoard != null);
			toReturn |=(this._snEvents != null);
			toReturn |=(this._snGroupMembers != null);
			toReturn |=(this._snGroupRequests != null);
			toReturn |=(this._snNotes != null);
			toReturn |=(this._snRelationshipss != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnAlbumEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnAlbumEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnDiscussionBoardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnGroupMemberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupMemberEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnGroupRequestEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupRequestEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnNoteEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetUser", _aspnetUser);
			toReturn.Add("SnGroupCategory", _snGroupCategory);
			toReturn.Add("SnAlbum", _snAlbum);
			toReturn.Add("SnDiscussionBoard", _snDiscussionBoard);
			toReturn.Add("SnEvents", _snEvents);
			toReturn.Add("SnGroupMembers", _snGroupMembers);
			toReturn.Add("SnGroupRequests", _snGroupRequests);
			toReturn.Add("SnNotes", _snNotes);
			toReturn.Add("SnRelationshipss", _snRelationshipss);
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
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MemberCount", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsPublic", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ImageUrl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GroupCategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Slug", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnGroupRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "SnGroups", resetFKFields, new int[] { (int)SnGroupFieldIndex.UserId } );
			_aspnetUser = null;
		}

		/// <summary> setups the sync logic for member _aspnetUser</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetUser(IEntityCore relatedEntity)
		{
			if(_aspnetUser!=relatedEntity)
			{
				DesetupSyncAspnetUser(true, true);
				_aspnetUser = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnGroupRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _snGroupCategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnGroupCategory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snGroupCategory, new PropertyChangedEventHandler( OnSnGroupCategoryPropertyChanged ), "SnGroupCategory", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnGroupRelations.SnGroupCategoryEntityUsingGroupCategoryIdStatic, true, signalRelatedEntity, "SnGroups", resetFKFields, new int[] { (int)SnGroupFieldIndex.GroupCategoryId } );
			_snGroupCategory = null;
		}

		/// <summary> setups the sync logic for member _snGroupCategory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnGroupCategory(IEntityCore relatedEntity)
		{
			if(_snGroupCategory!=relatedEntity)
			{
				DesetupSyncSnGroupCategory(true, true);
				_snGroupCategory = (SnGroupCategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snGroupCategory, new PropertyChangedEventHandler( OnSnGroupCategoryPropertyChanged ), "SnGroupCategory", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnGroupRelations.SnGroupCategoryEntityUsingGroupCategoryIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnGroupCategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SnGroupEntity</param>
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
		public  static SnGroupRelations Relations
		{
			get	{ return new SnGroupRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnAlbum' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnAlbum
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnAlbumEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnAlbumEntityFactory))), (IEntityRelation)GetRelationsForField("SnAlbum")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnAlbumEntity, 0, null, null, null, null, "SnAlbum", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionBoard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionBoard
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnDiscussionBoardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardEntityFactory))), (IEntityRelation)GetRelationsForField("SnDiscussionBoard")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, 0, null, null, null, null, "SnDiscussionBoard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnEvents
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))), (IEntityRelation)GetRelationsForField("SnEvents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, 0, null, null, null, null, "SnEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnGroupMember' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnGroupMembers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnGroupMemberEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupMemberEntityFactory))), (IEntityRelation)GetRelationsForField("SnGroupMembers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupMemberEntity, 0, null, null, null, null, "SnGroupMembers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnGroupRequest' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnGroupRequests
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnGroupRequestEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupRequestEntityFactory))), (IEntityRelation)GetRelationsForField("SnGroupRequests")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupRequestEntity, 0, null, null, null, null, "SnGroupRequests", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnNote' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnNotes
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnNoteEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))), (IEntityRelation)GetRelationsForField("SnNotes")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnNoteEntity, 0, null, null, null, null, "SnNotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationshipss
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationshipss")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationshipss", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnGroupCategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnGroupCategory
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupCategoryEntityFactory))),	(IEntityRelation)GetRelationsForField("SnGroupCategory")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupCategoryEntity, 0, null, null, null, null, "SnGroupCategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>		
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)SnGroupFieldIndex.Id, true); }
			set	{ SetValue((int)SnGroupFieldIndex.Id, value); }
		}

		/// <summary> The Name property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SnGroupFieldIndex.Name, true); }
			set	{ SetValue((int)SnGroupFieldIndex.Name, value); }
		}

		/// <summary> The DateCreated property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)SnGroupFieldIndex.DateCreated, true); }
			set	{ SetValue((int)SnGroupFieldIndex.DateCreated, value); }
		}

		/// <summary> The MemberCount property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."MemberCount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Int32 MemberCount
		{
			get { return (System.Int32)GetValue((int)SnGroupFieldIndex.MemberCount, true); }
			set	{ SetValue((int)SnGroupFieldIndex.MemberCount, value); }
		}

		/// <summary> The Description property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)SnGroupFieldIndex.Description, true); }
			set	{ SetValue((int)SnGroupFieldIndex.Description, value); }
		}

		/// <summary> The IsPublic property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."IsPublic"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Boolean IsPublic
		{
			get { return (System.Boolean)GetValue((int)SnGroupFieldIndex.IsPublic, true); }
			set	{ SetValue((int)SnGroupFieldIndex.IsPublic, value); }
		}

		/// <summary> The UserId property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> UserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnGroupFieldIndex.UserId, false); }
			set	{ SetValue((int)SnGroupFieldIndex.UserId, value); }
		}

		/// <summary> The ImageUrl property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."ImageUrl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String ImageUrl
		{
			get { return (System.String)GetValue((int)SnGroupFieldIndex.ImageUrl, true); }
			set	{ SetValue((int)SnGroupFieldIndex.ImageUrl, value); }
		}

		/// <summary> The GroupCategoryId property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."GroupCategoryId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> GroupCategoryId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnGroupFieldIndex.GroupCategoryId, false); }
			set	{ SetValue((int)SnGroupFieldIndex.GroupCategoryId, value); }
		}

		/// <summary> The Slug property of the Entity SnGroup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnGroup"."Slug"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String Slug
		{
			get { return (System.String)GetValue((int)SnGroupFieldIndex.Slug, true); }
			set	{ SetValue((int)SnGroupFieldIndex.Slug, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnAlbumEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnAlbumEntity))]		
		public virtual EntityCollection<SnAlbumEntity> SnAlbum
		{
			get { return GetOrCreateEntityCollection<SnAlbumEntity, SnAlbumEntityFactory>("SnGroup", true, false, ref _snAlbum);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnDiscussionBoardEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnDiscussionBoardEntity))]		
		public virtual EntityCollection<SnDiscussionBoardEntity> SnDiscussionBoard
		{
			get { return GetOrCreateEntityCollection<SnDiscussionBoardEntity, SnDiscussionBoardEntityFactory>("SnGroup", true, false, ref _snDiscussionBoard);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnEventEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnEventEntity))]		
		public virtual EntityCollection<SnEventEntity> SnEvents
		{
			get { return GetOrCreateEntityCollection<SnEventEntity, SnEventEntityFactory>("SnGroup", true, false, ref _snEvents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnGroupMemberEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnGroupMemberEntity))]		
		public virtual EntityCollection<SnGroupMemberEntity> SnGroupMembers
		{
			get { return GetOrCreateEntityCollection<SnGroupMemberEntity, SnGroupMemberEntityFactory>("SnGroup", true, false, ref _snGroupMembers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnGroupRequestEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnGroupRequestEntity))]		
		public virtual EntityCollection<SnGroupRequestEntity> SnGroupRequests
		{
			get { return GetOrCreateEntityCollection<SnGroupRequestEntity, SnGroupRequestEntityFactory>("SnGroup", true, false, ref _snGroupRequests);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnNoteEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnNoteEntity))]		
		public virtual EntityCollection<SnNoteEntity> SnNotes
		{
			get { return GetOrCreateEntityCollection<SnNoteEntity, SnNoteEntityFactory>("SnGroup", true, false, ref _snNotes);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]		
		public virtual EntityCollection<SnRelationshipEntity> SnRelationshipss
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("SnGroup", true, false, ref _snRelationshipss);	}
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
					SetSingleRelatedEntityNavigator(value, "SnGroups", "AspnetUser", _aspnetUser, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnGroupCategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual SnGroupCategoryEntity SnGroupCategory
		{
			get	{ return _snGroupCategory; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnGroupCategory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnGroups", "SnGroupCategory", _snGroupCategory, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public MonoSoftware.Core.ShortGuid ShortId
        {
            get 
            { 
                return new MonoSoftware.Core.ShortGuid(Id); 
            }
        }

		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
