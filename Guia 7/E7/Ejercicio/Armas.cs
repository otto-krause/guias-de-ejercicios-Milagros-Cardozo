namespace Ejercicio
{
    public class Armas
    {
        private string nombre;
        private int potencia;
        public string Nombre { get => nombre; set => nombre = value; }
        public int Potencia { get => potencia; set => potencia = value; }

        public Armas(string nombre, int potencia)
        {
            this.nombre = nombre;
            this.potencia = potencia;
        }

    }
}