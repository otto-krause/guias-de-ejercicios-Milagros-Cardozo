using System;
using System.Collections.Generic;

namespace E2
{
    public class Medico
    {
        string nombre;
        string apellido;
        string especialidad;
        int cantturnos;
        public Medico (string nombre, string apellido, string especialidad, int cantturnos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.cantturnos = cantturnos;
        }
        public string nombre1()
        {
            return nombre;
        }
        public string apellido1()
        {
            return apellido;
        }
        public String especialidad1()
        {
            return especialidad;
        }
        public bool Estadisponible()
        {
            return cantturnos<=50;
        }
    }
}

