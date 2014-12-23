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
	/// <summary>Implements the relations factory for the entity: AspnetPaths. </summary>
	public partial class AspnetPathsRelations
	{
		/// <summary>CTor</summary>
		public AspnetPathsRelations()
		{
		}

		/// <summary>Gets all relations of the AspnetPathsEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetPersonalizationPerUserEntityUsingPathId);
			toReturn.Add(this.AspnetPersonalizationAllUsersEntityUsingPathId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AspnetPathsEntity and AspnetPersonalizationPerUserEntity over the 1:n relation they have, using the relation between the fields:
		/// AspnetPaths.PathId - AspnetPersonalizationPerUser.PathId
		/// </summary>
		public virtual IEntityRelation AspnetPersonalizationPerUserEntityUsingPathId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AspnetPersonalizationPerUser" , true);
				relation.AddEntityFieldPair(AspnetPathsFields.PathId, AspnetPersonalizationPerUserFields.PathId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPathsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPersonalizationPerUserEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetPathsEntity and AspnetPersonalizationAllUsersEntity over the 1:1 relation they have, using the relation between the fields:
		/// AspnetPaths.PathId - AspnetPersonalizationAllUsers.PathId
		/// </summary>
		public virtual IEntityRelation AspnetPersonalizationAllUsersEntityUsingPathId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "AspnetPersonalizationAllUsers", true);

				relation.AddEntityFieldPair(AspnetPathsFields.PathId, AspnetPersonalizationAllUsersFields.PathId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPathsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPersonalizationAllUsersEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AspnetPathsEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// AspnetPaths.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplications", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, AspnetPathsFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPathsEntity", true);
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
	internal static class StaticAspnetPathsRelations
	{
		internal static readonly IEntityRelation AspnetPersonalizationPerUserEntityUsingPathIdStatic = new AspnetPathsRelations().AspnetPersonalizationPerUserEntityUsingPathId;
		internal static readonly IEntityRelation AspnetPersonalizationAllUsersEntityUsingPathIdStatic = new AspnetPathsRelations().AspnetPersonalizationAllUsersEntityUsingPathId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new AspnetPathsRelations().AspnetApplicationsEntityUsingApplicationId;

		/// <summary>CTor</summary>
		static StaticAspnetPathsRelations()
		{
		}
	}
}
