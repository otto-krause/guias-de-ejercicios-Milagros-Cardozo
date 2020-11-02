namespace Ejercicio
{
    public class BatiRiñonera
    {
        private string nombre;
        private int potencia;
        private int cantUsos;

        public string Nombre { get => nombre; set => nombre = value; }
        public BatiRiñonera(string nombre, int potencia, int cantUsos)
        {
            this.nombre = nombre;
            this.potencia = potencia;
            this.cantUsos = cantUsos;
        }
        public int Poder()
        {
            return potencia/cantUsos;
        }
    }
}