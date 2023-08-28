using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst.Models
{
    public class SalesContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        public SalesContext() : base() { }


        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "server=localhost\\sqlexpress;database=SalesFirst;trusted_connection=true;trustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
