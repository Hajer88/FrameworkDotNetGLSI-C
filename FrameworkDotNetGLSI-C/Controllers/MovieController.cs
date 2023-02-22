using FrameworkDotNetGLSI_C.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrameworkDotNetGLSI_C.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movie
        public IEnumerable<Movie> getMovies()
        {
            var movies= new List<Movie>(){
                new Movie{Id=1, Title="Film 1"},
                new Movie{Id=2, Title="Film 2"}
            };
            return movies;
        }
        public ActionResult Index()
        {
            var m = _context.movies.ToList();
            
            return View(m);
        }
        public ActionResult Edit(int id)
        {
            return Content("Id est  " + id);
            
        }
        //Définir route de chaque contrôleur dans des annotations
        [Route("Date/{year}/{month}")]
        public ActionResult DateYearMonth(int year, int month)
        {
            return Content(year+"   "+month);
        }
        public ActionResult details(int id)
        {
            var movieDetails = _context.movies.First(c => c.Id == id);
            return View(movieDetails);
        }

        public ActionResult GetMoviewithGenre()
        {
            var movie = _context.movies.Include(c=>c.genre).ToList();
            return View(movie);
        }
      
    }
}