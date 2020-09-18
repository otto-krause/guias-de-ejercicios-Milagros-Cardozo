using System.Collections.Generic;

namespace Ejercicio
{
    public abstract class Adulto
    {
        protected int tolerancia;
        public Adulto()
        {
            this.tolerancia = 0;
        }
        public abstract int Asustarse(int capacidad, bool caramelosMas15);
    }
}