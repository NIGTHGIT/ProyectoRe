using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INICIO.ConexionSQ;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INICIO.SubMenusProducto
{
    public partial class MostrarProduc : Form
    {
        public MostrarProduc(string codigo)
        {
            InitializeComponent();
            Co = codigo;
            this.CenterToScreen();

        }
        private string Co;
        private void MostrarProduc_Load(object sender, EventArgs e)
        {
            Conexion CONEXION = new Conexion();
            string con = $"SELECT * FROM dbo.Productos where CodigoProducto = '{Co}'";
            SqlCommand a = new SqlCommand(con,CONEXION.Conexifon());
            SqlDataReader redi = a.ExecuteReader();
            redi.Read();
            
                

                    this.Nombre.Text = redi["NombrePlatillo"].ToString();
                    this.Categoria.Text = redi["CategoriaPlatillo"].ToString();
                    this.Precio.Text = redi["PrecioProducto"].ToString() + "$";
                    this.PesoN.Text = redi["PesoNeto"].ToString() + "(g)";
                    this.Descip.Text = redi["DescripcionProducto"].ToString();
                    this.FechaIngre.Text = redi["FechaAdd"].ToString();
                    this.Clasifi.Text = redi["ClasificacionPlantillo"].ToString();
                
               
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
