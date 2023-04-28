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
    public partial class ViewEmpresa : Form
    {
        public ViewEmpresa()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ViewEmpresa_Load(object sender, EventArgs e)
        {
            Conexion cone = new Conexion();
            string a = "SELECT * FROM dbo.Empresa";
            SqlCommand comando = new SqlCommand(a,cone.Conexifon());
            SqlDataReader re = comando.ExecuteReader();
            re.Read();

            this.Nombre.Text = re["NombreEmpresa"].ToString();
            this.Correo.Text = re["CorreoDeEmpresa"].ToString();
            this.Fecha.Text = re["FechaDeCreacion"].ToString();
            this.Dirrecion.Text = re["DirreccionEmpresa"].ToString();
            this.info.Text = re["Decricion"].ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ModifycEmpresa f = new ModifycEmpresa();
            f.Show();
            this.Close();
        }
    }
}
