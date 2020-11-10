using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using Ejercicio;

namespace Testing
{
    public class Tests
    {
        Villanos gru;
        Minions bob;
        Minions kevin;
        Minions stuart;
        Ciudad ciudad;
        Armas torpedo;
        Armas rayoCongelante;
        Armas desinflaInador;
        List<string> objetos;
        List<Armas> armas;
        List<Minions> minions;

        [SetUp]
        public void Setup()
        {
            rayoCongelante = new Armas("Rayo congelante", 100);
            torpedo = new Armas("Torpedo", 250);
            desinflaInador = new Armas("Desinfla-Inador", 150);

            objetos = new List<string>{"Piramide", "Suero mutante", "La luna"};

            ciudad = new Ciudad(300, objetos, 150);

            armas = new List<Armas>{rayoCongelante, torpedo, desinflaInador};

            bob = new Minions("Amarillo", 350, torpedo);
            kevin = new Minions("Amarillo", 150, rayoCongelante);
            stuart = new Minions("Violeta", 400, desinflaInador);

            minions = new List<Minions>{bob, kevin, stuart};

            gru = new Villanos(minions, ciudad);
        }

        [Test]
        public void TestDevovlerElNivelDeConcentracionDeBob()
        {
            Assert.AreEqual(600 ,bob.nivelDeConcentracion());
        }
        [Test]
        public void TestGruOtorgaDosArmasYdaDeAlimentarYSaberSiKevinTieneUnRayoCongelador()
        {
            gru.otorgarArma(torpedo);
            gru.otorgarArma(rayoCongelante);
            gru.alimentar(10);
            Assert.IsFalse(kevin.tieneUnArmaCongelante());
        }
        [Test]
        public void TestRobarLaLunaYVerificarQueFunciono()
        {
            gru.robar("La luna");
            objetos.Remove("La luna");
            Assert.AreEqual(ciudad.Objetos, objetos);
        }
    }
}