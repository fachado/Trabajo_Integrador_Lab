using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

[TestClass]
public class AlquilerTests
{
    [TestMethod]
    public void CalcularCostoAlquiler_DeberiaCalcularCorrectamente()
    {
        // Arrange
        Juego juego = new Juego("NombreJuego", 1000, 5, "PlataformaX");
        Cliente cliente = new Cliente("ClienteNombre", "", 12345678, "", 0, "", "");

        IAlquiler alquiler = new Alquiler(juego, cliente, DateTime.Now, "1 día");

        // Act
        decimal costoAlquiler = alquiler.CalcularCostoAlquiler();

        // Assert
        // Verificar que el costo del alquiler se ha calculado correctamente
        Assert.AreEqual(juego.Precio , costoAlquiler);
    }
}