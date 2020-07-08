using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto = "Pepas";
            int productocant = 5;
            Supermercado super = new Supermercado (productocant, producto);
            Console.WriteLine("Ganancias totales: " + super.Ganancias());

        }
    }
}
