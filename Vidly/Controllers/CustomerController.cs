using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.EFModels;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> _customers = new List<Customer>();
        private MyDBContext _DbContext;
        public CustomerController()
        {
            _DbContext = new MyDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _DbContext.Dispose();
        }

        public ActionResult Index()
        {
           /* _customers.Add(
                new Customer() { ID = 1, Name = "John" });
            _customers.Add(
                new Customer() { ID = 2, Name = "Good Fellow" });
            var model = new RandomMovieViewModel()
            {
                customers = _customers
            };*/

            _customers = _DbContext.Customers.ToList();
            return View(_customers);
        }

        public ActionResult GetCustomer(int id)
        {
            /* _customers.Add(
                 new Customer() { ID = 1, Name = "John" });
             _customers.Add(
                 new Customer() { ID = 2, Name = "Good Fellow" });

             */
            var customers = _DbContext.Customers.FirstOrDefault(c => c.ID ==id);

            if (customers == null)
                return HttpNotFound();

            return View(customers);

        }
        

    }
}
