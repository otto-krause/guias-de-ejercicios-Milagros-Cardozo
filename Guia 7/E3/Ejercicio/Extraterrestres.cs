using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Extraterrestres : Villanos
    {
       private int abducidos;
       private int extremidades;

        public int Abducidos { get => abducidos; set => abducidos = value; }

        public Extraterrestres(int abducidos, int extremidades)
        {
            this.abducidos = abducidos;
            this.extremidades = extremidades;
        }
        public override void maldad(List<Habitantes> personas)
        {
            Habitantes lemur_del_sur = new Habitantes(2000000);
            personas.RemoveRange(0, abducidos);

            for(int i = 0; i < abducidos; i++)
            {
                personas.Add(lemur_del_sur);
            }
        }
        public override int calcularFuerza()
        {
            return abducidos/extremidades;
        }
    }
}