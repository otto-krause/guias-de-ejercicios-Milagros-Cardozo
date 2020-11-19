using System;

namespace Ejercicio
{
    public class Recuerdo
    {
        private string descripcion;
        private DateTime fecha;
        private string emocion;
        public string Emocion { get => emocion; set => emocion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Recuerdo(string descripcion, DateTime fecha, string emocion)
        {
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.emocion = emocion;
        }
    }
}