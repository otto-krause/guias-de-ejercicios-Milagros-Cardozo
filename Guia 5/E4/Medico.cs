

namespace E4
{
    public class Medico
    {
        private string nombre;
        private string apellido;
        private string especialidad;
        private int turnos;

        public Medico(string nombre, string apellido, string especialidad, int turnos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.turnos = turnos;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Especialidad { get => especialidad; }
        public int Turnos { get => turnos; }

        public bool EstaDisponible()
        {
            return Turnos < 50;
        }
    }
}