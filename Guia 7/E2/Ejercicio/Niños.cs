using System.Collections.Generic;
using System.Linq;
using System;

namespace Ejercicio
{
    public class Niños : LegionDeTerror
    {
        protected List<Elementos> elementos;
        private int actitudDelNiño;
        private string saludNiño;

        public string SaludNiños { get => saludNiño; }
        public int ActitudDelNiño { get => actitudDelNiño; set => actitudDelNiño = value; }

        public Niños(Maquillaje maquillaje, Traje traje, int actitudDelNiño, int Caramelos)
        {
            this.maquillaje = maquillaje;
            this.traje = traje;
            this.actitudDelNiño = actitudDelNiño;
            if(actitudDelNiño < 1 || actitudDelNiño > 10)
            {
                throw new Exception("El niño no tiene la suficiente actitud para asustar");
            }
            this.capacidadParaAsustar = (maquillaje.Puntos + traje.Puntos) * actitudDelNiño;
            this.Caramelos = Caramelos;
        }

        public override void Asustarlos(Adulto adulto)
        {
            Caramelos += adulto.Asustarse(capacidadParaAsustar, caramelosMas15());
        }
        public void Alimentarse(int cantCaramelos)
        {
            if((cantCaramelos - Caramelos) > 0)
                Caramelos = Caramelos - cantCaramelos;
                if(cantCaramelos > 10)
                {
                    saludNiño = "empachado";
                    actitudDelNiño = actitudDelNiño / 2;
                }
                if(cantCaramelos == 10)
                {
                    saludNiño = "en cama";
                    actitudDelNiño = 0;
                }
            else
                Caramelos = 0;
        }
    }
}