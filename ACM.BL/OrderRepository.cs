namespace ACM.BL
{
    internal class OrderRepository
    {
        #region Constructors
        public OrderRepository() { }
        public OrderRepository(int orderId) 
        { 
            OrderId = orderId;
        }
        #endregion

        #region Properties
        public int OrderId { get; set; }
        #endregion

        #region Methods
        public Order Retrieve(int id)
        {
            Order order = new(id);

            if (id == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now);
            }

            return order;
        }

        public bool Save()
        {
            return true;
        }
        #endregion
    }
}
