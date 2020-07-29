using System.Collections.Generic;
using System.Linq;

namespace E4
{
    public class Tragalibros
    {
        List <Libro> libro = new List<Libro>();
        List <int> cantidad = new List<int>();
        public void Leer(string librito, string autorito)
        {
            int cont = 0;
            foreach (var i in libro)
            {
                if (i.Titulo != librito && i.Autor != autorito)
                {
                    libro.Add(new Libro(librito, autorito));
                    cont += 1;
                }
            }
            cantidad.Add(cont);
        }
        public int CalcularCI()
        {
            return cantidad.Count() * 5;
        }
    }
}