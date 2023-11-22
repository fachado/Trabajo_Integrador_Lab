namespace Entidades
{
    public class Juego
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Plataforma { get; set; }

        public Juego(string nombre, decimal precio, int stock, string plataforma)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Plataforma = plataforma;
        }
    }

}