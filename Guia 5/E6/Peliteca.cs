using System.Collections.Generic;
using System.Linq;
using System;

namespace E6
{
    public class Peliteca
    {
        List<Pelicula> peliculas = new List<Pelicula>();
        public Peliteca()
        {
            peliculas.Add(new Pelicula("Kimi no na wa", "Romance", "2016", "Makoto Shinkai"));
            peliculas.Add(new Pelicula("Unidos", "Aventura", "2020", "Dan Scalon"));
            peliculas.Add(new Pelicula("El castillo ambulante", "Fantasia", "2004", "Hayao Miyazaki"));
            peliculas.Add(new Pelicula("Coco", "Animacion", "2017", "Adrian Molina"));
            peliculas.Add(new Pelicula("El Conjuro", "Terror", "2013", "James Wan")); 
        }
        public List<string> Eleccion(string busqueda, string opcion)
        {
            List<string> descripcion = new List<string>();
            switch (opcion)
            {
                case "1":
                peliculas.Where(i => i.Nombre==busqueda).ToList().ForEach(i => descripcion.Add(i.Descripcion()));
                break;
                case "2":
                peliculas.Where(i => i.Genero==busqueda).ToList().ForEach(i => descripcion.Add(i.Descripcion()));
                break;
                case "3":
                peliculas.Where(i => i.Año==busqueda).ToList().ForEach(i => descripcion.Add(i.Descripcion()));
                break;
                case "4":
                peliculas.Where(i => i.Director==busqueda).ToList().ForEach(i => descripcion.Add(i.Descripcion()));
                break;
            }
            return descripcion;
        }
        public int TotalPelis()
        {
            return peliculas.Count;
        }
        public int CantidadDeGenerosDePeliculas(string busqueda)
        {
            return peliculas.Count(i => i.Genero == busqueda);
        } 
    }
}