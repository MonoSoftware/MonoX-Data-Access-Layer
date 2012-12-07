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
	/// <summary>Implements the relations factory for the entity: PollLocalization. </summary>
	public partial class PollLocalizationRelations
	{
		/// <summary>CTor</summary>
		public PollLocalizationRelations()
		{
		}

		/// <summary>Gets all relations of the PollLocalizationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			toReturn.Add(this.PollEntityUsingPollId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between PollLocalizationEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// PollLocalization.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, PollLocalizationFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollLocalizationEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PollLocalizationEntity and PollEntity over the m:1 relation they have, using the relation between the fields:
		/// PollLocalization.PollId - Poll.Id
		/// </summary>
		public virtual IEntityRelation PollEntityUsingPollId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Poll", false);
				relation.AddEntityFieldPair(PollFields.Id, PollLocalizationFields.PollId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PollLocalizationEntity", true);
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
	internal static class StaticPollLocalizationRelations
	{
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new PollLocalizationRelations().LanguageEntityUsingLanguageId;
		internal static readonly IEntityRelation PollEntityUsingPollIdStatic = new PollLocalizationRelations().PollEntityUsingPollId;

		/// <summary>CTor</summary>
		static StaticPollLocalizationRelations()
		{
		}
	}
}
