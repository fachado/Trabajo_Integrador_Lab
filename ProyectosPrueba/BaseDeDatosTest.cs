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

    [TestCleanup]
    public void TearDown()
    {
        // Limpiar después de las pruebas
        // (en este caso, no se realiza ninguna limpieza específica)
    }

    [TestMethod]
    public void RealizarAlquiler_StockSuficiente_RegistraAlquilerYActualizaStock()
    {
        // Arrange
        Juego juego = new Juego("nombrejuego", 1000, 5, "PlataformaX");
        Cliente cliente = new Cliente("ClienteNombre", "", 12345678, "", 0, "", "");
        Alquiler alquiler = new Alquiler(juego, cliente, DateTime.Now, "1 día");

        // Act
        baseDeDatos.RealizarAlquiler(alquiler);

        // Assert
        List<Alquiler> registrosAlquiler = baseDeDatos.ObtenerAlquileres();
        List<Juego> juegosEnBaseDeDatos = baseDeDatos.ObtenerJuegos();

        // Verificar que se registró el alquiler
        Assert.IsTrue(registrosAlquiler.Contains(alquiler));

        // Verificar que se actualizó el stock
        Juego juegoEnBaseDeDatos = juegosEnBaseDeDatos.Find(j => j.Nombre == juego.Nombre);
        Assert.AreEqual(juego.Stock - 1, juegoEnBaseDeDatos.Stock);
    }
}