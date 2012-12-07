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
	/// <summary>Implements the relations factory for the entity: OaConsumer. </summary>
	public partial class OaConsumerRelations
	{
		/// <summary>CTor</summary>
		public OaConsumerRelations()
		{
		}

		/// <summary>Gets all relations of the OaConsumerEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.OaTokenEntityUsingConsumerId);
			toReturn.Add(this.SnEventEntityUsingOaConsumerId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between OaConsumerEntity and OaTokenEntity over the 1:n relation they have, using the relation between the fields:
		/// OaConsumer.Id - OaToken.ConsumerId
		/// </summary>
		public virtual IEntityRelation OaTokenEntityUsingConsumerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "OaTokens" , true);
				relation.AddEntityFieldPair(OaConsumerFields.Id, OaTokenFields.ConsumerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OaConsumerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OaTokenEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between OaConsumerEntity and SnEventEntity over the 1:n relation they have, using the relation between the fields:
		/// OaConsumer.Id - SnEvent.OaConsumerId
		/// </summary>
		public virtual IEntityRelation SnEventEntityUsingOaConsumerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnEvents" , true);
				relation.AddEntityFieldPair(OaConsumerFields.Id, SnEventFields.OaConsumerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OaConsumerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnEventEntity", false);
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
	internal static class StaticOaConsumerRelations
	{
		internal static readonly IEntityRelation OaTokenEntityUsingConsumerIdStatic = new OaConsumerRelations().OaTokenEntityUsingConsumerId;
		internal static readonly IEntityRelation SnEventEntityUsingOaConsumerIdStatic = new OaConsumerRelations().SnEventEntityUsingOaConsumerId;

		/// <summary>CTor</summary>
		static StaticOaConsumerRelations()
		{
		}
	}
}
