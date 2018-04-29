using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonaFusionApp.Data;


namespace PersonaFusionApp.Memory
{
    public class MemoryPersonaDatabase : PersonaDatabase
    {
        public MemoryPersonaDatabase()
        {
            _personas = new List<Persona>();
            new Persona() {
                Name = "Arsene", Recipe = "\n\nJack - o'-Lantern (2 / Magician) x Mandrake (3 / Death)\n\n" +
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
                                                          "Kodama(11 / Star) x Jack Frost(11 / Magician)"
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

        public IEnumerable<Persona> GetAll()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Persona> GetAllCore()
        {
            throw new NotImplementedException();
        }

        protected override Persona GetCore()
        {
            throw new NotImplementedException();
        }

        protected override Persona GetPersonaByNameCore( string name )
        {
            throw new NotImplementedException();
        }

        //public List<Persona> GetList { get; }

        private List<Persona> _personas = new List<Persona>();
    }
}

