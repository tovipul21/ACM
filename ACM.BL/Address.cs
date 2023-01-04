namespace ACM.BL
{
    public class Address
    {
        #region Constructors
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }
        #endregion

        #region Properties
        public int AddressId { get; }
        public string? StreeLine1 { get; set; }
        public string? StreeLine2 { get; set; }
        public string? City { get; set; }

        public string? StateProvince { get; set; }

        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        public int AddressType { get; set; }
        #endregion

        #region Methods
        public bool Validate()
        {
            var isValid = true;

            if (String.IsNullOrEmpty(PostalCode)) isValid = false;

            return isValid;
        }
        #endregion
    }
}
