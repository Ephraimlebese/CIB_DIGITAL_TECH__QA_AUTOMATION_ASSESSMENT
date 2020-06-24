using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT
{
    public class Class1
    {
        static async Task Main(string[] args)
        {
            var httpClient = HttpClientFactory.Create();
            var url = "https://dog.ceo/api/breeds/list/all";
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var contant = httpResponseMessage.Content;
                var data = contant.ReadAsStringAsync();
                Console.WriteLine(data.Result);
            }
        }
    }

    
}
