using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class AddressRepository
    {
        // necessary because Order and Customer uses the Address Entity

        /// <summary>
        /// Retrieve a address
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns></returns>
        public Address Retrieve(int addressID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieve all addresses of a customer
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            // temporary code
            var addresses = new List<Address>();
            if (customerID == 1)
            {
                var address = new Address(1)
                {
                    Name = "Minha Casa",
                    Street = "Rua Reta",
                    City = "Vila Nova",
                    State = "DF",
                    PostalCode = "32113-321",
                    Country = "Brasil",
                    AddressType = "Home"
                };

                addresses.Add(address);

                address = new Address(2)
                {
                    Name = "Escritório",
                    Street = "Rua Redeonda",
                    City = "Vila Azul",
                    State = "DF",
                    PostalCode = "32113-234",
                    Country = "Brasil",
                    AddressType = "Work"
                };

                addresses.Add(address);
            }          

            return addresses;
        }

        public bool Save(Address address)
        {
            throw new NotImplementedException();
        }
    }
}