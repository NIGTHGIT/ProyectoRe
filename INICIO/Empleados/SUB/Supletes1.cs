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

namespace INICIO.Empleados.SUB
{
    public partial class Supletes1 : Form
    {
        public Supletes1()
        {
            InitializeComponent();
            ConexionSQ.conexionj.Conexion.Close();
            ConexionSQ.conexionj.Conexion.Open();
            SqlCommand comndo = new SqlCommand("select * from suplentes", ConexionSQ.conexionj.Conexion);
            SqlDataAdapter ddd = new SqlDataAdapter();

            ddd.SelectCommand = comndo;
            DataTable tabe = new DataTable();
            ddd.Fill(tabe);

            dataGridView1.DataSource = tabe;
            ConexionSQ.conexionj.Conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand("select * from  suplentes where Cedula=@Id", ConexionSQ.conexionj.Conexion);
            comando.Parameters.AddWithValue("@Id", textid.Text);
            ConexionSQ.conexionj.Conexion.Open();
            SqlDataReader adatar = comando.ExecuteReader();
            if (adatar.Read())
            {
                 textnombre.Text = adatar["Nombre"].ToString();
                 textapellido.Text = adatar["Apellido"].ToString();
                 TEXTEDAD.Text = adatar["Edad"].ToString();
                TEXTEcedula.Text = adatar["Cedula"].ToString();
                textetelefono.Text = adatar["Telefono"].ToString();
                textpago.Text = adatar["pago"].ToString();










            }
            ConexionSQ.conexionj.Conexion.Close();
        }
    }
}
