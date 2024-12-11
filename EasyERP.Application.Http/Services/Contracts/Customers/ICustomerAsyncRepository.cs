
using EasyERP.Contract.Infrastructure;
using EasyERP.Domain.Services.Models.Customers;

namespace EasyERP.Application.Http.Services.Contracts.Customers
{
    internal interface ICustomerAsyncRepository : ICRUDAsyncRepository<Customer>, IGetAllAsyncRepository<Customer>
    {
    }
}
