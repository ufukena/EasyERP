using EasyERP.Enum.Database;

namespace EasyERP.Application.Infrastructure.Contract
{

    public interface IGetAllRepository<TEntityDto>
    {        

        IEnumerable<TEntityDto> GetAll(ColumnEnum columnenum);

    }
    

}
