using Acme.Common;

namespace ACM.BL.Test
{
    public class CommonTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertSpaceTest()
        {
            // Arrange
            var source = "VipulMehta";
            string expected = "Vipul Mehta";

            // Act
            string actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InsertTextWithSpaceTest()
        {
            // Arrange
            var source = "Vipul k Mehta";
            string expected = "Vipul k Mehta";

            // Act
            string actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
