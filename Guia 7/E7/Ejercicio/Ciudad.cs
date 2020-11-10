using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Ciudad
    {
        private int grados;
        List<string> objetos;
        private int altura;
        public int Altura { get => altura; set => altura = value; }
        public List<string> Objetos { get => objetos; }

        public Ciudad(int grados, List<string> objetos, int altura)
        {
            this.grados = grados;
            this.objetos = objetos;
            this.altura = altura;
        }

        public void bajar30Grados()
        {
            grados -= 30;
        }
        public void objetosRobados(string robado)
        {
            switch (robado)
            {
                case "Piramide":
                objetos.Remove("Piramide");
                break;
                case "Suero mutante":
                objetos.Remove("Suero utante");
                break;
                case "La luna":
                objetos.Remove("La luna");
                break;
                default:
                break;
            }
        }
    }
}