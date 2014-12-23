namespace MonoSoftware.MonoX.DAL.Auditing
{
    /// <summary>
    /// Audit type enum.
    /// </summary>
    [System.Flags]
    public enum AuditType 
    {
        /// <summary>
        /// Delete of entity.
        /// </summary>
        DeleteOfEntity = 1,
        /// <summary>
        /// Direct delete of entities.
        /// </summary>
        DirectDeleteOfEntities,
        /// <summary>
        /// Direct update of entities.
        /// </summary>
        DirectUpdateOfEntities,
        /// <summary>
        /// Dereference of related entity.
        /// </summary>
        DereferenceOfRelatedEntity,
        /// <summary>
        /// Reference of related entity.
        /// </summary>
        ReferenceOfRelatedEntity,
        /// <summary>
        /// Entity field set.
        /// </summary>
        EntityFieldSet,
        /// <summary>
        /// Insert of new entity.
        /// </summary>
        InsertOfNewEntity,
        /// <summary>
        /// Update of existing entity.
        /// </summary>
        UpdateOfExistingEntity,
        /// <summary>
        /// Custom audit type.
        /// </summary>
        Custom,
        /// <summary>
        /// Audits the successful load of an entity from the database.
        /// </summary>
        LoadOfEntity,

        // Additional 

        /// <summary>
        /// Audits Log In action.
        /// </summary>
        LogInAction,
        /// <summary>
        /// Audits Log Out action.
        /// </summary>
        LogOutAction
    }
}
