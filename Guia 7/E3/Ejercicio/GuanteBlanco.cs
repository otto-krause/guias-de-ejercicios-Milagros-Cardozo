using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class GuanteBlanco : Villanos
    {
        private int maldades;

        public GuanteBlanco()
        {
            
        }
        public override void maldad(List<Habitantes> personas)
        {
            maldades++;
            List<Habitantes> asaltadas = personas.Where(p => p.Clase == "Clase alta").ToList();
            asaltadas.ForEach(a => a.Dinero = 0);
        }
        public override int calcularFuerza()
        {
            return maldades;
        }
    }
}