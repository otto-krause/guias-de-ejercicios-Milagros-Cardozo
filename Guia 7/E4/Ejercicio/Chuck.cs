namespace Ejercicio
{
    public class Chuck : Pajaros
    {
        private int velocidad; 
        private int i;
        public Chuck(int ira, int velocidad) : base(ira)
        {
            this.velocidad = velocidad;
        }
        public override int calcularFuerza()
        {
            if(velocidad <= 80)
                i = 150;
            if(velocidad > 80)
                i = 150 + 5 * (velocidad - 80);
            return  i;            
        }
        public override void Enojarse()
        {
            velocidad *= 2;
        }
    }
}