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
    /// <param name="movie">The movie to add.</param>
    public interface IMovieDatabase
    {
        Movie Add( Movie movie, out string message );

        IEnumerable<Movie> GetAll();

        void Remove( int id );

        Movie Update( Movie movie, out string message );
    }
}
