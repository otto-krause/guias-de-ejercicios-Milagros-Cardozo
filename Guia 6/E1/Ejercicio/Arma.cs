namespace Ejercicio
{
    public class Arma
    {
        private int dureza;
        private int potencia;

        public Arma(int dureza, int potencia)
        {
            this.dureza = dureza;
            this.potencia = potencia;
        }

        public int Fuerza()
        {
            return potencia + fibonacci();
        }
        public int fibonacci()
        {
            int a = 0, b = 0, c = 1;
            for (int i = 2; i <= dureza; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return dureza == 0 ? 0 : dureza == 1 ? 1 : c;
        }
        
    }
}