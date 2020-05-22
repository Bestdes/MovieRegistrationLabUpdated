using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieRegistration.Models
{
    public class Movie
    {
        [Key]
        [Required(ErrorMessage = "Please enter a Movie ID ")]
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Moive Title cannot be blank, please enter a Movie Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Movie Genre cannot be blank, please enter a Movie Genre")]
        public string Genre { get; set; }

        [Range(1880, 2024, ErrorMessage = "Please enter a valid Movie Year")]
        public int Year { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }

        public List<string> ActorsList { get; set; }

        public List<string> DirectorsList { get; set; }
    }
}
