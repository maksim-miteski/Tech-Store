using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace WebApplication5.Models
{
    public class Product 
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public string ImgURL { get; set; }
    }
}
