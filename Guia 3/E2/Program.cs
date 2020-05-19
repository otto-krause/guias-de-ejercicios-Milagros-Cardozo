using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {    
            List <Contratista> contratistas = new List<Contratista>();
            int horas = 0;
            int presupuesto = 0;

            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Plomeros());
            contratistas.Add(new Plomeros());
            contratistas.Add(new Plomeros());
            contratistas.Add(new Plomeros());
            contratistas.Add(new Plomeros());
            contratistas.Add(new Plomeros());
            contratistas.Add(new Albañiles(23, true));
            contratistas.Add(new Albañiles(86, false));
            contratistas.Add(new Albañiles(36, false));
            contratistas.Add(new Albañiles(47, true));
            contratistas.Add(new Albañiles(98, true));

            Console.WriteLine("Ingrese el presupuesto de la constructora");
            presupuesto = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las horas para trabajar");
            horas = Int32.Parse(Console.ReadLine());
            Constructora constructora = new Constructora(presupuesto, horas, contratistas);
            Console.WriteLine("¿Se puede armar? "+constructora.sePuede());
        }
    }
}
