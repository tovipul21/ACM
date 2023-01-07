using Acme.Common;
using System.Net.Mail;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
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

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            } 
        }

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

        public string Log() => $"{ProductId} : {ProductName} Detail : {ProductDescription} Status : {EntityState.ToString()} ";
        #endregion

    }
}
