namespace E4
{
    public abstract class Empleado
    {
        protected int cajaBancaria;
        public Empleado(int cajaBancaria)
        {
            this.cajaBancaria = cajaBancaria;
        }
        public abstract int Depositar(string tipo);
        public int Extraer(int plata)
        {
            return cajaBancaria = cajaBancaria - plata;
        }
    }
}