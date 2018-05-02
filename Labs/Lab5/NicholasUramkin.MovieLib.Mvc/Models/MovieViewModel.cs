using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NicholasUramkin.MovieLib.Mvc.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Length must be >= 0")]
        public int Length { get; set; }

        public bool Owned { get; set; }
    }
}