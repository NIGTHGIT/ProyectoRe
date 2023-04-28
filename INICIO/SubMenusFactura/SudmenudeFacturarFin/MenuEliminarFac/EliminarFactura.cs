using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO.SubMenusFactura.SudmenudeFacturarFin.MenuEliminarFac
{
    public partial class EliminarFactura : Form
    {
        public EliminarFactura()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AbrirMenu(object hija)
        {
            if (this.panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }

            Form hijo = hija as Form;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(hijo);
            this.panel1.Tag = hijo;
            hijo.Show();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirMenu(new EliminarUna());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirMenu(new EliminarTodas());
        }

        private void EliminarFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
