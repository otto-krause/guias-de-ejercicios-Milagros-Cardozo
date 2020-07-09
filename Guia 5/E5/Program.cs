using System;
using System.Linq;
using System.Collections.Generic;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> conocimiento = new List<string>();
            conocimiento.Add("Actuacion");
            conocimiento.Add("Bailar");
            conocimiento.Add("Manipulacion");
            conocimiento.Add("Inteligencia");
            conocimiento.Add("Comer");
            conocimiento.Add("Cantar");

            Console.WriteLine("Ultimos 5 recientemente adqueridos: ");
            conocimiento.Reverse();
            List<string> aux = conocimiento.Take(5).ToList();
            aux.ForEach(i => Console.WriteLine(i));
            aux.Clear();

            Console.WriteLine("Primeros 4 ordenados alfabeticamente: ");
            conocimiento.Reverse();
            aux = conocimiento.Take(4).OrderBy(n => n).ToList();
            aux.ForEach(i => Console.WriteLine(i));
            aux.Clear();
            
            Console.WriteLine("Total de conocimientos terminados en 'cion': ");
            int count = conocimiento.Count(i => i.Contains("cion"));
            Console.WriteLine("En total hay " + count + " conocimientos que terminan en 'cion' \nLos conocimientos con esta terminacion son: ");
            aux = conocimiento.Where(i => i.Contains("cion")).ToList();
            aux.ForEach(i => Console.WriteLine(i));
        }
    }
}
