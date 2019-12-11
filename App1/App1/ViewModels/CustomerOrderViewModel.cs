using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.Domain.Dto;

namespace App1.ViewModels
{
   public class CustomerOrderViewModel
    {
        public CustomerOrder CustomerOrder { get; set; }


        // Una propiedad que el ViewModel procesa... 
        public string TotalOrder
        { get => CustomerOrder.OrderLineItems.Sum(li=> li.ProductQuantity * li.ProductPrice).ToString();}
    }
}
