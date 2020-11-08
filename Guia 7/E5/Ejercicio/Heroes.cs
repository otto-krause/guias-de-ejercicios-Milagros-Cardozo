using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Heroes : Personas
    {
        private string licencia;
        private int cantVictorias;
        private int cantDerrotas;

        public string Licencia { get => licencia; }
        public int CantVictorias { get => cantVictorias; }
        public int CantDerrotas { get => cantDerrotas; }

        public Heroes(Quirks quirks) : base (quirks)
        {
            this.licencia = "Licencia De Heroe";
            this.cantVictorias = 0;
            this.cantDerrotas = 0;
        }
        public void pelearContraUnVillano(Villanos villano)
        {
            if(Poder() > villano.Poder())
                cantVictorias += 1;
            else
                cantDerrotas += 1;
        }
        public void pelearContraUnaPandilla(Pandilla pandilla)
        {
            if(Poder() > pandilla.sumatoriaPoder())
                cantVictorias ++;
            else
                licencia = "Acta de Difusion";
        }
    }
}