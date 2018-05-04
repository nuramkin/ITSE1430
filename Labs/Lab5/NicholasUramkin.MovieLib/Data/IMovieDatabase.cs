/* Nicholas Uramkin
 * Lab 5
 * ITSE 1430
 * 4/30/2018
 * IMovieDatabase.cs
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib.Data
{
    /// <summary>
    ///Adds a movie to the database
    /// </summary>
    public interface IMovieDatabase
    {
        /// <summary>
        /// Adds a movie to the database
        /// </summary>
        /// <param name="movie">movie being added</param>
        /// <param name="message">error message</param>
        /// <returns>the added movie</returns>
        Movie Add( Movie movie );

        /// <summary>
        /// Gets all movies
        /// </summary>
        /// <returns>list of movies</returns>
        IEnumerable<Movie> GetAll();

        /// <summary>
        /// Removes a movie
        /// </summary>
        /// <param name="id">id of a movie</param>
        void Remove( int id );

        /// <summary>
        /// Updates movie that already exists in the database
        /// </summary>
        /// <param name="movie">movie being updated</param>
        /// <param name="message">error message</param>
        /// <returns>updated movie</returns>
        Movie Update( Movie movie );
    }
}
