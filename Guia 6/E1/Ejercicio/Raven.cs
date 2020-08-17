using System.Collections.Generic;

namespace Ejercicio
{
    public class Raven : Titan
    {
        List<string> pensamientos;
        private int felicidad;
        private int porciones;
        public Raven(int tristeza) : base(tristeza)
        {
            this.pensamientos = new List<string>();
            pensamientos.Add(new string("Extraño a mi Papi"));
            pensamientos.Add(new string("Me quedé sin MANTECA"));
            pensamientos.Add(new string("Perdí a Pipo"));
            pensamientos.Add(new string("Voy a comprar pilas para Robocop"));
            pensamientos.Add(new string("¿Donde esta Pipo?"));
            this.felicidad = 2;
            porciones = 4;
        }
        public override void LlorarPorRocop()
        {
            pensamientos.RemoveAt(0);
        }
        public override void comerPizza()
        {
            felicidad += 2 * porciones;
        }
        public override bool estaTriste()
        {
            int count = 0;
            foreach (var i in pensamientos)
            {
                if(i.Contains("Papi") || i.Contains("perrito") || i.Contains("Robocop") || i.Contains("Pipo") || i.Contains("MANTECA"))
                {
                    count ++;
                }
            }
            return count > 5 && felicidad == 10;
        }
        public override int Poder()
        {
            int count = 0;
            foreach (var i in pensamientos)
            {
                if(i.Contains("Papi") || i.Contains("perrito") || i.Contains("Robocop") || i.Contains("Pipo") || i.Contains("MANTECA"))
                {
                    count ++;
                }
            }
            return count;
        }
    }
}