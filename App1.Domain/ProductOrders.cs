﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Domain
{
   public class ProductOrders
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
