using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using WebApplication5.Models;

namespace WebApplication5.Models
{
    public class Transactions 
    {
        public Product Product { get; set; }
        public List<Client> Customers { get; set; }

        public Transactions()
        {
            Customers = new List<Client>();
        }
    }
}
