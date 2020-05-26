using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class SessionsController : Controller
    {
        public List<Movie> sessionMoviesInCart = new List<Movie>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayMovie(string Title)
        {
            HttpContext.Session.SetString("MovieCartSession", Title);

            return View("Index");
        }

        public IActionResult RemoveMovie()
        {
            HttpContext.Session.Remove("MovieCartSession");
            return View("Index");
        }

        public IActionResult AddToSessionsList(Movie movie)
        {
            string MovieJSON = HttpContext.Session.GetString("MovieCartSession") ?? "FirstTimeDoingThis";
            if (MovieJSON != "FirstTimeDoingThis")
            {
                sessionMoviesInCart = JsonSerializer.Deserialize<List<Movie>>(MovieJSON);
            }

            sessionMoviesInCart.Add(movie);

            MovieJSON = JsonSerializer.Serialize(sessionMoviesInCart);

            HttpContext.Session.SetString("MovieCartSession", MovieJSON);

            return View("MovieCartSession", sessionMoviesInCart);
        }

        public IActionResult SelectActionFigure(string title)
        {
            string MovieJSON = HttpContext.Session.GetString("MovieCartSession") ?? "FirstTimeDoingThis";
            if (MovieJSON != "FirstTimeDoingThis")
            {
                sessionMoviesInCart = JsonSerializer.Deserialize<List<Movie>>(MovieJSON);
            }
            //this finds the Movie with the name selected from the table in the previous view
            //(ListActionFigures).

            Movie locatedMovie = sessionMoviesInCart.Where(x => x.Title == title).First();
            return View(locatedMovie);
        }
    }
}