namespace ACM.BL
{
    public class Product : EntityBase
    {
        #region Constructors
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        #endregion

        #region Properties
        public int ProductId { get; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }
        #endregion

        #region Methods
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
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
