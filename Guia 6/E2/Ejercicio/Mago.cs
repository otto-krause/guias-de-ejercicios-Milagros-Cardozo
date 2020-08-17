using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Mago
    {
        List<Receta> recetas;
        Varita varita;
        public bool esUnLento()
        {
            List<Receta> recetasRapidas = recetas.Where(receta => receta.esDeRapido()).ToList();
            Receta recetasRapida = recetasRapidas.First();
            varita = new Carpe(1, recetasRapida);
            return varita.tiempoEnPreparLaReceta() > 30;
        }
        public bool noSeCuida()
        {
            List<Receta> recetasDeGordo = recetas.Where(recetas => recetas.esDeGordo()).ToList();
            return recetas.Count / 2 <= recetasDeGordo.Count();
        }
    }
}