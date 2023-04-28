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
using INICIO;
using System.Windows.Forms;

namespace INICIO.SubMenusFactura.SudmenudeFacturarFin
{
    public partial class Elegir : Form
    {
        public Elegir(string codigo)
        {
            InitializeComponent();
            this.CenterToParent();
            codigopass = codigo;
            Panel1.Dock = DockStyle.Fill;
        }
        private string codigopass;


        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.UtcNow.ToString("dd/MM/yy h:mm");

            //Abre la window de facturra ahora
            Conexion conex = new Conexion();
            string con = $"Insert into FacturaPendiente(NumeroOrdern, Estado, fechadeFact)values('{codigopass}', 'Pendiente', '{fecha}'); ";
            SqlCommand comadno = new SqlCommand(con, conex.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            ejecutar.Read();
            Facturar F = new Facturar(codigopass);
            F.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {



            string fecha = DateTime.UtcNow.ToString("dd/MM/yy h:mm");



            //Este le Agrega en la categoria pendiente
            Conexion conex = new Conexion();
            string con = $"Insert into FacturaPendiente(NumeroOrdern, Estado, fechadeFact)values('{codigopass}', 'Pendiente', '{fecha}'); ";
            SqlCommand comadno = new SqlCommand(con, conex.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            ejecutar.Read();
            
            Panel1.Visible = false;
            panel2.Dock = DockStyle.Fill;
            panel2.Visible = true;
           

        }

       

        private void Elegir_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
