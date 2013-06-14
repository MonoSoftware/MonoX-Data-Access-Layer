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
	/// <summary>Entity class which represents the entity 'SnDiscussionTopic'.<br/><br/></summary>
	[Serializable]
	public partial class SnDiscussionTopicEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SnDiscussionMessageEntity> _snDiscussionMessages;
		private EntityCollection<SnEventEntity> _snEvents;
		private EntityCollection<SnRelationshipEntity> _snRelationships;
		private AspnetUsersEntity _aspnetUser;
		private AspnetUsersEntity _pinnedByUser;
		private SnDiscussionBoardEntity _snDiscussionBoard;

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
			/// <summary>Member name PinnedByUser</summary>
			public static readonly string PinnedByUser = "PinnedByUser";
			/// <summary>Member name SnDiscussionBoard</summary>
			public static readonly string SnDiscussionBoard = "SnDiscussionBoard";
			/// <summary>Member name SnDiscussionMessages</summary>
			public static readonly string SnDiscussionMessages = "SnDiscussionMessages";
			/// <summary>Member name SnEvents</summary>
			public static readonly string SnEvents = "SnEvents";
			/// <summary>Member name SnRelationships</summary>
			public static readonly string SnRelationships = "SnRelationships";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SnDiscussionTopicEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SnDiscussionTopicEntity():base("SnDiscussionTopicEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SnDiscussionTopicEntity(IEntityFields2 fields):base("SnDiscussionTopicEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SnDiscussionTopicEntity</param>
		public SnDiscussionTopicEntity(IValidator validator):base("SnDiscussionTopicEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnDiscussionTopic which data should be fetched into this SnDiscussionTopic object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnDiscussionTopicEntity(System.Guid id):base("SnDiscussionTopicEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnDiscussionTopic which data should be fetched into this SnDiscussionTopic object</param>
		/// <param name="validator">The custom validator object for this SnDiscussionTopicEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnDiscussionTopicEntity(System.Guid id, IValidator validator):base("SnDiscussionTopicEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SnDiscussionTopicEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_snDiscussionMessages = (EntityCollection<SnDiscussionMessageEntity>)info.GetValue("_snDiscussionMessages", typeof(EntityCollection<SnDiscussionMessageEntity>));
				_snEvents = (EntityCollection<SnEventEntity>)info.GetValue("_snEvents", typeof(EntityCollection<SnEventEntity>));
				_snRelationships = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationships", typeof(EntityCollection<SnRelationshipEntity>));
				_aspnetUser = (AspnetUsersEntity)info.GetValue("_aspnetUser", typeof(AspnetUsersEntity));
				if(_aspnetUser!=null)
				{
					_aspnetUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_pinnedByUser = (AspnetUsersEntity)info.GetValue("_pinnedByUser", typeof(AspnetUsersEntity));
				if(_pinnedByUser!=null)
				{
					_pinnedByUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snDiscussionBoard = (SnDiscussionBoardEntity)info.GetValue("_snDiscussionBoard", typeof(SnDiscussionBoardEntity));
				if(_snDiscussionBoard!=null)
				{
					_snDiscussionBoard.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SnDiscussionTopicFieldIndex)fieldIndex)
			{
				case SnDiscussionTopicFieldIndex.SnDiscussionBoardId:
					DesetupSyncSnDiscussionBoard(true, false);
					break;
				case SnDiscussionTopicFieldIndex.UserId:
					DesetupSyncAspnetUser(true, false);
					break;
				case SnDiscussionTopicFieldIndex.PinnedByUserId:
					DesetupSyncPinnedByUser(true, false);
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
				case "AspnetUser":
					this.AspnetUser = (AspnetUsersEntity)entity;
					break;
				case "PinnedByUser":
					this.PinnedByUser = (AspnetUsersEntity)entity;
					break;
				case "SnDiscussionBoard":
					this.SnDiscussionBoard = (SnDiscussionBoardEntity)entity;
					break;
				case "SnDiscussionMessages":
					this.SnDiscussionMessages.Add((SnDiscussionMessageEntity)entity);
					break;
				case "SnEvents":
					this.SnEvents.Add((SnEventEntity)entity);
					break;
				case "SnRelationships":
					this.SnRelationships.Add((SnRelationshipEntity)entity);
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
				case "PinnedByUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingPinnedByUserId);
					break;
				case "SnDiscussionBoard":
					toReturn.Add(Relations.SnDiscussionBoardEntityUsingSnDiscussionBoardId);
					break;
				case "SnDiscussionMessages":
					toReturn.Add(Relations.SnDiscussionMessageEntityUsingSnDiscussionTopicId);
					break;
				case "SnEvents":
					toReturn.Add(Relations.SnEventEntityUsingSnDiscussionTopicId);
					break;
				case "SnRelationships":
					toReturn.Add(Relations.SnRelationshipEntityUsingDiscussionTopicId);
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
			int numberOfOneWayRelations = 0+1+1;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				case "AspnetUser":
					return true;
				case "PinnedByUser":
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
				case "AspnetUser":
					SetupSyncAspnetUser(relatedEntity);
					break;
				case "PinnedByUser":
					SetupSyncPinnedByUser(relatedEntity);
					break;
				case "SnDiscussionBoard":
					SetupSyncSnDiscussionBoard(relatedEntity);
					break;
				case "SnDiscussionMessages":
					this.SnDiscussionMessages.Add((SnDiscussionMessageEntity)relatedEntity);
					break;
				case "SnEvents":
					this.SnEvents.Add((SnEventEntity)relatedEntity);
					break;
				case "SnRelationships":
					this.SnRelationships.Add((SnRelationshipEntity)relatedEntity);
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
				case "AspnetUser":
					DesetupSyncAspnetUser(false, true);
					break;
				case "PinnedByUser":
					DesetupSyncPinnedByUser(false, true);
					break;
				case "SnDiscussionBoard":
					DesetupSyncSnDiscussionBoard(false, true);
					break;
				case "SnDiscussionMessages":
					this.PerformRelatedEntityRemoval(this.SnDiscussionMessages, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnEvents":
					this.PerformRelatedEntityRemoval(this.SnEvents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnRelationships":
					this.PerformRelatedEntityRemoval(this.SnRelationships, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_pinnedByUser!=null)
			{
				toReturn.Add(_pinnedByUser);
			}
			if(_snDiscussionBoard!=null)
			{
				toReturn.Add(_snDiscussionBoard);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SnDiscussionMessages);
			toReturn.Add(this.SnEvents);
			toReturn.Add(this.SnRelationships);
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
				info.AddValue("_snDiscussionMessages", ((_snDiscussionMessages!=null) && (_snDiscussionMessages.Count>0) && !this.MarkedForDeletion)?_snDiscussionMessages:null);
				info.AddValue("_snEvents", ((_snEvents!=null) && (_snEvents.Count>0) && !this.MarkedForDeletion)?_snEvents:null);
				info.AddValue("_snRelationships", ((_snRelationships!=null) && (_snRelationships.Count>0) && !this.MarkedForDeletion)?_snRelationships:null);
				info.AddValue("_aspnetUser", (!this.MarkedForDeletion?_aspnetUser:null));
				info.AddValue("_pinnedByUser", (!this.MarkedForDeletion?_pinnedByUser:null));
				info.AddValue("_snDiscussionBoard", (!this.MarkedForDeletion?_snDiscussionBoard:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SnDiscussionTopicRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnDiscussionMessage' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionMessages()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionMessageFields.SnDiscussionTopicId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnEvent' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnEvents()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnEventFields.SnDiscussionTopicId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationships()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.DiscussionTopicId, null, ComparisonOperator.Equal, this.Id));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPinnedByUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.PinnedByUserId));
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
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionTopicEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._snDiscussionMessages);
			collectionsQueue.Enqueue(this._snEvents);
			collectionsQueue.Enqueue(this._snRelationships);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._snDiscussionMessages = (EntityCollection<SnDiscussionMessageEntity>) collectionsQueue.Dequeue();
			this._snEvents = (EntityCollection<SnEventEntity>) collectionsQueue.Dequeue();
			this._snRelationships = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._snDiscussionMessages != null);
			toReturn |=(this._snEvents != null);
			toReturn |=(this._snRelationships != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnDiscussionMessageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionMessageEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetUser", _aspnetUser);
			toReturn.Add("PinnedByUser", _pinnedByUser);
			toReturn.Add("SnDiscussionBoard", _snDiscussionBoard);
			toReturn.Add("SnDiscussionMessages", _snDiscussionMessages);
			toReturn.Add("SnEvents", _snEvents);
			toReturn.Add("SnRelationships", _snRelationships);
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
			_fieldsCustomProperties.Add("SnDiscussionBoardId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Ip", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Referrer", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserAgent", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsApproved", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsSpam", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Spaminess", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Signature", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TimesViewed", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsClosed", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsPinned", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PinnedOn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PinnedByUserId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionTopicRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnDiscussionTopicFieldIndex.UserId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionTopicRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _pinnedByUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPinnedByUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _pinnedByUser, new PropertyChangedEventHandler( OnPinnedByUserPropertyChanged ), "PinnedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionTopicRelations.AspnetUsersEntityUsingPinnedByUserIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnDiscussionTopicFieldIndex.PinnedByUserId } );
			_pinnedByUser = null;
		}

		/// <summary> setups the sync logic for member _pinnedByUser</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPinnedByUser(IEntity2 relatedEntity)
		{
			if(_pinnedByUser!=relatedEntity)
			{
				DesetupSyncPinnedByUser(true, true);
				_pinnedByUser = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _pinnedByUser, new PropertyChangedEventHandler( OnPinnedByUserPropertyChanged ), "PinnedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionTopicRelations.AspnetUsersEntityUsingPinnedByUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPinnedByUserPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _snDiscussionBoard, new PropertyChangedEventHandler( OnSnDiscussionBoardPropertyChanged ), "SnDiscussionBoard", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionTopicRelations.SnDiscussionBoardEntityUsingSnDiscussionBoardIdStatic, true, signalRelatedEntity, "SnDiscussionTopics", resetFKFields, new int[] { (int)SnDiscussionTopicFieldIndex.SnDiscussionBoardId } );
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
				this.PerformSetupSyncRelatedEntity( _snDiscussionBoard, new PropertyChangedEventHandler( OnSnDiscussionBoardPropertyChanged ), "SnDiscussionBoard", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionTopicRelations.SnDiscussionBoardEntityUsingSnDiscussionBoardIdStatic, true, new string[] {  } );
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

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SnDiscussionTopicEntity</param>
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
		public  static SnDiscussionTopicRelations Relations
		{
			get	{ return new SnDiscussionTopicRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionMessage' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionMessages
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnDiscussionMessageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionMessageEntityFactory))), (IEntityRelation)GetRelationsForField("SnDiscussionMessages")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, 0, null, null, null, null, "SnDiscussionMessages", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnEvents
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))), (IEntityRelation)GetRelationsForField("SnEvents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, 0, null, null, null, null, "SnEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationships
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationships")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationships", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPinnedByUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("PinnedByUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "PinnedByUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionBoard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionBoard
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardEntityFactory))),	(IEntityRelation)GetRelationsForField("SnDiscussionBoard")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, 0, null, null, null, null, "SnDiscussionBoard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)SnDiscussionTopicFieldIndex.Id, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.Id, value); }
		}

		/// <summary> The SnDiscussionBoardId property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."SnDiscussionBoardId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid SnDiscussionBoardId
		{
			get { return (System.Guid)GetValue((int)SnDiscussionTopicFieldIndex.SnDiscussionBoardId, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.SnDiscussionBoardId, value); }
		}

		/// <summary> The Title property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)SnDiscussionTopicFieldIndex.Title, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.Title, value); }
		}

		/// <summary> The UserId property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> UserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnDiscussionTopicFieldIndex.UserId, false); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.UserId, value); }
		}

		/// <summary> The DateCreated property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)SnDiscussionTopicFieldIndex.DateCreated, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.DateCreated, value); }
		}

		/// <summary> The Ip property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."Ip"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Ip
		{
			get { return (System.String)GetValue((int)SnDiscussionTopicFieldIndex.Ip, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.Ip, value); }
		}

		/// <summary> The Referrer property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."Referrer"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Referrer
		{
			get { return (System.String)GetValue((int)SnDiscussionTopicFieldIndex.Referrer, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.Referrer, value); }
		}

		/// <summary> The UserAgent property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."UserAgent"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String UserAgent
		{
			get { return (System.String)GetValue((int)SnDiscussionTopicFieldIndex.UserAgent, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.UserAgent, value); }
		}

		/// <summary> The IsApproved property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."IsApproved"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsApproved
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionTopicFieldIndex.IsApproved, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.IsApproved, value); }
		}

		/// <summary> The IsSpam property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."IsSpam"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsSpam
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionTopicFieldIndex.IsSpam, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.IsSpam, value); }
		}

		/// <summary> The Spaminess property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."Spaminess"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 18, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Spaminess
		{
			get { return (System.Decimal)GetValue((int)SnDiscussionTopicFieldIndex.Spaminess, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.Spaminess, value); }
		}

		/// <summary> The Signature property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."Signature"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Signature
		{
			get { return (System.String)GetValue((int)SnDiscussionTopicFieldIndex.Signature, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.Signature, value); }
		}

		/// <summary> The TimesViewed property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."TimesViewed"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TimesViewed
		{
			get { return (Nullable<System.Int32>)GetValue((int)SnDiscussionTopicFieldIndex.TimesViewed, false); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.TimesViewed, value); }
		}

		/// <summary> The IsClosed property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."IsClosed"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsClosed
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionTopicFieldIndex.IsClosed, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.IsClosed, value); }
		}

		/// <summary> The IsPinned property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."IsPinned"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsPinned
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionTopicFieldIndex.IsPinned, true); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.IsPinned, value); }
		}

		/// <summary> The PinnedOn property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."PinnedOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> PinnedOn
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SnDiscussionTopicFieldIndex.PinnedOn, false); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.PinnedOn, value); }
		}

		/// <summary> The PinnedByUserId property of the Entity SnDiscussionTopic<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionTopic"."PinnedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> PinnedByUserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnDiscussionTopicFieldIndex.PinnedByUserId, false); }
			set	{ SetValue((int)SnDiscussionTopicFieldIndex.PinnedByUserId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnDiscussionMessageEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnDiscussionMessageEntity))]
		public virtual EntityCollection<SnDiscussionMessageEntity> SnDiscussionMessages
		{
			get { return GetOrCreateEntityCollection<SnDiscussionMessageEntity, SnDiscussionMessageEntityFactory>("SnDiscussionTopic", true, false, ref _snDiscussionMessages);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnEventEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnEventEntity))]
		public virtual EntityCollection<SnEventEntity> SnEvents
		{
			get { return GetOrCreateEntityCollection<SnEventEntity, SnEventEntityFactory>("SnDiscussionTopic", true, false, ref _snEvents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]
		public virtual EntityCollection<SnRelationshipEntity> SnRelationships
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("SnDiscussionTopic", true, false, ref _snRelationships);	}
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
					SetSingleRelatedEntityNavigator(value, "", "AspnetUser", _aspnetUser, false); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AspnetUsersEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual AspnetUsersEntity PinnedByUser
		{
			get	{ return _pinnedByUser; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPinnedByUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "", "PinnedByUser", _pinnedByUser, false); 
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
					SetSingleRelatedEntityNavigator(value, "SnDiscussionTopics", "SnDiscussionBoard", _snDiscussionBoard, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity; }
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
