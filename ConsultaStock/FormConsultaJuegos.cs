using Entidades;
using System.Windows.Forms;
namespace ConsultaStock
{
    public partial class FormConsultaJuegos : Form
    {
        private BaseDeDatos baseDeConsulta;
        private List<Juego> juegos; 

        public FormConsultaJuegos()
        {
            InitializeComponent();
            baseDeConsulta = new BaseDeDatos();

        }

        private void FormConsultaJuegos_Load(object sender, EventArgs e)
        {

            dataGridViewJuegos.AutoGenerateColumns = false; // Deshabilitar la generación automática de columnas
            juegos = baseDeConsulta.ObtenerJuegos();

            // Configuro manualmente las columnas del DataGridView
            dataGridViewJuegos.Columns.Add("Nombre", "nombre");
            dataGridViewJuegos.Columns.Add("Precio", "Precio");
            dataGridViewJuegos.Columns.Add("Stock", "Stock");
            dataGridViewJuegos.Columns.Add("Plataforma", "Plataforma");
           

            foreach (Juego juego in juegos)
            {
                //asigno una linea con la info del juego por cada uno
                dataGridViewJuegos.Rows.Add(juego.Nombre, juego.Precio, juego.Stock, juego.Plataforma);
            }

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            // Cierra el formulario de consulta
            this.Close();


        }

    }
}


