using EasyERP.Application.Infrastructure.Contract;
using EasyERP.Domain.Services.Models.Customers;


namespace EasyERP.Application.Services.Contracts.Customers
{
    public interface ICustomerRepository : ICRUDRepository<Customer>, IGetAllRepository<Customer>
    {
    }
}
