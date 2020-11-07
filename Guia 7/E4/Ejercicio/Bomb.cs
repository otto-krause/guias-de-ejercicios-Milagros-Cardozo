namespace Ejercicio
{
    public class Bomb : Pajaros
    {
        public Bomb(int ira) : base (ira)
        {

        }
        public override int calcularFuerza()
        {
            return ira * 2;
        }
        public int topeMaximo()
        {
            if(calcularFuerza() > 9000)
                ira = 0;
            return ira;
        }
        public override void Enojarse()
        {
            ira++;
        }
    }
}