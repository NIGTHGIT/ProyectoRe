using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using INICIO.ConexionSQ;
using System.Windows.Forms;

namespace INICIO.subMANUSConfigura.MenusInfo
{
    public partial class ModifycEmpresa : Form
    {
        public ModifycEmpresa()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private string no;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int i = this.Decrip.Text.Length;
            if(i > 500)
            {
                this.MOdifu.Enabled = false;
            }
            else
            {
                this.MOdifu.Enabled = true;
            }
        }

        private void ModifycEmpresa_Load(object sender, EventArgs e)
        {
            Conexion cone = new Conexion();
            string a = "SELECT * FROM dbo.Empresa";
            SqlCommand comando = new SqlCommand(a, cone.Conexifon());
            SqlDataReader re = comando.ExecuteReader();
            re.Read();

            this.Nombre.Text = re["NombreEmpresa"].ToString();
            this.Correo.Text = re["CorreoDeEmpresa"].ToString();
           
            this.Dirrecion.Text = re["DirreccionEmpresa"].ToString();
            this.Decrip.Text = re["Decricion"].ToString();
        }

        private void MOdifu_Click(object sender, EventArgs e)
        {

            Conexion cone = new Conexion();
            string a = $"UPDATE Empresa SET NombreEmpresa = '{this.Nombre.Text}',CorreoDeEmpresa = '{Correo.Text}',DirreccionEmpresa = '{Dirrecion.Text}',FechaDeCreacion = '{this.Fech.Value.ToString()}',Decricion = '{this.Decrip.Text}'";
            SqlCommand comando = new SqlCommand(a, cone.Conexifon());
            SqlDataReader re = comando.ExecuteReader();
            re.Read();
            MessageBox.Show("Se modifico");


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ViewEmpresa d = new ViewEmpresa();
            this.Close();
        }
    }
}
