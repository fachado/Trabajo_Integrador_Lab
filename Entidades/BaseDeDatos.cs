using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
using System;

public class BaseDeDatos
{
    public List<Juego> juegos { get; set; }
    private static string connectionString;
    public List<Alquiler> RegistrosAlquiler { get; set; } = new List<Alquiler>();

    string rutaArchivoCSV = "C:\\Users\\ignac\\source\\repos\\lquileres Taytum\\Entidades\\ListaJuegos.csv";
    //no me anda con la ruta relativa string rutaArchivoCSV = "Entidades\\ListaJuegos.csv";

    public BaseDeDatos()
    {
        juegos = new List<Juego>();
        BaseDeDatos.connectionString = "Server=.;Database=Alquiler_juegos;Trusted_Connection=True;";
        InicializarBaseDeDatos();

    }
    private void InicializarBaseDeDatos()
    {
        
       CrearTablaAlquileres();
       CrearTablaJuegosEnBaseDeDatos();
       CargarJuegosEnBaseDeDatos();
       CargarJuegosDesdeBaseDeDatos();
       CargarRegistrosDesdeBaseDeDatos();


        
    }

    public List<Juego> ObtenerJuegos()
    {
        return juegos;
    }

    public List<Alquiler> ObtenerAlquileres()
    {
        Console.WriteLine(RegistrosAlquiler.Count);

        return RegistrosAlquiler;

    }
    public void CargarRegistrosDesdeBaseDeDatos()//guardo los registros de la base de datos  en la lista
    {
        try
        {
            string selectQuery = "SELECT Juego, Cliente, FechaAlquiler, Duracion FROM Alquileres";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crear un nuevo objeto Cliente con la info necesaria
                            Cliente cliente = new Cliente
                            (
                                nombre: reader["Cliente"].ToString(),
                                apellido: "", 
                                dni: 0, 
                                calle: "", 
                                numero: 0, 
                                provincia: "",
                                localidad: "" 
                            );

                            // Crear un nuevo objeto Juego con la info necesaria
                            Juego juego = new Juego
                            (
                                nombre: reader["Juego"].ToString(),
                                precio: 0, 
                                stock: 0, 
                                plataforma: "" 
                            );

                            // Crear un nuevo objeto Alquiler y agregarlo a la lista 
                            Alquiler alquiler = new Alquiler
                            (
                                juego,
                                cliente,
                                Convert.ToDateTime(reader["FechaAlquiler"]),
                                reader["Duracion"].ToString()
                            );

                            RegistrosAlquiler.Add(alquiler);
                        }
                    }
                }
            }

            Console.WriteLine("Registros de alquiler cargados desde la base de datos con éxito.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al cargar los registros de alquiler desde la base de datos: {ex.Message}");
        }
    }
    public bool CrearTablaAlquileres() //creo la tabla para almacenar los alquileres
    {
        try
        {
            string query = "CREATE TABLE Alquileres (Juego NVARCHAR(100), Cliente NVARCHAR(100), FechaAlquiler DATETIME, Duracion NVARCHAR(100))";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Tabla Alquileres creada con éxito.");
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear la tabla de alquileres en la base de datos: {ex.Message}");
            return false;
        }
    }
    public void RegistrarAlquiler(Alquiler alquiler)// registro los lquileres en la base de datos
    {
        try
        {
            // Agregar el alquiler a la lista de registros local
            RegistrosAlquiler.Add(alquiler);

            
            string insertQuery = "INSERT INTO Alquileres (Juego, Cliente, FechaAlquiler , Duracion) VALUES (@Juego, @Cliente, @FechaAlquiler , @Duracion)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    // Agregar parámetros
                    insertCommand.Parameters.AddWithValue("@Juego", alquiler.JuegoAlquilado.Nombre);
                    insertCommand.Parameters.AddWithValue("@Cliente", alquiler.ClienteQueAlquila.Nombre);
                    insertCommand.Parameters.AddWithValue("@FechaAlquiler", alquiler.FechaInicio);
                    insertCommand.Parameters.AddWithValue("@Duracion", alquiler.DuracionAlquiler);

                    // Ejecutar la consulta
                    insertCommand.ExecuteNonQuery();
                }
            }

            

            Console.WriteLine("Alquiler registrado con éxito.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al registrar el alquiler: {ex.Message}");
        }
    }

    public void DecrementarStock(string nombreJuego) // decremento el stock en la base de datos para mantenerlo actualizado
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string updateQuery = "UPDATE Juegos SET Stock = Stock - 1 WHERE Nombre = @Nombre";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    // Agregar parámetro
                    updateCommand.Parameters.AddWithValue("@Nombre", nombreJuego);

                    // Ejecutar la consulta de actualización
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Se decrementó el stock de {nombreJuego} en 1.");
                    }
                    else
                    {
                        Console.WriteLine($"No se encontró el juego con el nombre {nombreJuego}.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al decrementar el stock: {ex.Message}");
        }
    }

    public void RealizarAlquiler(Alquiler alquiler) // si tiene stock se realiza el alquiler y se actualiza el stock.
    {
        // Verificar si hay suficiente stock
        if (alquiler.JuegoAlquilado.Stock >= 1)
        {
   


            // Agregar el alquiler a la lista de registros
            RegistrarAlquiler(alquiler);

            // Actualizar el stock
            DecrementarStock(alquiler.JuegoAlquilado.Nombre);



            Console.WriteLine("Alquiler realizado con éxito.");
        }
        else
        {
            Console.WriteLine("No hay suficiente stock para realizar el alquiler.");
        }


    }

    public bool CrearTablaJuegosEnBaseDeDatos()//crea la tabla para guardar los juegos
    {
        try
        {
            string query = "CREATE TABLE Juegos (Nombre NVARCHAR(100), Precio DECIMAL, Stock INT, Plataforma NVARCHAR(50))";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear la tabla de juegos en la base de datos: {ex.Message}");
            return false;
        }
    }
    public void CargarJuegosDesdeBaseDeDatos()//guardo los juegos de la base de datos en la lista, asi se mantienen actualizdos
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Nombre, Precio, Stock, Plataforma FROM Juegos";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader.GetString(0);
                            decimal precio = reader.GetDecimal(1);
                            int stock = reader.GetInt32(2);
                            string plataforma = reader.GetString(3);

                            Juego juego = new Juego(nombre, precio, stock, plataforma);
                            juegos.Add(juego);
                        }
                    }
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al cargar juegos desde la base de datos: {ex.Message}");

        }
    }
    public void CargarJuegosEnBaseDeDatos()//cargo los juegos desde el archivo en la base de datos.
    {
        try
        {
            string[] lineas = File.ReadAllLines(rutaArchivoCSV);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');

                    if (datos.Length == 4)
                    {
                        string nombre = datos[0];

                        // Verificar si el juego ya existe en la base de datos
                        if (!JuegoExiste(connection, nombre))
                        {
                            decimal precio;
                            if (decimal.TryParse(datos[1], out precio))
                            {
                                int stock;
                                if (int.TryParse(datos[2], out stock))
                                {
                                    string plataforma = datos[3];

                                    // Utilizar parámetros en lugar de concatenar directamente en la cadena SQL
                                    string insertQuery = "INSERT INTO Juegos (Nombre, Precio, Stock, Plataforma) VALUES (@Nombre, @Precio, @Stock, @Plataforma)";

                                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                    {
                                        // Agregar parámetros
                                        insertCommand.Parameters.AddWithValue("@Nombre", nombre);
                                        insertCommand.Parameters.AddWithValue("@Precio", precio);
                                        insertCommand.Parameters.AddWithValue("@Stock", stock);
                                        insertCommand.Parameters.AddWithValue("@Plataforma", plataforma);

                                        // Ejecutar la consulta
                                        insertCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Error: El stock no es un número válido en la línea: {linea}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Error: El precio no es un número válido en la línea: {linea}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"El juego '{nombre}' ya existe en la base de datos. No se agregará duplicado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: La línea no tiene el formato esperado: {linea}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al cargar juegos en la base de datos: {ex.Message}");
        }
    }

    private bool JuegoExiste(SqlConnection connection, string nombre) //funcion para no sobrecargar los juegos y existentes en tl cso
    {
        // Verificar si el juego ya existe en la base de datos
        string existeQuery = "SELECT COUNT(*) FROM Juegos WHERE Nombre = @Nombre";

        using (SqlCommand existeCommand = new SqlCommand(existeQuery, connection))
        {
            existeCommand.Parameters.AddWithValue("@Nombre", nombre);
            int count = (int)existeCommand.ExecuteScalar();
            return count > 0;
        }
    }

}