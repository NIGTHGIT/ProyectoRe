using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO.SubmMenuAlamcen.Stok
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        private void AgregarElemtos() {

            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand($" select * from Stok", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            Stoks1.Controls.Clear();
            while (RED.Read()) {

                Panel P = new Panel();
                P.Size = new Size(285, 72);
                P.BackColor = Color.DarkBlue;
                //lABEL id
                Label L = new Label();
                L.AutoSize = true;
                L.Text = "ID_#" + RED["ID"].ToString();
                L.Location = new Point(3, 0);
                L.Font = new Font("Microsoft Sans Seriz", 13);
                L.ForeColor = Color.White;
                P.Controls.Add(L);
                //nUTTON
                Label L2 = new Label();
                L2.AutoSize = true;
                L2.Font = new Font("Microsoft Sans Seriz", 13);
                L2.ForeColor = Color.White;
                L2.Text = RED["FechadefACTURA"].ToString();
                L2.Location = new Point(78, 15);
                P.Controls.Add(L2);
                //bBUTTON
                Button btn = new Button();
                btn.Size = new Size(86, 23);
                btn.Location = new Point(100, 41);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Text = "Ver mas..";
                btn.ForeColor = Color.White;
                btn.Name = RED["ID"].ToString();
                btn.Click += new EventHandler(btn_Click);
                btn.FlatAppearance.BorderColor = Color.Lime;
                P.Controls.Add(btn);
                Stoks1.Controls.Add(P);


            }           
        }

        private void btn_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            ViewStok vStk = new ViewStok(int.Parse(btn.Name));
            vStk.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand($"INSERT  into dbo.Stok (FechadefACTURA,Descrip)values('{Time.Value.ToString("dd/MM/yyyy - h:m")}','{Conte.Text}')", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            RED.Read();
            Conte.Clear();
            Conte.Focus();
            AgregarElemtos();
            MessageBox.Show("Se agrego");
           
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            AgregarElemtos();
        }
    }
}
