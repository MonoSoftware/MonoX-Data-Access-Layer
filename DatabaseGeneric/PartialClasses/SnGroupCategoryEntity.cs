using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class SnGroupCategoryEntity
    {
        #region Fields
        public const string GeneralItemName = "General";
        #endregion

        #region Properties
        public string DisplayName
        {
            get
            {
                return String.Format("{0} ({1})", this.Name, LanguageEntity.GetLookup().GetEntity(this.LanguageId).CultureName);
            }
        }

        public bool IsGeneral
        {
            get { return Slug == GeneralItemName; }
        }
        #endregion

        #region Methods
        public static MonoSoftware.Web.Workspace.Lookup<SnGroupCategoryEntity> GetLookup()
        {
            return MonoSoftware.Web.Workspace.Lookup<SnGroupCategoryEntity>.GetInstance(SnGroupCategoryFields.Name);
        }

        public static List<SnGroupCategoryEntity> GetCategoriesByLanguage(Guid languageId)
        {
            return GetLookup().Entities.Where(p => p.LanguageId.Equals(languageId)).ToList();
        }        
        #endregion
    }
}
