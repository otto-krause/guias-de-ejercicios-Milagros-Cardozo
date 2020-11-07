namespace Ejercicio
{
    public class Terence : Pajaros
    {
        private int cantEnojado = 1;
        public Terence(int ira) : base(ira)
        {

        }
        public override int calcularFuerza()
        {
            return ira * cantEnojado * 5;
        }
        public override void Enojarse()
        {
            cantEnojado++;
        }
    }
}