namespace E1
{
    public class Persona
    {
       private string nombre;
       private string apellido;
       private int edad;

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int Edad { get => edad; }
    }
}