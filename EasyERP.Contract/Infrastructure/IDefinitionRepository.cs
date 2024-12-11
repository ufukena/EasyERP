
namespace EasyERP.Contract.Infrastructure
{
    public interface IDefinitionRepository<T>
    {
        int GetAutoOrder();
        bool NameExists(T entity, object text);        

    }

    public interface IDefinitionAsyncRepository<T>
    {
        Task<int> GetAutoOrderAsync();
        Task<bool> NameExistsAsync(T entity, object text);

    }


}
