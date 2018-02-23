using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Controllers;
using System.Web.Mvc;
using UnitTests.Models;
using App.Models.ViewModels;
using System.Collections.Generic;

namespace UnitTestsLab
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual("HomeController", "HomeController");
        }

        [TestMethod]
        public void DetailsViewTest()
        {
            var controller = new HomeController();
            var result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Details", result.ViewName);
        }

        [TestMethod]
        public void DetailsModelValueTest()
        {
            var controller = new HomeController();
            var result = controller.DetailsWithModel(2) as ViewResult;
            var product = (Product)result.ViewData.Model;
            Assert.IsNotNull(result);
            Assert.IsNotNull(product);
            Assert.AreEqual("Laptop", product.Name);
        }

        [TestMethod]
        public void DetailsRedirectTest()
        {
            var controller = new HomeController();
            var result = controller.DetailsWithIf(-1) as RedirectToRouteResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        [TestMethod]
        public void ThenReturnTheAboutViewModelTest()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            var model = result.Model as AboutViewModel;

            Assert.IsNotNull(result);
            Assert.AreEqual("About DanylkoWeb", model.Title);
        }
    
        [TestMethod]
        public void CountElementsInActionTest()
        {
            var controller = new HomeController();
            var result = controller.Products() as ViewResult;
            var list = result.Model as List<Product>;

            Assert.IsNotNull(result);
            Assert.IsNotNull(list);
            Assert.AreEqual(5, list.Count);
        }

        [TestMethod]
        public void ViewBagValuesTest()
        {
            var controller = new HomeController();
            var result = controller.About() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.AreEqual("About Us", result.ViewBag.Title);
        }

        [TestMethod]
        public void IdRangeTest()
        {
            var controller = new HomeController();
            var result = controller.IdRangeValue(1) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
