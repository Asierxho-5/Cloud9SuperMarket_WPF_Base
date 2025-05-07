using System.Collections.Generic;
using System.Windows;
using Cloud9SuperMarket.Models;

namespace Cloud9SuperMarket.Views
{
    public partial class RealizarPedido : Window
    {
        private List<Cliente> clientes;
        private Inventario inventario;
        private List<Pedido> pedidos;

        public RealizarPedido(List<Cliente> listaClientes, Inventario inv, List<Pedido> listaPedidos)
        {
            InitializeComponent();
            clientes = listaClientes;
            inventario = inv;
            pedidos = listaPedidos;
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            string dni = txtDNI.Text;
            string prod = txtProducto.Text;
            var cliente = clientes.Find(c => c.DNI == dni);
            if (cliente != null)
            {
                var pedido = new Pedido(cliente);
                var producto = inventario.BuscarProducto(prod);
                if (producto != null && pedido.AgregarProducto(producto))
                {
                    pedido.CompletarPedido();
                    pedidos.Add(pedido);
                    MessageBox.Show("Producto agregado y pedido completado.");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado o sin stock.");
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }
    }
}