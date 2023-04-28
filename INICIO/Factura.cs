using INICIO.SubMenusFactura;
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
using INICIO.SubMenusFactura.SudmenudeFacturarFin;

namespace INICIO
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public  void AbrirMenu(object hija)
        {
            if(this.PanedlMadre.Controls.Count > 0)
            {
                PanedlMadre.Controls.RemoveAt(0);
            }

            Form hijo = hija as Form;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            this.PanedlMadre.Controls.Add(hijo);
            this.PanedlMadre.Tag = hijo;
            hijo.Show();



        }

        private string Codigo()
        {

            Random numeros = new Random();
            Random numerFin = new Random();
            var a = numeros.Next(1000000, 9000000);
            var b = numerFin.Next(0, 10);
            string Codigo = "NO-" + a.ToString() + "-" + b.ToString();





            return Codigo;
        }

        private string CoDIGO;
        private void button5_Click(object sender, EventArgs e)
        {
             

            
            
            But1.BackColor = Color.LightSeaGreen;
            this.button2.BackColor = Color.DarkSlateGray;
         
            this.button2.Enabled = true;
            this.But1.Enabled = true;
         
            CoDIGO = Codigo();
            AbrirMenu(new Seleccion(CoDIGO));
        }

     
        

        private void But1_Click(object sender, EventArgs e)
        {
            AbrirMenu(new Seleccion(CoDIGO));
            this.button2.BackColor = Color.DarkSlateGray;
            this.But1.BackColor = Color.LightSeaGreen;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirMenu(new Envio(CoDIGO));
            this.button2.BackColor = Color.LightSeaGreen;
            this.But1.BackColor = Color.DarkSlateGray;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.But1.BackColor = Color.DarkSlateGray;
            this.button2.BackColor = Color.DarkSlateGray;
           
            AbrirMenu(new Facturar(CoDIGO));
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            this.But1.Enabled = false;
           
        }
       
        private void button6_Click(object sender, EventArgs e)
        {

           
            FacturaPendding verPadin = new FacturaPendding();
            AbrirMenu(new FacturaPendding());

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
            AbrirMenu(new HomeFacture());
            this.But1.Enabled = false;
            button2.Enabled = false;
            this.But1.BackColor = Color.DarkSlateGray;
            this.button2.BackColor = Color.DarkSlateGray;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



                AbrirMenu(new HomeFacture());
                this.But1.Enabled = false;
                button2.Enabled = false;
                this.But1.BackColor = Color.DarkSlateGray;
                this.button2.BackColor = Color.DarkSlateGray;


           



        }
    }
}
