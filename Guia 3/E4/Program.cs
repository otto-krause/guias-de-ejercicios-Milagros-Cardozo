using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tragalibros libros = new Tragalibros();
            string librito, autorito = "";
            int opcion = 0;

            do
            {
                Console.WriteLine("Que desea hacer?\n"+
                "[1]Ingresar un nuevo libro a su lista\n"+
                "[2]Caulcular si CI\n"+
                "[3]Salir");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del libro: ");
                        librito = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del autor: ");
                        autorito = Console.ReadLine();
                        libros.Leer(librito, autorito);
                    break;
                    case 2:
                        Console.WriteLine("El total de su CI es: " + libros.CalcularCI());
                    break;
                    case 3:
                        opcion = 0;
                    break;
                }
            }
            while(opcion!=0);
        }
    }
}
