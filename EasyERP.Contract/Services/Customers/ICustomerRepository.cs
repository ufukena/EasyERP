using EasyERP.Contract.Infrastructure;
using EasyERP.Domain.Services.Models.Customers;

namespace EasyERP.Contract.Services.Customers
{
    public interface ICustomerRepository : ICRUDRepository<Customer>, IGetAllRepository<Customer>
    {
    }
}
