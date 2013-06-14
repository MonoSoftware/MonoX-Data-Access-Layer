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
    using System.Linq;
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Navigation'.<br/><br/></summary>
	[Serializable]
	public partial class NavigationEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<NavigationEntity> _childNavigationItems;
		private EntityCollection<NavigationLocalizationEntity> _navigationLocalizations;
		private EntityCollection<NavigationRoleEntity> _navigationRoles;
		private AspnetApplicationsEntity _aspnetApplication;
		private NavigationEntity _parentNavigationItem;
		private PageEntity _page;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AspnetApplication</summary>
			public static readonly string AspnetApplication = "AspnetApplication";
			/// <summary>Member name ParentNavigationItem</summary>
			public static readonly string ParentNavigationItem = "ParentNavigationItem";
			/// <summary>Member name Page</summary>
			public static readonly string Page = "Page";
			/// <summary>Member name ChildNavigationItems</summary>
			public static readonly string ChildNavigationItems = "ChildNavigationItems";
			/// <summary>Member name NavigationLocalizations</summary>
			public static readonly string NavigationLocalizations = "NavigationLocalizations";
			/// <summary>Member name NavigationRoles</summary>
			public static readonly string NavigationRoles = "NavigationRoles";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static NavigationEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public NavigationEntity():base("NavigationEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public NavigationEntity(IEntityFields2 fields):base("NavigationEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this NavigationEntity</param>
		public NavigationEntity(IValidator validator):base("NavigationEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for Navigation which data should be fetched into this Navigation object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public NavigationEntity(System.Guid id):base("NavigationEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Navigation which data should be fetched into this Navigation object</param>
		/// <param name="validator">The custom validator object for this NavigationEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public NavigationEntity(System.Guid id, IValidator validator):base("NavigationEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected NavigationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_childNavigationItems = (EntityCollection<NavigationEntity>)info.GetValue("_childNavigationItems", typeof(EntityCollection<NavigationEntity>));
				_navigationLocalizations = (EntityCollection<NavigationLocalizationEntity>)info.GetValue("_navigationLocalizations", typeof(EntityCollection<NavigationLocalizationEntity>));
				_navigationRoles = (EntityCollection<NavigationRoleEntity>)info.GetValue("_navigationRoles", typeof(EntityCollection<NavigationRoleEntity>));
				_aspnetApplication = (AspnetApplicationsEntity)info.GetValue("_aspnetApplication", typeof(AspnetApplicationsEntity));
				if(_aspnetApplication!=null)
				{
					_aspnetApplication.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_parentNavigationItem = (NavigationEntity)info.GetValue("_parentNavigationItem", typeof(NavigationEntity));
				if(_parentNavigationItem!=null)
				{
					_parentNavigationItem.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_page = (PageEntity)info.GetValue("_page", typeof(PageEntity));
				if(_page!=null)
				{
					_page.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((NavigationFieldIndex)fieldIndex)
			{
				case NavigationFieldIndex.PageId:
					DesetupSyncPage(true, false);
					break;
				case NavigationFieldIndex.ApplicationId:
					DesetupSyncAspnetApplication(true, false);
					break;
				case NavigationFieldIndex.ParentId:
					DesetupSyncParentNavigationItem(true, false);
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
				case "AspnetApplication":
					this.AspnetApplication = (AspnetApplicationsEntity)entity;
					break;
				case "ParentNavigationItem":
					this.ParentNavigationItem = (NavigationEntity)entity;
					break;
				case "Page":
					this.Page = (PageEntity)entity;
					break;
				case "ChildNavigationItems":
					this.ChildNavigationItems.Add((NavigationEntity)entity);
					break;
				case "NavigationLocalizations":
					this.NavigationLocalizations.Add((NavigationLocalizationEntity)entity);
					break;
				case "NavigationRoles":
					this.NavigationRoles.Add((NavigationRoleEntity)entity);
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
				case "AspnetApplication":
					toReturn.Add(Relations.AspnetApplicationsEntityUsingApplicationId);
					break;
				case "ParentNavigationItem":
					toReturn.Add(Relations.NavigationEntityUsingIdParentId);
					break;
				case "Page":
					toReturn.Add(Relations.PageEntityUsingPageId);
					break;
				case "ChildNavigationItems":
					toReturn.Add(Relations.NavigationEntityUsingParentId);
					break;
				case "NavigationLocalizations":
					toReturn.Add(Relations.NavigationLocalizationEntityUsingNavigationId);
					break;
				case "NavigationRoles":
					toReturn.Add(Relations.NavigationRoleEntityUsingNavigationId);
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
				case "AspnetApplication":
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
				case "AspnetApplication":
					SetupSyncAspnetApplication(relatedEntity);
					break;
				case "ParentNavigationItem":
					SetupSyncParentNavigationItem(relatedEntity);
					break;
				case "Page":
					SetupSyncPage(relatedEntity);
					break;
				case "ChildNavigationItems":
					this.ChildNavigationItems.Add((NavigationEntity)relatedEntity);
					break;
				case "NavigationLocalizations":
					this.NavigationLocalizations.Add((NavigationLocalizationEntity)relatedEntity);
					break;
				case "NavigationRoles":
					this.NavigationRoles.Add((NavigationRoleEntity)relatedEntity);
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
				case "AspnetApplication":
					DesetupSyncAspnetApplication(false, true);
					break;
				case "ParentNavigationItem":
					DesetupSyncParentNavigationItem(false, true);
					break;
				case "Page":
					DesetupSyncPage(false, true);
					break;
				case "ChildNavigationItems":
					this.PerformRelatedEntityRemoval(this.ChildNavigationItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NavigationLocalizations":
					this.PerformRelatedEntityRemoval(this.NavigationLocalizations, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NavigationRoles":
					this.PerformRelatedEntityRemoval(this.NavigationRoles, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_aspnetApplication!=null)
			{
				toReturn.Add(_aspnetApplication);
			}
			if(_parentNavigationItem!=null)
			{
				toReturn.Add(_parentNavigationItem);
			}
			if(_page!=null)
			{
				toReturn.Add(_page);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.ChildNavigationItems);
			toReturn.Add(this.NavigationLocalizations);
			toReturn.Add(this.NavigationRoles);
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
				info.AddValue("_childNavigationItems", ((_childNavigationItems!=null) && (_childNavigationItems.Count>0) && !this.MarkedForDeletion)?_childNavigationItems:null);
				info.AddValue("_navigationLocalizations", ((_navigationLocalizations!=null) && (_navigationLocalizations.Count>0) && !this.MarkedForDeletion)?_navigationLocalizations:null);
				info.AddValue("_navigationRoles", ((_navigationRoles!=null) && (_navigationRoles.Count>0) && !this.MarkedForDeletion)?_navigationRoles:null);
				info.AddValue("_aspnetApplication", (!this.MarkedForDeletion?_aspnetApplication:null));
				info.AddValue("_parentNavigationItem", (!this.MarkedForDeletion?_parentNavigationItem:null));
				info.AddValue("_page", (!this.MarkedForDeletion?_page:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new NavigationRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Navigation' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoChildNavigationItems()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NavigationFields.ParentId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NavigationLocalization' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNavigationLocalizations()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NavigationLocalizationFields.NavigationId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NavigationRole' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNavigationRoles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NavigationRoleFields.NavigationId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetApplications' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetApplication()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetApplicationsFields.ApplicationId, null, ComparisonOperator.Equal, this.ApplicationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Navigation' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoParentNavigationItem()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NavigationFields.Id, null, ComparisonOperator.Equal, this.ParentId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Page' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPage()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PageFields.Id, null, ComparisonOperator.Equal, this.PageId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(NavigationEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._childNavigationItems);
			collectionsQueue.Enqueue(this._navigationLocalizations);
			collectionsQueue.Enqueue(this._navigationRoles);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._childNavigationItems = (EntityCollection<NavigationEntity>) collectionsQueue.Dequeue();
			this._navigationLocalizations = (EntityCollection<NavigationLocalizationEntity>) collectionsQueue.Dequeue();
			this._navigationRoles = (EntityCollection<NavigationRoleEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._childNavigationItems != null);
			toReturn |=(this._navigationLocalizations != null);
			toReturn |=(this._navigationRoles != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NavigationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NavigationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NavigationLocalizationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NavigationLocalizationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NavigationRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NavigationRoleEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetApplication", _aspnetApplication);
			toReturn.Add("ParentNavigationItem", _parentNavigationItem);
			toReturn.Add("Page", _page);
			toReturn.Add("ChildNavigationItems", _childNavigationItems);
			toReturn.Add("NavigationLocalizations", _navigationLocalizations);
			toReturn.Add("NavigationRoles", _navigationRoles);
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
			_fieldsCustomProperties.Add("PageId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ApplicationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ExternalUrl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsContainerPage", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ParentId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PageOrder", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetApplication</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetApplication(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetApplication, new PropertyChangedEventHandler( OnAspnetApplicationPropertyChanged ), "AspnetApplication", MonoSoftware.MonoX.DAL.RelationClasses.StaticNavigationRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)NavigationFieldIndex.ApplicationId } );
			_aspnetApplication = null;
		}

		/// <summary> setups the sync logic for member _aspnetApplication</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetApplication(IEntity2 relatedEntity)
		{
			if(_aspnetApplication!=relatedEntity)
			{
				DesetupSyncAspnetApplication(true, true);
				_aspnetApplication = (AspnetApplicationsEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetApplication, new PropertyChangedEventHandler( OnAspnetApplicationPropertyChanged ), "AspnetApplication", MonoSoftware.MonoX.DAL.RelationClasses.StaticNavigationRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAspnetApplicationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _parentNavigationItem</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncParentNavigationItem(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _parentNavigationItem, new PropertyChangedEventHandler( OnParentNavigationItemPropertyChanged ), "ParentNavigationItem", MonoSoftware.MonoX.DAL.RelationClasses.StaticNavigationRelations.NavigationEntityUsingIdParentIdStatic, true, signalRelatedEntity, "ChildNavigationItems", resetFKFields, new int[] { (int)NavigationFieldIndex.ParentId } );
			_parentNavigationItem = null;
		}

		/// <summary> setups the sync logic for member _parentNavigationItem</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncParentNavigationItem(IEntity2 relatedEntity)
		{
			if(_parentNavigationItem!=relatedEntity)
			{
				DesetupSyncParentNavigationItem(true, true);
				_parentNavigationItem = (NavigationEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _parentNavigationItem, new PropertyChangedEventHandler( OnParentNavigationItemPropertyChanged ), "ParentNavigationItem", MonoSoftware.MonoX.DAL.RelationClasses.StaticNavigationRelations.NavigationEntityUsingIdParentIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnParentNavigationItemPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _page</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPage(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _page, new PropertyChangedEventHandler( OnPagePropertyChanged ), "Page", MonoSoftware.MonoX.DAL.RelationClasses.StaticNavigationRelations.PageEntityUsingPageIdStatic, true, signalRelatedEntity, "NavigationItems", resetFKFields, new int[] { (int)NavigationFieldIndex.PageId } );
			_page = null;
		}

		/// <summary> setups the sync logic for member _page</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPage(IEntity2 relatedEntity)
		{
			if(_page!=relatedEntity)
			{
				DesetupSyncPage(true, true);
				_page = (PageEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _page, new PropertyChangedEventHandler( OnPagePropertyChanged ), "Page", MonoSoftware.MonoX.DAL.RelationClasses.StaticNavigationRelations.PageEntityUsingPageIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPagePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this NavigationEntity</param>
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
		public  static NavigationRelations Relations
		{
			get	{ return new NavigationRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Navigation' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathChildNavigationItems
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NavigationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NavigationEntityFactory))), (IEntityRelation)GetRelationsForField("ChildNavigationItems")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, 0, null, null, null, null, "ChildNavigationItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NavigationLocalization' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNavigationLocalizations
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NavigationLocalizationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NavigationLocalizationEntityFactory))), (IEntityRelation)GetRelationsForField("NavigationLocalizations")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NavigationLocalizationEntity, 0, null, null, null, null, "NavigationLocalizations", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NavigationRole' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNavigationRoles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NavigationRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NavigationRoleEntityFactory))), (IEntityRelation)GetRelationsForField("NavigationRoles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NavigationRoleEntity, 0, null, null, null, null, "NavigationRoles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetApplications' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetApplication
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetApplicationsEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetApplication")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, 0, null, null, null, null, "AspnetApplication", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Navigation' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathParentNavigationItem
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(NavigationEntityFactory))),	(IEntityRelation)GetRelationsForField("ParentNavigationItem")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, 0, null, null, null, null, "ParentNavigationItem", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Page' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPage
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PageEntityFactory))),	(IEntityRelation)GetRelationsForField("Page")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, 0, null, null, null, null, "Page", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity Navigation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Navigation"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)NavigationFieldIndex.Id, true); }
			set	{ SetValue((int)NavigationFieldIndex.Id, value); }
		}

		/// <summary> The PageId property of the Entity Navigation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Navigation"."PageId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> PageId
		{
			get { return (Nullable<System.Guid>)GetValue((int)NavigationFieldIndex.PageId, false); }
			set	{ SetValue((int)NavigationFieldIndex.PageId, value); }
		}

		/// <summary> The ApplicationId property of the Entity Navigation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Navigation"."ApplicationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid ApplicationId
		{
			get { return (System.Guid)GetValue((int)NavigationFieldIndex.ApplicationId, true); }
			set	{ SetValue((int)NavigationFieldIndex.ApplicationId, value); }
		}

		/// <summary> The ExternalUrl property of the Entity Navigation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Navigation"."ExternalUrl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ExternalUrl
		{
			get { return (System.String)GetValue((int)NavigationFieldIndex.ExternalUrl, true); }
			set	{ SetValue((int)NavigationFieldIndex.ExternalUrl, value); }
		}

		/// <summary> The IsContainerPage property of the Entity Navigation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Navigation"."IsContainerPage"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsContainerPage
		{
			get { return (System.Boolean)GetValue((int)NavigationFieldIndex.IsContainerPage, true); }
			set	{ SetValue((int)NavigationFieldIndex.IsContainerPage, value); }
		}

		/// <summary> The ParentId property of the Entity Navigation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Navigation"."ParentId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> ParentId
		{
			get { return (Nullable<System.Guid>)GetValue((int)NavigationFieldIndex.ParentId, false); }
			set	{ SetValue((int)NavigationFieldIndex.ParentId, value); }
		}

		/// <summary> The PageOrder property of the Entity Navigation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Navigation"."PageOrder"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 PageOrder
		{
			get { return (System.Int32)GetValue((int)NavigationFieldIndex.PageOrder, true); }
			set	{ SetValue((int)NavigationFieldIndex.PageOrder, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NavigationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NavigationEntity))]
		public virtual EntityCollection<NavigationEntity> ChildNavigationItems
		{
			get { return GetOrCreateEntityCollection<NavigationEntity, NavigationEntityFactory>("ParentNavigationItem", true, false, ref _childNavigationItems);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NavigationLocalizationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NavigationLocalizationEntity))]
		public virtual EntityCollection<NavigationLocalizationEntity> NavigationLocalizations
		{
			get { return GetOrCreateEntityCollection<NavigationLocalizationEntity, NavigationLocalizationEntityFactory>("Navigation", true, false, ref _navigationLocalizations);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NavigationRoleEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NavigationRoleEntity))]
		public virtual EntityCollection<NavigationRoleEntity> NavigationRoles
		{
			get { return GetOrCreateEntityCollection<NavigationRoleEntity, NavigationRoleEntityFactory>("Navigation", true, false, ref _navigationRoles);	}
		}

		/// <summary> Gets / sets related entity of type 'AspnetApplicationsEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual AspnetApplicationsEntity AspnetApplication
		{
			get	{ return _aspnetApplication; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAspnetApplication(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "", "AspnetApplication", _aspnetApplication, false); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'NavigationEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual NavigationEntity ParentNavigationItem
		{
			get	{ return _parentNavigationItem; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncParentNavigationItem(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ChildNavigationItems", "ParentNavigationItem", _parentNavigationItem, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'PageEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual PageEntity Page
		{
			get	{ return _page; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPage(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "NavigationItems", "Page", _page, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode

        public bool LocalizationExists()
        {
            return (this.NavigationLocalizations.Count > 0 && this.NavigationLocalizations[0] != null);
        }

        public bool LocalizationExists(Guid languageId)
        {
            foreach (NavigationLocalizationEntity localization in this.NavigationLocalizations)
            {
                if (localization.LanguageId == languageId)
                    return true;
            }
            return false;
        }

        public NavigationLocalizationEntity LocalizedNavigation
        {
            get
            {
                if (LocalizationExists())
                    return (this.NavigationLocalizations[0]);
                else
                    return null;
            }
        }

        public string LocalizedTitle
        {
            get
            {
                if (LocalizationExists())
                    return LocalizedNavigation.Title;
                else
                    return string.Empty;
            }
            set
            {
                if (LocalizationExists())
                    LocalizedNavigation.Title = value;
            }
        }

        public Guid[] NavigationRoleIds
        {
            get 
            {
                if (this.NavigationRoles != null && this.NavigationRoles.Count > 0)
                {
                    Guid[] toReturn = new Guid[this.NavigationRoles.Count];
                    int i = 0;
                    foreach (NavigationRoleEntity role in this.NavigationRoles)
                    {
                        toReturn[i] = role.RoleId;
                        i++;
                    }
                    return toReturn;
                }
                else
                    return null;
            }
        }


        public void SetLocalizedTitle(Guid languageId, string value)
        {
            NavigationLocalizationEntity entity = this.NavigationLocalizations.Where(p => p.LanguageId.Equals(languageId)).FirstOrDefault();
            if (entity != null)
            {
                entity.Title = value;
            }            
        }

		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
