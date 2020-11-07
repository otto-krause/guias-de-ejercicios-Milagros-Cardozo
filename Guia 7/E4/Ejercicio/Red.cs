namespace Ejercicio
{
    public class Red : Pajaros
    {
        private int cantEnojado = 1;
        public int CantEnojado { get => cantEnojado; set => cantEnojado = value; }
        public Red(int ira) : base (ira)
        {

        }
        public override int calcularFuerza()
        {
            return ira * 10 * cantEnojado;
        }
        public override void Enojarse()
        {
            cantEnojado++;
        }
    }
}