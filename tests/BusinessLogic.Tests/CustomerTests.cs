using System;
using Xunit;

namespace BusinessLogic.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void FullNameTestValid()
        {
            // Arrange
            var customer = new Customer();
            customer.FirstName = "John";
            customer.LastName = "Wick";
            var expected = "John Wick";
            
            // Act
            var actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "Wick";
            var expected = "Wick";
            
            // Act
            var actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer();
            customer.FirstName = "John"; 
            var expected = "John";
            
            // Act
            var actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
