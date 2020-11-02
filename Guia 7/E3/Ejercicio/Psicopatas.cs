using System.Collections.Generic;

namespace Ejercicio
{
    public class Psicopatas : Villanos
    {
        private int asesinatos;
        private int inteligencia;

        public int Asesinatos { get => asesinatos; set => asesinatos = value; }

        public Psicopatas(int inteligencia)
        {
            this.inteligencia = inteligencia;
        }
        public override void maldad(List<Habitantes> personas)
        {
            personas.RemoveRange(0,5);
            asesinatos += 5;
        }
        public override int calcularFuerza()
        {
            return asesinatos * inteligencia;
        }
    }
}