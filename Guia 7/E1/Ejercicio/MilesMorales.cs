namespace Ejercicio
{
    public class MilesMorales : Spidermans
    {
        private int canto;
        public MilesMorales(int fuerza, int traje, int canto) : base(fuerza, traje)
        {
            this.canto = canto;
        }
        public override int CalcularPoder()
        {
            return Fuerza + canto;
        }
    }
}