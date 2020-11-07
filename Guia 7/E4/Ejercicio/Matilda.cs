using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Matilda : Pajaros
    {
        List<Huevos> huevos = new List<Huevos>();
        public Matilda(int ira) : base (ira)
        {
            Huevos huevo1 = new Huevos(1000);
            Huevos huevo2 = new Huevos(500);
            huevos.Add(huevo1);
            huevos.Add(huevo2);
        }
        public override int calcularFuerza()
        {
            int fuerzaHuevos = 0;
            huevos.ForEach(h => fuerzaHuevos += h.Fuerza());
            return ira * 2 + fuerzaHuevos;
        }
        public override void Enojarse()
        {
            Huevos huevo = new Huevos(2000);
            huevos.Add(huevo);
        }
    }
}