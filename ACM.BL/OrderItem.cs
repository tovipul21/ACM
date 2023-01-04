namespace ACM.BL
{
    public class OrderItem
    {
        #region Constructor
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        #endregion

        #region Properties
        public int OrderItemId { get; }

        public int ProductId { get; set; }

        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
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

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        #endregion
    }
}
