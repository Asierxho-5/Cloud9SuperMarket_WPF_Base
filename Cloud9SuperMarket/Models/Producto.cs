namespace Cloud9SuperMarket.Models
{
    public class Producto
    {
        private static int contadorID = 1;
        public int ID { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public int Stock { get; set; }

        public Producto(string nombre, decimal precio, int stock)
        {
            ID = contadorID++;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
    }
}