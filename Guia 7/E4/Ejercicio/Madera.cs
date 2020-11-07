namespace Ejercicio
{
    public class Madera : Pared
    {
        public Madera(int ancho) : base (ancho)
        {
       
        }
        public override int resistenciaDelObstaculos()
        {
            return 25 * ancho; 
        }
    }
}