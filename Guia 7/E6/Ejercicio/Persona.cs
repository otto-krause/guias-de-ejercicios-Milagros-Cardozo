using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Persona
    {
        Quirks quirk;
        List<Quirks> quirks;

        public Quirks Quirk { get => quirk; }
        public List<Quirks> Quirks { get => quirks; }

        public Persona(Quirks quirk)
        {
            this.quirk = quirk;
            this.quirks = new List<Quirks>{quirk};
        }
        public void agregarQuirk(Quirks quirk)
        {
            quirks.Add(quirk);
        }
        public void borrarQuirk(string quirkBorrar)
        {
            List<Quirks> eliminado = quirks.Except(quirks.Where(q => q.Nombre == quirkBorrar)).ToList();
            quirks = eliminado;
        }
        public int Poder()
        {
            return quirk.Poder();
        }
        public bool esPeligroso()
        {
            return quirk.esPeligroso();
        }
    }
}