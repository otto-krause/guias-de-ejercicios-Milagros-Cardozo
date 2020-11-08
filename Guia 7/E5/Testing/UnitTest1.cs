using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using Ejercicio;

namespace Testing
{
    public class Tests
    {
        Heroes endeavor;
        Heroes hawks;
        Quirks hellFlame;
        Quirks alasRigidas;
        Villanos twice;
        Villanos dabi;
        Villanos stain;
        Quirks duplicacion;
        Quirks cremacion;
        Quirks coaguloDeSangre;
        List<Villanos> pandill;
        Pandilla pandilla;
        [SetUp]
        public void Setup()
        {
            hellFlame = new Quirks("Hell Flame", 5000, false);
            alasRigidas = new Quirks("Alas Rigidas", 180, true);
            duplicacion = new Quirks("Duplicacion", 15, false);
            cremacion = new Quirks("Cremmacion", 360, false);
            coaguloDeSangre = new Quirks("CoaguloDesangre", 80, false);

            endeavor = new Heroes(hellFlame);
            hawks = new Heroes(alasRigidas);

            twice = new Villanos(true, true, false, duplicacion);
            dabi = new Villanos(true, false, true, cremacion);
            stain = new Villanos(true, false, true, coaguloDeSangre);

            pandill = new List<Villanos>{twice, dabi};
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
            Assert.AreEqual(1, endeavor.CantVictorias);
        }
        [Test]
        public void TestHacerQueHawksPeleeContraUnaPandillaYLeQuitenSuLicenciaDeHeroe()
        {
            hawks.pelearContraUnaPandilla(pandilla);
            Assert.AreEqual("Acta de Difusion", hawks.Licencia);
        }
    }
}