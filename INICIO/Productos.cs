using INICIO.SubMenusProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Configuration;
using System.Windows.Forms;

namespace INICIO
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }


        private void Abrir(object hija)
        {
            Form Conver = hija as Form;
            if(Panelmadre.Controls.Count > 0)
            {
                Panelmadre.Controls.RemoveAt(0);
            }
            Conver.TopLevel = false;
            Conver.Dock = DockStyle.Fill;
            Conver.FormBorderStyle = FormBorderStyle.None;
            Panelmadre.Controls.Add(Conver);
            Panelmadre.Tag = Conver;
            Conver.Show();




        }

        private void Productos_Load(object sender, EventArgs e)
        {
           
            var DATE = DateTime.UtcNow.ToString("dd/MM/yyyy");
            FEHCA.Text = DATE;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abrir(new Consultar());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir(new InfoBasica());
        }

        
        

        private void Productos_MouseMove(object sender, MouseEventArgs e)
        {


            int posx = 0;
            int posy=0;
           

            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;





            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);




            }
        }

        

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            max.Visible = false;
            min.Visible = true;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            min.Visible = false;
            max.Visible = true;
        }
    }
}
