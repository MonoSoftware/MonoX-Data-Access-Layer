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
	/// <summary>Implements the relations factory for the entity: AspnetPersonalizationAllUsers. </summary>
	public partial class AspnetPersonalizationAllUsersRelations
	{
		/// <summary>CTor</summary>
		public AspnetPersonalizationAllUsersRelations()
		{
		}

		/// <summary>Gets all relations of the AspnetPersonalizationAllUsersEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AspnetPathsEntityUsingPathId);
			return toReturn;
		}

		#region Class Property Declarations


		/// <summary>Returns a new IEntityRelation object, between AspnetPersonalizationAllUsersEntity and AspnetPathsEntity over the 1:1 relation they have, using the relation between the fields:
		/// AspnetPersonalizationAllUsers.PathId - AspnetPaths.PathId
		/// </summary>
		public virtual IEntityRelation AspnetPathsEntityUsingPathId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "AspnetPaths", false);



				relation.AddEntityFieldPair(AspnetPathsFields.PathId, AspnetPersonalizationAllUsersFields.PathId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPathsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AspnetPersonalizationAllUsersEntity", true);
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
	internal static class StaticAspnetPersonalizationAllUsersRelations
	{
		internal static readonly IEntityRelation AspnetPathsEntityUsingPathIdStatic = new AspnetPersonalizationAllUsersRelations().AspnetPathsEntityUsingPathId;

		/// <summary>CTor</summary>
		static StaticAspnetPersonalizationAllUsersRelations()
		{
		}
	}
}
