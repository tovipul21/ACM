namespace ACM.BL
{
    public class ProductRepository
    {
        #region Constructors
        public ProductRepository() { }
        public ProductRepository(int productId)
        {
            ProductId = productId;
        }
        #endregion

        #region Properties
        public int ProductId { get; set; }
        #endregion

        #region Methods
        public Product Retrieve(int id)
        {
            Product product = new(id);

            if (id == 1)
            {
                product.ProductName = "Cricket Bat";
                product.ProductDescription = "This bat is use to play cricket";
                product.CurrentPrice = 3500.00M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call insert stored procedure
                        success = true;
                    }
                    else
                    {
                        // Call update stored procedure
                        success = true;
                    }
                }
                else
                    success = false;
            }

            return success;
        }
        #endregion
    }
}
