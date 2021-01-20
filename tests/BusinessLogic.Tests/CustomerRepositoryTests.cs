using Xunit;
using FluentAssertions;
using System.Collections.Generic;

namespace BusinessLogic.Tests
{
    public class CustomerRepositoryTests
    {
        [Fact]
        public void RetrieveCustomerWithAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1) 
            {
                FirstName = "John",
                LastName = "Wick",
                Email = "johnwick@email.com",
                Addresses = new List<Address>()
                            {
                                new Address(1)
                                    {
                                        Name = "Minha Casa",
                                        Street = "Rua Reta",
                                        City = "Vila Nova",
                                        State = "DF",
                                        PostalCode = "32113-321",
                                        Country = "Brasil",
                                        AddressType = "Home"
                                    },
                                new Address(2)
                                    {
                                        Name = "Escritório",
                                        Street = "Rua Redeonda",
                                        City = "Vila Azul",
                                        State = "DF",
                                        PostalCode = "32113-234",
                                        Country = "Brasil",
                                        AddressType = "Work"
                                    }
                            }

            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}