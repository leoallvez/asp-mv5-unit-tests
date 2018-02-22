using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Controllers;
using System.Web.Mvc;
using UnitTests.Models;
using System.Collections.Generic;

namespace UnitTestsLab
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void Employees()
        {
            var controller = new EmployeeController();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CountElementsInAction()
        {
            var controller = new EmployeeController();
            var result = controller.Employees() as ViewResult;
            var list = result.Model as List<Employee>;

            Assert.IsNotNull(result);
            Assert.IsNotNull(list);
            Assert.AreEqual(4, list.Count);
        }
    }
}
