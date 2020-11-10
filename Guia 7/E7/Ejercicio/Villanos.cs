using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Villanos
    {
        List<Minions> minions;
        Minions minion;
        Ciudad ciudad;
        Minions masUtil;
        List<Minions> capacitados;

        public Villanos(List<Minions> minions, Ciudad ciudad)
        {
            this.minions = new List<Minions>();
            this.ciudad = ciudad;
        }
        public void nuevoMinion()
        {
            Armas rayoCongelante = new Armas("Rayo congelante", 10);
            Minions nuevo = new Minions("Amarillo", 5, rayoCongelante);
            minions.Add(nuevo);
        }
        public void otorgarArma(Armas arma)
        {
           minions.ForEach(m => m.recibirArma(arma));
        }
        public void alimentar(int masBananas)
        {
            minions.ForEach(m => m.Bananas += masBananas);
        }
        public int nivelConcentracionMinion()
        {
            return minion.nivelDeConcentracion();
        }
        public bool minionPeligroso()
        {
            return minion.sonPeligrosos();
        }
        public void congelar()
        {
            capacitados = minions.Where(m => m.tieneUnArmaCongelante() == true && m.nivelDeConcentracion() >= 500).ToList();
            capacitados.ForEach(c => c.totalMaldades());
            ciudad.bajar30Grados();
        }
        public void robar(string robado)
        {
            switch (robado)
            {
                case "Piramide":
                capacitados = minions.Where(m => m.sonPeligrosos() == true && m.nivelDeConcentracion() >= ciudad.Altura/2).ToList();
                capacitados.ForEach(c => c.Bananas =+ 10);
                capacitados.ForEach(c => c.totalMaldades());
                break;
                case "Suero mutante":
                capacitados = minions.Where(m => m.sonPeligrosos() == true && m.Bananas >= 100 && m.nivelDeConcentracion() >= 23).ToList();
                capacitados.ForEach(c => c.tomarSuero());
                capacitados.ForEach(c => c.totalMaldades());
                break;
                case "La luna":
                capacitados = minions.Where(m => m.sonPeligrosos() == true && m.tieneUnArmaCongelante()).ToList();
                Armas rayoCongelante = new Armas("Rayo congelante", 10);
                capacitados.ForEach(c => c.recibirArma(rayoCongelante));
                capacitados.ForEach(c => c.totalMaldades());
                break;
            }
            ciudad.objetosRobados(robado);
        }
        public Minions minionMasUtil()
        {
            List<Minions> elMasUtil = minions.Where(m => m.CantMaldades == minions.Max(m => m.CantMaldades)).ToList();
            elMasUtil.ForEach(e => masUtil = e);
            return masUtil;
        }
        public List<Minions> minionsMasInutiles()
        {
            List<Minions> inutiles = minions.Where(m => m.CantMaldades == 0).ToList();
            return inutiles;
        }
    }
}