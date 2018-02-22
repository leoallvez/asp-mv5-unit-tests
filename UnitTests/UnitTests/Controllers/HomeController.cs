using App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using UnitTests.Models;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new AboutViewModel { Title = "About DanylkoWeb" });
        }

        public ActionResult About()
        {
            ViewBag.Title = "About Us";
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Details(int Id)
        {
            return View("Details");
        }

        public ActionResult DetailsWithModel(int Id)
        {
            return View("Details", new Product(Id, "Laptop"));
        }

        public ActionResult DetailsWithIf(int Id)
        {
            if (Id < 1) {
                return RedirectToAction("Index");
            }

            return View("Details", new Product(Id, "Laptop"));
        }

        public ActionResult Products()
        {
            var products = new List<Product> {

               new Product { Id = 1, Name = "Product1" },
               new Product { Id = 2, Name = "Product2" },
               new Product { Id = 3, Name = "Product3" },
               new Product { Id = 4, Name = "Product4" },
               new Product { Id = 5, Name = "Product5" }

            };

            return View(products);
        }

        public ActionResult CheckCountValue(int i)
        {
            if (i > 20)
            {
                throw (new Exception("Out of the Range"));
            }

            return View();
        }

    }
}