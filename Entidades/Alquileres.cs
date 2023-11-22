using Entidades;

public class Alquiler : IAlquiler
{
    public Juego JuegoAlquilado { get; set; }
    public Cliente ClienteQueAlquila { get; set; }
    public DateTime FechaInicio { get; set; }
    public string DuracionAlquiler { get; set; }

    public Alquiler(Juego juegoAlquilado, Cliente clienteQueAlquila, DateTime fechaInicio, string duracionAlquiler)
    {
        JuegoAlquilado = juegoAlquilado;
        ClienteQueAlquila = clienteQueAlquila;
        FechaInicio = fechaInicio;
        DuracionAlquiler = duracionAlquiler;
        CalcularCostoAlquiler();
    }

    public decimal CalcularCostoAlquiler()
    {
        int duracionNumerica;
        switch (DuracionAlquiler)
        {
            case "1 día":
                duracionNumerica = 1500;
                break;
            case "7 días":
                duracionNumerica = 2500;
                break;
            case "1 mes":
                duracionNumerica = 3250;  //declaro el valor de aumento segun la duracion seleccionada
                break;
            default:
                duracionNumerica = 0;
                break;
        }
        JuegoAlquilado.Precio = JuegoAlquilado.Precio + duracionNumerica;
        // Implementar lógica para calcular el costo del alquiler
        return JuegoAlquilado.Precio;
    }

}