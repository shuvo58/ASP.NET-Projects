using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewPassingModel.Models;

namespace PartialViewPassingModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
              Product p1 = new Product() {Name = "Potato", Price = 10};
              Product p2=new Product(){Name = "Buiscuit",Price = 50};
              Product p3=new Product(){Name = "Ice Creame",Price = 100};
    
                List<Product> productList=new List<Product>();
    
                   productList.Add(p1);
                   productList.Add(p2);
                   productList.Add(p3);

            return View(productList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
