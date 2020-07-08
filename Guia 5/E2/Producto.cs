namespace E2
{
    public class Producto
    {
        private string nombre;
        private int precio;

        public Producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre { get => nombre; }
        public int Precio { get => precio; }
    }
}