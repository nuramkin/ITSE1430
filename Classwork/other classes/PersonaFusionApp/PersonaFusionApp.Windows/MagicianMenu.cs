using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonaFusionApp.Windows;

namespace PersonaFusionApp
{
    public partial class MagicianMenu : Form
    {
        public MagicianMenu()
        {
            InitializeComponent();
        }

        private Persona _persona = new Persona();
        private PersonaDatabase _database = new PersonaDatabase();

        private void buttonJackOLantern_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Jack-o'-Lantern");
            var form = new PersonaDetailForm(_persona, "Jack-o'-Lantern");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonJackFrost_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Jack Frost");
            var form = new PersonaDetailForm(_persona, "Jack Frost");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonNekomata_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Nekomata");
            var form = new PersonaDetailForm(_persona, "Nekomata");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonSandman_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Sandman");
            var form = new PersonaDetailForm(_persona, "Sandman");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonChoronzon_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Choronzon");
            var form = new PersonaDetailForm(_persona, "Choronzon");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonQueenMab_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Queen Mab");
            var form = new PersonaDetailForm(_persona, "Queen Mab");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonRangda_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Rangda");
            var form = new PersonaDetailForm(_persona, "Rangda");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonSurt_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Surt");
            var form = new PersonaDetailForm(_persona, "Surt");
            var result = form.ShowDialog(this);
            Close();
        }

        private void buttonFutsunushi_Click( object sender, EventArgs e )
        {
            var _persona = _database.GetPersonaByName("Futsunushi");
            var form = new PersonaDetailForm(_persona, "Futsunushi");
            var result = form.ShowDialog(this);
            Close();
        }
    }
}
