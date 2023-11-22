using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VerificadorDatos
{
    //funcion para verificar todos los datos del cliente.
    public static bool VerificarDatos(string nombre, string apellido, string dni, string calle, string numero, string localidad, string provincia, out string mensajeError)
    {
        mensajeError = string.Empty;

        // Verificar que el nombre no esté vacío
        if (string.IsNullOrWhiteSpace(nombre))
        {
            mensajeError = "El nombre no puede estar vacío.";
            return false;
        }

        // Verificar que el apellido no esté vacío
        if (string.IsNullOrWhiteSpace(apellido))
        {
            mensajeError = "El apellido no puede estar vacío.";
            return false;
        }

        // Verificar que el DNI no esté vacío y sea un número válido
        if (string.IsNullOrWhiteSpace(dni) || !int.TryParse(dni, out _))
        {
            mensajeError = "El DNI debe ser un número válido y no puede estar vacío.";
            return false;
        }

        // Verificar que la calle no esté vacía
        if (string.IsNullOrWhiteSpace(calle))
        {
            mensajeError = "La calle no puede estar vacía.";
            return false;
        }

        // Verificar que el número no esté vacío y sea un número válido
        if (string.IsNullOrWhiteSpace(numero) || !int.TryParse(numero, out _))
        {
            mensajeError = "El número debe ser un número válido y no puede estar vacío.";
            return false;
        }

        // Verificar que la localidad no esté vacía
        if (string.IsNullOrWhiteSpace(localidad))
        {
            mensajeError = "La localidad no puede estar vacía.";
            return false;
        }

        // Verificar que la provincia no esté vacía
        if (string.IsNullOrWhiteSpace(provincia))
        {
            mensajeError = "La provincia no puede estar vacía.";
            return false;
        }

        // Todos los datos son válidos
        return true;
    }
}