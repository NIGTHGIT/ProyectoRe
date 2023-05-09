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
    public partial class SUAGRE : Form
    {
        public SUAGRE()
        {
            InitializeComponent();
        }

        private void SUAGRE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarnombre() == false){return;}
            if (validarApellido() == false){ return; }
            if (validaredad() == false){return;}
            if (validarpago() == false ){return;}
            if (validarTelefono() == false){ return;}
            if (validarCedula() == false){ return; }
         

            ConexionSQ.conexionj.Conexion.Close();
          


            string consultar = "insert into suplentes(Nombre,Apellido,Edad,pago,Telefono,Cedula) values(@Nombre,@Apellido,@Edad,@pago,@Telefono,@Cedula)";

            ConexionSQ.conexionj.Conexion.Open();

            SqlCommand commando = new SqlCommand(consultar, ConexionSQ.conexionj.Conexion);

            commando.Parameters.AddWithValue("@Nombre",textNombre.Text);
            commando.Parameters.AddWithValue("@Apellido",textApellido.Text);
            commando.Parameters.AddWithValue("@Edad",textEdad.Text);
            commando.Parameters.AddWithValue("@pago",textPAGO.Text);
            commando.Parameters.AddWithValue("@Cedula",textCedula.Text);
            commando.Parameters.AddWithValue("@Telefono",textTelefono.Text);
            commando.ExecuteNonQuery();
            MessageBox.Show("todo se guardo con exito");
            ConexionSQ.conexionj.Conexion.Close();









        }

       

        private bool validarCedula()
        {
            int edad;
            if (!int.TryParse(textCedula.Text, out edad) || textEdad.Text == "")
            {
                errorProvider1.SetError(textCedula, " solo numero");

                return false;

            }
            else
            {

                errorProvider1.SetError(textCedula, "");
                return true;

            }
        }

        private bool validarTelefono()
        {
            int edad;
            if (!int.TryParse(textTelefono.Text, out edad) || textTelefono.Text == "") {
                errorProvider1.SetError(textTelefono, " solo numero");

                return false;

            }
            else
            {

                errorProvider1.SetError(textTelefono, "");
                return true;

            }
        }

        private bool validarpago()
        {
            int edad;
            if (!int.TryParse(textPAGO.Text, out edad) || textPAGO.Text == "")
            {
                errorProvider1.SetError(textPAGO, " solo numero");

                return false;

            }
            else
            {

                errorProvider1.SetError(textPAGO, "");
                return true;

            }
        }

        private bool validaredad()
        {
            int edad;
            if (!int.TryParse(textEdad.Text, out edad) || textEdad.Text == "")
            {
                errorProvider1.SetError(textEdad, " solo numero");

                return false;

            }
            else
            {

                errorProvider1.SetError(textEdad, "");
                return true;

            }
        }

        private bool validarApellido()
        {
            if (string.IsNullOrEmpty(textApellido.Text))
            {


                errorProvider1.SetError(textApellido, " Introduse Apellido");



                return false;



            }
            else
            {
                errorProvider1.SetError(textApellido, "");

                return true;




            }
        }

        private bool validarnombre()
        {
            if (string.IsNullOrEmpty(textNombre.Text))
            {


                errorProvider1.SetError(textNombre," Introduse nombre");



                return false;



            }
            else
            {
                errorProvider1.SetError(textNombre, "");

                return true;




            }

          


        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            int edad;
            if (int.TryParse(textNombre.Text, out edad) || textNombre.Text == "")
            {
                errorProvider1.SetError(textNombre, " solo letra");


            }
            else
            {

                errorProvider1.SetError(textNombre, "");

            }
        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

            int edad;
            if (int.TryParse(textApellido.Text, out edad) || textApellido.Text == "")
            {
                errorProvider1.SetError(textApellido, " solo letra");


            }
            else
            {

                errorProvider1.SetError(textApellido, "");

            }
        }
    }
}
