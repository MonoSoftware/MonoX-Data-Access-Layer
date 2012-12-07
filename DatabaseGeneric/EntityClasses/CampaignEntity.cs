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
	/// <summary>Entity class which represents the entity 'Campaign'.<br/><br/></summary>
	[Serializable]
	public partial class CampaignEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<AdEntity> _ad;
		private EntityCollection<SnRelationshipEntity> _snRelationshipss;
		private AspnetApplicationsEntity _aspnetApplications;

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
			/// <summary>Member name Ad</summary>
			public static readonly string Ad = "Ad";
			/// <summary>Member name SnRelationshipss</summary>
			public static readonly string SnRelationshipss = "SnRelationshipss";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CampaignEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public CampaignEntity():base("CampaignEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CampaignEntity(IEntityFields2 fields):base("CampaignEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CampaignEntity</param>
		public CampaignEntity(IValidator validator):base("CampaignEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CampaignEntity(System.Guid id):base("CampaignEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <param name="validator">The custom validator object for this CampaignEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CampaignEntity(System.Guid id, IValidator validator):base("CampaignEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CampaignEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_ad = (EntityCollection<AdEntity>)info.GetValue("_ad", typeof(EntityCollection<AdEntity>));
				_snRelationshipss = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationshipss", typeof(EntityCollection<SnRelationshipEntity>));
				_aspnetApplications = (AspnetApplicationsEntity)info.GetValue("_aspnetApplications", typeof(AspnetApplicationsEntity));
				if(_aspnetApplications!=null)
				{
					_aspnetApplications.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((CampaignFieldIndex)fieldIndex)
			{
				case CampaignFieldIndex.ApplicationId:
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
		protected override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{
				case "AspnetApplications":
					this.AspnetApplications = (AspnetApplicationsEntity)entity;
					break;
				case "Ad":
					this.Ad.Add((AdEntity)entity);
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
				case "AspnetApplications":
					toReturn.Add(Relations.AspnetApplicationsEntityUsingApplicationId);
					break;
				case "Ad":
					toReturn.Add(Relations.AdEntityUsingCampaignId);
					break;
				case "SnRelationshipss":
					toReturn.Add(Relations.SnRelationshipEntityUsingCampaignId);
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
		protected override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "AspnetApplications":
					SetupSyncAspnetApplications(relatedEntity);
					break;
				case "Ad":
					this.Ad.Add((AdEntity)relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "AspnetApplications":
					DesetupSyncAspnetApplications(false, true);
					break;
				case "Ad":
					this.PerformRelatedEntityRemoval(this.Ad, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.Ad);
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
				info.AddValue("_ad", ((_ad!=null) && (_ad.Count>0) && !this.MarkedForDeletion)?_ad:null);
				info.AddValue("_snRelationshipss", ((_snRelationshipss!=null) && (_snRelationshipss.Count>0) && !this.MarkedForDeletion)?_snRelationshipss:null);
				info.AddValue("_aspnetApplications", (!this.MarkedForDeletion?_aspnetApplications:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CampaignRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Ad' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAd()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AdFields.CampaignId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationshipss()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.CampaignId, null, ComparisonOperator.Equal, this.Id));
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
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CampaignEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._ad);
			collectionsQueue.Enqueue(this._snRelationshipss);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._ad = (EntityCollection<AdEntity>) collectionsQueue.Dequeue();
			this._snRelationshipss = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._ad != null);
			toReturn |=(this._snRelationshipss != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AdEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AdEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetApplications", _aspnetApplications);
			toReturn.Add("Ad", _ad);
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
			_fieldsCustomProperties.Add("ApplicationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Start", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("End", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Active", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateEntered", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateModified", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetApplications</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetApplications(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticCampaignRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)CampaignFieldIndex.ApplicationId } );
			_aspnetApplications = null;
		}

		/// <summary> setups the sync logic for member _aspnetApplications</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetApplications(IEntity2 relatedEntity)
		{
			if(_aspnetApplications!=relatedEntity)
			{
				DesetupSyncAspnetApplications(true, true);
				_aspnetApplications = (AspnetApplicationsEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticCampaignRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, new string[] {  } );
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

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CampaignEntity</param>
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
		public  static CampaignRelations Relations
		{
			get	{ return new CampaignRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Ad' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAd
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<AdEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AdEntityFactory))), (IEntityRelation)GetRelationsForField("Ad")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CampaignEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AdEntity, 0, null, null, null, null, "Ad", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationshipss
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationshipss")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CampaignEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationshipss", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetApplications' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetApplications
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetApplicationsEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetApplications")[0], (int)MonoSoftware.MonoX.DAL.EntityType.CampaignEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, 0, null, null, null, null, "AspnetApplications", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Campaign"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)CampaignFieldIndex.Id, true); }
			set	{ SetValue((int)CampaignFieldIndex.Id, value); }
		}

		/// <summary> The ApplicationId property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Campaign"."ApplicationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid ApplicationId
		{
			get { return (System.Guid)GetValue((int)CampaignFieldIndex.ApplicationId, true); }
			set	{ SetValue((int)CampaignFieldIndex.ApplicationId, value); }
		}

		/// <summary> The Name property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Campaign"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CampaignFieldIndex.Name, true); }
			set	{ SetValue((int)CampaignFieldIndex.Name, value); }
		}

		/// <summary> The Start property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Campaign"."Start"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Start
		{
			get { return (Nullable<System.DateTime>)GetValue((int)CampaignFieldIndex.Start, false); }
			set	{ SetValue((int)CampaignFieldIndex.Start, value); }
		}

		/// <summary> The End property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Campaign"."End"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> End
		{
			get { return (Nullable<System.DateTime>)GetValue((int)CampaignFieldIndex.End, false); }
			set	{ SetValue((int)CampaignFieldIndex.End, value); }
		}

		/// <summary> The Active property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Campaign"."Active"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Active
		{
			get { return (System.Boolean)GetValue((int)CampaignFieldIndex.Active, true); }
			set	{ SetValue((int)CampaignFieldIndex.Active, value); }
		}

		/// <summary> The DateEntered property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Campaign"."DateEntered"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateEntered
		{
			get { return (System.DateTime)GetValue((int)CampaignFieldIndex.DateEntered, true); }
			set	{ SetValue((int)CampaignFieldIndex.DateEntered, value); }
		}

		/// <summary> The DateModified property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Campaign"."DateModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateModified
		{
			get { return (System.DateTime)GetValue((int)CampaignFieldIndex.DateModified, true); }
			set	{ SetValue((int)CampaignFieldIndex.DateModified, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AdEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AdEntity))]
		public virtual EntityCollection<AdEntity> Ad
		{
			get { return GetOrCreateEntityCollection<AdEntity, AdEntityFactory>("Campaign", true, false, ref _ad);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]
		public virtual EntityCollection<SnRelationshipEntity> SnRelationshipss
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("Campaign", true, false, ref _snRelationshipss);	}
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.CampaignEntity; }
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
