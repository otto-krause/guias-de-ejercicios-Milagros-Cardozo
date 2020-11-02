using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class RobinHood : Villanos
    {
        private int maldades;
        private int dinerop;

        public RobinHood()
        {
        
        }
        public override void maldad(List<Habitantes> personas)
        {
            maldades++;
            List<Habitantes> asaltadas = personas.Where(p => p.Clase == "Clase alta").ToList();
            List<Habitantes> pobres = personas.Where(p => p.Clase == "Clase baja").ToList();
            asaltadas.ForEach(a => a.Dinero = dinerop);
            asaltadas.ForEach(a => a.Dinero = 0);
            pobres.ForEach(a => a.Dinero = dinerop);
        }
        public override int calcularFuerza()
        {
            return maldades;
        }
    }
}