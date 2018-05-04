/* Nicholas Uramkin
 * Lab 5
 * ITSE 1430
 * 4/30/2018
 * MovieViewModelExtensions.cs
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NicholasUramkin.MovieLib.Mvc.Models
{
    /// <summary>
    /// Extension class for MovieViewModel
    /// </summary>
    public static class MovieViewModelExtensions
    {
        /// <summary>
        /// Converts Movie to MovieViewModel
        /// </summary>
        /// <param name="source"></param>
        /// <returns>MovieViewModel</returns>
        public static MovieViewModel ToModel( this Movie source )
            => new MovieViewModel() {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                Owned = source.Owned,
                Length = source.Length
            };

        /// <summary>
        /// Converts MovieViewModel to Movie
        /// </summary>
        /// <param name="source"></param>
        /// <returns>Movie</returns>
        public static Movie ToDomain( this MovieViewModel source )
            => new Movie() {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                Owned = source.Owned,
                Length = source.Length
            };
    }
}