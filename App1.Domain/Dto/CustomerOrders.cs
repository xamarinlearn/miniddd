using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Domain.Dto
{
  public  class CustomerOrder
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string Orderfullfiled { get; set; }
        public string OrderPlaced { get; set; }

       public IEnumerable<OrderLineItem> OrderLineItems { get; set; }

    }
}
