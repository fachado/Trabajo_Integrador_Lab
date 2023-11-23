
using Entidades;
using Ticket_final;



namespace Carga_Cliente
{
    public partial class FormCliente : Form
    {

        public Juego JuegoSeleccionado { get; set; }
        public string DuracionAlquiler { get; set; }
        public string PlataformaSeleccionada { get; set; }

        public DateTime FechaInicio { get; set; }
        public FormCliente()
        {
            InitializeComponent();
        }


        private void InfoContinuar_Click(object sender, EventArgs e)
        {
            // Leer los datos del cliente desde los TextBox
            string nombre = NombreBox.Text;
            string apellido = ApellidoBox.Text;
            string dni = DniBox.Text;
            string calle = CalleBox.Text;
            string numero = NumeroBox.Text;
            string localidad = LocalidadBox.Text;
            string provincia = ProvinciaBox.Text;
            string mensajeError;
            //verifica los datos ingresados y continua
            if (VerificadorDatos.VerificarDatos(nombre, apellido, dni, calle, numero, localidad, provincia, out mensajeError))
            {
                Cliente nuevoCliente = new Cliente(nombre, apellido, int.Parse(dni), calle, int.Parse(numero), localidad, provincia);
                if (JuegoSeleccionado == null || nuevoCliente == null || FechaInicio == null || DuracionAlquiler == null)
                {
                    // Manejo del error: JuegoSeleccionado es nulo
                    Console.WriteLine("Error: El juego seleccionado es nulo.");
                    return;
                }
                Alquiler nuevoAlquiler = new Alquiler(JuegoSeleccionado, nuevoCliente, FechaInicio, DuracionAlquiler);
                if (nuevoAlquiler == null)
                {
                    // Manejo del error: JuegoSeleccionado es nulo
                    Console.WriteLine("Error: El juego seleccionado es nulo.");
                    return;
                }

                FormTicket ticket = new FormTicket();
                //le paso el alquiler al otro form
                ticket.alquiler = nuevoAlquiler;

                this.Close();

                ticket.Show();
                // Crear un objeto Cliente con los datos leídos // Todos los datos son válidos, continuar con el proceso.
            }
            else
            {
                // Alguno de los datos no es válido, mensajeError contiene el mensaje de error.
                MessageBox.Show($"Error: {mensajeError}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void FormCliente_Load(object sender, EventArgs e)
        {
            NombreBox.KeyPress += TextBox_KeyPressSoloLetras;
            ApellidoBox.KeyPress += TextBox_KeyPressSoloLetras;
            DniBox.KeyPress += TextBox_KeyPressLongitudMaxima;
            CalleBox.KeyPress += TextBox_KeyPressAlfanumerico;
            NumeroBox.KeyPress += TextBox_KeyPressLongitudMaxima;
            LocalidadBox.KeyPress += TextBox_KeyPressSoloLetras;
            ProvinciaBox.KeyPress += TextBox_KeyPressSoloLetras;
        }
        // Método para limitar TextBox a solo letras
        private void TextBox_KeyPressSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Método para limitar TextBox a solo números y controlar la longitud máxima
        private void TextBox_KeyPressLongitudMaxima(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limitar la longitud del texto
            if (textBox.Text.Length >= 8 && textBox == DniBox)
            {
                e.Handled = true;
            }
            else if (textBox.Text.Length >= 5 && textBox == NumeroBox)
            {
                e.Handled = true;
            }
        }

        // Método para limitar TextBox a caracteres alfanuméricos y controlar la longitud máxima
        private void TextBox_KeyPressAlfanumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Muestra un cuadro de diálogo de confirmación antes de cerrar el formulario

        }
    }
}
