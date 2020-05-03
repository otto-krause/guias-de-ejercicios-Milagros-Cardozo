using System;
using System.Collections.Generic;

namespace E4
{
    public class Pelicula
    {
        private string nombre;
        public string Nombre { get => nombre;}
        private string genero;
        public string Genero { get => genero;}
        private int año;
        public int Año { get => año;}
        private string director;
        public string Director { get => director;}
        public Pelicula (string nombre, string genero, int año, string director)
        {
            this.nombre  = nombre;
            this.genero = genero;
            this.año = año;
            this.director = director;
        }
        public string Descripcion()
        {
            return "Nombre: " + this.nombre + "\nGenero: " +this.genero+ "\nDirector: " + this.director + "\nAño: " + this.año;
        }
    }
}