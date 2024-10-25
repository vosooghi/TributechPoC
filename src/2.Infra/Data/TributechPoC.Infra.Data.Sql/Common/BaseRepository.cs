using TributechPoC.Core.Contracts.Data;

namespace TributechPoC.Infra.Data.Sql.Common
{

    public class BaseRepository<TEntity, TDbContext> : IRepository<TEntity>
        where TEntity : class
        where TDbContext : TributechPoCDbContext
    {
        protected readonly TDbContext _dbContext;

        public BaseRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(long id)
        {
            var entity = _dbContext.Set<TEntity>().Find(id);
            _dbContext.Set<TEntity>().Remove(entity);
            Commit();
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            Commit();
        }

        public void Insert(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            Commit();
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            Commit();
        }

        public TEntity Get(long id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public async Task<TEntity> GetAsync(long id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }


        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public IList<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }
    }
}
