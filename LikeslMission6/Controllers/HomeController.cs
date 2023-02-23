using LikeslMission6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LikeslMission6.Controllers
{
    public class HomeController : Controller
    {
        
        private MovieInfoContext _MovieInfoContext { get; set; }

        public HomeController(MovieInfoContext Moviefile)
        {
            _MovieInfoContext = Moviefile;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.categories = _MovieInfoContext.categories.ToList();
  
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(MovieResponse mr)
        {
            if (ModelState.IsValid)
            { 
            _MovieInfoContext.Add(mr);
            _MovieInfoContext.SaveChanges();
            return View("ItWorked", mr);
            }
            else //if invalid 
            {
                ViewBag.categories = _MovieInfoContext.categories.ToList();
                return View(mr);
            }
        }
        public IActionResult ListMovies()
        {
            var listItems = _MovieInfoContext.responses
                .Include(x => x.Category)
                //.Where(x => x.Year >= 2000)
                .OrderBy(x => x.MovieName)
                .ToList()
                ;

            return View(listItems);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.categories = _MovieInfoContext.categories.ToList();

            var categories = _MovieInfoContext.responses.Single(x => x.Id == id);

            return View("MovieForm", categories);
        }

        [HttpPost]
        public IActionResult Edit (MovieResponse movie)
        {
            _MovieInfoContext.Update(movie);
            _MovieInfoContext.SaveChanges();
            return RedirectToAction("ListMovies");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

            var movie = _MovieInfoContext.responses.Single(x => x.Id == id);
            return View(movie);  
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            _MovieInfoContext.responses.Remove(mr);
            _MovieInfoContext.SaveChanges();
            return RedirectToAction("ListMovies");
        }
    }
}
