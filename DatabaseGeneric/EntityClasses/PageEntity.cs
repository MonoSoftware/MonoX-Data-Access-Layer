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
	/// <summary>Entity class which represents the entity 'Page'.<br/><br/></summary>
	[Serializable]
	public partial class PageEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<AdPageEntity> _adPage;
		private EntityCollection<DocumentEntity> _documents;
		private EntityCollection<NavigationEntity> _navigationItems;
		private EntityCollection<PageEditRoleEntity> _pageEditRoles;
		private EntityCollection<PageLocalizationEntity> _pageLocalizations;
		private EntityCollection<PageRoleEntity> _pageRoles;
		private EntityCollection<SnRelationshipEntity> _snRelationshipss;
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
			/// <summary>Member name AdPage</summary>
			public static readonly string AdPage = "AdPage";
			/// <summary>Member name Documents</summary>
			public static readonly string Documents = "Documents";
			/// <summary>Member name NavigationItems</summary>
			public static readonly string NavigationItems = "NavigationItems";
			/// <summary>Member name PageEditRoles</summary>
			public static readonly string PageEditRoles = "PageEditRoles";
			/// <summary>Member name PageLocalizations</summary>
			public static readonly string PageLocalizations = "PageLocalizations";
			/// <summary>Member name PageRoles</summary>
			public static readonly string PageRoles = "PageRoles";
			/// <summary>Member name SnRelationshipss</summary>
			public static readonly string SnRelationshipss = "SnRelationshipss";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PageEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public PageEntity():base("PageEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PageEntity(IEntityFields2 fields):base("PageEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PageEntity</param>
		public PageEntity(IValidator validator):base("PageEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for Page which data should be fetched into this Page object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PageEntity(System.Guid id):base("PageEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Page which data should be fetched into this Page object</param>
		/// <param name="validator">The custom validator object for this PageEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PageEntity(System.Guid id, IValidator validator):base("PageEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PageEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_adPage = (EntityCollection<AdPageEntity>)info.GetValue("_adPage", typeof(EntityCollection<AdPageEntity>));
				_documents = (EntityCollection<DocumentEntity>)info.GetValue("_documents", typeof(EntityCollection<DocumentEntity>));
				_navigationItems = (EntityCollection<NavigationEntity>)info.GetValue("_navigationItems", typeof(EntityCollection<NavigationEntity>));
				_pageEditRoles = (EntityCollection<PageEditRoleEntity>)info.GetValue("_pageEditRoles", typeof(EntityCollection<PageEditRoleEntity>));
				_pageLocalizations = (EntityCollection<PageLocalizationEntity>)info.GetValue("_pageLocalizations", typeof(EntityCollection<PageLocalizationEntity>));
				_pageRoles = (EntityCollection<PageRoleEntity>)info.GetValue("_pageRoles", typeof(EntityCollection<PageRoleEntity>));
				_snRelationshipss = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationshipss", typeof(EntityCollection<SnRelationshipEntity>));
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
			switch((PageFieldIndex)fieldIndex)
			{
				case PageFieldIndex.ApplicationId:
					DesetupSyncAspnetApplications(true, false);
					break;
				case PageFieldIndex.UserId:
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
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "AspnetApplications":
					this.AspnetApplications = (AspnetApplicationsEntity)entity;
					break;
				case "AspnetUsers":
					this.AspnetUsers = (AspnetUsersEntity)entity;
					break;
				case "AdPage":
					this.AdPage.Add((AdPageEntity)entity);
					break;
				case "Documents":
					this.Documents.Add((DocumentEntity)entity);
					break;
				case "NavigationItems":
					this.NavigationItems.Add((NavigationEntity)entity);
					break;
				case "PageEditRoles":
					this.PageEditRoles.Add((PageEditRoleEntity)entity);
					break;
				case "PageLocalizations":
					this.PageLocalizations.Add((PageLocalizationEntity)entity);
					break;
				case "PageRoles":
					this.PageRoles.Add((PageRoleEntity)entity);
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
				case "AspnetUsers":
					toReturn.Add(Relations.AspnetUsersEntityUsingUserId);
					break;
				case "AdPage":
					toReturn.Add(Relations.AdPageEntityUsingPageId);
					break;
				case "Documents":
					toReturn.Add(Relations.DocumentEntityUsingPageId);
					break;
				case "NavigationItems":
					toReturn.Add(Relations.NavigationEntityUsingPageId);
					break;
				case "PageEditRoles":
					toReturn.Add(Relations.PageEditRoleEntityUsingPageId);
					break;
				case "PageLocalizations":
					toReturn.Add(Relations.PageLocalizationEntityUsingPageId);
					break;
				case "PageRoles":
					toReturn.Add(Relations.PageRoleEntityUsingPageId);
					break;
				case "SnRelationshipss":
					toReturn.Add(Relations.SnRelationshipEntityUsingPageId);
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
				case "AspnetUsers":
					SetupSyncAspnetUsers(relatedEntity);
					break;
				case "AdPage":
					this.AdPage.Add((AdPageEntity)relatedEntity);
					break;
				case "Documents":
					this.Documents.Add((DocumentEntity)relatedEntity);
					break;
				case "NavigationItems":
					this.NavigationItems.Add((NavigationEntity)relatedEntity);
					break;
				case "PageEditRoles":
					this.PageEditRoles.Add((PageEditRoleEntity)relatedEntity);
					break;
				case "PageLocalizations":
					this.PageLocalizations.Add((PageLocalizationEntity)relatedEntity);
					break;
				case "PageRoles":
					this.PageRoles.Add((PageRoleEntity)relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "AspnetApplications":
					DesetupSyncAspnetApplications(false, true);
					break;
				case "AspnetUsers":
					DesetupSyncAspnetUsers(false, true);
					break;
				case "AdPage":
					this.PerformRelatedEntityRemoval(this.AdPage, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Documents":
					this.PerformRelatedEntityRemoval(this.Documents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NavigationItems":
					this.PerformRelatedEntityRemoval(this.NavigationItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PageEditRoles":
					this.PerformRelatedEntityRemoval(this.PageEditRoles, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PageLocalizations":
					this.PerformRelatedEntityRemoval(this.PageLocalizations, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PageRoles":
					this.PerformRelatedEntityRemoval(this.PageRoles, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.AdPage);
			toReturn.Add(this.Documents);
			toReturn.Add(this.NavigationItems);
			toReturn.Add(this.PageEditRoles);
			toReturn.Add(this.PageLocalizations);
			toReturn.Add(this.PageRoles);
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
				info.AddValue("_adPage", ((_adPage!=null) && (_adPage.Count>0) && !this.MarkedForDeletion)?_adPage:null);
				info.AddValue("_documents", ((_documents!=null) && (_documents.Count>0) && !this.MarkedForDeletion)?_documents:null);
				info.AddValue("_navigationItems", ((_navigationItems!=null) && (_navigationItems.Count>0) && !this.MarkedForDeletion)?_navigationItems:null);
				info.AddValue("_pageEditRoles", ((_pageEditRoles!=null) && (_pageEditRoles.Count>0) && !this.MarkedForDeletion)?_pageEditRoles:null);
				info.AddValue("_pageLocalizations", ((_pageLocalizations!=null) && (_pageLocalizations.Count>0) && !this.MarkedForDeletion)?_pageLocalizations:null);
				info.AddValue("_pageRoles", ((_pageRoles!=null) && (_pageRoles.Count>0) && !this.MarkedForDeletion)?_pageRoles:null);
				info.AddValue("_snRelationshipss", ((_snRelationshipss!=null) && (_snRelationshipss.Count>0) && !this.MarkedForDeletion)?_snRelationshipss:null);
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
			return new PageRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'AdPage' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAdPage()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AdPageFields.PageId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Document' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDocuments()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DocumentFields.PageId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Navigation' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNavigationItems()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NavigationFields.PageId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PageEditRole' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPageEditRoles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PageEditRoleFields.PageId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PageLocalization' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPageLocalizations()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PageLocalizationFields.PageId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PageRole' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPageRoles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PageRoleFields.PageId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationshipss()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.PageId, null, ComparisonOperator.Equal, this.Id));
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
			return EntityFactoryCache2.GetEntityFactory(typeof(PageEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._adPage);
			collectionsQueue.Enqueue(this._documents);
			collectionsQueue.Enqueue(this._navigationItems);
			collectionsQueue.Enqueue(this._pageEditRoles);
			collectionsQueue.Enqueue(this._pageLocalizations);
			collectionsQueue.Enqueue(this._pageRoles);
			collectionsQueue.Enqueue(this._snRelationshipss);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._adPage = (EntityCollection<AdPageEntity>) collectionsQueue.Dequeue();
			this._documents = (EntityCollection<DocumentEntity>) collectionsQueue.Dequeue();
			this._navigationItems = (EntityCollection<NavigationEntity>) collectionsQueue.Dequeue();
			this._pageEditRoles = (EntityCollection<PageEditRoleEntity>) collectionsQueue.Dequeue();
			this._pageLocalizations = (EntityCollection<PageLocalizationEntity>) collectionsQueue.Dequeue();
			this._pageRoles = (EntityCollection<PageRoleEntity>) collectionsQueue.Dequeue();
			this._snRelationshipss = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._adPage != null);
			toReturn |=(this._documents != null);
			toReturn |=(this._navigationItems != null);
			toReturn |=(this._pageEditRoles != null);
			toReturn |=(this._pageLocalizations != null);
			toReturn |=(this._pageRoles != null);
			toReturn |=(this._snRelationshipss != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AdPageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AdPageEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DocumentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NavigationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NavigationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PageEditRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PageEditRoleEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PageLocalizationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PageLocalizationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PageRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PageRoleEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetApplications", _aspnetApplications);
			toReturn.Add("AspnetUsers", _aspnetUsers);
			toReturn.Add("AdPage", _adPage);
			toReturn.Add("Documents", _documents);
			toReturn.Add("NavigationItems", _navigationItems);
			toReturn.Add("PageEditRoles", _pageEditRoles);
			toReturn.Add("PageLocalizations", _pageLocalizations);
			toReturn.Add("PageRoles", _pageRoles);
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
			_fieldsCustomProperties.Add("Url", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TemplateName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CacheDuration", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VaryByCustom", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VaryByParam", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VaryByContentEncoding", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VaryByHeader", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VaryByControl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CacheDependencyKeys", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CacheLocation", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SlidingExpiration", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Theme", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MasterPage", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetApplications</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetApplications(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticPageRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)PageFieldIndex.ApplicationId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetApplications, new PropertyChangedEventHandler( OnAspnetApplicationsPropertyChanged ), "AspnetApplications", MonoSoftware.MonoX.DAL.RelationClasses.StaticPageRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, new string[] {  } );
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
			this.PerformDesetupSyncRelatedEntity( _aspnetUsers, new PropertyChangedEventHandler( OnAspnetUsersPropertyChanged ), "AspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticPageRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "Page", resetFKFields, new int[] { (int)PageFieldIndex.UserId } );
			_aspnetUsers = null;
		}

		/// <summary> setups the sync logic for member _aspnetUsers</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetUsers(IEntityCore relatedEntity)
		{
			if(_aspnetUsers!=relatedEntity)
			{
				DesetupSyncAspnetUsers(true, true);
				_aspnetUsers = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetUsers, new PropertyChangedEventHandler( OnAspnetUsersPropertyChanged ), "AspnetUsers", MonoSoftware.MonoX.DAL.RelationClasses.StaticPageRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
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
		/// <param name="validator">The validator object for this PageEntity</param>
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
		public  static PageRelations Relations
		{
			get	{ return new PageRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AdPage' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAdPage
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<AdPageEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AdPageEntityFactory))), (IEntityRelation)GetRelationsForField("AdPage")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AdPageEntity, 0, null, null, null, null, "AdPage", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Document' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDocuments
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<DocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DocumentEntityFactory))), (IEntityRelation)GetRelationsForField("Documents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.DocumentEntity, 0, null, null, null, null, "Documents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Navigation' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNavigationItems
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NavigationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NavigationEntityFactory))), (IEntityRelation)GetRelationsForField("NavigationItems")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, 0, null, null, null, null, "NavigationItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PageEditRole' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPageEditRoles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PageEditRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PageEditRoleEntityFactory))), (IEntityRelation)GetRelationsForField("PageEditRoles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PageEditRoleEntity, 0, null, null, null, null, "PageEditRoles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PageLocalization' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPageLocalizations
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PageLocalizationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PageLocalizationEntityFactory))), (IEntityRelation)GetRelationsForField("PageLocalizations")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PageLocalizationEntity, 0, null, null, null, null, "PageLocalizations", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PageRole' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPageRoles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PageRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PageRoleEntityFactory))), (IEntityRelation)GetRelationsForField("PageRoles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PageRoleEntity, 0, null, null, null, null, "PageRoles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationshipss
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationshipss")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationshipss", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetApplications' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetApplications
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetApplicationsEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetApplications")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, 0, null, null, null, null, "AspnetApplications", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUsers
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUsers")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUsers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>		
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)PageFieldIndex.Id, true); }
			set	{ SetValue((int)PageFieldIndex.Id, value); }
		}

		/// <summary> The ApplicationId property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."ApplicationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid ApplicationId
		{
			get { return (System.Guid)GetValue((int)PageFieldIndex.ApplicationId, true); }
			set	{ SetValue((int)PageFieldIndex.ApplicationId, value); }
		}

		/// <summary> The Url property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."Url"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 450<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String Url
		{
			get { return (System.String)GetValue((int)PageFieldIndex.Url, true); }
			set	{ SetValue((int)PageFieldIndex.Url, value); }
		}

		/// <summary> The UserId property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.Guid> UserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)PageFieldIndex.UserId, false); }
			set	{ SetValue((int)PageFieldIndex.UserId, value); }
		}

		/// <summary> The DateCreated property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)PageFieldIndex.DateCreated, true); }
			set	{ SetValue((int)PageFieldIndex.DateCreated, value); }
		}

		/// <summary> The TemplateName property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."TemplateName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String TemplateName
		{
			get { return (System.String)GetValue((int)PageFieldIndex.TemplateName, true); }
			set	{ SetValue((int)PageFieldIndex.TemplateName, value); }
		}

		/// <summary> The CacheDuration property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."CacheDuration"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Int32 CacheDuration
		{
			get { return (System.Int32)GetValue((int)PageFieldIndex.CacheDuration, true); }
			set	{ SetValue((int)PageFieldIndex.CacheDuration, value); }
		}

		/// <summary> The VaryByCustom property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."VaryByCustom"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String VaryByCustom
		{
			get { return (System.String)GetValue((int)PageFieldIndex.VaryByCustom, true); }
			set	{ SetValue((int)PageFieldIndex.VaryByCustom, value); }
		}

		/// <summary> The VaryByParam property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."VaryByParam"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String VaryByParam
		{
			get { return (System.String)GetValue((int)PageFieldIndex.VaryByParam, true); }
			set	{ SetValue((int)PageFieldIndex.VaryByParam, value); }
		}

		/// <summary> The VaryByContentEncoding property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."VaryByContentEncoding"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String VaryByContentEncoding
		{
			get { return (System.String)GetValue((int)PageFieldIndex.VaryByContentEncoding, true); }
			set	{ SetValue((int)PageFieldIndex.VaryByContentEncoding, value); }
		}

		/// <summary> The VaryByHeader property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."VaryByHeader"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String VaryByHeader
		{
			get { return (System.String)GetValue((int)PageFieldIndex.VaryByHeader, true); }
			set	{ SetValue((int)PageFieldIndex.VaryByHeader, value); }
		}

		/// <summary> The VaryByControl property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."VaryByControl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String VaryByControl
		{
			get { return (System.String)GetValue((int)PageFieldIndex.VaryByControl, true); }
			set	{ SetValue((int)PageFieldIndex.VaryByControl, value); }
		}

		/// <summary> The CacheDependencyKeys property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."CacheDependencyKeys"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String CacheDependencyKeys
		{
			get { return (System.String)GetValue((int)PageFieldIndex.CacheDependencyKeys, true); }
			set	{ SetValue((int)PageFieldIndex.CacheDependencyKeys, value); }
		}

		/// <summary> The CacheLocation property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."CacheLocation"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Int32 CacheLocation
		{
			get { return (System.Int32)GetValue((int)PageFieldIndex.CacheLocation, true); }
			set	{ SetValue((int)PageFieldIndex.CacheLocation, value); }
		}

		/// <summary> The SlidingExpiration property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."SlidingExpiration"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Int32 SlidingExpiration
		{
			get { return (System.Int32)GetValue((int)PageFieldIndex.SlidingExpiration, true); }
			set	{ SetValue((int)PageFieldIndex.SlidingExpiration, value); }
		}

		/// <summary> The Theme property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."Theme"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String Theme
		{
			get { return (System.String)GetValue((int)PageFieldIndex.Theme, true); }
			set	{ SetValue((int)PageFieldIndex.Theme, value); }
		}

		/// <summary> The MasterPage property of the Entity Page<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Page"."MasterPage"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String MasterPage
		{
			get { return (System.String)GetValue((int)PageFieldIndex.MasterPage, true); }
			set	{ SetValue((int)PageFieldIndex.MasterPage, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AdPageEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AdPageEntity))]		
		public virtual EntityCollection<AdPageEntity> AdPage
		{
			get { return GetOrCreateEntityCollection<AdPageEntity, AdPageEntityFactory>("Page", true, false, ref _adPage);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DocumentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(DocumentEntity))]		
		public virtual EntityCollection<DocumentEntity> Documents
		{
			get { return GetOrCreateEntityCollection<DocumentEntity, DocumentEntityFactory>("Page", true, false, ref _documents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NavigationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NavigationEntity))]		
		public virtual EntityCollection<NavigationEntity> NavigationItems
		{
			get { return GetOrCreateEntityCollection<NavigationEntity, NavigationEntityFactory>("Page", true, false, ref _navigationItems);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PageEditRoleEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PageEditRoleEntity))]		
		public virtual EntityCollection<PageEditRoleEntity> PageEditRoles
		{
			get { return GetOrCreateEntityCollection<PageEditRoleEntity, PageEditRoleEntityFactory>("Page", true, false, ref _pageEditRoles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PageLocalizationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PageLocalizationEntity))]		
		public virtual EntityCollection<PageLocalizationEntity> PageLocalizations
		{
			get { return GetOrCreateEntityCollection<PageLocalizationEntity, PageLocalizationEntityFactory>("Page", true, false, ref _pageLocalizations);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PageRoleEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PageRoleEntity))]		
		public virtual EntityCollection<PageRoleEntity> PageRoles
		{
			get { return GetOrCreateEntityCollection<PageRoleEntity, PageRoleEntityFactory>("Page", true, false, ref _pageRoles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]		
		public virtual EntityCollection<SnRelationshipEntity> SnRelationshipss
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("Page", true, false, ref _snRelationshipss);	}
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
					SetSingleRelatedEntityNavigator(value, "Page", "AspnetUsers", _aspnetUsers, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.PageEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode

        public bool LocalizationExists()
        {
            return (this.PageLocalizations.Count > 0 && this.PageLocalizations[0] != null);
        }

        public bool LocalizationExists(Guid languageId)
        {
            foreach (PageLocalizationEntity localization in this.PageLocalizations)
            {
                if (localization.LanguageId == languageId)
                    return true;
            }
            return false;
        }

	    public bool HasNavigation
	    {
            get { return (this.NavigationItems.Count > 0 && this.NavigationItems[0] != null && this.NavigationItems[0].NavigationLocalizations.Count > 0); }
	    }
	
        
        public PageLocalizationEntity LocalizedPage
        {
            get
            {
                if (LocalizationExists())
                    return (this.PageLocalizations[0]);
                else
                    return null;
            }
        }
	
        public string LocalizedTitle
        {
            get {
                if (LocalizationExists())
                    return LocalizedPage.Title;
                else
                    return string.Empty;
            }
            set {
                if (LocalizationExists())
                    LocalizedPage.Title = value;
            }
        }


        public string LocalizedKeywords
        {
            get
            {
                if (LocalizationExists())
                    return LocalizedPage.Keywords;
                else
                    return string.Empty;
            }
            set
            {
                if (LocalizationExists())
                    LocalizedPage.Keywords = value;
            }
        }

        public string LocalizedDescription
        {
            get
            {
                if (LocalizationExists())
                    return LocalizedPage.Description;
                else
                    return string.Empty;
            }
            set
            {
                if (LocalizationExists())
                    LocalizedPage.Description = value;
            }
        }

	
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
