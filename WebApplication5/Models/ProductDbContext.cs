using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;



namespace WebApplication5.Models
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }

        public ProductDbContext() : base("ConnectionProducts")
        {

        }

        public static ProductDbContext Create()
        {
            return new ProductDbContext();
        }

    }
}
