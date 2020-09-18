using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Comun : Adulto
    {
        protected int masDe15;
        public Comun()
        {
            
        }
        protected int Tolerancia()
        {
            return tolerancia = 10 * masDe15;
        }
        public override int Asustarse(int capacidad, bool caramelosMas15)
        {
            int caramelosDar = 1;
            caramelosDar = Tolerancia() < capacidad ? Tolerancia() / 2 : 0;
            if (caramelosMas15 == true)
                masDe15 += 1;
            return caramelosDar;
        }
    }
}