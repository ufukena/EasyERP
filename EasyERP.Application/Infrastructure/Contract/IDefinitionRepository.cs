
namespace EasyERP.Application.Infrastructure.Contract
{
    public interface IDefinitionRepository<T>
    {

        int GetAutoOrder();

        bool NameExists(T entity, object text);        

    }

}
