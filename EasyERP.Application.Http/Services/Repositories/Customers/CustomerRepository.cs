using EasyERP.Application.Http.Helper;
using EasyERP.Contract.Services.Customers;
using EasyERP.Domain.Services.Models.Customers;
using Newtonsoft.Json;


namespace EasyERP.Application.Http.Services.Repositories.Customers
{
    public class CustomerRepository : ICustomerRepository
    {

        public async Task<Customer> Get(Guid id)
        {

            using (var _httpClient = HttpClientHelper.GetClient())
            {

                HttpResponseMessage _httpResponse = await _httpClient.GetAsync($"/customer/" + id);


                if (_httpResponse.IsSuccessStatusCode)
                {
                    var json = await _httpResponse.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Customer>(json);
                    return result;
                }
                else
                {
                    throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
                }
            }
        }


        public async Task<IEnumerable<Customer>> GetAll()
        {
                       
            var _httpClient = HttpClientHelper.GetClient();
            HttpResponseMessage _httpResponse = await _httpClient.GetAsync($"/customer/getall");


            if (_httpResponse.IsSuccessStatusCode)
            {
                var json = await _httpResponse.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<IEnumerable<Customer>>(json);
                return result;
            }
            else
            {
                throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
            }

           
        }


        public int Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Customer entity)
        {
            throw new NotImplementedException();
        }
       
        

        public int Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
