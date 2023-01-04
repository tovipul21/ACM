namespace ACM.BL.Test
{
    public class CustomerRepositoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetrieveExistingWithAddress() 
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Vipul",
                LastName = "Mehta",
                EmailAddress = "vipul.mehta@aol.com",
                AddressList = new List<Address>
                {
                    new Address()
                    {
                        AddressType = 1, StreeLine1 = "Vijay Park", StreeLine2 = "Mathuradas Extn Road", City = "Mumbai", StateProvince = "MH", PostalCode = "400067", Country = "India"
                    },
                    new Address()
                    {
                        AddressType = 2, StreeLine1 = "Akruli Road", StreeLine2 = "Kandivali East", City = "Mumbai", StateProvince = "MH", PostalCode = "400064", Country = "India"
                    }
                }
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < expected.AddressList.Count; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, expected.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreeLine1, expected.AddressList[i].StreeLine1);
                Assert.AreEqual(expected.AddressList[i].StreeLine2, expected.AddressList[i].StreeLine2);
                Assert.AreEqual(expected.AddressList[i].City, expected.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].AddressType, expected.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].PostalCode, expected.AddressList[i].PostalCode);
            }
        }
    }
}
