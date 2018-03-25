using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib.Data.Memory
{
    public class MemoryMovieDatabase : MovieDatabase
    {
        public MemoryMovieDatabase()
        {
            MovieDatabaseExtensions.Seed(this);
        }

        protected override Movie AddCore (Movie movie)
        {
            //clone the object
            movie.Id = _nextId++;
            _movies.Add(Clone(movie));

            //return copy
            return movie;
        }

        protected override IEnumerable<Movie> GetAllCore()
        {
            foreach (var movie in _movies)
            {
                if (movie != null)
                    yield return Clone(movie);
            }
        }

        protected override Movie GetCore( int id )
        {
            foreach (var movie in _movies)
            {
                if (movie.Id == id)
                    return movie;
            }
            return null;
        }

        protected override void RemoveCore( int id )
        {
            var existing = GetCore(id);
            if (existing != null)
                _movies.Remove(existing);
        }

        protected override Movie UpdateCore( Movie movie )
        {
            var existing = GetCore(movie.Id);

            Copy(existing, movie);

            return movie;
        }

        protected override Movie GetMovieByTitleCore( string title )
        {
            foreach (var movie in _movies)
            {
                if (String.Compare(movie.Title, title, true) == 0)
                    return movie;
            }
            return null;
        }

        //clone movie
        private Movie Clone (Movie item)
        {
            var newMovie = new Movie();
            Copy(newMovie, item);

            return newMovie;
        }

        private void Copy (Movie target, Movie source)
        {
            target.Id = source.Id;
            target.Title = source.Title;
            target.Description = source.Description;
            target.Length = source.Length;
            target.Owned = source.Owned;
        }
        private readonly List<Movie> _movies = new List<Movie>();
        private int _nextId = 1;
    }
}
