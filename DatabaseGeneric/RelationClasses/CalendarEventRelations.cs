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
	/// <summary>Implements the relations factory for the entity: CalendarEvent. </summary>
	public partial class CalendarEventRelations
	{
		/// <summary>CTor</summary>
		public CalendarEventRelations()
		{
		}

		/// <summary>Gets all relations of the CalendarEventEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CalendarEventEntryEntityUsingCalendarEventId);
			toReturn.Add(this.SnRelationshipEntityUsingCalendarEventId);
			toReturn.Add(this.AspnetUsersEntityUsingAuthorId);
			toReturn.Add(this.CalendarEntityUsingOwnerCalendarId);
			toReturn.Add(this.CalendarEventRecurringDefinitionEntityUsingRecurringDefinitionId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CalendarEventEntity and CalendarEventEntryEntity over the 1:n relation they have, using the relation between the fields:
		/// CalendarEvent.Id - CalendarEventEntry.CalendarEventId
		/// </summary>
		public virtual IEntityRelation CalendarEventEntryEntityUsingCalendarEventId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarEventEntries" , true);
				relation.AddEntityFieldPair(CalendarEventFields.Id, CalendarEventEntryFields.CalendarEventId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CalendarEventEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// CalendarEvent.Id - SnRelationship.CalendarEventId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingCalendarEventId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(CalendarEventFields.Id, SnRelationshipFields.CalendarEventId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CalendarEventEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// CalendarEvent.AuthorId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingAuthorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, CalendarEventFields.AuthorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CalendarEventEntity and CalendarEntity over the m:1 relation they have, using the relation between the fields:
		/// CalendarEvent.OwnerCalendarId - Calendar.Id
		/// </summary>
		public virtual IEntityRelation CalendarEntityUsingOwnerCalendarId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Calendar", false);
				relation.AddEntityFieldPair(CalendarFields.Id, CalendarEventFields.OwnerCalendarId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CalendarEventEntity and CalendarEventRecurringDefinitionEntity over the m:1 relation they have, using the relation between the fields:
		/// CalendarEvent.RecurringDefinitionId - CalendarEventRecurringDefinition.Id
		/// </summary>
		public virtual IEntityRelation CalendarEventRecurringDefinitionEntityUsingRecurringDefinitionId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CalendarEventRecurringDefinition", false);
				relation.AddEntityFieldPair(CalendarEventRecurringDefinitionFields.Id, CalendarEventFields.RecurringDefinitionId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventRecurringDefinitionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", true);
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
	internal static class StaticCalendarEventRelations
	{
		internal static readonly IEntityRelation CalendarEventEntryEntityUsingCalendarEventIdStatic = new CalendarEventRelations().CalendarEventEntryEntityUsingCalendarEventId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingCalendarEventIdStatic = new CalendarEventRelations().SnRelationshipEntityUsingCalendarEventId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingAuthorIdStatic = new CalendarEventRelations().AspnetUsersEntityUsingAuthorId;
		internal static readonly IEntityRelation CalendarEntityUsingOwnerCalendarIdStatic = new CalendarEventRelations().CalendarEntityUsingOwnerCalendarId;
		internal static readonly IEntityRelation CalendarEventRecurringDefinitionEntityUsingRecurringDefinitionIdStatic = new CalendarEventRelations().CalendarEventRecurringDefinitionEntityUsingRecurringDefinitionId;

		/// <summary>CTor</summary>
		static StaticCalendarEventRelations()
		{
		}
	}
}
