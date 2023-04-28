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

namespace INICIO.SubMenusProducto
{
    public partial class ModifyConsul : Form
    {
        public ModifyConsul(string Codigo)
        {
            InitializeComponent();
            Co = Codigo;
            this.CenterToScreen();
        }
        private string Co;
        private void ModifyConsul_Load(object sender, EventArgs e)
        {


            Conexion C = new Conexion();
            string consukta = $"SELECT NombrePlatillo,PrecioProducto,ClasificacionPlantillo, PesoNeto,DescripcionProducto FROM Productos where CodigoProducto = '{Co}'";
            SqlCommand a = new SqlCommand(consukta, C.Conexifon());
            SqlDataReader redi3 = a.ExecuteReader();
            if (redi3.Read())
            {
                this.Nombre.Text = redi3["NombrePlatillo"].ToString();
                this.Precio.Text = redi3["PrecioProducto"].ToString();
                this.ClasifiP.Text = redi3["ClasificacionPlantillo"].ToString();
                this.Pesoneo.Text = redi3["PesoNeto"].ToString();
                this.Descip.Text = redi3["DescripcionProducto"].ToString();

            }
            else
            {
                MessageBox.Show("No se puedo cargar el producto");
            }




            C.Close();




        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var i = Descip.Text.Length;
            if( i > 500)
            {
                Count.ForeColor = Color.Red;
                this.Modific.Enabled = false;
            }
            else
            {
                Count.ForeColor = Color.Black;
                this.Modific.Enabled = true;
            }
            Count.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion C = new Conexion();
            string consukta = $"UPDATE Productos set NombrePlatillo = '{this.Nombre.Text}', PrecioProducto = {int.Parse(this.Precio.Text)}, ClasificacionPlantillo = '{ClasifiP.Text}', PesoNeto = {int.Parse(Pesoneo.Text)}, DescripcionProducto = '{this.Descip.Text}' where CodigoProducto = '{Co}'";
            SqlCommand a = new SqlCommand(consukta, C.Conexifon());
            SqlDataReader redi2 = a.ExecuteReader();
            redi2.Read();
            MessageBox.Show("Se modifico Correctamente");
           
            
            

            C.Close();
        }
    }
}