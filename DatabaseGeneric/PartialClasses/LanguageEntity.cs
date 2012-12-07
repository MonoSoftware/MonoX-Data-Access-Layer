using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class LanguageEntity
    {
        public static MonoSoftware.Web.Workspace.Lookup<LanguageEntity> GetLookup()
        {
            return MonoSoftware.Web.Workspace.Lookup<LanguageEntity>.GetInstance(LanguageFields.LanguageName);
        }

        public bool IsDefault
        {
            get { return DefaultLanguage.GetValueOrDefault(); }
        }        
        
    }
}
