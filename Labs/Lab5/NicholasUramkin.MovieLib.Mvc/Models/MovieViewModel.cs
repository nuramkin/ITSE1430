/* Nicholas Uramkin
 * Lab 5
 * ITSE 1430
 * 4/30/2018
 * MovieViewModel.cs
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NicholasUramkin.MovieLib.Mvc.Models
{
    /// <summary>
    /// View model for Movie class
    /// </summary>
    public class MovieViewModel : IValidatableObject
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Length must be >= 0")]
        public int Length { get; set; }

        public bool Owned { get; set; }

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            return new List<ValidationResult>();
        }
    }
}