using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Robin : Titan
    {
        List<Arma> arsenal = new List<Arma>();

        public Robin(List<Arma> arsenal, int tristeza) : base(tristeza)
        {
            this.arsenal = arsenal;
            this.tristeza = 10;
        }

        public override void LlorarPorRocop()
        {
            tristeza += 6;
        }
        public override void comerPizza()
        {
            tristeza -= 1; 
        }
        public override bool estaTriste()
        {
            return arsenal.Max(Arma => Arma.Fuerza()) < 100 && tristeza > 25;
        }

        public bool estaTriste2()
        {
            Arma armaMasFuerte = arsenal.OrderByDescending(arma => arma.Fuerza()).First();
            return armaMasFuerte.Fuerza() < 100 && tristeza > 25;
        }
        
        public override int Poder()
        {
            Arma armaMasFuerte = arsenal.OrderByDescending(arma => arma.Fuerza()).First();
            return armaMasFuerte.Fuerza() - tristeza;
        }
    }
}