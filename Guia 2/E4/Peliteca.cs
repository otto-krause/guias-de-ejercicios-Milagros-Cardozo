using System;
using System.Collections.Generic;

namespace E4
{
    public class Peliteca
    {
        List<Pelicula> peliculas = new List<Pelicula>();
        public Peliteca ()
        {
            peliculas.Add(new Pelicula("La hera del hielo", "Infantil",2002,"Chris"));
            peliculas.Add(new Pelicula("Chicas Pesadas", "Comedia",2004,"Mark"));
            peliculas.Add(new Pelicula("It", "Terror",2017, "Andres"));
            peliculas.Add(new Pelicula("Orgullo y Prejuicio", "Romance", 2006,"Joe"));
            peliculas.Add(new Pelicula("Scary Movie", "Comedia", 2000,"Keenen"));
        }
        public List<string> BuscaPorNombre(string nomb)
        {
            List<string> PeliNomb = new List<string>();
            int i=0, j=0;
            foreach(var k in peliculas)
            {
                if(nomb == k.Nombre)
                {
                    PeliNomb.Add(k.Descripcion());
                }
                else
                    i++;
                j++;    
            }
            if(i==j)
            {
                Console.WriteLine("Su pelicula no se encuentra aqui");
            }
            return PeliNomb;
        }
        public List<string> BuscaPorGenero(string gene)
        {
            List<string> PelisGene = new List<string>();
            foreach(var k in peliculas)
            {
                if(gene == k.Genero)
                {
                    PelisGene.Add(k.Descripcion());
                }
            }
            return PelisGene;
        }
        public List<string> BuscaPorAño(int año)
        {
            List<string> PelisAño = new List<string>();
            foreach(var k in peliculas)
            {
                if(año == k.Año)
                {
                    PelisAño.Add(k.Descripcion());
                }
            }
            return PelisAño;
        }
        public List<string> BuscaPorDire(string dire)
        {
            List<string> PelisDire = new List<string>();
            foreach(var k in peliculas)
            {
                if(dire == k.Director)
                {
                    PelisDire.Add(k.Descripcion());
                }
            }
            return PelisDire;
        }
        public void TotalPelis()
        {
            Console.WriteLine("El total de peliculas es: "+peliculas.Count);
        }
        public void ContPelisGenero(string gene)
        {
            int cont=0;
            foreach (var k in peliculas)
            {
                if(gene==k.Genero)
                {
                    cont+=1;
                }
            }
            if(cont>=1)
                Console.WriteLine("La cantidad de peliculas del genero "+ gene + " es: "+cont);
            else
                Console.WriteLine("No tenemos este genero en esta Peliteca");
        }
    }
}