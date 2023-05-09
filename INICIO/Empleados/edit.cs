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
            else
            {
                panel10.Visible = false;
                PANELdesple1.Visible = false;
                panel5.Visible = true;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel10.Visible == false)
            {
                panel10.Visible = true;
                panel5.Visible = false;


            }
            else
            {


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
            string query = "SELECT * FROM Emleados WHERE Cedula=@Id";
            using (SqlCommand command = new SqlCommand(query, ConexionSQ.conexionj.Conexion))
            {
                command.Parameters.AddWithValue("@Id", textId.Text);

                try
                {
                    ConexionSQ.conexionj.Conexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxNombre.Text = reader["Nombre"].ToString();
                            textBoxApellido.Text = reader["Apellido"].ToString();
                            textBoxCorreo.Text = reader["Correo"].ToString();
                            textBoxCedula.Text = reader["Cedula"].ToString();
                            textBoxDirecion.Text = reader["Direcion"].ToString();
                            textBEDAD.Text = reader["Edad"].ToString();
                            textBoxTelefono.Text = reader["Telefono"].ToString();
                            textBoxsalario.Text = reader["Salario"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    ConexionSQ.conexionj.Conexion.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConexionSQ.conexionj.Conexion.Close();


            string query = "UPDATE Emleados SET Nombre=@Nombre,Apellido=@Apellido,Correo=@Correo,Cedula=@Cedula,Direcion=@Direcion,Edad=@Edad,Telefono=@Telefono,Salario=@Salario WHERE Cedula=@Cedula";
            using (SqlCommand command = new SqlCommand(query, ConexionSQ.conexionj.Conexion))
            {


                string ssss =  textBoxCedula.Text;

                command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                command.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
                command.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
                command.Parameters.AddWithValue("@Cedula", ssss.ToString());
                command.Parameters.AddWithValue("@Direcion", textBoxDirecion.Text);
                command.Parameters.AddWithValue("@Edad", textBEDAD.Text);
                command.Parameters.AddWithValue("@Telefono", textBoxTelefono.Text);
                command.Parameters.AddWithValue("@Salario", textBoxsalario.Text);
                command.Parameters.AddWithValue("@Id", textId.Text);

                try
                {
                    ConexionSQ.conexionj.Conexion.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Se guardó correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se realizó ninguna actualización");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    ConexionSQ.conexionj.Conexion.Close();
                }








            }
        }
    }
}
