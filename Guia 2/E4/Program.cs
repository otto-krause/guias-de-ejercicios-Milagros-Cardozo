using System;
using System.Collections.Generic;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliteca pelit = new Peliteca();
            int opcion=1;
            string nomb = "";
            string gene = "";
            int año;
            string dire;
            do
            {
                Console.WriteLine("Que desea hacer?\n[1]Buscar por nombre\n[2]Buscar por genero\n[3]Buscar por año\n[4]Buscar por director\n[5]Saber el total de peliculas\n[6]Saber cuantas peliculas hay de un genero en especifico");
                opcion = Int32.Parse(Console.ReadLine());
                if(opcion==1)
                {
                    Console.WriteLine("Ingrese el nombre de la pelicula:");
                    nomb=Console.ReadLine();
                    pelit.BuscaPorNombre(nomb);
                    foreach(var i in pelit.BuscaPorNombre(nomb))
                    {
                        Console.WriteLine(i);
                    }
                }
                if(opcion==2)
                {
                    Console.WriteLine("Ingrese el genero de la pelicula:");
                    gene=Console.ReadLine();
                    pelit.BuscaPorGenero(gene);
                    foreach (var i in pelit.BuscaPorGenero(gene))
                    {
                        Console.WriteLine(i);
                    }
                }
                if(opcion==3)
                {
                    Console.WriteLine("Ingrese el anio de la pelicula:");
                    año=Int32.Parse(Console.ReadLine());
                    pelit.BuscaPorAño(año);
                    foreach(var i in pelit.BuscaPorAño(año))
                    {
                        Console.WriteLine(i);
                    }
                }
                if(opcion==4)
                {
                    Console.WriteLine("Ingrese el director de la pelicula:");
                    dire=Console.ReadLine();
                    pelit.BuscaPorDire(dire);
                    foreach(var i in pelit.BuscaPorDire(dire))
                    {
                        Console.WriteLine(i);
                    }
                }
                if(opcion==5)
                {
                    pelit.TotalPelis();
                }
                if(opcion==6)
                {
                    Console.WriteLine("Ingrese el genero de pelicula\n");
                    gene=Console.ReadLine();
                    pelit.ContPelisGenero(gene);
                }
                Console.WriteLine("Quiere seguir buscando?\n[1]Si\n[0]No");
                opcion = Int32.Parse(Console.ReadLine());
            }
            while(opcion!=0); 
        }
    }
}
