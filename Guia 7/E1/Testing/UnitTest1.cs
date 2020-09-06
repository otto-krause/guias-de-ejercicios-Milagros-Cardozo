using System.Collections.Generic;
using NUnit.Framework;
using Ejercicio;

namespace Testing
{
    public class Tests
    {
        SpiderGwen gwen;
        SpidermanNoir noir;
        MilesMorales miles;
        PeterParker peter;
        KingPin kingPin;
        Armas pistola;
        Armas metralleta;
        List<Armas> armas;
        List<Spidermans> arañas;
        SpiderTeam spiderTeam;

        [SetUp]
        public void Setup()
        {
            pistola = new Armas("calibre 38", 10);
            metralleta = new Armas("ar 15", 50);
            armas = new List<Armas>{pistola, metralleta};

            gwen = new SpiderGwen(20, 0 , 10);
            miles = new MilesMorales(20, 0, 5);
            peter = new PeterParker(20, 10);
            noir = new SpidermanNoir(20, 15, armas);
            kingPin = new KingPin(800);
            arañas = new List<Spidermans> {gwen, miles, peter, noir};
            spiderTeam = new SpiderTeam(arañas, kingPin);
        }

        [Test]
        public void TestSaberElPoderDelSpiderTeamEs80()
        {
            Assert.AreEqual(80, spiderTeam.fuerzaDelSpiderTeam());
        }
        [Test]
        public void TestSaberLaVidaDeKingpin()
        {
            Assert.AreEqual(800, kingPin.puntosDeVida);
        }
        [Test]
        public void TestSaberElPoderDeMilesMorales()
        {
            Assert.AreEqual(25, miles.CalcularPoder());
        }
        [Test]
        public void TestSaberElPoderDePeterParker()
        {
            Assert.AreEqual(30, peter.CalcularPoder());
        }
        [Test]
        public void TestKingPinEsVencido()
        {
            spiderTeam.pelearConKingpin();
            spiderTeam.pelearConKingpin();
            spiderTeam.pelearConKingpin();
            spiderTeam.pelearConKingpin();
            spiderTeam.pelearConKingpin();
            spiderTeam.pelearConKingpin();
            spiderTeam.pelearConKingpin();
            spiderTeam.pelearConKingpin();
            Assert.IsTrue(kingPin.fueVencido());
        }
        [Test]
        public void TestSaberElPoderDeSpiderGwen()
        {
            Assert.AreEqual(30, gwen.CalcularPoder());
        }
        [Test]
        public void TestSaberElPoderDeSpidermanNoir()
        {
            Assert.AreEqual(37, noir.CalcularPoder());
        }
    }
}