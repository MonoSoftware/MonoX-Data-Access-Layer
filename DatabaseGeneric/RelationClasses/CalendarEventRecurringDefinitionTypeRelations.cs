﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: CalendarEventRecurringDefinitionType. </summary>
	public partial class CalendarEventRecurringDefinitionTypeRelations
	{
		/// <summary>CTor</summary>
		public CalendarEventRecurringDefinitionTypeRelations()
		{
		}

		/// <summary>Gets all relations of the CalendarEventRecurringDefinitionTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CalendarEventRecurringDefinitionEntityUsingRecurringTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CalendarEventRecurringDefinitionTypeEntity and CalendarEventRecurringDefinitionEntity over the 1:n relation they have, using the relation between the fields:
		/// CalendarEventRecurringDefinitionType.Id - CalendarEventRecurringDefinition.RecurringTypeId
		/// </summary>
		public virtual IEntityRelation CalendarEventRecurringDefinitionEntityUsingRecurringTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarEventRecurringDefinitions" , true);
				relation.AddEntityFieldPair(CalendarEventRecurringDefinitionTypeFields.Id, CalendarEventRecurringDefinitionFields.RecurringTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventRecurringDefinitionTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventRecurringDefinitionEntity", false);
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
	internal static class StaticCalendarEventRecurringDefinitionTypeRelations
	{
		internal static readonly IEntityRelation CalendarEventRecurringDefinitionEntityUsingRecurringTypeIdStatic = new CalendarEventRecurringDefinitionTypeRelations().CalendarEventRecurringDefinitionEntityUsingRecurringTypeId;

		/// <summary>CTor</summary>
		static StaticCalendarEventRecurringDefinitionTypeRelations()
		{
		}
	}
}
