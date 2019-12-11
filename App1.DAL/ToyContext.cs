using Microsoft.EntityFrameworkCore;
using System;
using App1.Domain;

namespace App1.DAL
{
    public class ToyContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<ProductOrders> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb; Initial Catalog=ToyDB; Integrated Security=True");
        }
    }
}
