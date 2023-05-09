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
    public partial class Renunciar : Form
    {
        public Renunciar()
        {
           
            InitializeComponent();
            string query = "SELECT * FROM Emleados";

            // Crea un objeto SqlCommand
            ConexionSQ.conexionj.Conexion.Close();
            ConexionSQ.conexionj.Conexion.Open();

            SqlCommand command = new SqlCommand(query, ConexionSQ.conexionj.Conexion);

            // Crea un objeto SqlDataAdapter y llena un objeto DataTable con los resultados de la consulta SQL
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Enlaza los datos de la tabla al DataGridView
            dataGridView1.DataSource = table;


        }
        int mover1 = 0;
        int mover2 = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {

                mover1 = e.Y;
                mover2 = e.X;

            }
            else {
                Left = Left + (e.X - mover2);
                Top = Top + (e.Y  - mover1) ;
            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Empleado ddd = new Empleado();
            ddd.Show();
            ConexionSQ.conexionj.Conexion.Close();
        }

       
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {




            int id = int.Parse(textCedula.Text);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Emleados WHERE ID = @Id", ConexionSQ.conexionj.Conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@Id", id);
            DataTable table = new DataTable();
            adapter.Fill(table);



            if (table.Rows.Count > 0)
            {
                ConexionSQ.conexionj.Conexion.Close();
                ConexionSQ.conexionj.Conexion.Open();
                // Accede a la fila en la posición 0
                SqlCommand command = new SqlCommand("DELETE FROM Emleados WHERE Id = @Id", ConexionSQ.conexionj.Conexion);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();


                SqlCommand insertCommand = new SqlCommand("INSERT INTO UsuariosEliminados (Id, Nombre, Apellido , FechaEliminacion , Cedula , Edad , Sueldo , Renuncia) VALUES (@Id, @Nombre, @Apellido, GETDATE() , @Cedula , @Edad , @Sueldo , @Renuncia)", ConexionSQ.conexionj.Conexion);
                insertCommand.Parameters.AddWithValue("@Id", table.Rows[0]["Id"]);
                insertCommand.Parameters.AddWithValue("@Nombre", table.Rows[0]["Nombre"]);
                insertCommand.Parameters.AddWithValue("@Apellido", table.Rows[0]["Apellido"]);
                insertCommand.Parameters.AddWithValue("@Cedula", table.Rows[0]["Cedula"]);
                insertCommand.Parameters.AddWithValue("@Edad", table.Rows[0]["Edad"]);
                insertCommand.Parameters.AddWithValue("@Sueldo", table.Rows[0]["Salario"]);
                insertCommand.Parameters.AddWithValue("@Renuncia", textRenuncia.Text);

                insertCommand.ExecuteNonQuery();
                MessageBox.Show("se elimino");
                ConexionSQ.conexionj.Conexion.Close();
            }
            else
            {
                // El ID no existe en la tabla
                MessageBox.Show("El ID especificado no existe en la tabla.", "Error");
            }



            ///



            // 




        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userDelate ssss = new userDelate();
            ssss.Show();
            this.Close();
        }
    }
}
