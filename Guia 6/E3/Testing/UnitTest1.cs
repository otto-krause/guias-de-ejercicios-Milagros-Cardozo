using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;

namespace Testing
{
    public class Testing
    {
        Zero zero;
        Sables sableDeLuz;
        Sables katana;
        Blasters blasterGastado;
        Mavericks roberto;
        Mavericks carlos;
        List<Mavericks> mavericks;
        List<Armas> armasDeZero;

        [SetUp]
        public void Setup()
        {
            sableDeLuz = new Sables(100, 0, 1);
            blasterGastado = new Blasters(300, 0, 70);
            katana = new Sables(55, 0, 2);
            roberto = new Mavericks(20, sableDeLuz);
            carlos = new Mavericks(100, katana);
            mavericks.Add(carlos);
            mavericks.Add(roberto);
            armasDeZero.Add(sableDeLuz);
            armasDeZero.Add(blasterGastado);
            armasDeZero.Add(katana);
            zero = new Zero(armasDeZero);
        }

        [Test]
        public void TestComprobarPoderDelSableDeLuzEs200()
        {
            Assert.Pass(200, sableDeLuz.calcularPoder());
        }
        [Test]
        public void TestComprobarPoderDelBlasterGastadoEsDe230()
        {
            Assert.Pass(230, blasterGastado.calcularPoder());
        }
        [Test]
        public void TestComprobarPoderDeLaKatanaEs200()
        {
            Assert.Pass(200, katana.calcularPoder());
        }
        [Test]
        public void TestComprobarQueElBlasterGastadoEsElArmaMasPoderosaDeZeroYComprobarQueElPoderDeZeroEsDe230()
        {
            Assert.Pass(blasterGastado, zero.laMasPolentosa());
            Assert.Pass(230, zero.Poder());
        }
        [Test]
        public void TestComprobarQueZeroPuedeVencerARoberto()
        {
            Assert.Pass(true, zero.loPuedeVencer(roberto));
        }
        public void TestComprobarQueZeroNoPuedeVencerACarlos()
        {
            Assert.Pass(false, zero.loPuedeVencer(carlos));
        }
        public void TestComprobarQueZeroNoLosPuedeVencer()
        {
            Assert.Pass(false, zero.losPuedeVencer(mavericks));
        }
    }
}