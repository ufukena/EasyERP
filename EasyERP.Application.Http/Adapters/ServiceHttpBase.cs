using EasyERP.Application.Http.Services.Repositories.Customers;
using EasyERP.Contract.Services.Customers;


namespace EasyERP.Application.Http.Adapters
{
    public class ServiceHttpBase
    {
        public ICustomerRepository Customer;


        public ServiceHttpBase()
        {
            
            Customer = new CustomerHttpRepository();

        }


    }
}
