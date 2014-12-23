using System;
using MonoSoftware.LLBLGen;
using MonoSoftware.MonoX.DAL.EntityClasses;
using MonoSoftware.Web;
using MonoSoftware.Core;
using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Xml;
using System.Web;
using MonoSoftware.MonoX.DAL.HelperClasses;

namespace MonoSoftware.MonoX.DAL.Auditing
{
    [Serializable]
    public class Auditor : LLBLGenProGenericAuditor<AuditInfoEntity>
    {
        private static bool? _enableDataAccessAuditing = null;
        // TODO: These are preset, reserved for future use
        private static bool? _enableDataAccessAuditingInsert = true;
        private static bool? _enableDataAccessAuditingFetch = false;
        private static bool? _enableDataAccessAuditingSet = false;
        private static bool? _enableDataAccessAuditingUpdate = false;
        private static bool? _enableDataAccessAuditingDelete = false;

        #region Properties

        /// <summary>
        /// Gets Data Access Auditing for CRUD operations
        /// </summary>
        public static bool EnableDataAccessAuditing
        {
            get
            {
                if (!_enableDataAccessAuditing.HasValue)
                    _enableDataAccessAuditing = Convert.ToBoolean(System.Web.Configuration.WebConfigurationManager.AppSettings["AuditLogEnabled"]);
                return _enableDataAccessAuditing.GetValueOrDefault();
            }
        }

        /// <summary>
        /// Gets Data Access Auditing for INSERT operations
        /// </summary>
        public static bool EnableDataAccessAuditingInsert
        {
            get
            {
                if (!_enableDataAccessAuditingInsert.HasValue)
                    _enableDataAccessAuditingInsert = Convert.ToBoolean(System.Web.Configuration.WebConfigurationManager.AppSettings["AuditLogAuditInsert"]);
                return _enableDataAccessAuditingInsert.GetValueOrDefault();
            }
        }

        /// <summary>
        /// Gets Data Access Auditing for READ operations
        /// </summary>
        public static bool EnableDataAccessAuditingFetch
        {
            get
            {
                if (!_enableDataAccessAuditingFetch.HasValue)
                    _enableDataAccessAuditingFetch = Convert.ToBoolean(System.Web.Configuration.WebConfigurationManager.AppSettings["AuditLogAuditFetch"]);
                return _enableDataAccessAuditingFetch.GetValueOrDefault();
            }
        }

        /// <summary>
        /// Gets Data Access Auditing for SET operations
        /// </summary>
        public static bool EnableDataAccessAuditingSet
        {
            get
            {
                if (!_enableDataAccessAuditingSet.HasValue)
                    _enableDataAccessAuditingSet = Convert.ToBoolean(System.Web.Configuration.WebConfigurationManager.AppSettings["AuditLogAuditSet"]);
                return _enableDataAccessAuditingSet.GetValueOrDefault();
            }
        }

        /// <summary>
        /// Gets Data Access Auditing for Update operations
        /// </summary>
        public static bool EnableDataAccessAuditingUpdate
        {
            get
            {
                if (!_enableDataAccessAuditingUpdate.HasValue)
                    _enableDataAccessAuditingUpdate = Convert.ToBoolean(System.Web.Configuration.WebConfigurationManager.AppSettings["AuditLogAuditUpdate"]);
                return _enableDataAccessAuditingUpdate.GetValueOrDefault();
            }
        }

        /// <summary>
        /// Gets Data Access Auditing for Delete operations
        /// </summary>
        public static bool EnableDataAccessAuditingDelete
        {
            get
            {
                if (!_enableDataAccessAuditingDelete.HasValue)
                    _enableDataAccessAuditingDelete = Convert.ToBoolean(System.Web.Configuration.WebConfigurationManager.AppSettings["AuditLogAuditDelete"]);
                return _enableDataAccessAuditingDelete.GetValueOrDefault();
            }
        }

        protected List<Type> includedEntityTypes 
        { 
            get;
            set; 
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        public Auditor()
            : base()
        {
            includedEntityTypes = null;
        }
        #endregion

        public override void InitializeAuditInfoEntity(AuditInfoEntity auditInfoEntity)
        {
            ((AuditInfoEntity)auditInfoEntity).Id = GuidExtension.NewSequentialGuid();
        }

        public static void AppendEntityInformation(List<string> messages, IEntity2 entity)
        {
            messages.Add(String.Format("Entity Name: {0}", entity.LLBLGenProEntityName));
            messages.Add(String.Format("Entity Id: {0}", entity.PrimaryKeyFields[0].CurrentValue));
            AppendFieldsInformation(messages, entity.Fields);
        }

        public static void AppendFieldsInformation(List<string> messages, IEntityFields2 fields)
        {
            foreach (IEntityField2 field in fields)
            {
                messages.Add(String.Format("Field name: {0} [Value: {1}]", field.Name, field.CurrentValue));
            }
        }

        public static void LogCustomAction(string message, object data)
        {
            using (IDataAccessAdapter adapter = GetAdapter())
                Auditor.LogCustomAction<Auditor>(adapter, message, data);
        }

        public static void LogCustomAction(string message, object data, AuditType auditType)
        {
            using (IDataAccessAdapter adapter = GetAdapter())
                Auditor.LogCustomAction<Auditor>(adapter, message, data, (int)auditType, auditType.ToString());
        }

        public static void LogCustomAction(List<string> messages, object data)
        {
            using (IDataAccessAdapter adapter = GetAdapter())
                Auditor.LogCustomAction<Auditor>(adapter, messages, data);
        }

        public static void LogCustomAction(List<string> messages, object data, AuditType auditType)
        {
            using (IDataAccessAdapter adapter = GetAdapter())
                Auditor.LogCustomAction<Auditor>(adapter, messages, data, (int)auditType, auditType.ToString());
        }

        public override bool HasDataToXmlSerialize
        {
            get
            {
                return this._auditInfoEntities.Count > 0;
            }
        }

        public override void AuditDirectDeleteOfEntities(Type typeOfEntity, IPredicate filter, IRelationCollection relations, int numberOfEntitiesDeleted)
        {
            if (EnableDataAccessAuditing && EnableDataAccessAuditingDelete && IsEntityAuditable(typeOfEntity))
            {
                if (typeOfEntity.Equals(typeof(AuditInfoEntity))) return;
                IEntityCore entity = (IEntityCore)ActivatorExtension.CreateInstance(typeOfEntity);
                IAuditInfoEntity auditInfo = CreateAuditInfoEntity(entity, MonoSoftware.LLBLGen.AuditType.DirectDeleteOfEntities);
                if (auditInfo == null) return;

                auditInfo.ActionDataLog.Messages.Add(String.Format("{0} Entities of type {1} deleted.", numberOfEntitiesDeleted, entity.LLBLGenProEntityName));

                if (EnableIntensiveAuditing)
                {
                    auditInfo.ActionDataLog.Data = BinarySerializer.Serialize(new Tuple<IPredicate, IRelationCollection>(filter, relations));
                }

                _auditInfoEntities.Add(entity.ObjectID, auditInfo);
            }

            //base.AuditDirectDeleteOfEntities(typeOfEntity, filter, relations, numberOfEntitiesDeleted);
        }

        internal bool IsAuditActionValid(IEntityCore entity)
        {
            if (entity == null) return false;
            //We should skip the entites of TAuditInfoEntity type 
            if ((entity != null) && (entity.GetType().Equals(typeof(AuditInfoEntity))))
                return false;
            return true;
        }

        public override void AuditDirectUpdateOfEntities(IEntityCore entity, IPredicate filter, IRelationCollection relations, int numberOfEntitiesUpdated)
        {
            if (EnableDataAccessAuditing && EnableDataAccessAuditingUpdate && IsEntityAuditable(entity))
            {
                if (!IsAuditActionValid(entity)) return;
                IAuditInfoEntity auditInfo = CreateAuditInfoEntity(entity, MonoSoftware.LLBLGen.AuditType.DirectUpdateOfEntities);
                if (auditInfo == null) return;

                auditInfo.ActionDataLog.Messages.Add(String.Format("{0} Entities of type {1} updated.", numberOfEntitiesUpdated, entity.LLBLGenProEntityName));

                if (EnableIntensiveAuditing)
                {
                    auditInfo.ActionDataLog.Data = BinarySerializer.Serialize(new Tuple<IPredicate, IRelationCollection>(filter, relations));
                }

                _auditInfoEntities.Add(entity.ObjectID, auditInfo);
            }

            //base.AuditDirectUpdateOfEntities(entity, filter, relations, numberOfEntitiesUpdated);
        }

        public override void AuditDeleteOfEntity(IEntityCore entity)
        {
            if (EnableDataAccessAuditing && EnableDataAccessAuditingDelete && IsEntityAuditable(entity))
                base.AuditDeleteOfEntity(entity);
        }

        public override void AuditInsertOfNewEntity(IEntityCore entity)
        {
            if (EnableDataAccessAuditing && EnableDataAccessAuditingInsert && IsEntityAuditable(entity))
                base.AuditInsertOfNewEntity(entity);
        }
        
        public override void AuditUpdateOfExistingEntity(IEntityCore entity)
        {
            if (EnableDataAccessAuditing && EnableDataAccessAuditingUpdate && IsEntityAuditable(entity))
                base.AuditUpdateOfExistingEntity(entity);
        }

        public override void AuditLoadOfEntity(IEntityCore entity)
        {
            if (EnableDataAccessAuditing && EnableDataAccessAuditingFetch && IsEntityAuditable(entity))
                base.AuditLoadOfEntity(entity);
        }

        //if you override auditEntityFieldSet to check EnableDataAccessAuditing, you also need to override a AuditReferenceOfRelatedEntity,
        public override void AuditEntityFieldSet(IEntityCore entity, int fieldIndex, object originalValue)
        {
            if (EnableDataAccessAuditing && EnableDataAccessAuditingSet && IsEntityAuditable(entity))
                base.AuditEntityFieldSet(entity, fieldIndex, originalValue);
        }

        public override void AuditReferenceOfRelatedEntity(IEntityCore entity, IEntityCore relatedEntity, string mappedFieldName)
        {
            if (EnableDataAccessAuditing && EnableDataAccessAuditingSet && IsEntityAuditable(entity))
                base.AuditReferenceOfRelatedEntity(entity, relatedEntity, mappedFieldName);
        }

        public override void AuditDereferenceOfRelatedEntity(IEntityCore entity, IEntityCore relatedEntity, string mappedFieldName)
        {
            if (EnableDataAccessAuditing && EnableDataAccessAuditingSet && IsEntityAuditable(entity))
                base.AuditDereferenceOfRelatedEntity(entity, relatedEntity, mappedFieldName);
        }

        public override System.Collections.IList GetAuditEntitiesToSave()
        {
            SetUserInfo();
            return base.GetAuditEntitiesToSave();
        }

        public override void ReadXml(XmlReader reader)
        {
            var lst = (List<AuditInfoEntity>)XMLSerializer.Deserialize(
                      typeof(List<AuditInfoEntity>),
                      reader.ReadString());
            _auditInfoEntities = new AuditInfoCollection<AuditInfoEntity>(this.SerializationMode);

            foreach (var item in lst)
            {
                if (this.SerializationMode == AuditSerializationMode.BinarySerialization)
                    item.ActionDataLog = BinarySerializer.Deserialize(item.ActionDataBinary) as ActionData;
                else if (this.SerializationMode == AuditSerializationMode.XmlSerialization)
                    item.ActionDataLog = XMLSerializer.Deserialize(typeof(ActionData), item.ActionData) as ActionData;

                _auditInfoEntities.Add(item.Id, item);
            }

            return;
        }

        public override void WriteXml(XmlWriter writer, XmlFormatAspect aspects, Dictionary<Guid, IEntityCore> processedObjectIDs)
        {
            writer.WriteRaw(XMLSerializer.Serialize(_auditInfoEntities.ToList()));
            return;
        }

        protected virtual bool IsEntityAuditable(IEntityCore entity)
        {
            return (includedEntityTypes == null || includedEntityTypes.Contains(entity.GetType()));
        }

        protected virtual bool IsEntityAuditable(Type entityType)
        {
            return (includedEntityTypes == null || includedEntityTypes.Contains(entityType));
        }
        
        void SetUserInfo()
        {
            if (_auditInfoEntities != null && _auditInfoEntities.Count > 0)
            {
                Guid userId = Guid.Empty;
                String actionPerformedByUser = null;
                if (HttpContext.Current != null && 
                    HttpContext.Current.User != null && 
                    HttpContext.Current.User.Identity != null && 
                    !String.IsNullOrEmpty(HttpContext.Current.User.Identity.Name) && 
                    HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    userId = HttpContext.Current.User.GetProviderUserKey();
                    actionPerformedByUser = HttpContext.Current.User.Identity.Name;
                }

                for (int i = 0; i < _auditInfoEntities.Count; i++)
                {
                    var item = _auditInfoEntities.GetAt(i) as AuditInfoEntity;
                    if (item != null)
                    {
                        item.ActionPerformedByUser = actionPerformedByUser;
                        item.UserId = userId;
                        item.UserAgent = String.Empty;
                        item.Referrer = String.Empty;
                        item.IpAddress = String.Empty;

                        if (HttpContext.Current != null && HttpContext.Current.Request != null)
                        {
                            if (HttpContext.Current.Request.UserAgent != null)
                                item.UserAgent = ToTrimmedWordString(HttpContext.Current.Request.UserAgent, AuditInfoFields.UserAgent.MaxLength, true);

                            if (HttpContext.Current.Request.UrlReferrer != null)
                                item.Referrer = ToTrimmedWordString(HttpContext.Current.Request.UrlReferrer.AbsoluteUri, AuditInfoFields.Referrer.MaxLength, true);

                            item.IpAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                        }

                        //HttpContext.Current.User not available when just logging in.
                        if (GuidExtension.IsNullOrEmpty(item.UserId) && item.ActionDataLog != null && item.ActionDataLog.Data != null)
                        {
                            if (item.ActionDataLog.Data is LogInAudit)
                            {
                                var logInData = item.ActionDataLog.Data as LogInAudit;
                                item.UserId = logInData.UserId;
                            }
                            else if (item.ActionDataLog.Data is LogOutAudit)
                            {
                                var logOutData = item.ActionDataLog.Data as LogOutAudit;
                                item.UserId = logOutData.UserId;
                            }
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Trimm string by adding ellipsis after last space indicated by the length parameter.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="length">Limit.</param>
        /// <param name="forceLength">Do not allow strings greater than <see cref="length"/>.</param>
        /// <returns></returns>
        public string ToTrimmedWordString(string value, int length, bool forceLength)
        {
            const string ellipsis = "...";

            if (value.Length <= length) return value;
            int nLastSpace = value.LastIndexOf(" ", length - 1);
            if (nLastSpace == -1 || (forceLength && nLastSpace >= length - ellipsis.Length - 1))
            {
                if (forceLength)
                    return value.Substring(0, length - ellipsis.Length) + ellipsis;
                else
                    return value;
            }
            return value.Substring(0, nLastSpace) + ellipsis;
        }

        private static IDataAccessAdapter GetAdapter()
        {
            return MonoSoftware.Web.Workspace.WebContext.GetContext(typeof(UserProfileEntity).Assembly).GetAdapter();
        }
 
    }
}
