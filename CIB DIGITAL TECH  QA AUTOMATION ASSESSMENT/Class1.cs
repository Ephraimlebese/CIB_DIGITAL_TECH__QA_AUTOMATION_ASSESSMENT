using CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT
{
    public class Class1
    {
        public static void Main(string[] args)
        {
           
            HttpClientHelper httpClientHelper = new HttpClientHelper();

            httpClientHelper.endPoint = "https://dog.ceo/api/breeds/list/all";

            string response = string.Empty;


            /************************************************
             * 
             * A list of all dog breeds. stored in response
             * 
             * **********************************************/

            response = httpClientHelper.makeRequest();
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("A list of all dog breeds. stored in response");
            Console.WriteLine(JToken.Parse(response).ToString());

            /************************************************
             * 
             * Verify “retriever” breed is within the list.
             * 
             * **********************************************/

            if (!response.Contains("retriever"))
            {
                Assert.Fail("Retriver was not found within the list!");
            }


            /************************************************
             * 
             *  A list of sub-breeds for “retriever”
             * 
             * **********************************************/

            httpClientHelper.endPoint = "https://dog.ceo/api/breed/retriever/list";

            response = string.Empty;

            response = httpClientHelper.makeRequest();
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("A list of sub-breeds for “retriever”");
            Console.WriteLine(JToken.Parse(response).ToString());

            /************************************************
            * 
            *  A list of sub-breeds for “retriever”
            * 
            * **********************************************/

            httpClientHelper.endPoint = "https://dog.ceo/api/breed/retriever/images/random";

            response = string.Empty;

            response = httpClientHelper.makeRequest();

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("a random image / link for the sub-breed “golden”");
            Console.WriteLine(JToken.Parse(response).ToString());
        }


    }

    
}
