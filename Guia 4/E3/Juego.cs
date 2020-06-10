namespace E3
{
    public class Juego
    {
        public string nombre;
        public int añolanzamiento;
        public string consola;
        public Juego(string nomb, int año, string cons)
        {
            this.nombre = nomb;
            this.añolanzamiento = año;
            this.consola = cons;
        }
        public int Añoreturn()
        {
            return añolanzamiento;
        }
    }
}