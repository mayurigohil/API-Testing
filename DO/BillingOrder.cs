using NUnit.Framework;

namespace APITesting.DO
{
    class BillingOrder
    {

        //     \"zipCode\": \"123123\",    \"addressLine1\": \"string\",    \"addressLine2\": \"string\",    \"itemNumber\": 1,    \"comment\": \"string\",    \"state\": \"AL\"}";

        public string firstName;
        public string lastName;
        public string email;
        public string phone;
        public string city;
        public string zipCode;
        public string addressLine1;
        public string addressLine2;
        public string itemNumber;
        public string comments;
        public string state;

        public BillingOrder(
            string firstName = null,
            string lastName = null,
            string email = null,
            string phone = null,
            string city = null,
            string zipCode = null,
            string addressLine1 = null,
            string addressLine2 = null,
            string itemNumber = null,
            string comments = null,
            string state = null)
        {
            this.firstName = firstName ?? "Fname";
            this.lastName = lastName ?? "TestLname";
            this.email = email ?? "TestEmail@abc.com";
            this.phone = phone ?? "1231231233";
            this.city = city ?? "City";
            this.zipCode = zipCode ?? "123123";
            this.addressLine1 = addressLine1 ?? "test1";
            this.addressLine2 = addressLine2 ?? "tsdfsad";
            this.itemNumber = itemNumber ?? "1";
            this.comments = comments ?? "tasdfakhdk";
            this.state = state ?? "AL";
        }




        //Define all the variables required in one file

    }
}
