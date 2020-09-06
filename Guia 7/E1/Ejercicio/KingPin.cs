namespace Ejercicio
{
    public class KingPin
    {
        public int puntosDeVida;

        public KingPin(int puntosDeVida)
        {
            this.puntosDeVida = puntosDeVida;
        }

        public bool fueVencido()
        {
            return puntosDeVida < 0;
        }
        public void fueAtacado(int poderDelSpiderman)
        {
            puntosDeVida -= poderDelSpiderman;
        }
    }
}