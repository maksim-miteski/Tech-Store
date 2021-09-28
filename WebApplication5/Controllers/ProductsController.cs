using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;


namespace WebApplication5.Controllers
{
    public class ProductsController : Controller
    {
        private ProductDbContext db = new ProductDbContext();

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public ActionResult AllProducts()
        {
            return View(db.Products.ToList());
        }
    }
}