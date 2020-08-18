using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Zero
    {
        List<Armas> armas;

        public Zero(List<Armas> armas)
        {
            this.armas = armas;
        }

        public Armas laMasPolentosa()
        {
            Armas armaMasPolentosa = armas.First();
            foreach(var arma in armas)
            {
                if(armas.Max(arma => arma.calcularPoder() == arma.calcularPoder()))
                    armaMasPolentosa = arma;
            }
            return armaMasPolentosa;
        }
        public int Poder()
        {
            return laMasPolentosa().calcularPoder();
        }
        public bool loPuedeVencer(Mavericks mavericks)
        {
            return Poder() > mavericks.Fuerza();
        }
        public bool losPuedeVencer(List<Mavericks> mavericks)
        {
            bool puedeVencer = true;
            puedeVencer = mavericks.Any(maverick => maverick.Fuerza() < Poder());
            return puedeVencer;
        }
    }
}