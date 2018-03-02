/* Nicholas Uramkin
 * Lab 2
 * ITSE 1430
 * 2/26/2018
 * MainForm.cs
 * */

using System;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib.Windows
{
    /// <summary>Class for MainForm</summary>
    public partial class MainForm : Form
    {
        /// <summary>MainForm default constructor</summary>
        public MainForm()
        {
            InitializeComponent();
        }

        //exit application
        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnMoviesAdd( object sender, EventArgs e )
        {
            //instatiate MovieDetailForm with Add Product in titlebar
            var form = new MovieDetailForm("Add Product");

            //show MovieDetailForm
            var result = form.ShowDialog(this);
            //return if OK(Save) not selected
            if (result != DialogResult.OK)
                return;

            //add movie
            _movie = form.Movie;
            MessageBox.Show("Movie Added");
        }

        private void OnMoviesEdit( object sender, EventArgs e )
        {
            //check for movie in system
            if (_movie == null)
            {
                MessageBox.Show("No movie in system", "Error");
                return;
            }

            //instatiate MovieDetailForm with movie being edited
            var form = new MovieDetailForm(_movie);
            
            //load movie into form
            form.Movie = _movie;

            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //edit movie(assign edited form to movie)
            _movie = form.Movie;
            MessageBox.Show("Edit Saved");
        }

        private void OnMoviesRemove( object sender, EventArgs e )
        {
            if (_movie == null)
            {
                MessageBox.Show("No movie in system", "Error");
                return;
            }

            //get confirmation from user
            if (!ShowConfirmation("Are you sure?", "Remove Movie"))
                return;

            //remove movie
            _movie = null;
            MessageBox.Show("Movie removed");
        }

        //show about window
        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();

            form.ShowDialog();
        }

        //show confirmation window
        private bool ShowConfirmation( string message, string title )
        {
            //return true if Yes
            return MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private Movie _movie;
    }
}
