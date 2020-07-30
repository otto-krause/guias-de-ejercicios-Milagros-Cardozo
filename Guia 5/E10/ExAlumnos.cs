using System.Collections.Generic;
using System.Linq;

namespace E10
{
    public class ExAlumnos
    {
        private string nombre;
        private int idiomas;
        private int sueldo;
        private int cantidadViajes;

        public ExAlumnos(string nombre, int idiomas, int sueldo, int cantidadViajes)
        {
            this.nombre = nombre;
            this.idiomas = idiomas;
            this.sueldo = sueldo;
            this.cantidadViajes = cantidadViajes;
        }

        public string Nombre { get => nombre; }
        public int Idiomas { get => idiomas; }
        public int Sueldo { get => sueldo; }
        public int Viajes { get => cantidadViajes; }
    }
}