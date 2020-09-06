namespace Ejercicio
{
    public class Mavericks
    {
        private int destreza;
        Armas armas;
        public Mavericks(int destreza, Armas armas)
        {
            this.destreza = destreza;
            this.armas = armas;
        }
        public int Fuerza()
        {
            return armas.calcularPoder() + destreza;
        }
        public bool esDebil()
        {
            return Fuerza() < 200;
        }
    }
}