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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
            ConexionSQ.conexionj.Conexion.Close();
        }
      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxApellido.Text) || string.IsNullOrEmpty(textBoxCorreo.Text) || string.IsNullOrEmpty(textBoxCedula.Text))
            {



                MessageBox.Show("campos no validos");
            }
            else {
                PANELdesple1.Visible = false;
                panel5.Visible = true;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel10.Visible == false) {
                panel10.Visible = true;
                panel5.Visible = false;
            
            
            } 
            else {
                

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (panel10.Visible == false)
            {
                panel10.Visible = true;
                panel5.Visible = false;


            }
            else
            {
                panel10.Visible = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand("select * from  Emleados where Cedula=@Id", ConexionSQ.conexionj.Conexion);
            comando.Parameters.AddWithValue("@Id",textId.Text);

            ConexionSQ.conexionj.Conexion.Open();
            SqlDataReader adatar = comando.ExecuteReader();
            if (adatar.Read()) {
                textBoxNombre.Text = adatar["Nombre"].ToString();
                textBoxApellido.Text = adatar["Apellido"].ToString();
                textBoxCorreo.Text = adatar["Correo"].ToString();
                textBoxCedula.Text = adatar["Cedula"].ToString();
                textBoxDirecion.Text = adatar["Direcion"].ToString();
                textBEDAD.Text = adatar["Edad"].ToString();
                textBoxTelefono.Text = adatar["Telefono"].ToString();
                textBoxsalario.Text = adatar["Salario"].ToString();






            }
            ConexionSQ.conexionj.Conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updat = "UPDATE Emleados SET Nombre=@Nombre,Apellido=@Apellido,Correo=@Correo,Cedula=@Cedula,Direcion=@Direcion,Edad=@Edad,Telefono=@Telefono,Salario=@Salario   where Id=@Id";
            ConexionSQ.conexionj.Conexion.Close();
            ConexionSQ.conexionj.Conexion.Open();
            SqlCommand comando = new SqlCommand(updat, ConexionSQ.conexionj.Conexion);


            comando.Parameters.AddWithValue("@Nombre",textBoxNombre.Text);
            comando.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
            comando.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
            comando.Parameters.AddWithValue("@Cedula", textBoxCedula.Text);
            comando.Parameters.AddWithValue("@Direcion", textBoxDirecion.Text);
            comando.Parameters.AddWithValue("@Edad", textBEDAD.Text);
            comando.Parameters.AddWithValue("@Telefono", textBoxTelefono.Text);
            comando.Parameters.AddWithValue("@Salario", textBoxsalario.Text);
            comando.Parameters.AddWithValue("@Id", textId.Text);


            comando.ExecuteNonQuery();


            ConexionSQ.conexionj.Conexion.Close();
            MessageBox.Show("se guardo");








        }
    }
}
