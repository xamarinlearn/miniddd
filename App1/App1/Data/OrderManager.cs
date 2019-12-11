using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using App1.Domain.Dto;
using Newtonsoft.Json;

namespace App1.Data
{
   public class OrderManager
    {
        const string Url = "http://10.15.3.112:5000/orders/"; // 192.168.60.29:5000/orders

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.Timeout = Timeout.InfiniteTimeSpan;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add
                (new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public async Task<IEnumerable<CustomerOrder>> GetCustomerOrders(int id)
        {
            HttpClient client = GetClient();
            var urlRequest = $"{Url}{id}";
            string result = await client.GetStringAsync(urlRequest);

            var orders = JsonConvert.DeserializeObject<IEnumerable<CustomerOrder>>(result);
            return orders;
        }
    }
}
