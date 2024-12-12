using EasyERP.Application.Context;
using EasyERP.Application.Services.Repositories.Customers;
using EasyERP.Contract.Services.Customers;


namespace EasyERP.Application.Adapters
{
    public class ServiceBase
    {
       
        public ICustomerRepository Customer;


        public ServiceBase()
        {
            DbContext dbContext = new DbContext(); 

            Customer = new CustomerRepository(dbContext);
          
        }


    }

}
