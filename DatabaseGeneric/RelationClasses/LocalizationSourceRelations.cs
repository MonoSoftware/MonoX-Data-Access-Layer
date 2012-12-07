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
	/// <summary>Implements the relations factory for the entity: LocalizationSource. </summary>
	public partial class LocalizationSourceRelations
	{
		/// <summary>CTor</summary>
		public LocalizationSourceRelations()
		{
		}

		/// <summary>Gets all relations of the LocalizationSourceEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LocalizationBinaryEntityUsingId);
			toReturn.Add(this.LocalizationStringEntityUsingId);
			toReturn.Add(this.LanguageEntityUsingLanguageId);
			return toReturn;
		}

		#region Class Property Declarations


		/// <summary>Returns a new IEntityRelation object, between LocalizationSourceEntity and LocalizationBinaryEntity over the 1:1 relation they have, using the relation between the fields:
		/// LocalizationSource.Id - LocalizationBinary.Id
		/// </summary>
		public virtual IEntityRelation LocalizationBinaryEntityUsingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "LocalizationBinary", true);

				relation.AddEntityFieldPair(LocalizationSourceFields.Id, LocalizationBinaryFields.Id);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocalizationSourceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocalizationBinaryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LocalizationSourceEntity and LocalizationStringEntity over the 1:1 relation they have, using the relation between the fields:
		/// LocalizationSource.Id - LocalizationString.Id
		/// </summary>
		public virtual IEntityRelation LocalizationStringEntityUsingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "LocalizationString", true);

				relation.AddEntityFieldPair(LocalizationSourceFields.Id, LocalizationStringFields.Id);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocalizationSourceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocalizationStringEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LocalizationSourceEntity and LanguageEntity over the m:1 relation they have, using the relation between the fields:
		/// LocalizationSource.LanguageId - Language.Id
		/// </summary>
		public virtual IEntityRelation LanguageEntityUsingLanguageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Language", false);
				relation.AddEntityFieldPair(LanguageFields.Id, LocalizationSourceFields.LanguageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LanguageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocalizationSourceEntity", true);
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
	internal static class StaticLocalizationSourceRelations
	{
		internal static readonly IEntityRelation LocalizationBinaryEntityUsingIdStatic = new LocalizationSourceRelations().LocalizationBinaryEntityUsingId;
		internal static readonly IEntityRelation LocalizationStringEntityUsingIdStatic = new LocalizationSourceRelations().LocalizationStringEntityUsingId;
		internal static readonly IEntityRelation LanguageEntityUsingLanguageIdStatic = new LocalizationSourceRelations().LanguageEntityUsingLanguageId;

		/// <summary>CTor</summary>
		static StaticLocalizationSourceRelations()
		{
		}
	}
}
