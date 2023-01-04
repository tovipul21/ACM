namespace ACM.BL
{
    public class CustomerRepository
    {
        #region Constructors
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        #endregion

        #region Properties
        private AddressRepository addressRepository { get; set; }
        #endregion

        #region Methods
        public Customer Retrieve(int customerId)
        {
            Customer customer = new(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "Vipul";
                customer.LastName = "Mehta";
                customer.EmailAddress = "vipul.mehta@aol.com";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId);
            }

            return customer;
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate(int customerId)
        {
            var isValid = true;

            //if (custom)
            //{

            //}

            return isValid;
        }
        #endregion       
    }
}
