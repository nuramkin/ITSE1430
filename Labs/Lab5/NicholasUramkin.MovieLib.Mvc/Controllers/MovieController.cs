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
        public ActionResult List()
        {
            var movies = _database.GetAll();
            return View(movies.Select(m => m.ToModel()));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MovieViewModel model)
        {

        }
    }
}