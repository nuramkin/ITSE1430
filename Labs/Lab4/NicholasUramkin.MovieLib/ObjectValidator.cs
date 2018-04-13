/* Nicholas Uramkin
 * Lab 3
 * ITSE 1430
 * 3/26/2018
 * ObjectValidator.cs
 * */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib
{
    /// <summary>
    /// Provides validation for data
    /// </summary>
    public static class ObjectValidator
    {
        /// <summary>
        /// Validates an object and all of its properties
        /// </summary>
        /// <param name="source">object being validated</param>
        /// <returns>result of validation</returns>
        public static IEnumerable<ValidationResult> Validate (this IValidatableObject source)
        {
            var context = new ValidationContext(source);
            var errors = new Collection<ValidationResult>();
            Validator.TryValidateObject(source, context, errors, true);

            return errors;
        }
    }
}
