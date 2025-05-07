using System.Collections.Generic;

namespace Cloud9SuperMarket.Models
{
    public class Cliente : Persona
    {
        public List<Pedido> HistorialPedidos { get; private set; }

        public Cliente(string nombre, string dni) : base(nombre, dni)
        {
            HistorialPedidos = new List<Pedido>();
        }

        public void AgregarPedido(Pedido pedido)
        {
            HistorialPedidos.Add(pedido);
        }
    }
}