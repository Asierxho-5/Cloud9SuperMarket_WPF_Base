using System.Collections.Generic;
using System.Windows;
using Cloud9SuperMarket.Models;

namespace Cloud9SuperMarket.Views
{
    public partial class RegistroCliente : Window
    {
        private List<Cliente> clientes;

        public RegistroCliente(List<Cliente> listaClientes)
        {
            InitializeComponent();
            clientes = listaClientes;
        }

        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            string dni = txtDNI.Text;
            clientes.Add(new Cliente(nombre, dni));
            MessageBox.Show("Cliente registrado con éxito.");
        }
    }
}