using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAlquiler
    {
        Juego JuegoAlquilado { get; set; }
        Cliente ClienteQueAlquila { get; set; }
        DateTime FechaInicio { get; set; }
        string DuracionAlquiler { get; set; }

        decimal CalcularCostoAlquiler();
    }
}
