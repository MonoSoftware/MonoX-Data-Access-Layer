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
	/// <summary>Implements the relations factory for the entity: CalendarEventRecurringDefinition. </summary>
	public partial class CalendarEventRecurringDefinitionRelations
	{
		/// <summary>CTor</summary>
		public CalendarEventRecurringDefinitionRelations()
		{
		}

		/// <summary>Gets all relations of the CalendarEventRecurringDefinitionEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CalendarEventEntityUsingRecurringDefinitionId);
			toReturn.Add(this.CalendarEventRecurringDefinitionTypeEntityUsingRecurringTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CalendarEventRecurringDefinitionEntity and CalendarEventEntity over the 1:n relation they have, using the relation between the fields:
		/// CalendarEventRecurringDefinition.Id - CalendarEvent.RecurringDefinitionId
		/// </summary>
		public virtual IEntityRelation CalendarEventEntityUsingRecurringDefinitionId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarEvents" , true);
				relation.AddEntityFieldPair(CalendarEventRecurringDefinitionFields.Id, CalendarEventFields.RecurringDefinitionId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventRecurringDefinitionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CalendarEventRecurringDefinitionEntity and CalendarEventRecurringDefinitionTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// CalendarEventRecurringDefinition.RecurringTypeId - CalendarEventRecurringDefinitionType.Id
		/// </summary>
		public virtual IEntityRelation CalendarEventRecurringDefinitionTypeEntityUsingRecurringTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CalendarEventRecurringDefinitionType", false);
				relation.AddEntityFieldPair(CalendarEventRecurringDefinitionTypeFields.Id, CalendarEventRecurringDefinitionFields.RecurringTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventRecurringDefinitionTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventRecurringDefinitionEntity", true);
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
	internal static class StaticCalendarEventRecurringDefinitionRelations
	{
		internal static readonly IEntityRelation CalendarEventEntityUsingRecurringDefinitionIdStatic = new CalendarEventRecurringDefinitionRelations().CalendarEventEntityUsingRecurringDefinitionId;
		internal static readonly IEntityRelation CalendarEventRecurringDefinitionTypeEntityUsingRecurringTypeIdStatic = new CalendarEventRecurringDefinitionRelations().CalendarEventRecurringDefinitionTypeEntityUsingRecurringTypeId;

		/// <summary>CTor</summary>
		static StaticCalendarEventRecurringDefinitionRelations()
		{
		}
	}
}
