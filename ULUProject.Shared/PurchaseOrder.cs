namespace ULUApp.Shared
{
    public class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public string BillingAddress { get; set; }

        public string ShippingAddress { get; set; }

        public string ContactPersonName { get; set; }
    }
}
