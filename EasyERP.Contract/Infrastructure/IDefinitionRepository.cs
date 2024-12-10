
namespace EasyERP.Contract.Infrastructure
{
    public interface IDefinitionRepository<T>
    {

        int GetAutoOrder();

        bool NameExists(T entity, object text);        

    }

}
