using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NicholasUramkin.MovieLib.Data;
using NicholasUramkin.MovieLib.Data.Sql;
using NicholasUramkin.MovieLib.Mvc.Models;

namespace NicholasUramkin.MovieLib.Mvc.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public MovieController()
        {
            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"];
            _database = new SqlMovieDatabase(connString.ConnectionString);
        }

        private readonly IMovieDatabase _database;

        [HttpGet]
        public ActionResult Index()
        {
            var movies = _database.GetAll();
            return View(movies.Select(m => m.ToModel()));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add( MovieViewModel model )
        {
            try
            { 
                if (ModelState.IsValid)
                {
                    var movie = model.ToDomain();

                    movie = _database.Add(movie);

                    return RedirectToAction(nameof(Index));
            }
            }catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
            };

            return View( model);
}
    }
}