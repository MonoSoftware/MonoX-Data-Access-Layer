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
	/// <summary>Implements the relations factory for the entity: AspnetPersonalizationPerUser. </summary>
	public partial class AspnetPersonalizationPerUserRelations
	{
		/// <summary>CTor</summary>
		public AspnetPersonalizationPerUserRelations()
		{
		}

		/// <summary>Gets all relations of the AspnetPersonalizationPerUserEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetPathsEntityUsingPathId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between AspnetPersonalizationPerUserEntity and AspnetPathsEntity over the m:1 relation they have, using the relation between the fields:
		/// AspnetPersonalizationPerUser.PathId - AspnetPaths.PathId
		/// </summary>
		public virtual IEntityRelation AspnetPathsEntityUsingPathId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetPaths", false);
				relation.AddEntityFieldPair(AspnetPathsFields.PathId, AspnetPersonalizationPerUserFields.PathId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPathsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPersonalizationPerUserEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AspnetPersonalizationPerUserEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// AspnetPersonalizationPerUser.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, AspnetPersonalizationPerUserFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPersonalizationPerUserEntity", true);
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
	internal static class StaticAspnetPersonalizationPerUserRelations
	{
		internal static readonly IEntityRelation AspnetPathsEntityUsingPathIdStatic = new AspnetPersonalizationPerUserRelations().AspnetPathsEntityUsingPathId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new AspnetPersonalizationPerUserRelations().AspnetUsersEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticAspnetPersonalizationPerUserRelations()
		{
		}
	}
}
