using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NicholasUramkin.MovieLib.Mvc.Models
{
    public static class MovieViewModelExtensions
    {
        public static MovieViewModel ToModel( this Movie source )
            => new MovieViewModel() {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                Owned = source.Owned,
                Length = source.Length
            };
    }
}