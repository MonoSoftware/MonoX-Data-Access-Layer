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
	/// <summary>Implements the relations factory for the entity: Calendar. </summary>
	public partial class CalendarRelations
	{
		/// <summary>CTor</summary>
		public CalendarRelations()
		{
		}

		/// <summary>Gets all relations of the CalendarEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CalendarEditRoleEntityUsingCalendarId);
			toReturn.Add(this.CalendarEventEntityUsingOwnerCalendarId);
			toReturn.Add(this.CalendarEventEntryEntityUsingCalendarId);
			toReturn.Add(this.CalendarModeratorEntityUsingCalendarId);
			toReturn.Add(this.CalendarViewRoleEntityUsingCalendarId);
			toReturn.Add(this.AspnetUsersEntityUsingOwnerId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CalendarEntity and CalendarEditRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// Calendar.Id - CalendarEditRole.CalendarId
		/// </summary>
		public virtual IEntityRelation CalendarEditRoleEntityUsingCalendarId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarEditRoles" , true);
				relation.AddEntityFieldPair(CalendarFields.Id, CalendarEditRoleFields.CalendarId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEditRoleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CalendarEntity and CalendarEventEntity over the 1:n relation they have, using the relation between the fields:
		/// Calendar.Id - CalendarEvent.OwnerCalendarId
		/// </summary>
		public virtual IEntityRelation CalendarEventEntityUsingOwnerCalendarId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarEvents" , true);
				relation.AddEntityFieldPair(CalendarFields.Id, CalendarEventFields.OwnerCalendarId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CalendarEntity and CalendarEventEntryEntity over the 1:n relation they have, using the relation between the fields:
		/// Calendar.Id - CalendarEventEntry.CalendarId
		/// </summary>
		public virtual IEntityRelation CalendarEventEntryEntityUsingCalendarId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarEventEntries" , true);
				relation.AddEntityFieldPair(CalendarFields.Id, CalendarEventEntryFields.CalendarId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEventEntryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CalendarEntity and CalendarModeratorEntity over the 1:n relation they have, using the relation between the fields:
		/// Calendar.Id - CalendarModerator.CalendarId
		/// </summary>
		public virtual IEntityRelation CalendarModeratorEntityUsingCalendarId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarModerators" , true);
				relation.AddEntityFieldPair(CalendarFields.Id, CalendarModeratorFields.CalendarId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarModeratorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CalendarEntity and CalendarViewRoleEntity over the 1:n relation they have, using the relation between the fields:
		/// Calendar.Id - CalendarViewRole.CalendarId
		/// </summary>
		public virtual IEntityRelation CalendarViewRoleEntityUsingCalendarId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CalendarViewRoles" , true);
				relation.AddEntityFieldPair(CalendarFields.Id, CalendarViewRoleFields.CalendarId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarViewRoleEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CalendarEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// Calendar.OwnerId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingOwnerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, CalendarFields.OwnerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", true);
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
	internal static class StaticCalendarRelations
	{
		internal static readonly IEntityRelation CalendarEditRoleEntityUsingCalendarIdStatic = new CalendarRelations().CalendarEditRoleEntityUsingCalendarId;
		internal static readonly IEntityRelation CalendarEventEntityUsingOwnerCalendarIdStatic = new CalendarRelations().CalendarEventEntityUsingOwnerCalendarId;
		internal static readonly IEntityRelation CalendarEventEntryEntityUsingCalendarIdStatic = new CalendarRelations().CalendarEventEntryEntityUsingCalendarId;
		internal static readonly IEntityRelation CalendarModeratorEntityUsingCalendarIdStatic = new CalendarRelations().CalendarModeratorEntityUsingCalendarId;
		internal static readonly IEntityRelation CalendarViewRoleEntityUsingCalendarIdStatic = new CalendarRelations().CalendarViewRoleEntityUsingCalendarId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingOwnerIdStatic = new CalendarRelations().AspnetUsersEntityUsingOwnerId;

		/// <summary>CTor</summary>
		static StaticCalendarRelations()
		{
		}
	}
}
