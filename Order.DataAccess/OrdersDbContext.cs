using Microsoft.EntityFrameworkCore;
using Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.DataAccess
{
    public class OrdersDbContext : DbContext
    {
        public OrdersDbContext()
        {

        }

        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options)
        {


        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
