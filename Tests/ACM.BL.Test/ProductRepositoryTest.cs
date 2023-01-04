using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Test
{
    public class ProductRepositoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SaveTestValid()
        {
            // Arrange
            ProductRepository productRepo = new();
            
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "This is test product description",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // Act
            bool actual = productRepo.Save(updatedProduct);


            // Assert
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void SaveTestMissingPrice()
        {
            // Arrange
            ProductRepository productRepo = new();

            var updatedProduct = new Product(2)
            {
                ProductDescription = "This is test product description",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // Act
            bool actual = productRepo.Save(updatedProduct);


            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
