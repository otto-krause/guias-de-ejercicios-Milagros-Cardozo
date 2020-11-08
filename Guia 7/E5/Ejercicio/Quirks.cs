using System.Linq;

namespace Ejercicio
{
    public class Quirks
    {
        private string nombre;
        private int tiempoDeUso;
        private bool consecuencias;
        public int TiempoDeUso { get => tiempoDeUso; set => tiempoDeUso = value; }
        public int Nombre { get => nombre.Count(); }
        public bool Consecuencias { get => consecuencias; set => consecuencias = value; }

        public Quirks(string nombre, int tiempoDeUso, bool consecuencias)
        {
            this.nombre = nombre;
            this.tiempoDeUso = tiempoDeUso;
            this.consecuencias = consecuencias;
        }

    }
}