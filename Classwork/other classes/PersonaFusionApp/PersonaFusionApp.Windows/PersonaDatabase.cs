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
                    Recipe = "\n\nKelpie(6 / Strength) x Jack - o'-Lantern (2 / Magician)\n\n" +
                                 "Genbu(7 / Temperance) x Incubus(5 / Devil)\n\n" +
                                 "Hua Po(9 / Hanged Man) x Agathion(3 / Chariot)\n\n" +
                                 "Berith(9 / Hierophant) x Kelpie(6 / Strength)\n\n" +
                                 "Angel(12 / Justice) x Mandrake(3 / Death)\n\n" +
                                 "Queen's Necklace (15 / Empress) x	Arsene (1 / Fool)\n\n" +
                                 "High Pixie(16 / Fool) x Arsene(1 / Fool)\n\n" +
                                 "High Pixie(16 / Fool) x Regent(10 / Emperor)\n\n" +
                                 "Izanagi(20 / Fool) x Arsene(1 / Fool)\n\n" +
                                 "Izanagi Picaro(23 / Fool) x Arsene(1 / Fool)\n\n" +
                                 "Koh - i - Noor(25 / Priestess) x Arsene(1 / Fool)\n\n" +
                                 "Orpheus(26 / Fool) x Arsene(1 / Fool)\n\n" +
                                 "Izanagi(20 / Fool) x High Pixie(16 / Fool)\n\n" +
                                 "Stone of Scone(20 / Fortune) x High Pixie(16 / Fool)\n\n" +
                                 "Orlov(30 / Strength) x High Pixie(16 / Fool)\n\n" +
                                 "Emperor's Amulet (35 / Hanged Man) x High Pixie (16 / Fool)\n\n" +
                                 "Hope Diamond(40 / Death) x Arsene(1 / Fool)\n\n" });
                            
                _personas.Add(new Persona() { Name = "High Pixie", Pic = Properties.Resources.HighPixie,
                    Recipe = "\n\nKoppa Tengu(11 / Temperance) 	Incubus(5 / Devil)\n\n" +
                                 "Andras(10 / Devil) x Genbu(7 / Temperance)\n\n" +
                                 "Jack Frost(11 / Magician) x Kelpie(6 / Strength)\n\n" +
                                 "Angel(12 / Justice) x Incubus(5 / Devil)\n\n" +
                                 "Slime(10 / Chariot) x Hua Po(9 / Hanged Man)\n\n" +
                                 "Kusi Mitama(14 / Strength) x Jack - o'-Lantern (2 / Magician)\n\n" +
                                 "Inugami(14 / Hanged Man) x Agathion(3 / Chariot)\n\n" +
                                 "Koppa Tengu(11 / Temperance) x Andras(10 / Devil)\n\n" +
                                 "Angel(12 / Justice) x Mokoi(9 / Death)\n\n" +
                                 "Makami(15 / Temperance) x Incubus(5 / Devil)\n\n" +
                                 "Eligor(16 / Emperor) x Pixie(2 / Lovers)\n\n" +
                                 "Angel(12 / Justice) x Andras(10 / Devil)\n\n" +
                                 "Archangel(16 / Justice) x Mandrake(3 / Death)\n\n" +
                                 "Archangel(16 / Justice) x Incubus(5 / Devil)\n\n" +
                                 "Kusi Mitama(14 / Strength) x Berith(9 / Hierophant)\n\n" +
                                 "Eligor(16 / Emperor) x Saki Mitama(6 / Lovers)\n\n" +
                                 "Queen's Necklace (15 / Empress) x Obariyon (8 / Fool)\n\n" +
                                 "Inugami(14 / Hanged Man) x Slime(10 / Chariot)\n\n" +
                                 "Nekomata(17 / Magician) x Kelpie(6 / Strength)\n\n" +
                                 "Orobas(17 / Hierophant) x Kelpie(6 / Strength)\n\n"});

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

                _personas.Add(new Persona() { Name = "Jack-o'-Lantern", Pic = Properties.Resources.PyroJack,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Jack Frost", Pic = Properties.Resources.Jack_Frost,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Nekomata", Pic = Properties.Resources.Nekomata,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Sandman", Pic = Properties.Resources.Sandman,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Choronzon", Pic = Properties.Resources.Choronzon,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Queen Mab", Pic = Properties.Resources.QueenMab,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Rangda", Pic = Properties.Resources.Rangda,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Surt", Pic = Properties.Resources.Surt,
                    Recipe = "" });

                _personas.Add(new Persona() { Name = "Futsunushi", Pic = Properties.Resources.futsunushi,
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

