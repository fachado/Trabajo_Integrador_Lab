using Entidades;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Ticket_final
{
    public partial class FormTicket : Form
    {
        public Alquiler alquiler;

        public FormTicket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MostrarInformacionAlquiler()
        {
            string informacionCompleta = alquiler.ObtenerInformacionCompleta();

            // cargo el label con la extesion de alquiler y toda la info.
            lblJuego.Text = informacionCompleta;
        }

        private void MostrarInfo_Click(object sender, EventArgs e)
        {
            //  un mensaje temporal mientras se genera el ticket
            lblTicketStatus.Text = "Generando ticket...";

            // Utilizo un hilo para simular la generación del ticket
            Thread thread = new Thread(() =>
            {
                // Simul una espera de generación de ticket
                Thread.Sleep(5000); // Simula 5 segundos de espera

                // Llamamos al método que simula la generación del ticket
                MostrarInformacionAlquiler();

                // Cuando haya terminado la generación del ticket, actualizamos la interfaz de usuario
                this.Invoke(new Action(() =>
                {
                    // Actualizamos el estado del ticket
                    lblTicketStatus.Text = "Ticket generado con éxito.";

                  
                    BaseDeDatos miBaseDeDatos = new BaseDeDatos();
                    miBaseDeDatos.RealizarAlquiler(alquiler);
                }));
            });

            // Iniciamos el hilo
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}