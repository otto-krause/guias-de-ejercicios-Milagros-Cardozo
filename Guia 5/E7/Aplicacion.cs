using System.Collections.Generic;

namespace E7
{
    public class Aplicacion
    {
        private string nombre;
        private double tiempoDeUso;
        private int cantidadDeToquesEnLaPantalla;
        private List<string> permisos;
        private double tiempoDeUsoDelTeclado;

        public Aplicacion(string nombre, double tiempoDeUso, int cantidadDeToquesEnLaPantalla, List<string> permisos, double tiempoDeUsoDelTeclado)
        {
            this.nombre = nombre;
            this.tiempoDeUso = tiempoDeUso;
            this.cantidadDeToquesEnLaPantalla = cantidadDeToquesEnLaPantalla;
            this.permisos = permisos;
            this.tiempoDeUsoDelTeclado = tiempoDeUsoDelTeclado;
        }

        public string Nombre { get => nombre; }
        public double TiempoDeUso { get => tiempoDeUso; }
        public int CantidadDeToquesEnLaPantalla { get => cantidadDeToquesEnLaPantalla; }
        public List<string> Permisos { get => permisos; }
        public double TiempoDeUsoDelTeclado { get => tiempoDeUsoDelTeclado; }

        public double Interaccion()
        {
            return tiempoDeUsoDelTeclado / tiempoDeUso;
        }

        public double InteraccioConElTeclado()
        {
            return (tiempoDeUsoDelTeclado / tiempoDeUso) * 100;
        }
    }
}