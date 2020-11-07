using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq; 

namespace Testing
{
    public class Tests
    {
        Red red;
        Chuck chuck;
        Matilda matilda;
        Terence terence;
        Bomb bomb;
        CerditosArmados armados;
        CerditosObreros obreros;
        Huevos huevo;
        IslaPajaro isla;
        List<Obstaculo> obstaculos;
        PajarosComunes comunes;
        List<Pajaros> pajaros;
        Vidrio vidrio;
        Madera madera;
        Piedra piedra;

        [SetUp]
        public void Setup()
        {
            red = new Red(10);
            bomb = new Bomb(10);
            chuck = new Chuck(10, 50);
            matilda = new Matilda(10);
            terence = new Terence(10);
            comunes = new PajarosComunes(10);

            pajaros = new List<Pajaros>{red, bomb, chuck, matilda, comunes, terence};

            huevo = new Huevos(1000);

            obreros = new CerditosObreros();
            madera = new Madera(20);
            piedra = new Piedra(5);

            obstaculos = new List<Obstaculo>{obreros, madera, piedra};

            isla = new IslaPajaro(pajaros, obstaculos);
        }

        [Test]
        public void TestHacerEnojarARedYSaberLaFuerzaDeRed()
        {
            red.Enojarse();
            Assert.AreEqual(200, red.calcularFuerza());
        }
        [Test]
        public void TestSaberLosPajarosMasFuertesYCaulcularLaFuerzaTotalDeLaIsla()
        {
            int islaFuerza = 0;
            List<Pajaros> masFuerte = pajaros.Where(p => p.calcularFuerza() >= 50).ToList();
            masFuerte.ForEach(p => islaFuerza += p.calcularFuerza());
            Assert.AreEqual(1820, islaFuerza);
        }
        [Test]
        public void TestHacerUnaFiestaSorpresaParaRedYMostrarQueRedSeEnojoDosVeces()
        {
            //la cantidad de veces que se enojo Red esta iniciado en uno para no complicar otros testeos
            isla.fistaSorpresa(red);
            Assert.IsTrue(red.CantEnojado == 2);
        }
        [Test]
        public void TestSaberSiAlgunPajaroPuedeDestruirUnObstaculoYQueAtaquenALaIslaCerditoYRecuperenLosHuevos()
        {
            Assert.AreEqual(true, isla.atacarIslaCerdito());
            huevo.seRompio(isla);
        }
        
    }
}