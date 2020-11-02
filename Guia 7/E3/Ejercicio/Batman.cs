using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Batman
    {
        List<BatiRiñonera> tecnologias = new List<BatiRiñonera>();
        public int vitalidad;
        public int estres;

        public Batman(List<BatiRiñonera> tecnologias)
        {
            this.tecnologias = tecnologias;
            this.vitalidad = 800;
            this.estres = 8;
        }

        public void LlorarPorSusPadres()
        {
            estres -= 10;
        }
        public int BatiCaballero()
        {
            return vitalidad + tecnologias.Sum(b => b.Poder());
        }
        public bool estaEstresado()
        {
            return estres > 15;
        }
        public bool estaAlaModa()
        {
            return tecnologias.All(b => b.Nombre.StartsWith("Bati"));
        }
        public void batiTwist()
        {
            vitalidad += 100;
        }
        public void enCombate(List<Villanos> villanos)
        {
            if(BatiCaballero() > villanos.Sum(v => v.calcularFuerza()))
            {
                villanos.ForEach(v => v.Estado = "Inconciente");
            }
            else
            {
                vitalidad -= 200;
            }
            estres += villanos.Count();
        }
        public void enCombateUnico(Villanos villano)
        {
            if(BatiCaballero() > villano.calcularFuerza())
            {
                villano.Estado = "Inconciente";
            }
            else
            {
                vitalidad -= 200;
            }
            estres++;
        }
    }
}