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
    public partial class EMLEADOW : Form
    {
        public EMLEADOW()
        {
            InitializeComponent();
           

        }




   

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string Nombre = textNombre.Text;
                string Apellido = textApellido.Text;


                string Direcion = textDirecion.Text;
                string Postal = textEdad.Text;



                var valid = true;

                if (String.IsNullOrWhiteSpace(Nombre) || String.IsNullOrWhiteSpace(Apellido) || string.IsNullOrWhiteSpace(Direcion) || string.IsNullOrWhiteSpace(Postal))
                {

                    valid = false;

                    MessageBox.Show("NO VALIDO REVISE EL TEXTO");

                    if (textNombre.Text == "")
                    {
                        errorProvider1.SetError(textNombre, "introsusca su nombre");
                        textNombre.Focus();
                        return;



                    }
                    errorProvider1.SetError(textNombre, "");

                    if (textApellido.Text == "")
                    {
                        errorProvider1.SetError(textApellido, "introsusca apellido");
                        textApellido.Focus();
                        return;



                    }


                    errorProvider1.SetError(textApellido, "");

                    if (textDirecion.Text == "")
                    {
                        errorProvider1.SetError(textDirecion, "introsusca su direcion");
                        textDirecion.Focus();
                        return;



                    }
                    errorProvider1.SetError(textDirecion, "");



                    if (textEdad.Text == "")
                    {
                        errorProvider1.SetError(textEdad, "introsusca su postal");
                        textEdad.Focus();
                        return;



                    }
                    errorProvider1.SetError(textEdad, "");





                }

                //comiensa a validar si es falo o verdadero

                if (valid)
                {


                    valid = true;


                    if (valodaredad() == false)
                    {
                        return;
                    }
                    if (validarcombox() == false)
                    {
                        return;

                    }

                    if (validarcedula() == false)
                    {
                        return;
                    }


                    //sssss


                    // Obtener la edad de la persona desde un TextBox
                    int edad = Convert.ToInt32(textEdad.Text);
                    if (textCedula.Text == "")
                    {


                    }


                    else if (textCedula.MaxLength == 11)
                    {
                        // Validar si la persona es mayor o igual a 18 y menor o igual a 99 años
                        if (edad >= 18 && edad <= 99)
                        {




                            ////
                            // Asignar el valor del TextBox a una variable
                            string miUsuario = textCedula.Text;

                            // Crear la consulta SQL para buscar el usuario en la tabla
                            string query = "SELECT COUNT(*) FROM Emleados WHERE Cedula = @Cedula";

                            // Crear el objeto SqlCommand con la consulta SQL y la conexión a la base de datos
                            ConexionSQ.conexionj.Conexion.Close();

                            ConexionSQ.conexionj.Conexion.Open();
                            SqlCommand cmd = new SqlCommand(query, ConexionSQ.conexionj.Conexion);
                            cmd.Parameters.AddWithValue("@Cedula", miUsuario);

                            // Ejecutar la consulta y obtener el recuento de filas
                            int count = (int)cmd.ExecuteScalar();

                            // Verificar si el usuario ya existe y mostrar un mensaje en el TextBox
                            if (count > 0)
                            {
                                MessageBox.Show("El usuario ya existe en la tabla.");


                            }


                            else
                            {

                                panel1DE.Visible = false;
                                panel2.Visible = true;

                            }

                            ///


                        }
                        else if (edad > 99)
                        {
                            MessageBox.Show(textEdad, "Lo siento, no se aplica para personas mayores de 99 años.");

                        }
                        else
                        {
                            MessageBox.Show(textEdad, "Lo siento, debes ser mayor de 18 años para aplicar.");

                        }



                    }


















                }





            }
            catch
            {
            


                MessageBox.Show(" no exsite ninguna cedula en la base de datos o por favor inserte 3 cedula para validar la informacion", "se pede solucionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
             

            }








        }

        private bool valodaredad()
        {
            int edad;

            if (!int.TryParse(textEdad.Text, out edad) || textEdad.Text == "")
            {

                errorProvider1.SetError(textEdad, "solo numeros");

                return false;
            }
            else
            {
                errorProvider1.SetError(textEdad, "");
                return true;
            }
        }

        private bool validarcedula()
        {
            int Edad;

            if (textCedula.MaxLength <= 10)
            {
                errorProvider1.SetError(textCedula, "solo numeros");
                return false;


            }
            else if (textCedula.MaxLength == 11)
            {
                errorProvider1.SetError(textCedula, "");







                return true;
            }
            else
            {
                errorProvider1.SetError(textCedula, "");
                return true;

            }

        }

        private bool validarcombox()
        {
            if (string.IsNullOrEmpty(comboTrabajo.Text))
            {
                errorProvider1.SetError(comboTrabajo, "ingrese un traabajo");
                return false;


            }
            else
            {
                errorProvider1.SetError(comboTrabajo, "");
                return true;
            }
        }

       
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1DE.Visible = false;
            panel2.Visible = true;






        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            


            textBoxtelefono.MaxLength =10;



          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {
            string ddsd = "/500";
            int ddd = texboxdec.Text.Length   ;
            dddd.Text = ddd.ToString() + ddsd.ToString();



            label3.Text = ddd.ToString();
                   dddd.ForeColor = Color.Black;




            try {
                if (texboxdec.Text.Length > 500)
                {



                    dddd.ForeColor = Color.Red;





                }


            }
            catch (Exception) {
                MessageBox.Show("maximo valor alcansado" +
                    "");
            
            
            
            }

        }

        private void button4_Click(object sender, EventArgs e)

        {
            try {
                string consultar = "insert into Emleados(Nombre,Apellido,Cedula,Direcion,Edad,Trabajo,Telefono,LICENCIDEcondusir,direciondeenvio,Banco,Correo,salario, Descricion) values(@Nombre,@Apellido,@Cedula,@Direcion,@Edad,@Trabajo,@Telefono,@LICENCIDEcondusir,@direciondeenvio,@Banco,@Correo,@salario, @Descricion)";

                ConexionSQ.conexionj.Conexion.Open();

                SqlCommand commando = new SqlCommand(consultar, ConexionSQ.conexionj.Conexion);

                commando.Parameters.AddWithValue("@Nombre", textNombre.Text);
                commando.Parameters.AddWithValue("@Apellido", textNombre.Text);
                commando.Parameters.AddWithValue("@Cedula", textCedula.Text);
                commando.Parameters.AddWithValue("@Direcion", textDirecion.Text);
                commando.Parameters.AddWithValue("@Edad", textEdad.Text);
                commando.Parameters.AddWithValue("@Trabajo", comboTrabajo.SelectedItem.ToString());
                commando.Parameters.AddWithValue("@Telefono", textBoxtelefono.Text);
                commando.Parameters.AddWithValue("@LICENCIDEcondusir", textLicncia.Text);
                commando.Parameters.AddWithValue("@direciondeenvio", textBoXDirecion.Text);
                commando.Parameters.AddWithValue("@Banco", texcbanco.SelectedItem.ToString());
                commando.Parameters.AddWithValue("@Correo", TextCorreo.Text);
                commando.Parameters.AddWithValue("@salario", comboBxsalario.SelectedItem.ToString());
                commando.Parameters.AddWithValue("@Descricion", textDirecion.Text);
                commando.ExecuteNonQuery();
                MessageBox.Show("se guardo");


















                panel4.Visible = true;
                panel3.Visible = false;


            }
            catch (Exception) {
                MessageBox.Show("Algo salio mal");




                
            
            
            
            
            
            
            
            
            
            
            
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
   
            try {
               
                if (string.IsNullOrEmpty(textBoxtelefono.Text) || string.IsNullOrEmpty(textLicncia.Text) || string.IsNullOrEmpty(textBoXDirecion.Text) || string.IsNullOrEmpty(TextCorreo.Text))
                {





                  



                    if (textBoXDirecion.Text.Trim() == "")
                    {
                        errorProvider1.SetError(textBoXDirecion, "no introdusido");
                        textBoXDirecion.Focus();
                        return;



                    }
                    errorProvider1.SetError(textBoXDirecion, "");


                    MessageBox.Show("cambos invalido");




                }
                else
                {
                    panel2.Visible = false;
                    panel3.Visible = true;


                  

                }



            }
            catch (Exception) {




            }
            
        }

        private void textBoxCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EMLEADOW_Load(object sender, EventArgs e)
        {
            ///CARGAR COMBOBOX TRABAJO

            SqlCommand comans = new SqlCommand("Select * from Empres ", ConexionSQ.conexionj.Conexion);
            ConexionSQ.conexionj.Conexion.Close();
            ConexionSQ.conexionj.Conexion.Open();
            SqlDataReader letor = comans.ExecuteReader();
            while (letor.Read())
            {

                comboTrabajo.Items.Add(letor.GetString(1));
            }
          

            ///

            ///combobox salario


           
            ///
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBxsalario_Validated(object sender, EventArgs e)
        {

        }

        private void comboBxsalario_Click(object sender, EventArgs e)
        {
            ///combobox salario

            SqlCommand comado = new SqlCommand("select * from Sueldo", ConexionSQ.conexionj.Conexion);
            ConexionSQ.conexionj.Conexion.Close();
            ConexionSQ.conexionj.Conexion.Open();

            SqlDataReader letor2 = comado.ExecuteReader();


            if (comboTrabajo.SelectedItem.ToString() == "Mesera")
            {
                while (letor2.Read())
                {
                    comboBxsalario.Items.Add(letor2.GetString(1));




                }



            }

           





            if (comboTrabajo.SelectedItem.ToString() == "Conserje")
            {
                while (letor2.Read())
                {
                    comboBxsalario.Items.Add(letor2.GetString(2));




                }



            }

        















            if (comboTrabajo.SelectedItem.ToString() == "Chef")
            {
                while (letor2.Read())
                {
                    comboBxsalario.Items.Add(letor2.GetString(3));




                }



            }

           











            if (comboTrabajo.SelectedItem.ToString() == "Personal de servicio")
            {
                while (letor2.Read())
                {
                    comboBxsalario.Items.Add(letor2.GetString(4));




                }



            }

          





            if (comboTrabajo.SelectedItem.ToString() == "Cocineros")
            {

              
                while (letor2.Read())
                {
                    comboBxsalario.Items.Add(letor2.GetString(5));




                }



            }

           





            if (comboTrabajo.SelectedItem.ToString() == "Anfitrión")
            {
                while (letor2.Read())
                {
                    comboBxsalario.Items.Add(letor2.GetString(6));




                }



            }

         














            if (comboTrabajo.SelectedItem.ToString() == "Bartender")
            {
                
                while (letor2.Read())
                {
                    comboBxsalario.Items.Add(letor2.GetString(7));




                }



            }
            ConexionSQ.conexionj.Conexion.Close();

         
            ///
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textCedula_TextChanged(object sender, EventArgs e)
        {
            textCedula.MaxLength = 11;

        }

        private void textEdad_TextChanged(object sender, EventArgs e)
        {
            textEdad.MaxLength = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string consultar = "insert into Emleados(Nombre,Apellido,Cedula,Direcion,Edad,Trabajo,Telefono,LICENCIDEcondusir,direciondeenvio,Banco,Correo,salario, Descricion) values(@Nombre,@Apellido,@Cedula,@Direcion,@Edad,@Trabajo,@Telefono,@LICENCIDEcondusir,@direciondeenvio,@Banco,@Correo,@salario, @Descricion)";

            ConexionSQ.conexionj.Conexion.Close();

            SqlCommand commando = new SqlCommand(consultar, ConexionSQ.conexionj.Conexion);
            ConexionSQ.conexionj.Conexion.Open();

            commando.Parameters.AddWithValue("@Nombre", "randon");
            commando.Parameters.AddWithValue("@Apellido","randon");
            commando.Parameters.AddWithValue("@Cedula", "03231232312");
            commando.Parameters.AddWithValue("@Direcion", "randon");
            commando.Parameters.AddWithValue("@Edad", 11);
            commando.Parameters.AddWithValue("@Trabajo", "randon");
            commando.Parameters.AddWithValue("@Telefono",111);
            commando.Parameters.AddWithValue("@LICENCIDEcondusir","randon");
            commando.Parameters.AddWithValue("@direciondeenvio", 111);
            commando.Parameters.AddWithValue("@Banco", "RANDON");
            commando.Parameters.AddWithValue("@Correo", "randon");
            commando.Parameters.AddWithValue("@salario", 111);
            commando.Parameters.AddWithValue("@Descricion", "randon");
            commando.ExecuteNonQuery();
            MessageBox.Show("se guardo");


        }
    }
}
