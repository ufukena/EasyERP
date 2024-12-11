using EasyERP.Domain.Services.Models.Customers;


namespace EasyERP.Contract.Infrastructure
{

    public interface IGetAllRepository<TEntityDto>
    {        
        List<Customer> GetAll();
    }

    public interface IGetAllAsyncRepository<TEntityDto>
    {
        Task<List<Customer>> GetAllAsync();
    }


}
