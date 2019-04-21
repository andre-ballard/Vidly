using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.EFModels;
using Vidly.Models;
using System.Data.Entity;
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

        public ActionResult New()
        {
            var membershipTypes = _DbContext.MembershipTypes;
            var model = new CustomerFormViewModel() {
                MembershipType = membershipTypes
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (customer.ID == 0)
            {
                _DbContext.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _DbContext.Customers.Single(c =>c.ID == customer.ID);

                customerInDb.Name = customer.Name;
                customerInDb.BirthDay = customer.BirthDay;
                customerInDb.MembershipType = customer.MembershipType;
                customerInDb.isSubscribedToNewsLetter = customer.isSubscribedToNewsLetter;
            }

            _DbContext.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
            var customer = _DbContext.Customers.SingleOrDefault(c=>c.ID == id);

            if (customer == null)
                return HttpNotFound();
            var model = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipType = _DbContext.MembershipTypes.ToList()
            };
            return View("New", model);
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
            var model = new RandomMovieViewModel();
            _customers = _DbContext.Customers.Include(c => c.MembershipType).ToList();
            model.customers = _customers;
            return View(model);
        }

        public ActionResult GetCustomer(int id)
        {
            /* _customers.Add(
                 new Customer() { ID = 1, Name = "John" });
             _customers.Add(
                 new Customer() { ID = 2, Name = "Good Fellow" });

             */
            var customers = _DbContext.Customers.Include(c=>c.MembershipType).FirstOrDefault(c => c.ID ==id);

            if (customers == null)
                return HttpNotFound();

            return View(customers);

        }
        

    }
}
