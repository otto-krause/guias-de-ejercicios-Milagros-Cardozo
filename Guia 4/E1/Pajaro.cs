namespace E1
{
    public class Pajaro : Animales
    {
        public Pajaro(int energia) : base(energia)
        {
            
        }
        public override int Comer()
        {
           return energia += 10;
        }
        public override int Jugar()
        {
           return energia -= 5;
        }
        public override int Dormir()
        {
           return energia += 5;
        }
    }
}