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
	/// <summary>Implements the relations factory for the entity: Ad. </summary>
	public partial class AdRelations
	{
		/// <summary>CTor</summary>
		public AdRelations()
		{
		}

		/// <summary>Gets all relations of the AdEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AdPageEntityUsingAdId);
			toReturn.Add(this.CampaignEntityUsingCampaignId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AdEntity and AdPageEntity over the 1:n relation they have, using the relation between the fields:
		/// Ad.Id - AdPage.AdId
		/// </summary>
		public virtual IEntityRelation AdPageEntityUsingAdId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AdPage" , true);
				relation.AddEntityFieldPair(AdFields.Id, AdPageFields.AdId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdPageEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AdEntity and CampaignEntity over the m:1 relation they have, using the relation between the fields:
		/// Ad.CampaignId - Campaign.Id
		/// </summary>
		public virtual IEntityRelation CampaignEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Campaign", false);
				relation.AddEntityFieldPair(CampaignFields.Id, AdFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AdEntity", true);
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
	internal static class StaticAdRelations
	{
		internal static readonly IEntityRelation AdPageEntityUsingAdIdStatic = new AdRelations().AdPageEntityUsingAdId;
		internal static readonly IEntityRelation CampaignEntityUsingCampaignIdStatic = new AdRelations().CampaignEntityUsingCampaignId;

		/// <summary>CTor</summary>
		static StaticAdRelations()
		{
		}
	}
}
