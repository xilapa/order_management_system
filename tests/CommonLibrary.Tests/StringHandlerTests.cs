using System;
using Xunit;

namespace CommonLibrary.Tests
{
    public class StringHandlerTests
    {
        [Fact]
        public void InsertSpaceTest()
        {
            // Arrange
            var stringHandler = new StringHandler();
            var expected = "Oi Tudo Bem";

            // Act
            var result = stringHandler.InsertSpace("OiTudoBem");

            // Assert
            Assert.Equal(expected,result);
        }
    }
}
