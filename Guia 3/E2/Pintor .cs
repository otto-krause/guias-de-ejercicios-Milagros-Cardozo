using System;
using System.Collections.Generic;

namespace E2
{
    public class Pintor : Contratista
    {
        int hora;
        public void Trabajar(int horas)
        {
            this.hora = horas;
        }
        public int Cobrar()
        {
            return (hora * 3) * 50;
        }
    }
}