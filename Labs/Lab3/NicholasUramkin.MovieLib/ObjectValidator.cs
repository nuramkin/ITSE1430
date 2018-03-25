﻿using System;
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
        public static IEnumerable<ValidationResult> Validate (this IValidatableObject source)
        {
            var context = new ValidationContext(source);
            var errors = new Collection<ValidationResult>();
            Validator.TryValidateObject(source, context, errors, true);

            return errors;
        }
    }
}
