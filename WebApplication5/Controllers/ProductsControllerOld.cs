using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;


namespace WebApplication5.Controllers
{
    public class ProductsControllerOld : Controller
    {
        static List<Product> productsList = new List<Product>()
        {
            new Product() {Name = "Samsung", Price=899.99, Model="series 6", id=101, ImgURL="images/tv1.jpeg"}
        };

        static List<Client> listOfCustomers = new List<Client>() { };

        public ActionResult AllProducts()
        {
            return View(productsList);
        }

       
        public ActionResult ShowProduct(int id)
        {
            var product = productsList.ElementAt(id);
            Transactions model = new Transactions();
            model.Product = product;
            model.Customers = listOfCustomers;
            return View(model);
        }

       public ActionResult NewProduct()
        {
            Product model = new Product();
            return View(model);
        }
        [HttpPost]
        public ActionResult InsertNewProduct(Product model)
        {
            if (!ModelState.IsValid)
            {
                return View("NewMovie", model);
            }
            productsList.Add(model);
            return View("GetAllMovies", productsList);
        }

        public ActionResult Login()
        {
            Client model = new Client();
            return View(model);
        }
        [HttpPost]
        public ActionResult InsertNewClient(Client model)
        {
            if (!ModelState.IsValid)
            {
                return View("NewClient", model);
            }
            listOfCustomers.Add(model);
            return View("AllProducts", productsList);
        }

        public ActionResult ShowClient(int id)
        {
            Client model = listOfCustomers.ElementAt(id);
            return View(model);
        }
    }
}