using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movies = new Movie() { Name = "Shrek!" };
            ViewData["Movie"] = movies;
            var customers = new List<Customer>()
            {
                new Customer {Name = "C1"}
                ,new Customer {Name="C2"}
            };

            var viewModel = new RandomMovieViewModel() { movie = movies,
            customers = customers};

            return View(viewModel);
            //return Content("hi");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page=1, sortBy="name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        /*[Route("movies/released/{year}/{month:regex(\\d{4}):range(1:12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
    }
}
