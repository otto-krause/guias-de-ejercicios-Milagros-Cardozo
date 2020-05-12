using System;
using System.Collections.Generic;

namespace E6
{
    public class Juego
    {
        private string titulo;
        public string genero;
        List<Reseña> reseñas = new List<Reseña>();
        public Juego (string titulo, string genero, int estrellas, string comentario)
        {
            this.titulo = titulo;
            this.genero = genero;
            reseñas.Add(new Reseña(estrellas, comentario));
        }
        public int GetEstrellas()
        {
            int i=0;
            foreach(var k in reseñas)
            {
                return k.estrellas;
            }
            return i;
        }
        public string Promedio()
        {
            return "Titulo: " + this.titulo + "\nGenero: " +this.genero;
        }
    }
}