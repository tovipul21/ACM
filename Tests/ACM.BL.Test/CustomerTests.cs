namespace ACM.BL.Test
{
    public class CustomerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new () { FirstName = "Bilibo", LastName = "Baggins" };
            //customer.FirstName = "Bilibo";
            string expectedName = "Baggins, Bilibo";
            
            // Act
            string actualName = customer.FullName;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void StaticTest()
        {
            // Arrange
            Customer c1 = new() { FirstName = "Bilbo" };
            Customer.InstanceCount ++;

            Customer c2 = new() { FirstName = "Frodo" };
            Customer.InstanceCount ++;

            Customer c3 = new() { FirstName = "Rosie" };
            Customer.InstanceCount ++;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [Test]
        public void ValidateValidMethod()
        {
            // Arrange
            Customer customer = new() { LastName = "Baggins", EmailAddress = "baggins@aol.com" };
            var expected = true;

            // Act
            var actual = customer.CustomerRepository.Validate(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateMissingLastName()
        {
            // Arrange
            Customer customer = new() { EmailAddress = "baggins@aol.com" };
            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}