/* Nicholas Uramkin
 * Lab 5
 * ITSE 1430
 * 4/30/2018
 * MovieController.cs
 * */
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
    /// <summary>
    /// Controller class for Movie webpage
    /// </summary>
    public class MovieController : Controller
    {
        /// <summary>
        /// Constructor to connect to SQL database
        /// </summary>
        public MovieController()
        {
            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"];
            _database = new SqlMovieDatabase(connString.ConnectionString);
        }

        /// <summary>
        /// Result of List action that queries the movie database and converts each movie to a view model
        /// </summary>
        /// <returns>ViewResult of movie models</returns>
        [HttpGet]
        public ActionResult List()
        {
            var movies = _database.GetAll();
            return View(movies.Select(m => m.ToModel()));
        }

        /// <summary>
        /// Gets a movie to add
        /// </summary>
        /// <returns>ViewResult of empty MovieViewModel</returns>
        [HttpGet]
        public ActionResult Add()
        {
            return View(new MovieViewModel());
        }

        /// <summary>
        /// Adds movie to database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Redirect to List View or ViewResult of existing model</returns>
        [HttpPost]
        public ActionResult Add( MovieViewModel model )
        {
            try
            { 
                if (ModelState.IsValid)
                {
                    //convert MovieViewModel to Movie
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

        /// <summary>
        /// Gets movie to edit from database by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ViewResult of movie model or HttpNotFound</returns>
        [HttpGet]
        public ActionResult Edit( int id )
        {
            var movie = _database.GetAll().FirstOrDefault(m => m.Id == id);

            //if movie doest not exist return 404
            if (movie == null)
                return HttpNotFound();

            return View(movie.ToModel());
        }

        /// <summary>
        /// Updates edited movie in the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Redirect to List View or ViewResult of existing model</returns>
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

        /// <summary>
        /// Gets movie to delete by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ViewResult of movie model or HttpNotFound</returns>
        [HttpGet]
        public ActionResult Delete( int id )
        {
            var movie = _database.GetAll().FirstOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie.ToModel());

        }

        /// <summary>
        /// Deletes movie from database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Redirect to List View or ViewResult of existing model</returns>
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

        private readonly IMovieDatabase _database;
    }
}