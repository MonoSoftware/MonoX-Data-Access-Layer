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
	/// <summary>Implements the relations factory for the entity: CalendarEventEntry. </summary>
	public partial class CalendarEventEntryRelations
	{
		/// <summary>CTor</summary>
		public CalendarEventEntryRelations()
		{
		}

		/// <summary>Gets all relations of the CalendarEventEntryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CalendarEntityUsingCalendarId);
			toReturn.Add(this.CalendarEventEntityUsingCalendarEventId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between CalendarEventEntryEntity and CalendarEntity over the m:1 relation they have, using the relation between the fields:
		/// CalendarEventEntry.CalendarId - Calendar.Id
		/// </summary>
		public virtual IEntityRelation CalendarEntityUsingCalendarId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Calendar", false);
				relation.AddEntityFieldPair(CalendarFields.Id, CalendarEventEntryFields.CalendarId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntryEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CalendarEventEntryEntity and CalendarEventEntity over the m:1 relation they have, using the relation between the fields:
		/// CalendarEventEntry.CalendarEventId - CalendarEvent.Id
		/// </summary>
		public virtual IEntityRelation CalendarEventEntityUsingCalendarEventId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CalendarEvent", false);
				relation.AddEntityFieldPair(CalendarEventFields.Id, CalendarEventEntryFields.CalendarEventId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntryEntity", true);
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
	internal static class StaticCalendarEventEntryRelations
	{
		internal static readonly IEntityRelation CalendarEntityUsingCalendarIdStatic = new CalendarEventEntryRelations().CalendarEntityUsingCalendarId;
		internal static readonly IEntityRelation CalendarEventEntityUsingCalendarEventIdStatic = new CalendarEventEntryRelations().CalendarEventEntityUsingCalendarEventId;

		/// <summary>CTor</summary>
		static StaticCalendarEventEntryRelations()
		{
		}
	}
}
