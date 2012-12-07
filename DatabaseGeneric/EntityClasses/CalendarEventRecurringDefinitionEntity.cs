﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Entity class which represents the entity 'CalendarEventRecurringDefinition'.<br/><br/></summary>
	[Serializable]
	public partial class CalendarEventRecurringDefinitionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<CalendarEventEntity> _calendarEvents;
		private CalendarEventRecurringDefinitionTypeEntity _calendarEventRecurringDefinitionType;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CalendarEventRecurringDefinitionType</summary>
			public static readonly string CalendarEventRecurringDefinitionType = "CalendarEventRecurringDefinitionType";
			/// <summary>Member name CalendarEvents</summary>
			public static readonly string CalendarEvents = "CalendarEvents";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CalendarEventRecurringDefinitionEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public CalendarEventRecurringDefinitionEntity():base("CalendarEventRecurringDefinitionEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CalendarEventRecurringDefinitionEntity(IEntityFields2 fields):base("CalendarEventRecurringDefinitionEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CalendarEventRecurringDefinitionEntity</param>
		public CalendarEventRecurringDefinitionEntity(IValidator validator):base("CalendarEventRecurringDefinitionEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for CalendarEventRecurringDefinition which data should be fetched into this CalendarEventRecurringDefinition object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CalendarEventRecurringDefinitionEntity(System.Guid id):base("CalendarEventRecurringDefinitionEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for CalendarEventRecurringDefinition which data should be fetched into this CalendarEventRecurringDefinition object</param>
		/// <param name="validator">The custom validator object for this CalendarEventRecurringDefinitionEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CalendarEventRecurringDefinitionEntity(System.Guid id, IValidator validator):base("CalendarEventRecurringDefinitionEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CalendarEventRecurringDefinitionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_calendarEvents = (EntityCollection<CalendarEventEntity>)info.GetValue("_calendarEvents", typeof(EntityCollection<CalendarEventEntity>));
				_calendarEventRecurringDefinitionType = (CalendarEventRecurringDefinitionTypeEntity)info.GetValue("_calendarEventRecurringDefinitionType", typeof(CalendarEventRecurringDefinitionTypeEntity));
				if(_calendarEventRecurringDefinitionType!=null)
				{
					_calendarEventRecurringDefinitionType.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((CalendarEventRecurringDefinitionFieldIndex)fieldIndex)
			{
				case CalendarEventRecurringDefinitionFieldIndex.RecurringTypeId:
					DesetupSyncCalendarEventRecurringDefinitionType(true, false);
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
				case "CalendarEventRecurringDefinitionType":
					this.CalendarEventRecurringDefinitionType = (CalendarEventRecurringDefinitionTypeEntity)entity;
					break;
				case "CalendarEvents":
					this.CalendarEvents.Add((CalendarEventEntity)entity);
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
				case "CalendarEventRecurringDefinitionType":
					toReturn.Add(Relations.CalendarEventRecurringDefinitionTypeEntityUsingRecurringTypeId);
					break;
				case "CalendarEvents":
					toReturn.Add(Relations.CalendarEventEntityUsingRecurringDefinitionId);
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
				case "CalendarEventRecurringDefinitionType":
					SetupSyncCalendarEventRecurringDefinitionType(relatedEntity);
					break;
				case "CalendarEvents":
					this.CalendarEvents.Add((CalendarEventEntity)relatedEntity);
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
				case "CalendarEventRecurringDefinitionType":
					DesetupSyncCalendarEventRecurringDefinitionType(false, true);
					break;
				case "CalendarEvents":
					this.PerformRelatedEntityRemoval(this.CalendarEvents, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_calendarEventRecurringDefinitionType!=null)
			{
				toReturn.Add(_calendarEventRecurringDefinitionType);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.CalendarEvents);
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
				info.AddValue("_calendarEvents", ((_calendarEvents!=null) && (_calendarEvents.Count>0) && !this.MarkedForDeletion)?_calendarEvents:null);
				info.AddValue("_calendarEventRecurringDefinitionType", (!this.MarkedForDeletion?_calendarEventRecurringDefinitionType:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CalendarEventRecurringDefinitionRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CalendarEvent' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCalendarEvents()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CalendarEventFields.RecurringDefinitionId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CalendarEventRecurringDefinitionType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCalendarEventRecurringDefinitionType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CalendarEventRecurringDefinitionTypeFields.Id, null, ComparisonOperator.Equal, this.RecurringTypeId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventRecurringDefinitionEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._calendarEvents);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._calendarEvents = (EntityCollection<CalendarEventEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._calendarEvents != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CalendarEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CalendarEventRecurringDefinitionType", _calendarEventRecurringDefinitionType);
			toReturn.Add("CalendarEvents", _calendarEvents);
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
			_fieldsCustomProperties.Add("RecurringTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RepeatFactor", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Sunday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Monday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Tuesday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Wednesday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Thursday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Friday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Saturday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DayOfMonth", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MonthOfYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StartsOn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EndsOn", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _calendarEventRecurringDefinitionType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCalendarEventRecurringDefinitionType(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _calendarEventRecurringDefinitionType, new PropertyChangedEventHandler( OnCalendarEventRecurringDefinitionTypePropertyChanged ), "CalendarEventRecurringDefinitionType", MonoSoftware.MonoX.DAL.RelationClasses.StaticCalendarEventRecurringDefinitionRelations.CalendarEventRecurringDefinitionTypeEntityUsingRecurringTypeIdStatic, true, signalRelatedEntity, "CalendarEventRecurringDefinitions", resetFKFields, new int[] { (int)CalendarEventRecurringDefinitionFieldIndex.RecurringTypeId } );
			_calendarEventRecurringDefinitionType = null;
		}

		/// <summary> setups the sync logic for member _calendarEventRecurringDefinitionType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCalendarEventRecurringDefinitionType(IEntity2 relatedEntity)
		{
			if(_calendarEventRecurringDefinitionType!=relatedEntity)
			{
				DesetupSyncCalendarEventRecurringDefinitionType(true, true);
				_calendarEventRecurringDefinitionType = (CalendarEventRecurringDefinitionTypeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _calendarEventRecurringDefinitionType, new PropertyChangedEventHandler( OnCalendarEventRecurringDefinitionTypePropertyChanged ), "CalendarEventRecurringDefinitionType", MonoSoftware.MonoX.DAL.RelationClasses.StaticCalendarEventRecurringDefinitionRelations.CalendarEventRecurringDefinitionTypeEntityUsingRecurringTypeIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCalendarEventRecurringDefinitionTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CalendarEventRecurringDefinitionEntity</param>
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
		public  static CalendarEventRecurringDefinitionRelations Relations
		{
			get	{ return new CalendarEventRecurringDefinitionRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CalendarEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCalendarEvents
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CalendarEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventEntityFactory))), (IEntityRelation)GetRelationsForField("CalendarEvents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity, 0, null, null, null, null, "CalendarEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CalendarEventRecurringDefinitionType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCalendarEventRecurringDefinitionType
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CalendarEventRecurringDefinitionTypeEntityFactory))),	(IEntityRelation)GetRelationsForField("CalendarEventRecurringDefinitionType")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionEntity, (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionTypeEntity, 0, null, null, null, null, "CalendarEventRecurringDefinitionType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.Id, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.Id, value); }
		}

		/// <summary> The RecurringTypeId property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."RecurringTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid RecurringTypeId
		{
			get { return (System.Guid)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.RecurringTypeId, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.RecurringTypeId, value); }
		}

		/// <summary> The RepeatFactor property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."RepeatFactor"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RepeatFactor
		{
			get { return (System.Int32)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.RepeatFactor, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.RepeatFactor, value); }
		}

		/// <summary> The Sunday property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."Sunday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Sunday
		{
			get { return (System.Boolean)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.Sunday, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.Sunday, value); }
		}

		/// <summary> The Monday property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."Monday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Monday
		{
			get { return (System.Boolean)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.Monday, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.Monday, value); }
		}

		/// <summary> The Tuesday property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."Tuesday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Tuesday
		{
			get { return (System.Boolean)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.Tuesday, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.Tuesday, value); }
		}

		/// <summary> The Wednesday property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."Wednesday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Wednesday
		{
			get { return (System.Boolean)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.Wednesday, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.Wednesday, value); }
		}

		/// <summary> The Thursday property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."Thursday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Thursday
		{
			get { return (System.Boolean)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.Thursday, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.Thursday, value); }
		}

		/// <summary> The Friday property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."Friday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Friday
		{
			get { return (System.Boolean)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.Friday, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.Friday, value); }
		}

		/// <summary> The Saturday property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."Saturday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Saturday
		{
			get { return (System.Boolean)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.Saturday, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.Saturday, value); }
		}

		/// <summary> The DayOfMonth property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."DayOfMonth"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DayOfMonth
		{
			get { return (Nullable<System.Int32>)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.DayOfMonth, false); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.DayOfMonth, value); }
		}

		/// <summary> The MonthOfYear property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."MonthOfYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> MonthOfYear
		{
			get { return (Nullable<System.Int32>)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.MonthOfYear, false); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.MonthOfYear, value); }
		}

		/// <summary> The StartsOn property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."StartsOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartsOn
		{
			get { return (System.DateTime)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.StartsOn, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.StartsOn, value); }
		}

		/// <summary> The EndsOn property of the Entity CalendarEventRecurringDefinition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CalendarEventRecurringDefinition"."EndsOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime EndsOn
		{
			get { return (System.DateTime)GetValue((int)CalendarEventRecurringDefinitionFieldIndex.EndsOn, true); }
			set	{ SetValue((int)CalendarEventRecurringDefinitionFieldIndex.EndsOn, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CalendarEventEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CalendarEventEntity))]
		public virtual EntityCollection<CalendarEventEntity> CalendarEvents
		{
			get { return GetOrCreateEntityCollection<CalendarEventEntity, CalendarEventEntityFactory>("CalendarEventRecurringDefinition", true, false, ref _calendarEvents);	}
		}

		/// <summary> Gets / sets related entity of type 'CalendarEventRecurringDefinitionTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual CalendarEventRecurringDefinitionTypeEntity CalendarEventRecurringDefinitionType
		{
			get	{ return _calendarEventRecurringDefinitionType; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCalendarEventRecurringDefinitionType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CalendarEventRecurringDefinitions", "CalendarEventRecurringDefinitionType", _calendarEventRecurringDefinitionType, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionEntity; }
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