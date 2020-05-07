using System.Collections.Generic;


namespace E5
{
    public class Carrito
    {
        List<Producto> productos = new List<Producto>();

        public Carrito()
        {
            Producto produ1 = new Producto("Harina", 80);
            Producto produ2 = new Producto("Huevos", 20);
            productos.Add(produ1);
            productos.Add(produ2);
        }
        public int precio(string producto)
        {
            foreach (var k in productos)
            {
                if(producto == k.NombreP()) 
                    return k.PrecioP();
            }
            return 0;
        }
    }
}