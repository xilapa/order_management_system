using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set;}

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Retrieve a costumer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // temporary code
            Customer customer = new Customer();

            if (customerId == 1)
            {
                customer = new Customer(1)
                {
                    FirstName = "John",
                    LastName = "Wick",
                    Email = "johnwick@email.com",
                    Addresses = addressRepository.RetrieveByCustomerID(customerId).ToList()
                };
            }

            return customer;
        }

        /// <summary>
        /// Retrieve a list with all customers
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Customer> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save customer information
        /// </summary>
        /// <param name="customerId"></param>
        public bool Save(Customer customer)
        {
            throw new NotImplementedException();
        }


    }
}