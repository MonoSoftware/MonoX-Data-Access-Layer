using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class PrivacyLevelEntity
    {
        public static MonoSoftware.Web.Workspace.Lookup<PrivacyLevelEntity> GetLookup()
        {
            return MonoSoftware.Web.Workspace.Lookup<PrivacyLevelEntity>.GetInstance(PrivacyLevelFields.PrivacyLevel);
        }

        public bool IsPrivacyLevelPublic
        {
            get { return Abrv == "Public"; }
        }

        public bool IsPrivacyLevelPrivate
        {
            get { return Abrv == "Private"; }
        }

        public bool IsPrivacyLevelFriends
        {
            get { return Abrv == "Friends"; }
        }



        public static PrivacyLevelEntity PrivacyLevelPublic
        {
            get { return GetLookup().Entities.First(entity => entity.IsPrivacyLevelPublic); }
        }

        public static PrivacyLevelEntity PrivacyLevelPrivate
        {
            get { return GetLookup().Entities.First(entity => entity.IsPrivacyLevelPrivate); }
        }

        public static PrivacyLevelEntity PrivacyLevelFriends
        {
            get { return GetLookup().Entities.First(entity => entity.IsPrivacyLevelFriends); }
        }

        
    }
}
