using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class GuanteMarron : Villanos
    {
        private int maldades;

        public int Maldades { get => maldades; set => maldades = value; }

        public GuanteMarron()
        {
            
        }
        public override void maldad(List<Habitantes> personas)
        {
            maldades++;
            List<Habitantes> asaltadas = personas.Where(p => p.Clase == "Clase media").ToList();
            asaltadas.ForEach(a => a.Dinero = 0);
        }
        public override int calcularFuerza()
        {
            return maldades;
        }
    }
}