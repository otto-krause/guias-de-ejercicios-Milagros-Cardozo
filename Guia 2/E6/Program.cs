using System;
using System.Collections.Generic;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
           Steam steam = new Steam();
           int opcion;
           Console.WriteLine("Por que clasificacion de juego quiere buscar?\n[1]Alta\n[2]Media\n[3]Baja\n");
           opcion = Int32.Parse(Console.ReadLine());
           switch (opcion)
           {
               case 1:
                        steam.BuscaPorCalificacionAlta();
                        foreach(var i in steam.BuscaPorCalificacionAlta())
                        {
                             Console.WriteLine(i);
                        }
                break;
                case 2:
                        steam.BuscaPorCalificacionMedia();
                        foreach(var i in steam.BuscaPorCalificacionMedia())
                        {
                             Console.WriteLine(i);
                        }
                break;
                case 3:
                        steam.BuscaPorCalificacionBaja();
                        foreach(var i in steam.BuscaPorCalificacionBaja())
                        {
                             Console.WriteLine(i);
                        }
                break;
           }
        }
    }
}