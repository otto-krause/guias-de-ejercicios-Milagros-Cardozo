namespace E4
{
    public class RRHH : Empleado
    {
        public RRHH(int cajaBancaria) : base(cajaBancaria)
        {
        
        }
        public override int Depositar(string tipo)
        {
            if (tipo=="confiable")
                cajaBancaria += 10000;
            return cajaBancaria;
        }
    }
}