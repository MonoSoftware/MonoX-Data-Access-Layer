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
	/// <summary>Implements the relations factory for the entity: NewsletterRole. </summary>
	public partial class NewsletterRoleRelations
	{
		/// <summary>CTor</summary>
		public NewsletterRoleRelations()
		{
		}

		/// <summary>Gets all relations of the NewsletterRoleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetRolesEntityUsingRoleId);
			toReturn.Add(this.NewsletterEntityUsingNewsletterId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between NewsletterRoleEntity and AspnetRolesEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsletterRole.RoleId - AspnetRoles.RoleId
		/// </summary>
		public virtual IEntityRelation AspnetRolesEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AspnetRole", false);
				relation.AddEntityFieldPair(AspnetRolesFields.RoleId, NewsletterRoleFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetRolesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterRoleEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between NewsletterRoleEntity and NewsletterEntity over the m:1 relation they have, using the relation between the fields:
		/// NewsletterRole.NewsletterId - Newsletter.Id
		/// </summary>
		public virtual IEntityRelation NewsletterEntityUsingNewsletterId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Newsletter", false);
				relation.AddEntityFieldPair(NewsletterFields.Id, NewsletterRoleFields.NewsletterId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NewsletterRoleEntity", true);
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
	internal static class StaticNewsletterRoleRelations
	{
		internal static readonly IEntityRelation AspnetRolesEntityUsingRoleIdStatic = new NewsletterRoleRelations().AspnetRolesEntityUsingRoleId;
		internal static readonly IEntityRelation NewsletterEntityUsingNewsletterIdStatic = new NewsletterRoleRelations().NewsletterEntityUsingNewsletterId;

		/// <summary>CTor</summary>
		static StaticNewsletterRoleRelations()
		{
		}
	}
}
