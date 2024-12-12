
namespace EasyERP.Contract.Infrastructure
{
    
    public interface IDefinitionRepository<T>
    {
        Task<int> GetAutoOrderAsync();
        Task<bool> NameExistsAsync(T entity, object text);

    }


}
