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
	/// <summary>Implements the relations factory for the entity: SnSubscriber. </summary>
	public partial class SnSubscriberRelations
	{
		/// <summary>CTor</summary>
		public SnSubscriberRelations()
		{
		}

		/// <summary>Gets all relations of the SnSubscriberEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.SnRelationshipEntityUsingRelationshipId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SnSubscriberEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnSubscriber.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnSubscriberFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnSubscriberEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnSubscriberEntity and SnRelationshipEntity over the m:1 relation they have, using the relation between the fields:
		/// SnSubscriber.RelationshipId - SnRelationship.Id
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingRelationshipId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnRelationship", false);
				relation.AddEntityFieldPair(SnRelationshipFields.Id, SnSubscriberFields.RelationshipId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnSubscriberEntity", true);
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
	internal static class StaticSnSubscriberRelations
	{
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnSubscriberRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingRelationshipIdStatic = new SnSubscriberRelations().SnRelationshipEntityUsingRelationshipId;

		/// <summary>CTor</summary>
		static StaticSnSubscriberRelations()
		{
		}
	}
}
