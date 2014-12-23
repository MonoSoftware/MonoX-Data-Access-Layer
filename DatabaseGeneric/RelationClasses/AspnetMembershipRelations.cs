///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
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
	/// <summary>Implements the relations factory for the entity: AspnetMembership. </summary>
	public partial class AspnetMembershipRelations
	{
		/// <summary>CTor</summary>
		public AspnetMembershipRelations()
		{
		}

		/// <summary>Gets all relations of the AspnetMembershipEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			return toReturn;
		}

		#region Class Property Declarations


		/// <summary>Returns a new IEntityRelation object, between AspnetMembershipEntity and AspnetUsersEntity over the 1:1 relation they have, using the relation between the fields:
		/// AspnetMembership.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "AspnetUsers", false);



				relation.AddEntityFieldPair(AspnetUsersFields.UserId, AspnetMembershipFields.UserId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetMembershipEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetMembershipEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// AspnetMembership.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplications", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, AspnetMembershipFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetMembershipEntity", true);
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
	internal static class StaticAspnetMembershipRelations
	{
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new AspnetMembershipRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new AspnetMembershipRelations().AspnetApplicationsEntityUsingApplicationId;

		/// <summary>CTor</summary>
		static StaticAspnetMembershipRelations()
		{
		}
	}
}
