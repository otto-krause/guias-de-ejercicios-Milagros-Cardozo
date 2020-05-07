using System.Collections.Generic;

namespace E5
{
    public class Supermercado
    {
        List<Carrito> carritos = new List<Carrito>();
        string producto;
        int productocant;

        public  Supermercado (string producto, int productocant)
        {
            this.producto = producto;
            this.productocant = productocant;
            Carrito carri1 = new Carrito();
            carritos.Add(carri1);
        }
        public int Ganancias ()
        {
            int precio = 0;
            foreach (var k in carritos)
            {
                precio = k.precio(producto);
            }
            return precio * productocant;
        }
    }

}