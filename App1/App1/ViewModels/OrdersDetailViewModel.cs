using App1.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using App1.Data;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class OrdersDetailViewModel
    {
        private readonly OrderManager _orderManager;
        public ObservableCollection<CustomerOrderViewModel> CustomerOrders { get; set; }
        public Command SearchCommand { get; set; }
        public string CustomerId { get; set; }
        public OrdersDetailViewModel()
        {
            SearchCommand = new Command(SearchCustomerWithOrders);
            _orderManager = new OrderManager();
            CustomerOrders = new ObservableCollection<CustomerOrderViewModel>();

        }

        private async void SearchCustomerWithOrders()
        {
            var customerOrders = await _orderManager.GetCustomerOrders(int.Parse(CustomerId));

            foreach (var co in customerOrders)
            {
                CustomerOrders.Add
                      (
                    new CustomerOrderViewModel { CustomerOrder = co }
                    );
            }
        }
    }
}
