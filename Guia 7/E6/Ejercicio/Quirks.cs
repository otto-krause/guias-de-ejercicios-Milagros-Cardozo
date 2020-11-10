using System.Linq;

namespace Ejercicio
{
    public class Quirks
    {
        private string nombre;
        private int tiempoDeUso;
        private bool consecuencias;
        public int TiempoDeUso { get => tiempoDeUso; set => tiempoDeUso = value; }
        public string Nombre { get => nombre; }
        public bool Consecuencias { get => consecuencias; set => consecuencias = value; }

        public Quirks(string nombre, int tiempoDeUso, bool consecuencias)
        {
            this.nombre = nombre;
            this.tiempoDeUso = tiempoDeUso;
            this.consecuencias = consecuencias;
        }
        public int Poder()
        {
            return tiempoDeUso * nombre.Length;
        }
        public bool esPeligroso()
        {
            return Poder() > 1000 && tiempoDeUso > 60 || consecuencias == true || nombre == "All For One";
        }
    }
}