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
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'PrivacyLevel'.<br/><br/></summary>
	[Serializable]
	public partial class PrivacyLevelEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<PrivacyLevelDefinitionEntity> _privacyLevelDefinitions;
		private EntityCollection<SnAlbumEntity> _snAlbums;
		private EntityCollection<SnFileEntity> _snFiles;
		private EntityCollection<SnNoteEntity> _snNotes;
		private EntityCollection<UserProfileEntity> _userProfile;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name PrivacyLevelDefinitions</summary>
			public static readonly string PrivacyLevelDefinitions = "PrivacyLevelDefinitions";
			/// <summary>Member name SnAlbums</summary>
			public static readonly string SnAlbums = "SnAlbums";
			/// <summary>Member name SnFiles</summary>
			public static readonly string SnFiles = "SnFiles";
			/// <summary>Member name SnNotes</summary>
			public static readonly string SnNotes = "SnNotes";
			/// <summary>Member name UserProfile</summary>
			public static readonly string UserProfile = "UserProfile";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PrivacyLevelEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public PrivacyLevelEntity():base("PrivacyLevelEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PrivacyLevelEntity(IEntityFields2 fields):base("PrivacyLevelEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PrivacyLevelEntity</param>
		public PrivacyLevelEntity(IValidator validator):base("PrivacyLevelEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for PrivacyLevel which data should be fetched into this PrivacyLevel object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PrivacyLevelEntity(System.Guid id):base("PrivacyLevelEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for PrivacyLevel which data should be fetched into this PrivacyLevel object</param>
		/// <param name="validator">The custom validator object for this PrivacyLevelEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PrivacyLevelEntity(System.Guid id, IValidator validator):base("PrivacyLevelEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PrivacyLevelEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_privacyLevelDefinitions = (EntityCollection<PrivacyLevelDefinitionEntity>)info.GetValue("_privacyLevelDefinitions", typeof(EntityCollection<PrivacyLevelDefinitionEntity>));
				_snAlbums = (EntityCollection<SnAlbumEntity>)info.GetValue("_snAlbums", typeof(EntityCollection<SnAlbumEntity>));
				_snFiles = (EntityCollection<SnFileEntity>)info.GetValue("_snFiles", typeof(EntityCollection<SnFileEntity>));
				_snNotes = (EntityCollection<SnNoteEntity>)info.GetValue("_snNotes", typeof(EntityCollection<SnNoteEntity>));
				_userProfile = (EntityCollection<UserProfileEntity>)info.GetValue("_userProfile", typeof(EntityCollection<UserProfileEntity>));
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}


		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{
				case "PrivacyLevelDefinitions":
					this.PrivacyLevelDefinitions.Add((PrivacyLevelDefinitionEntity)entity);
					break;
				case "SnAlbums":
					this.SnAlbums.Add((SnAlbumEntity)entity);
					break;
				case "SnFiles":
					this.SnFiles.Add((SnFileEntity)entity);
					break;
				case "SnNotes":
					this.SnNotes.Add((SnNoteEntity)entity);
					break;
				case "UserProfile":
					this.UserProfile.Add((UserProfileEntity)entity);
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
				case "PrivacyLevelDefinitions":
					toReturn.Add(Relations.PrivacyLevelDefinitionEntityUsingPrivacyLevelId);
					break;
				case "SnAlbums":
					toReturn.Add(Relations.SnAlbumEntityUsingPrivacyLevelId);
					break;
				case "SnFiles":
					toReturn.Add(Relations.SnFileEntityUsingPrivacyLevelId);
					break;
				case "SnNotes":
					toReturn.Add(Relations.SnNoteEntityUsingPrivacyLevelId);
					break;
				case "UserProfile":
					toReturn.Add(Relations.UserProfileEntityUsingMyStatusPrivacyLevelId);
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
				case "PrivacyLevelDefinitions":
					this.PrivacyLevelDefinitions.Add((PrivacyLevelDefinitionEntity)relatedEntity);
					break;
				case "SnAlbums":
					this.SnAlbums.Add((SnAlbumEntity)relatedEntity);
					break;
				case "SnFiles":
					this.SnFiles.Add((SnFileEntity)relatedEntity);
					break;
				case "SnNotes":
					this.SnNotes.Add((SnNoteEntity)relatedEntity);
					break;
				case "UserProfile":
					this.UserProfile.Add((UserProfileEntity)relatedEntity);
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
				case "PrivacyLevelDefinitions":
					this.PerformRelatedEntityRemoval(this.PrivacyLevelDefinitions, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnAlbums":
					this.PerformRelatedEntityRemoval(this.SnAlbums, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnFiles":
					this.PerformRelatedEntityRemoval(this.SnFiles, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnNotes":
					this.PerformRelatedEntityRemoval(this.SnNotes, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "UserProfile":
					this.PerformRelatedEntityRemoval(this.UserProfile, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.PrivacyLevelDefinitions);
			toReturn.Add(this.SnAlbums);
			toReturn.Add(this.SnFiles);
			toReturn.Add(this.SnNotes);
			toReturn.Add(this.UserProfile);
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
				info.AddValue("_privacyLevelDefinitions", ((_privacyLevelDefinitions!=null) && (_privacyLevelDefinitions.Count>0) && !this.MarkedForDeletion)?_privacyLevelDefinitions:null);
				info.AddValue("_snAlbums", ((_snAlbums!=null) && (_snAlbums.Count>0) && !this.MarkedForDeletion)?_snAlbums:null);
				info.AddValue("_snFiles", ((_snFiles!=null) && (_snFiles.Count>0) && !this.MarkedForDeletion)?_snFiles:null);
				info.AddValue("_snNotes", ((_snNotes!=null) && (_snNotes.Count>0) && !this.MarkedForDeletion)?_snNotes:null);
				info.AddValue("_userProfile", ((_userProfile!=null) && (_userProfile.Count>0) && !this.MarkedForDeletion)?_userProfile:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new PrivacyLevelRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PrivacyLevelDefinition' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPrivacyLevelDefinitions()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PrivacyLevelDefinitionFields.PrivacyLevelId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnAlbum' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnAlbums()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnAlbumFields.PrivacyLevelId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnFile' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnFiles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnFileFields.PrivacyLevelId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnNote' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnNotes()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnNoteFields.PrivacyLevelId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UserProfile' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserProfile()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserProfileFields.MyStatusPrivacyLevelId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(PrivacyLevelEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._privacyLevelDefinitions);
			collectionsQueue.Enqueue(this._snAlbums);
			collectionsQueue.Enqueue(this._snFiles);
			collectionsQueue.Enqueue(this._snNotes);
			collectionsQueue.Enqueue(this._userProfile);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._privacyLevelDefinitions = (EntityCollection<PrivacyLevelDefinitionEntity>) collectionsQueue.Dequeue();
			this._snAlbums = (EntityCollection<SnAlbumEntity>) collectionsQueue.Dequeue();
			this._snFiles = (EntityCollection<SnFileEntity>) collectionsQueue.Dequeue();
			this._snNotes = (EntityCollection<SnNoteEntity>) collectionsQueue.Dequeue();
			this._userProfile = (EntityCollection<UserProfileEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._privacyLevelDefinitions != null);
			toReturn |=(this._snAlbums != null);
			toReturn |=(this._snFiles != null);
			toReturn |=(this._snNotes != null);
			toReturn |=(this._userProfile != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PrivacyLevelDefinitionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PrivacyLevelDefinitionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnAlbumEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnAlbumEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnFileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFileEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnNoteEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserProfileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserProfileEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("PrivacyLevelDefinitions", _privacyLevelDefinitions);
			toReturn.Add("SnAlbums", _snAlbums);
			toReturn.Add("SnFiles", _snFiles);
			toReturn.Add("SnNotes", _snNotes);
			toReturn.Add("UserProfile", _userProfile);
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
			_fieldsCustomProperties.Add("PrivacyLevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Sort", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateEntered", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Abrv", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PrivacyLevelEntity</param>
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
		public  static PrivacyLevelRelations Relations
		{
			get	{ return new PrivacyLevelRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PrivacyLevelDefinition' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPrivacyLevelDefinitions
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PrivacyLevelDefinitionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PrivacyLevelDefinitionEntityFactory))), (IEntityRelation)GetRelationsForField("PrivacyLevelDefinitions")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity, (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelDefinitionEntity, 0, null, null, null, null, "PrivacyLevelDefinitions", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnAlbum' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnAlbums
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnAlbumEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnAlbumEntityFactory))), (IEntityRelation)GetRelationsForField("SnAlbums")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnAlbumEntity, 0, null, null, null, null, "SnAlbums", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnFile' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnFiles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnFileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnFileEntityFactory))), (IEntityRelation)GetRelationsForField("SnFiles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, 0, null, null, null, null, "SnFiles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnNote' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnNotes
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnNoteEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnNoteEntityFactory))), (IEntityRelation)GetRelationsForField("SnNotes")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnNoteEntity, 0, null, null, null, null, "SnNotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserProfile' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserProfile
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<UserProfileEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserProfileEntityFactory))), (IEntityRelation)GetRelationsForField("UserProfile")[0], (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity, (int)MonoSoftware.MonoX.DAL.EntityType.UserProfileEntity, 0, null, null, null, null, "UserProfile", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
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

		/// <summary> The Id property of the Entity PrivacyLevel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PrivacyLevel"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)PrivacyLevelFieldIndex.Id, true); }
			set	{ SetValue((int)PrivacyLevelFieldIndex.Id, value); }
		}

		/// <summary> The PrivacyLevel property of the Entity PrivacyLevel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PrivacyLevel"."PrivacyLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PrivacyLevel
		{
			get { return (System.String)GetValue((int)PrivacyLevelFieldIndex.PrivacyLevel, true); }
			set	{ SetValue((int)PrivacyLevelFieldIndex.PrivacyLevel, value); }
		}

		/// <summary> The Sort property of the Entity PrivacyLevel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PrivacyLevel"."Sort"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Sort
		{
			get { return (System.Int32)GetValue((int)PrivacyLevelFieldIndex.Sort, true); }
			set	{ SetValue((int)PrivacyLevelFieldIndex.Sort, value); }
		}

		/// <summary> The DateEntered property of the Entity PrivacyLevel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PrivacyLevel"."DateEntered"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateEntered
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PrivacyLevelFieldIndex.DateEntered, false); }
			set	{ SetValue((int)PrivacyLevelFieldIndex.DateEntered, value); }
		}

		/// <summary> The DateModified property of the Entity PrivacyLevel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PrivacyLevel"."DateModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PrivacyLevelFieldIndex.DateModified, false); }
			set	{ SetValue((int)PrivacyLevelFieldIndex.DateModified, value); }
		}

		/// <summary> The Abrv property of the Entity PrivacyLevel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PrivacyLevel"."Abrv"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Abrv
		{
			get { return (System.String)GetValue((int)PrivacyLevelFieldIndex.Abrv, true); }
			set	{ SetValue((int)PrivacyLevelFieldIndex.Abrv, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PrivacyLevelDefinitionEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PrivacyLevelDefinitionEntity))]
		public virtual EntityCollection<PrivacyLevelDefinitionEntity> PrivacyLevelDefinitions
		{
			get { return GetOrCreateEntityCollection<PrivacyLevelDefinitionEntity, PrivacyLevelDefinitionEntityFactory>("PrivacyLevel", true, false, ref _privacyLevelDefinitions);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnAlbumEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnAlbumEntity))]
		public virtual EntityCollection<SnAlbumEntity> SnAlbums
		{
			get { return GetOrCreateEntityCollection<SnAlbumEntity, SnAlbumEntityFactory>("PrivacyLevel", true, false, ref _snAlbums);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnFileEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnFileEntity))]
		public virtual EntityCollection<SnFileEntity> SnFiles
		{
			get { return GetOrCreateEntityCollection<SnFileEntity, SnFileEntityFactory>("PrivacyLevel", true, false, ref _snFiles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnNoteEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnNoteEntity))]
		public virtual EntityCollection<SnNoteEntity> SnNotes
		{
			get { return GetOrCreateEntityCollection<SnNoteEntity, SnNoteEntityFactory>("PrivacyLevel", true, false, ref _snNotes);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserProfileEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UserProfileEntity))]
		public virtual EntityCollection<UserProfileEntity> UserProfile
		{
			get { return GetOrCreateEntityCollection<UserProfileEntity, UserProfileEntityFactory>("PrivacyLevel", true, false, ref _userProfile);	}
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity; }
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
