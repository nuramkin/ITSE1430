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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private Persona _persona = new Persona();
        private PersonaDatabase _database = new PersonaDatabase();

        //fool arcana button
        private void buttonFool_Click( object sender, EventArgs e )
        {
            var form = new FoolMenu();
            var result = form.ShowDialog(this);
        }

        private void buttonExit_Click( object sender, EventArgs e )
        {
            Close();
        }

        //searchbox
        private void buttonSearch_Click( object sender, EventArgs e )
        {
            
            var _persona = _database.GetPersonaByName(textSearch.Text);
            if (_persona == null)
            {
                MessageBox.Show(this, "Persona Not Found");
                return;
            }

            var form = new PersonaDetailForm(_persona, "");
            var result = form.ShowDialog(this);
        }

        private void buttonMagician_Click( object sender, EventArgs e )
        {
            var form = new MagicianMenu();
            var result = form.ShowDialog(this);
        }
    }
}
