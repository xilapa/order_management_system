using System;
using Xunit;

namespace CommonLibrary.Tests
{
    public class StringHandlerTests
    {
        [Fact]
        public void InsertSpaceValidSTest()
        {
            // Arrange
            var source = "OiTudoBem";
            var expected = "Oi Tudo Bem";

            // Act
            var result = source.InsertSpace();

            // Assert
            Assert.Equal(expected,result);
        }

        [Fact]
        public void InsertSpaceTestWithExistingSpace()
        {
            // Arrange
            var sourceOne = "OiTudo Bem";
            var sourceTwo = "Oi   Tudo  Bem";
            var expected = "Oi Tudo Bem";

            // Act
            var resultOneSpace = sourceOne.InsertSpace();
            var resultManySpaces = sourceTwo.InsertSpace();

            // Assert
            Assert.Equal(expected,resultOneSpace);
            Assert.Equal(expected,resultManySpaces);
        }

        [Fact]
        public void InsertSpaceOnNullValueReturnsEmpty()
        {
            // Arrange
            string source = null;
            var expected = string.Empty;

            // Act
            var result = source.InsertSpace();

            // Assert
            Assert.Equal(expected,result);

        }
    }
}
