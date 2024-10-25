namespace TributechPoC.Core.Contracts.Data
{

    /// <summary>
    /// the structure of main functionalities of Repository.
    /// </summary>
    public interface IRepository<TEntity> where TEntity : class        
    {
        /// <summary>
        /// Delete an entity with Id
        /// </summary>
        /// <param name="id">Id</param>
        void Delete(long id);

        /// <summary>
        /// Delete the given entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Insert the entity into the Database
        /// </summary>
        /// <param name="entity">Entity</param>
        void Insert(TEntity entity);

        /// <summary>
        /// Insert the entity into the Database
        /// </summary>
        /// <param name="entity">Entity</param>
        Task InsertAsync(TEntity entity);

        /// <summary>
        /// Returns an entity with specified Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Entity</returns>
        TEntity Get(long id);

        Task<TEntity> GetAsync(long id);
    }
}
