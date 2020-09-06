using NUnit.Framework;
using Ejercisio;
using System.Collections.Generic;

namespace Testing
{
    public class Tests
    {
        private Arma bastonDeMetal;
        private Arma bombasDeHumo;

        Robin robin;
        Raven raven;
        ChicoBestia chicoBestia;

        [SetUp]
        public void Setup()
        {
            bastonDeMetal = new Arma (15, 30);
            bombasDeHumo = new Arma(14, 89);
            robin = new Robin(new List<Arma> {bastonDeMetal, bombasDeHumo}, 10);
            raven = new Raven(2);
            chicoBestia = new ChicoBestia(2);
        }

        [Test]
        public void TestDeCalculoFibonacciDelBastonDeMetalEs610()
        {
            Assert.AreEqual(610, bastonDeMetal, fibonacci());
        }

        [Test]
        public void TestRobinLlora2VecesPorRobocopYSuPoderEsDe589()
        {
            robin.LlorarPorRobocop();
            robin.LlorarPorRobocop();
            Assert.AreEqual(598, robin.Poder());
        }
        [Test]
        public void TestHacerQueRavenComa4PorcionesDePizzaYSaberSiEstaTriste()
        {
            raven.comerPizza();
            raven.comerPizza();
            raven.comerPizza();
            raven.comerPizza();
            Assert.AreEqual(true, raven.estaTriste());
        }
        [Test]
        public void TestHacerQueChicoBestiaComaPizzaYConocerSuPoder()
        {
            chicoBestia.comerPizza();
            Assert.AreEqual(871, chicoBestia.Poder());
        }
        [Test]
        public void TestHacerQueChicoBestiaComaPizzaYSaberSiElPoderDeRavenEsMayorAlDeLosTitanes()
        {
            chicoBestia.comerPizza();
            bool Poderosa = false;
            if(raven.Poder() > chicoBestia.Poder() && raven.Poder() > robin.Poder())
            {
                Poderosa = true;
            }
            Assert.AreEqual(false, Poderosa);
        }
        [Test]
        public void TestHacerQueChicoBestiaLlorePorRobocopYConocerSuNivelDeTristeza()
        {
            chicoBestia.LlorarPorRobocop();
            Assert.AreEqual(0, chicoBestia.NivelDeTristeza());
        }
        [Test]
        public void TestHacerQueChicoRavenLlorePorRobocopYSaberSiEstaTriste()
        {
            raven.LlorarPorRobocop();
            Assert.AreEqual(false, raven.estaTriste());
        }
    }
}