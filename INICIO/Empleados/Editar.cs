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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void Abrir2(object hija)
        {
            Form Conver = hija as Form;
            if (c.Controls.Count > 0)
            {
                c.Controls.RemoveAt(0);
            }
            Conver.TopLevel = false;
            Conver.Dock = DockStyle.Fill;
            Conver.FormBorderStyle = FormBorderStyle.None;
            c.Controls.Add(Conver);
            c.Tag = Conver;
            Conver.Show();




        }


        int emdx = 0;
        int dddy = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {
                emdx = e.X;
                dddy = e.Y;

            }
            else {
                Left = Left + (e.X - emdx);
                Top = Top+(e.Y -dddy);
            
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (PANELmunu.Visible == false) {
                PANELmunu.Visible = true;
            
            
            }
            else {
                PANELmunu.Visible = false;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            Empleado ddd = new Empleado();
            ddd.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          Donar ddd = new  Donar();
            ddd.Show();
            this.Close();
        
        
        
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suplentes ddd = new Suplentes();
            ddd.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Opcion no esta disponiple Espere Que los admistradores Autorisen nuevas atualizaciones");
        }

        private void PANELmunu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //llamar el fromulario
            Configuracion fffp = new  Configuracion();

            //añadir padre
       
            //aceder al control
        



            fffp.Show();
            this.Close();
            






        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            Abrir2(   new edit());
        }
    }
}
