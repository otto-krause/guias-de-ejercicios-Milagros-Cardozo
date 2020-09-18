using System.Linq;

namespace Ejercicio
{
    public class Abuelo : Adulto
    {
        public Abuelo(int tolerancia)
        {
            this.tolerancia = tolerancia;
        }
        public override int Asustarse(int capacidad, bool caramelosMas15)
        {
           return tolerancia / 4;
        }
    }
}