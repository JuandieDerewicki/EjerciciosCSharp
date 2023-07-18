using System.Data;
using System.Data.SqlClient;

namespace PruebasDataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable dt = GetClientes();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";

            lblIdData.DataBindings.Add("Text", dt, "ID"); // Text es lo que queremos cambiar cada vez que estoy parado en un registro diferente, Id es el valor del campo
            txtId.DataBindings.Add("Text", dt, "ID");

            //dataGridView1.DataSource = dt; // Mostrar toda la tabla sin ningun filtro
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public DataTable GetClientes()
        {
            SqlConnection cn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand("Select * from Cliente", cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            // Llenar DataTable
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Cliente");
            return ds.Tables["Cliente"];
        }

        private string getConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bocaj\source\repos\Programacion III\PruebasDataBinding\PruebaBD.mdf;Integrated Security=True";
        }
    }
}