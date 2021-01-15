namespace BusinessLogic
{
    public class Customer
    {
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
            var isvalid = true;

            if (string.IsNullOrWhiteSpace(LastName))
                isvalid = false;
            if (string.IsNullOrWhiteSpace(Email))
                isvalid = false;
            
            return isvalid;
        }


    }
}