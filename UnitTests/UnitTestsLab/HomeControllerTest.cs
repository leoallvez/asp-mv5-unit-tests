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
        //String Compare Test.
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual("HomeController", "HomeController");
        }

        //View Name Test.
        [TestMethod]
        public void DetailsViewTest()
        {
            var controller = new HomeController();
            var result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Details", result.ViewName);
        }

        //Model class atribute value.
        [TestMethod]
        public void TestDetailsViewData()
        {
            var controller = new HomeController();
            var result = controller.DetailsWithModel(2) as ViewResult;
            var product = (Product)result.ViewData.Model;
            Assert.IsNotNull(result);
            Assert.IsNotNull(product);
            Assert.AreEqual("Laptop", product.Name);
        }
        //Redirect test.
        [TestMethod]
        public void TestDetailsRedirect()
        {
            var controller = new HomeController();
            var result = controller.DetailsWithIf(-1) as RedirectToRouteResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        //Test ViewModel value.
        [TestMethod]
        public void ThenReturnTheAboutViewModel()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            var model = result.Model as AboutViewModel;

            Assert.IsNotNull(result);
            Assert.AreEqual("About DanylkoWeb", model.Title);
        }
    
        // Count list elements in action.
        [TestMethod]
        public void CountElementsInAction()
        {
            var controller = new HomeController();
            var result = controller.Products() as ViewResult;
            var list = result.Model as List<Product>;

            Assert.IsNotNull(result);
            Assert.IsNotNull(list);
            Assert.AreEqual(5, list.Count);
        }

        [TestMethod]
        public void ViewBagValues()
        {
            var controller = new HomeController();
            var result = controller.About() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.AreEqual("About Us", result.ViewBag.Title);
        }

        [TestMethod]
        public void CheckCountValueTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.CheckCountValue(1) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
