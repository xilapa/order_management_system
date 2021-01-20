namespace BusinessLogic
{
    public class Address
    {
        public Address()
        {
            
        }

        public Address(int addressID)
        {
            AddressID = addressID;
        }

        public int AddressID { get; private set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }

        /// <summary>
        /// Validate the address
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;

            return isValid;
        }
    }
}