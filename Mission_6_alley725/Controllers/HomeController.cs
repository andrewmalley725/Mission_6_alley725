using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission_6_alley725.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6_alley725.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieContext _db;

        public HomeController(ILogger<HomeController> logger, MovieContext movie)
        {
            _logger = logger;

            _db = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {

            ViewBag.Ratings = _db.Ratings.ToList();

            ViewBag.Categories = _db.Category.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Movies movie)
        {

            if (ModelState.IsValid)
            {
                _db.Add(movie);
                _db.SaveChanges();
                var data = _db.Movies
                    .Include(x => x.rating)
                    .Include(x => x.category)
                    .OrderBy(x => x.title)
                    .ToList();
                return View("Data", data);
            }

            else
            {
                ViewBag.Ratings = _db.Ratings.ToList();

                ViewBag.Categories = _db.Category.ToList();

                return View();
            }
            
        }

        public IActionResult Data()
        {
            var data = _db.Movies
                .Include(x => x.rating)
                .Include(x => x.category)
                .OrderBy(x => x.title)
                .ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = _db.Movies.FirstOrDefault(x => x.movieId == id);

            ViewBag.Ratings = _db.Ratings.ToList();

            ViewBag.Categories = _db.Category.ToList();

            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit(Movies mov)
        {

            var movie = _db.Movies.FirstOrDefault(x => x.movieId == mov.movieId);
            if (movie == null)
            {
                return NotFound();
            }

            movie.title = mov.title;
            movie.categoryId = mov.categoryId;
            movie.ratingId = mov.ratingId;
            movie.year = mov.year;
            movie.edited = mov.edited;
            movie.lentTo = mov.lentTo;
            movie.notes = mov.notes;

            _db.Movies.Update(movie);
            _db.SaveChanges();

            return RedirectToAction("Data");
        }


        public IActionResult Delete(int id)
        {
            var movie = _db.Movies.FirstOrDefault(x => x.movieId == id);

            _db.Movies.Remove(movie);

            _db.SaveChanges();

            return RedirectToAction("Data");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}