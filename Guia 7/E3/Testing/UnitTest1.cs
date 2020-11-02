using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        Batman batman;
        Extraterrestres extra;
        GuanteBlanco blanco;
        GuanteMarron marron;
        Psicopatas psicopatas;
        RobinHood  robin;
        Gotica gotica;
        List<Habitantes> personas;
        List<Villanos> villanos;
        List<BatiRiñonera> tecnologia;
        BatiRiñonera soplete;
        BatiRiñonera cinturon;
        BatiRiñonera puños;

        Habitantes h1;
        Habitantes h2;
        Habitantes h3;
        Habitantes h4;
        Habitantes h5;
        Habitantes h6;
        Habitantes h7;
        Habitantes h8;
        Habitantes h9;
        Habitantes h10;
        [SetUp]
        public void Setup()
        {
            soplete = new BatiRiñonera("Bati-Soplete", 30, 5);
            cinturon = new BatiRiñonera("Bati-Cinturon", 20, 15);
            puños = new BatiRiñonera("Bati-Puños", 55, 30);
            tecnologia = new List<BatiRiñonera>(){soplete, cinturon, puños};
            batman = new Batman(tecnologia);

            extra = new Extraterrestres(6, 3);
            blanco = new GuanteBlanco();
            marron = new GuanteMarron();
            psicopatas = new Psicopatas(10);
            robin = new RobinHood();

            villanos = new List<Villanos>(){extra, blanco, marron};

            h1 = new Habitantes(2000000);
            h2 = new Habitantes(50000);
            h3 = new Habitantes(6000000);
            h4 = new Habitantes(7000000);
            h5 = new Habitantes(7500000);
            h6 = new Habitantes(40000);
            h7 = new Habitantes(8000000);
            h8 = new Habitantes(10000000);
            h9 = new Habitantes(150000);
            h10 = new Habitantes(650000);

            personas = new List<Habitantes>(){h1, h2, h3, h4, h5, h6, h7, h8, h9, h10};

            gotica = new Gotica();

        }

        [Test]
        public void TestSaberSiBatamanEstaEstresado()
        {
            Assert.False(batman.estaEstresado());
        }
        [Test]
        public void TestBatmanCombateConUnVillanoYElQuedaInconciente()
        {
            batman.enCombateUnico(extra);
            Assert.AreEqual(extra.Estado, "Inconciente");
        }
        [Test]
        public void TestBatmanCombateConVillanosYEllosQuedanInconcientes()
        {
            batman.enCombate(villanos);
            Assert.IsTrue(villanos.All(v => v.Estado == "Inconciente"));
        }
        [Test]
        public void TestBatmanEstaAlaModa()
        {
            Assert.IsTrue(batman.estaAlaModa());
        }
        [Test]
        public void TestBatmanBailaTwistYGana100DeVitalidad()
        {
            batman.batiTwist();
            Assert.AreEqual(batman.vitalidad, 900);
        }
        [Test]
        public void TestUnGrupoDeVillanosAtacaAlaCiudadYFallan()
        {
            villanos.ForEach(v => v.maldad(personas));
            Assert.IsFalse(psicopatas.Asesinatos == 5 && personas.Count() == 5);
        }
        [Test]
        public void TestSaberSiLaCiudadEsLujosa()
        {
            Assert.IsTrue(gotica.esLujosa());
        }
        [Test]
        public void TestMostrarLosVillanosProfugos()
        {
            batman.enCombateUnico(psicopatas);
            batman.enCombateUnico(extra);
            villanos.Remove(psicopatas);
            villanos.Remove(extra);
            Assert.IsTrue(villanos.All(v => v.Estado == "Profugo"));
        }
    }
}