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
            StringHandler sh = new();
            string expected = "Vipul Mehta";

            // Act
            string actual = sh.InsertSpaces("VipulMehta");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InsertTextWithSpaceTest()
        {
            // Arrange
            StringHandler sh = new();
            string expected = "Vipul k Mehta";

            // Act
            string actual = sh.InsertSpaces("Vipul k Mehta");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
