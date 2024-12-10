using Newtonsoft.Json;
using System.Text;


namespace EasyERP.Application.Http.Helper
{
    public static class JsonContentHelper
    {

        public static StringContent CreateJsonContent(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);

            var content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

            return content;
        }

    }
}
