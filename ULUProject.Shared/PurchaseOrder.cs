<<<<<<< HEAD
﻿using System;
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
=======
﻿namespace ULUApp.Shared
{
    public class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public string BillingAddress { get; set; }

        public string ShippingAddress { get; set; }

>>>>>>> 091e2c174a5db474342f5d16d1a1a9f2d3667160
        public string ContactPersonName { get; set; }
    }
}
