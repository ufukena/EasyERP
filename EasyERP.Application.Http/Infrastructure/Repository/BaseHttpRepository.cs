using EasyERP.Application.Http.Helper;
using System.Net;
using System.Net.Http.Json;


namespace EasyERP.Application.Http.Infrastructure.Repository
{
    internal abstract class BaseHttpRepository<T>
    {

        private readonly string httpUrlBase;        


        public BaseHttpRepository(string _httpUrlBase)
        {
            httpUrlBase = _httpUrlBase;            
        }


        public async Task<T> GetAsync(Guid id)
        {

            using (var _httpClient = HttpClientHelper.GetClient())
            {                
                HttpResponseMessage _httpResponse = await _httpClient.GetAsync($"/" + httpUrlBase + "/get/" + id);

                if (_httpResponse.IsSuccessStatusCode)
                {
                    var result = await _httpResponse.Content.ReadFromJsonAsync<T>() ?? throw new ArgumentException(); ;
                    return result;
                }
                else
                {
                    throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
                }

            }
        }

        public async Task<List<T>> GetAllAsync()
        {

            using (var _httpClient = HttpClientHelper.GetClient())
            {

                HttpResponseMessage _httpResponse = await _httpClient.GetAsync($"/" + httpUrlBase + "/getall");


                if (_httpResponse.IsSuccessStatusCode)
                {
                    var result = await _httpResponse.Content.ReadFromJsonAsync<List<T>>() ?? throw new ArgumentException(); ;
                    return result;
                }
                else
                {
                    throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
                }



            }


        }

        public async Task<T> CreateAsync(T entity)
        {

            using (var _httpClient = HttpClientHelper.GetClient())
            {
                HttpResponseMessage _httpResponse = await _httpClient.PutAsJsonAsync($"/" + httpUrlBase + "create", JsonContentHelper.CreateJsonContent(entity));

                if (_httpResponse.IsSuccessStatusCode)
                {
                    entity = await _httpResponse.Content.ReadFromJsonAsync<T>() ?? throw new ArgumentException();
                    return entity;
                }
                else
                {
                    throw new Exception((int)_httpResponse.StatusCode + "-" + _httpResponse.StatusCode.ToString());
                }



            }
        }

        public async Task<T> UpdateAsync(T entity)
        {

            using (var _httpClient = HttpClientHelper.GetClient())
            {
                HttpResponseMessage _httpResponse = await _httpClient.PutAsJsonAsync($"/" + httpUrlBase + "update", JsonContentHelper.CreateJsonContent(entity));

                if (_httpResponse.IsSuccessStatusCode)
                {
                    entity = await _httpResponse.Content.ReadFromJsonAsync<T>() ?? throw new ArgumentException();
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

        public async Task DeleteAsync(T entity)
        {
            using (var _httpClient = HttpClientHelper.GetClient())
            {

                HttpResponseMessage _httpResponse = await _httpClient.PostAsync($"/" + httpUrlBase + "/delete", JsonContentHelper.CreateJsonContent(entity));

                if (!_httpResponse.IsSuccessStatusCode)
                {
                    throw new ArgumentException();
                }

            }
        }




    }
}
