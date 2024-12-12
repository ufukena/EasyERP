using EasyERP.Application.Http.Infrastructure.Repository;
using EasyERP.Contract.Services.Customers;
using EasyERP.Domain.Services.Models.Customers;


namespace EasyERP.Application.Http.Services.Repositories.Customers
{
    internal class CustomerHttpRepository : BaseHttpRepository<Customer>, ICustomerRepository
    {

        public CustomerHttpRepository() : base("customer") { }
        
       
    }
}
