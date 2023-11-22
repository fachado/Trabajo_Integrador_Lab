using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AlquilerExtensions
    {
        //implemento un extension para guardar toda la info del alquiler.
        public static string ObtenerInformacionCompleta(this Alquiler alquiler)
        {
            string informacion = $"Juego alquilado: {alquiler.JuegoAlquilado.Nombre}\n" +
                                 $"Cliente: {alquiler.ClienteQueAlquila.Nombre} - Dni: {alquiler.ClienteQueAlquila.Dni}\n" +
                                 $"Direccion: {alquiler.ClienteQueAlquila.Calle} - {alquiler.ClienteQueAlquila.Numero}\n" +
                                 $"Provincia y Localidad: {alquiler.ClienteQueAlquila.Provincia} - {alquiler.ClienteQueAlquila.Localidad}\n" +
                                 $"Precio Total: {alquiler.JuegoAlquilado.Precio}";

            return informacion;
        }
    }
}
 