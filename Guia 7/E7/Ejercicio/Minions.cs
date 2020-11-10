using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Minions
    {
        private string color;
        private int bananas;
        public List<Armas> armas;
        int cantMaldades;

        public int Bananas { get => bananas; set => bananas = value; }
        public int CantMaldades { get => cantMaldades; }

        public Minions(string color, int bananas, Armas arma)
        {
            this.color = color;
            this.bananas = bananas;
            this.armas = new List<Armas>();
            this.armas.Add(arma);
        }
        public bool sonPeligrosos()
        {
            return armas.Count() > 2 || color  == "Violeta";
        }
        public void tomarSuero()
        {
            switch(color)
            {
                case "Amarillo":
                color = "Violeta";
                armas.Clear();
                break;
                case "Violeta":
                color = "Verde";
                break;
                case "Verde":
                color = "Amarillo";
                break;
            }
            bananas--;
        }
        public void Alimentarse()
        {
            bananas ++;
        }
        public int nivelDeConcentracion()
        {
            switch(color)
            {
                case "Amarillo":
                return armas.Max(a => a.Potencia) + bananas;
                case "Violeta":
                return bananas;
                default:
                return 0;
            }
        }
        public void recibirArma(Armas arma)
        {
            armas.Add(arma);
        }
        public bool tieneUnArmaCongelante()
        {
            bool siTiene = false;
            armas.ForEach(a => siTiene = a.Nombre == "Arma Congelante");
            return siTiene;
        }
        public void totalMaldades()
        {
            cantMaldades++;
        } 
    }
}