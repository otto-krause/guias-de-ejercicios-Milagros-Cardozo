using System;
using System.Linq;
using System.Collections.Generic;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliteca peliteca = new Peliteca();
            string opcion = ""; 
            string busqueda = "";

            do
            {
                Console.WriteLine(
                    "Que desea hacer?\n"+
                    "[1]Buscar por nombre\n"+
                    "[2]Buscar por genero\n"+
                    "[3]Buscar por año\n"+
                    "[4]Buscar por director\n"+
                    "[5]Saber el total de peliculas\n"+
                    "[6]Saber cuantas peliculas hay de un genero en especifico\n"+
                    "[7]Salir del programa");
                opcion = (Console.ReadLine());
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre de la pelicula:");
                        busqueda = Console.ReadLine();
                        peliteca.Eleccion(busqueda, opcion).ForEach(i => Console.WriteLine(i));
                    break;
                    case "2":
                        Console.WriteLine("Ingrese el genero de la pelicula:");
                        busqueda = Console.ReadLine();
                        peliteca.Eleccion(busqueda, opcion).ForEach(i => Console.WriteLine(i));
                    break;
                    case "3":
                        Console.WriteLine("Ingrese el año de la pelicula:");
                        busqueda = Console.ReadLine();
                        peliteca.Eleccion(busqueda, opcion).ForEach(i => Console.WriteLine(i));
                    break;
                    case "4":
                        Console.WriteLine("Ingrese el director de la pelicula:");
                        busqueda = Console.ReadLine();
                        peliteca.Eleccion(busqueda, opcion).ForEach(i => Console.WriteLine(i));
                    break;
                    case "5":
                        Console.WriteLine("En total hay " +peliteca.TotalPelis() + " peliculas");
                    break;
                    case "6":
                        Console.WriteLine("Ingrese el genero de la pelicula:");
                        busqueda = Console.ReadLine();
                        Console.WriteLine("La cantidad de peliculas del genero que ingreso es de " +peliteca.CantidadDeGenerosDePeliculas(busqueda));
                    break;
                    case "7":
                        opcion = "0";
                    break;
                }
            }
            while(opcion != "0");
        }
    }
}
