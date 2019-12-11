using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App1.DAL.Services;
using App1.Domain.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App1.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<CustomerOrder>> Get(int id)
        {
            OrderService orderService = new OrderService(new DAL.ToyContext());

            return await orderService.GetOrdersByCustomer(id);
        }
    }
}
