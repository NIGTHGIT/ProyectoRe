using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INICIO.subMANUSConfigura.AreaAndMESA
{
    public partial class MesaAmdArea1 : Form
    {
        public MesaAmdArea1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.AR.Text == "")
            {
                MessageBox.Show("Un campo esta vacio");
            }
            else
            {

                ConexionSQ.Conexion con = new ConexionSQ.Conexion();
                string conman = $"INSERT INTO dbo.Areas (NombredErea,Mesasactuales)values('{AR.Text}',0)";
                SqlCommand comando = new SqlCommand(conman, con.Conexifon());
                SqlDataReader re = comando.ExecuteReader();
                re.Read();
                MessageBox.Show("Se agrego una nueva area, recargue la pagina");
                this.Refresh();
            }
        }

        private void MesaAmdArea1_Load(object sender, EventArgs e)
        {
            ConexionSQ.Conexion con = new ConexionSQ.Conexion();
            string conman = $"SELECT * FROM Areas";
            SqlCommand comando = new SqlCommand(conman, con.Conexifon());
            SqlDataReader re = comando.ExecuteReader();
            while (re.Read())
            {
                ComboArea.Items.Add(re["NombredErea"].ToString());
                comboBoxArea.Items.Add(re["NombredErea"].ToString());

                Panel p = new Panel();
                p.Size = new Size(221, 124);
                p.BackColor = Color.DarkRed;
                //noMBRE
                Label L = new Label();
                L.Font = new Font("Arial", 18);
                L.ForeColor = Color.White;
                L.Location = new Point(9, 13);
                L.AutoSize = true;
                L.Text = re["NombredErea"].ToString();
                p.Controls.Add(L);
                //Cpacidad
                Label L1 = new Label();
                L1.Font = new Font("Arial", 9);
                L1.Location = new Point(9, 52);
                L1.AutoSize = true;
                L1.ForeColor = Color.White;
                L1.Text = "Numero de Mesa: " + re["Mesasactuales"].ToString();
                p.Controls.Add(L1);
                //BUtton
                Button btn = new Button();
                btn.Size = new Size(93, 28);
                btn.Location = new Point(70,88);
                btn.Text = "Eliminar";
                btn.ForeColor = Color.White;
                btn.Name = re["NombredErea"].ToString();
                btn.Click += new EventHandler(btn_Click);
                p.Controls.Add(btn);
               
                this.PanelM.Controls.Add(p);

                
            }


            //Nombre de la area





            //Aregar mesa 
           
            string conman2 = $"SELECT * FROM Areas";
            SqlCommand comando2 = new SqlCommand(conman2, con.Conexifon());
            SqlDataReader re2 = comando2.ExecuteReader();
          

        }


        private void btn_Click(object sender, EventArgs e) {

            Button BTN = sender as Button;
            MessageBox.Show("Seguro que quieres eliminarlo","Eliminar",MessageBoxButtons.OK);

            ConexionSQ.Conexion con = new ConexionSQ.Conexion();
            string conman = $"DELETE Areas WHERE NombredErea = '{BTN.Name}'";
            SqlCommand comando = new SqlCommand(conman, con.Conexifon());
            SqlDataReader re = comando.ExecuteReader();
            MessageBox.Show("Se elimino por completo", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.NombreMesa.Text == "" || CAPA.Value == 0)
            {
                MessageBox.Show("Completa los campos");


            }
            else {
                ConexionSQ.Conexion con = new ConexionSQ.Conexion();
                string conman = $"insert into Mesa (NombreMesa,Area,CapacidadOcupada,capacidadMaxima)values('{NombreMesa.Text}','{ComboArea.Text}',0,{CAPA.Value})";
                SqlCommand comando = new SqlCommand(conman, con.Conexifon());
                SqlDataReader re = comando.ExecuteReader();
                re.Read();

                string conman4 = $"update Areas set Mesasactuales = Mesasactuales + 1  where NombredErea = '{ComboArea.Text}'";
                SqlCommand comando4 = new SqlCommand(conman4, con.Conexifon());
                SqlDataReader re4 = comando4.ExecuteReader();
                re4.Read();

                MessageBox.Show("Se guardo la mesa");

                PanelM.Refresh();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            SubMenusFactura.SubMenuEnvios.ViewMesa viem = new SubMenusFactura.SubMenuEnvios.ViewMesa();
            viem.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var op = MessageBox.Show("Quieres eliminar esta mesa?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (op == DialogResult.OK) {
                    ConexionSQ.Conexion con = new ConexionSQ.Conexion();
                    string conman = $"delete mesa where NombreMesa = '{MesaEliminar.Text}' and Area = '{comboBoxArea.Text}'";
                    SqlCommand comando = new SqlCommand(conman, con.Conexifon());
                    SqlDataReader re = comando.ExecuteReader();
                    re.Read();
                    string conman4 = $"update Areas set Mesasactuales = Mesasactuales - 1  where NombredErea = '{comboBoxArea.Text}'";
                    SqlCommand comando4 = new SqlCommand(conman4, con.Conexifon());
                    SqlDataReader re4 = comando4.ExecuteReader();
                    re4.Read();
                    MessageBox.Show("Se elimino por completo","Eliminar",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("NO se ha encontrado una mesa con ese nombre");
            }
        }

        private void comboBoxArea_TextChanged(object sender, EventArgs e)
        {
            ConexionSQ.Conexion con = new ConexionSQ.Conexion();
            string conman2 = $"SELECT * FROM Mesa where Area ='{this.comboBoxArea.Text}'";
            SqlCommand comando2 = new SqlCommand(conman2, con.Conexifon());
            SqlDataReader re2 = comando2.ExecuteReader();
            while (re2.Read()) { 
            
                var mesar = re2["NombreMesa"].ToString();
                MesaEliminar.Items.Add(mesar);

            }
        }
    }
}
