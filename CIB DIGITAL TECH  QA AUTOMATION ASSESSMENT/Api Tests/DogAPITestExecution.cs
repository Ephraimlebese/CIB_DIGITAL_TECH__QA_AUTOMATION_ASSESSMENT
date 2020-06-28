using CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities;
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
        [SetUp]
        public void OneTimeSetup()
        {

        }

        [TestCase("https://dog.ceo/api/breeds/list/all")]
        public void ExecuteGetAllDogBreads(string url)
        {
            HttpClientHelper httpClientHelper = new HttpClientHelper();

            httpClientHelper.endPoint = url;

            string response = string.Empty;

            response = httpClientHelper.makeRequest();

            Console.WriteLine(response);
        }
    }
}
