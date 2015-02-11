using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week4_csharp_paired_day3.Models;

namespace week4_csharp_paired_day3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            model.Product = new List<Product>() {
                
            }
            return View(product);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}