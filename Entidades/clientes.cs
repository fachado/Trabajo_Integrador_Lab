using System;

namespace Entidades
{
    public class Cliente
    {
        public string Nombre { get; }
        public string Apellido { get; }
        public int Dni { get; }
        public string Calle { get; }
        public int Numero { get; }
        public string Provincia { get; }
        public string Localidad { get; }


        //clase cliente
        public Cliente(string nombre, string apellido, int dni, string calle, int numero, string provincia, string localidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Calle = calle;
            Numero = numero;
            Provincia = provincia;
            Localidad = localidad;
        }
    }
}

