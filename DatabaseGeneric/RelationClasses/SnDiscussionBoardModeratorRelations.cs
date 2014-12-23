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
	/// <summary>Implements the relations factory for the entity: SnDiscussionBoardModerator. </summary>
	public partial class SnDiscussionBoardModeratorRelations
	{
		/// <summary>CTor</summary>
		public SnDiscussionBoardModeratorRelations()
		{
		}

		/// <summary>Gets all relations of the SnDiscussionBoardModeratorEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.SnDiscussionBoardEntityUsingSnDiscussionBoardId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardModeratorEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionBoardModerator.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnDiscussionBoardModeratorFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardModeratorEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnDiscussionBoardModeratorEntity and SnDiscussionBoardEntity over the m:1 relation they have, using the relation between the fields:
		/// SnDiscussionBoardModerator.SnDiscussionBoardId - SnDiscussionBoard.Id
		/// </summary>
		public virtual IEntityRelation SnDiscussionBoardEntityUsingSnDiscussionBoardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnDiscussionBoard", false);
				relation.AddEntityFieldPair(SnDiscussionBoardFields.Id, SnDiscussionBoardModeratorFields.SnDiscussionBoardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnDiscussionBoardModeratorEntity", true);
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
	internal static class StaticSnDiscussionBoardModeratorRelations
	{
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnDiscussionBoardModeratorRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation SnDiscussionBoardEntityUsingSnDiscussionBoardIdStatic = new SnDiscussionBoardModeratorRelations().SnDiscussionBoardEntityUsingSnDiscussionBoardId;

		/// <summary>CTor</summary>
		static StaticSnDiscussionBoardModeratorRelations()
		{
		}
	}
}
