using APITesting.DO;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;

namespace APITesting
{
    [TestFixture]
    public class Tests
    {


        [TestCase()]
        public void TC_POST()
        {
            //Create edata object and store the data from Billing order to edata
            BillingOrder edata = new BillingOrder();

            //Serialise data in to Jason
            string jsonBody = JsonConvert.SerializeObject(edata);

            //Create and object for posting opertaion
            Operation postobj = new Operation();

            //Post Data and save the response
            IRestResponse response = postobj.POST(jsonBody);

            //Print the Response in Console
            TestContext.WriteLine(response.Content);

            //Deserialise Jason data in to Text
            BillingOrder actualData = JsonConvert.DeserializeObject<BillingOrder>(response.Content);

            //Assertion
            edata.Should().BeEquivalentTo(actualData);
            Assert.AreEqual(edata.firstName, actualData.firstName);
            //Assert.AreEqual(edata.lastName, actualData.lastName);


        }

        [Test]
        public void PUT()
        {
            BillingOrder edata = new BillingOrder();
            //Serialise data in to Jason
            string jsonBody = JsonConvert.SerializeObject(edata);
            Operation PutObj = new Operation();
            IRestResponse PutResponse = PutObj.PUT(3, jsonBody);
            BillingOrder actualData = JsonConvert.DeserializeObject<BillingOrder>(PutResponse.Content);
            TestContext.WriteLine(PutResponse.Content);
        }
        
        [Test]

        public void GET()
        {
            Operation GetObj = new Operation();
            IRestResponse GetResponse = GetObj.GET();
            TestContext.WriteLine(GetResponse.Content);
        }

        [Test]

        public void DELETE()
        {
            Operation DeleteObj = new Operation();
            IRestResponse DeleteResponse = DeleteObj.DELETE(2);
            TestContext.WriteLine(DeleteResponse.Content);
        }


    }
}
