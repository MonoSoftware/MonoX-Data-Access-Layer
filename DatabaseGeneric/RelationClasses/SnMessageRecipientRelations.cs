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
	/// <summary>Implements the relations factory for the entity: SnMessageRecipient. </summary>
	public partial class SnMessageRecipientRelations
	{
		/// <summary>CTor</summary>
		public SnMessageRecipientRelations()
		{
		}

		/// <summary>Gets all relations of the SnMessageRecipientEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.SnMessageEntityUsingMessageId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SnMessageRecipientEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnMessageRecipient.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnMessageRecipientFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageRecipientEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnMessageRecipientEntity and SnMessageEntity over the m:1 relation they have, using the relation between the fields:
		/// SnMessageRecipient.MessageId - SnMessage.Id
		/// </summary>
		public virtual IEntityRelation SnMessageEntityUsingMessageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnMessage", false);
				relation.AddEntityFieldPair(SnMessageFields.Id, SnMessageRecipientFields.MessageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageRecipientEntity", true);
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
	internal static class StaticSnMessageRecipientRelations
	{
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnMessageRecipientRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation SnMessageEntityUsingMessageIdStatic = new SnMessageRecipientRelations().SnMessageEntityUsingMessageId;

		/// <summary>CTor</summary>
		static StaticSnMessageRecipientRelations()
		{
		}
	}
}
