using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

[TestClass]
public class BaseDeDatosTests
{
    private BaseDeDatos baseDeDatos;

    [TestInitialize]
    public void SetUp()
    {
        // Configurar la base de datos para las pruebas
        baseDeDatos = new BaseDeDatos();
    }


    [TestMethod]
    public void RealizarAlquiler_StockSuficiente_RegistraAlquilerYActualizaStock()
    {
        // Arrange
        Juego juego = new Juego("NombreJuego", 1000, 5, "PlataformaX");
        Cliente cliente = new Cliente("ClienteNombre", "", 12345678, "", 0, "", "");
        Alquiler alquiler = new Alquiler(juego, cliente, DateTime.Now, "1 día");

        // Act
        baseDeDatos.RealizarAlquiler(alquiler);

        // Assert
        List<Alquiler> registrosAlquiler = baseDeDatos.ObtenerAlquileres();

        // Verificar que se registró el alquiler
        Assert.IsTrue(registrosAlquiler.Contains(alquiler));


    }
}