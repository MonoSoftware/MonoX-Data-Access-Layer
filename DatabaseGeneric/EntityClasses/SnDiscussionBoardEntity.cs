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
	/// <summary>Entity class which represents the entity 'SnDiscussionBoard'.<br/><br/></summary>
	[Serializable]
	public partial class SnDiscussionBoardEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SnDiscussionBoardInRoleEntity> _snDiscussionBoardInRoles;
		private EntityCollection<SnDiscussionBoardModeratorEntity> _snDiscussionBoardModerators;
		private EntityCollection<SnDiscussionTopicEntity> _snDiscussionTopics;
		private EntityCollection<SnEventEntity> _snEvents;
		private EntityCollection<SnRelationshipEntity> _snRelationships;
		private AspnetApplicationsEntity _aspnetApplication;
		private AspnetUsersEntity _aspnetUser;
		private AspnetUsersEntity _pinnedByUser;
		private LanguageEntity _language;
		private SnGroupEntity _snGroup;

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
			/// <summary>Member name PinnedByUser</summary>
			public static readonly string PinnedByUser = "PinnedByUser";
			/// <summary>Member name Language</summary>
			public static readonly string Language = "Language";
			/// <summary>Member name SnGroup</summary>
			public static readonly string SnGroup = "SnGroup";
			/// <summary>Member name SnDiscussionBoardInRoles</summary>
			public static readonly string SnDiscussionBoardInRoles = "SnDiscussionBoardInRoles";
			/// <summary>Member name SnDiscussionBoardModerators</summary>
			public static readonly string SnDiscussionBoardModerators = "SnDiscussionBoardModerators";
			/// <summary>Member name SnDiscussionTopics</summary>
			public static readonly string SnDiscussionTopics = "SnDiscussionTopics";
			/// <summary>Member name SnEvents</summary>
			public static readonly string SnEvents = "SnEvents";
			/// <summary>Member name SnRelationships</summary>
			public static readonly string SnRelationships = "SnRelationships";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SnDiscussionBoardEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SnDiscussionBoardEntity():base("SnDiscussionBoardEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SnDiscussionBoardEntity(IEntityFields2 fields):base("SnDiscussionBoardEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SnDiscussionBoardEntity</param>
		public SnDiscussionBoardEntity(IValidator validator):base("SnDiscussionBoardEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnDiscussionBoard which data should be fetched into this SnDiscussionBoard object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnDiscussionBoardEntity(System.Guid id):base("SnDiscussionBoardEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for SnDiscussionBoard which data should be fetched into this SnDiscussionBoard object</param>
		/// <param name="validator">The custom validator object for this SnDiscussionBoardEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SnDiscussionBoardEntity(System.Guid id, IValidator validator):base("SnDiscussionBoardEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SnDiscussionBoardEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_snDiscussionBoardInRoles = (EntityCollection<SnDiscussionBoardInRoleEntity>)info.GetValue("_snDiscussionBoardInRoles", typeof(EntityCollection<SnDiscussionBoardInRoleEntity>));
				_snDiscussionBoardModerators = (EntityCollection<SnDiscussionBoardModeratorEntity>)info.GetValue("_snDiscussionBoardModerators", typeof(EntityCollection<SnDiscussionBoardModeratorEntity>));
				_snDiscussionTopics = (EntityCollection<SnDiscussionTopicEntity>)info.GetValue("_snDiscussionTopics", typeof(EntityCollection<SnDiscussionTopicEntity>));
				_snEvents = (EntityCollection<SnEventEntity>)info.GetValue("_snEvents", typeof(EntityCollection<SnEventEntity>));
				_snRelationships = (EntityCollection<SnRelationshipEntity>)info.GetValue("_snRelationships", typeof(EntityCollection<SnRelationshipEntity>));
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
				_pinnedByUser = (AspnetUsersEntity)info.GetValue("_pinnedByUser", typeof(AspnetUsersEntity));
				if(_pinnedByUser!=null)
				{
					_pinnedByUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_language = (LanguageEntity)info.GetValue("_language", typeof(LanguageEntity));
				if(_language!=null)
				{
					_language.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_snGroup = (SnGroupEntity)info.GetValue("_snGroup", typeof(SnGroupEntity));
				if(_snGroup!=null)
				{
					_snGroup.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SnDiscussionBoardFieldIndex)fieldIndex)
			{
				case SnDiscussionBoardFieldIndex.ApplicationId:
					DesetupSyncAspnetApplication(true, false);
					break;
				case SnDiscussionBoardFieldIndex.LanguageId:
					DesetupSyncLanguage(true, false);
					break;
				case SnDiscussionBoardFieldIndex.SnGroupId:
					DesetupSyncSnGroup(true, false);
					break;
				case SnDiscussionBoardFieldIndex.UserId:
					DesetupSyncAspnetUser(true, false);
					break;
				case SnDiscussionBoardFieldIndex.PinnedByUserId:
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
				case "AspnetApplication":
					this.AspnetApplication = (AspnetApplicationsEntity)entity;
					break;
				case "AspnetUser":
					this.AspnetUser = (AspnetUsersEntity)entity;
					break;
				case "PinnedByUser":
					this.PinnedByUser = (AspnetUsersEntity)entity;
					break;
				case "Language":
					this.Language = (LanguageEntity)entity;
					break;
				case "SnGroup":
					this.SnGroup = (SnGroupEntity)entity;
					break;
				case "SnDiscussionBoardInRoles":
					this.SnDiscussionBoardInRoles.Add((SnDiscussionBoardInRoleEntity)entity);
					break;
				case "SnDiscussionBoardModerators":
					this.SnDiscussionBoardModerators.Add((SnDiscussionBoardModeratorEntity)entity);
					break;
				case "SnDiscussionTopics":
					this.SnDiscussionTopics.Add((SnDiscussionTopicEntity)entity);
					break;
				case "SnEvents":
					this.SnEvents.Add((SnEventEntity)entity);
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
				case "AspnetApplication":
					toReturn.Add(Relations.AspnetApplicationsEntityUsingApplicationId);
					break;
				case "AspnetUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingUserId);
					break;
				case "PinnedByUser":
					toReturn.Add(Relations.AspnetUsersEntityUsingPinnedByUserId);
					break;
				case "Language":
					toReturn.Add(Relations.LanguageEntityUsingLanguageId);
					break;
				case "SnGroup":
					toReturn.Add(Relations.SnGroupEntityUsingSnGroupId);
					break;
				case "SnDiscussionBoardInRoles":
					toReturn.Add(Relations.SnDiscussionBoardInRoleEntityUsingBoardId);
					break;
				case "SnDiscussionBoardModerators":
					toReturn.Add(Relations.SnDiscussionBoardModeratorEntityUsingSnDiscussionBoardId);
					break;
				case "SnDiscussionTopics":
					toReturn.Add(Relations.SnDiscussionTopicEntityUsingSnDiscussionBoardId);
					break;
				case "SnEvents":
					toReturn.Add(Relations.SnEventEntityUsingSnDiscussionBoardId);
					break;
				case "SnRelationships":
					toReturn.Add(Relations.SnRelationshipEntityUsingDiscussionBoardId);
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
			int numberOfOneWayRelations = 0+1+1+1+1;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				case "AspnetApplication":
					return true;
				case "AspnetUser":
					return true;
				case "PinnedByUser":
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
		protected override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "AspnetApplication":
					SetupSyncAspnetApplication(relatedEntity);
					break;
				case "AspnetUser":
					SetupSyncAspnetUser(relatedEntity);
					break;
				case "PinnedByUser":
					SetupSyncPinnedByUser(relatedEntity);
					break;
				case "Language":
					SetupSyncLanguage(relatedEntity);
					break;
				case "SnGroup":
					SetupSyncSnGroup(relatedEntity);
					break;
				case "SnDiscussionBoardInRoles":
					this.SnDiscussionBoardInRoles.Add((SnDiscussionBoardInRoleEntity)relatedEntity);
					break;
				case "SnDiscussionBoardModerators":
					this.SnDiscussionBoardModerators.Add((SnDiscussionBoardModeratorEntity)relatedEntity);
					break;
				case "SnDiscussionTopics":
					this.SnDiscussionTopics.Add((SnDiscussionTopicEntity)relatedEntity);
					break;
				case "SnEvents":
					this.SnEvents.Add((SnEventEntity)relatedEntity);
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
				case "AspnetApplication":
					DesetupSyncAspnetApplication(false, true);
					break;
				case "AspnetUser":
					DesetupSyncAspnetUser(false, true);
					break;
				case "PinnedByUser":
					DesetupSyncPinnedByUser(false, true);
					break;
				case "Language":
					DesetupSyncLanguage(false, true);
					break;
				case "SnGroup":
					DesetupSyncSnGroup(false, true);
					break;
				case "SnDiscussionBoardInRoles":
					this.PerformRelatedEntityRemoval(this.SnDiscussionBoardInRoles, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnDiscussionBoardModerators":
					this.PerformRelatedEntityRemoval(this.SnDiscussionBoardModerators, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnDiscussionTopics":
					this.PerformRelatedEntityRemoval(this.SnDiscussionTopics, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SnEvents":
					this.PerformRelatedEntityRemoval(this.SnEvents, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_aspnetApplication!=null)
			{
				toReturn.Add(_aspnetApplication);
			}
			if(_aspnetUser!=null)
			{
				toReturn.Add(_aspnetUser);
			}
			if(_pinnedByUser!=null)
			{
				toReturn.Add(_pinnedByUser);
			}
			if(_language!=null)
			{
				toReturn.Add(_language);
			}
			if(_snGroup!=null)
			{
				toReturn.Add(_snGroup);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SnDiscussionBoardInRoles);
			toReturn.Add(this.SnDiscussionBoardModerators);
			toReturn.Add(this.SnDiscussionTopics);
			toReturn.Add(this.SnEvents);
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
				info.AddValue("_snDiscussionBoardInRoles", ((_snDiscussionBoardInRoles!=null) && (_snDiscussionBoardInRoles.Count>0) && !this.MarkedForDeletion)?_snDiscussionBoardInRoles:null);
				info.AddValue("_snDiscussionBoardModerators", ((_snDiscussionBoardModerators!=null) && (_snDiscussionBoardModerators.Count>0) && !this.MarkedForDeletion)?_snDiscussionBoardModerators:null);
				info.AddValue("_snDiscussionTopics", ((_snDiscussionTopics!=null) && (_snDiscussionTopics.Count>0) && !this.MarkedForDeletion)?_snDiscussionTopics:null);
				info.AddValue("_snEvents", ((_snEvents!=null) && (_snEvents.Count>0) && !this.MarkedForDeletion)?_snEvents:null);
				info.AddValue("_snRelationships", ((_snRelationships!=null) && (_snRelationships.Count>0) && !this.MarkedForDeletion)?_snRelationships:null);
				info.AddValue("_aspnetApplication", (!this.MarkedForDeletion?_aspnetApplication:null));
				info.AddValue("_aspnetUser", (!this.MarkedForDeletion?_aspnetUser:null));
				info.AddValue("_pinnedByUser", (!this.MarkedForDeletion?_pinnedByUser:null));
				info.AddValue("_language", (!this.MarkedForDeletion?_language:null));
				info.AddValue("_snGroup", (!this.MarkedForDeletion?_snGroup:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SnDiscussionBoardRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnDiscussionBoardInRole' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionBoardInRoles()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionBoardInRoleFields.BoardId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnDiscussionBoardModerator' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionBoardModerators()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionBoardModeratorFields.SnDiscussionBoardId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnDiscussionTopic' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnDiscussionTopics()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnDiscussionTopicFields.SnDiscussionBoardId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnEvent' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnEvents()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnEventFields.SnDiscussionBoardId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SnRelationship' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnRelationships()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnRelationshipFields.DiscussionBoardId, null, ComparisonOperator.Equal, this.Id));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AspnetUsers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPinnedByUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AspnetUsersFields.UserId, null, ComparisonOperator.Equal, this.PinnedByUserId));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SnGroup' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSnGroup()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SnGroupFields.Id, null, ComparisonOperator.Equal, this.SnGroupId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._snDiscussionBoardInRoles);
			collectionsQueue.Enqueue(this._snDiscussionBoardModerators);
			collectionsQueue.Enqueue(this._snDiscussionTopics);
			collectionsQueue.Enqueue(this._snEvents);
			collectionsQueue.Enqueue(this._snRelationships);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._snDiscussionBoardInRoles = (EntityCollection<SnDiscussionBoardInRoleEntity>) collectionsQueue.Dequeue();
			this._snDiscussionBoardModerators = (EntityCollection<SnDiscussionBoardModeratorEntity>) collectionsQueue.Dequeue();
			this._snDiscussionTopics = (EntityCollection<SnDiscussionTopicEntity>) collectionsQueue.Dequeue();
			this._snEvents = (EntityCollection<SnEventEntity>) collectionsQueue.Dequeue();
			this._snRelationships = (EntityCollection<SnRelationshipEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._snDiscussionBoardInRoles != null);
			toReturn |=(this._snDiscussionBoardModerators != null);
			toReturn |=(this._snDiscussionTopics != null);
			toReturn |=(this._snEvents != null);
			toReturn |=(this._snRelationships != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnDiscussionBoardInRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardInRoleEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnDiscussionBoardModeratorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardModeratorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnDiscussionTopicEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionTopicEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AspnetApplication", _aspnetApplication);
			toReturn.Add("AspnetUser", _aspnetUser);
			toReturn.Add("PinnedByUser", _pinnedByUser);
			toReturn.Add("Language", _language);
			toReturn.Add("SnGroup", _snGroup);
			toReturn.Add("SnDiscussionBoardInRoles", _snDiscussionBoardInRoles);
			toReturn.Add("SnDiscussionBoardModerators", _snDiscussionBoardModerators);
			toReturn.Add("SnDiscussionTopics", _snDiscussionTopics);
			toReturn.Add("SnEvents", _snEvents);
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
			_fieldsCustomProperties.Add("ApplicationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LanguageId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SnGroupId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DailyReportSentOn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsClosed", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsPinned", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PinnedOn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PinnedByUserId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _aspnetApplication</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAspnetApplication(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _aspnetApplication, new PropertyChangedEventHandler( OnAspnetApplicationPropertyChanged ), "AspnetApplication", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnDiscussionBoardFieldIndex.ApplicationId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetApplication, new PropertyChangedEventHandler( OnAspnetApplicationPropertyChanged ), "AspnetApplication", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.AspnetApplicationsEntityUsingApplicationIdStatic, true, new string[] {  } );
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
			this.PerformDesetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.AspnetUsersEntityUsingUserIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnDiscussionBoardFieldIndex.UserId } );
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
				this.PerformSetupSyncRelatedEntity( _aspnetUser, new PropertyChangedEventHandler( OnAspnetUserPropertyChanged ), "AspnetUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.AspnetUsersEntityUsingUserIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _pinnedByUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPinnedByUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _pinnedByUser, new PropertyChangedEventHandler( OnPinnedByUserPropertyChanged ), "PinnedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.AspnetUsersEntityUsingPinnedByUserIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnDiscussionBoardFieldIndex.PinnedByUserId } );
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
				this.PerformSetupSyncRelatedEntity( _pinnedByUser, new PropertyChangedEventHandler( OnPinnedByUserPropertyChanged ), "PinnedByUser", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.AspnetUsersEntityUsingPinnedByUserIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _language</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncLanguage(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _language, new PropertyChangedEventHandler( OnLanguagePropertyChanged ), "Language", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.LanguageEntityUsingLanguageIdStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SnDiscussionBoardFieldIndex.LanguageId } );
			_language = null;
		}

		/// <summary> setups the sync logic for member _language</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncLanguage(IEntity2 relatedEntity)
		{
			if(_language!=relatedEntity)
			{
				DesetupSyncLanguage(true, true);
				_language = (LanguageEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _language, new PropertyChangedEventHandler( OnLanguagePropertyChanged ), "Language", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.LanguageEntityUsingLanguageIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _snGroup</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSnGroup(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _snGroup, new PropertyChangedEventHandler( OnSnGroupPropertyChanged ), "SnGroup", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.SnGroupEntityUsingSnGroupIdStatic, true, signalRelatedEntity, "SnDiscussionBoard", resetFKFields, new int[] { (int)SnDiscussionBoardFieldIndex.SnGroupId } );
			_snGroup = null;
		}

		/// <summary> setups the sync logic for member _snGroup</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSnGroup(IEntity2 relatedEntity)
		{
			if(_snGroup!=relatedEntity)
			{
				DesetupSyncSnGroup(true, true);
				_snGroup = (SnGroupEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _snGroup, new PropertyChangedEventHandler( OnSnGroupPropertyChanged ), "SnGroup", MonoSoftware.MonoX.DAL.RelationClasses.StaticSnDiscussionBoardRelations.SnGroupEntityUsingSnGroupIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSnGroupPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SnDiscussionBoardEntity</param>
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
		public  static SnDiscussionBoardRelations Relations
		{
			get	{ return new SnDiscussionBoardRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionBoardInRole' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionBoardInRoles
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnDiscussionBoardInRoleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardInRoleEntityFactory))), (IEntityRelation)GetRelationsForField("SnDiscussionBoardInRoles")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardInRoleEntity, 0, null, null, null, null, "SnDiscussionBoardInRoles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionBoardModerator' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionBoardModerators
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnDiscussionBoardModeratorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionBoardModeratorEntityFactory))), (IEntityRelation)GetRelationsForField("SnDiscussionBoardModerators")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardModeratorEntity, 0, null, null, null, null, "SnDiscussionBoardModerators", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnDiscussionTopic' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnDiscussionTopics
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnDiscussionTopicEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnDiscussionTopicEntityFactory))), (IEntityRelation)GetRelationsForField("SnDiscussionTopics")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, 0, null, null, null, null, "SnDiscussionTopics", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnEvents
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnEventEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnEventEntityFactory))), (IEntityRelation)GetRelationsForField("SnEvents")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, 0, null, null, null, null, "SnEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnRelationship' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnRelationships
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SnRelationshipEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SnRelationshipEntityFactory))), (IEntityRelation)GetRelationsForField("SnRelationships")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, 0, null, null, null, null, "SnRelationships", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetApplications' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetApplication
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetApplicationsEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetApplication")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, 0, null, null, null, null, "AspnetApplication", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAspnetUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("AspnetUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "AspnetUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AspnetUsers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPinnedByUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AspnetUsersEntityFactory))),	(IEntityRelation)GetRelationsForField("PinnedByUser")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, 0, null, null, null, null, "PinnedByUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Language' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathLanguage
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(LanguageEntityFactory))),	(IEntityRelation)GetRelationsForField("Language")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.LanguageEntity, 0, null, null, null, null, "Language", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SnGroup' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSnGroup
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SnGroupEntityFactory))),	(IEntityRelation)GetRelationsForField("SnGroup")[0], (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, (int)MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, 0, null, null, null, null, "SnGroup", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Id property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)SnDiscussionBoardFieldIndex.Id, true); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.Id, value); }
		}

		/// <summary> The ApplicationId property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."ApplicationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid ApplicationId
		{
			get { return (System.Guid)GetValue((int)SnDiscussionBoardFieldIndex.ApplicationId, true); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.ApplicationId, value); }
		}

		/// <summary> The LanguageId property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."LanguageId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid LanguageId
		{
			get { return (System.Guid)GetValue((int)SnDiscussionBoardFieldIndex.LanguageId, true); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.LanguageId, value); }
		}

		/// <summary> The SnGroupId property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."SnGroupId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> SnGroupId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnDiscussionBoardFieldIndex.SnGroupId, false); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.SnGroupId, value); }
		}

		/// <summary> The Name property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SnDiscussionBoardFieldIndex.Name, true); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.Name, value); }
		}

		/// <summary> The UserId property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> UserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnDiscussionBoardFieldIndex.UserId, false); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.UserId, value); }
		}

		/// <summary> The DateCreated property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)SnDiscussionBoardFieldIndex.DateCreated, true); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.DateCreated, value); }
		}

		/// <summary> The Description property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)SnDiscussionBoardFieldIndex.Description, true); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.Description, value); }
		}

		/// <summary> The DailyReportSentOn property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."DailyReportSentOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DailyReportSentOn
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SnDiscussionBoardFieldIndex.DailyReportSentOn, false); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.DailyReportSentOn, value); }
		}

		/// <summary> The IsClosed property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."IsClosed"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsClosed
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionBoardFieldIndex.IsClosed, true); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.IsClosed, value); }
		}

		/// <summary> The IsPinned property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."IsPinned"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsPinned
		{
			get { return (System.Boolean)GetValue((int)SnDiscussionBoardFieldIndex.IsPinned, true); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.IsPinned, value); }
		}

		/// <summary> The PinnedOn property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."PinnedOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> PinnedOn
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SnDiscussionBoardFieldIndex.PinnedOn, false); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.PinnedOn, value); }
		}

		/// <summary> The PinnedByUserId property of the Entity SnDiscussionBoard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SnDiscussionBoard"."PinnedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> PinnedByUserId
		{
			get { return (Nullable<System.Guid>)GetValue((int)SnDiscussionBoardFieldIndex.PinnedByUserId, false); }
			set	{ SetValue((int)SnDiscussionBoardFieldIndex.PinnedByUserId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnDiscussionBoardInRoleEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnDiscussionBoardInRoleEntity))]
		public virtual EntityCollection<SnDiscussionBoardInRoleEntity> SnDiscussionBoardInRoles
		{
			get { return GetOrCreateEntityCollection<SnDiscussionBoardInRoleEntity, SnDiscussionBoardInRoleEntityFactory>("SnDiscussionBoard", true, false, ref _snDiscussionBoardInRoles);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnDiscussionBoardModeratorEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnDiscussionBoardModeratorEntity))]
		public virtual EntityCollection<SnDiscussionBoardModeratorEntity> SnDiscussionBoardModerators
		{
			get { return GetOrCreateEntityCollection<SnDiscussionBoardModeratorEntity, SnDiscussionBoardModeratorEntityFactory>("SnDiscussionBoard", true, false, ref _snDiscussionBoardModerators);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnDiscussionTopicEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnDiscussionTopicEntity))]
		public virtual EntityCollection<SnDiscussionTopicEntity> SnDiscussionTopics
		{
			get { return GetOrCreateEntityCollection<SnDiscussionTopicEntity, SnDiscussionTopicEntityFactory>("SnDiscussionBoard", true, false, ref _snDiscussionTopics);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnEventEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnEventEntity))]
		public virtual EntityCollection<SnEventEntity> SnEvents
		{
			get { return GetOrCreateEntityCollection<SnEventEntity, SnEventEntityFactory>("SnDiscussionBoard", true, false, ref _snEvents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SnRelationshipEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SnRelationshipEntity))]
		public virtual EntityCollection<SnRelationshipEntity> SnRelationships
		{
			get { return GetOrCreateEntityCollection<SnRelationshipEntity, SnRelationshipEntityFactory>("SnDiscussionBoard", true, false, ref _snRelationships);	}
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
					SetSingleRelatedEntityNavigator(value, "", "AspnetUser", _aspnetUser, false); 
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
					SetSingleRelatedEntityNavigator(value, "", "PinnedByUser", _pinnedByUser, false); 
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

		/// <summary> Gets / sets related entity of type 'SnGroupEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SnGroupEntity SnGroup
		{
			get	{ return _snGroup; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSnGroup(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SnDiscussionBoard", "SnGroup", _snGroup, true); 
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
			get { return (int)MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity; }
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
