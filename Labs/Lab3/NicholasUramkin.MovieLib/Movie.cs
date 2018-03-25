/* Nicholas Uramkin
 * Lab 2
 * ITSE 1430
 * 2/26/2018
 * Movie.cs
 * Description: Windows Forms application that can add, edit, and remove a movie and its information.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NicholasUramkin.MovieLib
{
    /// <summary>Provides information about a movie.</summary>
    public class Movie : IValidatableObject
    {
        public int Id { get; set; }

        /// <summary>Gets or sets title.</summary>
        public string Title
        {
            get { return _title ?? ""; }
            set { _title = value ?? ""; }
        }

        /// <summary>Gets or sets description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value ?? ""; }
        }

        /// <summary>Gets or sets length</summary>
        public int Length { get; set; }

        /// <summary>Gets or sets Owned</summary>
        public bool Owned { get; set; }

        /// <summary>Validation method for Title and Length.  Title cannot be null or empty and Length must be >= 0.<returns></returns>
        //public string Validate()
        //{
        //    if (String.IsNullOrEmpty(_title))
        //        return "Title cannot be empty";

        //    if (Length < 0)
        //        return "Length must be >= 0";

        //    return "";
        //}

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var errors = new List<ValidationResult>();

            //title is required
            if (String.IsNullOrEmpty(_title))
                errors.Add(new ValidationResult("Title cannot be empty", new[] { nameof(Title) }));

            //length >= 0
            if (Length < 0)
                errors.Add(new ValidationResult("Length must be >= 0", new[] { nameof(Length) }));

            return errors;
        }

        private string _title;
        private string _description;
    }
}
