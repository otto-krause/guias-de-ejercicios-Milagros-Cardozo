namespace Ejercicio
{
    public class CerditosArmados : Obstaculo
    {
        private int cascos;
        private int escudos;
        public CerditosArmados (int escudos, int cascos)
        {
            this.escudos = escudos;
            this.cascos = cascos;
        }
        public override int resistenciaDelObstaculos()
        {
            return cascos * 10 + escudos * 10;
        }
    }
}