namespace Cloud9SuperMarket.Models
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }

        protected Persona(string nombre, string dni)
        {
            Nombre = nombre;
            DNI = dni;
        }
    }
}