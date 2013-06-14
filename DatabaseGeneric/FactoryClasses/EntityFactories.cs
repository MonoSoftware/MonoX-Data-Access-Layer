﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using MonoSoftware.MonoX.DAL.EntityClasses;
using MonoSoftware.MonoX.DAL.HelperClasses;
using MonoSoftware.MonoX.DAL.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace MonoSoftware.MonoX.DAL.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2<TEntity> : EntityFactoryCore2
		where TEntity : EntityBase2, IEntity2
	{
		private readonly MonoSoftware.MonoX.DAL.EntityType _typeOfEntity;
		private readonly bool _isInHierarchy;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <param name="isInHierarchy">If true, the entity of this factory is in an inheritance hierarchy, false otherwise</param>
		public EntityFactoryBase2(string entityName, MonoSoftware.MonoX.DAL.EntityType typeOfEntity, bool isInHierarchy) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
			_isInHierarchy = isInHierarchy;
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public override IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}
		
		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((MonoSoftware.MonoX.DAL.EntityType)entityTypeValue);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(this.ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			IEntityFactory2 toReturn = (IEntityFactory2)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(this.ForEntityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <param name="objectAlias">The object alias to use for the predicate(s).</param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);
		}
						
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity which this factory belongs to.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TEntity>(this);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields2 CreateHierarchyFields() 
		{
			return _isInHierarchy ? new EntityFields2(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields(this.ForEntityName), InheritanceInfoProviderSingleton.GetInstance(), null) : base.CreateHierarchyFields();
		}
	}

	/// <summary>Factory to create new, empty AdEntity objects.</summary>
	[Serializable]
	public partial class AdEntityFactory : EntityFactoryBase2<AdEntity> {
		/// <summary>CTor</summary>
		public AdEntityFactory() : base("AdEntity", MonoSoftware.MonoX.DAL.EntityType.AdEntity, false) { }
		
		/// <summary>Creates a new AdEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AdEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAdUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AdPageEntity objects.</summary>
	[Serializable]
	public partial class AdPageEntityFactory : EntityFactoryBase2<AdPageEntity> {
		/// <summary>CTor</summary>
		public AdPageEntityFactory() : base("AdPageEntity", MonoSoftware.MonoX.DAL.EntityType.AdPageEntity, false) { }
		
		/// <summary>Creates a new AdPageEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AdPageEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAdPageUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetApplicationsEntity objects.</summary>
	[Serializable]
	public partial class AspnetApplicationsEntityFactory : EntityFactoryBase2<AspnetApplicationsEntity> {
		/// <summary>CTor</summary>
		public AspnetApplicationsEntityFactory() : base("AspnetApplicationsEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity, false) { }
		
		/// <summary>Creates a new AspnetApplicationsEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetApplicationsEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetApplicationsUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetMembershipEntity objects.</summary>
	[Serializable]
	public partial class AspnetMembershipEntityFactory : EntityFactoryBase2<AspnetMembershipEntity> {
		/// <summary>CTor</summary>
		public AspnetMembershipEntityFactory() : base("AspnetMembershipEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetMembershipEntity, false) { }
		
		/// <summary>Creates a new AspnetMembershipEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetMembershipEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetMembershipUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetPathsEntity objects.</summary>
	[Serializable]
	public partial class AspnetPathsEntityFactory : EntityFactoryBase2<AspnetPathsEntity> {
		/// <summary>CTor</summary>
		public AspnetPathsEntityFactory() : base("AspnetPathsEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetPathsEntity, false) { }
		
		/// <summary>Creates a new AspnetPathsEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetPathsEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetPathsUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetPersonalizationAllUsersEntity objects.</summary>
	[Serializable]
	public partial class AspnetPersonalizationAllUsersEntityFactory : EntityFactoryBase2<AspnetPersonalizationAllUsersEntity> {
		/// <summary>CTor</summary>
		public AspnetPersonalizationAllUsersEntityFactory() : base("AspnetPersonalizationAllUsersEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetPersonalizationAllUsersEntity, false) { }
		
		/// <summary>Creates a new AspnetPersonalizationAllUsersEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetPersonalizationAllUsersEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetPersonalizationAllUsersUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetPersonalizationPerUserEntity objects.</summary>
	[Serializable]
	public partial class AspnetPersonalizationPerUserEntityFactory : EntityFactoryBase2<AspnetPersonalizationPerUserEntity> {
		/// <summary>CTor</summary>
		public AspnetPersonalizationPerUserEntityFactory() : base("AspnetPersonalizationPerUserEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetPersonalizationPerUserEntity, false) { }
		
		/// <summary>Creates a new AspnetPersonalizationPerUserEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetPersonalizationPerUserEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetPersonalizationPerUserUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetProfileEntity objects.</summary>
	[Serializable]
	public partial class AspnetProfileEntityFactory : EntityFactoryBase2<AspnetProfileEntity> {
		/// <summary>CTor</summary>
		public AspnetProfileEntityFactory() : base("AspnetProfileEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetProfileEntity, false) { }
		
		/// <summary>Creates a new AspnetProfileEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetProfileEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetProfileUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetRolesEntity objects.</summary>
	[Serializable]
	public partial class AspnetRolesEntityFactory : EntityFactoryBase2<AspnetRolesEntity> {
		/// <summary>CTor</summary>
		public AspnetRolesEntityFactory() : base("AspnetRolesEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetRolesEntity, false) { }
		
		/// <summary>Creates a new AspnetRolesEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetRolesEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetRolesUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetSchemaVersionsEntity objects.</summary>
	[Serializable]
	public partial class AspnetSchemaVersionsEntityFactory : EntityFactoryBase2<AspnetSchemaVersionsEntity> {
		/// <summary>CTor</summary>
		public AspnetSchemaVersionsEntityFactory() : base("AspnetSchemaVersionsEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetSchemaVersionsEntity, false) { }
		
		/// <summary>Creates a new AspnetSchemaVersionsEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetSchemaVersionsEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetSchemaVersionsUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetUsersEntity objects.</summary>
	[Serializable]
	public partial class AspnetUsersEntityFactory : EntityFactoryBase2<AspnetUsersEntity> {
		/// <summary>CTor</summary>
		public AspnetUsersEntityFactory() : base("AspnetUsersEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity, false) { }
		
		/// <summary>Creates a new AspnetUsersEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetUsersEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetUsersUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetUsersInRolesEntity objects.</summary>
	[Serializable]
	public partial class AspnetUsersInRolesEntityFactory : EntityFactoryBase2<AspnetUsersInRolesEntity> {
		/// <summary>CTor</summary>
		public AspnetUsersInRolesEntityFactory() : base("AspnetUsersInRolesEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetUsersInRolesEntity, false) { }
		
		/// <summary>Creates a new AspnetUsersInRolesEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetUsersInRolesEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetUsersInRolesUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AspnetWebEventEventsEntity objects.</summary>
	[Serializable]
	public partial class AspnetWebEventEventsEntityFactory : EntityFactoryBase2<AspnetWebEventEventsEntity> {
		/// <summary>CTor</summary>
		public AspnetWebEventEventsEntityFactory() : base("AspnetWebEventEventsEntity", MonoSoftware.MonoX.DAL.EntityType.AspnetWebEventEventsEntity, false) { }
		
		/// <summary>Creates a new AspnetWebEventEventsEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AspnetWebEventEventsEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAspnetWebEventEventsUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BlogEntity objects.</summary>
	[Serializable]
	public partial class BlogEntityFactory : EntityFactoryBase2<BlogEntity> {
		/// <summary>CTor</summary>
		public BlogEntityFactory() : base("BlogEntity", MonoSoftware.MonoX.DAL.EntityType.BlogEntity, false) { }
		
		/// <summary>Creates a new BlogEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BlogEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBlogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BlogCategoryEntity objects.</summary>
	[Serializable]
	public partial class BlogCategoryEntityFactory : EntityFactoryBase2<BlogCategoryEntity> {
		/// <summary>CTor</summary>
		public BlogCategoryEntityFactory() : base("BlogCategoryEntity", MonoSoftware.MonoX.DAL.EntityType.BlogCategoryEntity, false) { }
		
		/// <summary>Creates a new BlogCategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BlogCategoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBlogCategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BlogEditorEntity objects.</summary>
	[Serializable]
	public partial class BlogEditorEntityFactory : EntityFactoryBase2<BlogEditorEntity> {
		/// <summary>CTor</summary>
		public BlogEditorEntityFactory() : base("BlogEditorEntity", MonoSoftware.MonoX.DAL.EntityType.BlogEditorEntity, false) { }
		
		/// <summary>Creates a new BlogEditorEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BlogEditorEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBlogEditorUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BlogPostEntity objects.</summary>
	[Serializable]
	public partial class BlogPostEntityFactory : EntityFactoryBase2<BlogPostEntity> {
		/// <summary>CTor</summary>
		public BlogPostEntityFactory() : base("BlogPostEntity", MonoSoftware.MonoX.DAL.EntityType.BlogPostEntity, false) { }
		
		/// <summary>Creates a new BlogPostEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BlogPostEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBlogPostUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BlogPostCategoryEntity objects.</summary>
	[Serializable]
	public partial class BlogPostCategoryEntityFactory : EntityFactoryBase2<BlogPostCategoryEntity> {
		/// <summary>CTor</summary>
		public BlogPostCategoryEntityFactory() : base("BlogPostCategoryEntity", MonoSoftware.MonoX.DAL.EntityType.BlogPostCategoryEntity, false) { }
		
		/// <summary>Creates a new BlogPostCategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BlogPostCategoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBlogPostCategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BlogPostRoleEntity objects.</summary>
	[Serializable]
	public partial class BlogPostRoleEntityFactory : EntityFactoryBase2<BlogPostRoleEntity> {
		/// <summary>CTor</summary>
		public BlogPostRoleEntityFactory() : base("BlogPostRoleEntity", MonoSoftware.MonoX.DAL.EntityType.BlogPostRoleEntity, false) { }
		
		/// <summary>Creates a new BlogPostRoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BlogPostRoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBlogPostRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CalendarEntity objects.</summary>
	[Serializable]
	public partial class CalendarEntityFactory : EntityFactoryBase2<CalendarEntity> {
		/// <summary>CTor</summary>
		public CalendarEntityFactory() : base("CalendarEntity", MonoSoftware.MonoX.DAL.EntityType.CalendarEntity, false) { }
		
		/// <summary>Creates a new CalendarEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CalendarEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCalendarUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CalendarEditRoleEntity objects.</summary>
	[Serializable]
	public partial class CalendarEditRoleEntityFactory : EntityFactoryBase2<CalendarEditRoleEntity> {
		/// <summary>CTor</summary>
		public CalendarEditRoleEntityFactory() : base("CalendarEditRoleEntity", MonoSoftware.MonoX.DAL.EntityType.CalendarEditRoleEntity, false) { }
		
		/// <summary>Creates a new CalendarEditRoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CalendarEditRoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCalendarEditRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CalendarEventEntity objects.</summary>
	[Serializable]
	public partial class CalendarEventEntityFactory : EntityFactoryBase2<CalendarEventEntity> {
		/// <summary>CTor</summary>
		public CalendarEventEntityFactory() : base("CalendarEventEntity", MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity, false) { }
		
		/// <summary>Creates a new CalendarEventEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CalendarEventEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCalendarEventUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CalendarEventEntryEntity objects.</summary>
	[Serializable]
	public partial class CalendarEventEntryEntityFactory : EntityFactoryBase2<CalendarEventEntryEntity> {
		/// <summary>CTor</summary>
		public CalendarEventEntryEntityFactory() : base("CalendarEventEntryEntity", MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntryEntity, false) { }
		
		/// <summary>Creates a new CalendarEventEntryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CalendarEventEntryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCalendarEventEntryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CalendarEventRecurringDefinitionEntity objects.</summary>
	[Serializable]
	public partial class CalendarEventRecurringDefinitionEntityFactory : EntityFactoryBase2<CalendarEventRecurringDefinitionEntity> {
		/// <summary>CTor</summary>
		public CalendarEventRecurringDefinitionEntityFactory() : base("CalendarEventRecurringDefinitionEntity", MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionEntity, false) { }
		
		/// <summary>Creates a new CalendarEventRecurringDefinitionEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CalendarEventRecurringDefinitionEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCalendarEventRecurringDefinitionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CalendarEventRecurringDefinitionTypeEntity objects.</summary>
	[Serializable]
	public partial class CalendarEventRecurringDefinitionTypeEntityFactory : EntityFactoryBase2<CalendarEventRecurringDefinitionTypeEntity> {
		/// <summary>CTor</summary>
		public CalendarEventRecurringDefinitionTypeEntityFactory() : base("CalendarEventRecurringDefinitionTypeEntity", MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionTypeEntity, false) { }
		
		/// <summary>Creates a new CalendarEventRecurringDefinitionTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CalendarEventRecurringDefinitionTypeEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCalendarEventRecurringDefinitionTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CalendarModeratorEntity objects.</summary>
	[Serializable]
	public partial class CalendarModeratorEntityFactory : EntityFactoryBase2<CalendarModeratorEntity> {
		/// <summary>CTor</summary>
		public CalendarModeratorEntityFactory() : base("CalendarModeratorEntity", MonoSoftware.MonoX.DAL.EntityType.CalendarModeratorEntity, false) { }
		
		/// <summary>Creates a new CalendarModeratorEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CalendarModeratorEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCalendarModeratorUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CalendarViewRoleEntity objects.</summary>
	[Serializable]
	public partial class CalendarViewRoleEntityFactory : EntityFactoryBase2<CalendarViewRoleEntity> {
		/// <summary>CTor</summary>
		public CalendarViewRoleEntityFactory() : base("CalendarViewRoleEntity", MonoSoftware.MonoX.DAL.EntityType.CalendarViewRoleEntity, false) { }
		
		/// <summary>Creates a new CalendarViewRoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CalendarViewRoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCalendarViewRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CampaignEntity objects.</summary>
	[Serializable]
	public partial class CampaignEntityFactory : EntityFactoryBase2<CampaignEntity> {
		/// <summary>CTor</summary>
		public CampaignEntityFactory() : base("CampaignEntity", MonoSoftware.MonoX.DAL.EntityType.CampaignEntity, false) { }
		
		/// <summary>Creates a new CampaignEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CampaignEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCampaignUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty DocumentEntity objects.</summary>
	[Serializable]
	public partial class DocumentEntityFactory : EntityFactoryBase2<DocumentEntity> {
		/// <summary>CTor</summary>
		public DocumentEntityFactory() : base("DocumentEntity", MonoSoftware.MonoX.DAL.EntityType.DocumentEntity, false) { }
		
		/// <summary>Creates a new DocumentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DocumentEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDocumentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty FriendSuggestionTypedViewEntryEntity objects.</summary>
	[Serializable]
	public partial class FriendSuggestionTypedViewEntryEntityFactory : EntityFactoryBase2<FriendSuggestionTypedViewEntryEntity> {
		/// <summary>CTor</summary>
		public FriendSuggestionTypedViewEntryEntityFactory() : base("FriendSuggestionTypedViewEntryEntity", MonoSoftware.MonoX.DAL.EntityType.FriendSuggestionTypedViewEntryEntity, false) { }
		
		/// <summary>Creates a new FriendSuggestionTypedViewEntryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new FriendSuggestionTypedViewEntryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewFriendSuggestionTypedViewEntryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty LanguageEntity objects.</summary>
	[Serializable]
	public partial class LanguageEntityFactory : EntityFactoryBase2<LanguageEntity> {
		/// <summary>CTor</summary>
		public LanguageEntityFactory() : base("LanguageEntity", MonoSoftware.MonoX.DAL.EntityType.LanguageEntity, false) { }
		
		/// <summary>Creates a new LanguageEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new LanguageEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLanguageUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ListEntity objects.</summary>
	[Serializable]
	public partial class ListEntityFactory : EntityFactoryBase2<ListEntity> {
		/// <summary>CTor</summary>
		public ListEntityFactory() : base("ListEntity", MonoSoftware.MonoX.DAL.EntityType.ListEntity, false) { }
		
		/// <summary>Creates a new ListEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ListEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewListUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ListItemEntity objects.</summary>
	[Serializable]
	public partial class ListItemEntityFactory : EntityFactoryBase2<ListItemEntity> {
		/// <summary>CTor</summary>
		public ListItemEntityFactory() : base("ListItemEntity", MonoSoftware.MonoX.DAL.EntityType.ListItemEntity, false) { }
		
		/// <summary>Creates a new ListItemEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ListItemEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewListItemUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ListItemLocalizationEntity objects.</summary>
	[Serializable]
	public partial class ListItemLocalizationEntityFactory : EntityFactoryBase2<ListItemLocalizationEntity> {
		/// <summary>CTor</summary>
		public ListItemLocalizationEntityFactory() : base("ListItemLocalizationEntity", MonoSoftware.MonoX.DAL.EntityType.ListItemLocalizationEntity, false) { }
		
		/// <summary>Creates a new ListItemLocalizationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ListItemLocalizationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewListItemLocalizationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty LocalizationBinaryEntity objects.</summary>
	[Serializable]
	public partial class LocalizationBinaryEntityFactory : EntityFactoryBase2<LocalizationBinaryEntity> {
		/// <summary>CTor</summary>
		public LocalizationBinaryEntityFactory() : base("LocalizationBinaryEntity", MonoSoftware.MonoX.DAL.EntityType.LocalizationBinaryEntity, false) { }
		
		/// <summary>Creates a new LocalizationBinaryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new LocalizationBinaryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLocalizationBinaryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty LocalizationSourceEntity objects.</summary>
	[Serializable]
	public partial class LocalizationSourceEntityFactory : EntityFactoryBase2<LocalizationSourceEntity> {
		/// <summary>CTor</summary>
		public LocalizationSourceEntityFactory() : base("LocalizationSourceEntity", MonoSoftware.MonoX.DAL.EntityType.LocalizationSourceEntity, false) { }
		
		/// <summary>Creates a new LocalizationSourceEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new LocalizationSourceEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLocalizationSourceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty LocalizationStringEntity objects.</summary>
	[Serializable]
	public partial class LocalizationStringEntityFactory : EntityFactoryBase2<LocalizationStringEntity> {
		/// <summary>CTor</summary>
		public LocalizationStringEntityFactory() : base("LocalizationStringEntity", MonoSoftware.MonoX.DAL.EntityType.LocalizationStringEntity, false) { }
		
		/// <summary>Creates a new LocalizationStringEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new LocalizationStringEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLocalizationStringUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NavigationEntity objects.</summary>
	[Serializable]
	public partial class NavigationEntityFactory : EntityFactoryBase2<NavigationEntity> {
		/// <summary>CTor</summary>
		public NavigationEntityFactory() : base("NavigationEntity", MonoSoftware.MonoX.DAL.EntityType.NavigationEntity, false) { }
		
		/// <summary>Creates a new NavigationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NavigationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNavigationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NavigationLocalizationEntity objects.</summary>
	[Serializable]
	public partial class NavigationLocalizationEntityFactory : EntityFactoryBase2<NavigationLocalizationEntity> {
		/// <summary>CTor</summary>
		public NavigationLocalizationEntityFactory() : base("NavigationLocalizationEntity", MonoSoftware.MonoX.DAL.EntityType.NavigationLocalizationEntity, false) { }
		
		/// <summary>Creates a new NavigationLocalizationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NavigationLocalizationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNavigationLocalizationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NavigationRoleEntity objects.</summary>
	[Serializable]
	public partial class NavigationRoleEntityFactory : EntityFactoryBase2<NavigationRoleEntity> {
		/// <summary>CTor</summary>
		public NavigationRoleEntityFactory() : base("NavigationRoleEntity", MonoSoftware.MonoX.DAL.EntityType.NavigationRoleEntity, false) { }
		
		/// <summary>Creates a new NavigationRoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NavigationRoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNavigationRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsCategoryEntity objects.</summary>
	[Serializable]
	public partial class NewsCategoryEntityFactory : EntityFactoryBase2<NewsCategoryEntity> {
		/// <summary>CTor</summary>
		public NewsCategoryEntityFactory() : base("NewsCategoryEntity", MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity, false) { }
		
		/// <summary>Creates a new NewsCategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsCategoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsCategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsCategoryInRoleEntity objects.</summary>
	[Serializable]
	public partial class NewsCategoryInRoleEntityFactory : EntityFactoryBase2<NewsCategoryInRoleEntity> {
		/// <summary>CTor</summary>
		public NewsCategoryInRoleEntityFactory() : base("NewsCategoryInRoleEntity", MonoSoftware.MonoX.DAL.EntityType.NewsCategoryInRoleEntity, false) { }
		
		/// <summary>Creates a new NewsCategoryInRoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsCategoryInRoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsCategoryInRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsCategoryLocalizationEntity objects.</summary>
	[Serializable]
	public partial class NewsCategoryLocalizationEntityFactory : EntityFactoryBase2<NewsCategoryLocalizationEntity> {
		/// <summary>CTor</summary>
		public NewsCategoryLocalizationEntityFactory() : base("NewsCategoryLocalizationEntity", MonoSoftware.MonoX.DAL.EntityType.NewsCategoryLocalizationEntity, false) { }
		
		/// <summary>Creates a new NewsCategoryLocalizationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsCategoryLocalizationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsCategoryLocalizationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsCategoryTemplateEntity objects.</summary>
	[Serializable]
	public partial class NewsCategoryTemplateEntityFactory : EntityFactoryBase2<NewsCategoryTemplateEntity> {
		/// <summary>CTor</summary>
		public NewsCategoryTemplateEntityFactory() : base("NewsCategoryTemplateEntity", MonoSoftware.MonoX.DAL.EntityType.NewsCategoryTemplateEntity, false) { }
		
		/// <summary>Creates a new NewsCategoryTemplateEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsCategoryTemplateEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsCategoryTemplateUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsFileEntity objects.</summary>
	[Serializable]
	public partial class NewsFileEntityFactory : EntityFactoryBase2<NewsFileEntity> {
		/// <summary>CTor</summary>
		public NewsFileEntityFactory() : base("NewsFileEntity", MonoSoftware.MonoX.DAL.EntityType.NewsFileEntity, false) { }
		
		/// <summary>Creates a new NewsFileEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsFileEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsFileUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsItemEntity objects.</summary>
	[Serializable]
	public partial class NewsItemEntityFactory : EntityFactoryBase2<NewsItemEntity> {
		/// <summary>CTor</summary>
		public NewsItemEntityFactory() : base("NewsItemEntity", MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity, false) { }
		
		/// <summary>Creates a new NewsItemEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsItemEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsItemUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsItemLocalizationEntity objects.</summary>
	[Serializable]
	public partial class NewsItemLocalizationEntityFactory : EntityFactoryBase2<NewsItemLocalizationEntity> {
		/// <summary>CTor</summary>
		public NewsItemLocalizationEntityFactory() : base("NewsItemLocalizationEntity", MonoSoftware.MonoX.DAL.EntityType.NewsItemLocalizationEntity, false) { }
		
		/// <summary>Creates a new NewsItemLocalizationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsItemLocalizationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsItemLocalizationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsletterEntity objects.</summary>
	[Serializable]
	public partial class NewsletterEntityFactory : EntityFactoryBase2<NewsletterEntity> {
		/// <summary>CTor</summary>
		public NewsletterEntityFactory() : base("NewsletterEntity", MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity, false) { }
		
		/// <summary>Creates a new NewsletterEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsletterEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsletterUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsletterLogEntity objects.</summary>
	[Serializable]
	public partial class NewsletterLogEntityFactory : EntityFactoryBase2<NewsletterLogEntity> {
		/// <summary>CTor</summary>
		public NewsletterLogEntityFactory() : base("NewsletterLogEntity", MonoSoftware.MonoX.DAL.EntityType.NewsletterLogEntity, false) { }
		
		/// <summary>Creates a new NewsletterLogEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsletterLogEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsletterLogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsletterRoleEntity objects.</summary>
	[Serializable]
	public partial class NewsletterRoleEntityFactory : EntityFactoryBase2<NewsletterRoleEntity> {
		/// <summary>CTor</summary>
		public NewsletterRoleEntityFactory() : base("NewsletterRoleEntity", MonoSoftware.MonoX.DAL.EntityType.NewsletterRoleEntity, false) { }
		
		/// <summary>Creates a new NewsletterRoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsletterRoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsletterRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsMetaIgnoredWordEntity objects.</summary>
	[Serializable]
	public partial class NewsMetaIgnoredWordEntityFactory : EntityFactoryBase2<NewsMetaIgnoredWordEntity> {
		/// <summary>CTor</summary>
		public NewsMetaIgnoredWordEntityFactory() : base("NewsMetaIgnoredWordEntity", MonoSoftware.MonoX.DAL.EntityType.NewsMetaIgnoredWordEntity, false) { }
		
		/// <summary>Creates a new NewsMetaIgnoredWordEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsMetaIgnoredWordEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsMetaIgnoredWordUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty NewsPublishQueueEntity objects.</summary>
	[Serializable]
	public partial class NewsPublishQueueEntityFactory : EntityFactoryBase2<NewsPublishQueueEntity> {
		/// <summary>CTor</summary>
		public NewsPublishQueueEntityFactory() : base("NewsPublishQueueEntity", MonoSoftware.MonoX.DAL.EntityType.NewsPublishQueueEntity, false) { }
		
		/// <summary>Creates a new NewsPublishQueueEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NewsPublishQueueEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNewsPublishQueueUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty OaConsumerEntity objects.</summary>
	[Serializable]
	public partial class OaConsumerEntityFactory : EntityFactoryBase2<OaConsumerEntity> {
		/// <summary>CTor</summary>
		public OaConsumerEntityFactory() : base("OaConsumerEntity", MonoSoftware.MonoX.DAL.EntityType.OaConsumerEntity, false) { }
		
		/// <summary>Creates a new OaConsumerEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new OaConsumerEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOaConsumerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty OaTokenEntity objects.</summary>
	[Serializable]
	public partial class OaTokenEntityFactory : EntityFactoryBase2<OaTokenEntity> {
		/// <summary>CTor</summary>
		public OaTokenEntityFactory() : base("OaTokenEntity", MonoSoftware.MonoX.DAL.EntityType.OaTokenEntity, false) { }
		
		/// <summary>Creates a new OaTokenEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new OaTokenEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOaTokenUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PageEntity objects.</summary>
	[Serializable]
	public partial class PageEntityFactory : EntityFactoryBase2<PageEntity> {
		/// <summary>CTor</summary>
		public PageEntityFactory() : base("PageEntity", MonoSoftware.MonoX.DAL.EntityType.PageEntity, false) { }
		
		/// <summary>Creates a new PageEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PageEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPageUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PageEditRoleEntity objects.</summary>
	[Serializable]
	public partial class PageEditRoleEntityFactory : EntityFactoryBase2<PageEditRoleEntity> {
		/// <summary>CTor</summary>
		public PageEditRoleEntityFactory() : base("PageEditRoleEntity", MonoSoftware.MonoX.DAL.EntityType.PageEditRoleEntity, false) { }
		
		/// <summary>Creates a new PageEditRoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PageEditRoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPageEditRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PageLocalizationEntity objects.</summary>
	[Serializable]
	public partial class PageLocalizationEntityFactory : EntityFactoryBase2<PageLocalizationEntity> {
		/// <summary>CTor</summary>
		public PageLocalizationEntityFactory() : base("PageLocalizationEntity", MonoSoftware.MonoX.DAL.EntityType.PageLocalizationEntity, false) { }
		
		/// <summary>Creates a new PageLocalizationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PageLocalizationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPageLocalizationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PageRoleEntity objects.</summary>
	[Serializable]
	public partial class PageRoleEntityFactory : EntityFactoryBase2<PageRoleEntity> {
		/// <summary>CTor</summary>
		public PageRoleEntityFactory() : base("PageRoleEntity", MonoSoftware.MonoX.DAL.EntityType.PageRoleEntity, false) { }
		
		/// <summary>Creates a new PageRoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PageRoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPageRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PollEntity objects.</summary>
	[Serializable]
	public partial class PollEntityFactory : EntityFactoryBase2<PollEntity> {
		/// <summary>CTor</summary>
		public PollEntityFactory() : base("PollEntity", MonoSoftware.MonoX.DAL.EntityType.PollEntity, false) { }
		
		/// <summary>Creates a new PollEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PollEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPollUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PollAnswerEntity objects.</summary>
	[Serializable]
	public partial class PollAnswerEntityFactory : EntityFactoryBase2<PollAnswerEntity> {
		/// <summary>CTor</summary>
		public PollAnswerEntityFactory() : base("PollAnswerEntity", MonoSoftware.MonoX.DAL.EntityType.PollAnswerEntity, false) { }
		
		/// <summary>Creates a new PollAnswerEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PollAnswerEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPollAnswerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PollAnswerLocalizationEntity objects.</summary>
	[Serializable]
	public partial class PollAnswerLocalizationEntityFactory : EntityFactoryBase2<PollAnswerLocalizationEntity> {
		/// <summary>CTor</summary>
		public PollAnswerLocalizationEntityFactory() : base("PollAnswerLocalizationEntity", MonoSoftware.MonoX.DAL.EntityType.PollAnswerLocalizationEntity, false) { }
		
		/// <summary>Creates a new PollAnswerLocalizationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PollAnswerLocalizationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPollAnswerLocalizationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PollLocalizationEntity objects.</summary>
	[Serializable]
	public partial class PollLocalizationEntityFactory : EntityFactoryBase2<PollLocalizationEntity> {
		/// <summary>CTor</summary>
		public PollLocalizationEntityFactory() : base("PollLocalizationEntity", MonoSoftware.MonoX.DAL.EntityType.PollLocalizationEntity, false) { }
		
		/// <summary>Creates a new PollLocalizationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PollLocalizationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPollLocalizationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PrivacyLevelEntity objects.</summary>
	[Serializable]
	public partial class PrivacyLevelEntityFactory : EntityFactoryBase2<PrivacyLevelEntity> {
		/// <summary>CTor</summary>
		public PrivacyLevelEntityFactory() : base("PrivacyLevelEntity", MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity, false) { }
		
		/// <summary>Creates a new PrivacyLevelEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PrivacyLevelEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPrivacyLevelUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PrivacyLevelDefinitionEntity objects.</summary>
	[Serializable]
	public partial class PrivacyLevelDefinitionEntityFactory : EntityFactoryBase2<PrivacyLevelDefinitionEntity> {
		/// <summary>CTor</summary>
		public PrivacyLevelDefinitionEntityFactory() : base("PrivacyLevelDefinitionEntity", MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelDefinitionEntity, false) { }
		
		/// <summary>Creates a new PrivacyLevelDefinitionEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PrivacyLevelDefinitionEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPrivacyLevelDefinitionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnAlbumEntity objects.</summary>
	[Serializable]
	public partial class SnAlbumEntityFactory : EntityFactoryBase2<SnAlbumEntity> {
		/// <summary>CTor</summary>
		public SnAlbumEntityFactory() : base("SnAlbumEntity", MonoSoftware.MonoX.DAL.EntityType.SnAlbumEntity, false) { }
		
		/// <summary>Creates a new SnAlbumEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnAlbumEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnAlbumUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnBlockUserEntity objects.</summary>
	[Serializable]
	public partial class SnBlockUserEntityFactory : EntityFactoryBase2<SnBlockUserEntity> {
		/// <summary>CTor</summary>
		public SnBlockUserEntityFactory() : base("SnBlockUserEntity", MonoSoftware.MonoX.DAL.EntityType.SnBlockUserEntity, false) { }
		
		/// <summary>Creates a new SnBlockUserEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnBlockUserEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnBlockUserUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnCommentEntity objects.</summary>
	[Serializable]
	public partial class SnCommentEntityFactory : EntityFactoryBase2<SnCommentEntity> {
		/// <summary>CTor</summary>
		public SnCommentEntityFactory() : base("SnCommentEntity", MonoSoftware.MonoX.DAL.EntityType.SnCommentEntity, false) { }
		
		/// <summary>Creates a new SnCommentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnCommentEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnCommentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnDiscussionBoardEntity objects.</summary>
	[Serializable]
	public partial class SnDiscussionBoardEntityFactory : EntityFactoryBase2<SnDiscussionBoardEntity> {
		/// <summary>CTor</summary>
		public SnDiscussionBoardEntityFactory() : base("SnDiscussionBoardEntity", MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity, false) { }
		
		/// <summary>Creates a new SnDiscussionBoardEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnDiscussionBoardEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnDiscussionBoardUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnDiscussionBoardInRoleEntity objects.</summary>
	[Serializable]
	public partial class SnDiscussionBoardInRoleEntityFactory : EntityFactoryBase2<SnDiscussionBoardInRoleEntity> {
		/// <summary>CTor</summary>
		public SnDiscussionBoardInRoleEntityFactory() : base("SnDiscussionBoardInRoleEntity", MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardInRoleEntity, false) { }
		
		/// <summary>Creates a new SnDiscussionBoardInRoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnDiscussionBoardInRoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnDiscussionBoardInRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnDiscussionBoardModeratorEntity objects.</summary>
	[Serializable]
	public partial class SnDiscussionBoardModeratorEntityFactory : EntityFactoryBase2<SnDiscussionBoardModeratorEntity> {
		/// <summary>CTor</summary>
		public SnDiscussionBoardModeratorEntityFactory() : base("SnDiscussionBoardModeratorEntity", MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardModeratorEntity, false) { }
		
		/// <summary>Creates a new SnDiscussionBoardModeratorEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnDiscussionBoardModeratorEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnDiscussionBoardModeratorUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnDiscussionMessageEntity objects.</summary>
	[Serializable]
	public partial class SnDiscussionMessageEntityFactory : EntityFactoryBase2<SnDiscussionMessageEntity> {
		/// <summary>CTor</summary>
		public SnDiscussionMessageEntityFactory() : base("SnDiscussionMessageEntity", MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity, false) { }
		
		/// <summary>Creates a new SnDiscussionMessageEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnDiscussionMessageEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnDiscussionMessageUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnDiscussionTopicEntity objects.</summary>
	[Serializable]
	public partial class SnDiscussionTopicEntityFactory : EntityFactoryBase2<SnDiscussionTopicEntity> {
		/// <summary>CTor</summary>
		public SnDiscussionTopicEntityFactory() : base("SnDiscussionTopicEntity", MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity, false) { }
		
		/// <summary>Creates a new SnDiscussionTopicEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnDiscussionTopicEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnDiscussionTopicUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnEventEntity objects.</summary>
	[Serializable]
	public partial class SnEventEntityFactory : EntityFactoryBase2<SnEventEntity> {
		/// <summary>CTor</summary>
		public SnEventEntityFactory() : base("SnEventEntity", MonoSoftware.MonoX.DAL.EntityType.SnEventEntity, false) { }
		
		/// <summary>Creates a new SnEventEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnEventEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnEventUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnEventTypeEntity objects.</summary>
	[Serializable]
	public partial class SnEventTypeEntityFactory : EntityFactoryBase2<SnEventTypeEntity> {
		/// <summary>CTor</summary>
		public SnEventTypeEntityFactory() : base("SnEventTypeEntity", MonoSoftware.MonoX.DAL.EntityType.SnEventTypeEntity, false) { }
		
		/// <summary>Creates a new SnEventTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnEventTypeEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnEventTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnFileEntity objects.</summary>
	[Serializable]
	public partial class SnFileEntityFactory : EntityFactoryBase2<SnFileEntity> {
		/// <summary>CTor</summary>
		public SnFileEntityFactory() : base("SnFileEntity", MonoSoftware.MonoX.DAL.EntityType.SnFileEntity, false) { }
		
		/// <summary>Creates a new SnFileEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnFileEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnFileUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnFriendEntity objects.</summary>
	[Serializable]
	public partial class SnFriendEntityFactory : EntityFactoryBase2<SnFriendEntity> {
		/// <summary>CTor</summary>
		public SnFriendEntityFactory() : base("SnFriendEntity", MonoSoftware.MonoX.DAL.EntityType.SnFriendEntity, false) { }
		
		/// <summary>Creates a new SnFriendEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnFriendEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnFriendUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnFriendListEntity objects.</summary>
	[Serializable]
	public partial class SnFriendListEntityFactory : EntityFactoryBase2<SnFriendListEntity> {
		/// <summary>CTor</summary>
		public SnFriendListEntityFactory() : base("SnFriendListEntity", MonoSoftware.MonoX.DAL.EntityType.SnFriendListEntity, false) { }
		
		/// <summary>Creates a new SnFriendListEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnFriendListEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnFriendListUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnFriendListMemberEntity objects.</summary>
	[Serializable]
	public partial class SnFriendListMemberEntityFactory : EntityFactoryBase2<SnFriendListMemberEntity> {
		/// <summary>CTor</summary>
		public SnFriendListMemberEntityFactory() : base("SnFriendListMemberEntity", MonoSoftware.MonoX.DAL.EntityType.SnFriendListMemberEntity, false) { }
		
		/// <summary>Creates a new SnFriendListMemberEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnFriendListMemberEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnFriendListMemberUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnFriendRequestEntity objects.</summary>
	[Serializable]
	public partial class SnFriendRequestEntityFactory : EntityFactoryBase2<SnFriendRequestEntity> {
		/// <summary>CTor</summary>
		public SnFriendRequestEntityFactory() : base("SnFriendRequestEntity", MonoSoftware.MonoX.DAL.EntityType.SnFriendRequestEntity, false) { }
		
		/// <summary>Creates a new SnFriendRequestEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnFriendRequestEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnFriendRequestUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnGroupEntity objects.</summary>
	[Serializable]
	public partial class SnGroupEntityFactory : EntityFactoryBase2<SnGroupEntity> {
		/// <summary>CTor</summary>
		public SnGroupEntityFactory() : base("SnGroupEntity", MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity, false) { }
		
		/// <summary>Creates a new SnGroupEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnGroupEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnGroupUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnGroupCategoryEntity objects.</summary>
	[Serializable]
	public partial class SnGroupCategoryEntityFactory : EntityFactoryBase2<SnGroupCategoryEntity> {
		/// <summary>CTor</summary>
		public SnGroupCategoryEntityFactory() : base("SnGroupCategoryEntity", MonoSoftware.MonoX.DAL.EntityType.SnGroupCategoryEntity, false) { }
		
		/// <summary>Creates a new SnGroupCategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnGroupCategoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnGroupCategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnGroupMemberEntity objects.</summary>
	[Serializable]
	public partial class SnGroupMemberEntityFactory : EntityFactoryBase2<SnGroupMemberEntity> {
		/// <summary>CTor</summary>
		public SnGroupMemberEntityFactory() : base("SnGroupMemberEntity", MonoSoftware.MonoX.DAL.EntityType.SnGroupMemberEntity, false) { }
		
		/// <summary>Creates a new SnGroupMemberEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnGroupMemberEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnGroupMemberUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnGroupRequestEntity objects.</summary>
	[Serializable]
	public partial class SnGroupRequestEntityFactory : EntityFactoryBase2<SnGroupRequestEntity> {
		/// <summary>CTor</summary>
		public SnGroupRequestEntityFactory() : base("SnGroupRequestEntity", MonoSoftware.MonoX.DAL.EntityType.SnGroupRequestEntity, false) { }
		
		/// <summary>Creates a new SnGroupRequestEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnGroupRequestEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnGroupRequestUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnMessageEntity objects.</summary>
	[Serializable]
	public partial class SnMessageEntityFactory : EntityFactoryBase2<SnMessageEntity> {
		/// <summary>CTor</summary>
		public SnMessageEntityFactory() : base("SnMessageEntity", MonoSoftware.MonoX.DAL.EntityType.SnMessageEntity, false) { }
		
		/// <summary>Creates a new SnMessageEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnMessageEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnMessageUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnMessageRecipientEntity objects.</summary>
	[Serializable]
	public partial class SnMessageRecipientEntityFactory : EntityFactoryBase2<SnMessageRecipientEntity> {
		/// <summary>CTor</summary>
		public SnMessageRecipientEntityFactory() : base("SnMessageRecipientEntity", MonoSoftware.MonoX.DAL.EntityType.SnMessageRecipientEntity, false) { }
		
		/// <summary>Creates a new SnMessageRecipientEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnMessageRecipientEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnMessageRecipientUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnNoteEntity objects.</summary>
	[Serializable]
	public partial class SnNoteEntityFactory : EntityFactoryBase2<SnNoteEntity> {
		/// <summary>CTor</summary>
		public SnNoteEntityFactory() : base("SnNoteEntity", MonoSoftware.MonoX.DAL.EntityType.SnNoteEntity, false) { }
		
		/// <summary>Creates a new SnNoteEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnNoteEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnNoteUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnRatingEntity objects.</summary>
	[Serializable]
	public partial class SnRatingEntityFactory : EntityFactoryBase2<SnRatingEntity> {
		/// <summary>CTor</summary>
		public SnRatingEntityFactory() : base("SnRatingEntity", MonoSoftware.MonoX.DAL.EntityType.SnRatingEntity, false) { }
		
		/// <summary>Creates a new SnRatingEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnRatingEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnRatingUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnRelationshipEntity objects.</summary>
	[Serializable]
	public partial class SnRelationshipEntityFactory : EntityFactoryBase2<SnRelationshipEntity> {
		/// <summary>CTor</summary>
		public SnRelationshipEntityFactory() : base("SnRelationshipEntity", MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity, false) { }
		
		/// <summary>Creates a new SnRelationshipEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnRelationshipEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnRelationshipUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnSubscriberEntity objects.</summary>
	[Serializable]
	public partial class SnSubscriberEntityFactory : EntityFactoryBase2<SnSubscriberEntity> {
		/// <summary>CTor</summary>
		public SnSubscriberEntityFactory() : base("SnSubscriberEntity", MonoSoftware.MonoX.DAL.EntityType.SnSubscriberEntity, false) { }
		
		/// <summary>Creates a new SnSubscriberEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnSubscriberEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnSubscriberUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SnTagEntity objects.</summary>
	[Serializable]
	public partial class SnTagEntityFactory : EntityFactoryBase2<SnTagEntity> {
		/// <summary>CTor</summary>
		public SnTagEntityFactory() : base("SnTagEntity", MonoSoftware.MonoX.DAL.EntityType.SnTagEntity, false) { }
		
		/// <summary>Creates a new SnTagEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SnTagEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSnTagUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty TermsAndConditionsEntity objects.</summary>
	[Serializable]
	public partial class TermsAndConditionsEntityFactory : EntityFactoryBase2<TermsAndConditionsEntity> {
		/// <summary>CTor</summary>
		public TermsAndConditionsEntityFactory() : base("TermsAndConditionsEntity", MonoSoftware.MonoX.DAL.EntityType.TermsAndConditionsEntity, false) { }
		
		/// <summary>Creates a new TermsAndConditionsEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TermsAndConditionsEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTermsAndConditionsUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty UserAvatarEntity objects.</summary>
	[Serializable]
	public partial class UserAvatarEntityFactory : EntityFactoryBase2<UserAvatarEntity> {
		/// <summary>CTor</summary>
		public UserAvatarEntityFactory() : base("UserAvatarEntity", MonoSoftware.MonoX.DAL.EntityType.UserAvatarEntity, false) { }
		
		/// <summary>Creates a new UserAvatarEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new UserAvatarEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserAvatarUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty UserProfileEntity objects.</summary>
	[Serializable]
	public partial class UserProfileEntityFactory : EntityFactoryBase2<UserProfileEntity> {
		/// <summary>CTor</summary>
		public UserProfileEntityFactory() : base("UserProfileEntity", MonoSoftware.MonoX.DAL.EntityType.UserProfileEntity, false) { }
		
		/// <summary>Creates a new UserProfileEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new UserProfileEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserProfileUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty UserSocialIdentityEntity objects.</summary>
	[Serializable]
	public partial class UserSocialIdentityEntityFactory : EntityFactoryBase2<UserSocialIdentityEntity> {
		/// <summary>CTor</summary>
		public UserSocialIdentityEntityFactory() : base("UserSocialIdentityEntity", MonoSoftware.MonoX.DAL.EntityType.UserSocialIdentityEntity, false) { }
		
		/// <summary>Creates a new UserSocialIdentityEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new UserSocialIdentityEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserSocialIdentityUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty VersionEntity objects.</summary>
	[Serializable]
	public partial class VersionEntityFactory : EntityFactoryBase2<VersionEntity> {
		/// <summary>CTor</summary>
		public VersionEntityFactory() : base("VersionEntity", MonoSoftware.MonoX.DAL.EntityType.VersionEntity, false) { }
		
		/// <summary>Creates a new VersionEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new VersionEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVersionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(MonoSoftware.MonoX.DAL.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case MonoSoftware.MonoX.DAL.EntityType.AdEntity:
					factoryToUse = new AdEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AdPageEntity:
					factoryToUse = new AdPageEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetApplicationsEntity:
					factoryToUse = new AspnetApplicationsEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetMembershipEntity:
					factoryToUse = new AspnetMembershipEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetPathsEntity:
					factoryToUse = new AspnetPathsEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetPersonalizationAllUsersEntity:
					factoryToUse = new AspnetPersonalizationAllUsersEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetPersonalizationPerUserEntity:
					factoryToUse = new AspnetPersonalizationPerUserEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetProfileEntity:
					factoryToUse = new AspnetProfileEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetRolesEntity:
					factoryToUse = new AspnetRolesEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetSchemaVersionsEntity:
					factoryToUse = new AspnetSchemaVersionsEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetUsersEntity:
					factoryToUse = new AspnetUsersEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetUsersInRolesEntity:
					factoryToUse = new AspnetUsersInRolesEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.AspnetWebEventEventsEntity:
					factoryToUse = new AspnetWebEventEventsEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogEntity:
					factoryToUse = new BlogEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogCategoryEntity:
					factoryToUse = new BlogCategoryEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogEditorEntity:
					factoryToUse = new BlogEditorEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogPostEntity:
					factoryToUse = new BlogPostEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogPostCategoryEntity:
					factoryToUse = new BlogPostCategoryEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.BlogPostRoleEntity:
					factoryToUse = new BlogPostRoleEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEntity:
					factoryToUse = new CalendarEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEditRoleEntity:
					factoryToUse = new CalendarEditRoleEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntity:
					factoryToUse = new CalendarEventEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEventEntryEntity:
					factoryToUse = new CalendarEventEntryEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionEntity:
					factoryToUse = new CalendarEventRecurringDefinitionEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarEventRecurringDefinitionTypeEntity:
					factoryToUse = new CalendarEventRecurringDefinitionTypeEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarModeratorEntity:
					factoryToUse = new CalendarModeratorEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CalendarViewRoleEntity:
					factoryToUse = new CalendarViewRoleEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.CampaignEntity:
					factoryToUse = new CampaignEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.DocumentEntity:
					factoryToUse = new DocumentEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.FriendSuggestionTypedViewEntryEntity:
					factoryToUse = new FriendSuggestionTypedViewEntryEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.LanguageEntity:
					factoryToUse = new LanguageEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.ListEntity:
					factoryToUse = new ListEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.ListItemEntity:
					factoryToUse = new ListItemEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.ListItemLocalizationEntity:
					factoryToUse = new ListItemLocalizationEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.LocalizationBinaryEntity:
					factoryToUse = new LocalizationBinaryEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.LocalizationSourceEntity:
					factoryToUse = new LocalizationSourceEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.LocalizationStringEntity:
					factoryToUse = new LocalizationStringEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NavigationEntity:
					factoryToUse = new NavigationEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NavigationLocalizationEntity:
					factoryToUse = new NavigationLocalizationEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NavigationRoleEntity:
					factoryToUse = new NavigationRoleEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsCategoryEntity:
					factoryToUse = new NewsCategoryEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsCategoryInRoleEntity:
					factoryToUse = new NewsCategoryInRoleEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsCategoryLocalizationEntity:
					factoryToUse = new NewsCategoryLocalizationEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsCategoryTemplateEntity:
					factoryToUse = new NewsCategoryTemplateEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsFileEntity:
					factoryToUse = new NewsFileEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsItemEntity:
					factoryToUse = new NewsItemEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsItemLocalizationEntity:
					factoryToUse = new NewsItemLocalizationEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsletterEntity:
					factoryToUse = new NewsletterEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsletterLogEntity:
					factoryToUse = new NewsletterLogEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsletterRoleEntity:
					factoryToUse = new NewsletterRoleEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsMetaIgnoredWordEntity:
					factoryToUse = new NewsMetaIgnoredWordEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.NewsPublishQueueEntity:
					factoryToUse = new NewsPublishQueueEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.OaConsumerEntity:
					factoryToUse = new OaConsumerEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.OaTokenEntity:
					factoryToUse = new OaTokenEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PageEntity:
					factoryToUse = new PageEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PageEditRoleEntity:
					factoryToUse = new PageEditRoleEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PageLocalizationEntity:
					factoryToUse = new PageLocalizationEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PageRoleEntity:
					factoryToUse = new PageRoleEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PollEntity:
					factoryToUse = new PollEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PollAnswerEntity:
					factoryToUse = new PollAnswerEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PollAnswerLocalizationEntity:
					factoryToUse = new PollAnswerLocalizationEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PollLocalizationEntity:
					factoryToUse = new PollLocalizationEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelEntity:
					factoryToUse = new PrivacyLevelEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.PrivacyLevelDefinitionEntity:
					factoryToUse = new PrivacyLevelDefinitionEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnAlbumEntity:
					factoryToUse = new SnAlbumEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnBlockUserEntity:
					factoryToUse = new SnBlockUserEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnCommentEntity:
					factoryToUse = new SnCommentEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardEntity:
					factoryToUse = new SnDiscussionBoardEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardInRoleEntity:
					factoryToUse = new SnDiscussionBoardInRoleEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionBoardModeratorEntity:
					factoryToUse = new SnDiscussionBoardModeratorEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionMessageEntity:
					factoryToUse = new SnDiscussionMessageEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnDiscussionTopicEntity:
					factoryToUse = new SnDiscussionTopicEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnEventEntity:
					factoryToUse = new SnEventEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnEventTypeEntity:
					factoryToUse = new SnEventTypeEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFileEntity:
					factoryToUse = new SnFileEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFriendEntity:
					factoryToUse = new SnFriendEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFriendListEntity:
					factoryToUse = new SnFriendListEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFriendListMemberEntity:
					factoryToUse = new SnFriendListMemberEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnFriendRequestEntity:
					factoryToUse = new SnFriendRequestEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnGroupEntity:
					factoryToUse = new SnGroupEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnGroupCategoryEntity:
					factoryToUse = new SnGroupCategoryEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnGroupMemberEntity:
					factoryToUse = new SnGroupMemberEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnGroupRequestEntity:
					factoryToUse = new SnGroupRequestEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnMessageEntity:
					factoryToUse = new SnMessageEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnMessageRecipientEntity:
					factoryToUse = new SnMessageRecipientEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnNoteEntity:
					factoryToUse = new SnNoteEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnRatingEntity:
					factoryToUse = new SnRatingEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnRelationshipEntity:
					factoryToUse = new SnRelationshipEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnSubscriberEntity:
					factoryToUse = new SnSubscriberEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.SnTagEntity:
					factoryToUse = new SnTagEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.TermsAndConditionsEntity:
					factoryToUse = new TermsAndConditionsEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.UserAvatarEntity:
					factoryToUse = new UserAvatarEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.UserProfileEntity:
					factoryToUse = new UserProfileEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.UserSocialIdentityEntity:
					factoryToUse = new UserSocialIdentityEntityFactory();
					break;
				case MonoSoftware.MonoX.DAL.EntityType.VersionEntity:
					factoryToUse = new VersionEntityFactory();
					break;
			}
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the MonoSoftware.MonoX.DAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(MonoSoftware.MonoX.DAL.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(MonoSoftware.MonoX.DAL.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.Create((MonoSoftware.MonoX.DAL.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			IEntityFactory2 toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the MonoSoftware.MonoX.DAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(MonoSoftware.MonoX.DAL.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif		
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the MonoSoftware.MonoX.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue)
		{
			return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue);
		}
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (MonoSoftware.MonoX.DAL.EntityType)Enum.Parse(typeof(MonoSoftware.MonoX.DAL.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((MonoSoftware.MonoX.DAL.EntityType)Enum.Parse(typeof(MonoSoftware.MonoX.DAL.EntityType), leftOperandEntityName, false), joinType, (MonoSoftware.MonoX.DAL.EntityType)Enum.Parse(typeof(MonoSoftware.MonoX.DAL.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the MonoSoftware.MonoX.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((MonoSoftware.MonoX.DAL.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
