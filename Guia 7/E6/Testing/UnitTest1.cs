using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        Heroe endeavor;
        Heroe hawks;
        Heroe oruMaito;
        Heroe arturoMidorilla;
        Quirks hellFlame;
        Quirks alasRigidas;
        Villano twice;
        Villano dabi;
        Villano stain;
        Quirks duplicacion;
        Quirks cremacion;
        Quirks coaguloDeSangre;
        List<Villano> pandill;
        Pandilla pandilla;
        Quirks OFA;
        [SetUp]
        public void Setup()
        {
            hellFlame = new Quirks("Hell Flame", 5000, false);
            alasRigidas = new Quirks("Alas Rigidas", 180, true);
            duplicacion = new Quirks("Duplicacion", 15, false);
            cremacion = new Quirks("Cremmacion", 360, false);
            coaguloDeSangre = new Quirks("CoaguloDesangre", 80, false);
            OFA = new Quirks("One For All", 120, false);

            endeavor = new Heroe(hellFlame);
            hawks = new Heroe(alasRigidas);
            arturoMidorilla = new Heroe(OFA);
            oruMaito = new Heroe(OFA);

            twice = new Villano(true, true, false, duplicacion);
            dabi = new Villano(true, false, true, cremacion);
            stain = new Villano(true, false, true, coaguloDeSangre);

            pandill = new List<Villano>{twice, dabi};
            pandilla = new Pandilla(pandill);
        }

        [Test]
        public void TestSaberSiElQuirkDeEndeavorEsPeligroso()
        {
            Assert.IsTrue(endeavor.esPeligroso());
        }
        [Test]
        public void TestSaberSiTwiceEsPeligroso()
        {
            Assert.IsFalse(twice.esPeligroso());
        }
        [Test]
        public void TestSaberSiStainFueAlgunaVezBueno()
        {
            Assert.IsFalse(stain.algunaVezFueBueno());
        }
        [Test]
        public void TestHacerQueHawksPeleeContraTwiceYGane()
        {
            hawks.pelearContraUnVillano(twice);
            Assert.AreEqual(1, hawks.CantVictorias);
        }
        [Test]
        public void TestHacerQueEndeavorPeleeContraUnaPandillaYGane()
        {
            endeavor.pelearContraUnaPandilla(pandilla);
            Assert.AreEqual(2, endeavor.CantVictorias);
        }
        [Test]
        public void TestHacerQueHawksPeleeContraUnaPandillaYLeQuitenSuLicenciaDeHeroe()
        {
            hawks.pelearContraUnaPandilla(pandilla);
            Assert.AreEqual("Acta de Difusion", hawks.Licencia);
        }
        [Test]
        public void TestHacerQueOruMaitoLePaseSuQuirkAArturoMidorilla()
        {
            OneForAll ofa = new OneForAll(oruMaito);
            ofa.cambiarDeDueño(arturoMidorilla);
            Assert.AreEqual(ofa.Dueño, arturoMidorilla);
        }
    }
}