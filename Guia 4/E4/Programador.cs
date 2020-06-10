namespace E4
{
    public class Programador : Empleado
    {
        public Programador(int cajaBancaria) : base(cajaBancaria)
        {

        }
        public override int Depositar(string tipo)
        {
            if(tipo=="junior")
            {
                cajaBancaria += 30000;
            }
            else
            {
                if(tipo=="semi senior")
                {
                    cajaBancaria += 25000;
                }
                else
                {
                    if(tipo=="senior")
                    {
                        cajaBancaria +=  45000;
                    }
                }
            }
            return cajaBancaria;
        }
    }
}