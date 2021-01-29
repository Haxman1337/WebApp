using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Birdate { get; set; }
    }

    public class Order
    {
        public int id { get; set; }
        public int cid { get; set; }
        public int cname { get; set; }
        public decimal value { get; set; }
        public DateTime date { get; set; }


    }

    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}