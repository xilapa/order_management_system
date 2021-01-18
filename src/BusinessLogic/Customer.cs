using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId {get; private set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName 
        { 
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName))
                    return LastName;
                if (string.IsNullOrWhiteSpace(LastName))
                    return FirstName;
                
                return FirstName + ' ' + LastName;
            }
        
        }
    
        public string Email { get; set; }
    
        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;
            
            return isValid;
        }

        /// <summary>
        /// Retrieve a costumer from ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieve a list with all customers
        /// </summary>
        /// <returns></returns>
        public static List<Customer> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save the current customer information
        /// </summary>
        /// <param name="customerId"></param>
        public void Save(int customerId)
        {
            throw new NotImplementedException();
        }

    }
}