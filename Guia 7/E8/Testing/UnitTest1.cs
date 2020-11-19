using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using Ejercicio;
using System;

namespace Testing
{
    public class Tests
    {
        Riley riley;
        Recuerdo recuerdo;
        Recuerdo recuerdo1;
        List<Recuerdo> recuerdos;
        DateTime fecha;
        [SetUp]
        public void Setup()
        {
            fecha = new DateTime(2006, 11, 09);
            recuerdo = new Recuerdo("Tengo un gatito", fecha, "Alegria");
            fecha = new DateTime(2020, 11, 15);
            recuerdo1 = new Recuerdo("Hace tres semanas que no dibujo y estoy harta de todo", fecha, "Tristeza");
            recuerdos = new List<Recuerdo>(){recuerdo, recuerdo1};
            riley = new Riley("Alegria", recuerdos);
        }

        [Test]
        public void TestRileyViveUnEventoYLoAsientaYSaberSuEmocionActual()
        {
            fecha = new DateTime(2020, 8, 23);
            riley.nuevoEvento("Tuve una semana muy pesada", fecha, "Enojo");
            riley.asentarRecuerdo();
            Assert.IsTrue(riley.EmocionesDominante == "Alegria");
        }
        [Test]
        public void TestRileySaberLosPensamientosCentralesDeRiley()
        {
            fecha = new DateTime(2007, 06, 11);
            riley.nuevoEvento("Nueva bici", fecha, "Alegria");
            riley.nuevoEvento("Hace tres semanas que no dibujo y estoy harta de todo", fecha, "Tristeza");
            riley.asentarRecuerdo();  
            Assert.AreEqual(2, riley.Centrales.Count());
        }
        [Test]
        public void TestSaberLosRecuerdosMasDificiles()
        {
            fecha = new DateTime(2013, 04, 30);
            riley.nuevoEvento("Hace tres semanas que no dibujo y estoy harta de todo", fecha, "Tristeza");
            riley.asentarRecuerdo();
            Assert.AreEqual(1, riley.dificiles().Count());
        }
        [Test]
        public void TestSaberSiRileyNiegaUnRecuerdoYMandarlaADormir()
        {
            fecha = new DateTime(2019, 12, 17);
            riley.nuevoEvento("Estoy muy cansada", fecha, "Tristeza");
            Assert.AreEqual(1, riley.negarRecuerdo().Count());
            riley.Dormir("un");
        }
    }
}