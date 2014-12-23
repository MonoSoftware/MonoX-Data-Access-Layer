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
	/// <summary>Implements the relations factory for the entity: UserProfile. </summary>
	public partial class UserProfileRelations
	{
		/// <summary>CTor</summary>
		public UserProfileRelations()
		{
		}

		/// <summary>Gets all relations of the UserProfileEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetUsersEntityUsingId);
			toReturn.Add(this.PrivacyLevelEntityUsingMyStatusPrivacyLevelId);
			toReturn.Add(this.TermsAndConditionsEntityUsingTermsAndConditionsId);
			return toReturn;
		}

		#region Class Property Declarations


		/// <summary>Returns a new IEntityRelation object, between UserProfileEntity and AspnetUsersEntity over the 1:1 relation they have, using the relation between the fields:
		/// UserProfile.Id - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "AspnetUser", false);



				relation.AddEntityFieldPair(AspnetUsersFields.UserId, UserProfileFields.Id);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserProfileEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserProfileEntity and PrivacyLevelEntity over the m:1 relation they have, using the relation between the fields:
		/// UserProfile.MyStatusPrivacyLevelId - PrivacyLevel.Id
		/// </summary>
		public virtual IEntityRelation PrivacyLevelEntityUsingMyStatusPrivacyLevelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PrivacyLevel", false);
				relation.AddEntityFieldPair(PrivacyLevelFields.Id, UserProfileFields.MyStatusPrivacyLevelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PrivacyLevelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserProfileEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between UserProfileEntity and TermsAndConditionsEntity over the m:1 relation they have, using the relation between the fields:
		/// UserProfile.TermsAndConditionsId - TermsAndConditions.Id
		/// </summary>
		public virtual IEntityRelation TermsAndConditionsEntityUsingTermsAndConditionsId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "TermsAndConditions", false);
				relation.AddEntityFieldPair(TermsAndConditionsFields.Id, UserProfileFields.TermsAndConditionsId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TermsAndConditionsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserProfileEntity", true);
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
	internal static class StaticUserProfileRelations
	{
		internal static readonly IEntityRelation AspnetUsersEntityUsingIdStatic = new UserProfileRelations().AspnetUsersEntityUsingId;
		internal static readonly IEntityRelation PrivacyLevelEntityUsingMyStatusPrivacyLevelIdStatic = new UserProfileRelations().PrivacyLevelEntityUsingMyStatusPrivacyLevelId;
		internal static readonly IEntityRelation TermsAndConditionsEntityUsingTermsAndConditionsIdStatic = new UserProfileRelations().TermsAndConditionsEntityUsingTermsAndConditionsId;

		/// <summary>CTor</summary>
		static StaticUserProfileRelations()
		{
		}
	}
}
