using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web;
using vidly.Models;
using vidly.ViewModels;
using vidly.Data;

namespace vidly.Controllers
{
    [Route("movies")]
    public class MoviesController : Controller
    {
        private readonly MyContext _context;
        
        public MoviesController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("random")]
        public ActionResult Random() {
            // Movie movie = new Movie() { Name = "shrek!", Id = 5 };
            // MovieRandomVIew viewData = new MovieRandomVIew() { 
            //     movie = new Movie(){ Name = "shrek!", Id = 5 },
            //     customer = new Customer() { Name = "Darth Vader", Id = 10 },
            //     customers = new List<Customer>() {
            //         new Customer() { Name = "Austra Ramadhan", Id = 1 },
            //         new Customer() { Name = "Audia", Id = 3 }
            //     }   
            // };

            IEnumerable<Movie> movies = 
                from cinema in _context.movies
                select cinema;
            // return View(viewData);
            return Json(movies);
        }

        [HttpPost]
        [Route("insert")]
        public ActionResult updateMovies([FromBody] Movie movie) {
            _context.movies.Add(movie);
            _context.SaveChanges();
            return StatusCode(200);
        }

        [HttpDelete]
        [Route("delete/{age}")]
        public ActionResult delete(int age) {
            Movie detail = _context.movies.Find(age);
            _context.movies.Remove(detail);
            _context.SaveChanges();
            return StatusCode(200);
        }

        [HttpPut]
        [Route("update")]
        public ActionResult update([FromBody] Movie movie) {
            _context.movies.Update(movie);
            _context.SaveChanges();
            return StatusCode(200);
        }

    }
}