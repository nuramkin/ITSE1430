using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaFusionApp.Windows
{
    public class Persona
    {
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Recipe
        {
            get { return _recipe; }
            set { _recipe = value; }
        }

        public Bitmap Pic { get; set; }
        


        private string _name;
        private string _recipe;
        //private string _pic;
    }
}
