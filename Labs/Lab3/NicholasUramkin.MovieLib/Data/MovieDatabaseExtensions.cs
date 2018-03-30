/* Nicholas Uramkin
 * Lab 3
 * ITSE 1430
 * 3/26/2018
 * MovieDatabaseExtensions.cs
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib.Data
{
    /// <summary>
    /// Extension class for IMovieDatabase
    /// </summary>
    public static class MovieDatabaseExtensions
    {
        /// <summary>
        /// Seeds database with sample movies for testing program
        /// </summary>
        /// <param name="source"></param>
        public static void Seed(this IMovieDatabase source)
        {
            var message = "";
            source.Add(new Movie() {
                Title = "Akira",
                Owned = true,
                Length = 124, }, out message);
            source.Add(new Movie() {
                Title = "Shin Godzilla",
                Owned = true,
                Length = 120, }, out message);
            source.Add(new Movie() {
                Title = "End of Evangelion",
                Owned = true,
                Length = 90
            }, out message);
        }
    }
}
