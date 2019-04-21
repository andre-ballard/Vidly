using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public Movie()
        {
        }

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public int Stock { get; set; }
    }
}
