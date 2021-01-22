using Xunit;
using FluentAssertions;
using System.Collections.Generic;

namespace BusinessLogic.Tests
{
    public class ProductRepositoryTests
    {
        [Fact]
        public void SaveValidProduct()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var product = new Product()
            {
                Name = "Mousepad",
                Description = "Good Product",
                HasChanges = true
            };
            product.SetPrice(10.00m);
            var expected = true;

            // Act
            var actual = productRepository.Save(product);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void SaveMissingDescription()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var product = new Product()
            {
                Name = "Mousepad",
                HasChanges = true
            };
            product.SetPrice(10.00m);
            var expected = false;

            // Act
            var actual = productRepository.Save(product);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}