/* Nicholas Uramkin
 * Lab 4
 * ITSE 1430
 * 4/16/2018
 * MovieDatabase.cs
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <returns>the added movie</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        /// <exception cref="Exception">A movie with the same title already exists.</exception>
        public Movie Add( Movie movie )
        {
            //check for null
            movie = movie ?? throw new ArgumentNullException(nameof(movie));

            //validate movie with IvalidatableObject
            movie.Validate();

            //verify movie is unique
            var existing = GetMovieByTitleCore(movie.Title);
            if (existing != null)
                throw new Exception("Movie already exists");

            return AddCore(movie);
        }

        /// <summary>
        /// Gets all movies
        /// </summary>
        /// <returns>list of movies</returns>
        public IEnumerable<Movie> GetAll()
        {
            return from m in GetAllCore()
                   orderby m.Title, m.Id descending
                   select m;
        }

        /// <summary>
        /// Removes a movie
        /// </summary>
        /// <param name="id">id of movie, must be greater than 0</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to zero.</exception>
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
        /// <returns>updated movie</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        /// <exception cref="Exception">A movie with the same title already exists</exception>
        /// <exception cref="ArgumentException">The movie does not exist</exception>
        public Movie Update( Movie movie )
        {
            //check for null
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            //validate movie with IValidatableObject
            movie.Validate();

            //verify movie is unique
            var existing = GetMovieByTitleCore(movie.Title);
            if (existing != null && existing.Id != movie.Id)
                throw new Exception("Movie already exists");

            //find existing
            existing = existing ?? GetCore(movie.Id);
            if (existing == null)
                throw new ArgumentException("Movie not found", nameof(movie));

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
