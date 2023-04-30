using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
            this.CenterToParent(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AbrirMenu(object hija)
        {
            if (this.PanedlMadre.Controls.Count > 0)
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
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AbrirMenu(new SubmMenuAlamcen.herramientasAlma());
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            AbrirMenu(new SubmMenuAlamcen.ProducListo.ProductoListo());
        }
    }
}
