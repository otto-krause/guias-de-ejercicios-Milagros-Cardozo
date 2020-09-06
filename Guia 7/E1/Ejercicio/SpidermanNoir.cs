using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class SpidermanNoir : Spidermans
    {
        List<Armas> armas = new List<Armas>();
        public SpidermanNoir(int fuerza, int traje, List<Armas> armas) : base (fuerza, traje)
        {
            this.armas = armas;
        }
        public override int CalcularPoder()
        {
            return Fuerza + traje + armas.Count;
        }
    }
}