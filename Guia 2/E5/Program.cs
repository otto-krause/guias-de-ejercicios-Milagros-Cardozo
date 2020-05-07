using System;
using System.Collections.Generic;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto = "Harina";
            int productocant = 3;
            Supermercado super = new Supermercado (producto, productocant);
            Console.WriteLine("Ganancias totales de hoy: "+ super.Ganancias());
        }
    }
}
