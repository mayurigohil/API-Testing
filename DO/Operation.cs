using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITesting.DO
{
    class Operation
    {

        string baseUrl = "http://localhost:8080";
        public IRestResponse POST(string body)
        {

            var client = new RestClient($"{baseUrl}/BillingOrder");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response;

        }


        public IRestResponse PUT(int id, string body)
        {

            var client = new RestClient($"{baseUrl}/BillingOrder/{id}");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response;

        }


        //Read all records 
        public IRestResponse GET()
        {

            var client = new RestClient($"{baseUrl}/BillingOrder");

            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);


            return response;
        }





        public IRestResponse READ(int id)
        {

            var client = new RestClient($"{baseUrl}/BillingOrder/{id}");

            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);


            return response;
        }


        public IRestResponse DELETE(int id)
        {
            var client = new RestClient($"{baseUrl}/BillingOrder/{id}");

            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);

            TestContext.WriteLine(response.StatusCode);

            return response;
        }

    }
}
