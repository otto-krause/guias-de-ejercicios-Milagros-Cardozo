namespace Ejercicio
{
    public abstract class Armas
    {
        protected int potencia;
        protected int desgaste;
        protected int cantidadDeUsos;

        protected Armas(int potencia, int desgaste, int cantidadDeUsos)
        {
            this.potencia = potencia;
            this.desgaste = desgaste;
            this.cantidadDeUsos = cantidadDeUsos;
        }
        public abstract int calcularPoder();
    }
}