using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        Mago harryPostre;
        List<int> ingredientes;

        List<Receta> recetas;

        [SetUp]
        public void Setup()
        {
            ingredientes = new List<int>();
            ingredientes.Add(400);
            ingredientes.Add(400);
            ingredientes.Add(400);
            recetas = new List<Receta>();
            recetas.Add(ingredientes, 3);
            recetas.Add(ingredientes, 3);
            harryPostre = new Mago(recetas);
        }

        [Test]
        public void TestSaberSiTodasLasRecetasSonDeGordos()
        {
            Assert.Pass(false, recetas.All(receta => receta.esDeGordo()));
        }

        [Test]
        public void TestSaberSiAlgunaRecetaEsDeRapida()
        {
            Assert.Pass(true, recetas.Any(receta => receta.esDeRapido()));
        }
        
        [Test]
        public void TestSabeSiHarryEsUnLento()
        {
            Assert.Pass(false, harryPostre.esUnLento());
        }
        
        [Test]
        public void TestSaberSiHarryNoSeCuida()
        {
            Assert.Pass(false, recetas.noSeCuida());
        }
    }
}