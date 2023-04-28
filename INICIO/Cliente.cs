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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Inicio ddd = new Inicio();
            ddd.Show();
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (panel2.AutoScroll == false)
            {
                panel2.AutoScroll = true;
            }
            else if (panel2.AutoScroll == true)
            {
                panel2.AutoScroll = false;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;



            }
            else if (WindowState == FormWindowState.Maximized) {
                WindowState =
                    FormWindowState.Normal;
            
            
            }
            else if(WindowState == FormWindowState.Normal){ }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                panel2.AutoScroll = true;


            }
            else if(WindowState == FormWindowState.Maximized) {
                MessageBox.Show("desplegado");
            
            }
        }
        int x = 0;
        int y = 0;
        private void panel3_DragLeave(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) {
                x = e.X;
                y = e.Y;
            
            }
            else
            {
                Left = Left + (e.X - x);
                Top = Top + (e.Y - y);


            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font tipo = new Font("GenericSansSerif", 20, FontStyle.Regular);
            Font tipo2 = new Font("GenericSansSerif", 15, FontStyle.Regular);


            string texto = "                        Host Restaurant          ";







            string texto2 = ".............................Grasia por tu compra......................";

            e.Graphics.DrawString(texto2, tipo2, Brushes.Black, 180, 1000);

            e.Graphics.DrawString(texto, tipo, Brushes.Black, 94, 44);









            //NOBRE DEL CLIENTE

            string NOBRE1 = $"Codigo : {textID.Text}  ";

            string Nombre = "    Nombre : jose alberto";

            e.Graphics.DrawString(NOBRE1, tipo, Brushes.DimGray, 45, 255);

            e.Graphics.DrawString(Nombre, tipo, Brushes.DimGray, 55, 289);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();

            
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
