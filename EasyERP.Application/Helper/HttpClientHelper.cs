using EasyERP.Enum.Common;
using System.Net.Http.Headers;


namespace EasyERP.Application.Helper
{

    public static class HttpClientHelper
    {
        public static HttpClient GetClient(AppDebugModeEnum appDebugModeEnum)
        {

            HttpClient _httpClient = new HttpClient();


            if (appDebugModeEnum == AppDebugModeEnum.Development)            
                _httpClient.BaseAddress = new Uri("https://localhost:23352/");            
            else
                _httpClient.BaseAddress = new Uri("");



            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            return _httpClient;                      


        }

    }

}
