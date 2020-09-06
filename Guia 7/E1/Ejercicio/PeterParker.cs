namespace Ejercicio
{
    public class PeterParker : Spidermans
    {
        public PeterParker(int fuerza, int traje) : base (fuerza, traje)
        {
        }
        public override int CalcularPoder()
        {
            return Fuerza + traje;
        }
    }
}