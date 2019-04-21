using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> _customers = new List<Customer>();



        public ActionResult Index()
        {
            _customers.Add(
                new Customer() { ID = 1, Name = "John" });
            _customers.Add(
                new Customer() { ID = 2, Name = "Good Fellow" });
            var model = new RandomMovieViewModel()
            {
                customers = _customers
            };

            return View(model);
        }

        public ActionResult GetCustomer(int id)
        {
            _customers.Add(
                new Customer() { ID = 1, Name = "John" });
            _customers.Add(
                new Customer() { ID = 2, Name = "Good Fellow" });
            


            foreach(var obj in _customers)
            {
                if(id == obj.ID)
                {
                    return View(obj);
                }
            }

            return Content("No Customer Found");

        }
        

    }
}
