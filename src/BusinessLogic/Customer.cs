using System.Collections.Generic;

namespace BusinessLogic
{
    public class Customer : EntityBase
    {
        public Customer()
        {
            Addresses = new List<Address>();
        }
        public Customer(int customerId) : this() 
        {
            CustomerId = customerId;
        }
        public int CustomerId {get; private set;}
        public CustomerType CustomerType { get; set; }
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
        public List<Address> Addresses { get; set;}
    
        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;
            
            return isValid;
        }

        public override string ToString() => FullName;
    }
}