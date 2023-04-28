using INICIO.SubMenusFactura.SuDMenuFactura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO.SubMenusFactura
{
    public partial class Facturar : Form
    {
        public Facturar(string CO)
        {
            InitializeComponent();
            DIGO = CO;
            this.CenterToScreen();
        } 
        private string DIGO;
        private void AbrirPanel(object Gija)
        {

            Form P = Gija as Form;

            if (PanelMadre2.Controls.Count > 0) {

                PanelMadre2.Controls.RemoveAt(0);
               
            }
            P.TopLevel = false;
            P.FormBorderStyle = FormBorderStyle.None;
            P.Dock = DockStyle.Fill;
            PanelMadre2.Controls.Add(P);
            PanelMadre2.Tag = P;
            P.Show();

        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Paypal());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Efectivo(DIGO));






        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Bancos());
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
