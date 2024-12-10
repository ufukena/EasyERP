using EasyERP.Enum.Database;

namespace EasyERP.Contract.Infrastructure
{

    public interface IGetAllRepository<TEntityDto>
    {        

        Task<IEnumerable<TEntityDto>> GetAll();

    }
    

}
