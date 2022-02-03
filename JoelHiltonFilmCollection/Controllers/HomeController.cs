using JoelHiltonFilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHiltonFilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FilmCollectionContext fcContext;
        public HomeController(ILogger<HomeController> logger, FilmCollectionContext fcc)
        {
            _logger = logger;
            fcContext = fcc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = fcContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(FilmCollection fc)
        {
            // submit adding a movie
            ViewBag.Categories = fcContext.Categories.ToList();
            if (ModelState.IsValid)
            {
                fcContext.Add(fc);
                fcContext.SaveChanges();

                return View("Confirmation", fc);
            }
            else
            {
                ViewBag.Categories = fcContext.Categories.ToList();
                return View();
            }
        }

        [HttpGet]
        public IActionResult ViewFilms()
        {
            // view films including film categories and order by title A-Z
            var films = fcContext.collection
                .Include(x => x.Category)
                //.Where(x => x.Edited == false)
                .OrderBy(x => x.Title)
                .ToList();
            return View(films);
        }

        public IActionResult Edit (int filmid)
        {
            // Edit the film for that row
            ViewBag.Categories = fcContext.Categories.ToList();
            var film = fcContext.collection.Single(x => x.FilmId == filmid);

            return View("AddMovie", film);
        }

        [HttpPost]
        public IActionResult Edit (FilmCollection fc)
        {
            // Submit the edit
            fcContext.Update(fc);
            fcContext.SaveChanges();

            return RedirectToAction("ViewFilms");
        }

        [HttpGet]
        public IActionResult Delete (int FilmId)
        {
            // delete the film for that row
            var film = fcContext.collection.Single(x => x.FilmId == FilmId);
            return View(film);
        }

        [HttpPost]
        public IActionResult Delete(FilmCollection fc)
        {
            // submit deletion
            fcContext.collection.Remove(fc);
            fcContext.SaveChanges();

            return RedirectToAction("ViewFilms");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
