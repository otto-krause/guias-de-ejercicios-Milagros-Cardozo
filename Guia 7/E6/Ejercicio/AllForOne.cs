using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class AllForOne
    {
        List<Quirks> robados = new List<Quirks>();
        public void robarQuirk(Persona victima)
        {
            robados.Add(victima.Quirk);
            victima.borrarQuirk(victima.Quirk.Nombre);
        }
        public int poderAFO()
        {
            return robados.Sum(r => r.Poder());
        }
        public bool esPeligroso()
        {
            return robados.Any(r => r.esPeligroso());
        }
    }
}