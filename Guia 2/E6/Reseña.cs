using System;
using System.Collections.Generic;

namespace E6
{
    public class Reseña
    {
        public int estrellas;
        string comentario;
        public Reseña (int estrellas, string comentario)
        {
            this.estrellas = estrellas;
            this.comentario = comentario;
        }

    }
}