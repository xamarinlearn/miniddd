using System;
using App1.DAL.Services;
using App1.DAL;
using App1.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => GetOrders());
            // Console.WriteLine("Hello World!");
        }

        private static async void GetOrders()
        {
            OrderService os = new OrderService(new ToyContext());

            var CO = await os.GetOrdersByCustomer(1);

            foreach (var co in CO)
            {
                Console.WriteLine($"{co.CustomerName}");
                Console.WriteLine(co.OrderId);
                Console.WriteLine(co.OrderPlaced);
                Console.WriteLine(co.Orderfullfiled);
                foreach (var lineItem in co.OrderLineItems)
                {
                    Console.WriteLine(lineItem.ProductName);
                }
                Console.WriteLine(co.OrderLineItems.Sum(ol => ol.ProductPrice * ol.ProductQuantity));
                Console.WriteLine("***************************************************************");

                Console.WriteLine("Presiona enter para finalizar.");
                Console.ReadLine();
            }
        }
    }
}
