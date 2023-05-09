using INICIO.Empleados;
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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        int posx = 0;
        int posy = 0;



        private void Abrir(object hija)
        {
            Form Conver = hija as Form;
            if (panel4.Controls.Count > 0)
            {
                panel4.Controls.RemoveAt(0);
            }
            Conver.TopLevel = false;
            Conver.Dock = DockStyle.Fill;
            Conver.FormBorderStyle = FormBorderStyle.None;
           panel4.Controls.Add(Conver);
            panel4.Tag = Conver;
            Conver.Show();




        }

        private void Abrir2(object hija)
        {
            Form Conver = hija as Form;
            if (panel4.Controls.Count > 0)
            {
                panel4.Controls.RemoveAt(0);
            }
            Conver.TopLevel = false;
            Conver.Dock = DockStyle.Fill;
            Conver.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Add(Conver);
            panel4.Tag = Conver;
            Conver.Show();




        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Inicio SSS = new Inicio();
            SSS.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;

            }
            else if (WindowState == FormWindowState.Maximized)
            {

                WindowState = FormWindowState.Normal;


            }
            else if(WindowState == FormWindowState.Normal){

                WindowState = FormWindowState.Maximized;
                
            
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicio ddd = new Inicio();

            ddd.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir(new EMLEADOW());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TATERD asb = new TATERD();
            asb.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Renunciar asd = new Renunciar();
            asd.Show();
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) {
                posx = e.X;
                posy = e.Y;

            
            
            
            
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
           



            }
        }
    }
}
