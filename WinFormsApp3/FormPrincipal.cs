using Carga_Cliente;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using Entidades;

namespace WinFormsApp3
{
    public partial class FormPrincipal : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private BaseDeDatos baseDeDatos;
        public Juego JuegoSeleccionado;

        private string duracionSeleccionada;
        private string plataformaSeleccionada;
        private DateTime horaActual = DateTime.Now;

        public FormPrincipal()
        {
            InitializeComponent();

            baseDeDatos = new BaseDeDatos();
            CargarDatos();
        }



        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // diseño del form 
            this.BackgroundImage = Pantalla_principal.Properties.Resources.fondopiola;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            barramenu.BackgroundImage = Pantalla_principal.Properties.Resources.fotobarra;
            barramenu.BackgroundImageLayout = ImageLayout.Stretch;
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath.AddEllipse(0, 0, botoncontinuar.Width, botoncontinuar.Height);
            botoncontinuar.Region = new Region(buttonPath);
            botonsalida.Region = new Region(buttonPath);
            botonsalida.BackgroundImage = Pantalla_principal.Properties.Resources.botonsalida;
            botonsalida.BackgroundImageLayout = ImageLayout.Stretch;
            botoncontinuar.BackgroundImage = Pantalla_principal.Properties.Resources.boton1;
            botoncontinuar.BackgroundImageLayout = ImageLayout.Stretch;
            // diseño del form 

            //timer para mostrar hora
            timer1.Start();
        }


        private void CargarDatos()
        {
            List<Juego> juegos = baseDeDatos.ObtenerJuegos();

            // Llenar ComboBox de juegos
            foreach (Juego juego in juegos)
            {
                comboBoxJuegos.Items.Add(juego.Nombre);
            }

            // Llenar ComboBox de duración
            comboBoxDuracion.Items.AddRange(new string[] { "1 día", "7 días", "1 mes" });


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Obtener la hora actual

            // Establecer el texto del Label para mostrar la hora actual
            labelHora.Text = "Hora actual: " + horaActual.ToLongTimeString();
        }

        private void botoncontinuar_MouseLeave_1(object sender, EventArgs e)
        {
            // Restaura el fondo o el color del botón cuando el cursor sale 
            botoncontinuar.FlatAppearance.BorderSize = 0;

        }

        private void botoncontinuar_MouseEnter(object sender, EventArgs e)
        {

            botoncontinuar.FlatAppearance.BorderColor = Color.DarkBlue; // Restaura el color del borde
            botoncontinuar.FlatAppearance.BorderSize = 2;

        }


        private void botonsalida_MouseEnter(object sender, EventArgs e)
        {
            botonsalida.FlatAppearance.BorderColor = Color.DarkBlue; // Restaura el color del borde
            botonsalida.FlatAppearance.BorderSize = 2;
        }

        private void botonsalida_MouseLeave(object sender, EventArgs e)
        {
            botonsalida.FlatAppearance.BorderSize = 0;

        }

        private void botoncontinuar_Click(object sender, EventArgs e)
        {
            //si los combobox esta llenos continuar.
            if (!EsControlVacio(comboBoxPlataforma) && !EsControlVacio(comboBoxDuracion) && !EsControlVacio(comboBoxJuegos))
            {


                FormCliente Carga_Cliente = new FormCliente();
                if (JuegoSeleccionado != null)
                {
                    Carga_Cliente.JuegoSeleccionado = JuegoSeleccionado;
                    // Asignar otros valores...
                }
                else
                {
                    // Manejar el caso en el que JuegoSeleccionado es null
                    Console.WriteLine("Error: JuegoSeleccionado es null en FormPrincipal.");
                }
                Carga_Cliente.DuracionAlquiler = duracionSeleccionada;
                Carga_Cliente.PlataformaSeleccionada = plataformaSeleccionada;
                Carga_Cliente.FechaInicio = horaActual;

                // Ocultar el formulario principal
                this.Close();

                // Mostrar el nuevo formulario
                Carga_Cliente.ShowDialog();
            }
            else
            {
                // Muestra un mensaje de error si alguno de los ComboBox está vacío
                MessageBox.Show("Todos los ComboBox deben tener un elemento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }
        //generic para verificar combobox vacios o nulos
        private bool EsControlVacio<T>(T control) where T : ComboBox
        {
            return control.SelectedItem == null || string.IsNullOrWhiteSpace(control.SelectedItem.ToString());
        }
        private void muevepanal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void botonsalida_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres salir?", "Confirmación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", cerrar la aplicación
                Application.Exit();
            }
            // Si elige "No", no hacer nada y continuar con la aplicación abierta
        }

        private void comboBoxJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpio la plataforma, para agregar solo la disponible
            comboBoxPlataforma.Items.Clear();

            string nombreSeleccionado = comboBoxJuegos.SelectedItem.ToString();
            JuegoSeleccionado = baseDeDatos.ObtenerJuegos().FirstOrDefault(j => j.Nombre == nombreSeleccionado); //lambda busca el juego en la lista por el nombre sleccionado y lo guarda

            if (JuegoSeleccionado != null)
            {
                //guarda la plataforma disponible para el juego seleccionado anteriormente
                comboBoxPlataforma.Items.Add(JuegoSeleccionado.Plataforma);

                // Seleccionar la plataforma por defecto
                comboBoxPlataforma.SelectedIndex = 0;


            }
            else
            {
                // Manejar el caso en el que juegoSeleccionado es null
                Console.WriteLine("Error: juegoSeleccionado es null en FormPrincipal.");
            }


        }
        //guardo la plataforma
        private void comboBoxPlataforma_SelectedIndexChanged(object sender, EventArgs e)
        {
            plataformaSeleccionada = comboBoxPlataforma.SelectedItem.ToString();
        }

        private void comboBoxDuracion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBoxDuracion.SelectedItem.ToString())
            {
                case "1 día":
                    duracionSeleccionada = "1 día";
                    break;
                case "7 días":
                    duracionSeleccionada = "7 días";
                    break;
                case "1 mes":
                    duracionSeleccionada = "1 mes"; 
                    break;
                default:
                    duracionSeleccionada = "";
                    break;
            }
        }
    }
}