﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Entity class which represents the entity 'Newsletter'.<br/><br/></summary>
	[Serializable]
	public partial class NewsletterEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<NewsletterLogEntity> _newsletterLogs;
		private EntityCollection<NewsletterRoleEntity> _newsletterRoles;
		private EntityCollection<SnRelationshipEntity> _snRelationshipss;
		private EntityCollection<AspnetRolesEntity> _aspnetRolesCollectionViaNewsletterRole;
		private AspnetApplicationsEntity _aspnetApplication;
		private AspnetUsersEntity _aspnetUser;
		private LanguageEntity _language;

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
			/// <summary>Member name AspnetUser</summary>
			public static readonly string AspnetUser = "AspnetUser";
			/// <summary>Member name Language</summary>
			public static readonly string Language = "Language";
			/// <summary>Member name NewsletterLogs</summary>
			public static readonly string NewsletterLogs = "NewsletterLogs";
			/// <summary>Member name NewsletterRoles</summary>
			public static readonly string NewsletterRoles = "NewsletterRoles";
			/// <summary>Member name SnRelationshipss</summary>
			public static readonly string SnRelationshipss = "SnRelationshipss";
			/// <summary>Member name AspnetRolesCollectionViaNewsletterRole</summary>
			public static readonly string AspnetRolesCollectionViaNewsletterRole = "AspnetRolesCollectionViaNewsletterRole";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static NewsletterEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public NewsletterEntity():base("NewsletterEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public NewsletterEntity(IEntityFields2 fields):base("NewsletterEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this NewsletterEntity</param>
		public NewsletterEntity(IValidator validator):base("NewsletterEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for Newsletter which data should be fetched into this Newsletter object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public NewsletterEntity(System.Guid id):base("NewsletterEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Newsletter which data should be fetched into this Newsletter object</param>
		/// <param name="validator">The custom validator object for this NewsletterEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public NewsletterEntity(System.Guid id, IValidator validator):base("NewsletterEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected NewsletterEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_newsletterLogs = (EntityCollection<NewsletterLogEntity>)info.GetValue("_newsletterLogs", typeof(EntityCollection<NewsletterLogEntity>));
				_newsletterRoles = (EntityCollection<NewsletterRoleEntity>)info.GetValue("_newsletterRoles", typeof(EntityCollection<NewsletterRoleEntity>));
				_snRelationshipss = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationshipss", typeof(EntityCollection<SnRelationshipEntity>));
				_aspnetRolesCollectionViaNewsletterRole = (EntityCollection<AspnetRolesEntity>)info.GetValue("_aspnetRolesCollectionViaNewsletterRole", typeof(EntityCollection<AspnetRolesEntity>));
				_aspnetApplication = (AspnetApplicationsEntity)info.GetValue("_aspnetApplication", typeof(AspnetApplicationsEntity));
				if(_aspnetApplication!=null)
				{
					_aspnetApplication.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_aspnetUser = (AspnetUsersEntity)info.GetValue("_aspnetUser", typeof(AspnetUsersEntity));
				if(_aspnetUser!=null)
				{
					_aspnetUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_language = (LanguageEntity)info.GetValue("_language", typeof(LanguageEntity));
				if(_language!=null)
				{
					_language.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((NewsletterFieldIndex)fieldIndex)
			{
				case NewsletterFieldIndex.UserId:
					DesetupSyncAspnetUser(true, false);
					break;
				case NewsletterFieldIndex.ApplicationId:
					DesetupSyncAspnetApplication(true, false);
					break;
				case NewsletterFieldIndex.LanguageId:
					DesetupSyncLanguage(true, false);
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
				case "AspnetApplication":
					this.AspnetApplication = (AspnetApplicationsEntity)entity;
					break;
				case "AspnetUser":
					this.AspnetUser = (AspnetUsersEntity)entity;
					break;
				case "Language":
					this.Language = (LanguageEntity)entity;
					break;
				case "NewsletterLogs":
					this.NewsletterLogs.Add((NewsletterLogEntity)entity);
					break;
				case "NewsletterRoles":
					this.NewsletterRoles.Add((NewsletterRoleEntity)entity);
					break;
				case "SnRelationshipss":
					this.SnRelationshipss.Add((SnRelationshipEntity)entity);
					break;
				case "AspnetRolesCollectionViaNewsletterRole":
					this.AspnetRolesCollectionViaNewsletterRole.IsReadOnly = false;
					this.AspnetRolesCollectionViaNewsletterRole.Add((AspnetRolesEntity)entity);
					this.AspnetRolesCollectionViaNewsletterRole.IsReadOnly = true;
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
				case "AspnetUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingUserId);
					break;
				case "Language":
					toReturn.Add(Relations.LanguageEntityUsingLanguageId);
					break;
				case "NewsletterLogs":
					toReturn.Add(Relations.NewsletterLogEntityUsingNewsletterId);
					break;
				case "NewsletterRoles":
					toReturn.Add(Relations.NewsletterRoleEntityUsingNewsletterId);
					break;
				case "SnRelationshipss":
					toReturn.Add(Relations.SnRelationshipEntityUsingNewsletterId);
					break;
				case "AspnetRolesCollectionViaNewsletterRole":
					toReturn.Add(Relations.NewsletterRoleEntityUsingNewsletterId, "NewsletterEntity__", "NewsletterRole_", JoinHint.None);
					toReturn.Add(NewsletterRoleEntity.Relations.AspnetRolesEntityUsingRoleId, "NewsletterRole_", string.Empty, JoinHint.None);
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
			int numberOfOneWayRelations = 0+1+1;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				case "AspnetApplication":
					return true;
				case "Language":
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
				case "AspnetApplication":
					SetupSyncAspnetApplication(relatedEntity);
					break;
				case "AspnetUser":
					SetupSyncAspnetUser(relatedEntity);
					break;
				case "Language":
					SetupSyncLanguage(relatedEntity);
					break;
				case "NewsletterLogs":
					this.NewsletterLogs.Add((NewsletterLogEntity)relatedEntity);
					break;
				case "NewsletterRoles":
					this.NewsletterRoles.Add((NewsletterRoleEntity)relatedEntity);
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
				case "AspnetApplication":
					DesetupSyncAspnetApplication(false, true);
					break;
				case "AspnetUser":
					DesetupSyncAspnetUser(false, true);
					break;
				case "Language":
					DesetupSyncLanguage(false, true);
					break;
				case "NewsletterLogs":
					this.PerformRelatedEntityRemoval(this.NewsletterLogs, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "NewsletterRoles":
					this.PerformRelatedEntityRemoval(this.NewsletterRoles, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_aspnetApplication!=null)
			{
				toReturn.Add(_aspnetApplication);
			}
			if(_aspnetUser!=null)
			{
				toReturn.Add(_aspnetUser);
			}
			if(_language!=null)
			{
				toReturn.Add(_language);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.NewsletterLogs);
			toReturn.Add(this.NewsletterRoles);
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
				info.AddValue("_newsletterLogs", ((_newsletterLogs!=null) && (_newsletterLogs.Count>0) && !this.MarkedForDeletion)?_newsletterLogs:null);
				info.AddValue("_newsletterRoles", ((_newsletterRoles!=null) && (_newsletterRoles.Count>0) && !this.MarkedForDeletion)?_newsletterRoles:null);
				info.AddValue("_snRelationshipss", ((_snRelationshipss!=null) && (_snRelationshipss.Count>0) && !this.MarkedForDeletion)?_snRelationshipss:null);
				info.AddValue("_aspnetRolesCollectionViaNewsletterRole", ((_aspnetRolesCollectionViaNewsletterRole!=null) && (_aspnetRolesCollectionViaNewsletterRole.Count>0) && !this.MarkedForDeletion)?_aspnetRolesCollectionViaNewsletterRole:null);
				info.AddValue("_aspnetApplication", (!this.MarkedForDeletion?_aspnetApplication:null));
				info.AddValue("_aspnetUser", (!this.MarkedForDeletion?_aspnetUser:null));
				info.AddValue("_language", (!this.MarkedForDeletion?_language:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new NewsletterRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsletterLog' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsletterLogs()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsletterLogFields.NewsletterId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'NewsletterRole' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoNewsletterRoles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsletterRoleFields.NewsletterId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationshipss()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.NewsletterId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'AspnetRoles' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetRolesCollectionViaNewsletterRole()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AspnetRolesCollectionViaNewsletterRole"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(NewsletterFields.Id, null, ComparisonOperator.Equal, this.Id, "NewsletterEntity__"));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAspnetUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Language' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoLanguage()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(LanguageFields.Id, null, ComparisonOperator.Equal, this.LanguageId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(NewsletterEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._newsletterLogs);
			collectionsQueue.Enqueue(this._newsletterRoles);
			collectionsQueue.Enqueue(this._snRelationshipss);
			collectionsQueue.Enqueue(this._aspnetRolesCollectionViaNewsletterRole);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._newsletterLogs = (EntityCollection<NewsletterLogEntity>) collectionsQueue.Dequeue();
			this._newsletterRoles = (EntityCollection<NewsletterRoleEntity>) collectionsQueue.Dequeue();
			this._snRelationshipss = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();
			this._aspnetRolesCollectionViaNewsletterRole = (EntityCollection<AspnetRolesEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._newsletterLogs != null);
			toReturn |=(this._newsletterRoles != null);
			toReturn |=(this._snRelationshipss != null);
			toReturn |= (this._aspnetRolesCollectionViaNewsletterRole != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsletterLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsletterLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<NewsletterRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsletterRoleEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AspnetRolesEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AspnetRolesEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetApplication", _aspnetApplication);
			toReturn.Add("AspnetUser", _aspnetUser);
			toReturn.Add("Language", _language);
			toReturn.Add("NewsletterLogs", _newsletterLogs);
			toReturn.Add("NewsletterRoles", _newsletterRoles);
			toReturn.Add("SnRelationshipss", _snRelationshipss);
			toReturn.Add("AspnetRolesCollectionViaNewsletterRole", _aspnetRolesCollectionViaNewsletterRole);
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
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TextContent", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HtmlContent", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SentOn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ApplicationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MailFrom", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TestAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Result", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TextOnly", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LanguageId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetApplication</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetApplication(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetApplication, new PropertyChangedEventHandler( OnAspnetApplicationPropertyChanged ), "AspnetApplication", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsletterRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)NewsletterFieldIndex.ApplicationId } );
			_aspnetApplication = null;
		}

		/// <summary> setups the sync logic for member _aspnetApplication</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAspnetApplication(IEntityCore relatedEntity)
		{
			if(_aspnetApplication!=relatedEntity)
			{
				DesetupSyncAspnetApplication(true, true);
				_aspnetApplication = (AspnetApplicationsEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _aspnetApplication, new PropertyChangedEventHandler( OnAspnetApplicationPropertyChanged ), "AspnetApplication", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsletterRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _aspnetUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsletterRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "Newsletters", resetFKFields, new int[] { (int)NewsletterFieldIndex.UserId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsletterRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _language</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncLanguage(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _language, new PropertyChangedEventHandler( OnLanguagePropertyChanged ), "Language", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsletterRelations.LanguageEntityUsingLanguageIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)NewsletterFieldIndex.LanguageId } );
			_language = null;
		}

		/// <summary> setups the sync logic for member _language</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncLanguage(IEntityCore relatedEntity)
		{
			if(_language!=relatedEntity)
			{
				DesetupSyncLanguage(true, true);
				_language = (LanguageEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _language, new PropertyChangedEventHandler( OnLanguagePropertyChanged ), "Language", MonoSoftware.MonoX.DAL.RelationClasses.StaticNewsletterRelations.LanguageEntityUsingLanguageIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnLanguagePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this NewsletterEntity</param>
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
		public  static NewsletterRelations Relations
		{
			get	{ return new NewsletterRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsletterLog' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsletterLogs
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsletterLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsletterLogEntityFactory))), (IEntityRelation)GetRelationsForField("NewsletterLogs")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterLogEntity, 0, null, null, null, null, "NewsletterLogs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'NewsletterRole' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathNewsletterRoles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<NewsletterRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(NewsletterRoleEntityFactory))), (IEntityRelation)GetRelationsForField("NewsletterRoles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterRoleEntity, 0, null, null, null, null, "NewsletterRoles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationshipss
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationshipss")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationshipss", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetRoles' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetRolesCollectionViaNewsletterRole
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.NewsletterRoleEntityUsingNewsletterId;
				intermediateRelation.SetAliases(string.Empty, "NewsletterRole_");
				return new PrefetchPathElement2(new EntityCollection<AspnetRolesEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AspnetRolesEntityFactory))), intermediateRelation,
					(int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetRolesEntity, 0, null, null, GetRelationsForField("AspnetRolesCollectionViaNewsletterRole"), null, "AspnetRolesCollectionViaNewsletterRole", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetApplications' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetApplication
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetApplicationsEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetApplication")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, 0, null, null, null, null, "AspnetApplication", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Language' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathLanguage
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(LanguageEntityFactory))),	(IEntityRelation)GetRelationsForField("Language")[0], (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, (int)MonoSoftware.MonoX.DAL.EntityType.LanguageEntity, 0, null, null, null, null, "Language", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>		
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)NewsletterFieldIndex.Id, true); }
			set	{ SetValue((int)NewsletterFieldIndex.Id, value); }
		}

		/// <summary> The Title property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)NewsletterFieldIndex.Title, true); }
			set	{ SetValue((int)NewsletterFieldIndex.Title, value); }
		}

		/// <summary> The TextContent property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."TextContent"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String TextContent
		{
			get { return (System.String)GetValue((int)NewsletterFieldIndex.TextContent, true); }
			set	{ SetValue((int)NewsletterFieldIndex.TextContent, value); }
		}

		/// <summary> The HtmlContent property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."HtmlContent"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String HtmlContent
		{
			get { return (System.String)GetValue((int)NewsletterFieldIndex.HtmlContent, true); }
			set	{ SetValue((int)NewsletterFieldIndex.HtmlContent, value); }
		}

		/// <summary> The DateModified property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."DateModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.DateTime DateModified
		{
			get { return (System.DateTime)GetValue((int)NewsletterFieldIndex.DateModified, true); }
			set	{ SetValue((int)NewsletterFieldIndex.DateModified, value); }
		}

		/// <summary> The SentOn property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."SentOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual Nullable<System.DateTime> SentOn
		{
			get { return (Nullable<System.DateTime>)GetValue((int)NewsletterFieldIndex.SentOn, false); }
			set	{ SetValue((int)NewsletterFieldIndex.SentOn, value); }
		}

		/// <summary> The UserId property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid UserId
		{
			get { return (System.Guid)GetValue((int)NewsletterFieldIndex.UserId, true); }
			set	{ SetValue((int)NewsletterFieldIndex.UserId, value); }
		}

		/// <summary> The ApplicationId property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."ApplicationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid ApplicationId
		{
			get { return (System.Guid)GetValue((int)NewsletterFieldIndex.ApplicationId, true); }
			set	{ SetValue((int)NewsletterFieldIndex.ApplicationId, value); }
		}

		/// <summary> The Status property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String Status
		{
			get { return (System.String)GetValue((int)NewsletterFieldIndex.Status, true); }
			set	{ SetValue((int)NewsletterFieldIndex.Status, value); }
		}

		/// <summary> The MailFrom property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."MailFrom"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String MailFrom
		{
			get { return (System.String)GetValue((int)NewsletterFieldIndex.MailFrom, true); }
			set	{ SetValue((int)NewsletterFieldIndex.MailFrom, value); }
		}

		/// <summary> The TestAddress property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."TestAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String TestAddress
		{
			get { return (System.String)GetValue((int)NewsletterFieldIndex.TestAddress, true); }
			set	{ SetValue((int)NewsletterFieldIndex.TestAddress, value); }
		}

		/// <summary> The Result property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."Result"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>		
		public virtual System.String Result
		{
			get { return (System.String)GetValue((int)NewsletterFieldIndex.Result, true); }
			set	{ SetValue((int)NewsletterFieldIndex.Result, value); }
		}

		/// <summary> The TextOnly property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."TextOnly"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Boolean TextOnly
		{
			get { return (System.Boolean)GetValue((int)NewsletterFieldIndex.TextOnly, true); }
			set	{ SetValue((int)NewsletterFieldIndex.TextOnly, value); }
		}

		/// <summary> The LanguageId property of the Entity Newsletter<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Newsletter"."LanguageId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>		
		public virtual System.Guid LanguageId
		{
			get { return (System.Guid)GetValue((int)NewsletterFieldIndex.LanguageId, true); }
			set	{ SetValue((int)NewsletterFieldIndex.LanguageId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsletterLogEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsletterLogEntity))]		
		public virtual EntityCollection<NewsletterLogEntity> NewsletterLogs
		{
			get { return GetOrCreateEntityCollection<NewsletterLogEntity, NewsletterLogEntityFactory>("Newsletter", true, false, ref _newsletterLogs);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'NewsletterRoleEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(NewsletterRoleEntity))]		
		public virtual EntityCollection<NewsletterRoleEntity> NewsletterRoles
		{
			get { return GetOrCreateEntityCollection<NewsletterRoleEntity, NewsletterRoleEntityFactory>("Newsletter", true, false, ref _newsletterRoles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]		
		public virtual EntityCollection<SnRelationshipEntity> SnRelationshipss
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("Newsletter", true, false, ref _snRelationshipss);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AspnetRolesEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AspnetRolesEntity))]		
		public virtual EntityCollection<AspnetRolesEntity> AspnetRolesCollectionViaNewsletterRole
		{
			get { return GetOrCreateEntityCollection<AspnetRolesEntity, AspnetRolesEntityFactory>("", false, true, ref _aspnetRolesCollectionViaNewsletterRole);	}
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
					SetSingleRelatedEntityNavigator(value, "Newsletters", "AspnetUser", _aspnetUser, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'LanguageEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]		
		public virtual LanguageEntity Language
		{
			get	{ return _language; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncLanguage(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "", "Language", _language, false); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode

        public string UserName
        {
            get 
            {
                if (this.AspnetUser != null)
                    return this.AspnetUser.UserName;
                return string.Empty;
            }
        }

        public string SentOnString
        {
            get 
            {
                if (this.SentOn == DateTime.MinValue)
                    return string.Empty;
                else
                    return this.SentOn.ToString();
            }
        }

        public string NewsletterRolesString
        {
            get 
            {
                string toReturn = string.Empty;
                if (this.NewsletterRoles != null)
                {
                    foreach (NewsletterRoleEntity role in this.NewsletterRoles)
                    {
                        if (string.IsNullOrEmpty(toReturn))
                        {
                            if (role.AspnetRole != null)
                                toReturn = role.AspnetRole.RoleName;
                        }
                        else
                        {
                            if (role.AspnetRole != null)
                                toReturn += string.Format(", {0}", role.AspnetRole.RoleName);
                        }
                    }
                }
                return toReturn;
            }
        }
	
				
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
