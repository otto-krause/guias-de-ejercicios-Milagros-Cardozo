namespace Ejercicio
{
    public abstract class Pajaros
    {
        protected int ira;
        public int Ira { get => ira; set => ira = value; }

        protected Pajaros(int ira)
        {
            this.ira = ira;
        }
        public abstract int calcularFuerza();
        public abstract void Enojarse();
    }
}