using System.Collections.Generic;

namespace E3
{
    public class PC
    {
        private List<Componente> listaDeComponentes;
        private int total = 0;
        private bool sePuede = true;
        private Motherboard mother;
        public PC()
        {
            listaDeComponentes = new List<Componente> ();
            mother = new Motherboard("Gigabyte H310m H(rev. 1.0)", "DDR4", 2360, 2100, "SKU 31001");
        }

        public void NuevoComponente(Componente componentenuevo)
        {
            listaDeComponentes.Add(componentenuevo);
        }

        public int PrecioTotal()
        {
            foreach (var i in listaDeComponentes)
            {
                total += i.Precio();
            }
            return total;
        }
        public bool SePuedeArmar()
        {
            foreach (Componente i in listaDeComponentes)
            {
                if(sePuede==true)
                {
                    sePuede = i.EsCompatible(mother);
                }
            }
            return sePuede;
        }
    }
}