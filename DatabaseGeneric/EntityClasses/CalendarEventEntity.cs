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
	/// <summary>Entity class which represents the entity 'CalendarEvent'.<br/><br/></summary>
	[Serializable]
	public partial class CalendarEventEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<CalendarEventEntryEntity> _calendarEventEntries;
		private EntityCollection<SnRelationshipEntity> _snRelationships;
		private AspnetUsersEntity _aspnetUsers;
		private CalendarEntity _calendar;
		private CalendarEventRecurringDefinitionEntity _calendarEventRecurringDefinition;

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
			/// <summary>Member name Calendar</summary>
			public static readonly string Calendar = "Calendar";
			/// <summary>Member name CalendarEventRecurringDefinition</summary>
			public static readonly string CalendarEventRecurringDefinition = "CalendarEventRecurringDefinition";
			/// <summary>Member name CalendarEventEntries</summary>
			public static readonly string CalendarEventEntries = "CalendarEventEntries";
			/// <summary>Member name SnRelationships</summary>
			public static readonly string SnRelationships = "SnRelationships";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CalendarEventEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public CalendarEventEntity():base("CalendarEventEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CalendarEventEntity(IEntityFields2 fields):base("CalendarEventEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CalendarEventEntity</param>
		public CalendarEventEntity(IValidator validator):base("CalendarEventEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for CalendarEvent which data should be fetched into this CalendarEvent object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CalendarEventEntity(System.Guid id):base("CalendarEventEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for CalendarEvent which data should be fetched into this CalendarEvent object</param>
		/// <param name="validator">The custom validator object for this CalendarEventEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CalendarEventEntity(System.Guid id, IValidator validator):base("CalendarEventEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CalendarEventEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_calendarEventEntries = (EntityCollection<CalendarEventEntryEntity>)info.GetValue("_calendarEventEntries", typeof(EntityCollection<CalendarEventEntryEntity>));
				_snRelationships = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationships", typeof(EntityCollection<SnRelationshipEntity>));
				_aspnetUsers = (AspnetUsersEntity)info.GetValue("_aspnetUsers", typeof(AspnetUsersEntity));
				if(_aspnetUsers!=null)
				{
					_aspnetUsers.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_calendar = (CalendarEntity)info.GetValue("_calendar", typeof(CalendarEntity));
				if(_calendar!=null)
				{
					_calendar.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_calendarEventRecurringDefinition = (CalendarEventRecurringDefinitionEntity)info.GetValue("_calendarEventRecurringDefinition", typeof(CalendarEventRecurringDefinitionEntity));
				if(_calendarEventRecurringDefinition!=null)
				{
					_calendarEventRecurringDefinition.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((CalendarEventFieldIndex)fieldIndex)
			{
				case CalendarEventFieldIndex.AuthorId:
					DesetupSyncAspnetUsers(true, false);
					break;
				case CalendarEventFieldIndex.RecurringDefinitionId:
					DesetupSyncCalendarEventRecurringDefinition(true, false);
					break;
				case CalendarEventFieldIndex.OwnerCalendarId:
					DesetupSyncCalendar(true, false);
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
				case "AspnetUsers":
					this.AspnetUsers = (AspnetUsersEntity)entity;
					break;
				case "Calendar":
					this.Calendar = (CalendarEntity)entity;
					break;
				case "CalendarEventRecurringDefinition":
					this.CalendarEventRecurringDefinition = (CalendarEventRecurringDefinitionEntity)entity;
					break;
				case "CalendarEventEntries":
					this.CalendarEventEntries.Add((CalendarEventEntryEntity)entity);
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
				case "AspnetUsers":
					toReturn.Add(Relations.AspnetUsersEntityUsingAuthorId);
					break;
				case "Calendar":
					toReturn.Add(Relations.CalendarEntityUsingOwnerCalendarId);
					break;
				case "CalendarEventRecurringDefinition":
					toReturn.Add(Relations.CalendarEventRecurringDefinitionEntityUsingRecurringDefinitionId);
					break;
				case "CalendarEventEntries":
					toReturn.Add(Relations.CalendarEventEntryEntityUsingCalendarEventId);
					break;
				case "SnRelationships":
					toReturn.Add(Relations.SnRelationshipEntityUsingCalendarEventId);
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
		protected override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "AspnetUsers":
					SetupSyncAspnetUsers(relatedEntity);
					break;
				case "Calendar":
					SetupSyncCalendar(relatedEntity);
					break;
				case "CalendarEventRecurringDefinition":
					SetupSyncCalendarEventRecurringDefinition(relatedEntity);
					break;
				case "CalendarEventEntries":
					this.CalendarEventEntries.Add((CalendarEventEntryEntity)relatedEntity);
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
				case "AspnetUsers":
					DesetupSyncAspnetUsers(false, true);
					break;
				case "Calendar":
					DesetupSyncCalendar(false, true);
					break;
				case "CalendarEventRecurringDefinition":
					DesetupSyncCalendarEventRecurringDefinition(false, true);
					break;
				case "CalendarEventEntries":
					this.PerformRelatedEntityRemoval(this.CalendarEventEntries, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_aspnetUsers!=null)
			{
				toReturn.Add(_aspnetUsers);
			}
			if(_calendar!=null)
			{
				toReturn.Add(_calendar);
			}
			if(_calendarEventRecurringDefinition!=null)
			{
				toReturn.Add(_calendarEventRecurringDefinition);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.CalendarEventEntries);
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
				info.AddValue("_calendarEventEntries", ((_calendarEventEntries!=null) && (_calendarEventEntries.Count>0) && !this.MarkedForDeletion)?_calendarEventEntries:null);
				info.AddValue("_snRelationships", ((_snRelationships!=null) && (_snRelationships.Count>0) && !this.MarkedForDeletion)?_snRelationships:null);
				info.AddValue("_aspnetUsers", (!this.MarkedForDeletion?_aspnetUsers:null));
				info.AddValue("_calendar", (!this.MarkedForDeletion?_calendar:null));
				info.AddValue("_calendarEventRecurringDefinition", (!this.MarkedForDeletion?_calendarEventRecurringDefinition:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CalendarEventRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CalendarEventEntry' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCalendarEventEntries()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CalendarEventEntryFields.CalendarEventId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationships()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.CalendarEventId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetUsers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.AuthorId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Calendar' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCalendar()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CalendarFields.Id, null, ComparisonOperator.Equal, this.OwnerCalendarId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CalendarEventRecurringDefinition' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCalendarEventRecurringDefinition()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CalendarEventRecurringDefinitionFields.Id, null, ComparisonOperator.Equal, this.RecurringDefinitionId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._calendarEventEntries);
			collectionsQueue.Enqueue(this._snRelationships);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._calendarEventEntries = (EntityCollection<CalendarEventEntryEntity>) collectionsQueue.Dequeue();
			this._snRelationships = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._calendarEventEntries != null);
			toReturn |=(this._snRelationships != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CalendarEventEntryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventEntryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetUsers", _aspnetUsers);
			toReturn.Add("Calendar", _calendar);
			toReturn.Add("CalendarEventRecurringDefinition", _calendarEventRecurringDefinition);
			toReturn.Add("CalendarEventEntries", _calendarEventEntries);
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
			_fieldsCustomProperties.Add("AuthorId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StartTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EndTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AllDay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Place", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RecurringDefinitionId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OwnerCalendarId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetUsers</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetUsers(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetUsers, new PropertyChangedEventHandler( OnAspnetUsersPropertyChanged ), "AspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticCalendarEventRelations.AspnetUsersEntityUsingAuthorIdStatic, true, signalRelatedEntity, "CalendarEvents", resetFKFields, new int[] { (int)CalendarEventFieldIndex.AuthorId } );
			_aspnetUsers = null;
		}

		/// <summary> setups the sync logic for member _aspnetUsers</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetUsers(IEntity2 relatedEntity)
		{
			if(_aspnetUsers!=relatedEntity)
			{
				DesetupSyncAspnetUsers(true, true);
				_aspnetUsers = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetUsers, new PropertyChangedEventHandler( OnAspnetUsersPropertyChanged ), "AspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticCalendarEventRelations.AspnetUsersEntityUsingAuthorIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _calendar</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCalendar(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _calendar, new PropertyChangedEventHandler( OnCalendarPropertyChanged ), "Calendar", MonoSoftware.MonoX.DAL.RelationClasses.StaticCalendarEventRelations.CalendarEntityUsingOwnerCalendarIdStatic, true, signalRelatedEntity, "CalendarEvents", resetFKFields, new int[] { (int)CalendarEventFieldIndex.OwnerCalendarId } );
			_calendar = null;
		}

		/// <summary> setups the sync logic for member _calendar</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCalendar(IEntity2 relatedEntity)
		{
			if(_calendar!=relatedEntity)
			{
				DesetupSyncCalendar(true, true);
				_calendar = (CalendarEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _calendar, new PropertyChangedEventHandler( OnCalendarPropertyChanged ), "Calendar", MonoSoftware.MonoX.DAL.RelationClasses.StaticCalendarEventRelations.CalendarEntityUsingOwnerCalendarIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCalendarPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _calendarEventRecurringDefinition</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCalendarEventRecurringDefinition(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _calendarEventRecurringDefinition, new PropertyChangedEventHandler( OnCalendarEventRecurringDefinitionPropertyChanged ), "CalendarEventRecurringDefinition", MonoSoftware.MonoX.DAL.RelationClasses.StaticCalendarEventRelations.CalendarEventRecurringDefinitionEntityUsingRecurringDefinitionIdStatic, true, signalRelatedEntity, "CalendarEvents", resetFKFields, new int[] { (int)CalendarEventFieldIndex.RecurringDefinitionId } );
			_calendarEventRecurringDefinition = null;
		}

		/// <summary> setups the sync logic for member _calendarEventRecurringDefinition</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCalendarEventRecurringDefinition(IEntity2 relatedEntity)
		{
			if(_calendarEventRecurringDefinition!=relatedEntity)
			{
				DesetupSyncCalendarEventRecurringDefinition(true, true);
				_calendarEventRecurringDefinition = (CalendarEventRecurringDefinitionEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _calendarEventRecurringDefinition, new PropertyChangedEventHandler( OnCalendarEventRecurringDefinitionPropertyChanged ), "CalendarEventRecurringDefinition", MonoSoftware.MonoX.DAL.RelationClasses.StaticCalendarEventRelations.CalendarEventRecurringDefinitionEntityUsingRecurringDefinitionIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCalendarEventRecurringDefinitionPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CalendarEventEntity</param>
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
		public  static CalendarEventRelations Relations
		{
			get	{ return new CalendarEventRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CalendarEventEntry' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCalendarEventEntries
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CalendarEventEntryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventEntryEntityFactory))), (IEntityRelation)GetRelationsForField("CalendarEventEntries")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntryEntity, 0, null, null, null, null, "CalendarEventEntries", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationships
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationships")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationships", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUsers
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUsers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUsers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Calendar' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCalendar
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEntityFactory))),	(IEntityRelation)GetRelationsForField("Calendar")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEntity, 0, null, null, null, null, "Calendar", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CalendarEventRecurringDefinition' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCalendarEventRecurringDefinition
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventRecurringDefinitionEntityFactory))),	(IEntityRelation)GetRelationsForField("CalendarEventRecurringDefinition")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionEntity, 0, null, null, null, null, "CalendarEventRecurringDefinition", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)CalendarEventFieldIndex.Id, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.Id, value); }
		}

		/// <summary> The AuthorId property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."AuthorId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid AuthorId
		{
			get { return (System.Guid)GetValue((int)CalendarEventFieldIndex.AuthorId, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.AuthorId, value); }
		}

		/// <summary> The DateCreated property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)CalendarEventFieldIndex.DateCreated, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.DateCreated, value); }
		}

		/// <summary> The DateModified property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."DateModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)CalendarEventFieldIndex.DateModified, false); }
			set	{ SetValue((int)CalendarEventFieldIndex.DateModified, value); }
		}

		/// <summary> The StartTime property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."StartTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartTime
		{
			get { return (System.DateTime)GetValue((int)CalendarEventFieldIndex.StartTime, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.StartTime, value); }
		}

		/// <summary> The EndTime property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."EndTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime EndTime
		{
			get { return (System.DateTime)GetValue((int)CalendarEventFieldIndex.EndTime, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.EndTime, value); }
		}

		/// <summary> The AllDay property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."AllDay"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean AllDay
		{
			get { return (System.Boolean)GetValue((int)CalendarEventFieldIndex.AllDay, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.AllDay, value); }
		}

		/// <summary> The Title property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)CalendarEventFieldIndex.Title, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.Title, value); }
		}

		/// <summary> The Description property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)CalendarEventFieldIndex.Description, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.Description, value); }
		}

		/// <summary> The Place property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."Place"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Place
		{
			get { return (System.String)GetValue((int)CalendarEventFieldIndex.Place, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.Place, value); }
		}

		/// <summary> The RecurringDefinitionId property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."RecurringDefinitionId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> RecurringDefinitionId
		{
			get { return (Nullable<System.Guid>)GetValue((int)CalendarEventFieldIndex.RecurringDefinitionId, false); }
			set	{ SetValue((int)CalendarEventFieldIndex.RecurringDefinitionId, value); }
		}

		/// <summary> The OwnerCalendarId property of the Entity CalendarEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEvent"."OwnerCalendarId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid OwnerCalendarId
		{
			get { return (System.Guid)GetValue((int)CalendarEventFieldIndex.OwnerCalendarId, true); }
			set	{ SetValue((int)CalendarEventFieldIndex.OwnerCalendarId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CalendarEventEntryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CalendarEventEntryEntity))]
		public virtual EntityCollection<CalendarEventEntryEntity> CalendarEventEntries
		{
			get { return GetOrCreateEntityCollection<CalendarEventEntryEntity, CalendarEventEntryEntityFactory>("CalendarEvent", true, false, ref _calendarEventEntries);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]
		public virtual EntityCollection<SnRelationshipEntity> SnRelationships
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("CalendarEvent", true, false, ref _snRelationships);	}
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
					SetSingleRelatedEntityNavigator(value, "CalendarEvents", "AspnetUsers", _aspnetUsers, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'CalendarEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual CalendarEntity Calendar
		{
			get	{ return _calendar; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCalendar(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CalendarEvents", "Calendar", _calendar, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'CalendarEventRecurringDefinitionEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual CalendarEventRecurringDefinitionEntity CalendarEventRecurringDefinition
		{
			get	{ return _calendarEventRecurringDefinition; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCalendarEventRecurringDefinition(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CalendarEvents", "CalendarEventRecurringDefinition", _calendarEventRecurringDefinition, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity; }
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
