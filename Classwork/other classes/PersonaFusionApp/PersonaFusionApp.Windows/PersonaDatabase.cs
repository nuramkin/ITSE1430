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
                    Recipe = "\n\nOrpheus Picaro(29 / Fool) x Queen's Necklace (15 / Empress)\n\n" +
                                 "Orpheus Picaro(29 / Fool) x Koh - i - Noor(25 / Priestess)\n\n" +
                                 "Legion(38 / Fool) x Regent(10 / Emperor)\n\n" +
                                 "Principality(29 / Justice) x Pisaca(29 / Death)\n\n" +
                                 "Mithra(33 / Temperance) x Flauros(25 / Devil)\n\n" +
                                 "Zouchouten(31 / Strength) x Choronzon(28 / Magician)\n\n" +
                                 "Ara Mitama(31 / Chariot) x Take - Minakata(29 / Hanged Man)\n\n" +
                                 "Legion(38 / Fool) x Stone of Scone(20 / Fortune)\n\n" +
                                 "Lilim(32 / Devil)  Principality(29 / Justice)\n\n" +
                                 "Unicorn(39 / Hierophant) x Oni(19 / Strength)\n\n" +
                                 "Unicorn(39 / Hierophant) x Yaksini(20 / Empress)\n\n" +
                                 "Hell Biker(39 / Death) x Yaksini(20 / Empress)\n\n" +
                                 "Anubis(37 / Judgement) x Sui - Ki(24 / Moon)\n\n" +
                                 "Hariti(40 / Empress) x Matador(19 / Death)\n\n" +
                                 "White Rider(39 / Chariot) x Orthrus(21 / Hanged Man)\n\n" +
                                 "Anubis(37 / Judgement) x Kaguya Picaro(25 / Moon)\n\n" +
                                 "Kushinada - Hime(42 / Lovers) x Eligor(16 / Emperor)\n\n" +
                                 "Hecatoncheires(42 / Hanged Man) x Shiisaa(16 / Chariot)\n\n" +
                                 "Power(41 / Justice) x Matador(19 / Death)\n\n" +
                                 "Pazuzu(43 / Devil) x Makami(15 / Temperance)\n\n"});

                _personas.Add(new Persona() { Name = "Legion", Pic = Properties.Resources.Legion,
                    Recipe = "\n\nDecarabia(32 / Fool) x Queen's Necklace (15 / Empress)\n\n" +
                                 "Decarabia(32 / Fool) x Koh - i - Noor(25 / Priestess)\n\n" +
                                 "Ose(42 / Fool) x Regent(10 / Emperor)\n\n" +
                                 "Mithra(33 / Temperance) x Lilim(32 / Devil)\n\n" +
                                 "Thoth(36 / Emperor) x Ame - no - Uzume(29 / Lovers)\n\n" +
                                 "Ose(42 / Fool) x Stone of Scone(20 / Fortune)\n\n" +
                                 "Unicorn(39 / Hierophant) x Lamia(26 / Empress)\n\n" +
                                 "Hell Biker(39 / Death) x Lamia(26 / Empress)\n\n" +
                                 "Anubis(37 / Judgement) x Black Ooze(29 / Moon)\n\n" +
                                 "Hariti(40 / Empress) x Anzu(25 / Hierophant)\n\n" +
                                 "Power(41 / Justice) x Flauros(25 / Devil)\n\n" +
                                 "Daisoujou(42 / Hierophant) x Rakshasa(24 / Strength)\n\n" +
                                 "White Rider(39 / Chariot) x Take - Minakata(29 / Hanged Man)\n\n" +
                                 "Hell Biker(39 / Death) x Principality(29 / Justice)\n\n" +
                                 "Hecatoncheires(42 / Hanged Man) x Kin - Ki(25 / Chariot)\n\n" +
                                 "Valkyrie(44 / Strength) x Phoenix(22 / Hierophant)\n\n" +
                                 "Queen Mab(43 / Magician) x Rakshasa(24 / Strength)\n\n" +
                                 "Daisoujou(42 / Hierophant) x Lamia(26 / Empress)\n\n" +
                                 "Hariti(40 / Empress) x Pisaca(29 / Death)\n\n" +
                                 "Anubis(37 / Judgement) x Mothman(33 / Moon)\n\n"});

                _personas.Add(new Persona() { Name = "Ose", Pic = Properties.Resources.Ose,
                    Recipe = "\n\nLegion(38 / Fool) x Queen's Necklace (15 / Empress)\n\n" +
                                 "Legion(38 / Fool) x Koh - i - Noor(25 / Priestess)\n\n" +
                                 "Bugs(49 / Fool) x Regent(10 / Emperor)\n\n" +
                                 "Crystal Skull(50 / Fool) x Regent(10 / Emperor)\n\n" +
                                 "Bugs(49 / Fool) x Stone of Scone(20 / Fortune)\n\n" +
                                 "Crystal Skull(50 / Fool) x Stone of Scone(20 / Fortune)\n\n" +
                                 "Pazuzu(43 / Devil) x Mithra(33 / Temperance)\n\n" +
                                 "Hope Diamond(40 / Death) x Legion(38 / Fool)\n\n" +
                                 "Kushinada - Hime(42 / Lovers) x Thoth(36 / Emperor)\n\n" +
                                 "Hariti(40 / Empress) x Unicorn(39 / Hierophant)\n\n" +
                                 "Hariti(40 / Empress) x Hell Biker(39 / Death)\n\n" +
                                 "Power(41 / Justice) x Hell Biker(39 / Death)\n\n" +
                                 "Rangda(48 / Magician) x Zouchouten(31 / Strength)\n\n" +
                                 "Narcissus(50 / Lovers) x Setanta(28 / Emperor)\n\n" +
                                 "Hecatoncheires(42 / Hanged Man) x White Rider(39 / Chariot)\n\n" +
                                 "Bugs(49 / Fool) x Orlov(30 / Strength)\n\n" +
                                 "Girimehkala(44 / Moon) x Anubis(37 / Judgement)\n\n" +
                                 "Dakini(50 / Empress) x Pisaca(29 / Death)\n\n" +
                                 "Daisoujou(42 / Hierophant) x Hariti(40 / Empress)\n\n" +
                                 "Crystal Skull(50 / Fool) x Orlov(30 / Strength)\n\n"});

                _personas.Add(new Persona() { Name = "Bugs", Pic = Properties.Resources.Bugs,
                    Recipe = "\n\nSpecial Fusion:\nHariti (40 / Empress) x Pisaca (29 / Death) x Pixie (2 / Lovers)\n\n"});

                _personas.Add(new Persona() { Name = "Dionysus", Pic = Properties.Resources.Dionysus,
                    Recipe = "\n\nCrystal Skull(50 / Fool) x Queen's Necklace (15 / Empress)\n\n" +
                                 "Crystal Skull(50 / Fool) x Koh-i-Noor(25 / Priestess)\n\n" +
                                 "Pazuzu(43 / Devil) x Power(41 / Justice)\n\n" +
                                 "Okuninushi(44 / Emperor) x Kushinada - Hime(42 / Lovers)\n\n" +
                                 "Valkyrie(44 / Strength) x Daisoujou(42 / Hierophant)\n\n" +
                                 "Valkyrie(44 / Strength) x Queen Mab(43 / Magician)\n\n" +
                                 "Narcissus(50 / Lovers) x Thoth(36 / Emperor)\n\n" +
                                 "Cerberus(55 / Chariot) x Take - Minakata(29 / Hanged Man)\n\n" +
                                 "Tsukiyomi(50 / Moon) x Anubis(37 / Judgement)\n\n" +
                                 "Parvati(56 / Lovers) x Setanta(28 / Emperor)\n\n" +
                                 "Titania(56 / Empress) x Pisaca(29 / Death)\n\n" +
                                 "Dakini(50 / Empress) x Unicorn(39 / Hierophant)\n\n" +
                                 "Dakini(50 / Empress) x Hell Biker(39 / Death)\n\n" +
                                 "Raja Naga(55 / Temperance) x Lilim(32 / Devil)\n\n" +
                                 "Trumpeter(59 / Judgement) x Kaguya Picaro(25 / Moon)\n\n" +
                                 "Crystal Skull(50 / Fool) x Hope Diamond(40 / Death)\n\n" +
                                 "Baphomet(58 / Devil) x Principality(29 / Justice)\n\n" +
                                 "Moloch(60 / Hanged Man) x Kin-Ki(25 / Chariot)\n\n" +
                                 "Melchizedek(60 / Justice) x Flauros(25 / Devil)\n\n" +
                                 "Rangda(48 / Magician) x Valkyrie(44 / Strength)\n\n"});

                _personas.Add(new Persona() { Name = "Black Frost", Pic = Properties.Resources.BlackFrost,
                    Recipe = "\n\nSpecial Fusion:\nKing Frost (61 / Emperor) x Jack Frost (11 / Magician)" +
                    "\nx Jack-o'-Lantern (2 / Magician)\n\n"});

                _personas.Add(new Persona() { Name = "Vishnu", Pic = Properties.Resources.Vishnu,
                    Recipe = "\n\nDionysus(61 / Fool) x Queen's Necklace (15 / Empress)\n\n" +
                                 "Dionysus(61 / Fool) x Koh - i - Noor(25 / Priestess)\n\n" +
                                 "Black Frost(67 / Fool) x Queen's Necklace (15 / Empress)\n\n" +
                                 "Black Frost(67 / Fool) x Koh - i - Noor(25 / Priestess)\n\n" +
                                 "Dionysus(61 / Fool) x Hope Diamond(40 / Death)\n\n" +
                                 "Black Frost(67 / Fool) x Hope Diamond(40 / Death)\n\n" +
                                 "Dionysus(61 / Fool) x Crystal Skull(50 / Fool)\n\n" +
                                 "Chernobog(62 / Death) x Melchizedek(60 / Justice)\n\n" +
                                 "Nebiros(62 / Devil) x Melchizedek(60 / Justice)\n\n" +
                                 "Oberon(66 / Emperor) x Parvati(56 / Lovers)\n\n" +
                                 "Bishamonten(67 / Hierophant) x Titania(56 / Empress)\n\n" +
                                 "Vasuki(68 / Hanged Man) x Cerberus(55 / Chariot)\n\n" +
                                 "Belial(68 / Devil) x Raja Naga(55 / Temperance)\n\n" +
                                 "Mot(72 / Death) x Dakini(50 / Empress)\n\n" +
                                 "Seiryu(62 / Temperance) x Nebiros(62 / Devil)\n\n" +
                                 "Thor(64 / Chariot) x Moloch(60 / Hanged Man)\n\n" +
                                 "Yamata - no - Orochi(64 / Judgement) x Lilith(60 / Moon)\n\n" +
                                 "Thanatos(65 / Death) x Melchizedek(60 / Justice)\n\n" +
                                 "Throne(71 / Justice) x Pale Rider(53 / Death)\n\n" +
                                 "Thanatos Picaro(69 / Death) x Titania(56 / Empress)\n\n"});

                _personas.Add(new Persona() { Name = "Jack-o'-Lantern", Pic = Properties.Resources.PyroJack,
                    Recipe = "\n\nQueen's Necklace (15 / Empress) x Jack Frost (11 / Magician)\n\n" +
                                 "Nekomata(17 / Magician) x Jack Frost(11 / Magician)\n\n" +
                                 "Koh - i - Noor(25 / Priestess) x Jack Frost(11 / Magician)\n\n"});

                _personas.Add(new Persona() { Name = "Jack Frost", Pic = Properties.Resources.Jack_Frost,
                    Recipe = "\n\nSilky(6 / Priestess) x Mandrake(3 / Death)\n\n" +
                                 "Succubus(7 / Moon) x Pixie(2 / Lovers)\n\n" +
                                 "Succubus(7 / Moon) x Saki Mitama(6 / Lovers)\n\n" +
                                 "Succubus(7 / Moon) x Kelpie(6 / Strength)\n\n" +
                                 "Regent(10 / Emperor) x Jack - o'-Lantern (2 / Magician)\n\n" +
                                 "Kodama(11 / Star) x Arsene(1 / Fool)\n\n" +
                                 "Berith(9 / Hierophant) x Silky(6 / Priestess)\n\n" +
                                 "Mokoi(9 / Death) x Silky(6 / Priestess)\n\n" +
                                 "Apsaras(11 / Priestess) x Mandrake(3 / Death)\n\n" +
                                 "Onmoraki(12 / Moon) x Pixie(2 / Lovers)\n\n" +
                                 "Angel(12 / Justice) x Bicorn(4 / Hermit)\n\n" +
                                 "Onmoraki(12 / Moon) x Saki Mitama(6 / Lovers)\n\n" +
                                 "Onmoraki(12 / Moon) x Kelpie(6 / Strength)\n\n" +
                                 "Kodama(11 / Star) x Obariyon(8 / Fool)\n\n" +
                                 "Apsaras(11 / Priestess) x Berith(9 / Hierophant)\n\n" +
                                 "Apsaras(11 / Priestess) x Mokoi(9 / Death)\n\n" +
                                 "Angel(12 / Justice) x Koropokkuru(9 / Hermit)\n\n" +
                                 "Kusi Mitama(14 / Strength) x Succubus(7 / Moon)\n\n" +
                                 "Kaguya(16 / Moon) x Pixie(2 / Lovers)\n\n" +
                                 "Archangel(16 / Justice) x Bicorn(4 / Hermit)\n\n"});

                _personas.Add(new Persona() { Name = "Nekomata", Pic = Properties.Resources.Nekomata,
                    Recipe = "\n\nJack Frost(11 / Magician) x Regent(10 / Emperor)\n\n" +
                                 "Kaguya(16 / Moon) x Saki Mitama(6 / Lovers)\n\n" +
                                 "Kaguya(16 / Moon) x Kelpie(6 / Strength)\n\n" +
                                 "Ippon - Datara(13 / Hermit) x Angel(12 / Justice)\n\n" +
                                 "Orobas(17 / Hierophant) x Silky(6 / Priestess)\n\n" +
                                 "Archangel(16 / Justice) x Koropokkuru(9 / Hermit)\n\n" +
                                 "Kusi Mitama(14 / Strength) x Onmoraki(12 / Moon)\n\n" +
                                 "High Pixie(16 / Fool) x Kodama(11 / Star)\n\n" +
                                 "Nue(20 / Moon) x Pixie(2 / Lovers)\n\n" +
                                 "Stone of Scone(20 / Fortune) x Jack - o'-Lantern (2 / Magician)\n\n" +
                                 "Matador(19 / Death) x Silky(6 / Priestess)\n\n" +
                                 "Leanan Sidhe(19 / Lovers) x Succubus(7 / Moon)\n\n" +
                                 "Oni(19 / Strength) x Succubus(7 / Moon)\n\n" +
                                 "Suzaku(19 / Sun) x Genbu(7 / Temperance)\n\n" +
                                 "Orobas(17 / Hierophant) x Apsaras(11 / Priestess)\n\n" +
                                 "Nue(20 / Moon) x Saki Mitama(6 / Lovers)\n\n" +
                                 "Nue(20 / Moon) x Kelpie(6 / Strength)\n\n" +
                                 "Archangel(16 / Justice) x Ippon - Datara(13 / Hermit)\n\n" +
                                 "Sudama(17 / Hermit) x Angel(12 / Justice)\n\n" +
                                 "Kaguya(16 / Moon) x Kusi Mitama(14 / Strength)\n\n"});
 
                _personas.Add(new Persona() { Name = "Sandman", Pic = Properties.Resources.Sandman,
                    Recipe = "\n\nNekomata(17 / Magician) x Regent(10 / Emperor)\n\n" +
                                 "Stone of Scone(20 / Fortune) x Jack Frost(11 / Magician)\n\n" +
                                 "Suzaku(19 / Sun) x Makami(15 / Temperance)\n\n" +
                                 "Nue(20 / Moon) x Kusi Mitama(14 / Strength)\n\n" +
                                 "Leanan Sidhe(19 / Lovers) x Kaguya(16 / Moon)\n\n" +
                                 "Oni(19 / Strength) x Kaguya(16 / Moon)\n\n" +
                                 "Izanagi Picaro(23 / Fool) x Kodama(11 / Star)\n\n" +
                                 "Naga(24 / Hermit) x Angel(12 / Justice)\n\n" +
                                 "Rakshasa(24 / Strength) x Onmoraki(12 / Moon)\n\n" +
                                 "Anzu(25 / Hierophant) x Apsaras(11 / Priestess)\n\n" +
                                 "Isis(26 / Priestess) x Berith(9 / Hierophant)\n\n" +
                                 "Isis(26 / Priestess) x Mokoi(9 / Death)\n\n" +
                                 "Nue(20 / Moon) x Leanan Sidhe(19 / Lovers)\n\n" +
                                 "Nue(20 / Moon) x Oni(19 / Strength)\n\n" +
                                 "Nigi Mitama(20 / Temperance) x Suzaku(19 / Sun)\n\n" +
                                 "Sui - Ki(24 / Moon) x Kusi Mitama(14 / Strength)\n\n" +
                                 "Fuu - Ki(23 / Star) x High Pixie(16 / Fool)\n\n" +
                                 "Orpheus(26 / Fool) x Kodama(11 / Star)\n\n" +
                                 "Clotho(26 / Fortune) x Apsaras(11 / Priestess)\n\n" +
                                 "Kaguya Picaro(25 / Moon) x Kusi Mitama(14 / Strength)\n\n"});
 
                _personas.Add(new Persona() { Name = "Choronzon", Pic = Properties.Resources.Choronzon,
                    Recipe = "\n\nSandman(24 / Magician) x Regent(10 / Emperor)\n\n" +
                                 "Stone of Scone(20 / Fortune) x Nekomata(17 / Magician)\n\n" +
                                 "Rakshasa(24 / Strength) x Sui - Ki(24 / Moon)\n\n" +
                                 "Isis(26 / Priestess) x Phoenix(22 / Hierophant)\n\n" +
                                 "Black Ooze(29 / Moon) x Leanan Sidhe(19 / Lovers)\n\n" +
                                 "Black Ooze(29 / Moon) x Oni(19 / Strength)\n\n" +
                                 "Kaguya Picaro(25 / Moon) x Rakshasa(24 / Strength)\n\n" +
                                 "Orpheus(26 / Fool) x Fuu - Ki(23 / Star)\n\n" +
                                 "Ame - no - Uzume(29 / Lovers) x Nue(20 / Moon)\n\n" +
                                 "Neko Shogun(30 / Star) x Izanagi(20 / Fool)\n\n" +
                                 "Isis(26 / Priestess) x Anzu(25 / Hierophant)\n\n" +
                                 "Isis(26 / Priestess) x Clotho(26 / Fortune)\n\n" +
                                 "Zouchouten(31 / Strength) x Nue(20 / Moon)\n\n" +
                                 "Orpheus Picaro(29 / Fool) x Fuu - Ki(23 / Star)\n\n" +
                                 "Ame - no - Uzume(29 / Lovers) x Sui - Ki(24 / Moon)\n\n" +
                                 "Principality(29 / Justice) x Naga(24 / Hermit)\n\n" +
                                 "Black Ooze(29 / Moon) x Rakshasa(24 / Strength)\n\n" +
                                 "Neko Shogun(30 / Star) x Izanagi Picaro(23 / Fool)\n\n" +
                                 "Mothman(33 / Moon) x Leanan Sidhe(19 / Lovers)\n\n" +
                                 "Mothman(33 / Moon) x Oni(19 / Strength)\n\n"});

                _personas.Add(new Persona() { Name = "Queen Mab", Pic = Properties.Resources.QueenMab,
                    Recipe = "\n\nChoronzon(28 / Magician) x Regent(10 / Emperor)\n\n" +
                                 "Sandman(24 / Magician) x Stone of Scone(20 / Fortune)\n\n" +
                                 "Neko Shogun(30 / Star) x Orpheus(26 / Fool)\n\n" +
                                 "Ariadne(30 / Fortune) x Isis(26 / Priestess)\n\n" +
                                 "Zouchouten(31 / Strength) x Kaguya Picaro(25 / Moon)\n\n" +
                                 "Jatayu(32 / Tower) x Flauros(25 / Devil)\n\n" +
                                 "Mothman(33 / Moon) x Rakshasa(24 / Strength)\n\n" +
                                 "Ame - no - Uzume(29 / Lovers) x Black Ooze(29 / Moon)\n\n" +
                                 "Orlov(30 / Strength) x Choronzon(28 / Magician)\n\n" +
                                 "Kaiwan(36 / Star) x Izanagi(20 / Fool)\n\n" +
                                 "Neko Shogun(30 / Star) x Orpheus Picaro(29 / Fool)\n\n" +
                                 "Zouchouten(31 / Strength) x Black Ooze(29 / Moon)\n\n" +
                                 "Kaiwan(36 / Star) x Izanagi Picaro(23 / Fool)\n\n" +
                                 "Lachesis(34 / Fortune) x Isis(26 / Priestess)\n\n" +
                                 "Kikuri - Hime(40 / Priestess) x Orobas(17 / Hierophant)\n\n" +
                                 "Mithras(39 / Sun) x Nigi Mitama(20 / Temperance)\n\n" +
                                 "Decarabia(32 / Fool) x Neko Shogun(30 / Star)\n\n" +
                                 "Mothman(33 / Moon) x Ame - no - Uzume(29 / Lovers)\n\n" +
                                 "Kikuri - Hime(40 / Priestess) x Matador(19 / Death)\n\n" +
                                 "Power(41 / Justice) x Sudama(17 / Hermit)\n\n"});

                _personas.Add(new Persona() { Name = "Rangda", Pic = Properties.Resources.Rangda,
                    Recipe = "\n\nChoronzon(28 / Magician) x Stone of Scone(20 / Fortune)\n\n" +
                                 "Queen Mab(43 / Magician) x Regent(10 / Emperor)\n\n" +
                                 "Queen Mab(43 / Magician) x Orlov(30 / Strength)\n\n" +
                                 "Queen Mab(43 / Magician) x Emperor's Amulet (35 / Hanged Man)\n\n" +
                                 "Queen Mab(43 / Magician) x Hope Diamond(40 / Death)\n\n" +
                                 "Surt(59 / Magician) x Queen's Necklace (15 / Empress)\n\n" +
                                 "Girimehkala(44 / Moon) x Kushinada - Hime(42 / Lovers)\n\n" +
                                 "Fortuna(46 / Fortune) x Kikuri - Hime(40 / Priestess)\n\n" +
                                 "Magatsu - Izanagi(44 / Tower) x Pazuzu(43 / Devil)\n\n" +
                                 "Scathach(45 / Priestess) x Daisoujou(42 / Hierophant)\n\n" +
                                 "Scathach(45 / Priestess) x Ariadne Picaro(42 / Fortune)\n\n" +
                                 "Valkyrie(44 / Strength) x Girimehkala(44 / Moon)\n\n" +
                                 "Ganesha(53 / Sun) x Mithra(33 / Temperance)\n\n" +
                                 "Byakko(49 / Temperance) x Mithras(39 / Sun)\n\n" +
                                 "Tsukiyomi Picaro(55 / Moon) x Zouchouten(31 / Strength)\n\n" +
                                 "Sarasvati(50 / Priestess) x Unicorn(39 / Hierophant)\n\n" +
                                 "Sarasvati(50 / Priestess) x Atropos(39 / Fortune)\n\n" +
                                 "Sarasvati(50 / Priestess) x Hell Biker(39 / Death)\n\n" +
                                 "Surt(59 / Magician) x Koh - i - Noor(25 / Priestess)\n\n" +
                                 "Koumokuten(49 / Hermit) x Power(41 / Justice)\n\n"});

                _personas.Add(new Persona() { Name = "Surt", Pic = Properties.Resources.Surt,
                    Recipe = "\n\nQueen Mab(43 / Magician) x Stone of Scone(20 / Fortune)\n\n" +
                                 "Rangda(48 / Magician) x Regent(10 / Emperor)\n\n" +
                                 "Rangda(48 / Magician) x Orlov(30 / Strength)\n\n" +
                                 "Rangda(48 / Magician) x Emperor's Amulet (35 / Hanged Man)\n\n" +
                                 "Rangda(48 / Magician) x Hope Diamond(40 / Death)\n\n" +
                                 "Sarasvati(50 / Priestess) x Fortuna(46 / Fortune)\n\n" +
                                 "Norn(52 / Fortune) x Scathach(45 / Priestess)\n\n" +
                                 "Asterius(56 / Fortune) x Kikuri - Hime(40 / Priestess)\n\n" +
                                 "Skadi(55 / Priestess) x Daisoujou(42 / Hierophant)\n\n" +
                                 "Skadi(55 / Priestess) x Ariadne Picaro(42 / Fortune)\n\n" +
                                 "Tsukiyomi Picaro(55 / Moon) x Kushinada - Hime(42 / Lovers)\n\n" +
                                 "Raja Naga(55 / Temperance) x Yurlungur(42 / Sun)\n\n" +
                                 "Byakko(49 / Temperance) x Horus(49 / Sun)\n\n" +
                                 "Crystal Skull(50 / Fool) x Rangda(48 / Magician)\n\n" +
                                 "Kurama Tengu(56 / Hermit) x Power(41 / Justice)\n\n" +
                                 "Pale Rider(53 / Death) x Scathach(45 / Priestess)\n\n" +
                                 "Tsukiyomi Picaro(55 / Moon) x Valkyrie(44 / Strength)\n\n" +
                                 "Narcissus(50 / Lovers) x Tsukiyomi(50 / Moon)\n\n" +
                                 "Dionysus(61 / Fool) x Kaiwan(36 / Star)\n\n" +
                                 "Quetzalcoatl(63 / Sun) x Mithra(33 / Temperance)\n\n"});

                _personas.Add(new Persona() { Name = "Futsunushi", Pic = Properties.Resources.futsunushi,
                    Recipe = "\n\nRangda(48 / Magician) x Stone of Scone(20 / Fortune)\n\n" +
                                 "Surt(59 / Magician) x Regent(10 / Emperor)\n\n" +
                                 "Surt(59 / Magician) x Orlov(30 / Strength)\n\n" +
                                 "Surt(59 / Magician) x Emperor's Amulet (35 / Hanged Man)\n\n" +
                                 "Surt(59 / Magician) x Hope Diamond(40 / Death)\n\n" +
                                 "Surt(59 / Magician) x Crystal Skull(50 / Fool)\n\n" +
                                 "Forneus(63 / Hierophant) x Skadi(55 / Priestess)\n\n" +
                                 "Quetzalcoatl(63 / Sun) x Raja Naga(55 / Temperance)\n\n" +
                                 "Seiryu(62 / Temperance) x Yatagarasu(57 / Sun)\n\n" +
                                 "Black Frost(67 / Fool) x Garuda(52 / Star)\n\n" +
                                 "Belial(68 / Devil) x Seth(51 / Tower)\n\n" +
                                 "Thanatos(65 / Death) x Skadi(55 / Priestess)\n\n" +
                                 "Lakshmi(69 / Fortune) x Sarasvati(50 / Priestess)\n\n" +
                                 "Thanatos Picaro(69 / Death) x Sarasvati(50 / Priestess)\n\n" +
                                 "Siegfried(69 / Strength) x Tsukiyomi(50 / Moon)\n\n" +
                                 "Nebiros(62 / Devil) x Black Rider(59 / Tower)\n\n" +
                                 "Cybele(73 / Priestess) x Fortuna(46 / Fortune)\n\n" +
                                 "Throne(71 / Justice) x Koumokuten(49 / Hermit)\n\n" +
                                 "Bishamonten(67 / Hierophant) x Skadi(55 / Priestess)\n\n" +
                                 "Sandalphon(75 / Moon) x Valkyrie(44 / Strength)\n\n"});

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

