namespace E4
{
    public class Administrativo : Empleado
    {
        public Administrativo(int cajaBancaria) : base(cajaBancaria)
        {

        }
        public override int Depositar(string tipo)
        {
           cajaBancaria += 35000;
            return cajaBancaria;
        }
    }
}