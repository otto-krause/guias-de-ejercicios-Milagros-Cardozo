namespace E1
{
    public abstract class Animales
    {
        protected int energia;
        public Animales (int energia)
        {
            this.energia = energia;
        }
        public abstract int Comer();

        public abstract int Jugar();   

        public abstract int Dormir();
    }
}