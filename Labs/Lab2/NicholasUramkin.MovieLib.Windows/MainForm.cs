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

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnMoviesAdd( object sender, EventArgs e )
        {
            var button = sender as ToolStripMenuItem;

            var form = new MovieDetailForm("Add Product");

            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            _movie = form.Movie;
            MessageBox.Show("Movie Added");
        }

        private void OnMoviesEdit( object sender, EventArgs e )
        {
            if (_movie == null)
            {
                MessageBox.Show("No movie in system", "Error");
                return;
            }
            var form = new MovieDetailForm(_movie);
            form.Movie = _movie;

            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

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

            if (!ShowConfirmation("Are you sure?", "Remove Movie"))
                return;

            _movie = null;
            MessageBox.Show("Movie removed");
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {

            var form = new AboutBox();

            form.ShowDialog();
        }

        private bool ShowConfirmation( string message, string title )
        {
            return MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private Movie _movie;
    }
}
