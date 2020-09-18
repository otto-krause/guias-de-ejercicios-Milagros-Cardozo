using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace tests
{
    public class Tests
    {
        Niños maria;
        Niños juan;
        Niños tomas;
        Niños camila;
        List<Niños> niños;
        Comun carlos;
        Abuelo mabel;
        Necios juana;
        LegionesDeLegiones legiones;
        Legion legion;
        List<LegionDeTerror> miembros;
        Maquillaje maquillaje;
        Terrorificos terrorificos;
        Tiernos tiernos;

        [SetUp]
        public void Setup()
        {
            carlos = new Comun();
            mabel = new Abuelo(50);
            juana = new Necios();

            maquillaje = new Maquillaje();
            tiernos = new Tiernos();
            terrorificos = new Terrorificos();

            maria = new Niños(maquillaje, tiernos, 4, 16);
            juan = new Niños(maquillaje, tiernos, 6, 3);
            tomas = new Niños(maquillaje, terrorificos, 2, 14);
            camila = new Niños(maquillaje, terrorificos, 4, 5);

            niños = new List<Niños>();
            niños.Add(maria);
            niños.Add(juan);
            niños.Add(tomas);
            niños.Add(camila);

            miembros = new List<LegionDeTerror>{maria, juan, camila};

            legion = new Legion(niños);
            legiones = new LegionesDeLegiones(new List<LegionDeTerror>(){legion, tomas});

            miembros.Add(tomas);
        }

        [Test]
        public void TestSaberLaCapacidadDeAsustarDeCamilaEs32()
        {
            Assert.AreEqual(32, camila.CapacidadParaAsustar);
        }
        
        [Test]
        public void TestHacerQueMariaYTomasAsustanAUnAdultoComunPeroTomasNoRecibeCaramelos()
        {
            maria.Asustarlos(carlos);
            maria.Asustarlos(carlos);
            tomas.Asustarlos(carlos);
            Assert.AreEqual(14, tomas.Caramelos);
        }
        [Test]
        public void TestCamilaAsustaAUnAbueloYleDaCaramelos()
        {
            maria.Asustarlos(mabel);
            maria.Asustarlos(mabel);
            camila.Asustarlos(mabel);
            Assert.AreEqual(17, camila.Caramelos);
        }
        [Test]
        public void TestJuanAsustoAUnNecioPeroAunSigueCon3Caramelos()
        {
            juan.Asustarlos(juana);
            Assert.AreEqual(3, juan.Caramelos);
        }




        [Test]
        public void TestLaLegionTiraErrorSiTieneMenosDeDosNiños()
        {
            Assert.Throws<System.Exception>(() => new Legion(new List<Niños>(){maria}));
        }
        [Test]
        public void TestElLiderDeLaLegionEsCamila()
        {
            Assert.AreEqual(camila, legion.Lider);
        }
        [Test]
        public void TestLaCapacidadParaAsustarDeLaLegionEs114()
        {
            Assert.AreEqual(114, legiones.CapacidadParaAsustar);
        }
        [Test]
        public void TestElTotalDeCaramelosEsDe24()
        {
            Assert.AreEqual(38, legion.Caramelos);
        }
        [Test]
        public void TestLaLegionAsustaAUnAdultoComunYReciben10Caramelos()
        {
            legion.Asustarlos(carlos);
            legion.Asustarlos(carlos);
            Assert.AreEqual(38, legion.Caramelos);
        }
        [Test]
        public void TestLaLegionAsustaAUnAdultoNecioPeroSiguenConLosCaramelosAnteriores()
        {
            legion.Asustarlos(carlos);
            Assert.AreEqual(38, legion.Caramelos);
        }




        [Test]
        public void TestElLiderDeLegionesEsLegion()
        {
            Assert.AreEqual(legion, legiones.Lider);
        }
        [Test]
        public void TestLaCapacidadParaAsustarDeLegionesEsDe114()
        {
            Assert.AreEqual(114, legiones.CapacidadParaAsustar);
        }
        [Test]
        public void TestElTotalDeCaramelosDeLegionesEsDe38()
        {
            Assert.AreEqual(52, legiones.Caramelos);
        }
        [Test]
        public void TestLegionesAsustanAUnAbueloYTienen39Caramelos()
        {
            legiones.Asustarlos(mabel);
            Assert.AreEqual(64, legiones.Caramelos);
        }




        [Test]
        public void TestTresNiñosConMasCaramelosYelPrimeroEsMaria()
        {
            Assert.AreEqual(maria, miembros.OrderByDescending(m => m.Caramelos).First());
        }
        [Test]
        public void TestTresNiñosConMasCaramelosYelSegundoEsTomas()
        {
            Assert.AreEqual(tomas, miembros.OrderByDescending(m => m.Caramelos).Take(2).Last());
        }
        [Test]
        public void TestTresNiñosConMasCaramelosYelTerceroEsCamila()
        {
            Assert.AreEqual(camila, miembros.OrderByDescending(m => m.Caramelos).Take(3).Last());
        }



        [Test]
        public void TestJuanComioTodosSusDulces()
        {
            juan.Alimentarse(3);
            Assert.AreEqual(0, juan.Caramelos);
        }
        [Test]
        public void TestMariaComeMasDe10CaramelosYQueSeEmpache()
        {
            maria.Alimentarse(11);
            Assert.AreEqual("empachado", maria.SaludNiños);
        }
        [Test]
        public void TestMariaComeMasDe10CaramelosYQueSuActitudEstePorLaMitad()
        {
            maria.Alimentarse(11);
            Assert.AreEqual(2, maria.ActitudDelNiño);
        }
        [Test]
        public void TestTomasComa10CaramelosYSeQuedeEnCama()
        {
            tomas.Alimentarse(10);
            Assert.AreEqual("en cama", tomas.SaludNiños);
        }
        [Test]
        public void TestTomasComa10CaramelosYSuActitudSea0()
        {
            tomas.Alimentarse(10);
            Assert.AreEqual(0, tomas.ActitudDelNiño);
        }
    }
}