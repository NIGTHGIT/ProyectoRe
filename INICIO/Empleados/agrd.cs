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
    public partial class agrd : Form
    {
        public agrd()
        {
            InitializeComponent();

            ConexionSQ.conexionj.Conexion.Open();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void agrd_MouseMove(object sender, MouseEventArgs e)
        {
            int prox = 0;
            int proy = 0;
            if (e.Button != MouseButtons.Left)
            {
                prox = e.X;
                proy = e.Y;


            }
            else
            {

                Left = Left + (e.X - prox);
                Top = Top + (e.Y - proy);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comans = new SqlCommand("Select * from Empres ", ConexionSQ.conexionj.Conexion);
            ConexionSQ.conexionj.Conexion.Close();
            ConexionSQ.conexionj.Conexion.Open();
            SqlDataReader letor = comans.ExecuteReader();
            while (letor.Read())
            {

                comboBox1.Items.Add(letor.GetString(1));
            }
        }
    }
}
