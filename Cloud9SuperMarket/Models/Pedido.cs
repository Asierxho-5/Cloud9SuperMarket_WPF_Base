using System.Collections.Generic;

namespace Cloud9SuperMarket.Models
{
    public class Pedido
    {
        private static int contadorID = 1;
        public int ID { get; }
        public Cliente Cliente { get; }
        public List<Producto> Productos { get; private set; }
        public string Estado { get; private set; }

        public Pedido(Cliente cliente)
        {
            ID = contadorID++;
            Cliente = cliente;
            Productos = new List<Producto>();
            Estado = "Pendiente";
        }

        public bool AgregarProducto(Producto producto)
        {
            if (producto.Stock > 0)
            {
                Productos.Add(producto);
                producto.Stock--;
                return true;
            }
            return false;
        }

        public void CompletarPedido()
        {
            Estado = "Completado";
            Cliente.AgregarPedido(this);
        }
    }
}