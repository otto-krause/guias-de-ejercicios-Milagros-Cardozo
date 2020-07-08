using System.Linq;
using System.Collections.Generic;

namespace E2
{
    public class Supermercado
    {
        List<Carrito> carritos = new List<Carrito>();
        int productocant;
        string producto;
        public Supermercado(int productocant, string producto)
        {
            this.productocant = productocant;
            this.producto = producto;
            Carrito carri1= new Carrito();
            carritos.Add(carri1);
        }
        public int Ganancias ()
        {
            int precio = 0;
            foreach (var k in carritos)
            {
                precio = k.Precio(producto);
            }
            return precio * productocant;
        }
    }
}