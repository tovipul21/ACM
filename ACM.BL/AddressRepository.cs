namespace ACM.BL
{
    public class AddressRepository
    {
        #region Constructors
        public AddressRepository() { }
        public AddressRepository(int id)
        {
            AddressRepositoryId = id;
        }
        #endregion

        #region Properties
        public int AddressRepositoryId { get; }

        public List<Address> RetrieveByCustomerId(int customerId)
        { 
            List<Address> addressList = new();

            addressList.Add(new Address(1)
            { 
                AddressType = 1, StreeLine1 = "Vijay Park", StreeLine2 = "Mathuradas Extn Road", City = "Mumbai", StateProvince = "MH", PostalCode = "400067", Country = "India" 
            });

            addressList.Add(new Address(2) 
            { 
                AddressType = 2, StreeLine1 = "Akruli Road", StreeLine2 = "Kandivali East", City = "Mumbai", StateProvince = "MH", PostalCode = "400064", Country = "India" 
            });

            return addressList;
        }
        #endregion

        #region Methods
        public Address Retrieve(int addressId)
        {
            Address address = new(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreeLine1 = "Vijay Park, B-406";
                address.StreeLine2 = "Near Atul Tower, Mathuradas Extension Road";
                address.City = "Mumbai";
                address.StateProvince = "MH";
                address.PostalCode= "12345";
            }

            return address;
        }

        public bool Save()
        {
            return true;
        }
        #endregion
    }
}
