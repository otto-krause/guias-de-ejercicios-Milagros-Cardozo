namespace Ejercicio
{
    public class SpiderGwen : Spidermans
    {
        private int glamur;
        public SpiderGwen(int fuerza, int traje, int glamur) : base(fuerza, traje)
        {
            this.glamur = glamur;
        }
        public override int CalcularPoder()
        {
            return Fuerza + glamur;
        }
        
    }
}