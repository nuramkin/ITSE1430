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
        public ActionResult Add()
        {
            //return empty movie
            return View(new MovieViewModel());
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

                    return RedirectToAction(nameof(List));
            }
            }catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
            };

            return View( model);
        }

        [HttpGet]
        public ActionResult Edit( int id )
        {
            //query movie from database
            var movie = _database.GetAll().FirstOrDefault(m => m.Id == id);

            //if movie doest not exist return 404
            if (movie == null)
                return HttpNotFound();

            return View(movie.ToModel());
        }

        [HttpPost]
        public ActionResult Edit( MovieViewModel model )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var movie = model.ToDomain();

                    movie = _database.Update(movie);

                    return RedirectToAction(nameof(List));
                }
            } catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            };

            return View(model);
        }

        [HttpGet]
        [Route("movies/delete/{id}")]
        public ActionResult Delete( int id )
        {

            var movie = _database.GetAll().FirstOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie.ToModel());

        }

        [HttpPost]
        public ActionResult Delete( MovieViewModel model )
        {
            try
            {
                var movie = _database.GetAll().FirstOrDefault(m => m.Id == model.Id);

                _database.Remove(model.Id);

                return RedirectToAction(nameof(List));
            } catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            };

            return View(model);
        }
    }
}