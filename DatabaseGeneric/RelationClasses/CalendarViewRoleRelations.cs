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
	/// <summary>Implements the relations factory for the entity: CalendarViewRole. </summary>
	public partial class CalendarViewRoleRelations
	{
		/// <summary>CTor</summary>
		public CalendarViewRoleRelations()
		{
		}

		/// <summary>Gets all relations of the CalendarViewRoleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetRolesEntityUsingRoleId);
			toReturn.Add(this.CalendarEntityUsingCalendarId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between CalendarViewRoleEntity and AspnetRolesEntity over the m:1 relation they have, using the relation between the fields:
		/// CalendarViewRole.RoleId - AspnetRoles.RoleId
		/// </summary>
		public virtual IEntityRelation AspnetRolesEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetRoles", false);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, CalendarViewRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarViewRoleEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CalendarViewRoleEntity and CalendarEntity over the m:1 relation they have, using the relation between the fields:
		/// CalendarViewRole.CalendarId - Calendar.Id
		/// </summary>
		public virtual IEntityRelation CalendarEntityUsingCalendarId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Calendar", false);
				relation.AddEntityFieldPair(CalendarFields.Id, CalendarViewRoleFields.CalendarId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CalendarViewRoleEntity", true);
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
	internal static class StaticCalendarViewRoleRelations
	{
		internal static readonly IEntityRelation AspnetRolesEntityUsingRoleIdStatic = new CalendarViewRoleRelations().AspnetRolesEntityUsingRoleId;
		internal static readonly IEntityRelation CalendarEntityUsingCalendarIdStatic = new CalendarViewRoleRelations().CalendarEntityUsingCalendarId;

		/// <summary>CTor</summary>
		static StaticCalendarViewRoleRelations()
		{
		}
	}
}
