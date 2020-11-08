using System.Collections.Generic;

namespace Ejercicio
{
    public class Personas
    {
        Quirks quirks;
        public Personas(Quirks quirks)
        {
            this.quirks = quirks;
        }
        public int Poder()
        {
            return quirks.TiempoDeUso * quirks.Nombre;
        }
        public bool esPeligroso()
        {
            return Poder() > 1000 && quirks.TiempoDeUso > 60 || quirks.Consecuencias == true;
        }
    }
}