using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class LegionesDeLegiones : LegionDeTerror
    {
        private LegionDeTerror lider;
        public LegionDeTerror Lider { get => lider;}
        protected List<LegionDeTerror> miembros;
        public LegionesDeLegiones(List<LegionDeTerror> miembros)
        {
            this.miembros = miembros;
            this.Caramelos = miembros.Sum(m => m.Caramelos);
            this.capacidadParaAsustar = miembros.Sum(m => m.CapacidadParaAsustar);
            this.lider = miembros.OrderByDescending(m => m.CapacidadParaAsustar).First();
        }
        public override void Asustarlos(Adulto adulto)
        {
            Caramelos += adulto.Asustarse(capacidadParaAsustar, caramelosMas15());
        }
    }
}