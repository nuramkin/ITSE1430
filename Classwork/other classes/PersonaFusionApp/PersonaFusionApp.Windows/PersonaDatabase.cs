using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaFusionApp.Windows
{
    public class PersonaDatabase
    {
        public PersonaDatabase()
        {
            _personas = new List<Persona>();
            {
                _personas.Add(new Persona() {
                    Name = "Arsene", Pic = Properties.Resources.Arsene,
                    Recipe = "\n\nJack - o'-Lantern (2 / Magician) x Mandrake (3 / Death)\n\n" +
                                 "Pixie(2 / Lovers) x Agathion(3 / Chariot)\n\n" +
                                 "Agathion(3 / Chariot) x Succubus(7 / Moon)\n\n" +
                                 "Mandrake(3 / Death) x Kelpie(6 / Strength)\n\n" +
                                 "Bicorn(4 / Hermit) x Silky(6 / Priestess)\n\n" +
                                 "Incubus(5 / Devil) x Genbu(7 / Temperance)\n\n" +
                                 "Kelpie(6 / Strength) x Mokoi(9 / Death)\n\n" +
                                 "Saki Mitama(6 / Lovers) x Slime(10 / Chariot)\n\n" +
                                 "Silky(6 / Priestess) x Succubus(7 / Moon)\n\n" +
                                 "Genbu(7 / Temperance) x Berith(9 / Hierophant)\n\n" +
                                 "Succubus(7 / Moon) x Angel(12 / Justice)\n\n" +
                                 "Berith(9 / Hierophant) x Koropokkuru(9 / Hermit)\n\n" +
                                 "Hua Po(9 / Hanged Man) x Jatayu(32 / Tower)\n\n" +
                                 "Koropokkuru(9 / Hermit) x Silky(6 / Priestess)\n\n" +
                                 "Mokoi(9 / Death) x Kelpie(6 / Strength)\n\n" +
                                 "Andras(10 / Devil) x Genbu(7 / Temperance)\n\n" +
                                 "Slime(10 / Chariot) x Succubus(7 / Moon)\n\n" +
                                 "Apsaras(11 / Priestess) x Succubus(7 / Moon)\n\n" +
                                 "Jack Frost(11 / Magician) x Mokoi(9 / Death)\n\n" +
                                 "Kodama(11 / Star) x Jack Frost(11 / Magician)\n\n" });

                _personas.Add(new Persona() { Name = "Obariyon", Pic = Properties.Resources.Obariyon,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "High Pixie", Pic = Properties.Resources.HighPixie,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Decarabia", Pic = Properties.Resources.Decarabia,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Legion", Pic = Properties.Resources.Legion,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Ose", Pic = Properties.Resources.Ose,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Bugs", Pic = Properties.Resources.Bugs,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Dionysus", Pic = Properties.Resources.Dionysus,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Black Frost", Pic = Properties.Resources.BlackFrost,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Vishnu", Pic = Properties.Resources.Vishnu,
                    Recipe = "" });

                //_personas.Add(new Persona() { Name = "", Pic = Properties.Resources.,
                //    Recipe = "" });
            };
        }

        public Persona GetPersonaByName( string name )
        {
            foreach (var persona in _personas)
            {
                if (String.Compare(persona.Name, name, true) == 0)
                    return persona;
            }

            return null;
        }

        public Persona GetPersonaByNameCore( string name )
        {
            throw new NotImplementedException();
        }

        //public List<Persona> GetList { get; }

        private readonly List<Persona> _personas = new List<Persona>();
    }

    //public IEnumerable<Persona> GetAll()
    //{
    //    return GetAllCore();
    //}

    //protected abstract IEnumerable<Persona> GetAllCore();
    //protected abstract Persona GetCore();
    //protected abstract Persona GetPersonaByNameCore( string name );
}

