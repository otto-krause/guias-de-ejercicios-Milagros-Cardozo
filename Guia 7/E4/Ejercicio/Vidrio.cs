namespace Ejercicio
{
    public class Vidrio : Pared
    {
        public Vidrio(int ancho) : base (ancho)
        {
       
        }
        public override int resistenciaDelObstaculos()
        {
            return 10 * ancho; 
        }
    }
}