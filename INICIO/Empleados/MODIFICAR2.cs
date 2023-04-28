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
    public partial class MODIFICAR2 : Form
    {
        public MODIFICAR2()
        {
            InitializeComponent();

            ConexionSQ.conexionj.Conexion.Close();
            ConexionSQ.conexionj.Conexion.Open();
            SqlCommand comndo = new SqlCommand("select * from Emleados", ConexionSQ.conexionj.Conexion);
            SqlDataAdapter ddd = new SqlDataAdapter();

            ddd.SelectCommand = comndo;
            DataTable tabe = new DataTable();
            ddd.Fill(tabe);

            dataGridView1.DataSource = tabe;
            ConexionSQ.conexionj.Conexion.Close();
        }

       

        int ddx = 0;
        int ddy = 0;

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) {

                ddx = e.X;
                ddy = e.Y;



            }
            else
            {
                Left = Left + (e.X - ddx);
                Top = Top + (e.Y - ddy);



            }
        }

        private void MODIFICAR2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            Empleado ddd = new Empleado();
            ddd.Show();
            this.Close();
;        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;




            }
            else if (WindowState == FormWindowState.Maximized) {
                WindowState = FormWindowState.Normal;



            } else if (WindowState == FormWindowState.Maximized) {


                WindowState = FormWindowState.Normal;



            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
           


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Editar dddd = new Editar();
            dddd.Show();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        
    }
}
