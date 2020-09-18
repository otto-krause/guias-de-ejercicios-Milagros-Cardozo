using System.Collections.Generic;
using System.Linq;
using System;

namespace Ejercicio
{
    public class Legion : LegionDeTerror
    {
        private LegionDeTerror lider;
        protected List<Niños> niños;

        public LegionDeTerror Lider { get => lider;}

        public Legion(List<Niños> niños) : base()
        {
            if(niños.Count>1)
                this.niños = niños;
            else 
                throw new Exception("No hay suficientes niños para una legion");
            this.Caramelos = niños.Sum(niños => niños.Caramelos);
            this.capacidadParaAsustar = niños.Sum(niño => niño.CapacidadParaAsustar);
            this.lider = niños.OrderByDescending(niño => niño.CapacidadParaAsustar).First();
        }
        public override void Asustarlos(Adulto adulto)
        {
            niños.OrderByDescending(niño => niño.CapacidadParaAsustar).First().CaramelosLider(adulto.Asustarse(capacidadParaAsustar, caramelosMas15()));
        }
    }
}