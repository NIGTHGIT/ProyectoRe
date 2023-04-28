using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using INICIO.ConexionSQ;
using System.Threading.Tasks;
using System.Windows.Forms;
using INICIO.subMANUSConfigura.MenusInfo;

namespace INICIO.subMANUSConfigura
{
    public partial class InfOUser : Form
    {
        public InfOUser()
        {
            InitializeComponent();
         
        }
        private string correoSave;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es para Modificar");
        }

        private void InfOUser_Load(object sender, EventArgs e)
        {
            //Conexion CON = new Conexion();
            //string consulta = "SELECT * FROM USER"
            //SqlCommand comadno = new SqlCommand();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se modifica el restaurante");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            ViewEmpresa d = new ViewEmpresa();
            d.Show();

        }
    }
}
