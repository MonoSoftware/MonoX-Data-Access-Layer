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
using System.Collections;
using System.Collections.Generic;
using MonoSoftware.MonoX.DAL;
using MonoSoftware.MonoX.DAL.FactoryClasses;
using MonoSoftware.MonoX.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace MonoSoftware.MonoX.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: List. </summary>
	public partial class ListRelations
	{
		/// <summary>CTor</summary>
		public ListRelations()
		{
		}

		/// <summary>Gets all relations of the ListEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ListItemEntityUsingListId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ListEntity and ListItemEntity over the 1:n relation they have, using the relation between the fields:
		/// List.Id - ListItem.ListId
		/// </summary>
		public virtual IEntityRelation ListItemEntityUsingListId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ListItems" , true);
				relation.AddEntityFieldPair(ListFields.Id, ListItemFields.ListId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListItemEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ListEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// List.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplication", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, ListFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ListEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// List.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, ListFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticListRelations
	{
		internal static readonly IEntityRelation ListItemEntityUsingListIdStatic = new ListRelations().ListItemEntityUsingListId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new ListRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new ListRelations().AspnetUsersEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticListRelations()
		{
		}
	}
}
