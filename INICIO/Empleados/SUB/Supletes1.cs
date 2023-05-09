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
            else {
                MessageBox.Show("La cedua no existe");
            
            
            }
            ConexionSQ.conexionj.Conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                if (MessageBox.Show("quieres eliminar  el suplente", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {



                    int id = int.Parse(textid.Text);
                    ConexionSQ.conexionj.Conexion.Close();
                    ConexionSQ.conexionj.Conexion.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM suplentes WHERE Cedula = @Id", ConexionSQ.conexionj.Conexion);
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("se elimino");
                    ConexionSQ.conexionj.Conexion.Close();


                    textnombre.Text = "null";
                    textapellido.Text = "null";
                    TEXTEDAD.Text = "null";
                    TEXTEcedula.Text = "null";
                    textetelefono.Text = "null";
                    textpago.Text = "null";
                }
                else
                {


                }



            }
            catch (Exception) { }

        

    }
    }
}
