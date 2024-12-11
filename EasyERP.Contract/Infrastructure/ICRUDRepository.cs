

using System.Net;

namespace EasyERP.Contract.Infrastructure
{
    public interface ICRUDRepository<TEntity>
    {        
        TEntity Get(Guid id);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);

    }

    public interface ICRUDAsyncRepository<TEntity>
    {
        Task<TEntity> GetAsync(Guid id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<HttpStatusCode> DeleteAsync(TEntity entity);

    }
    
}
