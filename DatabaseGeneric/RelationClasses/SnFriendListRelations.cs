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
	/// <summary>Implements the relations factory for the entity: SnFriendList. </summary>
	public partial class SnFriendListRelations
	{
		/// <summary>CTor</summary>
		public SnFriendListRelations()
		{
		}

		/// <summary>Gets all relations of the SnFriendListEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnFriendListMemberEntityUsingFriendListId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnFriendListEntity and SnFriendListMemberEntity over the 1:n relation they have, using the relation between the fields:
		/// SnFriendList.Id - SnFriendListMember.FriendListId
		/// </summary>
		public virtual IEntityRelation SnFriendListMemberEntityUsingFriendListId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnFriendListMembers" , true);
				relation.AddEntityFieldPair(SnFriendListFields.Id, SnFriendListMemberFields.FriendListId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFriendListEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFriendListMemberEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnFriendListEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnFriendList.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnFriendListFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnFriendListEntity", true);
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
	internal static class StaticSnFriendListRelations
	{
		internal static readonly IEntityRelation SnFriendListMemberEntityUsingFriendListIdStatic = new SnFriendListRelations().SnFriendListMemberEntityUsingFriendListId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnFriendListRelations().AspnetUsersEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticSnFriendListRelations()
		{
		}
	}
}
