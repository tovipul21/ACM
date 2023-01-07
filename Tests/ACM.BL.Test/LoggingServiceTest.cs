using Acme.Common;

namespace ACM.BL.Test
{
    public class LoggingServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1) 
            { 
                EmailAddress = "fbaggins@hobbiton.com",
                FirstName= "Frodo",
                LastName= "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake",
                CurrentPrice = 15M
            };
            changedItems.Add(product);

            // Act
            LoggingService.WriteTextToFile(changedItems);

            // Assert
            // Validate the output
        }
    }
}
