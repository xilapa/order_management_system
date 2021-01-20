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

        [Fact]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Wick",
                Email = "j.wick@email.com"
            };
            var expected = true;
            
            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateLastNameEmpty()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "",
                Email = "j.wick@email.com"
            };
            var expected = false;
            
            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateEmailEmpty()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Wick",
                Email = ""
            };
            var expected = false;
            
            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }        
    }
}
