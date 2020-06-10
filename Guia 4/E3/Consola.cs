using System.Collections.Generic;

namespace E3
{
    public abstract class Consola
    {
        public List<Juego> juegos = new List<Juego>();
        protected int puntaje;
        public Consola()
        {
            
        }

        public abstract void AgregarJuego(string nomb,int año,string cons);
        public abstract void Jugar(int horas);
        public abstract int RevisarPuntaje();
        public abstract string ElMasNuevo();
        public abstract string ElMasViejo();

    }
}