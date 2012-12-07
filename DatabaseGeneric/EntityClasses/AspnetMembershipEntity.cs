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
	/// <summary>Entity class which represents the entity 'AspnetMembership'.<br/><br/></summary>
	[Serializable]
	public partial class AspnetMembershipEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AspnetApplicationsEntity _aspnetApplications;
		private AspnetUsersEntity _aspnetUsers;

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
			/// <summary>Member name AspnetUsers</summary>
			public static readonly string AspnetUsers = "AspnetUsers";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AspnetMembershipEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public AspnetMembershipEntity():base("AspnetMembershipEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AspnetMembershipEntity(IEntityFields2 fields):base("AspnetMembershipEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AspnetMembershipEntity</param>
		public AspnetMembershipEntity(IValidator validator):base("AspnetMembershipEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="userId">PK value for AspnetMembership which data should be fetched into this AspnetMembership object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AspnetMembershipEntity(System.Guid userId):base("AspnetMembershipEntity")
		{
			InitClassEmpty(null, null);
			this.UserId = userId;
		}

		/// <summary> CTor</summary>
		/// <param name="userId">PK value for AspnetMembership which data should be fetched into this AspnetMembership object</param>
		/// <param name="validator">The custom validator object for this AspnetMembershipEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AspnetMembershipEntity(System.Guid userId, IValidator validator):base("AspnetMembershipEntity")
		{
			InitClassEmpty(validator, null);
			this.UserId = userId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AspnetMembershipEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_aspnetApplications = (AspnetApplicationsEntity)info.GetValue("_aspnetApplications", typeof(AspnetApplicationsEntity));
				if(_aspnetApplications!=null)
				{
					_aspnetApplications.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_aspnetUsers = (AspnetUsersEntity)info.GetValue("_aspnetUsers", typeof(AspnetUsersEntity));
				if(_aspnetUsers!=null)
				{
					_aspnetUsers.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((AspnetMembershipFieldIndex)fieldIndex)
			{
				case AspnetMembershipFieldIndex.ApplicationId:
					DesetupSyncAspnetApplications(true, false);
					break;
				case AspnetMembershipFieldIndex.UserId:
					DesetupSyncAspnetUsers(true, false);
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
				case "AspnetUsers":
					this.AspnetUsers = (AspnetUsersEntity)entity;
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
				case "AspnetUsers":
					toReturn.Add(Relations.AspnetUsersEntityUsingUserId);
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
				case "AspnetUsers":
					SetupSyncAspnetUsers(relatedEntity);
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
				case "AspnetUsers":
					DesetupSyncAspnetUsers(false, true);
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
			if(_aspnetUsers!=null)
			{
				toReturn.Add(_aspnetUsers);
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
				info.AddValue("_aspnetApplications", (!this.MarkedForDeletion?_aspnetApplications:null));
				info.AddValue("_aspnetUsers", (!this.MarkedForDeletion?_aspnetUsers:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AspnetMembershipRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetApplications' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetApplications()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetApplicationsFields.ApplicationId, null, ComparisonOperator.Equal, this.ApplicationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetUsers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(AspnetMembershipEntityFactory));
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
			toReturn.Add("AspnetApplications", _aspnetApplications);
			toReturn.Add("AspnetUsers", _aspnetUsers);
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
			_fieldsCustomProperties.Add("Password", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PasswordFormat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PasswordSalt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MobilePin", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Email", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LoweredEmail", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PasswordQuestion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PasswordAnswer", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsApproved", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsLockedOut", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CreateDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastLoginDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastPasswordChangedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastLockoutDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FailedPasswordAttemptCount", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FailedPasswordAttemptWindowStart", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FailedPasswordAnswerAttemptCount", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FailedPasswordAnswerAttemptWindowStart", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Comment", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetApplications</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetApplications(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetMembershipRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)AspnetMembershipFieldIndex.ApplicationId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetMembershipRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _aspnetUsers</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetUsers(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetUsers, new PropertyChangedEventHandler( OnAspnetUsersPropertyChanged ), "AspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetMembershipRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "AspnetMembership", false, new int[] { (int)AspnetMembershipFieldIndex.UserId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetUsers, new PropertyChangedEventHandler( OnAspnetUsersPropertyChanged ), "AspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticAspnetMembershipRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
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

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AspnetMembershipEntity</param>
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
		public  static AspnetMembershipRelations Relations
		{
			get	{ return new AspnetMembershipRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetApplications' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetApplications
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetApplicationsEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetApplications")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetMembershipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, 0, null, null, null, null, "AspnetApplications", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUsers
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))), (IEntityRelation)GetRelationsForField("AspnetUsers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.AspnetMembershipEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUsers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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

		/// <summary> The ApplicationId property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."ApplicationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid ApplicationId
		{
			get { return (System.Guid)GetValue((int)AspnetMembershipFieldIndex.ApplicationId, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.ApplicationId, value); }
		}

		/// <summary> The UserId property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid UserId
		{
			get { return (System.Guid)GetValue((int)AspnetMembershipFieldIndex.UserId, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.UserId, value); }
		}

		/// <summary> The Password property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 128<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Password
		{
			get { return (System.String)GetValue((int)AspnetMembershipFieldIndex.Password, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.Password, value); }
		}

		/// <summary> The PasswordFormat property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."PasswordFormat"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 PasswordFormat
		{
			get { return (System.Int32)GetValue((int)AspnetMembershipFieldIndex.PasswordFormat, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.PasswordFormat, value); }
		}

		/// <summary> The PasswordSalt property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."PasswordSalt"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 128<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordSalt
		{
			get { return (System.String)GetValue((int)AspnetMembershipFieldIndex.PasswordSalt, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.PasswordSalt, value); }
		}

		/// <summary> The MobilePin property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."MobilePIN"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 16<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MobilePin
		{
			get { return (System.String)GetValue((int)AspnetMembershipFieldIndex.MobilePin, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.MobilePin, value); }
		}

		/// <summary> The Email property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."Email"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Email
		{
			get { return (System.String)GetValue((int)AspnetMembershipFieldIndex.Email, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.Email, value); }
		}

		/// <summary> The LoweredEmail property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."LoweredEmail"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String LoweredEmail
		{
			get { return (System.String)GetValue((int)AspnetMembershipFieldIndex.LoweredEmail, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.LoweredEmail, value); }
		}

		/// <summary> The PasswordQuestion property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."PasswordQuestion"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PasswordQuestion
		{
			get { return (System.String)GetValue((int)AspnetMembershipFieldIndex.PasswordQuestion, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.PasswordQuestion, value); }
		}

		/// <summary> The PasswordAnswer property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."PasswordAnswer"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 128<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PasswordAnswer
		{
			get { return (System.String)GetValue((int)AspnetMembershipFieldIndex.PasswordAnswer, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.PasswordAnswer, value); }
		}

		/// <summary> The IsApproved property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."IsApproved"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsApproved
		{
			get { return (System.Boolean)GetValue((int)AspnetMembershipFieldIndex.IsApproved, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.IsApproved, value); }
		}

		/// <summary> The IsLockedOut property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."IsLockedOut"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsLockedOut
		{
			get { return (System.Boolean)GetValue((int)AspnetMembershipFieldIndex.IsLockedOut, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.IsLockedOut, value); }
		}

		/// <summary> The CreateDate property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."CreateDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreateDate
		{
			get { return (System.DateTime)GetValue((int)AspnetMembershipFieldIndex.CreateDate, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.CreateDate, value); }
		}

		/// <summary> The LastLoginDate property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."LastLoginDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime LastLoginDate
		{
			get { return (System.DateTime)GetValue((int)AspnetMembershipFieldIndex.LastLoginDate, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.LastLoginDate, value); }
		}

		/// <summary> The LastPasswordChangedDate property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."LastPasswordChangedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime LastPasswordChangedDate
		{
			get { return (System.DateTime)GetValue((int)AspnetMembershipFieldIndex.LastPasswordChangedDate, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.LastPasswordChangedDate, value); }
		}

		/// <summary> The LastLockoutDate property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."LastLockoutDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime LastLockoutDate
		{
			get { return (System.DateTime)GetValue((int)AspnetMembershipFieldIndex.LastLockoutDate, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.LastLockoutDate, value); }
		}

		/// <summary> The FailedPasswordAttemptCount property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."FailedPasswordAttemptCount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 FailedPasswordAttemptCount
		{
			get { return (System.Int32)GetValue((int)AspnetMembershipFieldIndex.FailedPasswordAttemptCount, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.FailedPasswordAttemptCount, value); }
		}

		/// <summary> The FailedPasswordAttemptWindowStart property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."FailedPasswordAttemptWindowStart"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime FailedPasswordAttemptWindowStart
		{
			get { return (System.DateTime)GetValue((int)AspnetMembershipFieldIndex.FailedPasswordAttemptWindowStart, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.FailedPasswordAttemptWindowStart, value); }
		}

		/// <summary> The FailedPasswordAnswerAttemptCount property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."FailedPasswordAnswerAttemptCount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 FailedPasswordAnswerAttemptCount
		{
			get { return (System.Int32)GetValue((int)AspnetMembershipFieldIndex.FailedPasswordAnswerAttemptCount, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.FailedPasswordAnswerAttemptCount, value); }
		}

		/// <summary> The FailedPasswordAnswerAttemptWindowStart property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."FailedPasswordAnswerAttemptWindowStart"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime FailedPasswordAnswerAttemptWindowStart
		{
			get { return (System.DateTime)GetValue((int)AspnetMembershipFieldIndex.FailedPasswordAnswerAttemptWindowStart, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.FailedPasswordAnswerAttemptWindowStart, value); }
		}

		/// <summary> The Comment property of the Entity AspnetMembership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "aspnet_Membership"."Comment"<br/>
		/// Table field type characteristics (type, precision, scale, length): NText, 0, 0, 1073741823<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Comment
		{
			get { return (System.String)GetValue((int)AspnetMembershipFieldIndex.Comment, true); }
			set	{ SetValue((int)AspnetMembershipFieldIndex.Comment, value); }
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

		/// <summary> Gets / sets related entity of type 'AspnetUsersEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(true)]
		public virtual AspnetUsersEntity AspnetUsers
		{
			get { return _aspnetUsers; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAspnetUsers(value);
					CallSetRelatedEntityDuringDeserialization(value, "AspnetMembership");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_aspnetUsers !=null);
						DesetupSyncAspnetUsers(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("AspnetUsers");
						}
					}
					else
					{
						if(_aspnetUsers!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "AspnetMembership");
							SetupSyncAspnetUsers(value);
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.AspnetMembershipEntity; }
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
