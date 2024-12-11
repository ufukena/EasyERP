using EasyERP.Application.Http.Helper;
using EasyERP.Application.Http.Services.Contracts.Customers;
using EasyERP.Domain.Services.Models.Customers;
using System.Net;
using System.Net.Http.Json;


namespace EasyERP.Application.Http.Services.Repositories.Customers
{
    public class CustomerAsyncRepository : ICustomerAsyncRepository
    {

        public async Task<Customer> GetAsync(Guid id)
        {

            using (var _httpClient = HttpClientHelper.GetClient())
            {

                HttpResponseMessage _httpResponse = await _httpClient.GetAsync($"/customer/get" + id);


                if (_httpResponse.IsSuccessStatusCode)
                {
                    var result = await _httpResponse.Content.ReadFromJsonAsync<Customer>() ?? throw new ArgumentException(); ;
                    return result;
                }
                else
                {
                    throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
                }

            }
        }

        public async Task<List<Customer>> GetAllAsync()
        {

            #region Ex
            //var _httpClient = HttpClientHelper.GetClient();
            //HttpResponseMessage _httpResponse = await _httpClient.GetAsync($"/customer/getall");


            //if (_httpResponse.IsSuccessStatusCode)
            //{
            //    var json = await _httpResponse.Content.ReadAsStringAsync();

            //    var result = JsonConvert.DeserializeObject<List<Customer>>(json);

            //}
            //else
            //{
            //    //throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
            //    return null;
            //}


            //return result; 
            #endregion


            using (var _httpClient = HttpClientHelper.GetClient())
            {

                HttpResponseMessage _httpResponse = await _httpClient.GetAsync($"/customer/getall");

                                                
                if (_httpResponse.IsSuccessStatusCode)
                {
                    var result = await _httpResponse.Content.ReadFromJsonAsync<List<Customer>>() ?? throw new ArgumentException(); ;
                    return result;
                }
                else
                {
                    throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
                }

                

            }


        }

        public async Task<Customer> CreateAsync(Customer entity)
        {

            using (var _httpClient = HttpClientHelper.GetClient())
            {
                HttpResponseMessage _httpResponse = await _httpClient.PutAsJsonAsync($"/customer/create", JsonContentHelper.CreateJsonContent(entity));

                if (_httpResponse.IsSuccessStatusCode)
                {
                    entity = await _httpResponse.Content.ReadFromJsonAsync<Customer>() ?? throw new ArgumentException();
                    return entity;
                }
                else
                {
                    throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
                }

                

            }
        }

        public async Task<Customer> UpdateAsync(Customer entity)
        {

            using (var _httpClient = HttpClientHelper.GetClient())
            {                
                HttpResponseMessage _httpResponse = await _httpClient.PutAsJsonAsync($"/customer/update", JsonContentHelper.CreateJsonContent(entity));
                
                if (_httpResponse.IsSuccessStatusCode)
                {
                    entity = await _httpResponse.Content.ReadFromJsonAsync<Customer>() ?? throw new ArgumentException();
                }
                

                return entity;

                #region Ex
                //if (_httpResponse.IsSuccessStatusCode)
                //{
                //    //var json = await _httpResponse.Content.ReadAsAsync<Customer>();
                //    //entity = JsonConvert.DeserializeObject<Customer>(json);

                //    //entity = await _httpResponse.Content.ReadFromJsonAsync<Customer>();

                //    entity = await _httpResponse.Content.ReadFromJsonAsync<Customer>();

                //}
                //else
                //{
                //    throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
                //}

                //return entity; 
                #endregion

            }
           
        }

        public async Task<HttpStatusCode> DeleteAsync(Customer entity)
        {
            using (var _httpClient = HttpClientHelper.GetClient())
            {
               
                HttpResponseMessage _httpResponse = await _httpClient.PostAsync($"/customer/delete", JsonContentHelper.CreateJsonContent(entity));

                return _httpResponse.StatusCode;

            }
        }

       
    }
}
