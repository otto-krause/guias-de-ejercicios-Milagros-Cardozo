namespace Ejercicio
{
    public abstract class Titan
    {
        protected int tristeza;

        protected Titan(int tristeza)
        {
            this.tristeza = tristeza;
        }

        public abstract void LlorarPorRocop();
        public abstract void comerPizza();
        public abstract bool estaTriste();
        public abstract int Poder();
    }
}