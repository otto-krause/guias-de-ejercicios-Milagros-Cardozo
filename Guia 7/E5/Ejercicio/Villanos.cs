namespace Ejercicio
{
    public class Villanos : Personas
    {
        private bool roboEnOnce;
        private bool trabajo;
        private bool leGustaLaPizzaConPiña;

        public Villanos(bool roboEnOnce, bool trabajo, bool leGustaLaPizzaConPiña, Quirks quirks) : base (quirks)
        {
            this.roboEnOnce = roboEnOnce;
            this.trabajo = trabajo;
            this.leGustaLaPizzaConPiña = leGustaLaPizzaConPiña;
        }
        public bool esMuyMalo()
        {
            return roboEnOnce == true && trabajo == false && leGustaLaPizzaConPiña == true;
        }
        public bool algunaVezFueBueno()
        {
            return esPeligroso() == false && trabajo == true;
        }
    }
}