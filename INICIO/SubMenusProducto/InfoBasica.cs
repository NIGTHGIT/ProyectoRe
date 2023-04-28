using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;
using INICIO.SubMenusProducto.AddCon;
using INICIO.ConexionSQ;

namespace INICIO.SubMenusProducto
{
    public partial class InfoBasica : Form
    {
        public InfoBasica()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InfoBasica_Load(object sender, EventArgs e)
        {
            var date = DateTime.UtcNow.ToString("dd/MM/yyyy");
            this.FechaActual.Text = date;


            Conexion cx = new Conexion();
            string Categoria = "select NombreDecategoria from dbo.CateogoriaAlimenticia";
            SqlCommand comandosend = new SqlCommand(Categoria, cx.Conexifon());
            SqlDataReader EjecutarComando = comandosend.ExecuteReader();
            while (EjecutarComando.Read())
            {
                CategoriaP.Items.Add(EjecutarComando["NombreDecategoria"]);
            }






        }

        //Generar el codigo del producto
        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
            Random CodigoNu = new Random();
            var n =  CodigoNu.Next(1000000, 90000000);



            CodigoTex.Text = "NGH-" + n.ToString();
            



        }

        private void DescripcionP_TextChanged(object sender, EventArgs e)
        {
            int i = DescripcionP.Text.Length;
            if( i > 500)
            {
                Count.ForeColor = Color.Red;
                button2.Enabled = false;
            }
            else
            {
                Count.ForeColor = Color.Green;
                button2.Enabled = true;
            }
            Count.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var Nombre = this.NombreP.Text;
            var Categoria = this.CategoriaP.Text;
            var Clafi = this.ClasifiP.Text;
            decimal Precio = Convert.ToDecimal(this.PrecioP.Text);
            decimal PesoN = Convert.ToDecimal(this.PesoN.Text);
            var Codigo = this.CodigoTex.Text;
            var fecha = this.FechaActual.Text;
            var Descripcion = this.DescripcionP.Text;
            if (VeriNumber() == true && TextValidate())
            {
                //Aqui se agrega el producto

                

                    AgregarProducto f = new AgregarProducto();
                    f.NombrePl1 = Nombre;
                    f.Categoria1 = Categoria;
                    f.Clasificacion1 = Clafi;
                    f.PrecioProducto = Precio;
                    f.PesoNeto1 = PesoN;
                    f.Codigo1 = Codigo;
                    f.Fecha1 = fecha;
                    f.Descripcion1 = Descripcion;
                    f.Add();
                    DialogResult a = MessageBox.Show("Se agrego exitosamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);

             


            }
            else
            {
                MessageBox.Show("Por favor llenar los datos requerido");
            }





        }

         private bool VeriNumber()
        {
            try
            {
                decimal Precio = Convert.ToDecimal(this.PrecioP.Text);
                decimal PesoN = Convert.ToDecimal(this.PesoN.Text);
                return true;
             
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede convertir a decimal");
                return false;

            }
        }

        private bool TextValidate()
        {
            if (this.NombreP.Text == "" || this.CategoriaP.Text == "" || this.ClasifiP.Text == "" || this.CodigoTex.Text == "") {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
