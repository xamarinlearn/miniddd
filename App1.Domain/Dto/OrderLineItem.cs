using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Domain.Dto
{
    public class OrderLineItem
    {
        public int ProductQuantity { get; set; }
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

    }
}
