using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib.Data
{
    public abstract class MovieDatabase : IMovieDatabase
    {
        public Movie Add( Movie movie, out string message )
        {
            //check for null
            if(movie == null)
            {
                message = "Movie cannot be null.";
                return null;
            }

            //validate movie with IvalidatableObject
            var errors = movie.Validate();

            var error = errors.FirstOrDefault();
            if(error != null)
            {
                message = error.ErrorMessage;
                return null;
            }

            //verify movie is unique
            var existing = GetMovieByTitleCore(movie.Title);
            if (existing != null)
            {
                message = "Movie already exists.";
                return null;
            }

            message = null;
            return AddCore(movie);
        }

        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        public void Remove( int id )
        {
            if (id > 0)
                RemoveCore(id);
        }

        public Movie Update( Movie movie, out string message )
        {
            message = "";
            
            //check for null
            if(movie == null)
            {
                message = "Movie cannot be null.";
                return null;
            }

            //validate movie with IValidatableObject
            var errors = ObjectValidator.Validate(movie);
            if(errors.Count() > 0)
            {
                //get first error (element at 0)
                message = errors.ElementAt(0).ErrorMessage;
                return null;
            }

            //verify movie is unique
            var existing = GetMovieByTitleCore(movie.Title);
            if (existing != null && existing.Id != movie.Id)
            {
                message = "Movie already exists.";
                return null;
            }

            //find existing
            existing = existing ?? GetCore(movie.Id);
            if (existing == null)
            {
                message = "Product not found.";
                return null;
            }

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
