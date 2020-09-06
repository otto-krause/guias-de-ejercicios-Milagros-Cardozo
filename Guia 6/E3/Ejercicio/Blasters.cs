namespace Ejercicio
{
    public class Blasters : Armas
    {
        public Blasters(int potencia, int desgaste, int cantidadDeUsos) : base (potencia, desgaste, cantidadDeUsos)
        {
        }
        public override int calcularPoder()
        {
            if(potencia > cantidadDeUsos)
                return potencia - cantidadDeUsos;
            else 
                return 1;
        }
    }
}