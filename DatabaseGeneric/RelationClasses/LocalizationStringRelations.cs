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
	/// <summary>Implements the relations factory for the entity: LocalizationString. </summary>
	public partial class LocalizationStringRelations
	{
		/// <summary>CTor</summary>
		public LocalizationStringRelations()
		{
		}

		/// <summary>Gets all relations of the LocalizationStringEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LocalizationSourceEntityUsingId);
			return toReturn;
		}

		#region Class Property Declarations


		/// <summary>Returns a new IEntityRelation object, between LocalizationStringEntity and LocalizationSourceEntity over the 1:1 relation they have, using the relation between the fields:
		/// LocalizationString.Id - LocalizationSource.Id
		/// </summary>
		public virtual IEntityRelation LocalizationSourceEntityUsingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "LocalizationSource", false);



				relation.AddEntityFieldPair(LocalizationSourceFields.Id, LocalizationStringFields.Id);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocalizationSourceEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocalizationStringEntity", true);
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
	internal static class StaticLocalizationStringRelations
	{
		internal static readonly IEntityRelation LocalizationSourceEntityUsingIdStatic = new LocalizationStringRelations().LocalizationSourceEntityUsingId;

		/// <summary>CTor</summary>
		static StaticLocalizationStringRelations()
		{
		}
	}
}
