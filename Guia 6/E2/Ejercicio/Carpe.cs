namespace Ejercicio
{
    public class Carpe : Varita
    {
        public Carpe(int potencia, Receta receta) : base (potencia, receta)
        {
           
        }
        public override int tiempoEnPreparLaReceta()
        {
            return receta.Pasos / potencia;
        }
    }
}