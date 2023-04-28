using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using INICIO.ConexionSQ;
using System.Windows.Forms;

namespace INICIO.subMANUSConfigura.AreaAndMESA
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }





        private void btn_Click(object sender, EventArgs e)
        {
            Conexion CON = new Conexion(); Button btn = sender as Button;

            var mes = MessageBox.Show("¿Quieres eliminar esta categoria?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); if (mes == DialogResult.OK)
            {
                string COMADNO = $"DELETE CateogoriaAlimenticia WHERE NombreDecategoria = '{btn.Text}'";
                SqlCommand comando = new SqlCommand(COMADNO, CON.Conexifon()); SqlDataReader Botoens = comando.ExecuteReader();
                Botoens.Read();
                string COMADNO4 = $"delete Productos where CategoriaPlatillo = '{btn.Text}'"; SqlCommand comando4 = new SqlCommand(COMADNO4, CON.Conexifon());
                SqlDataReader Botoens4 = comando4.ExecuteReader(); Botoens4.Read();



                Control.Controls.Clear();
                string COMADNO1 = "SELECT * FROM CateogoriaAlimenticia"; SqlCommand comando1 = new SqlCommand(COMADNO1, CON.Conexifon());
                SqlDataReader Botoens1 = comando1.ExecuteReader(); while (Botoens1.Read())
                {
                    Button btn1 = new Button(); btn1.Name = Botoens1["NombreDecategoria"].ToString();
                    btn1.Text = Botoens1["NombreDecategoria"].ToString(); btn1.FlatStyle = FlatStyle.Flat;
                    btn1.BackColor = Color.DarkBlue;
                    btn1.Size = new Size(104, 52);
                    btn1.ForeColor = Color.White; btn1.Click += new EventHandler(btn_Click);
                    this.Control.Controls.Add(btn1);

                }
            }
        }


    

        private void Categoria_Load_1(object sender, EventArgs e)
        {
            Conexion CON = new Conexion();
            string COMADNO = "SELECT * FROM CateogoriaAlimenticia"; SqlCommand comando = new SqlCommand(COMADNO, CON.Conexifon());
            SqlDataReader Botoens = comando.ExecuteReader(); while (Botoens.Read())
            {
                Button btn = new Button();
                btn.Name = Botoens["NombreDecategoria"].ToString(); btn.Text = Botoens["NombreDecategoria"].ToString();
                btn.FlatStyle = FlatStyle.Flat; btn.BackColor = Color.DarkCyan;
                btn.Size = new Size(104, 52); btn.ForeColor = Color.White;
                btn.Click += new EventHandler(btn_Click); this.Control.Controls.Add(btn);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion CON = new Conexion();
            var mes = MessageBox.Show("¿Quieres añadir esta categoria?", "Agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (mes == DialogResult.OK)
            {
                string COMADNO = $"insert into CateogoriaAlimenticia (NombreDecategoria)values('{cat.Text}')";
                SqlCommand comando = new SqlCommand(COMADNO, CON.Conexifon()); SqlDataReader Botoens = comando.ExecuteReader();
                Botoens.Read();
                Control.Controls.Clear();
                string COMADNO1 = "SELECT * FROM CateogoriaAlimenticia"; SqlCommand comando1 = new SqlCommand(COMADNO1, CON.Conexifon());
                SqlDataReader Botoens1 = comando1.ExecuteReader(); while (Botoens1.Read())
                {
                    Button btn1 = new Button(); btn1.Name = Botoens1["NombreDecategoria"].ToString();
                    btn1.Text = Botoens1["NombreDecategoria"].ToString();
                    btn1.FlatStyle = FlatStyle.Flat;
                    btn1.BackColor = Color.DarkCyan; btn1.Size = new Size(104, 52);
                    btn1.ForeColor = Color.White; btn1.Click += new EventHandler(btn_Click);
                    this.Control.Controls.Add(btn1);

                }
            }

        }
    }
}
