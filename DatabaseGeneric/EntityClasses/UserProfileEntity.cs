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
    using MonoSoftware.Web;
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'UserProfile'.<br/><br/></summary>
	[Serializable]
	public partial class UserProfileEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private PrivacyLevelEntity _privacyLevel;
		private TermsAndConditionsEntity _termsAndConditions;
		private AspnetUsersEntity _aspnetUser;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name PrivacyLevel</summary>
			public static readonly string PrivacyLevel = "PrivacyLevel";
			/// <summary>Member name TermsAndConditions</summary>
			public static readonly string TermsAndConditions = "TermsAndConditions";
			/// <summary>Member name AspnetUser</summary>
			public static readonly string AspnetUser = "AspnetUser";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UserProfileEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public UserProfileEntity():base("UserProfileEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UserProfileEntity(IEntityFields2 fields):base("UserProfileEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UserProfileEntity</param>
		public UserProfileEntity(IValidator validator):base("UserProfileEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for UserProfile which data should be fetched into this UserProfile object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UserProfileEntity(System.Guid id):base("UserProfileEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for UserProfile which data should be fetched into this UserProfile object</param>
		/// <param name="validator">The custom validator object for this UserProfileEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UserProfileEntity(System.Guid id, IValidator validator):base("UserProfileEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected UserProfileEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_privacyLevel = (PrivacyLevelEntity)info.GetValue("_privacyLevel", typeof(PrivacyLevelEntity));
				if(_privacyLevel!=null)
				{
					_privacyLevel.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_termsAndConditions = (TermsAndConditionsEntity)info.GetValue("_termsAndConditions", typeof(TermsAndConditionsEntity));
				if(_termsAndConditions!=null)
				{
					_termsAndConditions.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_aspnetUser = (AspnetUsersEntity)info.GetValue("_aspnetUser", typeof(AspnetUsersEntity));
				if(_aspnetUser!=null)
				{
					_aspnetUser.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((UserProfileFieldIndex)fieldIndex)
			{
				case UserProfileFieldIndex.Id:
					DesetupSyncAspnetUser(true, false);
					break;
				case UserProfileFieldIndex.MyStatusPrivacyLevelId:
					DesetupSyncPrivacyLevel(true, false);
					break;
				case UserProfileFieldIndex.TermsAndConditionsId:
					DesetupSyncTermsAndConditions(true, false);
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
				case "PrivacyLevel":
					this.PrivacyLevel = (PrivacyLevelEntity)entity;
					break;
				case "TermsAndConditions":
					this.TermsAndConditions = (TermsAndConditionsEntity)entity;
					break;
				case "AspnetUser":
					this.AspnetUser = (AspnetUsersEntity)entity;
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
				case "PrivacyLevel":
					toReturn.Add(Relations.PrivacyLevelEntityUsingMyStatusPrivacyLevelId);
					break;
				case "TermsAndConditions":
					toReturn.Add(Relations.TermsAndConditionsEntityUsingTermsAndConditionsId);
					break;
				case "AspnetUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingId);
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
				case "PrivacyLevel":
					SetupSyncPrivacyLevel(relatedEntity);
					break;
				case "TermsAndConditions":
					SetupSyncTermsAndConditions(relatedEntity);
					break;
				case "AspnetUser":
					SetupSyncAspnetUser(relatedEntity);
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
				case "PrivacyLevel":
					DesetupSyncPrivacyLevel(false, true);
					break;
				case "TermsAndConditions":
					DesetupSyncTermsAndConditions(false, true);
					break;
				case "AspnetUser":
					DesetupSyncAspnetUser(false, true);
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
			if(_privacyLevel!=null)
			{
				toReturn.Add(_privacyLevel);
			}
			if(_termsAndConditions!=null)
			{
				toReturn.Add(_termsAndConditions);
			}
			if(_aspnetUser!=null)
			{
				toReturn.Add(_aspnetUser);
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
				info.AddValue("_privacyLevel", (!this.MarkedForDeletion?_privacyLevel:null));
				info.AddValue("_termsAndConditions", (!this.MarkedForDeletion?_termsAndConditions:null));
				info.AddValue("_aspnetUser", (!this.MarkedForDeletion?_aspnetUser:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new UserProfileRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'PrivacyLevel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPrivacyLevel()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PrivacyLevelFields.Id, null, ComparisonOperator.Equal, this.MyStatusPrivacyLevelId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'TermsAndConditions' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTermsAndConditions()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TermsAndConditionsFields.Id, null, ComparisonOperator.Equal, this.TermsAndConditionsId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(UserProfileEntityFactory));
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
			toReturn.Add("PrivacyLevel", _privacyLevel);
			toReturn.Add("TermsAndConditions", _termsAndConditions);
			toReturn.Add("AspnetUser", _aspnetUser);
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
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BirthDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Address", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ZipCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Country", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AboutMySelf", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("WebSites", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmailVerified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MyStatus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MyStatusPrivacyLevelId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TermsAndConditionsId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TermsAndConditionsAgreedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateEntered", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ReputationScore", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TimeZoneId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _privacyLevel</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPrivacyLevel(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _privacyLevel, new PropertyChangedEventHandler( OnPrivacyLevelPropertyChanged ), "PrivacyLevel", MonoSoftware.MonoX.DAL.RelationClasses.StaticUserProfileRelations.PrivacyLevelEntityUsingMyStatusPrivacyLevelIdStatic, true, signalRelatedEntity, "UserProfile", resetFKFields, new int[] { (int)UserProfileFieldIndex.MyStatusPrivacyLevelId } );
			_privacyLevel = null;
		}

		/// <summary> setups the sync logic for member _privacyLevel</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPrivacyLevel(IEntity2 relatedEntity)
		{
			if(_privacyLevel!=relatedEntity)
			{
				DesetupSyncPrivacyLevel(true, true);
				_privacyLevel = (PrivacyLevelEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _privacyLevel, new PropertyChangedEventHandler( OnPrivacyLevelPropertyChanged ), "PrivacyLevel", MonoSoftware.MonoX.DAL.RelationClasses.StaticUserProfileRelations.PrivacyLevelEntityUsingMyStatusPrivacyLevelIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _termsAndConditions</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncTermsAndConditions(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _termsAndConditions, new PropertyChangedEventHandler( OnTermsAndConditionsPropertyChanged ), "TermsAndConditions", MonoSoftware.MonoX.DAL.RelationClasses.StaticUserProfileRelations.TermsAndConditionsEntityUsingTermsAndConditionsIdStatic, true, signalRelatedEntity, "UserProfile", resetFKFields, new int[] { (int)UserProfileFieldIndex.TermsAndConditionsId } );
			_termsAndConditions = null;
		}

		/// <summary> setups the sync logic for member _termsAndConditions</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncTermsAndConditions(IEntity2 relatedEntity)
		{
			if(_termsAndConditions!=relatedEntity)
			{
				DesetupSyncTermsAndConditions(true, true);
				_termsAndConditions = (TermsAndConditionsEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _termsAndConditions, new PropertyChangedEventHandler( OnTermsAndConditionsPropertyChanged ), "TermsAndConditions", MonoSoftware.MonoX.DAL.RelationClasses.StaticUserProfileRelations.TermsAndConditionsEntityUsingTermsAndConditionsIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTermsAndConditionsPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticUserProfileRelations.AspnetUsersEntityUsingIdStatic, true, signalRelatedEntity, "UserProfile", false, new int[] { (int)UserProfileFieldIndex.Id } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticUserProfileRelations.AspnetUsersEntityUsingIdStatic, true, new string[] {  } );
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

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this UserProfileEntity</param>
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
		public  static UserProfileRelations Relations
		{
			get	{ return new UserProfileRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PrivacyLevel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPrivacyLevel
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PrivacyLevelEntityFactory))),	(IEntityRelation)GetRelationsForField("PrivacyLevel")[0], (int)MonoSoftware.MonoX.DAL.EntityType.UserProfileEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity, 0, null, null, null, null, "PrivacyLevel", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TermsAndConditions' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTermsAndConditions
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(TermsAndConditionsEntityFactory))),	(IEntityRelation)GetRelationsForField("TermsAndConditions")[0], (int)MonoSoftware.MonoX.DAL.EntityType.UserProfileEntity, (int)MonoSoftware.MonoX.DAL.EntityType.TermsAndConditionsEntity, 0, null, null, null, null, "TermsAndConditions", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUser
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))), (IEntityRelation)GetRelationsForField("AspnetUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.UserProfileEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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

		/// <summary> The Id property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)UserProfileFieldIndex.Id, true); }
			set	{ SetValue((int)UserProfileFieldIndex.Id, value); }
		}

		/// <summary> The FirstName property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.FirstName, true); }
			set	{ SetValue((int)UserProfileFieldIndex.FirstName, value); }
		}

		/// <summary> The LastName property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.LastName, true); }
			set	{ SetValue((int)UserProfileFieldIndex.LastName, value); }
		}

		/// <summary> The BirthDate property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."BirthDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> BirthDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserProfileFieldIndex.BirthDate, false); }
			set	{ SetValue((int)UserProfileFieldIndex.BirthDate, value); }
		}

		/// <summary> The Address property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."Address"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.Address, true); }
			set	{ SetValue((int)UserProfileFieldIndex.Address, value); }
		}

		/// <summary> The City property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.City, true); }
			set	{ SetValue((int)UserProfileFieldIndex.City, value); }
		}

		/// <summary> The ZipCode property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."ZipCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ZipCode
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.ZipCode, true); }
			set	{ SetValue((int)UserProfileFieldIndex.ZipCode, value); }
		}

		/// <summary> The Country property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."Country"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Country
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.Country, true); }
			set	{ SetValue((int)UserProfileFieldIndex.Country, value); }
		}

		/// <summary> The AboutMySelf property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."AboutMySelf"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AboutMySelf
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.AboutMySelf, true); }
			set	{ SetValue((int)UserProfileFieldIndex.AboutMySelf, value); }
		}

		/// <summary> The WebSites property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."WebSites"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String WebSites
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.WebSites, true); }
			set	{ SetValue((int)UserProfileFieldIndex.WebSites, value); }
		}

		/// <summary> The EmailVerified property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."EMailVerified"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean EmailVerified
		{
			get { return (System.Boolean)GetValue((int)UserProfileFieldIndex.EmailVerified, true); }
			set	{ SetValue((int)UserProfileFieldIndex.EmailVerified, value); }
		}

		/// <summary> The MyStatus property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."MyStatus"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MyStatus
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.MyStatus, true); }
			set	{ SetValue((int)UserProfileFieldIndex.MyStatus, value); }
		}

		/// <summary> The MyStatusPrivacyLevelId property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."MyStatusPrivacyLevelId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> MyStatusPrivacyLevelId
		{
			get { return (Nullable<System.Guid>)GetValue((int)UserProfileFieldIndex.MyStatusPrivacyLevelId, false); }
			set	{ SetValue((int)UserProfileFieldIndex.MyStatusPrivacyLevelId, value); }
		}

		/// <summary> The TermsAndConditionsId property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."TermsAndConditionsId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> TermsAndConditionsId
		{
			get { return (Nullable<System.Guid>)GetValue((int)UserProfileFieldIndex.TermsAndConditionsId, false); }
			set	{ SetValue((int)UserProfileFieldIndex.TermsAndConditionsId, value); }
		}

		/// <summary> The TermsAndConditionsAgreedDate property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."TermsAndConditionsAgreedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> TermsAndConditionsAgreedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserProfileFieldIndex.TermsAndConditionsAgreedDate, false); }
			set	{ SetValue((int)UserProfileFieldIndex.TermsAndConditionsAgreedDate, value); }
		}

		/// <summary> The DateEntered property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."DateEntered"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateEntered
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserProfileFieldIndex.DateEntered, false); }
			set	{ SetValue((int)UserProfileFieldIndex.DateEntered, value); }
		}

		/// <summary> The DateModified property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."DateModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserProfileFieldIndex.DateModified, false); }
			set	{ SetValue((int)UserProfileFieldIndex.DateModified, value); }
		}

		/// <summary> The ReputationScore property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."ReputationScore"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ReputationScore
		{
			get { return (Nullable<System.Int32>)GetValue((int)UserProfileFieldIndex.ReputationScore, false); }
			set	{ SetValue((int)UserProfileFieldIndex.ReputationScore, value); }
		}

		/// <summary> The TimeZoneId property of the Entity UserProfile<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserProfile"."TimeZoneId"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TimeZoneId
		{
			get { return (System.String)GetValue((int)UserProfileFieldIndex.TimeZoneId, true); }
			set	{ SetValue((int)UserProfileFieldIndex.TimeZoneId, value); }
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
					SetSingleRelatedEntityNavigator(value, "UserProfile", "PrivacyLevel", _privacyLevel, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'TermsAndConditionsEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual TermsAndConditionsEntity TermsAndConditions
		{
			get	{ return _termsAndConditions; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncTermsAndConditions(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "UserProfile", "TermsAndConditions", _termsAndConditions, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AspnetUsersEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(true)]
		public virtual AspnetUsersEntity AspnetUser
		{
			get { return _aspnetUser; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAspnetUser(value);
					CallSetRelatedEntityDuringDeserialization(value, "UserProfile");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_aspnetUser !=null);
						DesetupSyncAspnetUser(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("AspnetUser");
						}
					}
					else
					{
						if(_aspnetUser!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "UserProfile");
							SetupSyncAspnetUser(value);
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.UserProfileEntity; }
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
