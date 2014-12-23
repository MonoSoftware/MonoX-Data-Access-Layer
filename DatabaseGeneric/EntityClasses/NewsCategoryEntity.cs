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
	/// <summary>Entity class which represents the entity 'NewsCategory'.<br/><br/></summary>
	[Serializable]
	public partial class NewsCategoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<NewsCategoryEntity> _newsCategoryChildrens;
		private EntityCollection<NewsCategoryInRoleEntity> _newsCategoryInRoles;
		private EntityCollection<NewsCategoryLocalizationEntity> _newsCategoryLocalizations;
		private EntityCollection<NewsItemEntity> _newsItems;
		private EntityCollection<SnRelationshipEntity> _snRelationshipss;
		private AspnetApplicationsEntity _aspnetApplications;
		private NewsCategoryEntity _newsCategoryParent;
		private NewsCategoryTemplateEntity _newsCategoryTemplate;

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
			/// <summary>Member name NewsCategoryParent</summary>
			public static readonly string NewsCategoryParent = "NewsCategoryParent";
			/// <summary>Member name NewsCategoryChildrens</summary>
			public static readonly string NewsCategoryChildrens = "NewsCategoryChildrens";
			/// <summary>Member name NewsCategoryInRoles</summary>
			public static readonly string NewsCategoryInRoles = "NewsCategoryInRoles";
			/// <summary>Member name NewsCategoryLocalizations</summary>
			public static readonly string NewsCategoryLocalizations = "NewsCategoryLocalizations";
			/// <summary>Member name NewsItems</summary>
			public static readonly string NewsItems = "NewsItems";
			/// <summary>Member name SnRelationshipss</summary>
			public static readonly string SnRelationshipss = "SnRelationshipss";
			/// <summary>Member name NewsCategoryTemplate</summary>
			public static readonly string NewsCategoryTemplate = "NewsCategoryTemplate";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static NewsCategoryEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public NewsCategoryEntity():base("NewsCategoryEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public NewsCategoryEntity(IEntityFields2 fields):base("NewsCategoryEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this NewsCategoryEntity</param>
		public NewsCategoryEntity(IValidator validator):base("NewsCategoryEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for NewsCategory which data should be fetched into this NewsCategory object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public NewsCategoryEntity(System.Guid id):base("NewsCategoryEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for NewsCategory which data should be fetched into this NewsCategory object</param>
		/// <param name="validator">The custom validator object for this NewsCategoryEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public NewsCategoryEntity(System.Guid id, IValidator validator):base("NewsCategoryEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected NewsCategoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_newsCategoryChildrens = (EntityCollection<NewsCategoryEntity>)info.GetValue("_newsCategoryChildrens", typeof(EntityCollection<NewsCategoryEntity>));
				_newsCategoryInRoles = (EntityCollection<NewsCategoryInRoleEntity>)info.GetValue("_newsCategoryInRoles", typeof(EntityCollection<NewsCategoryInRoleEntity>));
				_newsCategoryLocalizations = (EntityCollection<NewsCategoryLocalizationEntity>)info.GetValue("_newsCategoryLocalizations", typeof(EntityCollection<NewsCategoryLocalizationEntity>));
				_newsItems = (EntityCollection<NewsItemEntity>)info.GetValue("_newsItems", typeof(EntityCollection<NewsItemEntity>));
				_snRelationshipss = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationshipss", typeof(EntityCollection<SnRelationshipEntity>));
				_aspnetApplications = (AspnetApplicationsEntity)info.GetValue("_aspnetApplications", typeof(AspnetApplicationsEntity));
				if(_aspnetApplications!=null)
				{
					_aspnetApplications.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_newsCategoryParent = (NewsCategoryEntity)info.GetValue("_newsCategoryParent", typeof(NewsCategoryEntity));
				if(_newsCategoryParent!=null)
				{
					_newsCategoryParent.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_newsCategoryTemplate = (NewsCategoryTemplateEntity)info.GetValue("_newsCategoryTemplate", typeof(NewsCategoryTemplateEntity));
				if(_newsCategoryTemplate!=null)
				{
					_newsCategoryTemplate.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((NewsCategoryFieldIndex)fieldIndex)
			{
				case NewsCategoryFieldIndex.ApplicationId:
					DesetupSyncAspnetApplications(true, false);
					break;
				case NewsCategoryFieldIndex.NewsCategoryId:
					DesetupSyncNewsCategoryParent(true, false);
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
				case "AspnetApplications":
					this.AspnetApplications = (AspnetApplicationsEntity)entity;
					break;
				case "NewsCategoryParent":
					this.NewsCategoryParent = (NewsCategoryEntity)entity;
					break;
				case "NewsCategoryChildrens":
					this.NewsCategoryChildrens.Add((NewsCategoryEntity)entity);
					break;
				case "NewsCategoryInRoles":
					this.NewsCategoryInRoles.Add((NewsCategoryInRoleEntity)entity);
					break;
				case "NewsCategoryLocalizations":
					this.NewsCategoryLocalizations.Add((NewsCategoryLocalizationEntity)entity);
					break;
				case "NewsItems":
					this.NewsItems.Add((NewsItemEntity)entity);
					break;
				case "SnRelationshipss":
					this.SnRelationshipss.Add((SnRelationshipEntity)entity);
					break;
				case "NewsCategoryTemplate":
					this.NewsCategoryTemplate = (NewsCategoryTemplateEntity)entity;
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
				case "NewsCategoryParent":
					toReturn.Add(Relations.NewsCategoryEntityUsingIdNewsCategoryId);
					break;
				case "NewsCategoryChildrens":
					toReturn.Add(Relations.NewsCategoryEntityUsingNewsCategoryId);
					break;
				case "NewsCategoryInRoles":
					toReturn.Add(Relations.NewsCategoryInRoleEntityUsingNewsCategoryId);
					break;
				case "NewsCategoryLocalizations":
					toReturn.Add(Relations.NewsCategoryLocalizationEntityUsingNewsCategoryId);
					break;
				case "NewsItems":
					toReturn.Add(Relations.NewsItemEntityUsingNewsCategoryId);
					break;
				case "SnRelationshipss":
					toReturn.Add(Relations.SnRelationshipEntityUsingNewsCategoryId);
					break;
				case "NewsCategoryTemplate":
					toReturn.Add(Relations.NewsCategoryTemplateEntityUsingId);
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
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "AspnetApplications":
					SetupSyncAspnetApplications(relatedEntity);
					break;
				case "NewsCategoryParent":
					SetupSyncNewsCategoryParent(relatedEntity);
					break;
				case "NewsCategoryChildrens":
					this.NewsCategoryChildrens.Add((NewsCategoryEntity)relatedEntity);
					break;
				case "NewsCategoryInRoles":
					this.NewsCategoryInRoles.Add((NewsCategoryInRoleEntity)relatedEntity);
					break;
				case "NewsCategoryLocalizations":
					this.NewsCategoryLocalizations.Add((NewsCategoryLocalizationEntity)relatedEntity);
					break;
				case "NewsItems":
					this.NewsItems.Add((NewsItemEntity)relatedEntity);
					break;
				case "SnRelationshipss":
					this.SnRelationshipss.Add((SnRelationshipEntity)relatedEntity);
					break;
				case "NewsCategoryTemplate":
					SetupSyncNewsCategoryTemplate(relatedEntity);
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
				case "AspnetApplications":
					DesetupSyncAspnetApplications(false, true);
					break;
				case "NewsCategoryParent":
					DesetupSyncNewsCategoryParent(false, true);
					break;
				case "NewsCategoryChildrens":
					this.PerformRelatedEntityRemoval(this.NewsCategoryChildrens, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NewsCategoryInRoles":
					this.PerformRelatedEntityRemoval(this.NewsCategoryInRoles, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NewsCategoryLocalizations":
					this.PerformRelatedEntityRemoval(this.NewsCategoryLocalizations, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NewsItems":
					this.PerformRelatedEntityRemoval(this.NewsItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnRelationshipss":
					this.PerformRelatedEntityRemoval(this.SnRelationshipss, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NewsCategoryTemplate":
					DesetupSyncNewsCategoryTemplate(false, true);
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
			if(_newsCategoryTemplate!=null)
			{
				toReturn.Add(_newsCategoryTemplate);
			}

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
			if(_newsCategoryParent!=null)
			{
				toReturn.Add(_newsCategoryParent);
			}


			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.NewsCategoryChildrens);
			toReturn.Add(this.NewsCategoryInRoles);
			toReturn.Add(this.NewsCategoryLocalizations);
			toReturn.Add(this.NewsItems);
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
				info.AddValue("_newsCategoryChildrens", ((_newsCategoryChildrens!=null) && (_newsCategoryChildrens.Count>0) && !this.MarkedForDeletion)?_newsCategoryChildrens:null);
				info.AddValue("_newsCategoryInRoles", ((_newsCategoryInRoles!=null) && (_newsCategoryInRoles.Count>0) && !this.MarkedForDeletion)?_newsCategoryInRoles:null);
				info.AddValue("_newsCategoryLocalizations", ((_newsCategoryLocalizations!=null) && (_newsCategoryLocalizations.Count>0) && !this.MarkedForDeletion)?_newsCategoryLocalizations:null);
				info.AddValue("_newsItems", ((_newsItems!=null) && (_newsItems.Count>0) && !this.MarkedForDeletion)?_newsItems:null);
				info.AddValue("_snRelationshipss", ((_snRelationshipss!=null) && (_snRelationshipss.Count>0) && !this.MarkedForDeletion)?_snRelationshipss:null);
				info.AddValue("_aspnetApplications", (!this.MarkedForDeletion?_aspnetApplications:null));
				info.AddValue("_newsCategoryParent", (!this.MarkedForDeletion?_newsCategoryParent:null));
				info.AddValue("_newsCategoryTemplate", (!this.MarkedForDeletion?_newsCategoryTemplate:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new NewsCategoryRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsCategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsCategoryChildrens()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsCategoryFields.NewsCategoryId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsCategoryInRole' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsCategoryInRoles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsCategoryInRoleFields.NewsCategoryId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsCategoryLocalization' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsCategoryLocalizations()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsCategoryLocalizationFields.NewsCategoryId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsItem' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsItems()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsItemFields.NewsCategoryId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationshipss()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.NewsCategoryId, null, ComparisonOperator.Equal, this.Id));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'NewsCategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsCategoryParent()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsCategoryFields.Id, null, ComparisonOperator.Equal, this.NewsCategoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'NewsCategoryTemplate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsCategoryTemplate()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsCategoryTemplateFields.Id, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._newsCategoryChildrens);
			collectionsQueue.Enqueue(this._newsCategoryInRoles);
			collectionsQueue.Enqueue(this._newsCategoryLocalizations);
			collectionsQueue.Enqueue(this._newsItems);
			collectionsQueue.Enqueue(this._snRelationshipss);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._newsCategoryChildrens = (EntityCollection<NewsCategoryEntity>) collectionsQueue.Dequeue();
			this._newsCategoryInRoles = (EntityCollection<NewsCategoryInRoleEntity>) collectionsQueue.Dequeue();
			this._newsCategoryLocalizations = (EntityCollection<NewsCategoryLocalizationEntity>) collectionsQueue.Dequeue();
			this._newsItems = (EntityCollection<NewsItemEntity>) collectionsQueue.Dequeue();
			this._snRelationshipss = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._newsCategoryChildrens != null);
			toReturn |=(this._newsCategoryInRoles != null);
			toReturn |=(this._newsCategoryLocalizations != null);
			toReturn |=(this._newsItems != null);
			toReturn |=(this._snRelationshipss != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsCategoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsCategoryInRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryInRoleEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsCategoryLocalizationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryLocalizationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsItemEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsItemEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetApplications", _aspnetApplications);
			toReturn.Add("NewsCategoryParent", _newsCategoryParent);
			toReturn.Add("NewsCategoryChildrens", _newsCategoryChildrens);
			toReturn.Add("NewsCategoryInRoles", _newsCategoryInRoles);
			toReturn.Add("NewsCategoryLocalizations", _newsCategoryLocalizations);
			toReturn.Add("NewsItems", _newsItems);
			toReturn.Add("SnRelationshipss", _snRelationshipss);
			toReturn.Add("NewsCategoryTemplate", _newsCategoryTemplate);
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
			_fieldsCustomProperties.Add("NewsCategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Image", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Order", fieldHashtable);
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
			this.PerformDesetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsCategoryRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)NewsCategoryFieldIndex.ApplicationId } );
			_aspnetApplications = null;
		}

		/// <summary> setups the sync logic for member _aspnetApplications</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetApplications(IEntityCore relatedEntity)
		{
			if(_aspnetApplications!=relatedEntity)
			{
				DesetupSyncAspnetApplications(true, true);
				_aspnetApplications = (AspnetApplicationsEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsCategoryRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _newsCategoryParent</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncNewsCategoryParent(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _newsCategoryParent, new PropertyChangedEventHandler( OnNewsCategoryParentPropertyChanged ), "NewsCategoryParent", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsCategoryRelations.NewsCategoryEntityUsingIdNewsCategoryIdStatic, true, signalRelatedEntity, "NewsCategoryChildrens", resetFKFields, new int[] { (int)NewsCategoryFieldIndex.NewsCategoryId } );
			_newsCategoryParent = null;
		}

		/// <summary> setups the sync logic for member _newsCategoryParent</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncNewsCategoryParent(IEntityCore relatedEntity)
		{
			if(_newsCategoryParent!=relatedEntity)
			{
				DesetupSyncNewsCategoryParent(true, true);
				_newsCategoryParent = (NewsCategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _newsCategoryParent, new PropertyChangedEventHandler( OnNewsCategoryParentPropertyChanged ), "NewsCategoryParent", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsCategoryRelations.NewsCategoryEntityUsingIdNewsCategoryIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnNewsCategoryParentPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _newsCategoryTemplate</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncNewsCategoryTemplate(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _newsCategoryTemplate, new PropertyChangedEventHandler( OnNewsCategoryTemplatePropertyChanged ), "NewsCategoryTemplate", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsCategoryRelations.NewsCategoryTemplateEntityUsingIdStatic, false, signalRelatedEntity, "NewsCategory", false, new int[] { (int)NewsCategoryFieldIndex.Id } );
			_newsCategoryTemplate = null;
		}
		
		/// <summary> setups the sync logic for member _newsCategoryTemplate</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncNewsCategoryTemplate(IEntityCore relatedEntity)
		{
			if(_newsCategoryTemplate!=relatedEntity)
			{
				DesetupSyncNewsCategoryTemplate(true, true);
				_newsCategoryTemplate = (NewsCategoryTemplateEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _newsCategoryTemplate, new PropertyChangedEventHandler( OnNewsCategoryTemplatePropertyChanged ), "NewsCategoryTemplate", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsCategoryRelations.NewsCategoryTemplateEntityUsingIdStatic, false, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnNewsCategoryTemplatePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this NewsCategoryEntity</param>
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
		public  static NewsCategoryRelations Relations
		{
			get	{ return new NewsCategoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsCategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsCategoryChildrens
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsCategoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryEntityFactory))), (IEntityRelation)GetRelationsForField("NewsCategoryChildrens")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, 0, null, null, null, null, "NewsCategoryChildrens", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsCategoryInRole' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsCategoryInRoles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsCategoryInRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryInRoleEntityFactory))), (IEntityRelation)GetRelationsForField("NewsCategoryInRoles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryInRoleEntity, 0, null, null, null, null, "NewsCategoryInRoles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsCategoryLocalization' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsCategoryLocalizations
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsCategoryLocalizationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryLocalizationEntityFactory))), (IEntityRelation)GetRelationsForField("NewsCategoryLocalizations")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryLocalizationEntity, 0, null, null, null, null, "NewsCategoryLocalizations", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsItems
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsItemEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsItemEntityFactory))), (IEntityRelation)GetRelationsForField("NewsItems")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, 0, null, null, null, null, "NewsItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationshipss
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationshipss")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationshipss", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetApplications' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetApplications
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetApplicationsEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetApplications")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, 0, null, null, null, null, "AspnetApplications", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsCategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsCategoryParent
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryEntityFactory))),	(IEntityRelation)GetRelationsForField("NewsCategoryParent")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, 0, null, null, null, null, "NewsCategoryParent", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsCategoryTemplate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsCategoryTemplate
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(NewsCategoryTemplateEntityFactory))), (IEntityRelation)GetRelationsForField("NewsCategoryTemplate")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryTemplateEntity, 0, null, null, null, null, "NewsCategoryTemplate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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

		/// <summary> The Id property of the Entity NewsCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsCategory"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>		
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)NewsCategoryFieldIndex.Id, true); }
			set	{ SetValue((int)NewsCategoryFieldIndex.Id, value); }
		}

		/// <summary> The ApplicationId property of the Entity NewsCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsCategory"."ApplicationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid ApplicationId
		{
			get { return (System.Guid)GetValue((int)NewsCategoryFieldIndex.ApplicationId, true); }
			set	{ SetValue((int)NewsCategoryFieldIndex.ApplicationId, value); }
		}

		/// <summary> The NewsCategoryId property of the Entity NewsCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsCategory"."NewsCategoryId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> NewsCategoryId
		{
			get { return (Nullable<System.Guid>)GetValue((int)NewsCategoryFieldIndex.NewsCategoryId, false); }
			set	{ SetValue((int)NewsCategoryFieldIndex.NewsCategoryId, value); }
		}

		/// <summary> The Image property of the Entity NewsCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsCategory"."Image"<br/>
		/// Table field type characteristics (type, precision, scale, length): Image, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.Byte[] Image
		{
			get { return (System.Byte[])GetValue((int)NewsCategoryFieldIndex.Image, true); }
			set	{ SetValue((int)NewsCategoryFieldIndex.Image, value); }
		}

		/// <summary> The Order property of the Entity NewsCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsCategory"."Order"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Int32 Order
		{
			get { return (System.Int32)GetValue((int)NewsCategoryFieldIndex.Order, true); }
			set	{ SetValue((int)NewsCategoryFieldIndex.Order, value); }
		}

		/// <summary> The DateEntered property of the Entity NewsCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsCategory"."DateEntered"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.DateTime> DateEntered
		{
			get { return (Nullable<System.DateTime>)GetValue((int)NewsCategoryFieldIndex.DateEntered, false); }
			set	{ SetValue((int)NewsCategoryFieldIndex.DateEntered, value); }
		}

		/// <summary> The DateModified property of the Entity NewsCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "NewsCategory"."DateModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.DateTime> DateModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)NewsCategoryFieldIndex.DateModified, false); }
			set	{ SetValue((int)NewsCategoryFieldIndex.DateModified, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsCategoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsCategoryEntity))]		
		public virtual EntityCollection<NewsCategoryEntity> NewsCategoryChildrens
		{
			get { return GetOrCreateEntityCollection<NewsCategoryEntity, NewsCategoryEntityFactory>("NewsCategoryParent", true, false, ref _newsCategoryChildrens);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsCategoryInRoleEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsCategoryInRoleEntity))]		
		public virtual EntityCollection<NewsCategoryInRoleEntity> NewsCategoryInRoles
		{
			get { return GetOrCreateEntityCollection<NewsCategoryInRoleEntity, NewsCategoryInRoleEntityFactory>("NewsCategory", true, false, ref _newsCategoryInRoles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsCategoryLocalizationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsCategoryLocalizationEntity))]		
		public virtual EntityCollection<NewsCategoryLocalizationEntity> NewsCategoryLocalizations
		{
			get { return GetOrCreateEntityCollection<NewsCategoryLocalizationEntity, NewsCategoryLocalizationEntityFactory>("NewsCategory", true, false, ref _newsCategoryLocalizations);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsItemEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsItemEntity))]		
		public virtual EntityCollection<NewsItemEntity> NewsItems
		{
			get { return GetOrCreateEntityCollection<NewsItemEntity, NewsItemEntityFactory>("NewsCategory", true, false, ref _newsItems);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]		
		public virtual EntityCollection<SnRelationshipEntity> SnRelationshipss
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("NewsCategory", true, false, ref _snRelationshipss);	}
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

		/// <summary> Gets / sets related entity of type 'NewsCategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual NewsCategoryEntity NewsCategoryParent
		{
			get	{ return _newsCategoryParent; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncNewsCategoryParent(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "NewsCategoryChildrens", "NewsCategoryParent", _newsCategoryParent, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'NewsCategoryTemplateEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(true)]		
		public virtual NewsCategoryTemplateEntity NewsCategoryTemplate
		{
			get { return _newsCategoryTemplate; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncNewsCategoryTemplate(value);
					CallSetRelatedEntityDuringDeserialization(value, "NewsCategory");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_newsCategoryTemplate !=null);
						DesetupSyncNewsCategoryTemplate(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("NewsCategoryTemplate");
						}
					}
					else
					{
						if(_newsCategoryTemplate!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "NewsCategory");
							SetupSyncNewsCategoryTemplate(value);
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity; }
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
