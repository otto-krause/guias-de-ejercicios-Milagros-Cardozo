namespace Ejercicio
{
    public class Sables : Armas
    {
        public Sables(int potencia, int desgaste, int cantidadDeUsos) : base (potencia, desgaste, cantidadDeUsos)
        {
        }
        public override int calcularPoder()
        {
            return potencia * cantidadDeUsos * 2;
        }
    }
}