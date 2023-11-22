using Entidades;

namespace ConsultaAlquileres
{
    public partial class FormConsultaAlquileres : Form
    {
        private List<Alquiler> alquileres; 
        private BaseDeDatos baseDeConsultaAlquiler;
        public FormConsultaAlquileres()
        {
            InitializeComponent();
            baseDeConsultaAlquiler = new BaseDeDatos();

        }


        private void FormConsultaAlquileres_Load(object sender, EventArgs e)
        {
            dataGridViewAlquileres.AutoGenerateColumns = false; // Deshabilitar la generación automática de columnas
            alquileres = baseDeConsultaAlquiler.ObtenerAlquileres();

            // Configuro manualmente las columnas del DataGridView
            dataGridViewAlquileres.Columns.Add("JuegoAlquilado", "JuegoAlquilado");
            dataGridViewAlquileres.Columns.Add("ClienteQueAlquila", "ClienteQueAlquila");
            dataGridViewAlquileres.Columns.Add("FechaInicio", "FechaInicio");
            dataGridViewAlquileres.Columns.Add("DuracionAlquiler", "DuracionAlquiler");
            
            Console.WriteLine(alquileres.Count);

            foreach (Alquiler alquiler in alquileres)
            {
                //asigno una linea con la info por cada alquiler en la lista
                dataGridViewAlquileres.Rows.Add(alquiler.JuegoAlquilado.Nombre, alquiler.ClienteQueAlquila.Nombre, alquiler.FechaInicio, alquiler.DuracionAlquiler);
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}