using System;
using System.Collections.Generic;

namespace App1.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderPlaced { get;  set; }
        public DateTime? OrderFulfilled { get; set; }
        public Customer Customer { get; set; }

        public ICollection<ProductOrders> ProductOrders { get; set; }
    }
}
