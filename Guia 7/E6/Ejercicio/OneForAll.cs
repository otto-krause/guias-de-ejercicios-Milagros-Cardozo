using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class OneForAll
    {
        Heroe dueño;
        public Heroe Dueño { get => dueño; }
        int cantTraspasos;
        private int poder;
        public OneForAll(Heroe dueño)
        {
            this.dueño = dueño;
            this.poder = dueño.Poder();
        }

        public void cambiarDeDueño(Heroe nuevoDueño)
        {
            cantTraspasos++;
            string quirkNombre = "";
            List<Quirks> portadoresAnteriores = dueño.Quirks.Where(p => p.Nombre == "One For All").ToList();
            portadoresAnteriores.ForEach(p => quirkNombre = p.Nombre);

            int extra = 15 * dueño.Poder() / 100;
            dueño.borrarQuirk(quirkNombre);
            dueño = nuevoDueño;
            poder += extra;
            Quirks OFA = new Quirks("One For All", 120, false);
            dueño.agregarQuirk(OFA);
        }
    }
}