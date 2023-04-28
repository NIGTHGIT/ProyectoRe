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
    public partial class Inicio : Form
    {
        Panel P = new Panel();
        int posx = 0;
        int posy = 0;

        private void btnsesor(object sensor , EventArgs e)
        {



            Button btn = sensor as Button;
            panelmenu.Controls.Add(P);
            P.BackColor = Color.FromArgb(90,210,2);
            P.Size = new Size(162, 5);
            P.Location = new Point(btn.Location.X, btn.Location.Y + 33);

            
        }





        private void quitarmenu(object jose, EventArgs e) {

            panel2.Visible = false;




        }

        private void btnsesornone(object sensor, EventArgs e)
        {
            panelmenu.Controls.Remove(P);


        }
        public Inicio()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else {
                panel2.Visible = true;
            }


        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;


            }
            else if (WindowState == FormWindowState.Maximized) {
                WindowState = FormWindowState.Normal;



            } else if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;

            }
           
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            Productos newProducto = new Productos();
            newProducto.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Factura er = new Factura();
            er.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado jose = new Empleado();
            jose.Show();
            this.Close();

        }

     
        private void panelmenu_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posx = e.Y;




            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Left + (e.Y - posy);


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion();
            config.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente ddd = new Cliente();
            ddd.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VIdeo ssss = new VIdeo();
           ssss.Show();
            this.Close();
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Almacen alma = new Almacen();
            alma.Show();

    

        }

        private void button12_Click(object sender, EventArgs e)
        {
            IA dddd = new IA();
            dddd.Show();
            this.Close();
        }
    }
}
