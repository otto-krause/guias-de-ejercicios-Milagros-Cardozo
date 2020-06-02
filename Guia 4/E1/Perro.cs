namespace E1
{
    public class Perro : Animales
    {
        public Perro(int energia) : base(energia)
        {
            
        }
        public override int Comer()
        {
           return energia += 15;
        }
        public override int Jugar()
        {
            return energia -= 20;
        }
        public override int Dormir()
        {
           return energia += 10;
        }
    }
}