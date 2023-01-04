namespace ACM.BL
{
    public class Order
    {
        #region Constructors
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        #endregion

        #region Properties
        public int OrderId { get; }

        public List<OrderItem> OrderItems { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        public int  CustomerId { get; set; }

        public int ShippingAddressId { get; set; }
        #endregion

        #region Methods
        public bool Validate()
        {
            return true;
        }

        public bool Save()
        {
            return true;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        #endregion
    }
}
