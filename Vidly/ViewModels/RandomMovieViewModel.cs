using System;
using System.Collections.Generic;
using Vidly.Models;
namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public RandomMovieViewModel()
        {
        }

        public List<Movie> movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}
