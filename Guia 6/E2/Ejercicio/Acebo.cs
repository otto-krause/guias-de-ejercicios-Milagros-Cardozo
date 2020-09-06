namespace Ejercicio
{
    public class Acebo : Varita
    {
        public Acebo(int potencia, Receta receta) : base (potencia, receta)
        {
           
        }
        public override int tiempoEnPreparLaReceta()
        {
            return receta.ingredientesCantidad() / potencia;
        }
    }
}