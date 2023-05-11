using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INICIO.Empleados

{
    public partial class userDelate : Form
    {
        public userDelate()
        {
            InitializeComponent();
            string query = "SELECT * FROM UsuariosEliminados";

            // Crea un objeto SqlCommand
            SqlCommand command = new SqlCommand(query, ConexionSQ.conexionj.Conexion);

            // Crea un objeto SqlDataAdapter y llena un objeto DataTable con los resultados de la consulta SQL
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void userDelate_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Empleado sss = new Empleado();
            sss.Show();
            this.Close();
        }
    }
}
