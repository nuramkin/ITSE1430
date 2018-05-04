/* Nicholas Uramkin
 * Lab 5
 * ITSE 1430
 * 4/30/2018
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
        public static IEnumerable<ValidationResult> TryValidate (this IValidatableObject source)
        {
            var context = new ValidationContext(source);
            var errors = new Collection<ValidationResult>();
            Validator.TryValidateObject(source, context, errors, true);

            return errors;
        }

        /// <summary>Validates an object and all of its properties</summary>
        /// <param name="source">object being validated</param>
        public static void Validate (this IValidatableObject source)
        {
            var context = new ValidationContext(source);
            Validator.ValidateObject(source, context, true);
        }
    }
}
