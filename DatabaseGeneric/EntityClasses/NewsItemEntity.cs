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
    using MonoSoftware.MonoX;
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'NewsItem'.<br/><br/></summary>
	[Serializable]
	public partial class NewsItemEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<NewsFileEntity> _newsFiles;
		private EntityCollection<NewsItemLocalizationEntity> _newsItemLocalizations;
		private EntityCollection<NewsPublishQueueEntity> _newsPublishQueues;
		private EntityCollection<SnRelationshipEntity> _snRelationships;
		private AspnetUsersEntity _aspnetUser;
		private NewsCategoryEntity _newsCategory;

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
			/// <summary>Member name NewsCategory</summary>
			public static readonly string NewsCategory = "NewsCategory";
			/// <summary>Member name NewsFiles</summary>
			public static readonly string NewsFiles = "NewsFiles";
			/// <summary>Member name NewsItemLocalizations</summary>
			public static readonly string NewsItemLocalizations = "NewsItemLocalizations";
			/// <summary>Member name NewsPublishQueues</summary>
			public static readonly string NewsPublishQueues = "NewsPublishQueues";
			/// <summary>Member name SnRelationships</summary>
			public static readonly string SnRelationships = "SnRelationships";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static NewsItemEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public NewsItemEntity():base("NewsItemEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public NewsItemEntity(IEntityFields2 fields):base("NewsItemEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this NewsItemEntity</param>
		public NewsItemEntity(IValidator validator):base("NewsItemEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for NewsItem which data should be fetched into this NewsItem object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public NewsItemEntity(System.Guid id):base("NewsItemEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for NewsItem which data should be fetched into this NewsItem object</param>
		/// <param name="validator">The custom validator object for this NewsItemEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public NewsItemEntity(System.Guid id, IValidator validator):base("NewsItemEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected NewsItemEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_newsFiles = (EntityCollection<NewsFileEntity>)info.GetValue("_newsFiles", typeof(EntityCollection<NewsFileEntity>));
				_newsItemLocalizations = (EntityCollection<NewsItemLocalizationEntity>)info.GetValue("_newsItemLocalizations", typeof(EntityCollection<NewsItemLocalizationEntity>));
				_newsPublishQueues = (EntityCollection<NewsPublishQueueEntity>)info.GetValue("_newsPublishQueues", typeof(EntityCollection<NewsPublishQueueEntity>));
				_snRelationships = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationships", typeof(EntityCollection<SnRelationshipEntity>));
				_aspnetUser = (AspnetUsersEntity)info.GetValue("_aspnetUser", typeof(AspnetUsersEntity));
				if(_aspnetUser!=null)
				{
					_aspnetUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_newsCategory = (NewsCategoryEntity)info.GetValue("_newsCategory", typeof(NewsCategoryEntity));
				if(_newsCategory!=null)
				{
					_newsCategory.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((NewsItemFieldIndex)fieldIndex)
			{
				case NewsItemFieldIndex.NewsCategoryId:
					DesetupSyncNewsCategory(true, false);
					break;
				case NewsItemFieldIndex.UserId:
					DesetupSyncAspnetUser(true, false);
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
				case "NewsCategory":
					this.NewsCategory = (NewsCategoryEntity)entity;
					break;
				case "NewsFiles":
					this.NewsFiles.Add((NewsFileEntity)entity);
					break;
				case "NewsItemLocalizations":
					this.NewsItemLocalizations.Add((NewsItemLocalizationEntity)entity);
					break;
				case "NewsPublishQueues":
					this.NewsPublishQueues.Add((NewsPublishQueueEntity)entity);
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
				case "NewsCategory":
					toReturn.Add(Relations.NewsCategoryEntityUsingNewsCategoryId);
					break;
				case "NewsFiles":
					toReturn.Add(Relations.NewsFileEntityUsingNewsItemId);
					break;
				case "NewsItemLocalizations":
					toReturn.Add(Relations.NewsItemLocalizationEntityUsingNewsId);
					break;
				case "NewsPublishQueues":
					toReturn.Add(Relations.NewsPublishQueueEntityUsingNewsItemId);
					break;
				case "SnRelationships":
					toReturn.Add(Relations.SnRelationshipEntityUsingNewsItemId);
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
				case "AspnetUser":
					SetupSyncAspnetUser(relatedEntity);
					break;
				case "NewsCategory":
					SetupSyncNewsCategory(relatedEntity);
					break;
				case "NewsFiles":
					this.NewsFiles.Add((NewsFileEntity)relatedEntity);
					break;
				case "NewsItemLocalizations":
					this.NewsItemLocalizations.Add((NewsItemLocalizationEntity)relatedEntity);
					break;
				case "NewsPublishQueues":
					this.NewsPublishQueues.Add((NewsPublishQueueEntity)relatedEntity);
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
				case "NewsCategory":
					DesetupSyncNewsCategory(false, true);
					break;
				case "NewsFiles":
					this.PerformRelatedEntityRemoval(this.NewsFiles, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NewsItemLocalizations":
					this.PerformRelatedEntityRemoval(this.NewsItemLocalizations, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NewsPublishQueues":
					this.PerformRelatedEntityRemoval(this.NewsPublishQueues, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_newsCategory!=null)
			{
				toReturn.Add(_newsCategory);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.NewsFiles);
			toReturn.Add(this.NewsItemLocalizations);
			toReturn.Add(this.NewsPublishQueues);
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
				info.AddValue("_newsFiles", ((_newsFiles!=null) && (_newsFiles.Count>0) && !this.MarkedForDeletion)?_newsFiles:null);
				info.AddValue("_newsItemLocalizations", ((_newsItemLocalizations!=null) && (_newsItemLocalizations.Count>0) && !this.MarkedForDeletion)?_newsItemLocalizations:null);
				info.AddValue("_newsPublishQueues", ((_newsPublishQueues!=null) && (_newsPublishQueues.Count>0) && !this.MarkedForDeletion)?_newsPublishQueues:null);
				info.AddValue("_snRelationships", ((_snRelationships!=null) && (_snRelationships.Count>0) && !this.MarkedForDeletion)?_snRelationships:null);
				info.AddValue("_aspnetUser", (!this.MarkedForDeletion?_aspnetUser:null));
				info.AddValue("_newsCategory", (!this.MarkedForDeletion?_newsCategory:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new NewsItemRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsFile' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsFiles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsFileFields.NewsItemId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsItemLocalization' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsItemLocalizations()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsItemLocalizationFields.NewsId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsPublishQueue' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsPublishQueues()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsPublishQueueFields.NewsItemId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationships()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.NewsItemId, null, ComparisonOperator.Equal, this.Id));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'NewsCategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsCategory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsCategoryFields.Id, null, ComparisonOperator.Equal, this.NewsCategoryId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(NewsItemEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._newsFiles);
			collectionsQueue.Enqueue(this._newsItemLocalizations);
			collectionsQueue.Enqueue(this._newsPublishQueues);
			collectionsQueue.Enqueue(this._snRelationships);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._newsFiles = (EntityCollection<NewsFileEntity>) collectionsQueue.Dequeue();
			this._newsItemLocalizations = (EntityCollection<NewsItemLocalizationEntity>) collectionsQueue.Dequeue();
			this._newsPublishQueues = (EntityCollection<NewsPublishQueueEntity>) collectionsQueue.Dequeue();
			this._snRelationships = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._newsFiles != null);
			toReturn |=(this._newsItemLocalizations != null);
			toReturn |=(this._newsPublishQueues != null);
			toReturn |=(this._snRelationships != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsFileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsFileEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsItemLocalizationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsItemLocalizationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsPublishQueueEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsPublishQueueEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetUser", _aspnetUser);
			toReturn.Add("NewsCategory", _newsCategory);
			toReturn.Add("NewsFiles", _newsFiles);
			toReturn.Add("NewsItemLocalizations", _newsItemLocalizations);
			toReturn.Add("NewsPublishQueues", _newsPublishQueues);
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
			_fieldsCustomProperties.Add("NewsCategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShowOnHomePage", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Revision", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShowTitle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShowShortContent", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShowCategoryTitle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShowCategoryTitleAsLink", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShowFullCategoryPath", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShowUserName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShowDateEntered", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShowDateModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ViewCount", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateEntered", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VisibleDate", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsItemRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "NewsItems", resetFKFields, new int[] { (int)NewsItemFieldIndex.UserId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsItemRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _newsCategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncNewsCategory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _newsCategory, new PropertyChangedEventHandler( OnNewsCategoryPropertyChanged ), "NewsCategory", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsItemRelations.NewsCategoryEntityUsingNewsCategoryIdStatic, true, signalRelatedEntity, "NewsItems", resetFKFields, new int[] { (int)NewsItemFieldIndex.NewsCategoryId } );
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
				this.PerformSetupSyncRelatedEntity( _newsCategory, new PropertyChangedEventHandler( OnNewsCategoryPropertyChanged ), "NewsCategory", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsItemRelations.NewsCategoryEntityUsingNewsCategoryIdStatic, true, new string[] {  } );
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

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this NewsItemEntity</param>
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
		public  static NewsItemRelations Relations
		{
			get	{ return new NewsItemRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsFile' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsFiles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsFileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsFileEntityFactory))), (IEntityRelation)GetRelationsForField("NewsFiles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsFileEntity, 0, null, null, null, null, "NewsFiles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsItemLocalization' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsItemLocalizations
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsItemLocalizationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsItemLocalizationEntityFactory))), (IEntityRelation)GetRelationsForField("NewsItemLocalizations")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemLocalizationEntity, 0, null, null, null, null, "NewsItemLocalizations", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsPublishQueue' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsPublishQueues
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsPublishQueueEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsPublishQueueEntityFactory))), (IEntityRelation)GetRelationsForField("NewsPublishQueues")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsPublishQueueEntity, 0, null, null, null, null, "NewsPublishQueues", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationships
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationships")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationships", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsCategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsCategory
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryEntityFactory))),	(IEntityRelation)GetRelationsForField("NewsCategory")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, 0, null, null, null, null, "NewsCategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)NewsItemFieldIndex.Id, true); }
			set	{ SetValue((int)NewsItemFieldIndex.Id, value); }
		}

		/// <summary> The NewsCategoryId property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."NewsCategoryId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid NewsCategoryId
		{
			get { return (System.Guid)GetValue((int)NewsItemFieldIndex.NewsCategoryId, true); }
			set	{ SetValue((int)NewsItemFieldIndex.NewsCategoryId, value); }
		}

		/// <summary> The UserId property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid UserId
		{
			get { return (System.Guid)GetValue((int)NewsItemFieldIndex.UserId, true); }
			set	{ SetValue((int)NewsItemFieldIndex.UserId, value); }
		}

		/// <summary> The ShowOnHomePage property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ShowOnHomePage"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ShowOnHomePage
		{
			get { return (System.Boolean)GetValue((int)NewsItemFieldIndex.ShowOnHomePage, true); }
			set	{ SetValue((int)NewsItemFieldIndex.ShowOnHomePage, value); }
		}

		/// <summary> The Revision property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."Revision"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Revision
		{
			get { return (System.Int32)GetValue((int)NewsItemFieldIndex.Revision, true); }
			set	{ SetValue((int)NewsItemFieldIndex.Revision, value); }
		}

		/// <summary> The ShowTitle property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ShowTitle"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ShowTitle
		{
			get { return (System.Boolean)GetValue((int)NewsItemFieldIndex.ShowTitle, true); }
			set	{ SetValue((int)NewsItemFieldIndex.ShowTitle, value); }
		}

		/// <summary> The ShowShortContent property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ShowShortContent"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ShowShortContent
		{
			get { return (System.Boolean)GetValue((int)NewsItemFieldIndex.ShowShortContent, true); }
			set	{ SetValue((int)NewsItemFieldIndex.ShowShortContent, value); }
		}

		/// <summary> The ShowCategoryTitle property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ShowCategoryTitle"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ShowCategoryTitle
		{
			get { return (System.Boolean)GetValue((int)NewsItemFieldIndex.ShowCategoryTitle, true); }
			set	{ SetValue((int)NewsItemFieldIndex.ShowCategoryTitle, value); }
		}

		/// <summary> The ShowCategoryTitleAsLink property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ShowCategoryTitleAsLink"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ShowCategoryTitleAsLink
		{
			get { return (System.Boolean)GetValue((int)NewsItemFieldIndex.ShowCategoryTitleAsLink, true); }
			set	{ SetValue((int)NewsItemFieldIndex.ShowCategoryTitleAsLink, value); }
		}

		/// <summary> The ShowFullCategoryPath property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ShowFullCategoryPath"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ShowFullCategoryPath
		{
			get { return (System.Boolean)GetValue((int)NewsItemFieldIndex.ShowFullCategoryPath, true); }
			set	{ SetValue((int)NewsItemFieldIndex.ShowFullCategoryPath, value); }
		}

		/// <summary> The ShowUserName property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ShowUserName"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ShowUserName
		{
			get { return (System.Boolean)GetValue((int)NewsItemFieldIndex.ShowUserName, true); }
			set	{ SetValue((int)NewsItemFieldIndex.ShowUserName, value); }
		}

		/// <summary> The ShowDateEntered property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ShowDateEntered"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ShowDateEntered
		{
			get { return (System.Boolean)GetValue((int)NewsItemFieldIndex.ShowDateEntered, true); }
			set	{ SetValue((int)NewsItemFieldIndex.ShowDateEntered, value); }
		}

		/// <summary> The ShowDateModified property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ShowDateModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ShowDateModified
		{
			get { return (System.Boolean)GetValue((int)NewsItemFieldIndex.ShowDateModified, true); }
			set	{ SetValue((int)NewsItemFieldIndex.ShowDateModified, value); }
		}

		/// <summary> The ViewCount property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."ViewCount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ViewCount
		{
			get { return (Nullable<System.Int32>)GetValue((int)NewsItemFieldIndex.ViewCount, false); }
			set	{ SetValue((int)NewsItemFieldIndex.ViewCount, value); }
		}

		/// <summary> The DateEntered property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."DateEntered"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateEntered
		{
			get { return (Nullable<System.DateTime>)GetValue((int)NewsItemFieldIndex.DateEntered, false); }
			set	{ SetValue((int)NewsItemFieldIndex.DateEntered, value); }
		}

		/// <summary> The DateModified property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."DateModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)NewsItemFieldIndex.DateModified, false); }
			set	{ SetValue((int)NewsItemFieldIndex.DateModified, value); }
		}

		/// <summary> The VisibleDate property of the Entity NewsItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsItem"."VisibleDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> VisibleDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)NewsItemFieldIndex.VisibleDate, false); }
			set	{ SetValue((int)NewsItemFieldIndex.VisibleDate, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsFileEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsFileEntity))]
		public virtual EntityCollection<NewsFileEntity> NewsFiles
		{
			get { return GetOrCreateEntityCollection<NewsFileEntity, NewsFileEntityFactory>("NewsItem", true, false, ref _newsFiles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsItemLocalizationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsItemLocalizationEntity))]
		public virtual EntityCollection<NewsItemLocalizationEntity> NewsItemLocalizations
		{
			get { return GetOrCreateEntityCollection<NewsItemLocalizationEntity, NewsItemLocalizationEntityFactory>("NewsItem", true, false, ref _newsItemLocalizations);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsPublishQueueEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsPublishQueueEntity))]
		public virtual EntityCollection<NewsPublishQueueEntity> NewsPublishQueues
		{
			get { return GetOrCreateEntityCollection<NewsPublishQueueEntity, NewsPublishQueueEntityFactory>("NewsItem", true, false, ref _newsPublishQueues);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]
		public virtual EntityCollection<SnRelationshipEntity> SnRelationships
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("NewsItem", true, false, ref _snRelationships);	}
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
					SetSingleRelatedEntityNavigator(value, "NewsItems", "AspnetUser", _aspnetUser, true); 
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
					SetSingleRelatedEntityNavigator(value, "NewsItems", "NewsCategory", _newsCategory, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode

        private NewsItemLocalizationEntity _localizedNewsItem;
        /// <summary>
        /// Get or set Localized News item 
        /// Note: You must manually set this property
        /// </summary>
        public NewsItemLocalizationEntity LocalizedNewsItem
        {
            get { return _localizedNewsItem; }
            set { _localizedNewsItem = value; }
        }

        /// <summary>
        /// Localized ItemTitle.
        /// </summary>
        public string Title
        {
            get
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    return this.NewsItemLocalizations[0].Title;
                }
                else return string.Empty;
            }
            set
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    this.NewsItemLocalizations[0].Title = value;
                }
            }
        }              

        /// <summary>
        /// Localized ItemShortContent.
        /// </summary>
        public string ShortContent
        {
            get
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    return this.NewsItemLocalizations[0].ShortContent;
                }
                else return string.Empty;
            }
            set
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    this.NewsItemLocalizations[0].ShortContent = value;
                }
            }
        }

        /// <summary>
        /// Localized ItemContent.
        /// </summary>
        public string Content
        {
            get
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    return this.NewsItemLocalizations[0].Content;
                }
                else return string.Empty;
            }
            set
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    this.NewsItemLocalizations[0].Content = value;
                }
            }
        }

        /// <summary>
        /// Localized ItemPublished.
        /// </summary>
        public bool Published
        {
            get
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    return this.NewsItemLocalizations[0].Published;
                }
                else return false;
            }
            set
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    this.NewsItemLocalizations[0].Published = value;
                }
            }
        }

        /// <summary>
        /// Localized ItemPublishStart.
        /// </summary>
        public DateTime PublishStart
        {
            get
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    return this.NewsItemLocalizations[0].PublishStart;
                }
                return System.Data.SqlTypes.SqlDateTime.MinValue.Value;
            }
            set
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    this.NewsItemLocalizations[0].PublishStart = value;
                }
            }
        }

        /// <summary>
        /// Localized ItemPublishEnd.
        /// </summary>
        public DateTime? PublishEnd
        {
            get
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    return this.NewsItemLocalizations[0].PublishEnd;
                }
                else return null;
            }
            set
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    this.NewsItemLocalizations[0].PublishEnd = value;
                }
            }
        }

        /// <summary>
        /// Localized ItemVisibleDate.
        /// </summary>
        public DateTime? ItemVisibleDate
        {
            get
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    return this.NewsItemLocalizations[0].VisibleDate;
                }
                else return null;
            }
            set
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    this.NewsItemLocalizations[0].VisibleDate = value;
                }
            }
        }

        /// <summary>
        /// Localized ItemMetaDescription.
        /// </summary>
        public string MetaDescription
        {
            get
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    return this.NewsItemLocalizations[0].MetaDescription;
                }
                else return string.Empty;
            }
            set
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    this.NewsItemLocalizations[0].MetaDescription = value;
                }
            }
        }

        /// <summary>
        /// Localized ItemMetaKeywords.
        /// </summary>
        public string MetaKeywords
        {
            get
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    return this.NewsItemLocalizations[0].MetaKeywords;
                }
                else return string.Empty;
            }
            set
            {
                if (this.NewsItemLocalizations != null && this.NewsItemLocalizations.Count > 0)
                {
                    this.NewsItemLocalizations[0].MetaKeywords = value;
                }
            }
        }

		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
