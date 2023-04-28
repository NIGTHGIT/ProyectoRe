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
using INICIO.SubMenusFactura.SudmenudeFacturarFin;

namespace INICIO.SubMenusFactura.SuDMenuFactura
{
    public partial class Efectivo : Form
    {
        public Efectivo(String DIGO)
        {
            InitializeComponent();
            CO = DIGO;
        }

        private string CO;

        private void MontoPagar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal Monto = Convert.ToDecimal(this.MontoPagar.Text);
                decimal MontoTotal = Convert.ToDecimal(this.MondoTotal.Text);
                decimal Devuelta = Monto - MontoTotal;
                this.Devuelta.Text = Devuelta.ToString();
            }
            catch (Exception)
            {

                error.SetError(this.MontoPagar, "Por favor instroducir el monto");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion a = new Conexion();
            string inert = $"INSERT INTO dbo.FactuarTotal(NumeroDeOrden, DescuentoAplicado, MontoApagar, Devuelta, PrecioTotal,PrecioBruto)values(' { CO }', ' { this.Descuento.Text }',  { Convert.ToDecimal(this.MontoPagar.Text) },  { Convert.ToDecimal(this.Devuelta.Text) },  { Convert.ToDecimal(this.MondoTotal.Text)}, { int.Parse(this.PrecioBruto.Text)})";
           
            SqlCommand con = new SqlCommand(inert,a.Conexifon());
            SqlDataReader redi = con.ExecuteReader();
            redi.Read();


          

            string inert2 = $"update Mesa set CapacidadOcupada = 0, NumOderOcupado = '' where NumOderOcupado = '{CO}'";

            SqlCommand con2 = new SqlCommand(inert2, a.Conexifon());
            SqlDataReader redi2 = con2.ExecuteReader();
            redi2.Read();

            //Este le Agrega en la categoria pendiente
            Conexion conex = new Conexion();
            string con3 = $"UPDATE FacturaPendiente set Estado = 'Facturado' where  NumeroOrdern = '{CO}'";
            SqlCommand comadno = new SqlCommand(con3, conex.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            ejecutar.Read();



            ViewFactura factura = new ViewFactura(CO,"Ver...");
            factura.Show();
            this.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            int a = int.Parse(Descuento.Text);

            decimal total = Convert.ToDecimal(MondoTotal.Text);
            this.Descuen.Text = a.ToString() + "%";
           

            if (a < 9) {

                string i = $"0.0{a}";
                var con = Convert.ToDecimal(i);

                var r = total * con;

               var r2 =  total - r;
                this.MondoTotal.Text = r2.ToString();

            }
            else
            {
                string i = $"0.{a}";
                var con = Convert.ToDecimal(i);

                var r = total * con;
                var r2 = total - r;
                this.MondoTotal.Text = r2.ToString();
            }








        }

        private void Efectivo_Load(object sender, EventArgs e)
        {
            Conexion a = new Conexion();
            
            string n = $"SELECT * FROM dbo.Factura where  NumeroDeOrden = '{this.CO}' ";
            SqlCommand con = new SqlCommand(n, a.Conexifon());
            SqlDataReader redi = con.ExecuteReader();
            int k = 0; 
            while (redi.Read())
            {
                 var o =  int.Parse(redi["PrecioTotal"].ToString());
                k += o;

            }
            this.MondoTotal.Text = k.ToString();
            this.PrecioBruto.Text = k.ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            var montoTOTL = this.PrecioBruto.Text;
            this.MondoTotal.Text = montoTOTL;
            this.Descuen.Text = "0%";
        }
    }
}
