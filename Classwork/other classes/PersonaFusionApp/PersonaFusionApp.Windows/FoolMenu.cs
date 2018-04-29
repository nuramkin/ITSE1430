using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PersonaFusionApp.Windows
{
    public partial class FoolMenu : Form
    {
        

        public FoolMenu()
        {
            InitializeComponent();
        }

        private Persona _persona = new Persona();
        private PersonaDatabase _database = new PersonaDatabase();

        //Back button
        private void button1_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void buttonArsene_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Arsene");           
            var form = new PersonaDetailForm(_persona, "Arsene");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonObariyon_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Obariyon");
            var form = new PersonaDetailForm(_persona, "Obariyon");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonHighPixie_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("High Pixie");
            var form = new PersonaDetailForm(_persona, "High Pixie");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonDecambria_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Decarabia");
            var form = new PersonaDetailForm(_persona, "Decarabia");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonLegion_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Legion");
            var form = new PersonaDetailForm(_persona, "Legion");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonOse_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Legion");
            var form = new PersonaDetailForm(_persona, "Legion");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonBugs_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Bugs");
            var form = new PersonaDetailForm(_persona, "Bugs");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonDionysus_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Dionysus");
            var form = new PersonaDetailForm(_persona, "Dionysus");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonBlackFrost_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Black Frost");
            var form = new PersonaDetailForm(_persona, "Black Frost");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonVishnu_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Vishnu");
            var form = new PersonaDetailForm(_persona, "Vishnu");
            var result = form.ShowDialog(this);
            Close();
        }
    }
}
