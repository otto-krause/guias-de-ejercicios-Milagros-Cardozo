namespace Ejercicio
{
    public class Piedra : Pared
    {
        public Piedra(int ancho) : base (ancho)
        {
       
        }
        public override int resistenciaDelObstaculos()
        {
            return 10 * ancho; 
        }
    }
}