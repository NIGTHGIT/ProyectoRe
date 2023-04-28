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

namespace INICIO.SubMenusProducto
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexion a = new Conexion();
            string consukta = $"SELECT NombrePlatillo,PrecioProducto FROM dbo.Productos where CodigoProducto = '{CodigoSearh.Text}' ";
            SqlCommand comando = new SqlCommand(consukta,a.Conexifon());
            SqlDataReader redi = comando.ExecuteReader();
            if (redi.Read())
            {

                this.Nombre.Text =  redi["NombrePlatillo"].ToString();
                this.precio.Text = redi["PrecioProducto"].ToString() + "$";
                this.Modific.Enabled = true;
                this.Eiminr.Enabled = true;
                this.Mostrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("El producto no fue encontrado", "Encontrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModifyConsul asd = new ModifyConsul(this.CodigoSearh.Text);
            asd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          var s =   MessageBox.Show("Quieres eliminar este producto?? ", "Eliminar", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            if (s == DialogResult.Yes) {

                Conexion a = new Conexion();
                string a2 = $"DELETE dbo.Productos where CodigoProducto = '{CodigoSearh.Text}'";
                SqlCommand comando = new SqlCommand(a2, a.Conexifon());
                SqlDataReader redi = comando.ExecuteReader();
                redi.Read();
                
                    MessageBox.Show("Producto Eliminado", "Eliminar", MessageBoxButtons.OK);
                string c = "SELECT * FROM dbo.Productos";

                SqlDataAdapter adao = new SqlDataAdapter(c, "DATA SOURCE = .\\SQLEXPRESS ; DATABASE = RestaHurante ; integrated security = true ");
                SqlCommandBuilder A = new SqlCommandBuilder(adao);
                DataSet fl = new DataSet();

                adao.Fill(fl);
                this.DataViem.ReadOnly = false;
                this.DataViem.DataSource = fl.Tables[0];


            }


           
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
           
            string c = "SELECT * FROM dbo.Productos";
            Conexion cx = new Conexion();
            SqlDataAdapter adao = new SqlDataAdapter(c, "DATA SOURCE = .\\SQLEXPRESS ; DATABASE = RestaHurante ; integrated security = true ");
            SqlCommandBuilder A = new SqlCommandBuilder(adao);
            DataSet fl = new DataSet();

            adao.Fill(fl);
            this.DataViem.ReadOnly = false;
            this.DataViem.DataSource = fl.Tables[0];



            string Categoria = "select NombreDecategoria from dbo.CateogoriaAlimenticia";
            SqlCommand comandosend = new SqlCommand(Categoria,cx.Conexifon());
            SqlDataReader EjecutarComando = comandosend.ExecuteReader();
            while (EjecutarComando.Read())
            {
                this.Combo.Items.Add(EjecutarComando["NombreDecategoria"]);
            }


          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarProduc mos = new MostrarProduc(this.CodigoSearh.Text);
            mos.Show();

        }

        private void Combo_TextChanged(object sender, EventArgs e)
        {

            if(this.Combo.Text == "All")
            {
                string c = $"SELECT * FROM dbo.Productos";
                SqlDataAdapter adao = new SqlDataAdapter(c, "DATA SOURCE = .\\SQLEXPRESS ; DATABASE = RestaHurante ; integrated security = true ");
                SqlCommandBuilder A = new SqlCommandBuilder(adao);
                DataSet fl = new DataSet();

                adao.Fill(fl);
                this.DataViem.ReadOnly = false;
                this.DataViem.DataSource = fl.Tables[0];
            }
            else {
                try
                {
                    string c = $"SELECT * FROM dbo.Productos where CategoriaPlatillo = '{this.Combo.Text}'";
                    SqlDataAdapter adao = new SqlDataAdapter(c, "DATA SOURCE = .\\SQLEXPRESS ; DATABASE = RestaHurante ; integrated security = true ");
                    SqlCommandBuilder A = new SqlCommandBuilder(adao);
                    DataSet fl = new DataSet();

                    adao.Fill(fl);
                    this.DataViem.ReadOnly = false;
                    this.DataViem.DataSource = fl.Tables[0];
                }
                catch (Exception)
                {

                    MessageBox.Show("Elija una opcion correcta!!");
                }
            }

          
        }
    }
}
