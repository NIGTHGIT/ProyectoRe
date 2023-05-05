using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INICIO.SubmMenuAlamcen.Stok
{
    public partial class ViewStok : Form
    {
        public ViewStok(int i)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = i;

        }

        private int ID;

        private void ViewStok_Load(object sender, EventArgs e)
        {
            PO.Text += $"_#{ID}";
            DateTime time = DateTime.UtcNow;
           // time.ToString("dd/MM/yyyy - h:mm");
            Fe = time.ToString("dd/MM/yyyy - h:mm"); ;
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand($"SELECT * FROM Stok WHERE ID = {ID}", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            RED.Read();
            Conte.Text = RED["Descrip"].ToString();
            Fecha.Text = $"Ultima actualizacion ( { RED["FechadefACTURA"] } )";

        }

        private string Fe;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand($"  UPDATE Stok set FechadefACTURA  = '{Fe}', Descrip = '{Conte.Text}' where ID = 2", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            RED.Read();
            MessageBox.Show("Se modifico completamente");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand($"DELETE Stok WHERE ID = {ID}", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            RED.Read();
            MessageBox.Show("Se elimino!!");
        }

        private void Conte_TextChanged(object sender, EventArgs e)
        {
            Modific.Enabled = true;
        }
    }
}
