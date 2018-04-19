/* Nicholas Uramkin
 * Lab 3
 * ITSE 1430
 * 3/26/2018
 * MovieDetailForm.cs
 * */

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NicholasUramkin.MovieLib.Windows
{
    /// <summary>Form to add/edit a movie</summary>
    public partial class MovieDetailForm : Form
    {
        /// <summary>MovieDetailForm default constructor</summary>
        public MovieDetailForm()
        {
            InitializeComponent();
        }

        /// <summary>MovieDetailForm constructor (passes in string for titlebar)</summary><param name="title"></param>
        public MovieDetailForm( string title ) : this()
        {
            Text = title;
        }

        /// <summary>MovieDetailForm constructor (passes in movie to edit)</summary><param name="movie"></param>
        public MovieDetailForm( Movie movie ) : this("Edit Movie")
        {
            Movie = movie;
        }

        public MovieDetailForm(Movie movie, string title) : this()
        {
            Movie = movie;
            Text = title;
        }

        /// <summary>Gets or sets Movie being edited</summary>
        public Movie Movie { get; set; }

        //load event for movie
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //load movie
            if (Movie != null)
            {
                _txtTitle.Text = Movie.Title;
                _txtDescription.Text = Movie.Description;
                _txtLength.Text = Movie.Length.ToString();
                _chkOwned.Checked = Movie.Owned;
            }
            ValidateChildren();
        }

        //save event for movie
        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            //create movie
            var movie = new Movie();
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Length = ConvertToLength(_txtLength);
            movie.Owned = _chkOwned.Checked;

            //validate with IValidatableObject
            var errors = ObjectValidator.Validate(movie);
            if(errors.Count() > 0)
            {
                DisplayError(errors.ElementAt(0).ErrorMessage);
                return;
            }

            Movie = movie;
            DialogResult = DialogResult.OK;

            Close();
        }

        //converts length form textbox to integer
        private int ConvertToLength( TextBox control )
        {
            if (Int32.TryParse(control.Text, out var length))
                return length;

            return -1;
        }

        private void OnCancel( object sender, EventArgs e )
        {
            Close();
        }

        //error window
        private void DisplayError( string message )
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //warning for empty title textbox
        private void _txtTitle_Validating( object sender, CancelEventArgs e )
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text))
            {
                _errorProvider.SetError(textbox, "Title is required");
                e.Cancel = true;
            } else
                _errorProvider.SetError(textbox, "");
        }

        //warning for empty or invalid length textbox
        private void _txtLength_Validating( object sender, CancelEventArgs e )
        {
            var textbox = sender as TextBox;

            var price = ConvertToLength(textbox);
            if (price < 0)
            {
                _errorProvider.SetError(textbox, "Length must be >= 0");
                e.Cancel = true;
            } else
                _errorProvider.SetError(textbox, "");
        }
    }
}
