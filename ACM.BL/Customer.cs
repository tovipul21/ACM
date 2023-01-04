namespace ACM.BL
{
    public class Customer : EntityBase
    {
        #region Constructors
        /// <summary>
        /// This is default constructor
        /// </summary>
        public Customer() : this (1)
        {}

        public Customer(int customerId)
        {
            CustomerId = customerId;
            CustomerRepository = new CustomerRepository();
        }
        #endregion


        #region Properties
        public int CustomerId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName.Trim()}, {FirstName.Trim()}";
            }
        }
        public string EmailAddress { get; set; }

        public List<Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }

        public CustomerRepository CustomerRepository { get; set; }

        public int CustomerTypeId { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Retrieve all customers that meet defined criteria
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {

            return new List<Customer>();
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

            return isValid;
        }

        public override string ToString() => FullName;
        #endregion
    }
}