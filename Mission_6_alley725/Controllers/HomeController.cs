using Microsoft.AspNetCore.Mvc;
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

            ViewData["Ratings"] = new string[] { "G", "PG", "PG-13", "R" };

            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Movies movie)
        { 
            _db.Add(movie);
            _db.SaveChanges();
            var data = _db.Movies.ToList();
            return View("Data", data);
        }

        public IActionResult Data()
        {
            var data = _db.Movies.ToList();
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
