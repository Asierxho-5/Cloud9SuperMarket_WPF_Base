using System;
using System.Windows;
using Cloud9SuperMarket.Models;

namespace Cloud9SuperMarket.Views
{
    public partial class GestionProductos : Window
    {
        private Inventario inventario;

        public GestionProductos(Inventario inv)
        {
            InitializeComponent();
            inventario = inv;
        }

        private void AgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                inventario.AgregarProducto(new Producto(nombre, precio, stock));
                MessageBox.Show("Producto agregado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}