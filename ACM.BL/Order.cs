using Acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
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
        public override bool Validate()
        {
            var isValid = true;

            if (OrderItems.Count == 0) isValid = false;
            if (OrderDate == null) isValid = false;

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

        public string Log() => $"{OrderId} : Date : {this.OrderDate.Value.Date} Status : {EntityState.ToString()} ";
        #endregion
    }
}
