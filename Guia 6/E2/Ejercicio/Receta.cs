using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Receta
    {
        List<int> ingredientes;

        private int pasos;
        
        public int Pasos { get => pasos;}

        public Receta(List<int> ingredientes, int pasos)
        {
            this.ingredientes = ingredientes;
            this.pasos = pasos;
        }
        public int ingredientesCantidad()
        {
            return ingredientes.Count;
        }
        public bool esDeGordo()
        {
            return ingredientes.Sum(ingrediente => ingrediente) > 2000;
        }
        public bool esDeRapido()
        {
            return ingredientes.Count() / pasos > 1;
        }
    }
}