

namespace EasyERP.Application.Infrastructure.Contract
{
    public interface ICRUDRepository<TEntity>
    {
        
        Task<TEntity> Get(Guid id);

        int Create(TEntity entity);

        int Update(TEntity entity);

        int Delete(TEntity entity);

    }

    public interface ICRUDRepository<TEntity,TParameter>
    {
        
        TEntity Get(int id);

        TEntity Create(TParameter entity);

        TEntity Update(TParameter entity);

        int Delete(TParameter entity);

    }

    

}
