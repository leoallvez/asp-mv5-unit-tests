using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UnitTests.Models;

//https://www.tutorialspoint.com/asp.net_mvc/asp.net_mvc_unit_testing.htm
namespace UnitTests.Controllers
{
    public class EmployeeController : Controller
    {
        [NonAction]
        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>{
            new Employee{
               Id = 1,
               Name = "Allan",
               JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
               Age = 23
            },

            new Employee{
               Id = 2,
               Name = "Carson",
               JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
               Age = 45
            },

            new Employee{
               Id = 3,
               Name = "Carson",
               JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
               Age = 37
            },

            new Employee{
               Id = 4,
               Name = "Laura",
               JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
               Age = 26
            },
         };
        }

        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Employees()
        {             
            return View(GetEmployeeList());
        }
    }
}