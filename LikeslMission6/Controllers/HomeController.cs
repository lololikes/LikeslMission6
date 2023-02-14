using LikeslMission6.Models;
using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private MovieInfoContext _MovieInfoContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieInfoContext Moviefile)
        {
            _logger = logger;
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
  
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(MovieResponse mr)
        {
            _MovieInfoContext.Add(mr);
            _MovieInfoContext.SaveChanges();
            return View("ItWorked", mr);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
