using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Domain
{
   public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        public ICollection<ProductOrders> ProductOrders { get; set; }

    }
}
