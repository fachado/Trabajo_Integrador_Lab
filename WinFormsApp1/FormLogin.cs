using Carga_Cliente;
using ConsultaAlquileres;
using ConsultaStock;
using WinFormsApp3;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }



        private void BotonContinuar_click(object sender, EventArgs e)
        {
            //metodo para que sea un usuario y contrse�a valido
            if (Contrase�aUsuario.Text == "Contrase�a" || NombreUsuario.Text == "Usuario" || (NombreUsuario.Text.Length < 4) || (Contrase�aUsuario.Text.Length < 4))
            {

            }
            else
            {
                FormPrincipal formprincipal = new FormPrincipal();
                // Mostrar el formulario FormCliente
                this.Hide();
                formprincipal.Show();


            }
        }

        // metodos para mostrar usuario y contrase�a  
        private void NombreUsuario_Enter(object sender, EventArgs e)
        {
            if (NombreUsuario.Text == "Usuario")
            {
                NombreUsuario.Text = "";

            }
        }

        private void NombreUsuario_Leave(object sender, EventArgs e)
        {
            if (NombreUsuario.Text == "")
            {
                NombreUsuario.Text = "Usuario";

            }
        }

        private void Contrase�aUsuario_Enter(object sender, EventArgs e)
        {
            if (Contrase�aUsuario.Text == "Contrase�a")
            {
                Contrase�aUsuario.Text = "";
                Console.WriteLine("");
            }
        }

        private void Contrase�aUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Contrase�aUsuario.Text))
            {
                Contrase�aUsuario.Text = "Contrase�a";
            }
        }


        //evento para que no se usen caracteres especiales y se respee la longitud maxima
        private void Contrase�aUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                // Permitir la tecla de retroceso
                return;
            }

            // Verificar si la tecla es una letra o un n�mero y si la longitud es menor o igual a 8
            if ((!char.IsLetterOrDigit(e.KeyChar)) || (Contrase�aUsuario.Text.Length >= 8))
            {
                // Bloquear la tecla presionada
                e.Handled = true;
            }
        }
        //evento para que no se usen caracteres especiales y se respee la longitud maxima

        private void NombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                // Permitir la tecla de retroceso
                return;
            }

            // Verificar si la tecla es una letra o un n�mero y si la longitud es menor o igual a 8
            if ((!char.IsLetterOrDigit(e.KeyChar)) || (NombreUsuario.Text.Length >= 8))
            {
                // Bloquear la tecla presionada
                e.Handled = true;
            }
        }
        //botones de consultas
        private void BotonStock_Click(object sender, EventArgs e)
        {
            FormConsultaJuegos formconsultajuegos = new FormConsultaJuegos();
            formconsultajuegos.Owner = this;
            formconsultajuegos.FormClosed += (s, args) => this.Show(); // evento para volver al form anterior
            this.Hide();

            formconsultajuegos.Show();
        }

        private void BotonPedidos_Click(object sender, EventArgs e)
        {
            FormConsultaAlquileres formconsultalquileres = new FormConsultaAlquileres();
            formconsultalquileres.Owner = this;
            formconsultalquileres.FormClosed += (s, args) => this.Show();// evento para volver al form anterior
            this.Hide();
            formconsultalquileres.Show();
        }
    }
}