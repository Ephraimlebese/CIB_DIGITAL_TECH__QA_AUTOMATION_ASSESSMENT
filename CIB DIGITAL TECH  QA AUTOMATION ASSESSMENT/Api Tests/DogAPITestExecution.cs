using CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Api_Tests
{
    class DogAPITestExecution 
    {
        [TestCase("https://dog.ceo/api/breeds/list/all" , TestName = "A list of all dog breeds.")]
        [TestCase("https://dog.ceo/api/breed/retriever/list", TestName = "A list of sub-breeds for “retriever”")]
        [TestCase("https://dog.ceo/api/breed/retriever/images/random", TestName = "A random image / link for the sub-breed “golden”")]
        public void ExecuteApiRequest(string url)
        {
            HttpClientHelper httpClientHelper = new HttpClientHelper();

            httpClientHelper.endPoint = url;

            string response = string.Empty;

            response = httpClientHelper.makeRequest();
            Console.WriteLine(JToken.Parse(response).ToString());
        }
    }
}
