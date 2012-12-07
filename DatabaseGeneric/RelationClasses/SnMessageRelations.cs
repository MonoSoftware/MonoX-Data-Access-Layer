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
	/// <summary>Implements the relations factory for the entity: SnMessage. </summary>
	public partial class SnMessageRelations
	{
		/// <summary>CTor</summary>
		public SnMessageRelations()
		{
		}

		/// <summary>Gets all relations of the SnMessageEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SnMessageEntityUsingInReplyToMessageId);
			toReturn.Add(this.SnMessageRecipientEntityUsingMessageId);
			toReturn.Add(this.SnRelationshipEntityUsingMessageId);
			toReturn.Add(this.AspnetUsersEntityUsingUserId);
			toReturn.Add(this.SnMessageEntityUsingIdInReplyToMessageId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SnMessageEntity and SnMessageEntity over the 1:n relation they have, using the relation between the fields:
		/// SnMessage.Id - SnMessage.InReplyToMessageId
		/// </summary>
		public virtual IEntityRelation SnMessageEntityUsingInReplyToMessageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnReplyMessages" , true);
				relation.AddEntityFieldPair(SnMessageFields.Id, SnMessageFields.InReplyToMessageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnMessageEntity and SnMessageRecipientEntity over the 1:n relation they have, using the relation between the fields:
		/// SnMessage.Id - SnMessageRecipient.MessageId
		/// </summary>
		public virtual IEntityRelation SnMessageRecipientEntityUsingMessageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnMessageRecipients" , true);
				relation.AddEntityFieldPair(SnMessageFields.Id, SnMessageRecipientFields.MessageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageRecipientEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SnMessageEntity and SnRelationshipEntity over the 1:n relation they have, using the relation between the fields:
		/// SnMessage.Id - SnRelationship.MessageId
		/// </summary>
		public virtual IEntityRelation SnRelationshipEntityUsingMessageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SnRelationships" , true);
				relation.AddEntityFieldPair(SnMessageFields.Id, SnRelationshipFields.MessageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnRelationshipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SnMessageEntity and AspnetUsersEntity over the m:1 relation they have, using the relation between the fields:
		/// SnMessage.UserId - AspnetUsers.UserId
		/// </summary>
		public virtual IEntityRelation AspnetUsersEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetUser", false);
				relation.AddEntityFieldPair(AspnetUsersFields.UserId, SnMessageFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetUsersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SnMessageEntity and SnMessageEntity over the m:1 relation they have, using the relation between the fields:
		/// SnMessage.InReplyToMessageId - SnMessage.Id
		/// </summary>
		public virtual IEntityRelation SnMessageEntityUsingIdInReplyToMessageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SnMessage", false);
				relation.AddEntityFieldPair(SnMessageFields.Id, SnMessageFields.InReplyToMessageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SnMessageEntity", true);
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
	internal static class StaticSnMessageRelations
	{
		internal static readonly IEntityRelation SnMessageEntityUsingInReplyToMessageIdStatic = new SnMessageRelations().SnMessageEntityUsingInReplyToMessageId;
		internal static readonly IEntityRelation SnMessageRecipientEntityUsingMessageIdStatic = new SnMessageRelations().SnMessageRecipientEntityUsingMessageId;
		internal static readonly IEntityRelation SnRelationshipEntityUsingMessageIdStatic = new SnMessageRelations().SnRelationshipEntityUsingMessageId;
		internal static readonly IEntityRelation AspnetUsersEntityUsingUserIdStatic = new SnMessageRelations().AspnetUsersEntityUsingUserId;
		internal static readonly IEntityRelation SnMessageEntityUsingIdInReplyToMessageIdStatic = new SnMessageRelations().SnMessageEntityUsingIdInReplyToMessageId;

		/// <summary>CTor</summary>
		static StaticSnMessageRelations()
		{
		}
	}
}
