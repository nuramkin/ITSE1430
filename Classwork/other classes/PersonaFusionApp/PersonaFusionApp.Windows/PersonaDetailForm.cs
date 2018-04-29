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
    public partial class PersonaDetailForm : Form
    {
        public PersonaDetailForm()
        {
            InitializeComponent();
        }

        public PersonaDetailForm(Persona persona, string name) : this()
        {
            Text = name;
            Persona = persona;
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (Persona != null)
            {
                labelName.Text = Persona.Name;
                //textBoxRecipe.Text = Persona.Recipe;
                labelRecipe.Text = Persona.Recipe;
                pictureBox.Image = Persona.Pic;
                //pictureBox.Image = Properties.Resources.Arsene;
            }
        }

        public Bitmap GetImage(string name)
        {
            return Properties.Resources.Arsene;
        }

        public Persona Persona { get; set; }

        private void button1_Click( object sender, EventArgs e )
        {
            Close();
        }
    }
}
