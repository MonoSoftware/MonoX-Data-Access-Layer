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
	/// <summary>Entity class which represents the entity 'SnFile'.<br/><br/></summary>
	[Serializable]
	public partial class SnFileEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SnEventEntity> _snEvents;
		private EntityCollection<SnRelationshipEntity> _snRelationships;
		private AspnetUsersEntity _aspnetUser;
		private PrivacyLevelEntity _privacyLevel;
		private SnAlbumEntity _snAlbum;
		private SnRelationshipEntity _snRelationship;

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
			/// <summary>Member name PrivacyLevel</summary>
			public static readonly string PrivacyLevel = "PrivacyLevel";
			/// <summary>Member name SnAlbum</summary>
			public static readonly string SnAlbum = "SnAlbum";
			/// <summary>Member name SnRelationship</summary>
			public static readonly string SnRelationship = "SnRelationship";
			/// <summary>Member name SnEvents</summary>
			public static readonly string SnEvents = "SnEvents";
			/// <summary>Member name SnRelationships</summary>
			public static readonly string SnRelationships = "SnRelationships";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SnFileEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SnFileEntity():base("SnFileEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SnFileEntity(IEntityFields2 fields):base("SnFileEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SnFileEntity</param>
		public SnFileEntity(IValidator validator):base("SnFileEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnFile which data should be fetched into this SnFile object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnFileEntity(System.Guid id):base("SnFileEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnFile which data should be fetched into this SnFile object</param>
		/// <param name="validator">The custom validator object for this SnFileEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnFileEntity(System.Guid id, IValidator validator):base("SnFileEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SnFileEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_snEvents = (EntityCollection<SnEventEntity>)info.GetValue("_snEvents", typeof(EntityCollection<SnEventEntity>));
				_snRelationships = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationships", typeof(EntityCollection<SnRelationshipEntity>));
				_aspnetUser = (AspnetUsersEntity)info.GetValue("_aspnetUser", typeof(AspnetUsersEntity));
				if(_aspnetUser!=null)
				{
					_aspnetUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_privacyLevel = (PrivacyLevelEntity)info.GetValue("_privacyLevel", typeof(PrivacyLevelEntity));
				if(_privacyLevel!=null)
				{
					_privacyLevel.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snAlbum = (SnAlbumEntity)info.GetValue("_snAlbum", typeof(SnAlbumEntity));
				if(_snAlbum!=null)
				{
					_snAlbum.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snRelationship = (SnRelationshipEntity)info.GetValue("_snRelationship", typeof(SnRelationshipEntity));
				if(_snRelationship!=null)
				{
					_snRelationship.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SnFileFieldIndex)fieldIndex)
			{
				case SnFileFieldIndex.UserId:
					DesetupSyncAspnetUser(true, false);
					break;
				case SnFileFieldIndex.RelationshipId:
					DesetupSyncSnRelationship(true, false);
					break;
				case SnFileFieldIndex.PrivacyLevelId:
					DesetupSyncPrivacyLevel(true, false);
					break;
				case SnFileFieldIndex.AlbumId:
					DesetupSyncSnAlbum(true, false);
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
				case "PrivacyLevel":
					this.PrivacyLevel = (PrivacyLevelEntity)entity;
					break;
				case "SnAlbum":
					this.SnAlbum = (SnAlbumEntity)entity;
					break;
				case "SnRelationship":
					this.SnRelationship = (SnRelationshipEntity)entity;
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
				case "PrivacyLevel":
					toReturn.Add(Relations.PrivacyLevelEntityUsingPrivacyLevelId);
					break;
				case "SnAlbum":
					toReturn.Add(Relations.SnAlbumEntityUsingAlbumId);
					break;
				case "SnRelationship":
					toReturn.Add(Relations.SnRelationshipEntityUsingRelationshipId);
					break;
				case "SnEvents":
					toReturn.Add(Relations.SnEventEntityUsingSnFileId);
					break;
				case "SnRelationships":
					toReturn.Add(Relations.SnRelationshipEntityUsingFileId);
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
				case "PrivacyLevel":
					SetupSyncPrivacyLevel(relatedEntity);
					break;
				case "SnAlbum":
					SetupSyncSnAlbum(relatedEntity);
					break;
				case "SnRelationship":
					SetupSyncSnRelationship(relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "AspnetUser":
					DesetupSyncAspnetUser(false, true);
					break;
				case "PrivacyLevel":
					DesetupSyncPrivacyLevel(false, true);
					break;
				case "SnAlbum":
					DesetupSyncSnAlbum(false, true);
					break;
				case "SnRelationship":
					DesetupSyncSnRelationship(false, true);
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
			if(_privacyLevel!=null)
			{
				toReturn.Add(_privacyLevel);
			}
			if(_snAlbum!=null)
			{
				toReturn.Add(_snAlbum);
			}
			if(_snRelationship!=null)
			{
				toReturn.Add(_snRelationship);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
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
				info.AddValue("_snEvents", ((_snEvents!=null) && (_snEvents.Count>0) && !this.MarkedForDeletion)?_snEvents:null);
				info.AddValue("_snRelationships", ((_snRelationships!=null) && (_snRelationships.Count>0) && !this.MarkedForDeletion)?_snRelationships:null);
				info.AddValue("_aspnetUser", (!this.MarkedForDeletion?_aspnetUser:null));
				info.AddValue("_privacyLevel", (!this.MarkedForDeletion?_privacyLevel:null));
				info.AddValue("_snAlbum", (!this.MarkedForDeletion?_snAlbum:null));
				info.AddValue("_snRelationship", (!this.MarkedForDeletion?_snRelationship:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SnFileRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnEvent' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnEvents()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnEventFields.SnFileId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationships()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.FileId, null, ComparisonOperator.Equal, this.Id));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'PrivacyLevel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPrivacyLevel()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PrivacyLevelFields.Id, null, ComparisonOperator.Equal, this.PrivacyLevelId));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationship()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.Id, null, ComparisonOperator.Equal, this.RelationshipId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SnFileEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._snEvents);
			collectionsQueue.Enqueue(this._snRelationships);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._snEvents = (EntityCollection<SnEventEntity>) collectionsQueue.Dequeue();
			this._snRelationships = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
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
			toReturn.Add("PrivacyLevel", _privacyLevel);
			toReturn.Add("SnAlbum", _snAlbum);
			toReturn.Add("SnRelationship", _snRelationship);
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
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RelationshipId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Url", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PrivacyLevelId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ThumbnailUrl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AlbumId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsAlbumCover", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SortOrder", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rating", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnFileRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "SnFiles", resetFKFields, new int[] { (int)SnFileFieldIndex.UserId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnFileRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _privacyLevel</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPrivacyLevel(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _privacyLevel, new PropertyChangedEventHandler( OnPrivacyLevelPropertyChanged ), "PrivacyLevel", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnFileRelations.PrivacyLevelEntityUsingPrivacyLevelIdStatic, true, signalRelatedEntity, "SnFiles", resetFKFields, new int[] { (int)SnFileFieldIndex.PrivacyLevelId } );
			_privacyLevel = null;
		}

		/// <summary> setups the sync logic for member _privacyLevel</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPrivacyLevel(IEntityCore relatedEntity)
		{
			if(_privacyLevel!=relatedEntity)
			{
				DesetupSyncPrivacyLevel(true, true);
				_privacyLevel = (PrivacyLevelEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _privacyLevel, new PropertyChangedEventHandler( OnPrivacyLevelPropertyChanged ), "PrivacyLevel", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnFileRelations.PrivacyLevelEntityUsingPrivacyLevelIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPrivacyLevelPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _snAlbum, new PropertyChangedEventHandler( OnSnAlbumPropertyChanged ), "SnAlbum", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnFileRelations.SnAlbumEntityUsingAlbumIdStatic, true, signalRelatedEntity, "SnFiles", resetFKFields, new int[] { (int)SnFileFieldIndex.AlbumId } );
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
				this.PerformSetupSyncRelatedEntity( _snAlbum, new PropertyChangedEventHandler( OnSnAlbumPropertyChanged ), "SnAlbum", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnFileRelations.SnAlbumEntityUsingAlbumIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _snRelationship</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnRelationship(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snRelationship, new PropertyChangedEventHandler( OnSnRelationshipPropertyChanged ), "SnRelationship", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnFileRelations.SnRelationshipEntityUsingRelationshipIdStatic, true, signalRelatedEntity, "SnFiles", resetFKFields, new int[] { (int)SnFileFieldIndex.RelationshipId } );
			_snRelationship = null;
		}

		/// <summary> setups the sync logic for member _snRelationship</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnRelationship(IEntityCore relatedEntity)
		{
			if(_snRelationship!=relatedEntity)
			{
				DesetupSyncSnRelationship(true, true);
				_snRelationship = (SnRelationshipEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snRelationship, new PropertyChangedEventHandler( OnSnRelationshipPropertyChanged ), "SnRelationship", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnFileRelations.SnRelationshipEntityUsingRelationshipIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnRelationshipPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SnFileEntity</param>
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
		public  static SnFileRelations Relations
		{
			get	{ return new SnFileRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnEvents
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))), (IEntityRelation)GetRelationsForField("SnEvents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, 0, null, null, null, null, "SnEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationships
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationships")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationships", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PrivacyLevel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPrivacyLevel
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PrivacyLevelEntityFactory))),	(IEntityRelation)GetRelationsForField("PrivacyLevel")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity, 0, null, null, null, null, "PrivacyLevel", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnAlbum' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnAlbum
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnAlbumEntityFactory))),	(IEntityRelation)GetRelationsForField("SnAlbum")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnAlbumEntity, 0, null, null, null, null, "SnAlbum", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationship
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))),	(IEntityRelation)GetRelationsForField("SnRelationship")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationship", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>		
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)SnFileFieldIndex.Id, true); }
			set	{ SetValue((int)SnFileFieldIndex.Id, value); }
		}

		/// <summary> The UserId property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid UserId
		{
			get { return (System.Guid)GetValue((int)SnFileFieldIndex.UserId, true); }
			set	{ SetValue((int)SnFileFieldIndex.UserId, value); }
		}

		/// <summary> The RelationshipId property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."RelationshipId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid RelationshipId
		{
			get { return (System.Guid)GetValue((int)SnFileFieldIndex.RelationshipId, true); }
			set	{ SetValue((int)SnFileFieldIndex.RelationshipId, value); }
		}

		/// <summary> The Name property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SnFileFieldIndex.Name, true); }
			set	{ SetValue((int)SnFileFieldIndex.Name, value); }
		}

		/// <summary> The Url property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."Url"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2000<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.String Url
		{
			get { return (System.String)GetValue((int)SnFileFieldIndex.Url, true); }
			set	{ SetValue((int)SnFileFieldIndex.Url, value); }
		}

		/// <summary> The Description property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)SnFileFieldIndex.Description, true); }
			set	{ SetValue((int)SnFileFieldIndex.Description, value); }
		}

		/// <summary> The PrivacyLevelId property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."PrivacyLevelId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> PrivacyLevelId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnFileFieldIndex.PrivacyLevelId, false); }
			set	{ SetValue((int)SnFileFieldIndex.PrivacyLevelId, value); }
		}

		/// <summary> The ThumbnailUrl property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."ThumbnailUrl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2000<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String ThumbnailUrl
		{
			get { return (System.String)GetValue((int)SnFileFieldIndex.ThumbnailUrl, true); }
			set	{ SetValue((int)SnFileFieldIndex.ThumbnailUrl, value); }
		}

		/// <summary> The DateCreated property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)SnFileFieldIndex.DateCreated, true); }
			set	{ SetValue((int)SnFileFieldIndex.DateCreated, value); }
		}

		/// <summary> The AlbumId property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."AlbumId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> AlbumId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnFileFieldIndex.AlbumId, false); }
			set	{ SetValue((int)SnFileFieldIndex.AlbumId, value); }
		}

		/// <summary> The IsAlbumCover property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."IsAlbumCover"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Boolean> IsAlbumCover
		{
			get { return (Nullable<System.Boolean>)GetValue((int)SnFileFieldIndex.IsAlbumCover, false); }
			set	{ SetValue((int)SnFileFieldIndex.IsAlbumCover, value); }
		}

		/// <summary> The SortOrder property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."SortOrder"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Int32> SortOrder
		{
			get { return (Nullable<System.Int32>)GetValue((int)SnFileFieldIndex.SortOrder, false); }
			set	{ SetValue((int)SnFileFieldIndex.SortOrder, value); }
		}

		/// <summary> The Rating property of the Entity SnFile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnFile"."Rating"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Double Rating
		{
			get { return (System.Double)GetValue((int)SnFileFieldIndex.Rating, true); }
			set	{ SetValue((int)SnFileFieldIndex.Rating, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnEventEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnEventEntity))]		
		public virtual EntityCollection<SnEventEntity> SnEvents
		{
			get { return GetOrCreateEntityCollection<SnEventEntity, SnEventEntityFactory>("SnFile", true, false, ref _snEvents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]		
		public virtual EntityCollection<SnRelationshipEntity> SnRelationships
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("SnFile", true, false, ref _snRelationships);	}
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
					SetSingleRelatedEntityNavigator(value, "SnFiles", "AspnetUser", _aspnetUser, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'PrivacyLevelEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual PrivacyLevelEntity PrivacyLevel
		{
			get	{ return _privacyLevel; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPrivacyLevel(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnFiles", "PrivacyLevel", _privacyLevel, true); 
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
					SetSingleRelatedEntityNavigator(value, "SnFiles", "SnAlbum", _snAlbum, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnRelationshipEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual SnRelationshipEntity SnRelationship
		{
			get	{ return _snRelationship; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnRelationship(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnFiles", "SnRelationship", _snRelationship, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity; }
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
