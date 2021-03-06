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
	/// <summary>Implements the relations factory for the entity: OaToken. </summary>
	public partial class OaTokenRelations
	{
		/// <summary>CTor</summary>
		public OaTokenRelations()
		{
		}

		/// <summary>Gets all relations of the OaTokenEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.OaConsumerEntityUsingConsumerId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between OaTokenEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// OaToken.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUsers", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, OaTokenFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OaTokenEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between OaTokenEntity and OaConsumerEntity over the m:1 relation they have, using the relation between the fields:
		/// OaToken.ConsumerId - OaConsumer.Id
		/// </summary>
		public virtual IEntityRelation OaConsumerEntityUsingConsumerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "OaConsumer", false);
				relation.AddEntityFieldPair(OaConsumerFields.Id, OaTokenFields.ConsumerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OaConsumerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OaTokenEntity", true);
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
	internal static class StaticOaTokenRelations
	{
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new OaTokenRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation OaConsumerEntityUsingConsumerIdStatic = new OaTokenRelations().OaConsumerEntityUsingConsumerId;

		/// <summary>CTor</summary>
		static StaticOaTokenRelations()
		{
		}
	}
}
