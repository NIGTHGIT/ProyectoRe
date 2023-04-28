using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INICIO.Empleados
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar sss = Owner as Editar;

            sss.pictureBox11.Visible = false;



        }

        int prox = 0;
        int proy = 0;


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {


            if (e.Button != MouseButtons.Left)
            {
                prox = e.X;
                proy = e.Y;


            }
            else {

                Left = Left + (e.X - prox);
                Top = Top + (e.Y - proy);
            
            
            
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Configuracion_Paint(object sender, PaintEventArgs e)

        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }
    }
}
