using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class QueryProjection
    {

        //public async Task<List<CustomerOrder>> GetAll()
        //{
        //    List<CustomerOrder> orders = await (_context.Orders.AsNoTracking()
        //        .OrderByDescending(o => o.OrderPlaced)
        //        .Select(o => new CustomerOrder
        //        {
        //            OrderId = o.Id,
        //            CustomerName = $"{o.Customer.LastName}, {o.Customer.FirstName}",
        //            OrderFulfilled = o.OrderFulfilled.HasValue ?
        //                o.OrderFulfilled.Value.ToShortDateString() : string.Empty,
        //            OrderPlaced = o.OrderPlaced.ToShortDateString(),
        //            OrderLineItems = (o.ProductOrders.Select(po => new OrderLineItem
        //            {
        //                ProductQuantity = po.Quantity,
        //                ProductName = po.Product.Name
        //            }))
        //        })).ToListAsync();

        //    return orders;
        //}
    }
}
