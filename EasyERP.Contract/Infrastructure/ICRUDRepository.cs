using System.Net;


namespace EasyERP.Contract.Infrastructure
{    

    public interface ICRUDRepository<TEntity>
    {
        Task<TEntity> GetAsync(Guid id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);

    }
    
}
