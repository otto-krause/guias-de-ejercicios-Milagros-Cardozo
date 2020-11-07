namespace Ejercicio
{
    public class Pared : Obstaculo
    {
        protected int ancho;
        public Pared(int ancho)
        {
            this.ancho = ancho;
        }
        public override int resistenciaDelObstaculos()
        {
            return 50 * ancho;
        }
    }
}