using System.Collections.Generic;

namespace Ejercicio
{
    public abstract class Villanos
    {
        protected string estado;

        public string Estado { get => estado; set => estado = value; }

        public Villanos()
        {
            this.estado = "Profugo";
        }
        public abstract void maldad(List<Habitantes> personas);
        public abstract int calcularFuerza();

    }
}