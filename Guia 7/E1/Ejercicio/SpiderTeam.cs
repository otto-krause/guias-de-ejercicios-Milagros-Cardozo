using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class SpiderTeam
    {
        List<Spidermans> arañas = new List<Spidermans>();
        KingPin kingPin;

        public SpiderTeam(List<Spidermans> arañas, KingPin kingPin)
        {
            this.arañas = arañas;
            this.kingPin = kingPin;
        }

        public void pelearConKingpin()
        {
            arañas.ForEach(araña => araña.Atacar(kingPin));
        }
        public void volverACasa()
        {
            List<Spidermans> arañaMenorPoder = arañas.OrderBy(araña => araña.CalcularPoder()).ToList();
            if(kingPin.fueVencido())
                arañas.Remove(arañaMenorPoder.Last());
        }
        public int fuerzaDelSpiderTeam()
        {
            return arañas.Sum(araña => araña.Fuerza);
        }
    }
}