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
	/// <summary>Implements the relations factory for the entity: Poll. </summary>
	public partial class PollRelations
	{
		/// <summary>CTor</summary>
		public PollRelations()
		{
		}

		/// <summary>Gets all relations of the PollEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PollAnswerEntityUsingPollId);
			toReturn.Add(this.PollLocalizationEntityUsingPollId);
			toReturn.Add(this.SnRelationshipEntityUsingPollId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PollEntity and PollAnswerEntity over the 1:n relation they have, using the relation between the fields:
		/// Poll.Id - PollAnswer.PollId
		/// </summary>
		public virtual IEntityRelation PollAnswerEntityUsingPollId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PollAnswers" , true);
				relation.AddEntityFieldPair(PollFields.Id, PollAnswerFields.PollId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollAnswerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PollEntity and PollLocalizationEntity over the 1:n relation they have, using the relation between the fields:
		/// Poll.Id - PollLocalization.PollId
		/// </summary>
		public virtual IEntityRelation PollLocalizationEntityUsingPollId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PollLocalizations" , true);
				relation.AddEntityFieldPair(PollFields.Id, PollLocalizationFields.PollId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollLocalizationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PollEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// Poll.Id - SnRelationship.PollId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingPollId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationshipss" , true);
				relation.AddEntityFieldPair(PollFields.Id, SnRelationshipFields.PollId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PollEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// Poll.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplication", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, PollFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PollEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// Poll.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, PollFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollEntity", true);
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
	internal static class StaticPollRelations
	{
		internal static readonly IEntityRelation PollAnswerEntityUsingPollIdStatic = new PollRelations().PollAnswerEntityUsingPollId;
		internal static readonly IEntityRelation PollLocalizationEntityUsingPollIdStatic = new PollRelations().PollLocalizationEntityUsingPollId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingPollIdStatic = new PollRelations().SnRelationshipEntityUsingPollId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new PollRelations().AspnetApplicationsEntityUsingApplicationId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new PollRelations().AspnetUsersEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticPollRelations()
		{
		}
	}
}
