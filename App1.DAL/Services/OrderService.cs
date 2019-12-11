using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.Domain;
using App1.Domain.Dto;
using System.Threading.Tasks;

namespace App1.DAL.Services
{
    public class OrderService
    {
        private readonly ToyContext _context;

        public OrderService(ToyContext context)
        {
            this._context = context;
        }

        public async Task<List<CustomerOrder>> GetOrdersByCustomer(int id)
        {
            List<CustomerOrder> Orders = await (_context.Orders.AsNoTracking().Where(o => o.CustomerID == id)
                .OrderByDescending(o => o.OrderPlaced)
                .Select(o => new CustomerOrder
                {
                    OrderId = o.Id,
                    CustomerName = $"{o.Customer.CustomerName}",
                    OrderPlaced = o.OrderPlaced.ToShortDateString(),
                    Orderfullfiled = o.OrderFulfilled.HasValue ? o.OrderFulfilled.Value.ToShortDateString() : string.Empty,
                    OrderLineItems = o.ProductOrders.Select(po => new OrderLineItem
                    {
                        ProductName = po.Product.ProductName,
                        ProductPrice = po.Product.UnitPrice,
                        ProductQuantity = po.Quantity
                    })
                })).ToListAsync();
            return Orders;
        }
        private IQueryable<Order> GetOrdersByCustomerIdInternal(int id)
        {
            return _context.Orders.AsNoTracking().Where(o => o.CustomerID == id);
        }
    }
}
