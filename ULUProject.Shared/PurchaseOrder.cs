using System;
using System.Collections.Generic;
using System.Text;
//using System.ComponentModel.DataAnnotations;

namespace ULUProject.Shared
{
    public class PurchaseOrder
    {
        //[Required]
        public int PurchaseOrderId { get; set; }

        //[Required]
        public string ProductName { get; set; }

        //[Required]
        public int Quantity { get; set; }

        //[Required]
        public string BillingAddress { get; set; }

        //[Required]
        public string ShippingAddress { get; set; }

        //[Required]
        public string ContactPersonName { get; set; }
    }
}
