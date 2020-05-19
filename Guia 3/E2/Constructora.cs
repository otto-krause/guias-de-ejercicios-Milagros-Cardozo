using System.Collections.Generic;

namespace E2
{
    public class Constructora
    {
        List <Contratista> contratistas = new List<Contratista>();
        public int presupuesto;
        public int horas;

        public Constructora(int presupuesto, int horas, List<Contratista> contratistas)
        {
            this.presupuesto = presupuesto;
            this.horas = horas;
            this.contratistas = contratistas;
        }
        public bool sePuede()
        {
            int acu = 0;
            foreach (var i in contratistas)
            {
                i.Trabajar(horas);
                acu += i.Cobrar();
            }
            return presupuesto > acu;
        }
    }
}