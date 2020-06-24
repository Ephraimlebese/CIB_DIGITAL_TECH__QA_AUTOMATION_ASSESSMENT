using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities
{
    public  class HttpClientHelper
    {
        async static void GetRequest(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await httpClient.GetAsync(url) ) 
                {
                    Console.WriteLine(responseMessage.RequestMessage);
                }
            }
        }
    }
}
