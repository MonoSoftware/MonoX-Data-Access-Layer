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
	/// <summary>Entity class which represents the entity 'SnDiscussionMessage'.<br/><br/></summary>
	[Serializable]
	public partial class SnDiscussionMessageEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SnRelationshipEntity> _snRelationships;
		private AspnetUsersEntity _adminAttentionReportedByUser;
		private AspnetUsersEntity _aspnetUser;
		private AspnetUsersEntity _deleteRequestedByUser;
		private AspnetUsersEntity _pinnedByUser;
		private SnDiscussionTopicEntity _snDiscussionTopic;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AdminAttentionReportedByUser</summary>
			public static readonly string AdminAttentionReportedByUser = "AdminAttentionReportedByUser";
			/// <summary>Member name AspnetUser</summary>
			public static readonly string AspnetUser = "AspnetUser";
			/// <summary>Member name DeleteRequestedByUser</summary>
			public static readonly string DeleteRequestedByUser = "DeleteRequestedByUser";
			/// <summary>Member name PinnedByUser</summary>
			public static readonly string PinnedByUser = "PinnedByUser";
			/// <summary>Member name SnDiscussionTopic</summary>
			public static readonly string SnDiscussionTopic = "SnDiscussionTopic";
			/// <summary>Member name SnRelationships</summary>
			public static readonly string SnRelationships = "SnRelationships";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SnDiscussionMessageEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SnDiscussionMessageEntity():base("SnDiscussionMessageEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SnDiscussionMessageEntity(IEntityFields2 fields):base("SnDiscussionMessageEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SnDiscussionMessageEntity</param>
		public SnDiscussionMessageEntity(IValidator validator):base("SnDiscussionMessageEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnDiscussionMessage which data should be fetched into this SnDiscussionMessage object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnDiscussionMessageEntity(System.Guid id):base("SnDiscussionMessageEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnDiscussionMessage which data should be fetched into this SnDiscussionMessage object</param>
		/// <param name="validator">The custom validator object for this SnDiscussionMessageEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnDiscussionMessageEntity(System.Guid id, IValidator validator):base("SnDiscussionMessageEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SnDiscussionMessageEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_snRelationships = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationships", typeof(EntityCollection<SnRelationshipEntity>));
				_adminAttentionReportedByUser = (AspnetUsersEntity)info.GetValue("_adminAttentionReportedByUser", typeof(AspnetUsersEntity));
				if(_adminAttentionReportedByUser!=null)
				{
					_adminAttentionReportedByUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_aspnetUser = (AspnetUsersEntity)info.GetValue("_aspnetUser", typeof(AspnetUsersEntity));
				if(_aspnetUser!=null)
				{
					_aspnetUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_deleteRequestedByUser = (AspnetUsersEntity)info.GetValue("_deleteRequestedByUser", typeof(AspnetUsersEntity));
				if(_deleteRequestedByUser!=null)
				{
					_deleteRequestedByUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_pinnedByUser = (AspnetUsersEntity)info.GetValue("_pinnedByUser", typeof(AspnetUsersEntity));
				if(_pinnedByUser!=null)
				{
					_pinnedByUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snDiscussionTopic = (SnDiscussionTopicEntity)info.GetValue("_snDiscussionTopic", typeof(SnDiscussionTopicEntity));
				if(_snDiscussionTopic!=null)
				{
					_snDiscussionTopic.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SnDiscussionMessageFieldIndex)fieldIndex)
			{
				case SnDiscussionMessageFieldIndex.SnDiscussionTopicId:
					DesetupSyncSnDiscussionTopic(true, false);
					break;
				case SnDiscussionMessageFieldIndex.UserId:
					DesetupSyncAspnetUser(true, false);
					break;
				case SnDiscussionMessageFieldIndex.AdminAttentionReportedByUserId:
					DesetupSyncAdminAttentionReportedByUser(true, false);
					break;
				case SnDiscussionMessageFieldIndex.DeleteRequestedByUserId:
					DesetupSyncDeleteRequestedByUser(true, false);
					break;
				case SnDiscussionMessageFieldIndex.PinnedByUserId:
					DesetupSyncPinnedByUser(true, false);
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
				case "AdminAttentionReportedByUser":
					this.AdminAttentionReportedByUser = (AspnetUsersEntity)entity;
					break;
				case "AspnetUser":
					this.AspnetUser = (AspnetUsersEntity)entity;
					break;
				case "DeleteRequestedByUser":
					this.DeleteRequestedByUser = (AspnetUsersEntity)entity;
					break;
				case "PinnedByUser":
					this.PinnedByUser = (AspnetUsersEntity)entity;
					break;
				case "SnDiscussionTopic":
					this.SnDiscussionTopic = (SnDiscussionTopicEntity)entity;
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
				case "AdminAttentionReportedByUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingAdminAttentionReportedByUserId);
					break;
				case "AspnetUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingUserId);
					break;
				case "DeleteRequestedByUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingDeleteRequestedByUserId);
					break;
				case "PinnedByUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingPinnedByUserId);
					break;
				case "SnDiscussionTopic":
					toReturn.Add(Relations.SnDiscussionTopicEntityUsingSnDiscussionTopicId);
					break;
				case "SnRelationships":
					toReturn.Add(Relations.SnRelationshipEntityUsingDiscussionMessageId);
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
			int numberOfOneWayRelations = 0+1+1+1;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				case "AdminAttentionReportedByUser":
					return true;
				case "AspnetUser":
					return true;
				case "DeleteRequestedByUser":
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
				case "AdminAttentionReportedByUser":
					SetupSyncAdminAttentionReportedByUser(relatedEntity);
					break;
				case "AspnetUser":
					SetupSyncAspnetUser(relatedEntity);
					break;
				case "DeleteRequestedByUser":
					SetupSyncDeleteRequestedByUser(relatedEntity);
					break;
				case "PinnedByUser":
					SetupSyncPinnedByUser(relatedEntity);
					break;
				case "SnDiscussionTopic":
					SetupSyncSnDiscussionTopic(relatedEntity);
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
				case "AdminAttentionReportedByUser":
					DesetupSyncAdminAttentionReportedByUser(false, true);
					break;
				case "AspnetUser":
					DesetupSyncAspnetUser(false, true);
					break;
				case "DeleteRequestedByUser":
					DesetupSyncDeleteRequestedByUser(false, true);
					break;
				case "PinnedByUser":
					DesetupSyncPinnedByUser(false, true);
					break;
				case "SnDiscussionTopic":
					DesetupSyncSnDiscussionTopic(false, true);
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
			if(_adminAttentionReportedByUser!=null)
			{
				toReturn.Add(_adminAttentionReportedByUser);
			}
			if(_aspnetUser!=null)
			{
				toReturn.Add(_aspnetUser);
			}
			if(_deleteRequestedByUser!=null)
			{
				toReturn.Add(_deleteRequestedByUser);
			}
			if(_pinnedByUser!=null)
			{
				toReturn.Add(_pinnedByUser);
			}
			if(_snDiscussionTopic!=null)
			{
				toReturn.Add(_snDiscussionTopic);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
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
				info.AddValue("_snRelationships", ((_snRelationships!=null) && (_snRelationships.Count>0) && !this.MarkedForDeletion)?_snRelationships:null);
				info.AddValue("_adminAttentionReportedByUser", (!this.MarkedForDeletion?_adminAttentionReportedByUser:null));
				info.AddValue("_aspnetUser", (!this.MarkedForDeletion?_aspnetUser:null));
				info.AddValue("_deleteRequestedByUser", (!this.MarkedForDeletion?_deleteRequestedByUser:null));
				info.AddValue("_pinnedByUser", (!this.MarkedForDeletion?_pinnedByUser:null));
				info.AddValue("_snDiscussionTopic", (!this.MarkedForDeletion?_snDiscussionTopic:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SnDiscussionMessageRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationships()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.DiscussionMessageId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAdminAttentionReportedByUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.AdminAttentionReportedByUserId));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeleteRequestedByUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.DeleteRequestedByUserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPinnedByUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.PinnedByUserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnDiscussionTopic' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionTopic()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionTopicFields.Id, null, ComparisonOperator.Equal, this.SnDiscussionTopicId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionMessageEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._snRelationships);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._snRelationships = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._snRelationships != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AdminAttentionReportedByUser", _adminAttentionReportedByUser);
			toReturn.Add("AspnetUser", _aspnetUser);
			toReturn.Add("DeleteRequestedByUser", _deleteRequestedByUser);
			toReturn.Add("PinnedByUser", _pinnedByUser);
			toReturn.Add("SnDiscussionTopic", _snDiscussionTopic);
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
			_fieldsCustomProperties.Add("SnDiscussionTopicId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Message", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Ip", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Referrer", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserAgent", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsApproved", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsSpam", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Spaminess", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Signature", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsAnswer", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AdminAttentionRequired", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AdminAttentionReportedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AdminAttentionReportedOn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AdminAttentionApproved", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AdminAttentionReason", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsDeleteRequested", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DeleteRequestedOn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DeleteRequestedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsDeleteApproved", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DeleteDisapprovedReason", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsPinned", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PinnedOn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PinnedByUserId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _adminAttentionReportedByUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAdminAttentionReportedByUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _adminAttentionReportedByUser, new PropertyChangedEventHandler( OnAdminAttentionReportedByUserPropertyChanged ), "AdminAttentionReportedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.AspnetUsersEntityUsingAdminAttentionReportedByUserIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnDiscussionMessageFieldIndex.AdminAttentionReportedByUserId } );
			_adminAttentionReportedByUser = null;
		}

		/// <summary> setups the sync logic for member _adminAttentionReportedByUser</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAdminAttentionReportedByUser(IEntity2 relatedEntity)
		{
			if(_adminAttentionReportedByUser!=relatedEntity)
			{
				DesetupSyncAdminAttentionReportedByUser(true, true);
				_adminAttentionReportedByUser = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _adminAttentionReportedByUser, new PropertyChangedEventHandler( OnAdminAttentionReportedByUserPropertyChanged ), "AdminAttentionReportedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.AspnetUsersEntityUsingAdminAttentionReportedByUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAdminAttentionReportedByUserPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnDiscussionMessageFieldIndex.UserId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _deleteRequestedByUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDeleteRequestedByUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _deleteRequestedByUser, new PropertyChangedEventHandler( OnDeleteRequestedByUserPropertyChanged ), "DeleteRequestedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.AspnetUsersEntityUsingDeleteRequestedByUserIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnDiscussionMessageFieldIndex.DeleteRequestedByUserId } );
			_deleteRequestedByUser = null;
		}

		/// <summary> setups the sync logic for member _deleteRequestedByUser</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDeleteRequestedByUser(IEntity2 relatedEntity)
		{
			if(_deleteRequestedByUser!=relatedEntity)
			{
				DesetupSyncDeleteRequestedByUser(true, true);
				_deleteRequestedByUser = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _deleteRequestedByUser, new PropertyChangedEventHandler( OnDeleteRequestedByUserPropertyChanged ), "DeleteRequestedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.AspnetUsersEntityUsingDeleteRequestedByUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDeleteRequestedByUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _pinnedByUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPinnedByUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _pinnedByUser, new PropertyChangedEventHandler( OnPinnedByUserPropertyChanged ), "PinnedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.AspnetUsersEntityUsingPinnedByUserIdStatic, true, signalRelatedEntity, "SnDiscussionMessage", resetFKFields, new int[] { (int)SnDiscussionMessageFieldIndex.PinnedByUserId } );
			_pinnedByUser = null;
		}

		/// <summary> setups the sync logic for member _pinnedByUser</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPinnedByUser(IEntity2 relatedEntity)
		{
			if(_pinnedByUser!=relatedEntity)
			{
				DesetupSyncPinnedByUser(true, true);
				_pinnedByUser = (AspnetUsersEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _pinnedByUser, new PropertyChangedEventHandler( OnPinnedByUserPropertyChanged ), "PinnedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.AspnetUsersEntityUsingPinnedByUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPinnedByUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _snDiscussionTopic</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnDiscussionTopic(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snDiscussionTopic, new PropertyChangedEventHandler( OnSnDiscussionTopicPropertyChanged ), "SnDiscussionTopic", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.SnDiscussionTopicEntityUsingSnDiscussionTopicIdStatic, true, signalRelatedEntity, "SnDiscussionMessages", resetFKFields, new int[] { (int)SnDiscussionMessageFieldIndex.SnDiscussionTopicId } );
			_snDiscussionTopic = null;
		}

		/// <summary> setups the sync logic for member _snDiscussionTopic</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnDiscussionTopic(IEntity2 relatedEntity)
		{
			if(_snDiscussionTopic!=relatedEntity)
			{
				DesetupSyncSnDiscussionTopic(true, true);
				_snDiscussionTopic = (SnDiscussionTopicEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snDiscussionTopic, new PropertyChangedEventHandler( OnSnDiscussionTopicPropertyChanged ), "SnDiscussionTopic", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionMessageRelations.SnDiscussionTopicEntityUsingSnDiscussionTopicIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnDiscussionTopicPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SnDiscussionMessageEntity</param>
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
		public  static SnDiscussionMessageRelations Relations
		{
			get	{ return new SnDiscussionMessageRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationships
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationships")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationships", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAdminAttentionReportedByUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AdminAttentionReportedByUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AdminAttentionReportedByUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeleteRequestedByUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("DeleteRequestedByUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "DeleteRequestedByUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPinnedByUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("PinnedByUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "PinnedByUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionTopic' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionTopic
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionTopicEntityFactory))),	(IEntityRelation)GetRelationsForField("SnDiscussionTopic")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, 0, null, null, null, null, "SnDiscussionTopic", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)SnDiscussionMessageFieldIndex.Id, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.Id, value); }
		}

		/// <summary> The SnDiscussionTopicId property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."SnDiscussionTopicId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid SnDiscussionTopicId
		{
			get { return (System.Guid)GetValue((int)SnDiscussionMessageFieldIndex.SnDiscussionTopicId, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.SnDiscussionTopicId, value); }
		}

		/// <summary> The UserId property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid UserId
		{
			get { return (System.Guid)GetValue((int)SnDiscussionMessageFieldIndex.UserId, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.UserId, value); }
		}

		/// <summary> The Message property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."Message"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Message
		{
			get { return (System.String)GetValue((int)SnDiscussionMessageFieldIndex.Message, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.Message, value); }
		}

		/// <summary> The DateCreated property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)SnDiscussionMessageFieldIndex.DateCreated, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.DateCreated, value); }
		}

		/// <summary> The LastModifiedDate property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."LastModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> LastModifiedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SnDiscussionMessageFieldIndex.LastModifiedDate, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.LastModifiedDate, value); }
		}

		/// <summary> The Ip property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."Ip"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Ip
		{
			get { return (System.String)GetValue((int)SnDiscussionMessageFieldIndex.Ip, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.Ip, value); }
		}

		/// <summary> The Referrer property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."Referrer"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Referrer
		{
			get { return (System.String)GetValue((int)SnDiscussionMessageFieldIndex.Referrer, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.Referrer, value); }
		}

		/// <summary> The UserAgent property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."UserAgent"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String UserAgent
		{
			get { return (System.String)GetValue((int)SnDiscussionMessageFieldIndex.UserAgent, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.UserAgent, value); }
		}

		/// <summary> The IsApproved property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."IsApproved"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsApproved
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionMessageFieldIndex.IsApproved, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.IsApproved, value); }
		}

		/// <summary> The IsSpam property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."IsSpam"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsSpam
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionMessageFieldIndex.IsSpam, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.IsSpam, value); }
		}

		/// <summary> The Spaminess property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."Spaminess"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 18, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Spaminess
		{
			get { return (System.Decimal)GetValue((int)SnDiscussionMessageFieldIndex.Spaminess, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.Spaminess, value); }
		}

		/// <summary> The Signature property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."Signature"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Signature
		{
			get { return (System.String)GetValue((int)SnDiscussionMessageFieldIndex.Signature, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.Signature, value); }
		}

		/// <summary> The IsAnswer property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."IsAnswer"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsAnswer
		{
			get { return (Nullable<System.Boolean>)GetValue((int)SnDiscussionMessageFieldIndex.IsAnswer, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.IsAnswer, value); }
		}

		/// <summary> The AdminAttentionRequired property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."AdminAttentionRequired"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> AdminAttentionRequired
		{
			get { return (Nullable<System.Boolean>)GetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionRequired, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionRequired, value); }
		}

		/// <summary> The AdminAttentionReportedByUserId property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."AdminAttentionReportedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> AdminAttentionReportedByUserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionReportedByUserId, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionReportedByUserId, value); }
		}

		/// <summary> The AdminAttentionReportedOn property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."AdminAttentionReportedOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> AdminAttentionReportedOn
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionReportedOn, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionReportedOn, value); }
		}

		/// <summary> The AdminAttentionApproved property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."AdminAttentionApproved"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> AdminAttentionApproved
		{
			get { return (Nullable<System.Boolean>)GetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionApproved, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionApproved, value); }
		}

		/// <summary> The AdminAttentionReason property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."AdminAttentionReason"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 300<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AdminAttentionReason
		{
			get { return (System.String)GetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionReason, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.AdminAttentionReason, value); }
		}

		/// <summary> The IsDeleteRequested property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."IsDeleteRequested"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsDeleteRequested
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionMessageFieldIndex.IsDeleteRequested, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.IsDeleteRequested, value); }
		}

		/// <summary> The DeleteRequestedOn property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."DeleteRequestedOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DeleteRequestedOn
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SnDiscussionMessageFieldIndex.DeleteRequestedOn, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.DeleteRequestedOn, value); }
		}

		/// <summary> The DeleteRequestedByUserId property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."DeleteRequestedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> DeleteRequestedByUserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnDiscussionMessageFieldIndex.DeleteRequestedByUserId, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.DeleteRequestedByUserId, value); }
		}

		/// <summary> The IsDeleteApproved property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."IsDeleteApproved"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsDeleteApproved
		{
			get { return (Nullable<System.Boolean>)GetValue((int)SnDiscussionMessageFieldIndex.IsDeleteApproved, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.IsDeleteApproved, value); }
		}

		/// <summary> The DeleteDisapprovedReason property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."DeleteDisapprovedReason"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 300<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String DeleteDisapprovedReason
		{
			get { return (System.String)GetValue((int)SnDiscussionMessageFieldIndex.DeleteDisapprovedReason, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.DeleteDisapprovedReason, value); }
		}

		/// <summary> The IsPinned property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."IsPinned"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsPinned
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionMessageFieldIndex.IsPinned, true); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.IsPinned, value); }
		}

		/// <summary> The PinnedOn property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."PinnedOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> PinnedOn
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SnDiscussionMessageFieldIndex.PinnedOn, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.PinnedOn, value); }
		}

		/// <summary> The PinnedByUserId property of the Entity SnDiscussionMessage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionMessage"."PinnedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> PinnedByUserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnDiscussionMessageFieldIndex.PinnedByUserId, false); }
			set	{ SetValue((int)SnDiscussionMessageFieldIndex.PinnedByUserId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]
		public virtual EntityCollection<SnRelationshipEntity> SnRelationships
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("SnDiscussionMessage", true, false, ref _snRelationships);	}
		}

		/// <summary> Gets / sets related entity of type 'AspnetUsersEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual AspnetUsersEntity AdminAttentionReportedByUser
		{
			get	{ return _adminAttentionReportedByUser; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAdminAttentionReportedByUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "", "AdminAttentionReportedByUser", _adminAttentionReportedByUser, false); 
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
					SetSingleRelatedEntityNavigator(value, "", "AspnetUser", _aspnetUser, false); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AspnetUsersEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual AspnetUsersEntity DeleteRequestedByUser
		{
			get	{ return _deleteRequestedByUser; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncDeleteRequestedByUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "", "DeleteRequestedByUser", _deleteRequestedByUser, false); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AspnetUsersEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual AspnetUsersEntity PinnedByUser
		{
			get	{ return _pinnedByUser; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPinnedByUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnDiscussionMessage", "PinnedByUser", _pinnedByUser, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SnDiscussionTopicEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnDiscussionTopicEntity SnDiscussionTopic
		{
			get	{ return _snDiscussionTopic; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnDiscussionTopic(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnDiscussionMessages", "SnDiscussionTopic", _snDiscussionTopic, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity; }
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
