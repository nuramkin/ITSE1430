using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib.Data
{
    public static class MovieDatabaseExtensions
    {
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
