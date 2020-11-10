using System.Linq;

namespace Ejercicio
{
    public class Heroe : Persona
    {
        private string licencia;
        private int cantVictorias;
        private int cantDerrotas;

        public string Licencia { get => licencia; }
        public int CantVictorias { get => cantVictorias; }
        public int CantDerrotas { get => cantDerrotas; }

        public Heroe(Quirks quirks) : base (quirks)
        {
            this.licencia = "Licencia De Heroe";
            this.cantVictorias = 0;
            this.cantDerrotas = 0;
        }
        public void pelearContraUnVillano(Villano villano)
        {
            if(Poder() > villano.Poder())
                cantVictorias += 1;
            else
                cantDerrotas += 1;
        }
        public void pelearContraUnaPandilla(Pandilla pandilla)
        {
            if(Poder() > pandilla.sumatoriaPoder())
                cantVictorias += pandilla.Pandillas.Count();
            else
                licencia = "Acta de Difusion";
        }
    }
}