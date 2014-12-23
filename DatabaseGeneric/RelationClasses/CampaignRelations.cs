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
	/// <summary>Implements the relations factory for the entity: Campaign. </summary>
	public partial class CampaignRelations
	{
		/// <summary>CTor</summary>
		public CampaignRelations()
		{
		}

		/// <summary>Gets all relations of the CampaignEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AdEntityUsingCampaignId);
			toReturn.Add(this.SnRelationshipEntityUsingCampaignId);
			toReturn.Add(this.AspnetApplicationsEntityUsingApplicationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CampaignEntity and AdEntity over the 1:n relation they have, using the relation between the fields:
		/// Campaign.Id - Ad.CampaignId
		/// </summary>
		public virtual IEntityRelation AdEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Ad" , true);
				relation.AddEntityFieldPair(CampaignFields.Id, AdFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CampaignEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// Campaign.Id - SnRelationship.CampaignId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationshipss" , true);
				relation.AddEntityFieldPair(CampaignFields.Id, SnRelationshipFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CampaignEntity and AspnetApplicationsEntity over the m:1 relation they have, using the relation between the fields:
		/// Campaign.ApplicationId - AspnetApplications.ApplicationId
		/// </summary>
		public virtual IEntityRelation AspnetApplicationsEntityUsingApplicationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetApplications", false);
				relation.AddEntityFieldPair(AspnetApplicationsFields.ApplicationId, CampaignFields.ApplicationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetApplicationsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", true);
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
	internal static class StaticCampaignRelations
	{
		internal static readonly IEntityRelation AdEntityUsingCampaignIdStatic = new CampaignRelations().AdEntityUsingCampaignId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingCampaignIdStatic = new CampaignRelations().SnRelationshipEntityUsingCampaignId;
		internal static readonly IEntityRelation AspnetApplicationsEntityUsingApplicationIdStatic = new CampaignRelations().AspnetApplicationsEntityUsingApplicationId;

		/// <summary>CTor</summary>
		static StaticCampaignRelations()
		{
		}
	}
}
