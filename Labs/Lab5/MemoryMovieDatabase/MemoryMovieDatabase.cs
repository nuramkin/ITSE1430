/* Nicholas Uramkin
 * Lab 4
 * ITSE 1430
 * 4/16/2018
 * MemoryMovieDatabase.cs
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib.Data.Memory
{
    /// <summary>
    /// In-memory movie database
    /// </summary>
    public class MemoryMovieDatabase : MovieDatabase
    {
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
            return from m in _movies
                   select Clone(m);
        }

        //gets movie by matching id, returns null if no match
        protected override Movie GetCore( int id )
        {
            return (from m in _movies
                    where m.Id == id
                    select m).FirstOrDefault();
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

            //clones object
            Copy(existing, movie);

            //returns the copy
            return movie;
        }

        //gets movie by matching title name, returns null if no match
        protected override Movie GetMovieByTitleCore( string title )
        {
            return (from m in _movies
                    where String.Compare(m.Title, title, true) == 0
                    select m).FirstOrDefault();
        }

        //clone movie (returns copied movie)
        private Movie Clone (Movie item)
        {
            var newMovie = new Movie();
            Copy(newMovie, item);

            return newMovie;
        }

        //copy movie from one object to another
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
