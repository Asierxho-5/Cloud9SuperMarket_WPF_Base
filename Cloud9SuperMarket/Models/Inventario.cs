using System.Collections.Generic;
using System.Linq;

namespace Cloud9SuperMarket.Models
{
    public class Inventario
    {
        private List<Producto> productos;

        public Inventario()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public Producto BuscarProducto(string nombre)
        {
            return productos.FirstOrDefault(p => p.Nombre.ToLower() == nombre.ToLower());
        }

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}