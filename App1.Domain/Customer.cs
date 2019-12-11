using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Domain
{
   public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

       public ICollection<Order> Orders { get; set; }
    }
}
