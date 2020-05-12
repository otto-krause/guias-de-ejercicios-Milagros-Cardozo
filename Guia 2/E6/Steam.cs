using System;
using System.Collections.Generic;

namespace E6
{
    public class Steam
    {
        List<Juego> juegos = new List<Juego>();
        public Steam ()
        {
            juegos.Add(new Juego("The Legend of Zelda: Breaht of the Wild", "Aventura", 5, "La animacion y la musica, me encanta!"));
            juegos.Add(new Juego("Mario Kart 8: Deluxe", "Carreras", 5, "Las pistas de carrera son increibles!"));
            juegos.Add(new Juego("Fortnite", "Battle Royale", 1, "me cago en la nueva actualizacion"));
            juegos.Add(new Juego("Pokemon Go", "Aventura", 3, "Podrian añadir mas pases de incursion remota"));
            juegos.Add(new Juego("League of Legends", "Moba", 2, "rito lpm arreglame los servidores"));
            juegos.Add(new Juego("Subway Surfers", "Plataformero", 3, "Divertido pero se me lagea"));
        }
        public List<string> BuscaPorCalificacionAlta()
        {
            List<string> Alta = new List<string>();

            foreach(var k in juegos)
            {
                if(k.GetEstrellas() >= 4)
                {
                    Alta.Add(k.Promedio());
                } 
            }
            return Alta;
        }
         public List<string> BuscaPorCalificacionMedia()
        {
            List<string> Media = new List<string>();
            foreach(var k in juegos)
            {
                if(k.GetEstrellas() == 3)
                {
                    Media.Add(k.Promedio());
                } 
            }
            return Media;
        }
         public List<string> BuscaPorCalificacionBaja()
        {
            List<string> Baja = new List<string>();
            foreach(var k in juegos)
            {
                if(k.GetEstrellas() <= 2)
                {
                    Baja.Add(k.Promedio());
                } 
            }
            return Baja;
        }

    }
}