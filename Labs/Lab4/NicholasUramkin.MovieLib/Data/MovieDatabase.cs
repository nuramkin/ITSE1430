/* Nicholas Uramkin
 * Lab 3
 * ITSE 1430
 * 3/26/2018
 * MovieDatabase.cs
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: add doctags for exeptions

namespace NicholasUramkin.MovieLib.Data
{
    /// <summary>
    /// Base implementation for IProductDatabase
    /// </summary>
    public abstract class MovieDatabase : IMovieDatabase
    {
        /// <summary>
        /// Adds new movie
        /// </summary>
        /// <param name="movie">movie being added</param>
        /// <param name="message">error message</param>
        /// <returns>the added movie</returns>
        public Movie Add( Movie movie )
        {
            //check for null
            //if(movie == null)
            //{
            //    message = "Movie cannot be null.";
            //    return null;
            //}

            movie = movie ?? throw new ArgumentNullException(nameof(movie));

            //validate movie with IvalidatableObject
            var errors = movie.Validate();

            //var error = errors.FirstOrDefault();
            //if(error != null)
            //{
            //    message = error.ErrorMessage;
            //    return null;
            //}

            //verify movie is unique
            var existing = GetMovieByTitleCore(movie.Title);
            if (existing != null)
                throw new Exception("Movie already exists");
            //{
            //    message = "Movie already exists.";
            //    return null;
            //}

            //message = null;//null for no error
            return AddCore(movie);
        }

        /// <summary>
        /// Gets all movies
        /// </summary>
        /// <returns>list of movies</returns>
        public IEnumerable<Movie> GetAll()
        {
            //return GetAllCore();

            return from m in GetAllCore()
                   orderby m.Title, m.Id descending
                   select m;
        }

        /// <summary>
        /// Removes a movie
        /// </summary>
        /// <param name="id">id of movie, must be greater than 0</param>
        public void Remove( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0");

            RemoveCore(id);
        }

        /// <summary>
        /// Updates an already existing movie
        /// </summary>
        /// <param name="movie">movie to update</param>
        /// <param name="message">error message</param>
        /// <returns>updated movie</returns>
        public Movie Update( Movie movie )
        {
            //message = "";

            //check for null
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));
            //{
            //    message = "Movie cannot be null.";
            //    return null;
            //}

            //validate movie with IValidatableObject
            //var errors = ObjectValidator.Validate(movie);
            movie.Validate();
            //if(errors.Count() > 0)
            //{
            //    //get first error (element at 0)
            //    message = errors.ElementAt(0).ErrorMessage;
            //    return null;
            //}

            //verify movie is unique
            var existing = GetMovieByTitleCore(movie.Title);
            if (existing != null && existing.Id != movie.Id)
                throw new Exception("Movie already exists");
            //{
            //    message = "Movie already exists.";
            //    return null;
            //}

            //find existing
            existing = existing ?? GetCore(movie.Id);
            if (existing == null)
                throw new ArgumentException("Movie not found", nameof(movie));
            //{
            //    message = "Product not found.";
            //    return null;
            //}

            return UpdateCore(movie);
        }

        protected abstract Movie AddCore( Movie movie );
        protected abstract IEnumerable<Movie> GetAllCore();
        protected abstract Movie GetCore( int id );
        protected abstract void RemoveCore( int id );
        protected abstract Movie UpdateCore( Movie movie );
        protected abstract Movie GetMovieByTitleCore( string title );
    }
}
