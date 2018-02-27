using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib
{
    /// <summary>Provides information about a movie.</summary>
    public class Movie
    {
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

        /// <summary>Validation method for title and length<returns></returns>
        public string Validate()
        {
            //Title is required
            if (String.IsNullOrEmpty(_title))
                return "Title cannot be empty";

            //Length >= 0
            if (Length < 0)
                return "Length must be >= 0";

            return "";
        }

        private string _title;
        private string _description;
    }
}
