namespace Ejercicio
{
    public abstract class Spidermans
    {
        private int fuerza;
        protected int traje;

        public int Fuerza { get => fuerza; }

        protected Spidermans(int fuerza, int traje)
        {
            this.fuerza = fuerza;
            this.traje = traje;
        }

        public void Atacar(KingPin kingPin)
        {
            kingPin.puntosDeVida -= CalcularPoder();
        }
        public abstract int CalcularPoder();

    }
}